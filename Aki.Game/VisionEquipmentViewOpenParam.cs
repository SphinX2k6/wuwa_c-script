using System;

// Token: 0x020024FF RID: 9471
public class VisionEquipmentViewOpenParam : IVisionEquipmentViewOpenParam
{
	// Token: 0x170018CA RID: 6346
	// (get) Token: 0x0601309C RID: 77980 RVA: 0x004B6B22 File Offset: 0x004B4D22
	// (set) Token: 0x0601309D RID: 77981 RVA: 0x004B6B2A File Offset: 0x004B4D2A
	public int RoleId { get; set; }

	// Token: 0x170018CB RID: 6347
	// (get) Token: 0x0601309E RID: 77982 RVA: 0x004B6B33 File Offset: 0x004B4D33
	// (set) Token: 0x0601309F RID: 77983 RVA: 0x004B6B3B File Offset: 0x004B4D3B
	public int SelectIndex { get; set; }

	// Token: 0x170018CC RID: 6348
	// (get) Token: 0x060130A0 RID: 77984 RVA: 0x004B6B44 File Offset: 0x004B4D44
	// (set) Token: 0x060130A1 RID: 77985 RVA: 0x004B6B4C File Offset: 0x004B4D4C
	public ERoleViewSource? Source { get; set; }
}
