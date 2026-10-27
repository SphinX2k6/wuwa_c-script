using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001575 RID: 5493
	public class DriveMotorInSpecConfig_SetValue
	{
		// Token: 0x04004756 RID: 18262
		[Nullable(1)]
		public IMotorParamsChangeConfig MotorParamsChangeConfig;

		// Token: 0x04004757 RID: 18263
		public bool? IsEnableNitrogen;

		// Token: 0x04004758 RID: 18264
		[Nullable(2)]
		public List<EPlayerInputConstraintType> DisableInput;

		// Token: 0x04004759 RID: 18265
		public float Duration;

		// Token: 0x0400475A RID: 18266
		public bool? IsAffectedByTimeStop;

		// Token: 0x0400475B RID: 18267
		public bool? CanBeInterrupted;
	}
}
