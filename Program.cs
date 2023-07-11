using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Username;
            Console.WriteLine("Enter User Name");
            Username = Console.ReadLine();
            if(Username.Length>=6)
            {
                Console.WriteLine("Welcome: \t" + Username);
            }
            else
            {
                Console.WriteLine("Invalid User Name");
            }
            Console.ReadKey();
        }
    }
}
