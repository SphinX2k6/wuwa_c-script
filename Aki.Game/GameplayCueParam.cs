using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020023CA RID: 9162
[NullableContext(2)]
[Nullable(0)]
public struct GameplayCueParam
{
	// Token: 0x0400C0B1 RID: 49329
	public IActiveBuff Buff;

	// Token: 0x0400C0B2 RID: 49330
	public Action BeginCallback;

	// Token: 0x0400C0B3 RID: 49331
	public Action EndCallback;

	// Token: 0x0400C0B4 RID: 49332
	public bool? Sync;

	// Token: 0x0400C0B5 RID: 49333
	public EntityHandle Instigator;

	// Token: 0x0400C0B6 RID: 49334
	public bool Instant;

	// Token: 0x0400C0B7 RID: 49335
	public string SocketNameOverride;

	// Token: 0x0400C0B8 RID: 49336
	public FVector? RelativePositionOverride;

	// Token: 0x0400C0B9 RID: 49337
	public FVector? RelativeRotationOverride;

	// Token: 0x0400C0BA RID: 49338
	public FVector? ScaleOverride;

	// Token: 0x0400C0BB RID: 49339
	public GameplayCue CueConfig;

	// Token: 0x0400C0BC RID: 49340
	[Nullable(1)]
	public EntityHandle EntityHandle;

	// Token: 0x0400C0BD RID: 49341
	[Nullable(1)]
	public BaseGameplayCueComponent CueComp;
}
