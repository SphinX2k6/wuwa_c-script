using System;
using System.Runtime.CompilerServices;

// Token: 0x0200045A RID: 1114
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneItemApplyPresetContext : IFurnitureSceneItemApplyPresetContext
{
	// Token: 0x17000848 RID: 2120
	// (get) Token: 0x06003A03 RID: 14851 RVA: 0x0014C9AF File Offset: 0x0014ABAF
	// (set) Token: 0x06003A04 RID: 14852 RVA: 0x0014C9B7 File Offset: 0x0014ABB7
	public int PresetId { get; set; }

	// Token: 0x17000849 RID: 2121
	// (get) Token: 0x06003A05 RID: 14853 RVA: 0x0014C9C0 File Offset: 0x0014ABC0
	// (set) Token: 0x06003A06 RID: 14854 RVA: 0x0014C9C8 File Offset: 0x0014ABC8
	public FurnitureAreaData AreaData { get; set; }
}
