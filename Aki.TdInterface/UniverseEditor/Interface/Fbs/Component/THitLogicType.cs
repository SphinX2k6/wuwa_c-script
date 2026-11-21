using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006258 RID: 25176
	public enum THitLogicType : byte
	{
		// Token: 0x0401014A RID: 65866
		NONE,
		// Token: 0x0401014B RID: 65867
		IHitLogicActionByHitType,
		// Token: 0x0401014C RID: 65868
		IHitLogicChangeByPartHit,
		// Token: 0x0401014D RID: 65869
		IHitLogicChangeCountDownState,
		// Token: 0x0401014E RID: 65870
		IHitLogicChangeLockState,
		// Token: 0x0401014F RID: 65871
		IHitLogicChangeNextAndLockTargetState,
		// Token: 0x04010150 RID: 65872
		IHitLogicChangeNextState,
		// Token: 0x04010151 RID: 65873
		IHitLogicChangeTargetState
	}
}
