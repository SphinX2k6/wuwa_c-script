using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200445B RID: 17499
	public class IQuestScheduleChildQuestCompletedCountT
	{
		// Token: 0x17007966 RID: 31078
		// (get) Token: 0x060191EA RID: 102890 RVA: 0x003954F7 File Offset: 0x003936F7
		// (set) Token: 0x060191EB RID: 102891 RVA: 0x003954FF File Offset: 0x003936FF
		public EQuestScheduleType Type { get; set; }

		// Token: 0x17007967 RID: 31079
		// (get) Token: 0x060191EC RID: 102892 RVA: 0x00395508 File Offset: 0x00393708
		// (set) Token: 0x060191ED RID: 102893 RVA: 0x00395510 File Offset: 0x00393710
		public List<int> AssociatedChildQuestIds { get; set; }

		// Token: 0x060191EE RID: 102894 RVA: 0x00395519 File Offset: 0x00393719
		public IQuestScheduleChildQuestCompletedCountT()
		{
			this.Type = EQuestScheduleType.None;
			this.AssociatedChildQuestIds = null;
		}
	}
}
