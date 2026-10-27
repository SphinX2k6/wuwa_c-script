using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221B RID: 8731
	[NullableContext(1)]
	[Nullable(0)]
	public class StartMotorCruise_SetValue
	{
		// Token: 0x0400724E RID: 29262
		public ISplineWayPoint StartPoint;

		// Token: 0x0400724F RID: 29263
		public ISplineWayPoint EndPoint;

		// Token: 0x04007250 RID: 29264
		public bool AllowSkip;
	}
}
