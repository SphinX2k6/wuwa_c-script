using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E33 RID: 7731
	public class ISetNpcHandInHandPerform_SetValue
	{
		// Token: 0x040062E2 RID: 25314
		public ENpcGroupPerformType Type;

		// Token: 0x040062E3 RID: 25315
		[Nullable(1)]
		public IHandInHandInitiator Initiator;

		// Token: 0x040062E4 RID: 25316
		public int Follower;
	}
}
