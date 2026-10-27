using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F9F RID: 3999
[NullableContext(1)]
[Nullable(0)]
public class FurnitureAreaSlotContext : IFurnitureAreaSlotContext
{
	// Token: 0x17000818 RID: 2072
	// (get) Token: 0x06006653 RID: 26195 RVA: 0x0014408C File Offset: 0x0014228C
	// (set) Token: 0x06006654 RID: 26196 RVA: 0x00144094 File Offset: 0x00142294
	public FurnitureAreaData AreaData { get; set; }

	// Token: 0x17000819 RID: 2073
	// (get) Token: 0x06006655 RID: 26197 RVA: 0x0014409D File Offset: 0x0014229D
	// (set) Token: 0x06006656 RID: 26198 RVA: 0x001440A5 File Offset: 0x001422A5
	public IFurnitureSlotContext SlotContext { get; set; }
}
