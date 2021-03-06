﻿using assignment03;
using System;
using System.Windows.Forms;
 
namespace assignment03
{
	public class Program : ChaosEngine
	{

		public Program()
		{
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left) rupee.TargetX -= 30;
			if (e.KeyCode == Keys.Right) rupee.TargetX += 30;
			if (e.KeyCode == Keys.Up) rupee.TargetY -= 30;
			if (e.KeyCode == Keys.Down) rupee.TargetY += 30;
			Console.WriteLine(rupee.TargetX);
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			rupee.TargetX = 50;
			rupee.TargetY = 50;
			rupee.Velocity = 5;
			Program.parent.Add(rupee);
			Application.Run(new Program());
		}
	}
}