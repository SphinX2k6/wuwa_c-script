using System;
using System.Runtime.CompilerServices;

// Token: 0x02000107 RID: 263
[NullableContext(2)]
[Nullable(0)]
internal class AddMoveParams
{
	// Token: 0x04000C13 RID: 3091
	public float NowTime;

	// Token: 0x04000C14 RID: 3092
	public float CurrentSpeed;

	// Token: 0x04000C15 RID: 3093
	[Nullable(1)]
	public readonly Vector InputDirectCache = Vector.Create();

	// Token: 0x04000C16 RID: 3094
	public float AccumulativeSpeedUpTime;

	// Token: 0x04000C17 RID: 3095
	public CharacterSkillComponent CharSkillComp;

	// Token: 0x04000C18 RID: 3096
	public BaseMoveComponent MoveComp;

	// Token: 0x04000C19 RID: 3097
	public CharacterActorComponent CharActorComp;
}
