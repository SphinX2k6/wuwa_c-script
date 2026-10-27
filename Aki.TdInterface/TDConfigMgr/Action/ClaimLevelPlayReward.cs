using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014F5 RID: 5365
	public class ClaimLevelPlayReward : ActionParams
	{
		// Token: 0x06007A06 RID: 31238 RVA: 0x00123A62 File Offset: 0x00121C62
		[NullableContext(1)]
		public static ClaimLevelPlayReward Create([Nullable(2)] ClaimLevelPlayReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClaimLevelPlayReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x040046BC RID: 18108
		[Nullable(2)]
		protected new ClaimLevelPlayReward FbInstance;
	}
}
