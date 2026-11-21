using System;
using System.Runtime.CompilerServices;

// Token: 0x0200045F RID: 1119
[NullableContext(1)]
[Nullable(0)]
public class FurnitureDesignReportContext : IFurnitureDesignReportContext
{
	// Token: 0x17000853 RID: 2131
	// (get) Token: 0x06003A14 RID: 14868 RVA: 0x0014CA03 File Offset: 0x0014AC03
	// (set) Token: 0x06003A15 RID: 14869 RVA: 0x0014CA0B File Offset: 0x0014AC0B
	public int AreaId { get; set; }

	// Token: 0x17000854 RID: 2132
	// (get) Token: 0x06003A16 RID: 14870 RVA: 0x0014CA14 File Offset: 0x0014AC14
	// (set) Token: 0x06003A17 RID: 14871 RVA: 0x0014CA1C File Offset: 0x0014AC1C
	public EFurnitureDesignReportOperationType OperationType { get; set; }

	// Token: 0x17000855 RID: 2133
	// (get) Token: 0x06003A18 RID: 14872 RVA: 0x0014CA25 File Offset: 0x0014AC25
	// (set) Token: 0x06003A19 RID: 14873 RVA: 0x0014CA2D File Offset: 0x0014AC2D
	public IFurnitureSlotContext SlotContext { get; set; }

	// Token: 0x17000856 RID: 2134
	// (get) Token: 0x06003A1A RID: 14874 RVA: 0x0014CA36 File Offset: 0x0014AC36
	// (set) Token: 0x06003A1B RID: 14875 RVA: 0x0014CA3E File Offset: 0x0014AC3E
	public int? OldFurnitureId { get; set; }

	// Token: 0x17000857 RID: 2135
	// (get) Token: 0x06003A1C RID: 14876 RVA: 0x0014CA47 File Offset: 0x0014AC47
	// (set) Token: 0x06003A1D RID: 14877 RVA: 0x0014CA4F File Offset: 0x0014AC4F
	public int? NewFurnitureId { get; set; }
}
