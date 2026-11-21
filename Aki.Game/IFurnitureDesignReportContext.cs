using System;
using System.Runtime.CompilerServices;

// Token: 0x0200045E RID: 1118
[NullableContext(1)]
public interface IFurnitureDesignReportContext
{
	// Token: 0x1700084E RID: 2126
	// (get) Token: 0x06003A0F RID: 14863
	int AreaId { get; }

	// Token: 0x1700084F RID: 2127
	// (get) Token: 0x06003A10 RID: 14864
	EFurnitureDesignReportOperationType OperationType { get; }

	// Token: 0x17000850 RID: 2128
	// (get) Token: 0x06003A11 RID: 14865
	IFurnitureSlotContext SlotContext { get; }

	// Token: 0x17000851 RID: 2129
	// (get) Token: 0x06003A12 RID: 14866
	int? OldFurnitureId { get; }

	// Token: 0x17000852 RID: 2130
	// (get) Token: 0x06003A13 RID: 14867
	int? NewFurnitureId { get; }
}
