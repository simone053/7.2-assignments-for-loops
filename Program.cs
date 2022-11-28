using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_assignments_for_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a message, and I'll display it five times.");
            Console.WriteLine("Message: ");
            String messages = Console.ReadLine();
            for (int i = -10; i <= 10; i = i + 2)
            {
                Console.WriteLine(i + ". " + messages);
            }
            Console.ReadLine();

            // Assignment 1: Blast off//
            Console.WriteLine("Count down the rocket ship blast with me.");
            String message = Console.ReadLine();
            Console.WriteLine();
            for (int i = 10; i >= 0;i = i - 1)
            {
                if (i == 0)
                    message = " Blast off!";
                    Console.WriteLine(i + message);
                    
            }
            Console.ReadLine();
            // Assignment 2: X and Y //
            Console.WriteLine("X    Y");
            for (int i = -10; i<= 10; i = i + 2)
            {
             Console.WriteLine(i + "\t" + i * i);
            }
            //Assignment 3: For Loop fun//
            Console.WriteLine("What's your name?");
            string name;
            for (int n = 10; n<= 1; n = n + 1 )
            {
            
                    
            }

            
        }
    }
}
