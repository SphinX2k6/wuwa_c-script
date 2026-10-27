using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002177 RID: 8567
	public class RollBlockGetReward : ActionParams
	{
		// Token: 0x0600BC5A RID: 48218 RVA: 0x001B252D File Offset: 0x001B072D
		[NullableContext(1)]
		public static RollBlockGetReward Create([Nullable(2)] RollBlockGetReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockGetReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x04007081 RID: 28801
		[Nullable(2)]
		protected new RollBlockGetReward FbInstance;
	}
}
