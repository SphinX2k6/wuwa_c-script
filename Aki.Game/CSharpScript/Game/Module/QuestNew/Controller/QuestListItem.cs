using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuestNew.Controller
{
	// Token: 0x02003F63 RID: 16227
	public class QuestListItem
	{
		// Token: 0x17005316 RID: 21270
		// (get) Token: 0x06029158 RID: 168280 RVA: 0x00B89D64 File Offset: 0x00B87F64
		// (set) Token: 0x06029159 RID: 168281 RVA: 0x00B89D6C File Offset: 0x00B87F6C
		public int QuestId { get; set; }

		// Token: 0x17005317 RID: 21271
		// (get) Token: 0x0602915A RID: 168282 RVA: 0x00B89D75 File Offset: 0x00B87F75
		// (set) Token: 0x0602915B RID: 168283 RVA: 0x00B89D7D File Offset: 0x00B87F7D
		public QuestState State { get; set; }

		// Token: 0x17005318 RID: 21272
		// (get) Token: 0x0602915C RID: 168284 RVA: 0x00B89D86 File Offset: 0x00B87F86
		// (set) Token: 0x0602915D RID: 168285 RVA: 0x00B89D8E File Offset: 0x00B87F8E
		public EQuestStatusUpdateReason UpdateReason { get; set; }
	}
}
