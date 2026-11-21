using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000C1 RID: 193
	[EnumExtensions]
	public enum EHitLogicType
	{
		// Token: 0x04000445 RID: 1093
		ChangeNextState,
		// Token: 0x04000446 RID: 1094
		ChangeCountDownState,
		// Token: 0x04000447 RID: 1095
		ChangeLockState,
		// Token: 0x04000448 RID: 1096
		ChangeNextAndLockTargetState,
		// Token: 0x04000449 RID: 1097
		ChangeTargetState,
		// Token: 0x0400044A RID: 1098
		ChangeByPartHit,
		// Token: 0x0400044B RID: 1099
		ActionByHitType
	}
}
