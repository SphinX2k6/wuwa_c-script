using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x0200305B RID: 12379
[NullableContext(2)]
[Nullable(0)]
public class IConcomitantInheritContext
{
	// Token: 0x0400C8DF RID: 51423
	public bool SkillInterrupt;

	// Token: 0x0400C8E0 RID: 51424
	public bool HitInterrupt;

	// Token: 0x0400C8E1 RID: 51425
	public bool OtherInterrupt;

	// Token: 0x0400C8E2 RID: 51426
	[Nullable(1)]
	public List<long> NewSkillIds = new List<long>();

	// Token: 0x0400C8E3 RID: 51427
	public EConcomitantDurationType ConcomitantDurationType;

	// Token: 0x0400C8E4 RID: 51428
	public float Duration;

	// Token: 0x0400C8E5 RID: 51429
	public long StartCue;

	// Token: 0x0400C8E6 RID: 51430
	public long EndCue;

	// Token: 0x0400C8E7 RID: 51431
	public int SummonIndex;

	// Token: 0x0400C8E8 RID: 51432
	public long BuffId;

	// Token: 0x0400C8E9 RID: 51433
	public long? PreMessage;

	// Token: 0x0400C8EA RID: 51434
	public int? SkillId;

	// Token: 0x0400C8EB RID: 51435
	public TimerHandle TimerHandle;

	// Token: 0x0400C8EC RID: 51436
	public UAnimMontage CurrentMontage;

	// Token: 0x0400C8ED RID: 51437
	public Action<UAnimMontage, bool> OnMontageEnded;

	// Token: 0x0400C8EE RID: 51438
	public CharacterAnimationComponent SummonAnimComp;
}
