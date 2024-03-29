﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.regex_strings
{
    public class IPv4AddressRegexString : RegexValidator
    {
        public IPv4AddressRegexString() : base(@"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}") { }
        public override string ToString() => "IPv4 Address";
    }
}
