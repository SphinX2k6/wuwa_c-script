using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060A8 RID: 24744
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedConfigContext : ActivityBaseData
	{
		// Token: 0x1700909D RID: 37021
		// (get) Token: 0x0603E8DB RID: 256219 RVA: 0x00F1E6C6 File Offset: 0x00F1C8C6
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

		// Token: 0x1700909E RID: 37022
		// (get) Token: 0x0603E8DC RID: 256220 RVA: 0x00F1E6DC File Offset: 0x00F1C8DC
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

		// Token: 0x1700909F RID: 37023
		// (get) Token: 0x0603E8DD RID: 256221 RVA: 0x00F1E6F4 File Offset: 0x00F1C8F4
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

		// Token: 0x170090A0 RID: 37024
		// (get) Token: 0x0603E8DE RID: 256222 RVA: 0x00F1E790 File Offset: 0x00F1C990
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

		// Token: 0x0603E8DF RID: 256223 RVA: 0x00F1E7A8 File Offset: 0x00F1C9A8
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

		// Token: 0x0603E8E0 RID: 256224 RVA: 0x00F1E844 File Offset: 0x00F1CA44
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

		// Token: 0x0603E8E1 RID: 256225 RVA: 0x00F1E8BC File Offset: 0x00F1CABC
		public SolarSpeedConfigContext(SolarSpeedModel model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x0603E8E2 RID: 256226 RVA: 0x00F1E8CB File Offset: 0x00F1CACB
		public void Dispose()
		{
			this.CurrentCfgCache.Clear();
			this.CurrentRewardCache.Clear();
		}

		// Token: 0x0603E8E3 RID: 256227 RVA: 0x00F1E8E4 File Offset: 0x00F1CAE4
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

		// Token: 0x0603E8E4 RID: 256228 RVA: 0x00F1E90C File Offset: 0x00F1CB0C
		public int? GetLevelIdByInstanceId(int instanceId)
		{
			int value;
			if (!this.InstanceId2LevelIdReverseMap.TryGetValue(instanceId, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0603E8E5 RID: 256229 RVA: 0x00F1E93C File Offset: 0x00F1CB3C
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

		// Token: 0x0603E8E6 RID: 256230 RVA: 0x00F1E96C File Offset: 0x00F1CB6C
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

		// Token: 0x0603E8E7 RID: 256231 RVA: 0x00F1E9B4 File Offset: 0x00F1CBB4
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

		// Token: 0x0603E8E8 RID: 256232 RVA: 0x00F1EA00 File Offset: 0x00F1CC00
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

		// Token: 0x0603E8E9 RID: 256233 RVA: 0x00F1EA44 File Offset: 0x00F1CC44
		public int GetRewardThresholdById(int id)
		{
			TeamParKOurReward teamParKOurReward;
			if (!this.CurrentRewardCache.TryGetValue(id, out teamParKOurReward))
			{
				return 0;
			}
			return teamParKOurReward.RewardThreshold;
		}

		// Token: 0x0603E8EA RID: 256234 RVA: 0x00F1EA6C File Offset: 0x00F1CC6C
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

		// Token: 0x0603E8EB RID: 256235 RVA: 0x00F1EAC0 File Offset: 0x00F1CCC0
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

		// Token: 0x04020B87 RID: 134023
		private readonly SolarSpeedModel AttachedModel;

		// Token: 0x04020B88 RID: 134024
		[Nullable(2)]
		private Dictionary<int, TeamParKOurCfg> CurrentCfgCacheInternal;

		// Token: 0x04020B89 RID: 134025
		[Nullable(2)]
		private Dictionary<int, TeamParKOurReward> CurrentRewardCacheInternal;

		// Token: 0x04020B8A RID: 134026
		[Nullable(2)]
		private Dictionary<int, int> InstanceId2LevelIdReverseCacheInternal;

		// Token: 0x04020B8B RID: 134027
		[Nullable(2)]
		private List<SettleFlag> SortedSettleCfgCacheInternal;
	}
}
