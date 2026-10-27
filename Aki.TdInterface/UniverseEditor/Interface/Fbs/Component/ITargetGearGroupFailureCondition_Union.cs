using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A31 RID: 23089
	public enum ITargetGearGroupFailureCondition_Union : byte
	{
		// Token: 0x0400F099 RID: 61593
		NONE,
		// Token: 0x0400F09A RID: 61594
		ITargetGearGroupFailureCondition,
		// Token: 0x0400F09B RID: 61595
		IFailureConditionArbitraryState,
		// Token: 0x0400F09C RID: 61596
		IFailureConditionSequentialState,
		// Token: 0x0400F09D RID: 61597
		IFailureConditionHitTargetEntity
	}
}
