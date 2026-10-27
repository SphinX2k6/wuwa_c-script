using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004DB1 RID: 19889
	public enum EHitLogicType : byte
	{
		// Token: 0x0400D9C1 RID: 55745
		ChangeNextState,
		// Token: 0x0400D9C2 RID: 55746
		ChangeCountDownState,
		// Token: 0x0400D9C3 RID: 55747
		ChangeLockState,
		// Token: 0x0400D9C4 RID: 55748
		ChangeNextAndLockTargetState,
		// Token: 0x0400D9C5 RID: 55749
		ChangeTargetState,
		// Token: 0x0400D9C6 RID: 55750
		ChangeByPartHit,
		// Token: 0x0400D9C7 RID: 55751
		ActionByHitType
	}
}
