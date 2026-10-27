using System;
using System.Runtime.CompilerServices;

// Token: 0x020019CF RID: 6607
[NullableContext(1)]
public interface IWorldNavigationConfig
{
	// Token: 0x1700101D RID: 4125
	// (get) Token: 0x0600C0E9 RID: 49385
	// (set) Token: 0x0600C0EA RID: 49386
	Vector SourcePosition { get; set; }

	// Token: 0x1700101E RID: 4126
	// (get) Token: 0x0600C0EB RID: 49387
	// (set) Token: 0x0600C0EC RID: 49388
	Vector DestPosition { get; set; }

	// Token: 0x1700101F RID: 4127
	// (get) Token: 0x0600C0ED RID: 49389
	// (set) Token: 0x0600C0EE RID: 49390
	int MapId { get; set; }

	// Token: 0x17001020 RID: 4128
	// (get) Token: 0x0600C0EF RID: 49391
	// (set) Token: 0x0600C0F0 RID: 49392
	[Nullable(2)]
	BaseMoveComponent MoveComponent { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001021 RID: 4129
	// (get) Token: 0x0600C0F1 RID: 49393
	// (set) Token: 0x0600C0F2 RID: 49394
	int? DistanceThreshold { get; set; }

	// Token: 0x17001022 RID: 4130
	// (get) Token: 0x0600C0F3 RID: 49395
	// (set) Token: 0x0600C0F4 RID: 49396
	int? TryFindPathTimes { get; set; }

	// Token: 0x17001023 RID: 4131
	// (get) Token: 0x0600C0F5 RID: 49397
	// (set) Token: 0x0600C0F6 RID: 49398
	[Nullable(2)]
	TWorldNavigationCallback Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
