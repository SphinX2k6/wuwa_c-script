using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000FB4 RID: 4020
[NullableContext(1)]
[Nullable(0)]
public class SceneSlotItemInfo : ISceneSlotItemInfo
{
	// Token: 0x17000842 RID: 2114
	// (get) Token: 0x060066FE RID: 26366 RVA: 0x00145DEE File Offset: 0x00143FEE
	// (set) Token: 0x060066FF RID: 26367 RVA: 0x00145DF6 File Offset: 0x00143FF6
	public int SlotEntityId { get; set; }

	// Token: 0x17000843 RID: 2115
	// (get) Token: 0x06006700 RID: 26368 RVA: 0x00145DFF File Offset: 0x00143FFF
	// (set) Token: 0x06006701 RID: 26369 RVA: 0x00145E07 File Offset: 0x00144007
	[Nullable(2)]
	public FurnitureSceneItemBase RootFurnitureSceneItem { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000844 RID: 2116
	// (get) Token: 0x06006702 RID: 26370 RVA: 0x00145E10 File Offset: 0x00144010
	// (set) Token: 0x06006703 RID: 26371 RVA: 0x00145E18 File Offset: 0x00144018
	public Dictionary<int, FurnitureSceneItemBase> SubFurnitureSceneItemMap { get; set; } = new Dictionary<int, FurnitureSceneItemBase>();
}
