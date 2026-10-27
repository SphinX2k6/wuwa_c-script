using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002213 RID: 8723
	[NullableContext(2)]
	[Nullable(0)]
	public class SlideRailStart_SetValue
	{
		// Token: 0x0400722D RID: 29229
		public int RailEntityId;

		// Token: 0x0400722E RID: 29230
		[Nullable(1)]
		public string SlidePerformDaPath;

		// Token: 0x0400722F RID: 29231
		public ISlideRailFollowConfig SlideRailFollowConfig;

		// Token: 0x04007230 RID: 29232
		public ISlideRailRTPCParams RTPCParams;
	}
}
