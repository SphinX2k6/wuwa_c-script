using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022BD RID: 8893
[NullableContext(1)]
public interface IWeeklyRogueRewardPopViewData
{
	// Token: 0x17002151 RID: 8529
	// (get) Token: 0x06015F8B RID: 89995
	// (set) Token: 0x06015F8C RID: 89996
	int SinglePowerCost { get; set; }

	// Token: 0x17002152 RID: 8530
	// (get) Token: 0x06015F8D RID: 89997
	// (set) Token: 0x06015F8E RID: 89998
	Action<int, int> RewardCallBack { get; set; }

	// Token: 0x17002153 RID: 8531
	// (get) Token: 0x06015F8F RID: 89999
	// (set) Token: 0x06015F90 RID: 90000
	[Nullable(2)]
	Action CloseCallBack { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17002154 RID: 8532
	// (get) Token: 0x06015F91 RID: 90001
	// (set) Token: 0x06015F92 RID: 90002
	List<int> AvailableSilentArea { get; set; }

	// Token: 0x17002155 RID: 8533
	// (get) Token: 0x06015F93 RID: 90003
	// (set) Token: 0x06015F94 RID: 90004
	int FreeCount { get; set; }

	// Token: 0x17002156 RID: 8534
	// (get) Token: 0x06015F95 RID: 90005
	// (set) Token: 0x06015F96 RID: 90006
	int FreeMax { get; set; }
}
