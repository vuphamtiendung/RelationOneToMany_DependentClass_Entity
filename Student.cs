﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EFCoreStepByStep_006
{
    // Dependent Class
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public Grade Grade { get; set; } // Reference
    }
}
