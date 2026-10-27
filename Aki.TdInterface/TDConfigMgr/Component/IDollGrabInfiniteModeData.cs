using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002BF RID: 703
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabInfiniteModeData
	{
		// Token: 0x06000D33 RID: 3379 RVA: 0x0003197C File Offset: 0x0002FB7C
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

		// Token: 0x06000D34 RID: 3380 RVA: 0x000319B4 File Offset: 0x0002FBB4
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

		// Token: 0x06000D35 RID: 3381 RVA: 0x000319C7 File Offset: 0x0002FBC7
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

		// Token: 0x06000D36 RID: 3382 RVA: 0x000319DC File Offset: 0x0002FBDC
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

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00031A38 File Offset: 0x0002FC38
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00031ACB File Offset: 0x0002FCCB
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

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00031AE0 File Offset: 0x0002FCE0
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00031B0B File Offset: 0x0002FD0B
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

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00031B1C File Offset: 0x0002FD1C
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00031BAF File Offset: 0x0002FDAF
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().StageConfigs = value;
				this._StageConfigsInited = false;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00031BC4 File Offset: 0x0002FDC4
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00031C57 File Offset: 0x0002FE57
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().ScoreRewards = value;
				this._ScoreRewardsInited = false;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00031C6C File Offset: 0x0002FE6C
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00031CCD File Offset: 0x0002FECD
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

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00031CE4 File Offset: 0x0002FEE4
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00031D1E File Offset: 0x0002FF1E
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

		// Token: 0x04000C09 RID: 3081
		[Nullable(2)]
		protected IDollGrabInfiniteModeData FbInstance;

		// Token: 0x04000C0A RID: 3082
		[Nullable(2)]
		protected IDollGrabInfiniteModeData_SetValue PocoInterface;

		// Token: 0x04000C0B RID: 3083
		private List<IDollGrabStandbyPoolItem> _StandbyItemPoolCache;

		// Token: 0x04000C0C RID: 3084
		private bool _StandbyItemPoolInited;

		// Token: 0x04000C0D RID: 3085
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDollGrabInfiniteStageConfig> _StageConfigsCache;

		// Token: 0x04000C0E RID: 3086
		private bool _StageConfigsInited;

		// Token: 0x04000C0F RID: 3087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDollGrabInfiniteScoreReward> _ScoreRewardsCache;

		// Token: 0x04000C10 RID: 3088
		private bool _ScoreRewardsInited;

		// Token: 0x04000C11 RID: 3089
		private IDollGrabInfiniteScoreReward _ScoreRewardCache;

		// Token: 0x04000C12 RID: 3090
		private bool _ScoreRewardInited;
	}
}
