using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200164E RID: 5710
	public class ClaimLevelPlayReward : ActionParams
	{
		// Token: 0x060080D3 RID: 32979 RVA: 0x0013269A File Offset: 0x0013089A
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

		// Token: 0x04004A57 RID: 19031
		[Nullable(2)]
		protected new ClaimLevelPlayReward FbInstance;
	}
}
