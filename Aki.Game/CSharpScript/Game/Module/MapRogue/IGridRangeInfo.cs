using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200457F RID: 17791
	public interface IGridRangeInfo
	{
		// Token: 0x17005A53 RID: 23123
		// (get) Token: 0x0602CD18 RID: 183576
		// (set) Token: 0x0602CD19 RID: 183577
		double CenterX { get; set; }

		// Token: 0x17005A54 RID: 23124
		// (get) Token: 0x0602CD1A RID: 183578
		// (set) Token: 0x0602CD1B RID: 183579
		double CenterY { get; set; }

		// Token: 0x17005A55 RID: 23125
		// (get) Token: 0x0602CD1C RID: 183580
		// (set) Token: 0x0602CD1D RID: 183581
		double RadiusX { get; set; }

		// Token: 0x17005A56 RID: 23126
		// (get) Token: 0x0602CD1E RID: 183582
		// (set) Token: 0x0602CD1F RID: 183583
		double RadiusY { get; set; }
	}
}
