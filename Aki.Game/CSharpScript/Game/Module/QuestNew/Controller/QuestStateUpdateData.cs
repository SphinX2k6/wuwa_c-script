using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuestNew.Controller
{
	// Token: 0x02004F9B RID: 20379
	[NullableContext(2)]
	[Nullable(0)]
	public class QuestStateUpdateData
	{
		// Token: 0x17007F69 RID: 32617
		// (get) Token: 0x060342F1 RID: 213745 RVA: 0x00C405F3 File Offset: 0x00C3E7F3
		// (set) Token: 0x060342F2 RID: 213746 RVA: 0x00C405FB File Offset: 0x00C3E7FB
		public int QuestId { get; set; }

		// Token: 0x17007F6A RID: 32618
		// (get) Token: 0x060342F3 RID: 213747 RVA: 0x00C40604 File Offset: 0x00C3E804
		// (set) Token: 0x060342F4 RID: 213748 RVA: 0x00C4060C File Offset: 0x00C3E80C
		public QuestState State { get; set; }

		// Token: 0x17007F6B RID: 32619
		// (get) Token: 0x060342F5 RID: 213749 RVA: 0x00C40615 File Offset: 0x00C3E815
		// (set) Token: 0x060342F6 RID: 213750 RVA: 0x00C4061D File Offset: 0x00C3E81D
		public EQuestStatusUpdateReason UpdateReason { get; set; }

		// Token: 0x17007F6C RID: 32620
		// (get) Token: 0x060342F7 RID: 213751 RVA: 0x00C40626 File Offset: 0x00C3E826
		// (set) Token: 0x060342F8 RID: 213752 RVA: 0x00C4062E File Offset: 0x00C3E82E
		public Action OnAfterUpdate { get; set; }
	}
}
