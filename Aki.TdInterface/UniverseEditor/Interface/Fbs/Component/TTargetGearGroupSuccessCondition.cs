using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBA RID: 23738
	public enum TTargetGearGroupSuccessCondition : byte
	{
		// Token: 0x0400F579 RID: 62841
		NONE,
		// Token: 0x0400F57A RID: 62842
		ISuccessConditionCountDownState,
		// Token: 0x0400F57B RID: 62843
		ISuccessConditionSameArbitraryState,
		// Token: 0x0400F57C RID: 62844
		ISuccessConditionSameSpecificState,
		// Token: 0x0400F57D RID: 62845
		ISuccessConditionSpecificTargetState
	}
}
