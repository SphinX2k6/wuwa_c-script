using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001556 RID: 5462
	public class DangoAbyssCreateRewardTreasureBox : ActionParams
	{
		// Token: 0x06007B79 RID: 31609 RVA: 0x0012989A File Offset: 0x00127A9A
		[NullableContext(1)]
		public static DangoAbyssCreateRewardTreasureBox Create([Nullable(2)] DangoAbyssCreateRewardTreasureBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssCreateRewardTreasureBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400471E RID: 18206
		[Nullable(2)]
		protected new DangoAbyssCreateRewardTreasureBox FbInstance;
	}
}
