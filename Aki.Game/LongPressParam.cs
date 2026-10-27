using System;

// Token: 0x02002484 RID: 9348
public class LongPressParam : ILongPressParam
{
	// Token: 0x17001895 RID: 6293
	// (get) Token: 0x06012C18 RID: 76824 RVA: 0x004A030B File Offset: 0x0049E50B
	// (set) Token: 0x06012C19 RID: 76825 RVA: 0x004A0313 File Offset: 0x0049E513
	public float BeforeLongPressThreshold { get; set; }

	// Token: 0x17001896 RID: 6294
	// (get) Token: 0x06012C1A RID: 76826 RVA: 0x004A031C File Offset: 0x0049E51C
	// (set) Token: 0x06012C1B RID: 76827 RVA: 0x004A0324 File Offset: 0x0049E524
	public float LongPressThreshold { get; set; }

	// Token: 0x17001897 RID: 6295
	// (get) Token: 0x06012C1C RID: 76828 RVA: 0x004A032D File Offset: 0x0049E52D
	// (set) Token: 0x06012C1D RID: 76829 RVA: 0x004A0335 File Offset: 0x0049E535
	public float InvalidMoveDistance { get; set; }

	// Token: 0x17001898 RID: 6296
	// (get) Token: 0x06012C1E RID: 76830 RVA: 0x004A033E File Offset: 0x0049E53E
	// (set) Token: 0x06012C1F RID: 76831 RVA: 0x004A0346 File Offset: 0x0049E546
	public float OffsetX { get; set; }

	// Token: 0x17001899 RID: 6297
	// (get) Token: 0x06012C20 RID: 76832 RVA: 0x004A034F File Offset: 0x0049E54F
	// (set) Token: 0x06012C21 RID: 76833 RVA: 0x004A0357 File Offset: 0x0049E557
	public float OffsetY { get; set; }
}
