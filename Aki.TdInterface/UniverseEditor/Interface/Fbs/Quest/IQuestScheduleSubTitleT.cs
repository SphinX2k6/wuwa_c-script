using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200403B RID: 16443
	public class IQuestScheduleSubTitleT
	{
		// Token: 0x170073B4 RID: 29620
		// (get) Token: 0x06017CCA RID: 97482 RVA: 0x0036F32A File Offset: 0x0036D52A
		// (set) Token: 0x06017CCB RID: 97483 RVA: 0x0036F332 File Offset: 0x0036D532
		public string TidTitle { get; set; }

		// Token: 0x170073B5 RID: 29621
		// (get) Token: 0x06017CCC RID: 97484 RVA: 0x0036F33B File Offset: 0x0036D53B
		// (set) Token: 0x06017CCD RID: 97485 RVA: 0x0036F343 File Offset: 0x0036D543
		public TQuestScheduleUnion QuestScheduleType { get; set; }

		// Token: 0x170073B6 RID: 29622
		// (get) Token: 0x06017CCE RID: 97486 RVA: 0x0036F34C File Offset: 0x0036D54C
		// (set) Token: 0x06017CCF RID: 97487 RVA: 0x0036F354 File Offset: 0x0036D554
		public IConditionGroupT ShowConditions { get; set; }

		// Token: 0x170073B7 RID: 29623
		// (get) Token: 0x06017CD0 RID: 97488 RVA: 0x0036F35D File Offset: 0x0036D55D
		// (set) Token: 0x06017CD1 RID: 97489 RVA: 0x0036F365 File Offset: 0x0036D565
		public int CustomIcon { get; set; }

		// Token: 0x170073B8 RID: 29624
		// (get) Token: 0x06017CD2 RID: 97490 RVA: 0x0036F36E File Offset: 0x0036D56E
		// (set) Token: 0x06017CD3 RID: 97491 RVA: 0x0036F376 File Offset: 0x0036D576
		public IProgressBarT ProgressBar { get; set; }

		// Token: 0x170073B9 RID: 29625
		// (get) Token: 0x06017CD4 RID: 97492 RVA: 0x0036F37F File Offset: 0x0036D57F
		// (set) Token: 0x06017CD5 RID: 97493 RVA: 0x0036F387 File Offset: 0x0036D587
		public List<IConditionTextT> ConditionText { get; set; }

		// Token: 0x170073BA RID: 29626
		// (get) Token: 0x06017CD6 RID: 97494 RVA: 0x0036F390 File Offset: 0x0036D590
		// (set) Token: 0x06017CD7 RID: 97495 RVA: 0x0036F398 File Offset: 0x0036D598
		public bool BlankTitleStillShow { get; set; }

		// Token: 0x170073BB RID: 29627
		// (get) Token: 0x06017CD8 RID: 97496 RVA: 0x0036F3A1 File Offset: 0x0036D5A1
		// (set) Token: 0x06017CD9 RID: 97497 RVA: 0x0036F3A9 File Offset: 0x0036D5A9
		public List<ICustomPlaceholderBindingProgressT> CustomPlaceholderBindingProgressList { get; set; }

		// Token: 0x170073BC RID: 29628
		// (get) Token: 0x06017CDA RID: 97498 RVA: 0x0036F3B2 File Offset: 0x0036D5B2
		// (set) Token: 0x06017CDB RID: 97499 RVA: 0x0036F3BA File Offset: 0x0036D5BA
		public byte NullMask { get; set; }

		// Token: 0x06017CDC RID: 97500 RVA: 0x0036F3C4 File Offset: 0x0036D5C4
		public IQuestScheduleSubTitleT()
		{
			this.TidTitle = null;
			this.QuestScheduleType = null;
			this.ShowConditions = null;
			this.CustomIcon = 0;
			this.ProgressBar = null;
			this.ConditionText = null;
			this.BlankTitleStillShow = false;
			this.CustomPlaceholderBindingProgressList = null;
			this.NullMask = 0;
		}
	}
}
