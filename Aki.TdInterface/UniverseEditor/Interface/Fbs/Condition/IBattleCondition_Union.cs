using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004979 RID: 18809
	public enum IBattleCondition_Union : byte
	{
		// Token: 0x0400D17E RID: 53630
		NONE,
		// Token: 0x0400D17F RID: 53631
		IBattleCondition,
		// Token: 0x0400D180 RID: 53632
		IBattleTagCondition,
		// Token: 0x0400D181 RID: 53633
		IPerfectDodgeCondition,
		// Token: 0x0400D182 RID: 53634
		ICounterAttackCondition
	}
}
