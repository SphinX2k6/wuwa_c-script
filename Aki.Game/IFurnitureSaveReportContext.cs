using System;
using System.Runtime.CompilerServices;

// Token: 0x02000460 RID: 1120
[NullableContext(1)]
public interface IFurnitureSaveReportContext
{
	// Token: 0x17000858 RID: 2136
	// (get) Token: 0x06003A1F RID: 14879
	int AreaId { get; }

	// Token: 0x17000859 RID: 2137
	// (get) Token: 0x06003A20 RID: 14880
	FurnitureAreaData OldAreaData { get; }

	// Token: 0x1700085A RID: 2138
	// (get) Token: 0x06003A21 RID: 14881
	FurnitureAreaData NewAreaData { get; }

	// Token: 0x1700085B RID: 2139
	// (get) Token: 0x06003A22 RID: 14882
	bool IsSave { get; }
}
