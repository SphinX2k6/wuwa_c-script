using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuestNew.Controller
{
	// Token: 0x02004F9A RID: 20378
	public class QuestListItem
	{
		// Token: 0x17007F66 RID: 32614
		// (get) Token: 0x060342EA RID: 213738 RVA: 0x00C405B8 File Offset: 0x00C3E7B8
		// (set) Token: 0x060342EB RID: 213739 RVA: 0x00C405C0 File Offset: 0x00C3E7C0
		public int QuestId { get; set; }

		// Token: 0x17007F67 RID: 32615
		// (get) Token: 0x060342EC RID: 213740 RVA: 0x00C405C9 File Offset: 0x00C3E7C9
		// (set) Token: 0x060342ED RID: 213741 RVA: 0x00C405D1 File Offset: 0x00C3E7D1
		public QuestState State { get; set; }

		// Token: 0x17007F68 RID: 32616
		// (get) Token: 0x060342EE RID: 213742 RVA: 0x00C405DA File Offset: 0x00C3E7DA
		// (set) Token: 0x060342EF RID: 213743 RVA: 0x00C405E2 File Offset: 0x00C3E7E2
		public EQuestStatusUpdateReason UpdateReason { get; set; }
	}
}
