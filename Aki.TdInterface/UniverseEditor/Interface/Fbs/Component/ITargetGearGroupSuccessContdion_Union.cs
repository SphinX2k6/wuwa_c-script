using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006044 RID: 24644
	public enum ITargetGearGroupSuccessContdion_Union : byte
	{
		// Token: 0x0400FD9A RID: 64922
		NONE,
		// Token: 0x0400FD9B RID: 64923
		ITargetGearGroupSuccessContdion,
		// Token: 0x0400FD9C RID: 64924
		ISuccessConditionSameSpecificState,
		// Token: 0x0400FD9D RID: 64925
		ISuccessConditionSameArbitraryState,
		// Token: 0x0400FD9E RID: 64926
		ISuccessConditionCountDownState,
		// Token: 0x0400FD9F RID: 64927
		ISuccessConditionSpecificTargetState
	}
}
