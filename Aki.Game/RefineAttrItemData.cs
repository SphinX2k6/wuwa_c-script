using System;

// Token: 0x02000BE2 RID: 3042
public class RefineAttrItemData : IRefineAttrItemData
{
	// Token: 0x17000E47 RID: 3655
	// (get) Token: 0x06007F36 RID: 32566 RVA: 0x00272067 File Offset: 0x00270267
	// (set) Token: 0x06007F37 RID: 32567 RVA: 0x0027206F File Offset: 0x0027026F
	public int PropItemId { get; set; }

	// Token: 0x17000E48 RID: 3656
	// (get) Token: 0x06007F38 RID: 32568 RVA: 0x00272078 File Offset: 0x00270278
	// (set) Token: 0x06007F39 RID: 32569 RVA: 0x00272080 File Offset: 0x00270280
	public int PropIndexId { get; set; }

	// Token: 0x17000E49 RID: 3657
	// (get) Token: 0x06007F3A RID: 32570 RVA: 0x00272089 File Offset: 0x00270289
	// (set) Token: 0x06007F3B RID: 32571 RVA: 0x00272091 File Offset: 0x00270291
	public bool IsRecommend { get; set; }

	// Token: 0x17000E4A RID: 3658
	// (get) Token: 0x06007F3C RID: 32572 RVA: 0x0027209A File Offset: 0x0027029A
	// (set) Token: 0x06007F3D RID: 32573 RVA: 0x002720A2 File Offset: 0x002702A2
	public bool IsDisable { get; set; }
}
