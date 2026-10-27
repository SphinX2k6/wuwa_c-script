using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F9E RID: 3998
[NullableContext(1)]
public interface IFurnitureAreaSlotContext
{
	// Token: 0x17000816 RID: 2070
	// (get) Token: 0x06006651 RID: 26193
	FurnitureAreaData AreaData { get; }

	// Token: 0x17000817 RID: 2071
	// (get) Token: 0x06006652 RID: 26194
	IFurnitureSlotContext SlotContext { get; }
}
