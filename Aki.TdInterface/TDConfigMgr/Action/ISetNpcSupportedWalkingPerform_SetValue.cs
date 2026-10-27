using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E39 RID: 7737
	public class ISetNpcSupportedWalkingPerform_SetValue
	{
		// Token: 0x040062F9 RID: 25337
		public ENpcGroupPerformType Type;

		// Token: 0x040062FA RID: 25338
		[Nullable(1)]
		public IPlayerInitiator Initiator;

		// Token: 0x040062FB RID: 25339
		public int Target;
	}
}
