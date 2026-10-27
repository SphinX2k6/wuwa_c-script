using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C4 RID: 8644
	public class SetMotorSpeed_SetValue
	{
		// Token: 0x0400714F RID: 29007
		[Nullable(2)]
		public IMotorConstraintConfig MotorConstraint;

		// Token: 0x04007150 RID: 29008
		[Nullable(1)]
		public ISetMotorSpeedTargetSpeed SpeedConfig;
	}
}
