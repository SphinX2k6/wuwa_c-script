using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592A RID: 22826
	public enum IHitLogicType_Union : byte
	{
		// Token: 0x0400F1BE RID: 61886
		NONE,
		// Token: 0x0400F1BF RID: 61887
		IHitLogicType,
		// Token: 0x0400F1C0 RID: 61888
		IHitLogicChangeNextState,
		// Token: 0x0400F1C1 RID: 61889
		IHitLogicChangeLockState,
		// Token: 0x0400F1C2 RID: 61890
		IHitLogicChangeCountDownState,
		// Token: 0x0400F1C3 RID: 61891
		IHitLogicChangeNextAndLockTargetState,
		// Token: 0x0400F1C4 RID: 61892
		IHitLogicChangeTargetState,
		// Token: 0x0400F1C5 RID: 61893
		IHitLogicChangeByPartHit,
		// Token: 0x0400F1C6 RID: 61894
		IHitLogicActionByHitType
	}
}
