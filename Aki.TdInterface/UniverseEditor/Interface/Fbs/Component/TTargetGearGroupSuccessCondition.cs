using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062EB RID: 25323
	public enum TTargetGearGroupSuccessCondition : byte
	{
		// Token: 0x040102C0 RID: 66240
		NONE,
		// Token: 0x040102C1 RID: 66241
		ISuccessConditionCountDownState,
		// Token: 0x040102C2 RID: 66242
		ISuccessConditionSameArbitraryState,
		// Token: 0x040102C3 RID: 66243
		ISuccessConditionSameSpecificState,
		// Token: 0x040102C4 RID: 66244
		ISuccessConditionSpecificTargetState
	}
}
