using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF4 RID: 3828
	public class IDollGrabInfiniteModeData
	{
		// Token: 0x06005623 RID: 22051 RVA: 0x000D3682 File Offset: 0x000D1882
		public static IDollGrabInfiniteModeData Create(IDollGrabInfiniteModeData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabInfiniteModeData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06005624 RID: 22052 RVA: 0x000D36A4 File Offset: 0x000D18A4
		public virtual List<IDollGrabStandbyPoolItem> StandbyItemPool
		{
			get
			{
				if (this._StandbyItemPoolInited)
				{
					return this._StandbyItemPoolCache;
				}
				this._StandbyItemPoolInited = true;
				int standbyItemPoolLength = this.Instance.StandbyItemPoolLength;
				this._StandbyItemPoolCache = new List<IDollGrabStandbyPoolItem>(standbyItemPoolLength);
				for (int i = 0; i < standbyItemPoolLength; i++)
				{
					this._StandbyItemPoolCache.Add(IDollGrabStandbyPoolItem.Create(this.Instance.StandbyItemPool(i)));
				}
				return this._StandbyItemPoolCache;
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06005625 RID: 22053 RVA: 0x000D370D File Offset: 0x000D190D
		public virtual string RefreshIntervalCurve
		{
			get
			{
				return this.Instance.RefreshIntervalCurve;
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06005626 RID: 22054 RVA: 0x000D371C File Offset: 0x000D191C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IDollGrabInfiniteStageConfig> StageConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._StageConfigsInited)
				{
					return this._StageConfigsCache;
				}
				this._StageConfigsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int stageConfigsLength = this.Instance.StageConfigsLength;
				this._StageConfigsCache = new List<IDollGrabInfiniteStageConfig>(stageConfigsLength);
				for (int i = 0; i < stageConfigsLength; i++)
				{
					this._StageConfigsCache.Add(IDollGrabInfiniteStageConfig.Create(this.Instance.StageConfigs(i)));
				}
				return this._StageConfigsCache;
			}
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06005627 RID: 22055 RVA: 0x000D3798 File Offset: 0x000D1998
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IDollGrabInfiniteScoreReward> ScoreRewards
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ScoreRewardsInited)
				{
					return this._ScoreRewardsCache;
				}
				this._ScoreRewardsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int scoreRewardsLength = this.Instance.ScoreRewardsLength;
				this._ScoreRewardsCache = new List<IDollGrabInfiniteScoreReward>(scoreRewardsLength);
				for (int i = 0; i < scoreRewardsLength; i++)
				{
					this._ScoreRewardsCache.Add(IDollGrabInfiniteScoreReward.Create(this.Instance.ScoreRewards(i)));
				}
				return this._ScoreRewardsCache;
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06005628 RID: 22056 RVA: 0x000D3812 File Offset: 0x000D1A12
		[Nullable(2)]
		public virtual IDollGrabInfiniteScoreReward ScoreReward
		{
			[NullableContext(2)]
			get
			{
				if (this._ScoreRewardInited)
				{
					return this._ScoreRewardCache;
				}
				this._ScoreRewardInited = true;
				this._ScoreRewardCache = IDollGrabInfiniteScoreReward.Create(this.Instance.ScoreReward);
				return this._ScoreRewardCache;
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x000D3848 File Offset: 0x000D1A48
		public virtual int? UnlockConditionGroupId
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.UnlockConditionGroupId);
			}
		}

		// Token: 0x04003153 RID: 12627
		private IDollGrabInfiniteModeData Instance;

		// Token: 0x04003154 RID: 12628
		private List<IDollGrabStandbyPoolItem> _StandbyItemPoolCache;

		// Token: 0x04003155 RID: 12629
		private bool _StandbyItemPoolInited;

		// Token: 0x04003156 RID: 12630
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDollGrabInfiniteStageConfig> _StageConfigsCache;

		// Token: 0x04003157 RID: 12631
		private bool _StageConfigsInited;

		// Token: 0x04003158 RID: 12632
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDollGrabInfiniteScoreReward> _ScoreRewardsCache;

		// Token: 0x04003159 RID: 12633
		private bool _ScoreRewardsInited;

		// Token: 0x0400315A RID: 12634
		[Nullable(2)]
		private IDollGrabInfiniteScoreReward _ScoreRewardCache;

		// Token: 0x0400315B RID: 12635
		private bool _ScoreRewardInited;
	}
}
