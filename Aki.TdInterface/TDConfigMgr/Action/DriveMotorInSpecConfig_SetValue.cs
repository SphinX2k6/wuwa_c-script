using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016D3 RID: 5843
	public class DriveMotorInSpecConfig_SetValue
	{
		// Token: 0x04004AF6 RID: 19190
		public IMotorParamsChangeConfig MotorParamsChangeConfig;

		// Token: 0x04004AF7 RID: 19191
		public bool? IsEnableNitrogen;

		// Token: 0x04004AF8 RID: 19192
		[Nullable(2)]
		public List<EPlayerInputConstraintType> DisableInput;

		// Token: 0x04004AF9 RID: 19193
		public float Duration;

		// Token: 0x04004AFA RID: 19194
		public bool? IsAffectedByTimeStop;

		// Token: 0x04004AFB RID: 19195
		public bool? CanBeInterrupted;
	}
}
