using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtk;
using GLib;

namespace HelloWorld {
    public class Program {
        static int Main(string[] args) {
            Application.Init();

            Window myWindow = new Window("My first GTK application!");
            myWindow.Resize(200, 200);
            myWindow.DeleteEvent += new DeleteEventHandler(Window_Delete);

            Label myLabel = new Label("Hello World");

            myWindow.Add(myLabel);

            myWindow.ShowAll();

            Application.Run();
            return 0;            
        }

        static void Window_Delete(object obj, DeleteEventArgs args) {
            SignalArgs signalArguments = (SignalArgs) args;
            Application.Quit();
            signalArguments.RetVal = true;
        }
    }
}
