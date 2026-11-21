using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000306 RID: 774
	public class IDollGrabInfiniteModeData
	{
		// Token: 0x06000E63 RID: 3683 RVA: 0x000348B0 File Offset: 0x00032AB0
		private IDollGrabInfiniteModeData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabInfiniteModeData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabInfiniteModeData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabInfiniteModeData_SetValue());
			}
			return result;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x000348E8 File Offset: 0x00032AE8
		public static IDollGrabInfiniteModeData Create([Nullable(2)] IDollGrabInfiniteModeData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabInfiniteModeData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000348FB File Offset: 0x00032AFB
		public static IDollGrabInfiniteModeData CreateFromSetValue([Nullable(2)] IDollGrabInfiniteModeData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabInfiniteModeData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00034910 File Offset: 0x00032B10
		public IDollGrabInfiniteModeData_SetValue ToSetValue()
		{
			return new IDollGrabInfiniteModeData_SetValue
			{
				StandbyItemPool = this.StandbyItemPool,
				RefreshIntervalCurve = this.RefreshIntervalCurve,
				StageConfigs = this.StageConfigs,
				ScoreRewards = this.ScoreRewards,
				ScoreReward = this.ScoreReward,
				UnlockConditionGroupId = this.UnlockConditionGroupId
			};
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0003496C File Offset: 0x00032B6C
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x000349FF File Offset: 0x00032BFF
		public virtual List<IDollGrabStandbyPoolItem> StandbyItemPool
		{
			get
			{
				if (this._StandbyItemPoolInited)
				{
					return this._StandbyItemPoolCache;
				}
				this._StandbyItemPoolInited = true;
				if (this.FbInstance != null)
				{
					List<IDollGrabStandbyPoolItem> standbyItemPool = this.FbInstance.StandbyItemPool;
					if (standbyItemPool != null)
					{
						this._StandbyItemPoolCache = new List<IDollGrabStandbyPoolItem>(standbyItemPool.Count);
						for (int i = 0; i < standbyItemPool.Count; i++)
						{
							this._StandbyItemPoolCache.Add(IDollGrabStandbyPoolItem.Create(standbyItemPool[i]));
						}
					}
				}
				else
				{
					IDollGrabInfiniteModeData_SetValue pocoInterface = this.PocoInterface;
					this._StandbyItemPoolCache = ((pocoInterface != null) ? pocoInterface.StandbyItemPool : null);
				}
				return this._StandbyItemPoolCache;
			}
			set
			{
				this.GetOrCreatePoco().StandbyItemPool = value;
				this._StandbyItemPoolInited = false;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00034A14 File Offset: 0x00032C14
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00034A3F File Offset: 0x00032C3F
		public virtual string RefreshIntervalCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshIntervalCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RefreshIntervalCurve;
			}
			set
			{
				this.GetOrCreatePoco().RefreshIntervalCurve = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00034A50 File Offset: 0x00032C50
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00034AE3 File Offset: 0x00032CE3
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
				if (this.FbInstance != null)
				{
					List<IDollGrabInfiniteStageConfig> stageConfigs = this.FbInstance.StageConfigs;
					if (stageConfigs != null)
					{
						this._StageConfigsCache = new List<IDollGrabInfiniteStageConfig>(stageConfigs.Count);
						for (int i = 0; i < stageConfigs.Count; i++)
						{
							this._StageConfigsCache.Add(IDollGrabInfiniteStageConfig.Create(stageConfigs[i]));
						}
					}
				}
				else
				{
					IDollGrabInfiniteModeData_SetValue pocoInterface = this.PocoInterface;
					this._StageConfigsCache = ((pocoInterface != null) ? pocoInterface.StageConfigs : null);
				}
				return this._StageConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().StageConfigs = value;
				this._StageConfigsInited = false;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00034AF8 File Offset: 0x00032CF8
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00034B8B File Offset: 0x00032D8B
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
				if (this.FbInstance != null)
				{
					List<IDollGrabInfiniteScoreReward> scoreRewards = this.FbInstance.ScoreRewards;
					if (scoreRewards != null)
					{
						this._ScoreRewardsCache = new List<IDollGrabInfiniteScoreReward>(scoreRewards.Count);
						for (int i = 0; i < scoreRewards.Count; i++)
						{
							this._ScoreRewardsCache.Add(IDollGrabInfiniteScoreReward.Create(scoreRewards[i]));
						}
					}
				}
				else
				{
					IDollGrabInfiniteModeData_SetValue pocoInterface = this.PocoInterface;
					this._ScoreRewardsCache = ((pocoInterface != null) ? pocoInterface.ScoreRewards : null);
				}
				return this._ScoreRewardsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().ScoreRewards = value;
				this._ScoreRewardsInited = false;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00034BA0 File Offset: 0x00032DA0
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00034C01 File Offset: 0x00032E01
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
				if (this.FbInstance != null)
				{
					this._ScoreRewardCache = IDollGrabInfiniteScoreReward.Create(this.FbInstance.ScoreReward);
				}
				else
				{
					IDollGrabInfiniteModeData_SetValue pocoInterface = this.PocoInterface;
					this._ScoreRewardCache = ((pocoInterface != null) ? pocoInterface.ScoreReward : null);
				}
				return this._ScoreRewardCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ScoreReward = value;
				this._ScoreRewardInited = false;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00034C18 File Offset: 0x00032E18
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x00034C52 File Offset: 0x00032E52
		public virtual int? UnlockConditionGroupId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UnlockConditionGroupId;
				}
				IDollGrabInfiniteModeData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UnlockConditionGroupId;
			}
			set
			{
				this.GetOrCreatePoco().UnlockConditionGroupId = value;
			}
		}

		// Token: 0x04000CF3 RID: 3315
		[Nullable(2)]
		protected IDollGrabInfiniteModeData FbInstance;

		// Token: 0x04000CF4 RID: 3316
		[Nullable(2)]
		protected IDollGrabInfiniteModeData_SetValue PocoInterface;

		// Token: 0x04000CF5 RID: 3317
		private List<IDollGrabStandbyPoolItem> _StandbyItemPoolCache;

		// Token: 0x04000CF6 RID: 3318
		private bool _StandbyItemPoolInited;

		// Token: 0x04000CF7 RID: 3319
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDollGrabInfiniteStageConfig> _StageConfigsCache;

		// Token: 0x04000CF8 RID: 3320
		private bool _StageConfigsInited;

		// Token: 0x04000CF9 RID: 3321
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDollGrabInfiniteScoreReward> _ScoreRewardsCache;

		// Token: 0x04000CFA RID: 3322
		private bool _ScoreRewardsInited;

		// Token: 0x04000CFB RID: 3323
		private IDollGrabInfiniteScoreReward _ScoreRewardCache;

		// Token: 0x04000CFC RID: 3324
		private bool _ScoreRewardInited;
	}
}
