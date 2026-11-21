using System;
using Aki.Config;

// Token: 0x0200048E RID: 1166
public class FurnitureHandBookItemData : IFurnitureHandBookItemData
{
	// Token: 0x17000892 RID: 2194
	// (get) Token: 0x06003BCD RID: 15309 RVA: 0x001539B4 File Offset: 0x00151BB4
	// (set) Token: 0x06003BCE RID: 15310 RVA: 0x001539BC File Offset: 0x00151BBC
	public Furniture FurnitureConfig { get; set; }

	// Token: 0x17000893 RID: 2195
	// (get) Token: 0x06003BCF RID: 15311 RVA: 0x001539C5 File Offset: 0x00151BC5
	// (set) Token: 0x06003BD0 RID: 15312 RVA: 0x001539CD File Offset: 0x00151BCD
	public bool IsLock { get; set; }

	// Token: 0x17000894 RID: 2196
	// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x001539D6 File Offset: 0x00151BD6
	// (set) Token: 0x06003BD2 RID: 15314 RVA: 0x001539DE File Offset: 0x00151BDE
	public bool RedDotVisible { get; set; }
}
