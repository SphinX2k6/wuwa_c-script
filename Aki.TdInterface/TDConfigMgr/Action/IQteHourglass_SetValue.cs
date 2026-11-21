using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F8C RID: 8076
	public class IQteHourglass_SetValue
	{
		// Token: 0x040066BF RID: 26303
		public ESimpleGameplayType Type;

		// Token: 0x040066C0 RID: 26304
		[Nullable(2)]
		public List<int> QteIds;

		// Token: 0x040066C1 RID: 26305
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IQteHourglassConfig> QteConfigs;
	}
}
