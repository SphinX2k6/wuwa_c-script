using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016B2 RID: 5810
	public class DangoAbyssCreateRewardTreasureBox : ActionParams
	{
		// Token: 0x0600824D RID: 33357 RVA: 0x00138846 File Offset: 0x00136A46
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

		// Token: 0x04004ABA RID: 19130
		[Nullable(2)]
		protected new DangoAbyssCreateRewardTreasureBox FbInstance;
	}
}
