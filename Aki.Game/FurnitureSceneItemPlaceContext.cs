using System;
using System.Runtime.CompilerServices;

// Token: 0x02000458 RID: 1112
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneItemPlaceContext : IFurnitureSceneItemPlaceContext
{
	// Token: 0x17000843 RID: 2115
	// (get) Token: 0x060039FA RID: 14842 RVA: 0x0014C974 File Offset: 0x0014AB74
	// (set) Token: 0x060039FB RID: 14843 RVA: 0x0014C97C File Offset: 0x0014AB7C
	public IFurnitureAreaSlotContext AreaSlotContext { get; set; }

	// Token: 0x17000844 RID: 2116
	// (get) Token: 0x060039FC RID: 14844 RVA: 0x0014C985 File Offset: 0x0014AB85
	// (set) Token: 0x060039FD RID: 14845 RVA: 0x0014C98D File Offset: 0x0014AB8D
	public int FurnitureId { get; set; }

	// Token: 0x17000845 RID: 2117
	// (get) Token: 0x060039FE RID: 14846 RVA: 0x0014C996 File Offset: 0x0014AB96
	// (set) Token: 0x060039FF RID: 14847 RVA: 0x0014C99E File Offset: 0x0014AB9E
	public bool KeepSubFurniture { get; set; }
}
