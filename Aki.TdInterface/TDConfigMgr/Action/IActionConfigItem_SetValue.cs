using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001755 RID: 5973
	public class IActionConfigItem_SetValue
	{
		// Token: 0x04005088 RID: 20616
		public EOnlineParticipateRule? OnlineParticipateRule;

		// Token: 0x04005089 RID: 20617
		public bool? IsDetectScreenOccupation;

		// Token: 0x0400508A RID: 20618
		public bool? IsWithResultOnly;

		// Token: 0x0400508B RID: 20619
		public bool? IsOperatePlayer;

		// Token: 0x0400508C RID: 20620
		[Nullable(1)]
		public string CnName;
	}
}
