using System;

// Token: 0x020027E8 RID: 10216
public class MaterialItemData : IMaterialItemData, IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001B7A RID: 7034
	// (get) Token: 0x06014F95 RID: 85909 RVA: 0x00551219 File Offset: 0x0054F419
	// (set) Token: 0x06014F96 RID: 85910 RVA: 0x00551221 File Offset: 0x0054F421
	public ERoleDevItemType Type { get; set; }

	// Token: 0x17001B7B RID: 7035
	// (get) Token: 0x06014F97 RID: 85911 RVA: 0x0055122A File Offset: 0x0054F42A
	// (set) Token: 0x06014F98 RID: 85912 RVA: 0x00551232 File Offset: 0x0054F432
	public int ItemId { get; set; }

	// Token: 0x17001B7C RID: 7036
	// (get) Token: 0x06014F99 RID: 85913 RVA: 0x0055123B File Offset: 0x0054F43B
	// (set) Token: 0x06014F9A RID: 85914 RVA: 0x00551243 File Offset: 0x0054F443
	public int RequiredCount { get; set; }
}
