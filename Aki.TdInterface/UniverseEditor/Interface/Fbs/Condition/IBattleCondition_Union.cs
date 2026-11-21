using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E30 RID: 20016
	public enum IBattleCondition_Union : byte
	{
		// Token: 0x0400DC46 RID: 56390
		NONE,
		// Token: 0x0400DC47 RID: 56391
		IBattleCondition,
		// Token: 0x0400DC48 RID: 56392
		IBattleTagCondition,
		// Token: 0x0400DC49 RID: 56393
		IPerfectDodgeCondition,
		// Token: 0x0400DC4A RID: 56394
		ICounterAttackCondition
	}
}
