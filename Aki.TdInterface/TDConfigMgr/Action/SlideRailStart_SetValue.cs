using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247E RID: 9342
	public class SlideRailStart_SetValue
	{
		// Token: 0x04007877 RID: 30839
		public int RailEntityId;

		// Token: 0x04007878 RID: 30840
		public string SlidePerformDaPath;

		// Token: 0x04007879 RID: 30841
		[Nullable(2)]
		public ISlideRailFollowConfig SlideRailFollowConfig;

		// Token: 0x0400787A RID: 30842
		[Nullable(2)]
		public ISlideRailRTPCParams RTPCParams;
	}
}
