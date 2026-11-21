using System;

// Token: 0x02001D63 RID: 7523
public class MaterialItemData : IMaterialItemData, IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001BD2 RID: 7122
	// (get) Token: 0x06012995 RID: 76181 RVA: 0x0057BF89 File Offset: 0x0057A189
	// (set) Token: 0x06012996 RID: 76182 RVA: 0x0057BF91 File Offset: 0x0057A191
	public ERoleDevItemType Type { get; set; }

	// Token: 0x17001BD3 RID: 7123
	// (get) Token: 0x06012997 RID: 76183 RVA: 0x0057BF9A File Offset: 0x0057A19A
	// (set) Token: 0x06012998 RID: 76184 RVA: 0x0057BFA2 File Offset: 0x0057A1A2
	public int ItemId { get; set; }

	// Token: 0x17001BD4 RID: 7124
	// (get) Token: 0x06012999 RID: 76185 RVA: 0x0057BFAB File Offset: 0x0057A1AB
	// (set) Token: 0x0601299A RID: 76186 RVA: 0x0057BFB3 File Offset: 0x0057A1B3
	public int RequiredCount { get; set; }
}
