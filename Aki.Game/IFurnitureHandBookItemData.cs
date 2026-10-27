using System;
using Aki.Config;

// Token: 0x02000FD8 RID: 4056
public interface IFurnitureHandBookItemData
{
	// Token: 0x1700086D RID: 2157
	// (get) Token: 0x0600682F RID: 26671
	// (set) Token: 0x06006830 RID: 26672
	Furniture FurnitureConfig { get; set; }

	// Token: 0x1700086E RID: 2158
	// (get) Token: 0x06006831 RID: 26673
	// (set) Token: 0x06006832 RID: 26674
	bool IsLock { get; set; }

	// Token: 0x1700086F RID: 2159
	// (get) Token: 0x06006833 RID: 26675
	// (set) Token: 0x06006834 RID: 26676
	bool RedDotVisible { get; set; }
}
