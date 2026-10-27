using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BA8 RID: 19368
	public class ICompareFishingTechLevelT
	{
		// Token: 0x17008C99 RID: 35993
		// (get) Token: 0x0601E8B4 RID: 125108 RVA: 0x00446024 File Offset: 0x00444224
		// (set) Token: 0x0601E8B5 RID: 125109 RVA: 0x0044602C File Offset: 0x0044422C
		public ECondition Type { get; set; }

		// Token: 0x17008C9A RID: 35994
		// (get) Token: 0x0601E8B6 RID: 125110 RVA: 0x00446035 File Offset: 0x00444235
		// (set) Token: 0x0601E8B7 RID: 125111 RVA: 0x0044603D File Offset: 0x0044423D
		public int TechId { get; set; }

		// Token: 0x17008C9B RID: 35995
		// (get) Token: 0x0601E8B8 RID: 125112 RVA: 0x00446046 File Offset: 0x00444246
		// (set) Token: 0x0601E8B9 RID: 125113 RVA: 0x0044604E File Offset: 0x0044424E
		public ECompare Compare { get; set; }

		// Token: 0x17008C9C RID: 35996
		// (get) Token: 0x0601E8BA RID: 125114 RVA: 0x00446057 File Offset: 0x00444257
		// (set) Token: 0x0601E8BB RID: 125115 RVA: 0x0044605F File Offset: 0x0044425F
		public int TechLevel { get; set; }

		// Token: 0x0601E8BC RID: 125116 RVA: 0x00446068 File Offset: 0x00444268
		public ICompareFishingTechLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.TechId = 0;
			this.Compare = ECompare.Eq;
			this.TechLevel = 0;
		}
	}
}
