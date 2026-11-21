using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D0 RID: 16848
	public class IConditionTextT
	{
		// Token: 0x170072CB RID: 29387
		// (get) Token: 0x060175EC RID: 95724 RVA: 0x00357606 File Offset: 0x00355806
		// (set) Token: 0x060175ED RID: 95725 RVA: 0x0035760E File Offset: 0x0035580E
		public IConditionGroupT Condition { get; set; }

		// Token: 0x170072CC RID: 29388
		// (get) Token: 0x060175EE RID: 95726 RVA: 0x00357617 File Offset: 0x00355817
		// (set) Token: 0x060175EF RID: 95727 RVA: 0x0035761F File Offset: 0x0035581F
		public string TidTitle { get; set; }

		// Token: 0x170072CD RID: 29389
		// (get) Token: 0x060175F0 RID: 95728 RVA: 0x00357628 File Offset: 0x00355828
		// (set) Token: 0x060175F1 RID: 95729 RVA: 0x00357630 File Offset: 0x00355830
		public TQuestScheduleUnion QuestScheduleType { get; set; }

		// Token: 0x170072CE RID: 29390
		// (get) Token: 0x060175F2 RID: 95730 RVA: 0x00357639 File Offset: 0x00355839
		// (set) Token: 0x060175F3 RID: 95731 RVA: 0x00357641 File Offset: 0x00355841
		public IProgressBarT ProgressBar { get; set; }

		// Token: 0x060175F4 RID: 95732 RVA: 0x0035764A File Offset: 0x0035584A
		public IConditionTextT()
		{
			this.Condition = null;
			this.TidTitle = null;
			this.QuestScheduleType = null;
			this.ProgressBar = null;
		}
	}
}
