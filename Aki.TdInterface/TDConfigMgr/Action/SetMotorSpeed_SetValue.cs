using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242F RID: 9263
	public class SetMotorSpeed_SetValue
	{
		// Token: 0x04007797 RID: 30615
		[Nullable(2)]
		public IMotorConstraintConfig MotorConstraint;

		// Token: 0x04007798 RID: 30616
		public ISetMotorSpeedTargetSpeed SpeedConfig;
	}
}
