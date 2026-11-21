using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200164B RID: 5707
	public class ClaimDungeonReward : ActionParams
	{
		// Token: 0x060080C9 RID: 32969 RVA: 0x00132583 File Offset: 0x00130783
		public static ClaimDungeonReward Create([Nullable(2)] ClaimDungeonReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClaimDungeonReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004A51 RID: 19025
		[Nullable(2)]
		protected new ClaimDungeonReward FbInstance;
	}
}
