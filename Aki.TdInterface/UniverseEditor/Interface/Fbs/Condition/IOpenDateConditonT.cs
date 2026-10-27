using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C6B RID: 19563
	public class IOpenDateConditonT
	{
		// Token: 0x17008E17 RID: 36375
		// (get) Token: 0x0601F051 RID: 127057 RVA: 0x00456430 File Offset: 0x00454630
		// (set) Token: 0x0601F052 RID: 127058 RVA: 0x00456438 File Offset: 0x00454638
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008E18 RID: 36376
		// (get) Token: 0x0601F053 RID: 127059 RVA: 0x00456441 File Offset: 0x00454641
		// (set) Token: 0x0601F054 RID: 127060 RVA: 0x00456449 File Offset: 0x00454649
		public int DateId { get; set; }

		// Token: 0x17008E19 RID: 36377
		// (get) Token: 0x0601F055 RID: 127061 RVA: 0x00456452 File Offset: 0x00454652
		// (set) Token: 0x0601F056 RID: 127062 RVA: 0x0045645A File Offset: 0x0045465A
		public EQuestOpenDateType OpenType { get; set; }

		// Token: 0x17008E1A RID: 36378
		// (get) Token: 0x0601F057 RID: 127063 RVA: 0x00456463 File Offset: 0x00454663
		// (set) Token: 0x0601F058 RID: 127064 RVA: 0x0045646B File Offset: 0x0045466B
		public byte NullMask { get; set; }

		// Token: 0x0601F059 RID: 127065 RVA: 0x00456474 File Offset: 0x00454674
		public IOpenDateConditonT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.DateId = 0;
			this.OpenType = EQuestOpenDateType.AfterBeginTime;
			this.NullMask = 0;
		}
	}
}
