using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005197 RID: 20887
	public class IPreQuestCondtionT
	{
		// Token: 0x17009599 RID: 38297
		// (get) Token: 0x06020DF7 RID: 134647 RVA: 0x0048C794 File Offset: 0x0048A994
		// (set) Token: 0x06020DF8 RID: 134648 RVA: 0x0048C79C File Offset: 0x0048A99C
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x1700959A RID: 38298
		// (get) Token: 0x06020DF9 RID: 134649 RVA: 0x0048C7A5 File Offset: 0x0048A9A5
		// (set) Token: 0x06020DFA RID: 134650 RVA: 0x0048C7AD File Offset: 0x0048A9AD
		public int PreQuest { get; set; }

		// Token: 0x06020DFB RID: 134651 RVA: 0x0048C7B6 File Offset: 0x0048A9B6
		public IPreQuestCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.PreQuest = 0;
		}
	}
}
