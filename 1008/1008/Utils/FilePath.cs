﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1008.Utils
{
	public static class FilePath
	{
		public static string GetFullPath(string filename)
		{
			return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", filename);
		}
	}
}
