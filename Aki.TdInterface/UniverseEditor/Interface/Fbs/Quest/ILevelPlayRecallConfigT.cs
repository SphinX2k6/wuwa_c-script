using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F00 RID: 16128
	public class ILevelPlayRecallConfigT
	{
		// Token: 0x17006FE0 RID: 28640
		// (get) Token: 0x06016D4C RID: 93516 RVA: 0x0034AF3B File Offset: 0x0034913B
		// (set) Token: 0x06016D4D RID: 93517 RVA: 0x0034AF43 File Offset: 0x00349143
		public int RecallId { get; set; }

		// Token: 0x17006FE1 RID: 28641
		// (get) Token: 0x06016D4E RID: 93518 RVA: 0x0034AF4C File Offset: 0x0034914C
		// (set) Token: 0x06016D4F RID: 93519 RVA: 0x0034AF54 File Offset: 0x00349154
		public List<int> RecallEntityList { get; set; }

		// Token: 0x06016D50 RID: 93520 RVA: 0x0034AF5D File Offset: 0x0034915D
		public ILevelPlayRecallConfigT()
		{
			this.RecallId = 0;
			this.RecallEntityList = null;
		}
	}
}
