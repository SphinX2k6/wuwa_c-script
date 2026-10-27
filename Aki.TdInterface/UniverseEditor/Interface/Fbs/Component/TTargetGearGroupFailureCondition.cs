using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB7 RID: 23735
	public enum TTargetGearGroupFailureCondition : byte
	{
		// Token: 0x0400F572 RID: 62834
		NONE,
		// Token: 0x0400F573 RID: 62835
		IFailureConditionArbitraryState,
		// Token: 0x0400F574 RID: 62836
		IFailureConditionHitTargetEntity,
		// Token: 0x0400F575 RID: 62837
		IFailureConditionSequentialState
	}
}
