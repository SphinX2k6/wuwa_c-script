using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x02004780 RID: 18304
	public interface IArea
	{
		// Token: 0x1700777F RID: 30591
		// (get) Token: 0x0602FE13 RID: 196115
		// (set) Token: 0x0602FE14 RID: 196116
		double MinX { get; set; }

		// Token: 0x17007780 RID: 30592
		// (get) Token: 0x0602FE15 RID: 196117
		// (set) Token: 0x0602FE16 RID: 196118
		double MaxX { get; set; }

		// Token: 0x17007781 RID: 30593
		// (get) Token: 0x0602FE17 RID: 196119
		// (set) Token: 0x0602FE18 RID: 196120
		double MinY { get; set; }

		// Token: 0x17007782 RID: 30594
		// (get) Token: 0x0602FE19 RID: 196121
		// (set) Token: 0x0602FE1A RID: 196122
		double MaxY { get; set; }
	}
}
