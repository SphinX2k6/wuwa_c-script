using System;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200077E RID: 1918
	public class ISlopeSlidePerform_SetValue
	{
		// Token: 0x04001BC8 RID: 7112
		public ESlidePerformType Type;

		// Token: 0x04001BC9 RID: 7113
		public int? TriggerLandingDistance;

		// Token: 0x04001BCA RID: 7114
		public int? FallbackLandingPointId;

		// Token: 0x04001BCB RID: 7115
		public bool? IsAllowJump;
	}
}
