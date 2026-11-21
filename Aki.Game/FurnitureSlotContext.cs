using System;

// Token: 0x02000452 RID: 1106
public class FurnitureSlotContext : IFurnitureSlotContext
{
	// Token: 0x17000836 RID: 2102
	// (get) Token: 0x060039E4 RID: 14820 RVA: 0x0014C8F6 File Offset: 0x0014AAF6
	// (set) Token: 0x060039E5 RID: 14821 RVA: 0x0014C8FE File Offset: 0x0014AAFE
	public int SlotEntityId { get; set; }

	// Token: 0x17000837 RID: 2103
	// (get) Token: 0x060039E6 RID: 14822 RVA: 0x0014C907 File Offset: 0x0014AB07
	// (set) Token: 0x060039E7 RID: 14823 RVA: 0x0014C90F File Offset: 0x0014AB0F
	public int SubSlotIndex { get; set; }
}
