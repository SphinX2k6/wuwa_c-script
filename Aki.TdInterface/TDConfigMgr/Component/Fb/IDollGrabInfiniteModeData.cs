using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF8 RID: 3576
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabInfiniteModeData
	{
		// Token: 0x060050FC RID: 20732 RVA: 0x000C7DBA File Offset: 0x000C5FBA
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

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x000C7DDC File Offset: 0x000C5FDC
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

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x000C7E45 File Offset: 0x000C6045
		public virtual string RefreshIntervalCurve
		{
			get
			{
				return this.Instance.RefreshIntervalCurve;
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x000C7E54 File Offset: 0x000C6054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IDollGrabInfiniteStageConfig> StageConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x000C7ED0 File Offset: 0x000C60D0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IDollGrabInfiniteScoreReward> ScoreRewards
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x000C7F4A File Offset: 0x000C614A
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

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x000C7F80 File Offset: 0x000C6180
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

		// Token: 0x04002E8B RID: 11915
		private IDollGrabInfiniteModeData Instance;

		// Token: 0x04002E8C RID: 11916
		private List<IDollGrabStandbyPoolItem> _StandbyItemPoolCache;

		// Token: 0x04002E8D RID: 11917
		private bool _StandbyItemPoolInited;

		// Token: 0x04002E8E RID: 11918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDollGrabInfiniteStageConfig> _StageConfigsCache;

		// Token: 0x04002E8F RID: 11919
		private bool _StageConfigsInited;

		// Token: 0x04002E90 RID: 11920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDollGrabInfiniteScoreReward> _ScoreRewardsCache;

		// Token: 0x04002E91 RID: 11921
		private bool _ScoreRewardsInited;

		// Token: 0x04002E92 RID: 11922
		[Nullable(2)]
		private IDollGrabInfiniteScoreReward _ScoreRewardCache;

		// Token: 0x04002E93 RID: 11923
		private bool _ScoreRewardInited;
	}
}
