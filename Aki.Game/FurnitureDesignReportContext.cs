using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FAA RID: 4010
[NullableContext(1)]
[Nullable(0)]
public class FurnitureDesignReportContext : IFurnitureDesignReportContext
{
	// Token: 0x17000831 RID: 2097
	// (get) Token: 0x0600667C RID: 26236 RVA: 0x0014416F File Offset: 0x0014236F
	// (set) Token: 0x0600667D RID: 26237 RVA: 0x00144177 File Offset: 0x00142377
	public int AreaId { get; set; }

	// Token: 0x17000832 RID: 2098
	// (get) Token: 0x0600667E RID: 26238 RVA: 0x00144180 File Offset: 0x00142380
	// (set) Token: 0x0600667F RID: 26239 RVA: 0x00144188 File Offset: 0x00142388
	public EFurnitureDesignReportOperationType OperationType { get; set; }

	// Token: 0x17000833 RID: 2099
	// (get) Token: 0x06006680 RID: 26240 RVA: 0x00144191 File Offset: 0x00142391
	// (set) Token: 0x06006681 RID: 26241 RVA: 0x00144199 File Offset: 0x00142399
	public IFurnitureSlotContext SlotContext { get; set; }

	// Token: 0x17000834 RID: 2100
	// (get) Token: 0x06006682 RID: 26242 RVA: 0x001441A2 File Offset: 0x001423A2
	// (set) Token: 0x06006683 RID: 26243 RVA: 0x001441AA File Offset: 0x001423AA
	public int? OldFurnitureId { get; set; }

	// Token: 0x17000835 RID: 2101
	// (get) Token: 0x06006684 RID: 26244 RVA: 0x001441B3 File Offset: 0x001423B3
	// (set) Token: 0x06006685 RID: 26245 RVA: 0x001441BB File Offset: 0x001423BB
	public int? NewFurnitureId { get; set; }
}
