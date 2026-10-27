using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B0 RID: 8368
	public class IVisualNovelTransitionTime_SetValue
	{
		// Token: 0x04006E62 RID: 28258
		public EVisualNovelTransitionType Type;

		// Token: 0x04006E63 RID: 28259
		[Nullable(1)]
		public IVisualNovelDate EndDate;

		// Token: 0x04006E64 RID: 28260
		public int EndPeriodId;

		// Token: 0x04006E65 RID: 28261
		public bool? IsFullScreen;
	}
}
