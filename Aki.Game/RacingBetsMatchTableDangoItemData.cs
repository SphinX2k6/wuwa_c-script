using System;

// Token: 0x0200271B RID: 10011
public class RacingBetsMatchTableDangoItemData : IRacingBetsMatchTableDangoItemData
{
	// Token: 0x17001AEE RID: 6894
	// (get) Token: 0x06014842 RID: 84034 RVA: 0x0052E41F File Offset: 0x0052C61F
	// (set) Token: 0x06014843 RID: 84035 RVA: 0x0052E427 File Offset: 0x0052C627
	public int DangoId { get; set; }

	// Token: 0x17001AEF RID: 6895
	// (get) Token: 0x06014844 RID: 84036 RVA: 0x0052E430 File Offset: 0x0052C630
	// (set) Token: 0x06014845 RID: 84037 RVA: 0x0052E438 File Offset: 0x0052C638
	public bool IsNeedCheer { get; set; }

	// Token: 0x17001AF0 RID: 6896
	// (get) Token: 0x06014846 RID: 84038 RVA: 0x0052E441 File Offset: 0x0052C641
	// (set) Token: 0x06014847 RID: 84039 RVA: 0x0052E449 File Offset: 0x0052C649
	public bool IsMatchFinished { get; set; }

	// Token: 0x17001AF1 RID: 6897
	// (get) Token: 0x06014848 RID: 84040 RVA: 0x0052E452 File Offset: 0x0052C652
	// (set) Token: 0x06014849 RID: 84041 RVA: 0x0052E45A File Offset: 0x0052C65A
	public bool IsPromote { get; set; }

	// Token: 0x17001AF2 RID: 6898
	// (get) Token: 0x0601484A RID: 84042 RVA: 0x0052E463 File Offset: 0x0052C663
	// (set) Token: 0x0601484B RID: 84043 RVA: 0x0052E46B File Offset: 0x0052C66B
	public bool IsNeedPlayLevelSequence { get; set; }

	// Token: 0x17001AF3 RID: 6899
	// (get) Token: 0x0601484C RID: 84044 RVA: 0x0052E474 File Offset: 0x0052C674
	// (set) Token: 0x0601484D RID: 84045 RVA: 0x0052E47C File Offset: 0x0052C67C
	public bool IsCurMatch { get; set; }
}
