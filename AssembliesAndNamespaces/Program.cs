using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//faded out items above shows that these namespaces are not used in the program and
//they can be deleted and the program will still compile.

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //The purpose of a .NET assembly is to separate the programs into portions
            //will be loaded into memory. "Imagine if the .NET framework had to load
            //the whole library into memory just to use a small portion of it.

            //the references tab to the right has to do with the fact that we have references
            // to the .NET framework class library

            //namespace help developers tell the difference between different classes 
            //in cases where the same name was used in the massive .NET class library


            //the full name of the class is...
            System.Console.WriteLine("Hello World!");
            //because we used the "using" command up top, we don't have to type out "system"
            //"system" is a namespace

            //if a code snippet references an unknown assembly...click on it and 
            // type ctrl+. to get the options to add the correct using "..." statement



            Console.ReadKey();
        }
    }
}
