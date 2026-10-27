using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C13 RID: 7187
	public class IMotorCatapult_SetValue
	{
		// Token: 0x04005DC1 RID: 24001
		public ELeisureInteract Type;

		// Token: 0x04005DC2 RID: 24002
		[Nullable(1)]
		public IMotorCatapultParam Param;

		// Token: 0x04005DC3 RID: 24003
		public EMotorCatapultSkillType? SkillType;
	}
}
