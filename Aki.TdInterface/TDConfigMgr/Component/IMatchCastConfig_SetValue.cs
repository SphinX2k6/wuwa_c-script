using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004DB RID: 1243
	public class IMatchCastConfig_SetValue
	{
		// Token: 0x04001288 RID: 4744
		public int Time;

		// Token: 0x04001289 RID: 4745
		[Nullable(1)]
		public string Spline;

		// Token: 0x0400128A RID: 4746
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMatchSequence> MatchSequence;

		// Token: 0x0400128B RID: 4747
		[Nullable(2)]
		public string SpeedCurve;
	}
}
