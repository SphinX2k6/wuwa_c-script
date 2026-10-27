using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200245A RID: 9306
[NullableContext(1)]
public interface IPhantomInteractGridData
{
	// Token: 0x17001837 RID: 6199
	// (get) Token: 0x06012AB4 RID: 76468
	int MonsterId { get; }

	// Token: 0x17001838 RID: 6200
	// (get) Token: 0x06012AB5 RID: 76469
	int MonsterInfoId { get; }

	// Token: 0x17001839 RID: 6201
	// (get) Token: 0x06012AB6 RID: 76470
	List<int> SkinIds { get; }

	// Token: 0x1700183A RID: 6202
	// (get) Token: 0x06012AB7 RID: 76471
	int EquippedSkin { get; }

	// Token: 0x1700183B RID: 6203
	// (get) Token: 0x06012AB8 RID: 76472
	bool IsSpecial { get; }

	// Token: 0x1700183C RID: 6204
	// (get) Token: 0x06012AB9 RID: 76473
	bool HasSkin { get; }

	// Token: 0x1700183D RID: 6205
	// (get) Token: 0x06012ABA RID: 76474
	int Cost { get; }

	// Token: 0x1700183E RID: 6206
	// (get) Token: 0x06012ABB RID: 76475
	List<int> InteractAreaList { get; }

	// Token: 0x1700183F RID: 6207
	// (get) Token: 0x06012ABC RID: 76476
	bool IsUnlocked { get; }

	// Token: 0x17001840 RID: 6208
	// (get) Token: 0x06012ABD RID: 76477
	[Nullable(2)]
	string Name { [NullableContext(2)] get; }

	// Token: 0x17001841 RID: 6209
	// (get) Token: 0x06012ABE RID: 76478
	int InSlotIndex { get; }

	// Token: 0x17001842 RID: 6210
	// (get) Token: 0x06012ABF RID: 76479
	[Nullable(2)]
	string IconPath { [NullableContext(2)] get; }

	// Token: 0x17001843 RID: 6211
	// (get) Token: 0x06012AC0 RID: 76480
	int GetWayConfigId { get; }

	// Token: 0x17001844 RID: 6212
	// (get) Token: 0x06012AC1 RID: 76481
	int SortId { get; }
}
