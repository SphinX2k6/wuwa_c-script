using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000468 RID: 1128
[NullableContext(1)]
public interface ISceneSlotItemInfo
{
	// Token: 0x17000861 RID: 2145
	// (get) Token: 0x06003A90 RID: 14992
	// (set) Token: 0x06003A91 RID: 14993
	int SlotEntityId { get; set; }

	// Token: 0x17000862 RID: 2146
	// (get) Token: 0x06003A92 RID: 14994
	// (set) Token: 0x06003A93 RID: 14995
	[Nullable(2)]
	FurnitureSceneItemBase RootFurnitureSceneItem { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000863 RID: 2147
	// (get) Token: 0x06003A94 RID: 14996
	// (set) Token: 0x06003A95 RID: 14997
	Dictionary<int, FurnitureSceneItemBase> SubFurnitureSceneItemMap { get; set; }
}
