using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A4 RID: 21412
	public enum IHitLogicType_Union : byte
	{
		// Token: 0x0400E58E RID: 58766
		NONE,
		// Token: 0x0400E58F RID: 58767
		IHitLogicType,
		// Token: 0x0400E590 RID: 58768
		IHitLogicChangeNextState,
		// Token: 0x0400E591 RID: 58769
		IHitLogicChangeLockState,
		// Token: 0x0400E592 RID: 58770
		IHitLogicChangeCountDownState,
		// Token: 0x0400E593 RID: 58771
		IHitLogicChangeNextAndLockTargetState,
		// Token: 0x0400E594 RID: 58772
		IHitLogicChangeTargetState,
		// Token: 0x0400E595 RID: 58773
		IHitLogicChangeByPartHit,
		// Token: 0x0400E596 RID: 58774
		IHitLogicActionByHitType
	}
}
