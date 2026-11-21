using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F2 RID: 1778
	public class IRandomNpcRule_SetValue
	{
		// Token: 0x04001A09 RID: 6665
		public ERefreshRule Type;

		// Token: 0x04001A0A RID: 6666
		public List<IFixedDateTime> DateTimeList;

		// Token: 0x04001A0B RID: 6667
		public IProbabilityRefreshGroup ProbabilityRefreshGroup;
	}
}
