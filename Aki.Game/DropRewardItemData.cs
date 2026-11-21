using System;

// Token: 0x02001D65 RID: 7525
public class DropRewardItemData : IDropRewardItemData, IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001BD8 RID: 7128
	// (get) Token: 0x060129A2 RID: 76194 RVA: 0x0057BFC4 File Offset: 0x0057A1C4
	// (set) Token: 0x060129A3 RID: 76195 RVA: 0x0057BFCC File Offset: 0x0057A1CC
	public ERoleDevItemType Type { get; set; }

	// Token: 0x17001BD9 RID: 7129
	// (get) Token: 0x060129A4 RID: 76196 RVA: 0x0057BFD5 File Offset: 0x0057A1D5
	// (set) Token: 0x060129A5 RID: 76197 RVA: 0x0057BFDD File Offset: 0x0057A1DD
	public int ItemId { get; set; }

	// Token: 0x17001BDA RID: 7130
	// (get) Token: 0x060129A6 RID: 76198 RVA: 0x0057BFE6 File Offset: 0x0057A1E6
	// (set) Token: 0x060129A7 RID: 76199 RVA: 0x0057BFEE File Offset: 0x0057A1EE
	public int Count { get; set; }

	// Token: 0x17001BDB RID: 7131
	// (get) Token: 0x060129A8 RID: 76200 RVA: 0x0057BFF7 File Offset: 0x0057A1F7
	// (set) Token: 0x060129A9 RID: 76201 RVA: 0x0057BFFF File Offset: 0x0057A1FF
	public bool HaveFinish { get; set; }
}
