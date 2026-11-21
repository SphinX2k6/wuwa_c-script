using System;
using System.Runtime.CompilerServices;

// Token: 0x02000457 RID: 1111
[NullableContext(1)]
public interface IFurnitureSceneItemPlaceContext
{
	// Token: 0x17000840 RID: 2112
	// (get) Token: 0x060039F7 RID: 14839
	IFurnitureAreaSlotContext AreaSlotContext { get; }

	// Token: 0x17000841 RID: 2113
	// (get) Token: 0x060039F8 RID: 14840
	int FurnitureId { get; }

	// Token: 0x17000842 RID: 2114
	// (get) Token: 0x060039F9 RID: 14841
	bool KeepSubFurniture { get; }
}
