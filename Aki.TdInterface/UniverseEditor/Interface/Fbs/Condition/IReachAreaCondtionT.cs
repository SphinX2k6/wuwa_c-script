using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CB0 RID: 19632
	public class IReachAreaCondtionT
	{
		// Token: 0x17008E90 RID: 36496
		// (get) Token: 0x0601F26F RID: 127599 RVA: 0x00459D44 File Offset: 0x00457F44
		// (set) Token: 0x0601F270 RID: 127600 RVA: 0x00459D4C File Offset: 0x00457F4C
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008E91 RID: 36497
		// (get) Token: 0x0601F271 RID: 127601 RVA: 0x00459D55 File Offset: 0x00457F55
		// (set) Token: 0x0601F272 RID: 127602 RVA: 0x00459D5D File Offset: 0x00457F5D
		public int RangeEntityId { get; set; }

		// Token: 0x0601F273 RID: 127603 RVA: 0x00459D66 File Offset: 0x00457F66
		public IReachAreaCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.RangeEntityId = 0;
		}
	}
}
