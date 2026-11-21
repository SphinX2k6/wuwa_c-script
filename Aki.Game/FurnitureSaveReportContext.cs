using System;
using System.Runtime.CompilerServices;

// Token: 0x02000461 RID: 1121
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSaveReportContext : IFurnitureSaveReportContext
{
	// Token: 0x1700085C RID: 2140
	// (get) Token: 0x06003A23 RID: 14883 RVA: 0x0014CA60 File Offset: 0x0014AC60
	// (set) Token: 0x06003A24 RID: 14884 RVA: 0x0014CA68 File Offset: 0x0014AC68
	public int AreaId { get; set; }

	// Token: 0x1700085D RID: 2141
	// (get) Token: 0x06003A25 RID: 14885 RVA: 0x0014CA71 File Offset: 0x0014AC71
	// (set) Token: 0x06003A26 RID: 14886 RVA: 0x0014CA79 File Offset: 0x0014AC79
	public FurnitureAreaData OldAreaData { get; set; }

	// Token: 0x1700085E RID: 2142
	// (get) Token: 0x06003A27 RID: 14887 RVA: 0x0014CA82 File Offset: 0x0014AC82
	// (set) Token: 0x06003A28 RID: 14888 RVA: 0x0014CA8A File Offset: 0x0014AC8A
	public FurnitureAreaData NewAreaData { get; set; }

	// Token: 0x1700085F RID: 2143
	// (get) Token: 0x06003A29 RID: 14889 RVA: 0x0014CA93 File Offset: 0x0014AC93
	// (set) Token: 0x06003A2A RID: 14890 RVA: 0x0014CA9B File Offset: 0x0014AC9B
	public bool IsSave { get; set; }
}
