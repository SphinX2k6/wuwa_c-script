using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FA9 RID: 4009
[NullableContext(1)]
public interface IFurnitureDesignReportContext
{
	// Token: 0x1700082C RID: 2092
	// (get) Token: 0x06006677 RID: 26231
	int AreaId { get; }

	// Token: 0x1700082D RID: 2093
	// (get) Token: 0x06006678 RID: 26232
	EFurnitureDesignReportOperationType OperationType { get; }

	// Token: 0x1700082E RID: 2094
	// (get) Token: 0x06006679 RID: 26233
	IFurnitureSlotContext SlotContext { get; }

	// Token: 0x1700082F RID: 2095
	// (get) Token: 0x0600667A RID: 26234
	int? OldFurnitureId { get; }

	// Token: 0x17000830 RID: 2096
	// (get) Token: 0x0600667B RID: 26235
	int? NewFurnitureId { get; }
}
