using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051A9 RID: 20905
	public class IReachAreaCondtionT
	{
		// Token: 0x170095BE RID: 38334
		// (get) Token: 0x06020E91 RID: 134801 RVA: 0x0048D894 File Offset: 0x0048BA94
		// (set) Token: 0x06020E92 RID: 134802 RVA: 0x0048D89C File Offset: 0x0048BA9C
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x170095BF RID: 38335
		// (get) Token: 0x06020E93 RID: 134803 RVA: 0x0048D8A5 File Offset: 0x0048BAA5
		// (set) Token: 0x06020E94 RID: 134804 RVA: 0x0048D8AD File Offset: 0x0048BAAD
		public int RangeEntityId { get; set; }

		// Token: 0x06020E95 RID: 134805 RVA: 0x0048D8B6 File Offset: 0x0048BAB6
		public IReachAreaCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.RangeEntityId = 0;
		}
	}
}
