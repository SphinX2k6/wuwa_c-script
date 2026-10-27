using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A37 RID: 23095
	public enum ITargetGearGroupSuccessContdion_Union : byte
	{
		// Token: 0x0400F0A3 RID: 61603
		NONE,
		// Token: 0x0400F0A4 RID: 61604
		ITargetGearGroupSuccessContdion,
		// Token: 0x0400F0A5 RID: 61605
		ISuccessConditionSameSpecificState,
		// Token: 0x0400F0A6 RID: 61606
		ISuccessConditionSameArbitraryState,
		// Token: 0x0400F0A7 RID: 61607
		ISuccessConditionCountDownState,
		// Token: 0x0400F0A8 RID: 61608
		ISuccessConditionSpecificTargetState
	}
}
