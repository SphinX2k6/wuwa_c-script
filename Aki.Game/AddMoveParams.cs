using System;
using System.Runtime.CompilerServices;

// Token: 0x02000107 RID: 263
[NullableContext(2)]
[Nullable(0)]
internal class AddMoveParams
{
	// Token: 0x04000C1B RID: 3099
	public float NowTime;

	// Token: 0x04000C1C RID: 3100
	public float CurrentSpeed;

	// Token: 0x04000C1D RID: 3101
	[Nullable(1)]
	public readonly Vector InputDirectCache = Vector.Create();

	// Token: 0x04000C1E RID: 3102
	public float AccumulativeSpeedUpTime;

	// Token: 0x04000C1F RID: 3103
	public CharacterSkillComponent CharSkillComp;

	// Token: 0x04000C20 RID: 3104
	public BaseMoveComponent MoveComp;

	// Token: 0x04000C21 RID: 3105
	public CharacterActorComponent CharActorComp;
}
