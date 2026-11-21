using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B5 RID: 21173
	public enum EHitLogicType : byte
	{
		// Token: 0x0400E510 RID: 58640
		ChangeNextState,
		// Token: 0x0400E511 RID: 58641
		ChangeCountDownState,
		// Token: 0x0400E512 RID: 58642
		ChangeLockState,
		// Token: 0x0400E513 RID: 58643
		ChangeNextAndLockTargetState,
		// Token: 0x0400E514 RID: 58644
		ChangeTargetState,
		// Token: 0x0400E515 RID: 58645
		ChangeByPartHit,
		// Token: 0x0400E516 RID: 58646
		ActionByHitType
	}
}
