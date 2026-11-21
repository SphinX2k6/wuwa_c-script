using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005026 RID: 20518
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedConfigContext : ActivityBaseData
	{
		// Token: 0x170063FF RID: 25599
		// (get) Token: 0x0603359F RID: 210335 RVA: 0x00E6548A File Offset: 0x00E6368A
		public Dictionary<int, TeamParKOurCfg> CurrentCfgCache
		{
			get
			{
				if (this.CurrentCfgCacheInternal == null)
				{
					this.InitCurrentCfgCache();
				}
				return this.CurrentCfgCacheInternal;
			}
		}

		// Token: 0x17006400 RID: 25600
		// (get) Token: 0x060335A0 RID: 210336 RVA: 0x00E654A0 File Offset: 0x00E636A0
		public Dictionary<int, TeamParKOurReward> CurrentRewardCache
		{
			get
			{
				if (this.CurrentRewardCacheInternal == null)
				{
					this.InitCurrentRewardCache();
				}
				return this.CurrentRewardCacheInternal;
			}
		}

		// Token: 0x17006401 RID: 25601
		// (get) Token: 0x060335A1 RID: 210337 RVA: 0x00E654B8 File Offset: 0x00E636B8
		public List<SettleFlag> SortedSettleCfgCache
		{
			get
			{
				if (this.SortedSettleCfgCacheInternal == null)
				{
					this.SortedSettleCfgCacheInternal = new List<SettleFlag>();
					IReadOnlyList<SettleFlag> configList = ConfigSettleFlagAll.GetConfigList(true);
					if (configList != null)
					{
						foreach (SettleFlag item in configList)
						{
							this.SortedSettleCfgCacheInternal.Add(item);
						}
						this.SortedSettleCfgCacheInternal.Sort((SettleFlag a, SettleFlag b) => a.Priority - b.Priority);
					}
				}
				return this.SortedSettleCfgCacheInternal;
			}
		}

		// Token: 0x17006402 RID: 25602
		// (get) Token: 0x060335A2 RID: 210338 RVA: 0x00E65554 File Offset: 0x00E63754
		private Dictionary<int, int> InstanceId2LevelIdReverseMap
		{
			get
			{
				if (this.InstanceId2LevelIdReverseCacheInternal == null)
				{
					this.InitCurrentCfgCache();
				}
				return this.InstanceId2LevelIdReverseCacheInternal;
			}
		}

		// Token: 0x060335A3 RID: 210339 RVA: 0x00E6556C File Offset: 0x00E6376C
		private void InitCurrentCfgCache()
		{
			this.CurrentCfgCacheInternal = new Dictionary<int, TeamParKOurCfg>();
			this.InstanceId2LevelIdReverseCacheInternal = new Dictionary<int, int>();
			foreach (TeamParKOurCfg value in ConfigTeamParKOurCfgAll.GetConfigList(true))
			{
				if (value.ActivityId == this.AttachedModel.CurrentActivityId)
				{
					this.CurrentCfgCacheInternal[value.Id] = value;
					this.InstanceId2LevelIdReverseCacheInternal[value.InstId] = value.Id;
				}
			}
		}

		// Token: 0x060335A4 RID: 210340 RVA: 0x00E65608 File Offset: 0x00E63808
		private void InitCurrentRewardCache()
		{
			this.CurrentRewardCacheInternal = new Dictionary<int, TeamParKOurReward>();
			foreach (TeamParKOurReward value in ConfigTeamParKOurRewardAll.GetConfigList(true))
			{
				if (value.ActivityId == this.AttachedModel.CurrentActivityId)
				{
					this.CurrentRewardCacheInternal[value.Id] = value;
				}
			}
		}

		// Token: 0x060335A5 RID: 210341 RVA: 0x00E65680 File Offset: 0x00E63880
		public SolarSpeedConfigContext(SolarSpeedModel model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x060335A6 RID: 210342 RVA: 0x00E6568F File Offset: 0x00E6388F
		public void Dispose()
		{
			this.CurrentCfgCache.Clear();
			this.CurrentRewardCache.Clear();
		}

		// Token: 0x060335A7 RID: 210343 RVA: 0x00E656A8 File Offset: 0x00E638A8
		[NullableContext(2)]
		public string GetInfoPicturePathById(int id)
		{
			TeamParKOurCfg teamParKOurCfg;
			if (!this.CurrentCfgCache.TryGetValue(id, out teamParKOurCfg))
			{
				return null;
			}
			return teamParKOurCfg.DescPicPath;
		}

		// Token: 0x060335A8 RID: 210344 RVA: 0x00E656D0 File Offset: 0x00E638D0
		public int? GetLevelIdByInstanceId(int instanceId)
		{
			int value;
			if (!this.InstanceId2LevelIdReverseMap.TryGetValue(instanceId, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060335A9 RID: 210345 RVA: 0x00E65700 File Offset: 0x00E63900
		[NullableContext(2)]
		public string GetInfoPicturePathByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				return null;
			}
			return this.GetInfoPicturePathById(levelIdByInstanceId.Value);
		}

		// Token: 0x060335AA RID: 210346 RVA: 0x00E65730 File Offset: 0x00E63930
		[NullableContext(2)]
		public string GetTitleTextIdById(int id)
		{
			TeamParKOurCfg teamParKOurCfg;
			if (!this.CurrentCfgCache.TryGetValue(id, out teamParKOurCfg))
			{
				return null;
			}
			if (ConfigInstanceDungeonById.GetConfig(teamParKOurCfg.InstId, true) == null)
			{
				return null;
			}
			InstanceDungeon? instanceDungeon;
			return instanceDungeon.GetValueOrDefault().MapName;
		}

		// Token: 0x060335AB RID: 210347 RVA: 0x00E65778 File Offset: 0x00E63978
		[NullableContext(2)]
		public string GetRomePathById(int id)
		{
			TeamParKOurCfg teamParKOurCfg;
			if (!this.CurrentCfgCache.TryGetValue(id, out teamParKOurCfg))
			{
				return null;
			}
			int instId = teamParKOurCfg.InstId;
			if (ConfigInstanceDungeonById.GetConfig(instId, true) == null)
			{
				return null;
			}
			InstanceDungeon? instanceDungeon;
			return instanceDungeon.GetValueOrDefault().DifficultyIcon;
		}

		// Token: 0x060335AC RID: 210348 RVA: 0x00E657C4 File Offset: 0x00E639C4
		public IReadOnlyList<int> GetTaskListById(int id)
		{
			if (id == 99)
			{
				return SolarSpeedDefine.bonusRewardList;
			}
			TeamParKOurCfg teamParKOurCfg;
			if (!this.CurrentCfgCache.TryGetValue(id, out teamParKOurCfg) || teamParKOurCfg.GetTaskListArray() == null)
			{
				return new List<int>();
			}
			return teamParKOurCfg.GetTaskListArray();
		}

		// Token: 0x060335AD RID: 210349 RVA: 0x00E65808 File Offset: 0x00E63A08
		public int GetRewardThresholdById(int id)
		{
			TeamParKOurReward teamParKOurReward;
			if (!this.CurrentRewardCache.TryGetValue(id, out teamParKOurReward))
			{
				return 0;
			}
			return teamParKOurReward.RewardThreshold;
		}

		// Token: 0x060335AE RID: 210350 RVA: 0x00E65830 File Offset: 0x00E63A30
		public List<TItem> GetRewardItemDataListById(int id)
		{
			List<TItem> result = new List<TItem>();
			TeamParKOurReward? config = ConfigTeamParKOurRewardById.GetConfig(id, true);
			if (config == null)
			{
				return result;
			}
			if (config.Value.Reward == 0)
			{
				return result;
			}
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.Value.Reward);
		}

		// Token: 0x060335AF RID: 210351 RVA: 0x00E65884 File Offset: 0x00E63A84
		[NullableContext(2)]
		public string GetRewardTitleTextId(int id)
		{
			if (ConfigTeamParKOurRewardById.GetConfig(id, true) == null)
			{
				return null;
			}
			TeamParKOurReward? teamParKOurReward;
			return teamParKOurReward.GetValueOrDefault().TaskTitle;
		}

		// Token: 0x0401B4B4 RID: 111796
		private readonly SolarSpeedModel AttachedModel;

		// Token: 0x0401B4B5 RID: 111797
		[Nullable(2)]
		private Dictionary<int, TeamParKOurCfg> CurrentCfgCacheInternal;

		// Token: 0x0401B4B6 RID: 111798
		[Nullable(2)]
		private Dictionary<int, TeamParKOurReward> CurrentRewardCacheInternal;

		// Token: 0x0401B4B7 RID: 111799
		[Nullable(2)]
		private Dictionary<int, int> InstanceId2LevelIdReverseCacheInternal;

		// Token: 0x0401B4B8 RID: 111800
		[Nullable(2)]
		private List<SettleFlag> SortedSettleCfgCacheInternal;
	}
}
