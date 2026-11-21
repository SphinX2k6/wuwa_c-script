using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002305 RID: 8965
	public class IVisualNovelTransitionTime_SetValue
	{
		// Token: 0x04007480 RID: 29824
		public EVisualNovelTransitionType Type;

		// Token: 0x04007481 RID: 29825
		[Nullable(2)]
		public IVisualNovelDate EndDate;

		// Token: 0x04007482 RID: 29826
		public int EndPeriodId;

		// Token: 0x04007483 RID: 29827
		public bool? IsFullScreen;
	}
}
