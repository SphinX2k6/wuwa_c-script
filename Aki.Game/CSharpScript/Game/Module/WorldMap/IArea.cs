using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036B1 RID: 14001
	public interface IArea
	{
		// Token: 0x17004A3B RID: 19003
		// (get) Token: 0x060245DE RID: 148958
		// (set) Token: 0x060245DF RID: 148959
		double MinX { get; set; }

		// Token: 0x17004A3C RID: 19004
		// (get) Token: 0x060245E0 RID: 148960
		// (set) Token: 0x060245E1 RID: 148961
		double MaxX { get; set; }

		// Token: 0x17004A3D RID: 19005
		// (get) Token: 0x060245E2 RID: 148962
		// (set) Token: 0x060245E3 RID: 148963
		double MinY { get; set; }

		// Token: 0x17004A3E RID: 19006
		// (get) Token: 0x060245E4 RID: 148964
		// (set) Token: 0x060245E5 RID: 148965
		double MaxY { get; set; }
	}
}
