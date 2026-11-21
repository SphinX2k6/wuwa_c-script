using System;
using Aki.Config;

// Token: 0x02000494 RID: 1172
public class FurniturePresetGridItemData : IFurniturePresetGridItemData
{
	// Token: 0x17000898 RID: 2200
	// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x00154064 File Offset: 0x00152264
	// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x0015406C File Offset: 0x0015226C
	public Furniture FurnitureConfig { get; set; }

	// Token: 0x17000899 RID: 2201
	// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x00154075 File Offset: 0x00152275
	// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x0015407D File Offset: 0x0015227D
	public bool IsLock { get; set; }

	// Token: 0x1700089A RID: 2202
	// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x00154086 File Offset: 0x00152286
	// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x0015408E File Offset: 0x0015228E
	public bool IsFinished { get; set; }
}
