using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D9 RID: 18649
	public class IDartCompetitorStrategiesT
	{
		// Token: 0x170081E8 RID: 33256
		// (get) Token: 0x0601B9B3 RID: 113075 RVA: 0x003E753A File Offset: 0x003E573A
		// (set) Token: 0x0601B9B4 RID: 113076 RVA: 0x003E7542 File Offset: 0x003E5742
		public int Mode301Strategy { get; set; }

		// Token: 0x170081E9 RID: 33257
		// (get) Token: 0x0601B9B5 RID: 113077 RVA: 0x003E754B File Offset: 0x003E574B
		// (set) Token: 0x0601B9B6 RID: 113078 RVA: 0x003E7553 File Offset: 0x003E5753
		public int Mode501Strategy { get; set; }

		// Token: 0x170081EA RID: 33258
		// (get) Token: 0x0601B9B7 RID: 113079 RVA: 0x003E755C File Offset: 0x003E575C
		// (set) Token: 0x0601B9B8 RID: 113080 RVA: 0x003E7564 File Offset: 0x003E5764
		public int Mode701Strategy { get; set; }

		// Token: 0x0601B9B9 RID: 113081 RVA: 0x003E756D File Offset: 0x003E576D
		public IDartCompetitorStrategiesT()
		{
			this.Mode301Strategy = 0;
			this.Mode501Strategy = 0;
			this.Mode701Strategy = 0;
		}
	}
}
