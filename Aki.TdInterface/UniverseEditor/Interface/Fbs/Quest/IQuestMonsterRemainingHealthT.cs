using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF9 RID: 16377
	public class IQuestMonsterRemainingHealthT
	{
		// Token: 0x17007311 RID: 29457
		// (get) Token: 0x060179EB RID: 96747 RVA: 0x003686CF File Offset: 0x003668CF
		// (set) Token: 0x060179EC RID: 96748 RVA: 0x003686D7 File Offset: 0x003668D7
		public EStatisticsEventType Type { get; set; }

		// Token: 0x17007312 RID: 29458
		// (get) Token: 0x060179ED RID: 96749 RVA: 0x003686E0 File Offset: 0x003668E0
		// (set) Token: 0x060179EE RID: 96750 RVA: 0x003686E8 File Offset: 0x003668E8
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007313 RID: 29459
		// (get) Token: 0x060179EF RID: 96751 RVA: 0x003686F1 File Offset: 0x003668F1
		// (set) Token: 0x060179F0 RID: 96752 RVA: 0x003686F9 File Offset: 0x003668F9
		public int EntityId { get; set; }

		// Token: 0x17007314 RID: 29460
		// (get) Token: 0x060179F1 RID: 96753 RVA: 0x00368702 File Offset: 0x00366902
		// (set) Token: 0x060179F2 RID: 96754 RVA: 0x0036870A File Offset: 0x0036690A
		public bool IsStatisticsAdd { get; set; }

		// Token: 0x060179F3 RID: 96755 RVA: 0x00368713 File Offset: 0x00366913
		public IQuestMonsterRemainingHealthT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.EntityId = 0;
			this.IsStatisticsAdd = false;
		}
	}
}
