using System;
using Aki.Config;

// Token: 0x0200048D RID: 1165
public interface IFurnitureHandBookItemData
{
	// Token: 0x1700088F RID: 2191
	// (get) Token: 0x06003BC7 RID: 15303
	// (set) Token: 0x06003BC8 RID: 15304
	Furniture FurnitureConfig { get; set; }

	// Token: 0x17000890 RID: 2192
	// (get) Token: 0x06003BC9 RID: 15305
	// (set) Token: 0x06003BCA RID: 15306
	bool IsLock { get; set; }

	// Token: 0x17000891 RID: 2193
	// (get) Token: 0x06003BCB RID: 15307
	// (set) Token: 0x06003BCC RID: 15308
	bool RedDotVisible { get; set; }
}
