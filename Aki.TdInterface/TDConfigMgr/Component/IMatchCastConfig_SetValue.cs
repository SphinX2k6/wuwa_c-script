using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000534 RID: 1332
	public class IMatchCastConfig_SetValue
	{
		// Token: 0x040013AA RID: 5034
		public int Time;

		// Token: 0x040013AB RID: 5035
		public string Spline;

		// Token: 0x040013AC RID: 5036
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMatchSequence> MatchSequence;

		// Token: 0x040013AD RID: 5037
		[Nullable(2)]
		public string SpeedCurve;
	}
}
