using System;
using System.Runtime.CompilerServices;

// Token: 0x02000454 RID: 1108
[NullableContext(1)]
[Nullable(0)]
public class FurnitureAreaSlotContext : IFurnitureAreaSlotContext
{
	// Token: 0x1700083A RID: 2106
	// (get) Token: 0x060039EB RID: 14827 RVA: 0x0014C920 File Offset: 0x0014AB20
	// (set) Token: 0x060039EC RID: 14828 RVA: 0x0014C928 File Offset: 0x0014AB28
	public FurnitureAreaData AreaData { get; set; }

	// Token: 0x1700083B RID: 2107
	// (get) Token: 0x060039ED RID: 14829 RVA: 0x0014C931 File Offset: 0x0014AB31
	// (set) Token: 0x060039EE RID: 14830 RVA: 0x0014C939 File Offset: 0x0014AB39
	public IFurnitureSlotContext SlotContext { get; set; }
}
