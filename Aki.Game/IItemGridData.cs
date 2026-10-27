using System;

// Token: 0x020010AF RID: 4271
public interface IItemGridData
{
	// Token: 0x1700094D RID: 2381
	// (get) Token: 0x06006F2D RID: 28461
	// (set) Token: 0x06006F2E RID: 28462
	TItem Item { get; set; }

	// Token: 0x1700094E RID: 2382
	// (get) Token: 0x06006F2F RID: 28463
	// (set) Token: 0x06006F30 RID: 28464
	bool HasClaimed { get; set; }
}
