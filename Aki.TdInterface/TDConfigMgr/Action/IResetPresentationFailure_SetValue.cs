using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB5 RID: 7605
	public class IResetPresentationFailure_SetValue
	{
		// Token: 0x040061C6 RID: 25030
		public EResetPresentationType Type;

		// Token: 0x040061C7 RID: 25031
		public float Duration;

		// Token: 0x040061C8 RID: 25032
		[Nullable(1)]
		public List<int> GamePlayCues;
	}
}
