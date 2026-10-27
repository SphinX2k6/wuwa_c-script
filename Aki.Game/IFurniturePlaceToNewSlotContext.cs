using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FA0 RID: 4000
[NullableContext(1)]
public interface IFurniturePlaceToNewSlotContext
{
	// Token: 0x1700081A RID: 2074
	// (get) Token: 0x06006658 RID: 26200
	IFurnitureAreaSlotContext SourceContext { get; }

	// Token: 0x1700081B RID: 2075
	// (get) Token: 0x06006659 RID: 26201
	IFurnitureAreaSlotContext TargetContext { get; }
}
