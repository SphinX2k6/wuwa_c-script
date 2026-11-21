using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000469 RID: 1129
[NullableContext(1)]
[Nullable(0)]
public class SceneSlotItemInfo : ISceneSlotItemInfo
{
	// Token: 0x17000864 RID: 2148
	// (get) Token: 0x06003A96 RID: 14998 RVA: 0x0014E6B2 File Offset: 0x0014C8B2
	// (set) Token: 0x06003A97 RID: 14999 RVA: 0x0014E6BA File Offset: 0x0014C8BA
	public int SlotEntityId { get; set; }

	// Token: 0x17000865 RID: 2149
	// (get) Token: 0x06003A98 RID: 15000 RVA: 0x0014E6C3 File Offset: 0x0014C8C3
	// (set) Token: 0x06003A99 RID: 15001 RVA: 0x0014E6CB File Offset: 0x0014C8CB
	[Nullable(2)]
	public FurnitureSceneItemBase RootFurnitureSceneItem { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000866 RID: 2150
	// (get) Token: 0x06003A9A RID: 15002 RVA: 0x0014E6D4 File Offset: 0x0014C8D4
	// (set) Token: 0x06003A9B RID: 15003 RVA: 0x0014E6DC File Offset: 0x0014C8DC
	public Dictionary<int, FurnitureSceneItemBase> SubFurnitureSceneItemMap { get; set; } = new Dictionary<int, FurnitureSceneItemBase>();
}
