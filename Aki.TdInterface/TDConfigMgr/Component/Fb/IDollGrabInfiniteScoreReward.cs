using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF3 RID: 3827
	public class IDollGrabInfiniteScoreReward
	{
		// Token: 0x0600561F RID: 22047 RVA: 0x000D3641 File Offset: 0x000D1841
		public static IDollGrabInfiniteScoreReward Create(IDollGrabInfiniteScoreReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabInfiniteScoreReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06005620 RID: 22048 RVA: 0x000D3660 File Offset: 0x000D1860
		public virtual int TargetScore
		{
			get
			{
				return this.Instance.TargetScore;
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06005621 RID: 22049 RVA: 0x000D366D File Offset: 0x000D186D
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x04003152 RID: 12626
		private IDollGrabInfiniteScoreReward Instance;
	}
}
