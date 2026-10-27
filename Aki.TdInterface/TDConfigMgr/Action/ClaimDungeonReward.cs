using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014F2 RID: 5362
	public class ClaimDungeonReward : ActionParams
	{
		// Token: 0x060079FC RID: 31228 RVA: 0x0012394B File Offset: 0x00121B4B
		[NullableContext(1)]
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

		// Token: 0x040046B6 RID: 18102
		[Nullable(2)]
		protected new ClaimDungeonReward FbInstance;
	}
}
