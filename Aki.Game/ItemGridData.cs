using System;

// Token: 0x020010B0 RID: 4272
public class ItemGridData : IItemGridData
{
	// Token: 0x1700094F RID: 2383
	// (get) Token: 0x06006F31 RID: 28465 RVA: 0x0016B5A4 File Offset: 0x001697A4
	// (set) Token: 0x06006F32 RID: 28466 RVA: 0x0016B5AC File Offset: 0x001697AC
	public TItem Item { get; set; }

	// Token: 0x17000950 RID: 2384
	// (get) Token: 0x06006F33 RID: 28467 RVA: 0x0016B5B5 File Offset: 0x001697B5
	// (set) Token: 0x06006F34 RID: 28468 RVA: 0x0016B5BD File Offset: 0x001697BD
	public bool HasClaimed { get; set; }
}
