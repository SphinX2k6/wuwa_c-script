using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002BCF RID: 11215
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TowerClimbConfig : ConfigBase
{
	// Token: 0x06017493 RID: 95379 RVA: 0x005EB400 File Offset: 0x005E9600
	public int GetAreaFloorNumber(int season, int difficulty, int area)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		int num = 0;
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty && towerConfig.AreaNum == area)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06017494 RID: 95380 RVA: 0x005EB470 File Offset: 0x005E9670
	public int GetDifficultyFloorNumber(int season, int difficulty)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		int num = 0;
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06017495 RID: 95381 RVA: 0x005EB4D4 File Offset: 0x005E96D4
	public int GetDifficultyLastFloor(int season, int difficulty)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		int num = -1;
		int num2 = -1;
		int result = -1;
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty)
				{
					if (num < towerConfig.AreaNum)
					{
						num = towerConfig.AreaNum;
						num2 = -1;
					}
					if (num2 < towerConfig.Floor)
					{
						result = towerConfig.Id;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06017496 RID: 95382 RVA: 0x005EB564 File Offset: 0x005E9764
	public int[] GetDifficultyAllFloor(int season, int difficulty)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		List<int> list = new List<int>();
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty)
				{
					list.Add(towerConfig.Id);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06017497 RID: 95383 RVA: 0x005EB5DC File Offset: 0x005E97DC
	public int[] GetDifficultyAllAreaFirstFloor(int season, int difficulty)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		int num = -1;
		List<int> list = new List<int>();
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty && num != towerConfig.AreaNum)
				{
					list.Add(towerConfig.Id);
					num = towerConfig.AreaNum;
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06017498 RID: 95384 RVA: 0x005EB668 File Offset: 0x005E9868
	public int[] GetDifficultyAreaAllFloor(int season, int difficulty, int area)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		List<int> list = new List<int>();
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (difficulty == towerConfig.Difficulty && area == towerConfig.AreaNum)
				{
					list.Add(towerConfig.Id);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06017499 RID: 95385 RVA: 0x005EB6E8 File Offset: 0x005E98E8
	[NullableContext(2)]
	public IReadOnlyList<IntPair> GetDifficultyReward(int difficulty, int rewardGroup)
	{
		if (rewardGroup == 0)
		{
			return null;
		}
		IReadOnlyList<TowerSeasonReward> configList = ConfigTowerSeasonRewardByDifficulty.GetConfigList(difficulty, true);
		if (configList == null)
		{
			return null;
		}
		foreach (TowerSeasonReward towerSeasonReward in configList)
		{
			if (towerSeasonReward.RewardGroup == rewardGroup)
			{
				return towerSeasonReward.Reward();
			}
		}
		return null;
	}

	// Token: 0x0601749A RID: 95386 RVA: 0x005EB754 File Offset: 0x005E9954
	public string GetTowerBuffDesc(long buffId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetTowerBuffConfig(buffId).Value.Desc, null);
	}

	// Token: 0x0601749B RID: 95387 RVA: 0x005EB780 File Offset: 0x005E9980
	public string GetTowerBuffName(long buffId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetTowerBuffConfig(buffId).Value.Name, null);
	}

	// Token: 0x0601749C RID: 95388 RVA: 0x005EB7AC File Offset: 0x005E99AC
	[NullableContext(2)]
	public string GetTowerBuffIcon(long buffId)
	{
		TowerBuff? towerBuffConfig = this.GetTowerBuffConfig(buffId);
		if (towerBuffConfig == null)
		{
			return null;
		}
		return towerBuffConfig.GetValueOrDefault().Icon;
	}

	// Token: 0x0601749D RID: 95389 RVA: 0x005EB7DC File Offset: 0x005E99DC
	public TowerBuff? GetTowerBuffConfig(long buffId)
	{
		TowerBuff? config = ConfigTowerBuffById.GetConfig(buffId, true);
		if (config != null)
		{
			return config;
		}
		return null;
	}

	// Token: 0x0601749E RID: 95390 RVA: 0x005EB808 File Offset: 0x005E9A08
	[NullableContext(2)]
	public IReadOnlyList<int> GetFloorTarget(int floorId)
	{
		TowerConfig? config = ConfigTowerConfigById.GetConfig(floorId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().TargetConfig();
	}

	// Token: 0x0601749F RID: 95391 RVA: 0x005EB837 File Offset: 0x005E9A37
	public TowerTarget? GetTargetConfig(int targetId)
	{
		return ConfigTowerTargetById.GetConfig(targetId, true);
	}

	// Token: 0x060174A0 RID: 95392 RVA: 0x005EB840 File Offset: 0x005E9A40
	public int GetNextFloorInArea(int towerId)
	{
		TowerConfig? config = ConfigTowerConfigById.GetConfig(towerId, true);
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList(config.Value.Season, true);
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == config.Value.Difficulty && towerConfig.AreaNum == config.Value.AreaNum && towerConfig.Floor > config.Value.Floor)
				{
					return towerConfig.Id;
				}
			}
			return 0;
		}
		return 0;
	}

	// Token: 0x060174A1 RID: 95393 RVA: 0x005EB8FC File Offset: 0x005E9AFC
	public int GetLastFloorInArea(int towerId)
	{
		TowerConfig? config = ConfigTowerConfigById.GetConfig(towerId, true);
		if (config.Value.Floor == 1)
		{
			return 0;
		}
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList(config.Value.Season, true);
		int result = 0;
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == config.Value.Difficulty && towerConfig.AreaNum == config.Value.AreaNum && towerConfig.Floor < config.Value.Floor)
				{
					result = towerConfig.Id;
				}
			}
		}
		return result;
	}

	// Token: 0x060174A2 RID: 95394 RVA: 0x005EB9CC File Offset: 0x005E9BCC
	public TowerConfig? GetTowerInfo(int towerId)
	{
		return ConfigTowerConfigById.GetConfig(towerId, true);
	}

	// Token: 0x060174A3 RID: 95395 RVA: 0x005EB9D5 File Offset: 0x005E9BD5
	public TowerSeason? GetTowerSeason(int seasonId)
	{
		return ConfigTowerSeasonById.GetConfig(seasonId, true);
	}

	// Token: 0x060174A4 RID: 95396 RVA: 0x005EB9E0 File Offset: 0x005E9BE0
	public string GetTowerAreaName(int towerId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(ConfigTowerConfigById.GetConfig(towerId, true).Value.AreaName, null);
	}

	// Token: 0x060174A5 RID: 95397 RVA: 0x005EBA0C File Offset: 0x005E9C0C
	public string GetNewTowerDifficultTitle(int difficultId)
	{
		switch (difficultId)
		{
		case 1:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_1", null) ?? string.Empty;
		case 2:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_2", null) ?? string.Empty;
		case 3:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_3", null) ?? string.Empty;
		case 4:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_4", null) ?? string.Empty;
		default:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_1", null) ?? string.Empty;
		}
	}

	// Token: 0x17001F64 RID: 8036
	// (get) Token: 0x060174A6 RID: 95398 RVA: 0x005EBA9B File Offset: 0x005E9C9B
	public static TowerClimbConfig Instance
	{
		get
		{
			return TowerClimbConfig._Instance;
		}
	}

	// Token: 0x060174A7 RID: 95399 RVA: 0x005EBAA2 File Offset: 0x005E9CA2
	public static TowerClimbConfig GetOrCreateInstance()
	{
		if (TowerClimbConfig._Instance == null)
		{
			TowerClimbConfig.CreateInstance();
		}
		return TowerClimbConfig._Instance;
	}

	// Token: 0x060174A8 RID: 95400 RVA: 0x005EBAB6 File Offset: 0x005E9CB6
	public static bool CreateInstance()
	{
		if (TowerClimbConfig._Instance != null)
		{
			return true;
		}
		TowerClimbConfig._Instance = new TowerClimbConfig();
		return true;
	}

	// Token: 0x060174A9 RID: 95401 RVA: 0x005EBACC File Offset: 0x005E9CCC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060174AA RID: 95402 RVA: 0x005EBACE File Offset: 0x005E9CCE
	public static void ResetStaticDefaultValue()
	{
		TowerClimbConfig._Instance = null;
	}

	// Token: 0x060174AB RID: 95403 RVA: 0x005EBAD6 File Offset: 0x005E9CD6
	static TowerClimbConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerClimbConfig.CreateStaticDefaultValue), new Action(TowerClimbConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400AE49 RID: 44617
	[Nullable(2)]
	private static TowerClimbConfig _Instance;
}
