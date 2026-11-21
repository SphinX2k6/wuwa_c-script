using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000B0E RID: 2830
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class WheelTowerConfig : ConfigBase
{
	// Token: 0x06007464 RID: 29796 RVA: 0x0024009D File Offset: 0x0023E29D
	public NewTowerParam? GetTowerConfig(int cycleId)
	{
		return ConfigNewTowerParamByCycleId.GetConfig(cycleId, true);
	}

	// Token: 0x06007465 RID: 29797 RVA: 0x002400A6 File Offset: 0x0023E2A6
	public NewTowerLevel? GetLevelConfigById(int levelId)
	{
		return ConfigNewTowerLevelById.GetConfig(levelId, true);
	}

	// Token: 0x06007466 RID: 29798 RVA: 0x002400AF File Offset: 0x0023E2AF
	public IReadOnlyList<NewTowerLevel> GetLevelConfigListByCycleId(int cycleId)
	{
		return ConfigNewTowerLevelByCycleId.GetConfigList(cycleId, true);
	}

	// Token: 0x06007467 RID: 29799 RVA: 0x002400B8 File Offset: 0x0023E2B8
	public NewTowerWave? GetWaveConfigById(int waveId)
	{
		return ConfigNewTowerWaveById.GetConfig(waveId, true);
	}

	// Token: 0x06007468 RID: 29800 RVA: 0x002400C1 File Offset: 0x0023E2C1
	public IReadOnlyList<NewTowerWave> GetWaveConfigListByLevelId(int levelId)
	{
		return ConfigNewTowerWaveByLevel.GetConfigList(levelId, true);
	}

	// Token: 0x06007469 RID: 29801 RVA: 0x002400CA File Offset: 0x0023E2CA
	public NewTowerBossBuff? GetBossBuffConfigById(int buffId)
	{
		return ConfigNewTowerBossBuffById.GetConfig(buffId, true);
	}

	// Token: 0x0600746A RID: 29802 RVA: 0x002400D3 File Offset: 0x0023E2D3
	public NewTowerBuff? GetBuffConfigById(int buffId)
	{
		return ConfigNewTowerBuffById.GetConfig(buffId, true);
	}

	// Token: 0x0600746B RID: 29803 RVA: 0x002400DC File Offset: 0x0023E2DC
	public NewTowerScoreReward? GetRewardConfigById(int rewardId)
	{
		return ConfigNewTowerScoreRewardById.GetConfig(rewardId, true);
	}

	// Token: 0x0600746C RID: 29804 RVA: 0x002400E5 File Offset: 0x0023E2E5
	public IReadOnlyList<NewTowerScoreReward> GetRewardConfigListByLevelId(int levelId)
	{
		return ConfigNewTowerScoreRewardByLevelId.GetConfigList(levelId, true);
	}

	// Token: 0x0600746D RID: 29805 RVA: 0x002400EE File Offset: 0x0023E2EE
	public IReadOnlyList<NewTowerRole> GetRoleConfigList()
	{
		return ConfigNewTowerRoleAll.GetConfigList(true);
	}

	// Token: 0x0600746E RID: 29806 RVA: 0x002400F6 File Offset: 0x0023E2F6
	public NewTowerRole? GetRoleConfigByRoleId(int roleId)
	{
		return ConfigNewTowerRoleById.GetConfig(roleId, true);
	}

	// Token: 0x0600746F RID: 29807 RVA: 0x002400FF File Offset: 0x0023E2FF
	public NewTowerTag? GetTagConfigByTagId(int tagId)
	{
		return ConfigNewTowerTagById.GetConfig(tagId, true);
	}

	// Token: 0x06007470 RID: 29808 RVA: 0x00240108 File Offset: 0x0023E308
	public NewTowerBossBuff? GetBossBuffConfig(int id)
	{
		return ConfigNewTowerBossBuffById.GetConfig(id, true);
	}

	// Token: 0x06007471 RID: 29809 RVA: 0x00240111 File Offset: 0x0023E311
	public NewTowerSeason? GetSeasonConfig(int seasonId)
	{
		return ConfigNewTowerSeasonById.GetConfig(seasonId, true);
	}

	// Token: 0x06007472 RID: 29810 RVA: 0x0024011C File Offset: 0x0023E31C
	public int GetSeasonScoreItemId(int seasonId)
	{
		if (this.GetSeasonConfig(seasonId) == null)
		{
			return 0;
		}
		NewTowerSeason? newTowerSeason;
		return newTowerSeason.GetValueOrDefault().ScoreItem;
	}

	// Token: 0x06007473 RID: 29811 RVA: 0x0024014B File Offset: 0x0023E34B
	public IReadOnlyList<NewTowerSeason> GetAllSeasonConfigs()
	{
		return ConfigNewTowerSeasonAll.GetConfigList(true);
	}

	// Token: 0x06007474 RID: 29812 RVA: 0x00240153 File Offset: 0x0023E353
	public NewTowerSeasonAward? GetSeasonTaskRewardConfig(int taskId)
	{
		return ConfigNewTowerSeasonAwardById.GetConfig(taskId, true);
	}

	// Token: 0x06007475 RID: 29813 RVA: 0x0024015C File Offset: 0x0023E35C
	public NewTowerSeasonSAward? GetSeasonScoreRewardConfig(int rewardId)
	{
		return ConfigNewTowerSeasonSAwardById.GetConfig(rewardId, true);
	}

	// Token: 0x06007476 RID: 29814 RVA: 0x00240165 File Offset: 0x0023E365
	public IReadOnlyList<NewTowerSeasonSAward> GetSeasonScoreRewardConfigList(int seasonId)
	{
		return ConfigNewTowerSeasonSAwardBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x06007477 RID: 29815 RVA: 0x0024016E File Offset: 0x0023E36E
	public NewTowerTeamFeature? GetTeamFeatureConfig(int id)
	{
		return ConfigNewTowerTeamFeatureById.GetConfig(id, true);
	}

	// Token: 0x06007478 RID: 29816 RVA: 0x00240177 File Offset: 0x0023E377
	[NullableContext(1)]
	public NewTowerScoreLevel? GetScoreLevelConfigByLevel(string level)
	{
		return ConfigNewTowerScoreLevelByLevel.GetConfig(level, true);
	}

	// Token: 0x06007479 RID: 29817 RVA: 0x00240180 File Offset: 0x0023E380
	public NewTowerScoreLevel? GetScoreLevelConfigById(int id)
	{
		return ConfigNewTowerScoreLevelById.GetConfig(id, true);
	}

	// Token: 0x0600747A RID: 29818 RVA: 0x00240189 File Offset: 0x0023E389
	public NewTowerMedal? GetMedalConfigById(int id)
	{
		return ConfigNewTowerMedalById.GetConfig(id, true);
	}

	// Token: 0x0600747B RID: 29819 RVA: 0x00240192 File Offset: 0x0023E392
	public IReadOnlyList<NewTowerMedal> GetMedalConfigListByGroupId(int groupId)
	{
		return ConfigNewTowerMedalByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0600747C RID: 29820 RVA: 0x0024019B File Offset: 0x0023E39B
	public IReadOnlyList<NewTowerMedal> GetMedalConfigListBySeasonId(int seasonId)
	{
		return ConfigNewTowerMedalBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x17000DAD RID: 3501
	// (get) Token: 0x0600747D RID: 29821 RVA: 0x002401A4 File Offset: 0x0023E3A4
	[Nullable(1)]
	public static WheelTowerConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return WheelTowerConfig._Instance;
		}
	}

	// Token: 0x0600747E RID: 29822 RVA: 0x002401AB File Offset: 0x0023E3AB
	[NullableContext(1)]
	public static WheelTowerConfig GetOrCreateInstance()
	{
		if (WheelTowerConfig._Instance == null)
		{
			WheelTowerConfig.CreateInstance();
		}
		return WheelTowerConfig._Instance;
	}

	// Token: 0x0600747F RID: 29823 RVA: 0x002401BF File Offset: 0x0023E3BF
	public static bool CreateInstance()
	{
		if (WheelTowerConfig._Instance != null)
		{
			return true;
		}
		WheelTowerConfig._Instance = new WheelTowerConfig();
		return true;
	}

	// Token: 0x06007480 RID: 29824 RVA: 0x002401D5 File Offset: 0x0023E3D5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007481 RID: 29825 RVA: 0x002401D7 File Offset: 0x0023E3D7
	public static void ResetStaticDefaultValue()
	{
		WheelTowerConfig._Instance = null;
	}

	// Token: 0x06007482 RID: 29826 RVA: 0x002401DF File Offset: 0x0023E3DF
	static WheelTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WheelTowerConfig.CreateStaticDefaultValue), new Action(WheelTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040049E5 RID: 18917
	private static WheelTowerConfig _Instance;
}
