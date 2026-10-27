using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000176 RID: 374
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowerPollutionComponent_SetValue
	{
		// Token: 0x04000724 RID: 1828
		public bool? Disabled;

		// Token: 0x04000725 RID: 1829
		public bool? EdIsLocked;

		// Token: 0x04000726 RID: 1830
		public IFlowerPollutionSplineConfig SplineConfigs;

		// Token: 0x04000727 RID: 1831
		public IFlowerPollutionPointLightConfig PointLightConfig;

		// Token: 0x04000728 RID: 1832
		public List<int> ObstacleEntityIds;

		// Token: 0x04000729 RID: 1833
		public List<int> PollutionSourceEntityIds;

		// Token: 0x0400072A RID: 1834
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> OnEnterPollutionRangeActions;

		// Token: 0x0400072B RID: 1835
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> OnLeavePollutionRangeActions;

		// Token: 0x0400072C RID: 1836
		public string BakeData;
	}
}
