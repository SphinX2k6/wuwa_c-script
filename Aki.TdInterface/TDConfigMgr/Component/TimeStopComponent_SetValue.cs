using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C7 RID: 2247
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeStopComponent_SetValue
	{
		// Token: 0x04002131 RID: 8497
		public bool? Disabled;

		// Token: 0x04002132 RID: 8498
		public bool? EdIsLocked;

		// Token: 0x04002133 RID: 8499
		public string ActiveState;

		// Token: 0x04002134 RID: 8500
		public int StopTime;

		// Token: 0x04002135 RID: 8501
		public ITimeStopTarget Target;
	}
}
