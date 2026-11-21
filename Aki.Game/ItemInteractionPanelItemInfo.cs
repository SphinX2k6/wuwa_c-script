using System;

// Token: 0x02000D7E RID: 3454
public class ItemInteractionPanelItemInfo : IItemInteractionPanelItemInfo
{
	// Token: 0x17000F8A RID: 3978
	// (get) Token: 0x06008DF0 RID: 36336 RVA: 0x002ACAA1 File Offset: 0x002AACA1
	// (set) Token: 0x06008DF1 RID: 36337 RVA: 0x002ACAA9 File Offset: 0x002AACA9
	public int ItemConfigId { get; set; }

	// Token: 0x17000F8B RID: 3979
	// (get) Token: 0x06008DF2 RID: 36338 RVA: 0x002ACAB2 File Offset: 0x002AACB2
	// (set) Token: 0x06008DF3 RID: 36339 RVA: 0x002ACABA File Offset: 0x002AACBA
	public int CurrentCount { get; set; }

	// Token: 0x17000F8C RID: 3980
	// (get) Token: 0x06008DF4 RID: 36340 RVA: 0x002ACAC3 File Offset: 0x002AACC3
	// (set) Token: 0x06008DF5 RID: 36341 RVA: 0x002ACACB File Offset: 0x002AACCB
	public int? NeedCount { get; set; }
}
