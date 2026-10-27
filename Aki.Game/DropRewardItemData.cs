using System;

// Token: 0x020027EA RID: 10218
public class DropRewardItemData : IDropRewardItemData, IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001B80 RID: 7040
	// (get) Token: 0x06014FA2 RID: 85922 RVA: 0x00551254 File Offset: 0x0054F454
	// (set) Token: 0x06014FA3 RID: 85923 RVA: 0x0055125C File Offset: 0x0054F45C
	public ERoleDevItemType Type { get; set; }

	// Token: 0x17001B81 RID: 7041
	// (get) Token: 0x06014FA4 RID: 85924 RVA: 0x00551265 File Offset: 0x0054F465
	// (set) Token: 0x06014FA5 RID: 85925 RVA: 0x0055126D File Offset: 0x0054F46D
	public int ItemId { get; set; }

	// Token: 0x17001B82 RID: 7042
	// (get) Token: 0x06014FA6 RID: 85926 RVA: 0x00551276 File Offset: 0x0054F476
	// (set) Token: 0x06014FA7 RID: 85927 RVA: 0x0055127E File Offset: 0x0054F47E
	public int Count { get; set; }

	// Token: 0x17001B83 RID: 7043
	// (get) Token: 0x06014FA8 RID: 85928 RVA: 0x00551287 File Offset: 0x0054F487
	// (set) Token: 0x06014FA9 RID: 85929 RVA: 0x0055128F File Offset: 0x0054F48F
	public bool HaveFinish { get; set; }
}
