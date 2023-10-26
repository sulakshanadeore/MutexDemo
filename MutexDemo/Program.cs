using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MutexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Mutex m = new Mutex(false, "MutexTrial"))
            {

                if (!m.WaitOne(5000,false))
                {
                    Console.WriteLine("One instance is already running...");
                    Console.Read();
                    return;
                }
                Console.WriteLine("application is running");
                Console.ReadLine();
            }
            
        }
    }
}
