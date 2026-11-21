using System;
using System.Runtime.CompilerServices;

// Token: 0x02000453 RID: 1107
[NullableContext(1)]
public interface IFurnitureAreaSlotContext
{
	// Token: 0x17000838 RID: 2104
	// (get) Token: 0x060039E9 RID: 14825
	FurnitureAreaData AreaData { get; }

	// Token: 0x17000839 RID: 2105
	// (get) Token: 0x060039EA RID: 14826
	IFurnitureSlotContext SlotContext { get; }
}
