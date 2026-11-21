using System;
using System.Runtime.CompilerServices;

// Token: 0x02000455 RID: 1109
[NullableContext(1)]
public interface IFurniturePlaceToNewSlotContext
{
	// Token: 0x1700083C RID: 2108
	// (get) Token: 0x060039F0 RID: 14832
	IFurnitureAreaSlotContext SourceContext { get; }

	// Token: 0x1700083D RID: 2109
	// (get) Token: 0x060039F1 RID: 14833
	IFurnitureAreaSlotContext TargetContext { get; }
}
