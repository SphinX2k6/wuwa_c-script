using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FAB RID: 4011
[NullableContext(1)]
public interface IFurnitureSaveReportContext
{
	// Token: 0x17000836 RID: 2102
	// (get) Token: 0x06006687 RID: 26247
	int AreaId { get; }

	// Token: 0x17000837 RID: 2103
	// (get) Token: 0x06006688 RID: 26248
	FurnitureAreaData OldAreaData { get; }

	// Token: 0x17000838 RID: 2104
	// (get) Token: 0x06006689 RID: 26249
	FurnitureAreaData NewAreaData { get; }

	// Token: 0x17000839 RID: 2105
	// (get) Token: 0x0600668A RID: 26250
	bool IsSave { get; }
}
