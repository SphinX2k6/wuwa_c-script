using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062E8 RID: 25320
	public enum TTargetGearGroupFailureCondition : byte
	{
		// Token: 0x040102B9 RID: 66233
		NONE,
		// Token: 0x040102BA RID: 66234
		IFailureConditionArbitraryState,
		// Token: 0x040102BB RID: 66235
		IFailureConditionHitTargetEntity,
		// Token: 0x040102BC RID: 66236
		IFailureConditionSequentialState
	}
}
