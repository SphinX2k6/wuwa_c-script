using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016B4 RID: 5812
	public class DangoAbyssReceiveReward : ActionParams
	{
		// Token: 0x06008251 RID: 33361 RVA: 0x0013887C File Offset: 0x00136A7C
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

		// Token: 0x04004ABC RID: 19132
		[Nullable(2)]
		protected new DangoAbyssReceiveReward FbInstance;
	}
}
