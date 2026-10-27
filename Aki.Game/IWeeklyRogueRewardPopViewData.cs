using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002D63 RID: 11619
[NullableContext(1)]
public interface IWeeklyRogueRewardPopViewData
{
	// Token: 0x170020F6 RID: 8438
	// (get) Token: 0x060186E9 RID: 100073
	// (set) Token: 0x060186EA RID: 100074
	int SinglePowerCost { get; set; }

	// Token: 0x170020F7 RID: 8439
	// (get) Token: 0x060186EB RID: 100075
	// (set) Token: 0x060186EC RID: 100076
	Action<int, int> RewardCallBack { get; set; }

	// Token: 0x170020F8 RID: 8440
	// (get) Token: 0x060186ED RID: 100077
	// (set) Token: 0x060186EE RID: 100078
	[Nullable(2)]
	Action CloseCallBack { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170020F9 RID: 8441
	// (get) Token: 0x060186EF RID: 100079
	// (set) Token: 0x060186F0 RID: 100080
	List<int> AvailableSilentArea { get; set; }

	// Token: 0x170020FA RID: 8442
	// (get) Token: 0x060186F1 RID: 100081
	// (set) Token: 0x060186F2 RID: 100082
	int FreeCount { get; set; }

	// Token: 0x170020FB RID: 8443
	// (get) Token: 0x060186F3 RID: 100083
	// (set) Token: 0x060186F4 RID: 100084
	int FreeMax { get; set; }
}
