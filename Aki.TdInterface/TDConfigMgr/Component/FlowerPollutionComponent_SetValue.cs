using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018B RID: 395
	public class FlowerPollutionComponent_SetValue
	{
		// Token: 0x04000771 RID: 1905
		public bool? Disabled;

		// Token: 0x04000772 RID: 1906
		public bool? EdIsLocked;

		// Token: 0x04000773 RID: 1907
		public IFlowerPollutionSplineConfig SplineConfigs;

		// Token: 0x04000774 RID: 1908
		public IFlowerPollutionPointLightConfig PointLightConfig;

		// Token: 0x04000775 RID: 1909
		public List<int> ObstacleEntityIds;

		// Token: 0x04000776 RID: 1910
		public List<int> PollutionSourceEntityIds;

		// Token: 0x04000777 RID: 1911
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> OnEnterPollutionRangeActions;

		// Token: 0x04000778 RID: 1912
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> OnLeavePollutionRangeActions;

		// Token: 0x04000779 RID: 1913
		public string BakeData;
	}
}
