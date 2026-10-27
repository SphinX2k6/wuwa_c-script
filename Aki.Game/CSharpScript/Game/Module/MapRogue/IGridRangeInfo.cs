using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055A9 RID: 21929
	public interface IGridRangeInfo
	{
		// Token: 0x1700868C RID: 34444
		// (get) Token: 0x06037E1A RID: 228890
		// (set) Token: 0x06037E1B RID: 228891
		double CenterX { get; set; }

		// Token: 0x1700868D RID: 34445
		// (get) Token: 0x06037E1C RID: 228892
		// (set) Token: 0x06037E1D RID: 228893
		double CenterY { get; set; }

		// Token: 0x1700868E RID: 34446
		// (get) Token: 0x06037E1E RID: 228894
		// (set) Token: 0x06037E1F RID: 228895
		double RadiusX { get; set; }

		// Token: 0x1700868F RID: 34447
		// (get) Token: 0x06037E20 RID: 228896
		// (set) Token: 0x06037E21 RID: 228897
		double RadiusY { get; set; }
	}
}
