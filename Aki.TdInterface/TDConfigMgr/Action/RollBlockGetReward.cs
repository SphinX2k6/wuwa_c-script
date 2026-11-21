using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D8 RID: 9176
	public class RollBlockGetReward : ActionParams
	{
		// Token: 0x0600C7E8 RID: 51176 RVA: 0x001C96E1 File Offset: 0x001C78E1
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

		// Token: 0x040076B6 RID: 30390
		[Nullable(2)]
		protected new RollBlockGetReward FbInstance;
	}
}
