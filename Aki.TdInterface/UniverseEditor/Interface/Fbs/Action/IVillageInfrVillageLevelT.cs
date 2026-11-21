using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D3E RID: 32062
	public class IVillageInfrVillageLevelT
	{
		// Token: 0x1700EFF6 RID: 61430
		// (get) Token: 0x06039E1A RID: 237082 RVA: 0x007CEDFC File Offset: 0x007CCFFC
		// (set) Token: 0x06039E1B RID: 237083 RVA: 0x007CEE04 File Offset: 0x007CD004
		public EVillageInfrBuildType Type { get; set; }

		// Token: 0x1700EFF7 RID: 61431
		// (get) Token: 0x06039E1C RID: 237084 RVA: 0x007CEE0D File Offset: 0x007CD00D
		// (set) Token: 0x06039E1D RID: 237085 RVA: 0x007CEE15 File Offset: 0x007CD015
		public int Level { get; set; }

		// Token: 0x06039E1E RID: 237086 RVA: 0x007CEE1E File Offset: 0x007CD01E
		public IVillageInfrVillageLevelT()
		{
			this.Type = EVillageInfrBuildType.Village;
			this.Level = 0;
		}
	}
}
