using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F1 RID: 16881
	public class IDarkTideHecatePollutionBossEventT
	{
		// Token: 0x170072FA RID: 29434
		// (get) Token: 0x060176DE RID: 95966 RVA: 0x0035904E File Offset: 0x0035724E
		// (set) Token: 0x060176DF RID: 95967 RVA: 0x00359056 File Offset: 0x00357256
		public EDarkTideBossEventType Type { get; set; }

		// Token: 0x060176E0 RID: 95968 RVA: 0x0035905F File Offset: 0x0035725F
		public IDarkTideHecatePollutionBossEventT()
		{
			this.Type = EDarkTideBossEventType.XinjilemuChase;
		}
	}
}
