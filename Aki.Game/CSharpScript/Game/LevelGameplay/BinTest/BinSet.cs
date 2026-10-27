using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BinTest
{
	// Token: 0x02006F41 RID: 28481
	public class BinSet
	{
		// Token: 0x0402422E RID: 148014
		public int BinNum;

		// Token: 0x0402422F RID: 148015
		public double MinX;

		// Token: 0x04024230 RID: 148016
		public double MaxX;

		// Token: 0x04024231 RID: 148017
		public double MaxY;

		// Token: 0x04024232 RID: 148018
		public double DeltaY;

		// Token: 0x04024233 RID: 148019
		public double ReciprocalDeltaY;

		// Token: 0x04024234 RID: 148020
		[Nullable(1)]
		public List<Bin> Bins = new List<Bin>();

		// Token: 0x04024235 RID: 148021
		public double MinY;
	}
}
