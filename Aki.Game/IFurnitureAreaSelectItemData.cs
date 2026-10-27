using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FC1 RID: 4033
[NullableContext(1)]
public interface IFurnitureAreaSelectItemData
{
	// Token: 0x17000845 RID: 2117
	// (get) Token: 0x06006733 RID: 26419
	// (set) Token: 0x06006734 RID: 26420
	int AreaId { get; set; }

	// Token: 0x17000846 RID: 2118
	// (get) Token: 0x06006735 RID: 26421
	// (set) Token: 0x06006736 RID: 26422
	int FloorId { get; set; }

	// Token: 0x17000847 RID: 2119
	// (get) Token: 0x06006737 RID: 26423
	// (set) Token: 0x06006738 RID: 26424
	string AreaName { get; set; }

	// Token: 0x17000848 RID: 2120
	// (get) Token: 0x06006739 RID: 26425
	// (set) Token: 0x0600673A RID: 26426
	string LockAreaIcon { get; set; }

	// Token: 0x17000849 RID: 2121
	// (get) Token: 0x0600673B RID: 26427
	// (set) Token: 0x0600673C RID: 26428
	string UnlockAreaIcon { get; set; }

	// Token: 0x1700084A RID: 2122
	// (get) Token: 0x0600673D RID: 26429
	// (set) Token: 0x0600673E RID: 26430
	bool IsSelected { get; set; }

	// Token: 0x1700084B RID: 2123
	// (get) Token: 0x0600673F RID: 26431
	// (set) Token: 0x06006740 RID: 26432
	bool IsUnlock { get; set; }

	// Token: 0x1700084C RID: 2124
	// (get) Token: 0x06006741 RID: 26433
	// (set) Token: 0x06006742 RID: 26434
	int PlacedSlotCount { get; set; }

	// Token: 0x1700084D RID: 2125
	// (get) Token: 0x06006743 RID: 26435
	// (set) Token: 0x06006744 RID: 26436
	int MaxSlotCount { get; set; }

	// Token: 0x1700084E RID: 2126
	// (get) Token: 0x06006745 RID: 26437
	// (set) Token: 0x06006746 RID: 26438
	bool RedDotShowState { get; set; }

	// Token: 0x1700084F RID: 2127
	// (get) Token: 0x06006747 RID: 26439
	// (set) Token: 0x06006748 RID: 26440
	Action<int> OnSelected { get; set; }
}
