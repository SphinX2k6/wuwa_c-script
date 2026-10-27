using System;

// Token: 0x0200172A RID: 5930
public class RefineAttrItemData : IRefineAttrItemData
{
	// Token: 0x17000E26 RID: 3622
	// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x00267C8F File Offset: 0x00265E8F
	// (set) Token: 0x0600AB55 RID: 43861 RVA: 0x00267C97 File Offset: 0x00265E97
	public int PropItemId { get; set; }

	// Token: 0x17000E27 RID: 3623
	// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x00267CA0 File Offset: 0x00265EA0
	// (set) Token: 0x0600AB57 RID: 43863 RVA: 0x00267CA8 File Offset: 0x00265EA8
	public int PropIndexId { get; set; }

	// Token: 0x17000E28 RID: 3624
	// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x00267CB1 File Offset: 0x00265EB1
	// (set) Token: 0x0600AB59 RID: 43865 RVA: 0x00267CB9 File Offset: 0x00265EB9
	public bool IsRecommend { get; set; }

	// Token: 0x17000E29 RID: 3625
	// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x00267CC2 File Offset: 0x00265EC2
	// (set) Token: 0x0600AB5B RID: 43867 RVA: 0x00267CCA File Offset: 0x00265ECA
	public bool IsDisable { get; set; }
}
