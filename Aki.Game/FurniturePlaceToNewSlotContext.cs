using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FA1 RID: 4001
[NullableContext(1)]
[Nullable(0)]
public class FurniturePlaceToNewSlotContext : IFurniturePlaceToNewSlotContext
{
	// Token: 0x1700081C RID: 2076
	// (get) Token: 0x0600665A RID: 26202 RVA: 0x001440B6 File Offset: 0x001422B6
	// (set) Token: 0x0600665B RID: 26203 RVA: 0x001440BE File Offset: 0x001422BE
	public IFurnitureAreaSlotContext SourceContext { get; set; }

	// Token: 0x1700081D RID: 2077
	// (get) Token: 0x0600665C RID: 26204 RVA: 0x001440C7 File Offset: 0x001422C7
	// (set) Token: 0x0600665D RID: 26205 RVA: 0x001440CF File Offset: 0x001422CF
	public IFurnitureAreaSlotContext TargetContext { get; set; }
}
