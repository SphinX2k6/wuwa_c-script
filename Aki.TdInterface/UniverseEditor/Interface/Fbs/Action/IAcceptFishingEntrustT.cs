using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200606F RID: 24687
	public class IAcceptFishingEntrustT
	{
		// Token: 0x1700B5EB RID: 46571
		// (get) Token: 0x06029CDE RID: 171230 RVA: 0x005BC622 File Offset: 0x005BA822
		// (set) Token: 0x06029CDF RID: 171231 RVA: 0x005BC62A File Offset: 0x005BA82A
		public int EntrustId { get; set; }

		// Token: 0x1700B5EC RID: 46572
		// (get) Token: 0x06029CE0 RID: 171232 RVA: 0x005BC633 File Offset: 0x005BA833
		// (set) Token: 0x06029CE1 RID: 171233 RVA: 0x005BC63B File Offset: 0x005BA83B
		public bool IsAutoTracking { get; set; }

		// Token: 0x1700B5ED RID: 46573
		// (get) Token: 0x06029CE2 RID: 171234 RVA: 0x005BC644 File Offset: 0x005BA844
		// (set) Token: 0x06029CE3 RID: 171235 RVA: 0x005BC64C File Offset: 0x005BA84C
		public byte NullMask { get; set; }

		// Token: 0x06029CE4 RID: 171236 RVA: 0x005BC655 File Offset: 0x005BA855
		public IAcceptFishingEntrustT()
		{
			this.EntrustId = 0;
			this.IsAutoTracking = false;
			this.NullMask = 0;
		}
	}
}
