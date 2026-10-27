using System;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006DD RID: 1757
	public class ISlopeSlidePerform_SetValue
	{
		// Token: 0x040019C9 RID: 6601
		public ESlidePerformType Type;

		// Token: 0x040019CA RID: 6602
		public int? TriggerLandingDistance;

		// Token: 0x040019CB RID: 6603
		public int? FallbackLandingPointId;

		// Token: 0x040019CC RID: 6604
		public bool? IsAllowJump;
	}
}
