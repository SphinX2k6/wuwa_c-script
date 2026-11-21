using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096A RID: 2410
	public class TimeStopComponent_SetValue
	{
		// Token: 0x04002343 RID: 9027
		public bool? Disabled;

		// Token: 0x04002344 RID: 9028
		public bool? EdIsLocked;

		// Token: 0x04002345 RID: 9029
		public string ActiveState;

		// Token: 0x04002346 RID: 9030
		public int StopTime;

		// Token: 0x04002347 RID: 9031
		public ITimeStopTarget Target;
	}
}
