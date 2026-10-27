using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000655 RID: 1621
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomNpcRule_SetValue
	{
		// Token: 0x04001817 RID: 6167
		public ERefreshRule Type;

		// Token: 0x04001818 RID: 6168
		public List<IFixedDateTime> DateTimeList;

		// Token: 0x04001819 RID: 6169
		public IProbabilityRefreshGroup ProbabilityRefreshGroup;
	}
}
