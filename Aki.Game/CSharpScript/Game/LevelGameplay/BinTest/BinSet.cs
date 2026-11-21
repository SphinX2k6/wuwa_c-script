using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BinTest
{
	// Token: 0x020060C2 RID: 24770
	public class BinSet
	{
		// Token: 0x0401F4E3 RID: 128227
		public int BinNum;

		// Token: 0x0401F4E4 RID: 128228
		public double MinX;

		// Token: 0x0401F4E5 RID: 128229
		public double MaxX;

		// Token: 0x0401F4E6 RID: 128230
		public double MaxY;

		// Token: 0x0401F4E7 RID: 128231
		public double DeltaY;

		// Token: 0x0401F4E8 RID: 128232
		public double ReciprocalDeltaY;

		// Token: 0x0401F4E9 RID: 128233
		[Nullable(1)]
		public List<Bin> Bins = new List<Bin>();

		// Token: 0x0401F4EA RID: 128234
		public double MinY;
	}
}
