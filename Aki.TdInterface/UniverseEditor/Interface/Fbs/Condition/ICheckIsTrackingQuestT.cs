using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F75 RID: 20341
	public class ICheckIsTrackingQuestT
	{
		// Token: 0x1700916A RID: 37226
		// (get) Token: 0x0601FAB3 RID: 129715 RVA: 0x00467326 File Offset: 0x00465526
		// (set) Token: 0x0601FAB4 RID: 129716 RVA: 0x0046732E File Offset: 0x0046552E
		public ECondition Type { get; set; }

		// Token: 0x1700916B RID: 37227
		// (get) Token: 0x0601FAB5 RID: 129717 RVA: 0x00467337 File Offset: 0x00465537
		// (set) Token: 0x0601FAB6 RID: 129718 RVA: 0x0046733F File Offset: 0x0046553F
		public int QuestId { get; set; }

		// Token: 0x1700916C RID: 37228
		// (get) Token: 0x0601FAB7 RID: 129719 RVA: 0x00467348 File Offset: 0x00465548
		// (set) Token: 0x0601FAB8 RID: 129720 RVA: 0x00467350 File Offset: 0x00465550
		public bool IsTracking { get; set; }

		// Token: 0x0601FAB9 RID: 129721 RVA: 0x00467359 File Offset: 0x00465559
		public ICheckIsTrackingQuestT()
		{
			this.Type = ECondition.CompareVar;
			this.QuestId = 0;
			this.IsTracking = false;
		}
	}
}
