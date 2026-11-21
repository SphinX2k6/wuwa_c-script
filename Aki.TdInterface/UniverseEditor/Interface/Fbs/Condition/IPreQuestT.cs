using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005194 RID: 20884
	public class IPreQuestT
	{
		// Token: 0x17009593 RID: 38291
		// (get) Token: 0x06020DDF RID: 134623 RVA: 0x0048C562 File Offset: 0x0048A762
		// (set) Token: 0x06020DE0 RID: 134624 RVA: 0x0048C56A File Offset: 0x0048A76A
		public EVisibleCondition Type { get; set; }

		// Token: 0x17009594 RID: 38292
		// (get) Token: 0x06020DE1 RID: 134625 RVA: 0x0048C573 File Offset: 0x0048A773
		// (set) Token: 0x06020DE2 RID: 134626 RVA: 0x0048C57B File Offset: 0x0048A77B
		public ECompare Compare { get; set; }

		// Token: 0x17009595 RID: 38293
		// (get) Token: 0x06020DE3 RID: 134627 RVA: 0x0048C584 File Offset: 0x0048A784
		// (set) Token: 0x06020DE4 RID: 134628 RVA: 0x0048C58C File Offset: 0x0048A78C
		public int PreQuestId { get; set; }

		// Token: 0x06020DE5 RID: 134629 RVA: 0x0048C595 File Offset: 0x0048A795
		public IPreQuestT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.PreQuestId = 0;
		}
	}
}
