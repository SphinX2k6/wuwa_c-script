using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000B9 RID: 185
	[EnumExtensions]
	public enum EHitLogicType
	{
		// Token: 0x04000421 RID: 1057
		ChangeNextState,
		// Token: 0x04000422 RID: 1058
		ChangeCountDownState,
		// Token: 0x04000423 RID: 1059
		ChangeLockState,
		// Token: 0x04000424 RID: 1060
		ChangeNextAndLockTargetState,
		// Token: 0x04000425 RID: 1061
		ChangeTargetState,
		// Token: 0x04000426 RID: 1062
		ChangeByPartHit,
		// Token: 0x04000427 RID: 1063
		ActionByHitType
	}
}
