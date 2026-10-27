using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001558 RID: 5464
	public class DangoAbyssReceiveReward : ActionParams
	{
		// Token: 0x06007B7D RID: 31613 RVA: 0x001298D0 File Offset: 0x00127AD0
		[NullableContext(1)]
		public static DangoAbyssReceiveReward Create([Nullable(2)] DangoAbyssReceiveReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssReceiveReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004720 RID: 18208
		[Nullable(2)]
		protected new DangoAbyssReceiveReward FbInstance;
	}
}
