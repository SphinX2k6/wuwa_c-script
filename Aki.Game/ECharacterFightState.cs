using System;

// Token: 0x02003059 RID: 12377
public enum ECharacterFightState
{
	// Token: 0x0400C8CD RID: 51405
	Default,
	// Token: 0x0400C8CE RID: 51406
	NormalSkill,
	// Token: 0x0400C8CF RID: 51407
	BeHit,
	// Token: 0x0400C8D0 RID: 51408
	OverrideBeHitSkill,
	// Token: 0x0400C8D1 RID: 51409
	CounterattackBeHit,
	// Token: 0x0400C8D2 RID: 51410
	OverrideCounterattackSkill,
	// Token: 0x0400C8D3 RID: 51411
	BeBrokeWeakness,
	// Token: 0x0400C8D4 RID: 51412
	OverrideBeBrokeWeaknessSkill,
	// Token: 0x0400C8D5 RID: 51413
	BeCaught,
	// Token: 0x0400C8D6 RID: 51414
	SuperSkill,
	// Token: 0x0400C8D7 RID: 51415
	StateMachine
}
