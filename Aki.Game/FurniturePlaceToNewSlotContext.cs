using System;
using System.Runtime.CompilerServices;

// Token: 0x02000456 RID: 1110
[NullableContext(1)]
[Nullable(0)]
public class FurniturePlaceToNewSlotContext : IFurniturePlaceToNewSlotContext
{
	// Token: 0x1700083E RID: 2110
	// (get) Token: 0x060039F2 RID: 14834 RVA: 0x0014C94A File Offset: 0x0014AB4A
	// (set) Token: 0x060039F3 RID: 14835 RVA: 0x0014C952 File Offset: 0x0014AB52
	public IFurnitureAreaSlotContext SourceContext { get; set; }

	// Token: 0x1700083F RID: 2111
	// (get) Token: 0x060039F4 RID: 14836 RVA: 0x0014C95B File Offset: 0x0014AB5B
	// (set) Token: 0x060039F5 RID: 14837 RVA: 0x0014C963 File Offset: 0x0014AB63
	public IFurnitureAreaSlotContext TargetContext { get; set; }
}
