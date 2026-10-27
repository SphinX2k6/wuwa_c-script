using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FA3 RID: 4003
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneItemPlaceContext : IFurnitureSceneItemPlaceContext
{
	// Token: 0x17000821 RID: 2081
	// (get) Token: 0x06006662 RID: 26210 RVA: 0x001440E0 File Offset: 0x001422E0
	// (set) Token: 0x06006663 RID: 26211 RVA: 0x001440E8 File Offset: 0x001422E8
	public IFurnitureAreaSlotContext AreaSlotContext { get; set; }

	// Token: 0x17000822 RID: 2082
	// (get) Token: 0x06006664 RID: 26212 RVA: 0x001440F1 File Offset: 0x001422F1
	// (set) Token: 0x06006665 RID: 26213 RVA: 0x001440F9 File Offset: 0x001422F9
	public int FurnitureId { get; set; }

	// Token: 0x17000823 RID: 2083
	// (get) Token: 0x06006666 RID: 26214 RVA: 0x00144102 File Offset: 0x00142302
	// (set) Token: 0x06006667 RID: 26215 RVA: 0x0014410A File Offset: 0x0014230A
	public bool KeepSubFurniture { get; set; }
}
