using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020025B1 RID: 9649
[NullableContext(2)]
[Nullable(0)]
public class IConcomitantInheritContext
{
	// Token: 0x0400CCB9 RID: 52409
	public bool SkillInterrupt;

	// Token: 0x0400CCBA RID: 52410
	public bool HitInterrupt;

	// Token: 0x0400CCBB RID: 52411
	public bool OtherInterrupt;

	// Token: 0x0400CCBC RID: 52412
	[Nullable(1)]
	public List<long> NewSkillIds = new List<long>();

	// Token: 0x0400CCBD RID: 52413
	public EConcomitantDurationType ConcomitantDurationType;

	// Token: 0x0400CCBE RID: 52414
	public float Duration;

	// Token: 0x0400CCBF RID: 52415
	public long StartCue;

	// Token: 0x0400CCC0 RID: 52416
	public long EndCue;

	// Token: 0x0400CCC1 RID: 52417
	public int SummonIndex;

	// Token: 0x0400CCC2 RID: 52418
	public long BuffId;

	// Token: 0x0400CCC3 RID: 52419
	public long? PreMessage;

	// Token: 0x0400CCC4 RID: 52420
	public int? SkillId;

	// Token: 0x0400CCC5 RID: 52421
	public TimerHandle TimerHandle;

	// Token: 0x0400CCC6 RID: 52422
	public UAnimMontage CurrentMontage;

	// Token: 0x0400CCC7 RID: 52423
	public Action<UAnimMontage, bool> OnMontageEnded;

	// Token: 0x0400CCC8 RID: 52424
	public CharacterAnimationComponent SummonAnimComp;
}
