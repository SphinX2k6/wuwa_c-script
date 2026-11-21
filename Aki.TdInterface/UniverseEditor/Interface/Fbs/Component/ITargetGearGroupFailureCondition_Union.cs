using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200603E RID: 24638
	public enum ITargetGearGroupFailureCondition_Union : byte
	{
		// Token: 0x0400FD90 RID: 64912
		NONE,
		// Token: 0x0400FD91 RID: 64913
		ITargetGearGroupFailureCondition,
		// Token: 0x0400FD92 RID: 64914
		IFailureConditionArbitraryState,
		// Token: 0x0400FD93 RID: 64915
		IFailureConditionSequentialState,
		// Token: 0x0400FD94 RID: 64916
		IFailureConditionHitTargetEntity
	}
}
