using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020026C5 RID: 9925
[RequiredMember]
public class EndSkillBehaviorParam
{
	// Token: 0x06018E06 RID: 101894 RVA: 0x0078F9FA File Offset: 0x0078DBFA
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public EndSkillBehaviorParam()
	{
	}

	// Token: 0x0400D7F4 RID: 55284
	[Nullable(1)]
	[RequiredMember]
	public Entity Entity;

	// Token: 0x0400D7F5 RID: 55285
	public ESkillBehaviorActionType ActionType;

	// Token: 0x0400D7F6 RID: 55286
	public EMovementMode? MovementMode;

	// Token: 0x0400D7F7 RID: 55287
	public ECollisionChannel? CollisionChannel;

	// Token: 0x0400D7F8 RID: 55288
	public ECollisionResponse? CollisionResponse;

	// Token: 0x0400D7F9 RID: 55289
	[Nullable(2)]
	public BaseSkillComponent SummonSkillComponent;

	// Token: 0x0400D7FA RID: 55290
	public int? SummonSkillId;

	// Token: 0x0400D7FB RID: 55291
	public long? GameplayCue;
}
