using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FA2 RID: 4002
[NullableContext(1)]
public interface IFurnitureSceneItemPlaceContext
{
	// Token: 0x1700081E RID: 2078
	// (get) Token: 0x0600665F RID: 26207
	IFurnitureAreaSlotContext AreaSlotContext { get; }

	// Token: 0x1700081F RID: 2079
	// (get) Token: 0x06006660 RID: 26208
	int FurnitureId { get; }

	// Token: 0x17000820 RID: 2080
	// (get) Token: 0x06006661 RID: 26209
	bool KeepSubFurniture { get; }
}
