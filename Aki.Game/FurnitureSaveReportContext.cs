using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FAC RID: 4012
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSaveReportContext : IFurnitureSaveReportContext
{
	// Token: 0x1700083A RID: 2106
	// (get) Token: 0x0600668B RID: 26251 RVA: 0x001441CC File Offset: 0x001423CC
	// (set) Token: 0x0600668C RID: 26252 RVA: 0x001441D4 File Offset: 0x001423D4
	public int AreaId { get; set; }

	// Token: 0x1700083B RID: 2107
	// (get) Token: 0x0600668D RID: 26253 RVA: 0x001441DD File Offset: 0x001423DD
	// (set) Token: 0x0600668E RID: 26254 RVA: 0x001441E5 File Offset: 0x001423E5
	public FurnitureAreaData OldAreaData { get; set; }

	// Token: 0x1700083C RID: 2108
	// (get) Token: 0x0600668F RID: 26255 RVA: 0x001441EE File Offset: 0x001423EE
	// (set) Token: 0x06006690 RID: 26256 RVA: 0x001441F6 File Offset: 0x001423F6
	public FurnitureAreaData NewAreaData { get; set; }

	// Token: 0x1700083D RID: 2109
	// (get) Token: 0x06006691 RID: 26257 RVA: 0x001441FF File Offset: 0x001423FF
	// (set) Token: 0x06006692 RID: 26258 RVA: 0x00144207 File Offset: 0x00142407
	public bool IsSave { get; set; }
}
