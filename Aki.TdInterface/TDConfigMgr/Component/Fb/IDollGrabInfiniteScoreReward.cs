using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF7 RID: 3575
	public class IDollGrabInfiniteScoreReward
	{
		// Token: 0x060050F8 RID: 20728 RVA: 0x000C7D79 File Offset: 0x000C5F79
		[NullableContext(1)]
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

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x000C7D98 File Offset: 0x000C5F98
		public virtual int TargetScore
		{
			get
			{
				return this.Instance.TargetScore;
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x000C7DA5 File Offset: 0x000C5FA5
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x04002E8A RID: 11914
		private IDollGrabInfiniteScoreReward Instance;
	}
}
