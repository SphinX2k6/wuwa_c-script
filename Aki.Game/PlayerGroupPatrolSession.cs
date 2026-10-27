using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x020031C6 RID: 12742
[NullableContext(1)]
[Nullable(0)]
internal class PlayerGroupPatrolSession
{
	// Token: 0x0400D759 RID: 55129
	public int GroupEntityId;

	// Token: 0x0400D75A RID: 55130
	public int GroupOwnerPbDataId;

	// Token: 0x0400D75B RID: 55131
	public int PlayerEntityId;

	// Token: 0x0400D75C RID: 55132
	public CharacterActorComponent ActorComp;

	// Token: 0x0400D75D RID: 55133
	public BaseMoveComponent MoveComp;

	// Token: 0x0400D75E RID: 55134
	public CharacterCustomActionComponent CustomActionComp;

	// Token: 0x0400D75F RID: 55135
	[Nullable(2)]
	public CharacterAnimationComponent AnimComp;

	// Token: 0x0400D760 RID: 55136
	[Nullable(2)]
	public BaseTagComponent TagComp;

	// Token: 0x0400D761 RID: 55137
	[Nullable(2)]
	public CharacterUnifiedStateComponent UnifiedComp;

	// Token: 0x0400D762 RID: 55138
	public EGroupAiEcologyGameplayType? EcologyGameplayType;

	// Token: 0x0400D763 RID: 55139
	public bool InitialPlacementPending;

	// Token: 0x0400D764 RID: 55140
	public bool InitialPlacementCompleted;

	// Token: 0x0400D765 RID: 55141
	public bool InitialTurnStarted;

	// Token: 0x0400D766 RID: 55142
	[Nullable(2)]
	public CustomSetActorRotation InitialTurnAction;

	// Token: 0x0400D767 RID: 55143
	public bool EcologyTagApplied;

	// Token: 0x0400D768 RID: 55144
	public bool GroupSyncTagListenerActive;

	// Token: 0x0400D769 RID: 55145
	public readonly HashSet<int> GroupSyncedTagIds = new HashSet<int>();

	// Token: 0x0400D76A RID: 55146
	public bool PreciseFollowActive;

	// Token: 0x0400D76B RID: 55147
	public EPlayerPatrolRootMotionScaleMode RootMotionScaleMode;

	// Token: 0x0400D76C RID: 55148
	public float SavedRootMotionScale = -1f;

	// Token: 0x0400D76D RID: 55149
	public readonly Vector TargetLocation = Vector.Create();

	// Token: 0x0400D76E RID: 55150
	public readonly Vector MovePosition = Vector.Create();

	// Token: 0x0400D76F RID: 55151
	public readonly Vector PreciseMoveOffset = Vector.Create();

	// Token: 0x0400D770 RID: 55152
	public readonly Vector LastPlayerLocation = Vector.Create();

	// Token: 0x0400D771 RID: 55153
	public readonly Vector LastTargetLocation = Vector.Create();

	// Token: 0x0400D772 RID: 55154
	public float StationaryTimeSeconds;

	// Token: 0x0400D773 RID: 55155
	public float OriginalMaxSpeed;

	// Token: 0x0400D774 RID: 55156
	public bool OriginalIsWalkMode;

	// Token: 0x0400D775 RID: 55157
	public int MoveFailureCount;

	// Token: 0x0400D776 RID: 55158
	public EPlayerGroupPatrolState State;
}
