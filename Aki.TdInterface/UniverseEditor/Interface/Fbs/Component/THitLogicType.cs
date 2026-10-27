using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C33 RID: 23603
	public enum THitLogicType : byte
	{
		// Token: 0x0400F420 RID: 62496
		NONE,
		// Token: 0x0400F421 RID: 62497
		IHitLogicActionByHitType,
		// Token: 0x0400F422 RID: 62498
		IHitLogicChangeByPartHit,
		// Token: 0x0400F423 RID: 62499
		IHitLogicChangeCountDownState,
		// Token: 0x0400F424 RID: 62500
		IHitLogicChangeLockState,
		// Token: 0x0400F425 RID: 62501
		IHitLogicChangeNextAndLockTargetState,
		// Token: 0x0400F426 RID: 62502
		IHitLogicChangeNextState,
		// Token: 0x0400F427 RID: 62503
		IHitLogicChangeTargetState
	}
}
