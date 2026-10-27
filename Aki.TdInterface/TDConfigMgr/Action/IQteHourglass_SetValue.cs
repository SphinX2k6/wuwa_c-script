using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D7B RID: 7547
	public class IQteHourglass_SetValue
	{
		// Token: 0x04006143 RID: 24899
		public ESimpleGameplayType Type;

		// Token: 0x04006144 RID: 24900
		[Nullable(2)]
		public List<int> QteIds;

		// Token: 0x04006145 RID: 24901
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IQteHourglassConfig> QteConfigs;
	}
}
