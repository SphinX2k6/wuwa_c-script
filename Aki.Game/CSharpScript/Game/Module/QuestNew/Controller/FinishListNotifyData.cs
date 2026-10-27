using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestNew.Controller
{
	// Token: 0x02004F99 RID: 20377
	[NullableContext(1)]
	[Nullable(0)]
	public class FinishListNotifyData
	{
		// Token: 0x17007F63 RID: 32611
		// (get) Token: 0x060342E3 RID: 213731 RVA: 0x00C40572 File Offset: 0x00C3E772
		// (set) Token: 0x060342E4 RID: 213732 RVA: 0x00C4057A File Offset: 0x00C3E77A
		public List<int> QuestIds { get; set; } = new List<int>();

		// Token: 0x17007F64 RID: 32612
		// (get) Token: 0x060342E5 RID: 213733 RVA: 0x00C40583 File Offset: 0x00C3E783
		// (set) Token: 0x060342E6 RID: 213734 RVA: 0x00C4058B File Offset: 0x00C3E78B
		public EEventName EmitEventName { get; set; }

		// Token: 0x17007F65 RID: 32613
		// (get) Token: 0x060342E7 RID: 213735 RVA: 0x00C40594 File Offset: 0x00C3E794
		// (set) Token: 0x060342E8 RID: 213736 RVA: 0x00C4059C File Offset: 0x00C3E79C
		[Nullable(2)]
		public Action TryChangeTrackedQuest { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
