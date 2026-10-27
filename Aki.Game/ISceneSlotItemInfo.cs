using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000FB3 RID: 4019
[NullableContext(1)]
public interface ISceneSlotItemInfo
{
	// Token: 0x1700083F RID: 2111
	// (get) Token: 0x060066F8 RID: 26360
	// (set) Token: 0x060066F9 RID: 26361
	int SlotEntityId { get; set; }

	// Token: 0x17000840 RID: 2112
	// (get) Token: 0x060066FA RID: 26362
	// (set) Token: 0x060066FB RID: 26363
	[Nullable(2)]
	FurnitureSceneItemBase RootFurnitureSceneItem { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000841 RID: 2113
	// (get) Token: 0x060066FC RID: 26364
	// (set) Token: 0x060066FD RID: 26365
	Dictionary<int, FurnitureSceneItemBase> SubFurnitureSceneItemMap { get; set; }
}
