using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002E78 RID: 11896
[NullableContext(2)]
[Nullable(0)]
public struct GameplayCueParam
{
	// Token: 0x0400BD1A RID: 48410
	public IActiveBuff Buff;

	// Token: 0x0400BD1B RID: 48411
	public Action BeginCallback;

	// Token: 0x0400BD1C RID: 48412
	public Action EndCallback;

	// Token: 0x0400BD1D RID: 48413
	public bool? Sync;

	// Token: 0x0400BD1E RID: 48414
	public EntityHandle Instigator;

	// Token: 0x0400BD1F RID: 48415
	public bool Instant;

	// Token: 0x0400BD20 RID: 48416
	public string SocketNameOverride;

	// Token: 0x0400BD21 RID: 48417
	public FVector? RelativePositionOverride;

	// Token: 0x0400BD22 RID: 48418
	public FVector? RelativeRotationOverride;

	// Token: 0x0400BD23 RID: 48419
	public FVector? ScaleOverride;

	// Token: 0x0400BD24 RID: 48420
	public GameplayCue CueConfig;

	// Token: 0x0400BD25 RID: 48421
	[Nullable(1)]
	public EntityHandle EntityHandle;

	// Token: 0x0400BD26 RID: 48422
	[Nullable(1)]
	public BaseGameplayCueComponent CueComp;
}
