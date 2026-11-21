using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x02002735 RID: 10037
[NullableContext(1)]
[Nullable(0)]
internal class PlayerGroupPatrolSession
{
	// Token: 0x0400DBE0 RID: 56288
	public int GroupEntityId;

	// Token: 0x0400DBE1 RID: 56289
	public int GroupOwnerPbDataId;

	// Token: 0x0400DBE2 RID: 56290
	public int PlayerEntityId;

	// Token: 0x0400DBE3 RID: 56291
	public CharacterActorComponent ActorComp;

	// Token: 0x0400DBE4 RID: 56292
	public BaseMoveComponent MoveComp;

	// Token: 0x0400DBE5 RID: 56293
	public CharacterCustomActionComponent CustomActionComp;

	// Token: 0x0400DBE6 RID: 56294
	[Nullable(2)]
	public CharacterAnimationComponent AnimComp;

	// Token: 0x0400DBE7 RID: 56295
	[Nullable(2)]
	public BaseTagComponent TagComp;

	// Token: 0x0400DBE8 RID: 56296
	[Nullable(2)]
	public CharacterUnifiedStateComponent UnifiedComp;

	// Token: 0x0400DBE9 RID: 56297
	public EGroupAiEcologyGameplayType? EcologyGameplayType;

	// Token: 0x0400DBEA RID: 56298
	public bool InitialPlacementPending;

	// Token: 0x0400DBEB RID: 56299
	public bool InitialPlacementCompleted;

	// Token: 0x0400DBEC RID: 56300
	public bool InitialTurnStarted;

	// Token: 0x0400DBED RID: 56301
	[Nullable(2)]
	public CustomSetActorRotation InitialTurnAction;

	// Token: 0x0400DBEE RID: 56302
	public bool EcologyTagApplied;

	// Token: 0x0400DBEF RID: 56303
	public bool GroupSyncTagListenerActive;

	// Token: 0x0400DBF0 RID: 56304
	public readonly HashSet<int> GroupSyncedTagIds = new HashSet<int>();

	// Token: 0x0400DBF1 RID: 56305
	public bool PreciseFollowActive;

	// Token: 0x0400DBF2 RID: 56306
	public EPlayerPatrolRootMotionScaleMode RootMotionScaleMode;

	// Token: 0x0400DBF3 RID: 56307
	public float SavedRootMotionScale = -1f;

	// Token: 0x0400DBF4 RID: 56308
	public readonly Vector TargetLocation = Vector.Create();

	// Token: 0x0400DBF5 RID: 56309
	public readonly Vector MovePosition = Vector.Create();

	// Token: 0x0400DBF6 RID: 56310
	public readonly Vector PreciseMoveOffset = Vector.Create();

	// Token: 0x0400DBF7 RID: 56311
	public readonly Vector LastPlayerLocation = Vector.Create();

	// Token: 0x0400DBF8 RID: 56312
	public readonly Vector LastTargetLocation = Vector.Create();

	// Token: 0x0400DBF9 RID: 56313
	public float StationaryTimeSeconds;

	// Token: 0x0400DBFA RID: 56314
	public float OriginalMaxSpeed;

	// Token: 0x0400DBFB RID: 56315
	public bool OriginalIsWalkMode;

	// Token: 0x0400DBFC RID: 56316
	public int MoveFailureCount;

	// Token: 0x0400DBFD RID: 56317
	public EPlayerGroupPatrolState State;
}
