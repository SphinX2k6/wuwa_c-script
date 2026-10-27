using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003158 RID: 12632
[RequiredMember]
public class EndSkillBehaviorParam
{
	// Token: 0x0601B301 RID: 111361 RVA: 0x0076802E File Offset: 0x0076622E
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public EndSkillBehaviorParam()
	{
	}

	// Token: 0x0400D391 RID: 54161
	[Nullable(1)]
	[RequiredMember]
	public Entity Entity;

	// Token: 0x0400D392 RID: 54162
	public ESkillBehaviorActionType ActionType;

	// Token: 0x0400D393 RID: 54163
	public EMovementMode? MovementMode;

	// Token: 0x0400D394 RID: 54164
	public ECollisionChannel? CollisionChannel;

	// Token: 0x0400D395 RID: 54165
	public ECollisionResponse? CollisionResponse;

	// Token: 0x0400D396 RID: 54166
	[Nullable(2)]
	public BaseSkillComponent SummonSkillComponent;

	// Token: 0x0400D397 RID: 54167
	public int? SummonSkillId;

	// Token: 0x0400D398 RID: 54168
	public long? GameplayCue;
}
