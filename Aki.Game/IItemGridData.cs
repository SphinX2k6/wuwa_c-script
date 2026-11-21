using System;

// Token: 0x02000563 RID: 1379
public interface IItemGridData
{
	// Token: 0x1700096D RID: 2413
	// (get) Token: 0x060042C3 RID: 17091
	// (set) Token: 0x060042C4 RID: 17092
	TItem Item { get; set; }

	// Token: 0x1700096E RID: 2414
	// (get) Token: 0x060042C5 RID: 17093
	// (set) Token: 0x060042C6 RID: 17094
	bool HasClaimed { get; set; }
}
