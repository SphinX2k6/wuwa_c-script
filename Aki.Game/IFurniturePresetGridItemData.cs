using System;
using Aki.Config;

// Token: 0x02000493 RID: 1171
public interface IFurniturePresetGridItemData
{
	// Token: 0x17000895 RID: 2197
	// (get) Token: 0x06003BEC RID: 15340
	// (set) Token: 0x06003BED RID: 15341
	Furniture FurnitureConfig { get; set; }

	// Token: 0x17000896 RID: 2198
	// (get) Token: 0x06003BEE RID: 15342
	// (set) Token: 0x06003BEF RID: 15343
	bool IsLock { get; set; }

	// Token: 0x17000897 RID: 2199
	// (get) Token: 0x06003BF0 RID: 15344
	// (set) Token: 0x06003BF1 RID: 15345
	bool IsFinished { get; set; }
}
