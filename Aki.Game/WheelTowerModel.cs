using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02000B12 RID: 2834
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WheelTowerModel : ModelBase
{
	// Token: 0x060074BE RID: 29886 RVA: 0x002415CD File Offset: 0x0023F7CD
	protected override bool OnInit()
	{
		this.BuildRoleData();
		return true;
	}

	// Token: 0x060074BF RID: 29887 RVA: 0x002415D6 File Offset: 0x0023F7D6
	protected override bool OnClear()
	{
		this.ClearRoleData();
		return true;
	}

	// Token: 0x060074C0 RID: 29888 RVA: 0x002415DF File Offset: 0x0023F7DF
	public void SetActivityId(int id)
	{
		this.ActivityDataIdInternal = id;
	}

	// Token: 0x17000DB6 RID: 3510
	// (get) Token: 0x060074C1 RID: 29889 RVA: 0x002415E8 File Offset: 0x0023F7E8
	[Nullable(2)]
	public WheelTowerData ActivityData
	{
		[NullableContext(2)]
		get
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityDataIdInternal) as WheelTowerData;
		}
	}

	// Token: 0x060074C2 RID: 29890 RVA: 0x00241600 File Offset: 0x0023F800
	public NewTowerParam GetTowerConfig()
	{
		return WheelTowerConfig.Instance.GetTowerConfig(this.ActivityData.CycleId).Value;
	}

	// Token: 0x060074C3 RID: 29891 RVA: 0x0024162C File Offset: 0x0023F82C
	public int GetTeamMaxRoleCount()
	{
		return this.GetTowerConfig().RoleCount;
	}

	// Token: 0x060074C4 RID: 29892 RVA: 0x00241648 File Offset: 0x0023F848
	public int GetRoleCost(int roleId)
	{
		if (this.RoleCostMap == null)
		{
			this.RoleCostMap = new Dictionary<int, int>();
			foreach (DicIntInt dicIntInt in this.GetTowerConfig().CostEnergyIter())
			{
				this.RoleCostMap[dicIntInt.Key] = dicIntInt.Value;
			}
			this.DefaultRoleCost = this.GetTowerConfig().DefaultCostEnergy;
		}
		return this.RoleCostMap.GetValueOrDefault(roleId, this.DefaultRoleCost);
	}

	// Token: 0x060074C5 RID: 29893 RVA: 0x002416E8 File Offset: 0x0023F8E8
	public CommonDefine.ICountDown GetSeasonCountDownData()
	{
		long endOpenTime = this.ActivityData.EndOpenTime;
		double num = (double)MathUtils.Instance.LongToNumber(endOpenTime) - TimeUtil.Instance.GetServerTime();
		if (num <= 1.0)
		{
			num = 1.0;
		}
		CommonDefine.ETimeType value = (num >= 86400.0) ? CommonDefine.ETimeType.Day : ((num >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
		CommonDefine.ETimeType value2 = (num >= 86400.0) ? CommonDefine.ETimeType.Hour : ((num >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
		return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2));
	}

	// Token: 0x060074C6 RID: 29894 RVA: 0x00241786 File Offset: 0x0023F986
	public NewTowerClimbingLevelRecord GetCurrentLevelRecord(bool? endless = null)
	{
		if (endless == null)
		{
			return this.ActivityData.GetLevelRecord(this.EndlessMode);
		}
		return this.ActivityData.GetLevelRecord(endless.Value);
	}

	// Token: 0x060074C7 RID: 29895 RVA: 0x002417B5 File Offset: 0x0023F9B5
	public int GetTotalScore()
	{
		return this.ActivityData.GetTotalScore(this.EndlessMode);
	}

	// Token: 0x060074C8 RID: 29896 RVA: 0x002417C8 File Offset: 0x0023F9C8
	public int GetBestTotalScore()
	{
		return this.ActivityData.GetHistoryBestScore(this.EndlessMode);
	}

	// Token: 0x060074C9 RID: 29897 RVA: 0x002417DC File Offset: 0x0023F9DC
	public List<int> GetLevelBuffList()
	{
		int levelId = this.GetCurrentLevelRecord(null).LevelId;
		return new List<int>(WheelTowerConfig.Instance.GetLevelConfigById(levelId).Value.GetNewTowerBuffsArray());
	}

	// Token: 0x060074CA RID: 29898 RVA: 0x00241820 File Offset: 0x0023FA20
	public int GetLevelCanSelectBuffCount()
	{
		int levelId = this.GetCurrentLevelRecord(null).LevelId;
		return WheelTowerConfig.Instance.GetLevelConfigById(levelId).Value.NewTowerBuffCount;
	}

	// Token: 0x060074CB RID: 29899 RVA: 0x00241860 File Offset: 0x0023FA60
	public bool IsLevelCompleted(bool endless)
	{
		if (endless)
		{
			return false;
		}
		MonsterInfoPreview nextMonsterInfoPreview = this.ActivityData.GetLevelRecord(false).NextMonsterInfoPreview;
		return nextMonsterInfoPreview != null && this.GetBossHpPercentage(nextMonsterInfoPreview) <= 0.0;
	}

	// Token: 0x060074CC RID: 29900 RVA: 0x0024189C File Offset: 0x0023FA9C
	public int GetLastChallengeRound(bool? endless = null)
	{
		return this.GetCurrentLevelRecord(endless).TeamChallengeInfos.Count - 1;
	}

	// Token: 0x060074CD RID: 29901 RVA: 0x002418B4 File Offset: 0x0023FAB4
	public bool IsRoundChallenged(int round, bool? endless = null)
	{
		int lastChallengeRound = this.GetLastChallengeRound(endless);
		return lastChallengeRound != -1 && round <= lastChallengeRound;
	}

	// Token: 0x060074CE RID: 29902 RVA: 0x002418D4 File Offset: 0x0023FAD4
	public bool IsTeamRoundCanChallenge(int round)
	{
		if (this.IsRoundChallenged(round, null))
		{
			return true;
		}
		int maxChallengeRound = this.GetMaxChallengeRound(null);
		return round <= maxChallengeRound;
	}

	// Token: 0x060074CF RID: 29903 RVA: 0x0024190C File Offset: 0x0023FB0C
	public bool HasChallengeAnyRound(bool? isEndless = null)
	{
		return this.GetLastChallengeRound(isEndless) >= 0;
	}

	// Token: 0x060074D0 RID: 29904 RVA: 0x0024191C File Offset: 0x0023FB1C
	public int GetMaxChallengeRound(bool? isEndless = null)
	{
		int lastChallengeRound = this.GetLastChallengeRound(isEndless);
		if (this.IsLastRound(lastChallengeRound, isEndless))
		{
			return lastChallengeRound;
		}
		return lastChallengeRound + 1;
	}

	// Token: 0x060074D1 RID: 29905 RVA: 0x00241940 File Offset: 0x0023FB40
	public bool IsLastRound(int round, bool? isEndless = null)
	{
		bool flag = isEndless ?? this.EndlessMode;
		if (flag)
		{
			return false;
		}
		int lastChallengeRound = this.GetLastChallengeRound(new bool?(flag));
		if (lastChallengeRound < 0 || round < lastChallengeRound)
		{
			return false;
		}
		NewTowerClimbingLevelRecord currentLevelRecord = this.GetCurrentLevelRecord(null);
		int num = -1;
		List<IBossInfo> roundBossInfo = this.GetRoundBossInfo(round, null);
		for (int i = 0; i < roundBossInfo.Count; i++)
		{
			if (roundBossInfo[i].HpPercentage > 0.0)
			{
				num = i;
				break;
			}
		}
		return num < 0 || this.IsLastRoundCheckLimit(currentLevelRecord.LevelId, round);
	}

	// Token: 0x060074D2 RID: 29906 RVA: 0x002419F4 File Offset: 0x0023FBF4
	public bool IsLastRoundCheckLimit(int levelId, int round)
	{
		int teamLimit = WheelTowerConfig.Instance.GetLevelConfigById(levelId).Value.TeamLimit;
		return teamLimit != 0 && round == teamLimit - 1;
	}

	// Token: 0x060074D3 RID: 29907 RVA: 0x00241A28 File Offset: 0x0023FC28
	public int GetRoundBossRound(int round)
	{
		NewTowerClimbingLevelRecord currentLevelRecord = this.GetCurrentLevelRecord(null);
		MonsterInfoPreview monsterInfoPreview;
		if (!this.IsRoundChallenged(round, null))
		{
			monsterInfoPreview = currentLevelRecord.NextMonsterInfoPreview;
		}
		else
		{
			monsterInfoPreview = currentLevelRecord.TeamChallengeInfos[round].LastMonsterInfoPreview;
		}
		return monsterInfoPreview.Round;
	}

	// Token: 0x060074D4 RID: 29908 RVA: 0x00241A7C File Offset: 0x0023FC7C
	public MonsterInfoPreview GetBossInfoByRound(int round, bool? isEndless = null)
	{
		NewTowerClimbingLevelRecord currentLevelRecord = this.GetCurrentLevelRecord(isEndless);
		MonsterInfoPreview result;
		if (!this.IsRoundChallenged(round, isEndless))
		{
			result = currentLevelRecord.NextMonsterInfoPreview;
		}
		else
		{
			result = currentLevelRecord.TeamChallengeInfos[round].LastMonsterInfoPreview;
		}
		return result;
	}

	// Token: 0x060074D5 RID: 29909 RVA: 0x00241ABC File Offset: 0x0023FCBC
	public MonsterInfoPreview GetLastBossInfo(bool isEndless)
	{
		int lastChallengeRound = this.GetLastChallengeRound(new bool?(isEndless));
		return this.GetBossInfoByRound(lastChallengeRound, new bool?(isEndless));
	}

	// Token: 0x060074D6 RID: 29910 RVA: 0x00241AE4 File Offset: 0x0023FCE4
	public List<IBossInfo> GetRoundBossInfo(int round, bool? isEndless = null)
	{
		NewTowerClimbingLevelRecord currentLevelRecord = this.GetCurrentLevelRecord(isEndless);
		MonsterInfoPreview monsterInfoPreview;
		if (!this.IsRoundChallenged(round, isEndless))
		{
			monsterInfoPreview = currentLevelRecord.NextMonsterInfoPreview;
		}
		else
		{
			monsterInfoPreview = currentLevelRecord.TeamChallengeInfos[round].LastMonsterInfoPreview;
		}
		int waveConfigId = monsterInfoPreview.WaveConfigId;
		int round2 = monsterInfoPreview.Round;
		double bossHpPercentage = this.GetBossHpPercentage(monsterInfoPreview);
		List<int> waveBatch = this.GetWaveBatch(currentLevelRecord.LevelId, waveConfigId);
		int num = -1;
		for (int i = 0; i < waveBatch.Count; i++)
		{
			if (waveBatch[i] == waveConfigId)
			{
				num = i;
				break;
			}
		}
		List<IBossInfo> list = new List<IBossInfo>();
		for (int j = 0; j < waveBatch.Count; j++)
		{
			double hpPercentage = 0.0;
			if (j == num)
			{
				hpPercentage = bossHpPercentage;
			}
			else if (j > num)
			{
				hpPercentage = 100.0;
			}
			int waveConfigId2 = waveBatch[j];
			list.Add(new BossInfo
			{
				WaveConfigId = waveConfigId2,
				Round = round2,
				HpPercentage = hpPercentage
			});
		}
		return list;
	}

	// Token: 0x060074D7 RID: 29911 RVA: 0x00241BE8 File Offset: 0x0023FDE8
	public int GetCurrentWaveId(int? round = null, bool? isEndless = null)
	{
		NewTowerClimbingLevelRecord currentLevelRecord = this.GetCurrentLevelRecord(isEndless);
		int num = round ?? this.SelectedRound;
		MonsterInfoPreview monsterInfoPreview;
		if (!this.IsRoundChallenged(num, null))
		{
			monsterInfoPreview = currentLevelRecord.NextMonsterInfoPreview;
		}
		else
		{
			monsterInfoPreview = currentLevelRecord.TeamChallengeInfos[num].LastMonsterInfoPreview;
		}
		return monsterInfoPreview.WaveConfigId;
	}

	// Token: 0x060074D8 RID: 29912 RVA: 0x00241C50 File Offset: 0x0023FE50
	[NullableContext(0)]
	public ValueTuple<int, int> GetBossProgress(int round, bool? isEndless = null)
	{
		List<IBossInfo> roundBossInfo = this.GetRoundBossInfo(round, isEndless);
		int num = 0;
		for (int i = 0; i < roundBossInfo.Count; i++)
		{
			if (roundBossInfo[i].HpPercentage <= 0.0)
			{
				num++;
			}
		}
		return new ValueTuple<int, int>((num == roundBossInfo.Count) ? num : (num + 1), roundBossInfo.Count);
	}

	// Token: 0x060074D9 RID: 29913 RVA: 0x00241CB0 File Offset: 0x0023FEB0
	public List<IBossInfo> GetTeamKillBossInfo(int teamRound, bool? isEndlessMode = null)
	{
		bool flag = isEndlessMode ?? this.EndlessMode;
		NewTowerClimbingLevelRecord currentLevelRecord = this.GetCurrentLevelRecord(new bool?(flag));
		IReadOnlyList<NewTowerWave> waveConfigListByLevelId = WheelTowerConfig.Instance.GetWaveConfigListByLevelId(currentLevelRecord.LevelId);
		MonsterInfoPreview bossInfoByRound = this.GetBossInfoByRound(teamRound, new bool?(flag));
		MonsterInfoPreview monsterInfoPreview = null;
		int num = waveConfigListByLevelId[0].Id;
		double num2 = 0.0;
		if (teamRound > 0)
		{
			monsterInfoPreview = this.GetBossInfoByRound(teamRound - 1, new bool?(flag));
			num = monsterInfoPreview.WaveConfigId;
			num2 = MathUtils.Instance.GetRoundToNDecimalPlaces(this.GetBossHpPercentage(monsterInfoPreview), 2);
		}
		List<IBossInfo> list = new List<IBossInfo>();
		int num3 = -1;
		int num4 = -1;
		if (flag)
		{
			for (int i = 0; i < waveConfigListByLevelId.Count; i++)
			{
				if (waveConfigListByLevelId[i].Round == 3)
				{
					num3 = waveConfigListByLevelId[i].Id;
					break;
				}
			}
			for (int j = waveConfigListByLevelId.Count - 1; j >= 0; j--)
			{
				if (waveConfigListByLevelId[j].Round == 3)
				{
					num4 = waveConfigListByLevelId[j].Id;
					break;
				}
			}
		}
		int num5 = num;
		int num6 = (monsterInfoPreview != null) ? monsterInfoPreview.Round : waveConfigListByLevelId[0].Round;
		for (;;)
		{
			NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(num5);
			num6 = ((num6 <= 3) ? waveConfigById.Value.Round : num6);
			double num7 = 0.0;
			double value = 100.0;
			if (num5 == num && monsterInfoPreview != null && num6 == monsterInfoPreview.Round)
			{
				value = num2;
			}
			bool flag2 = num5 == bossInfoByRound.WaveConfigId && num6 == bossInfoByRound.Round;
			if (flag2)
			{
				num7 = this.GetBossHpPercentage(bossInfoByRound);
				value = MathUtils.Instance.GetRoundToNDecimalPlaces(100.0 - num7, 2);
			}
			if (waveConfigById.Value.IsShowInView)
			{
				list.Add(new BossInfo
				{
					WaveConfigId = num5,
					Round = num6,
					HpPercentage = num7,
					LoseHpPercentage = new double?(value)
				});
			}
			if (flag2)
			{
				break;
			}
			if (num4 != -1 && num5 == num4)
			{
				num5 = num3;
				num6++;
			}
			else
			{
				num5++;
			}
		}
		return list;
	}

	// Token: 0x060074DA RID: 29914 RVA: 0x00241F0C File Offset: 0x0024010C
	public List<IBossInfo> GetPrevRoundBossInfo(int round)
	{
		List<IBossInfo> roundBossInfo = this.GetRoundBossInfo(round, null);
		if (round == 0)
		{
			for (int i = 0; i < roundBossInfo.Count; i++)
			{
				roundBossInfo[i].HpPercentage = 100.0;
			}
			return roundBossInfo;
		}
		List<IBossInfo> roundBossInfo2 = this.GetRoundBossInfo(round - 1, null);
		int round2 = roundBossInfo[0].Round;
		int round3 = roundBossInfo2[0].Round;
		if (round2 == round3)
		{
			return roundBossInfo2;
		}
		for (int j = 0; j < roundBossInfo.Count; j++)
		{
			roundBossInfo[j].HpPercentage = 100.0;
		}
		return roundBossInfo;
	}

	// Token: 0x060074DB RID: 29915 RVA: 0x00241FB8 File Offset: 0x002401B8
	public double GetRecordPrevBossHpPercentage(int round, int waveConfigId, int bossRound)
	{
		NewTowerClimbingLevelRecord currentLevelRecord = this.GetCurrentLevelRecord(null);
		for (int i = Math.Min(round, currentLevelRecord.TeamChallengeInfos.Count); i >= 0; i--)
		{
			MonsterInfoPreview lastMonsterInfoPreview = currentLevelRecord.TeamChallengeInfos[i].LastMonsterInfoPreview;
			if (lastMonsterInfoPreview != null && lastMonsterInfoPreview.WaveConfigId == waveConfigId && lastMonsterInfoPreview != null && lastMonsterInfoPreview.Round == bossRound)
			{
				return this.GetBossHpPercentage(lastMonsterInfoPreview);
			}
		}
		return 100.0;
	}

	// Token: 0x060074DC RID: 29916 RVA: 0x0024202C File Offset: 0x0024022C
	public double GetBossHpPercentage(MonsterInfoPreview bossPreview)
	{
		if (bossPreview.IsDead)
		{
			return 0.0;
		}
		double num = (double)bossPreview.HpPpb;
		return MathUtils.Instance.Clamp(num / 100.0, 0.01, 100.0);
	}

	// Token: 0x060074DD RID: 29917 RVA: 0x0024207C File Offset: 0x0024027C
	public List<int> GetWaveBatch(int levelId, int waveConfigId)
	{
		int round = WheelTowerConfig.Instance.GetWaveConfigById(waveConfigId).Value.Round;
		IEnumerable<NewTowerWave> waveConfigListByLevelId = WheelTowerConfig.Instance.GetWaveConfigListByLevelId(levelId);
		List<int> list = new List<int>();
		foreach (NewTowerWave newTowerWave in waveConfigListByLevelId)
		{
			if (newTowerWave.Round == round && newTowerWave.IsShowInView)
			{
				list.Add(newTowerWave.Id);
			}
		}
		return list;
	}

	// Token: 0x060074DE RID: 29918 RVA: 0x00242110 File Offset: 0x00240310
	public List<int> GetRoundSelectBuffList(int round)
	{
		return new List<int>(this.GetCurrentLevelRecord(null).TeamChallengeInfos[round].BuffIds);
	}

	// Token: 0x060074DF RID: 29919 RVA: 0x00242144 File Offset: 0x00240344
	public List<int> GetRoundSelectRoleIdList(int round)
	{
		NewTowerClimbingLevelRecord currentLevelRecord = this.GetCurrentLevelRecord(null);
		List<int> list = new List<int>();
		foreach (RoleSaveInfo roleSaveInfo in currentLevelRecord.TeamChallengeInfos[round].RoleSaveInfos)
		{
			list.Add(roleSaveInfo.RoleId);
		}
		return list;
	}

	// Token: 0x060074E0 RID: 29920 RVA: 0x002421B8 File Offset: 0x002403B8
	public int GetRoundScore(int round)
	{
		return this.ActivityData.GetRoundScore(this.EndlessMode, round);
	}

	// Token: 0x060074E1 RID: 29921 RVA: 0x002421CC File Offset: 0x002403CC
	public int GetRoundTotalScore(int round)
	{
		return this.ActivityData.GetRoundTotalScore(this.EndlessMode, round);
	}

	// Token: 0x060074E2 RID: 29922 RVA: 0x002421E0 File Offset: 0x002403E0
	public int GetSelectedRoundTotalScore()
	{
		return this.GetRoundTotalScore(this.SelectedRound);
	}

	// Token: 0x060074E3 RID: 29923 RVA: 0x002421EE File Offset: 0x002403EE
	public void SetEndlessMode(bool endless)
	{
		if (this.EndlessMode == endless)
		{
			return;
		}
		this.EndlessMode = endless;
		this.ResetSelectedData();
	}

	// Token: 0x060074E4 RID: 29924 RVA: 0x00242208 File Offset: 0x00240408
	public void UpdateSelectRound(int round, bool force = false)
	{
		if (this.SelectedRound == round && !force)
		{
			return;
		}
		this.ResetSelectedData();
		this.SelectedEnergyInfo = this.ActivityData.GetRoundEnergyInfo(this.EndlessMode, round);
		this.SelectedRound = round;
		if (this.IsRoundChallenged(round, null))
		{
			this.SelectedBuff = this.GetRoundSelectBuffList(round)[0];
			this.SelectedRoleList = this.GetRoundSelectRoleIdList(round);
		}
	}

	// Token: 0x060074E5 RID: 29925 RVA: 0x00242279 File Offset: 0x00240479
	public void ResetSelectedData()
	{
		this.SelectedRound = -1;
		this.SelectedBuff = -1;
		this.SelectedRoleList.Clear();
	}

	// Token: 0x060074E6 RID: 29926 RVA: 0x00242294 File Offset: 0x00240494
	public bool CheckSelectTeamIsFull()
	{
		return this.SelectedRoleList.Count >= this.GetTeamMaxRoleCount();
	}

	// Token: 0x060074E7 RID: 29927 RVA: 0x002422AC File Offset: 0x002404AC
	public bool CheckSelectedRoleEnergyEnough()
	{
		CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.EnergyInfo selectedEnergyInfo = this.SelectedEnergyInfo;
		for (int i = 0; i < this.SelectedRoleList.Count; i++)
		{
			int roleId = this.SelectedRoleList[i];
			if (selectedEnergyInfo.GetRoleEnergy(roleId) <= 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060074E8 RID: 29928 RVA: 0x002422F0 File Offset: 0x002404F0
	public bool CheckBuffIsSelected()
	{
		return this.SelectedBuff > 0;
	}

	// Token: 0x060074E9 RID: 29929 RVA: 0x002422FB File Offset: 0x002404FB
	public bool CheckSelectedIsConflict()
	{
		return this.CheckCurrentSelectConflict().Count != 0;
	}

	// Token: 0x060074EA RID: 29930 RVA: 0x0024230B File Offset: 0x0024050B
	public List<IConflictInfo> CheckCurrentSelectConflict()
	{
		return this.CheckConflictList(this.SelectedRoleList);
	}

	// Token: 0x060074EB RID: 29931 RVA: 0x0024231C File Offset: 0x0024051C
	public List<IConflictInfo> CheckConflictList(List<int> roleIdList)
	{
		List<IConflictInfo> list = new List<IConflictInfo>();
		for (int i = 0; i < roleIdList.Count; i++)
		{
			int roleId = roleIdList[i];
			IConflictInfo conflictInfo = this.CheckConflict(roleId);
			if (conflictInfo != null)
			{
				list.Add(conflictInfo);
			}
		}
		return list;
	}

	// Token: 0x060074EC RID: 29932 RVA: 0x0024235C File Offset: 0x0024055C
	[NullableContext(2)]
	public IConflictInfo CheckConflict(int roleId)
	{
		if (roleId <= 0)
		{
			return null;
		}
		if (this.IsTemplateRole(roleId))
		{
			return null;
		}
		CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.EnergyInfo selectedEnergyInfo = this.SelectedEnergyInfo;
		IRoleInfo roleInfo = this.GetRoleInfo(roleId);
		bool flag = !selectedEnergyInfo.GetWeaponCanUse(roleInfo.Weapon, roleId);
		bool flag2 = false;
		foreach (int phantomIncId in roleInfo.Phantom)
		{
			if (!selectedEnergyInfo.GetPhantomCanUse(phantomIncId, roleId))
			{
				flag2 = true;
				break;
			}
		}
		if (flag || flag2)
		{
			return new ConflictInfo
			{
				RoleId = roleId,
				WeaponConflict = flag,
				PhantomConflict = flag2
			};
		}
		return null;
	}

	// Token: 0x060074ED RID: 29933 RVA: 0x00242410 File Offset: 0x00240610
	public int GetConflictWeaponRoleId(int roleId)
	{
		int value = (WeaponModel.Instance.GetWeaponDataByRoleDataId(roleId, true) as WeaponInstance).GetIncId().Value;
		return this.SelectedEnergyInfo.GetWeaponOccupyRoleId(value, roleId);
	}

	// Token: 0x060074EE RID: 29934 RVA: 0x0024244C File Offset: 0x0024064C
	public IRoleInfo GetRoleInfo(int roleId)
	{
		int value = (WeaponModel.Instance.GetWeaponDataByRoleDataId(roleId, true) as WeaponInstance).GetIncId().Value;
		List<int> phantom = new List<int>(PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList());
		return new CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.RoleInfo
		{
			RoleId = roleId,
			Weapon = value,
			Phantom = phantom
		};
	}

	// Token: 0x060074EF RID: 29935 RVA: 0x002424A8 File Offset: 0x002406A8
	public void TmpToSelect()
	{
		this.SelectedRoleList.Clear();
		List<int> list = new List<int>();
		for (int i = 0; i < this.GetTeamMaxRoleCount(); i++)
		{
			int item;
			if (this.TmpSelectedRoleMap.TryGetValue(i, out item))
			{
				list.Add(item);
			}
		}
		this.SelectedRoleList.AddRange(list);
	}

	// Token: 0x060074F0 RID: 29936 RVA: 0x002424FC File Offset: 0x002406FC
	public void SelectToTmp()
	{
		this.TmpSelectedRoleMap.Clear();
		for (int i = 0; i < this.SelectedRoleList.Count; i++)
		{
			int value = this.SelectedRoleList[i];
			this.TmpSelectedRoleMap[i] = value;
		}
	}

	// Token: 0x060074F1 RID: 29937 RVA: 0x00242544 File Offset: 0x00240744
	public void SetTmpSelectRoleList(List<int> roleList)
	{
		this.TmpSelectedRoleMap.Clear();
		for (int i = 0; i < roleList.Count; i++)
		{
			this.TmpSelectedRoleMap[i] = roleList[i];
		}
	}

	// Token: 0x060074F2 RID: 29938 RVA: 0x00242580 File Offset: 0x00240780
	public void TryAddOrDeleteRole(int roleId)
	{
		int roleSlot = this.GetRoleSlot(roleId);
		if (roleSlot != -1)
		{
			this.TmpSelectedRoleMap.Remove(roleSlot);
			return;
		}
		int firstEmptySlot = this.GetFirstEmptySlot();
		if (firstEmptySlot >= 0)
		{
			this.TmpSelectedRoleMap[firstEmptySlot] = roleId;
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("WheelTower_TeamSelectFullTips", Array.Empty<object>());
	}

	// Token: 0x060074F3 RID: 29939 RVA: 0x002425D4 File Offset: 0x002407D4
	public int GetRoleSlot(int roleId)
	{
		if (roleId <= 0)
		{
			return -1;
		}
		for (int i = 0; i < this.GetTeamMaxRoleCount(); i++)
		{
			int num;
			if (this.TmpSelectedRoleMap.TryGetValue(i, out num) && num == roleId)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060074F4 RID: 29940 RVA: 0x0024260F File Offset: 0x0024080F
	public bool IsSelectRole(int roleId)
	{
		return this.GetRoleSlot(roleId) >= 0;
	}

	// Token: 0x060074F5 RID: 29941 RVA: 0x0024261E File Offset: 0x0024081E
	public bool IsTempHasAnyEmptySlot()
	{
		return this.GetFirstEmptySlot() >= 0;
	}

	// Token: 0x060074F6 RID: 29942 RVA: 0x0024262C File Offset: 0x0024082C
	private int GetFirstEmptySlot()
	{
		for (int i = 0; i < this.GetTeamMaxRoleCount(); i++)
		{
			if (!this.TmpSelectedRoleMap.ContainsKey(i))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060074F7 RID: 29943 RVA: 0x0024265C File Offset: 0x0024085C
	[NullableContext(2)]
	public IWheelTowerCoverRecordViewData GetRecordPopupData()
	{
		IWheelTowerCoverRecordViewData result;
		if (!this.LevelRecordPopupDataMap.TryGetValue(this.EndlessMode, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060074F8 RID: 29944 RVA: 0x00242681 File Offset: 0x00240881
	public void SetRecordPopupData(IWheelTowerCoverRecordViewData data)
	{
		this.LevelRecordPopupDataMap[this.EndlessMode] = data;
	}

	// Token: 0x060074F9 RID: 29945 RVA: 0x00242695 File Offset: 0x00240895
	public void DeleteRecordPopupData()
	{
		this.LevelRecordPopupDataMap.Remove(this.EndlessMode);
	}

	// Token: 0x060074FA RID: 29946 RVA: 0x002426AC File Offset: 0x002408AC
	public string GetScoreResourceIdByLevel(EScoreLevel level)
	{
		string result;
		if (!WheelTowerDefine.LevelItemMappingTable.TryGetValue(level, out result))
		{
			return "";
		}
		return result;
	}

	// Token: 0x060074FB RID: 29947 RVA: 0x002426CF File Offset: 0x002408CF
	public EScoreLevel GetRoundScoreLevel(int score)
	{
		return EScoreLevel.None;
	}

	// Token: 0x060074FC RID: 29948 RVA: 0x002426D4 File Offset: 0x002408D4
	public EScoreLevel GetTotalScoreLevel(int score, bool? isEndless = null, int? levelId = null)
	{
		int levelId2 = (levelId != null && levelId.Value != 0) ? levelId.Value : this.GetCurrentLevelRecord(isEndless).LevelId;
		NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(levelId2);
		EScoreLevel result = EScoreLevel.None;
		foreach (DicIntInt dicIntInt in levelConfigById.Value.ScoreLevelRuleIter())
		{
			int key = dicIntInt.Key;
			int value = dicIntInt.Value;
			if (score < value)
			{
				break;
			}
			result = (EScoreLevel)key;
		}
		return result;
	}

	// Token: 0x060074FD RID: 29949 RVA: 0x00242778 File Offset: 0x00240978
	[NullableContext(0)]
	public ValueTuple<int, int> GetScoreRange(int score)
	{
		int levelId = this.GetCurrentLevelRecord(null).LevelId;
		NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(levelId);
		int num = 0;
		int item = 0;
		foreach (DicIntInt dicIntInt in levelConfigById.Value.ScoreLevelRuleIter())
		{
			int value = dicIntInt.Value;
			if (score < value)
			{
				return new ValueTuple<int, int>(num, value);
			}
			item = num;
			num = value;
		}
		return new ValueTuple<int, int>(item, num);
	}

	// Token: 0x060074FE RID: 29950 RVA: 0x00242820 File Offset: 0x00240A20
	public List<WheelTowerScoreLevelTargetData> GetScoreLevelList()
	{
		int levelId = this.GetCurrentLevelRecord(null).LevelId;
		List<WheelTowerScoreLevelTargetData> result;
		if (!this.LevelIdToScoreLevelTargetDataList.TryGetValue(levelId, out result))
		{
			NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(levelId);
			List<WheelTowerScoreLevelTargetData> list = new List<WheelTowerScoreLevelTargetData>();
			foreach (DicIntInt dicIntInt in levelConfigById.Value.ScoreLevelRuleIter())
			{
				int key = dicIntInt.Key;
				int value = dicIntInt.Value;
				if (key != 0)
				{
					list.Add(new WheelTowerScoreLevelTargetData(key, value));
				}
			}
			this.LevelIdToScoreLevelTargetDataList[levelId] = list;
			return list;
		}
		return result;
	}

	// Token: 0x060074FF RID: 29951 RVA: 0x002428EC File Offset: 0x00240AEC
	public bool CheckInInstanceDungeon()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.GetValueOrDefault().InstSubType == 47;
		}
		return false;
	}

	// Token: 0x06007500 RID: 29952 RVA: 0x0024293C File Offset: 0x00240B3C
	public bool GetIsEndlessUnlockedInInstance()
	{
		if (this.IsEndlessUnlockedInInstance)
		{
			this.IsEndlessUnlockedInInstance = false;
			return true;
		}
		return false;
	}

	// Token: 0x06007501 RID: 29953 RVA: 0x00242950 File Offset: 0x00240B50
	public void SetIsEndlessUnlockedInInstance(bool value)
	{
		this.IsEndlessUnlockedInInstance = value;
	}

	// Token: 0x06007502 RID: 29954 RVA: 0x0024295C File Offset: 0x00240B5C
	[NullableContext(2)]
	public string GetNextCycleRemainTime()
	{
		double cycleBeginTime = this.ActivityData.CycleBeginTime;
		if (cycleBeginTime == -1.0)
		{
			return null;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return this.RemainTimeToText(cycleBeginTime - serverTime);
	}

	// Token: 0x06007503 RID: 29955 RVA: 0x00242998 File Offset: 0x00240B98
	[NullableContext(2)]
	public string GetCycleEndRemainTime()
	{
		double cycleEndTime = this.ActivityData.CycleEndTime;
		if (cycleEndTime == -1.0)
		{
			return null;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return this.RemainTimeToText(cycleEndTime - serverTime);
	}

	// Token: 0x06007504 RID: 29956 RVA: 0x002429D4 File Offset: 0x00240BD4
	private string RemainTimeToText(double remainingTime)
	{
		if (remainingTime <= 1.0)
		{
			remainingTime = 1.0;
		}
		CommonDefine.ETimeType value = (remainingTime >= 86400.0) ? CommonDefine.ETimeType.Day : ((remainingTime >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
		CommonDefine.ETimeType value2 = (remainingTime >= 86400.0) ? CommonDefine.ETimeType.Hour : ((remainingTime >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
		return TimeUtil.Instance.GetCountDownDataFormat2(remainingTime, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2)).CountDownText;
	}

	// Token: 0x06007505 RID: 29957 RVA: 0x00242A54 File Offset: 0x00240C54
	private void BuildRoleData()
	{
		IReadOnlyList<NewTowerRole> roleConfigList = WheelTowerConfig.Instance.GetRoleConfigList();
		if (roleConfigList == null)
		{
			return;
		}
		foreach (NewTowerRole newTowerRole in roleConfigList)
		{
			if (newTowerRole.TemplateRoleId != 0)
			{
				this.RoleToTemplate[newTowerRole.Id] = newTowerRole.TemplateRoleId;
				this.TemplateToRole[newTowerRole.TemplateRoleId] = newTowerRole.Id;
			}
		}
	}

	// Token: 0x06007506 RID: 29958 RVA: 0x00242AE0 File Offset: 0x00240CE0
	private void ClearRoleData()
	{
		this.RoleToTemplate.Clear();
		this.TemplateToRole.Clear();
		this.EnhancedRoleSetInterval.Clear();
	}

	// Token: 0x06007507 RID: 29959 RVA: 0x00242B03 File Offset: 0x00240D03
	public bool IsTemplateRole(int roleId)
	{
		return this.TemplateToRole.ContainsKey(roleId);
	}

	// Token: 0x06007508 RID: 29960 RVA: 0x00242B14 File Offset: 0x00240D14
	public int GetTemplateRoleId(int roleId)
	{
		int result;
		if (!this.RoleToTemplate.TryGetValue(roleId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06007509 RID: 29961 RVA: 0x00242B34 File Offset: 0x00240D34
	public int GetRealRoleId(int templateRoleId)
	{
		int result;
		if (!this.TemplateToRole.TryGetValue(templateRoleId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0600750A RID: 29962 RVA: 0x00242B54 File Offset: 0x00240D54
	public int TryGetRealRoleId(int roleId)
	{
		if (!this.IsTemplateRole(roleId))
		{
			return roleId;
		}
		return this.GetRealRoleId(roleId);
	}

	// Token: 0x0600750B RID: 29963 RVA: 0x00242B68 File Offset: 0x00240D68
	public string GetTemplateRoleDesc(int roleId)
	{
		int roleId2 = this.TryGetRealRoleId(roleId);
		return WheelTowerConfig.Instance.GetRoleConfigByRoleId(roleId2).Value.TemplateDesc;
	}

	// Token: 0x17000DB7 RID: 3511
	// (get) Token: 0x0600750C RID: 29964 RVA: 0x00242B98 File Offset: 0x00240D98
	public HashSet<int> EnhancedRoleSet
	{
		get
		{
			if (this.EnhancedRoleSetInterval.Count == 0)
			{
				this.EnhancedRoleSetInterval = new HashSet<int>(this.GetTowerConfig().GetEnhanceRoleIdsArray());
			}
			return this.EnhancedRoleSetInterval;
		}
	}

	// Token: 0x0600750D RID: 29965 RVA: 0x00242BD4 File Offset: 0x00240DD4
	public List<int> GetEnhanceRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (int item in this.EnhancedRoleSet)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600750E RID: 29966 RVA: 0x00242C30 File Offset: 0x00240E30
	public unsafe List<WheelTowerRoleEnhanceSkillData> GetEnhanceSkillInfoList(int roleId)
	{
		NewTowerRole? roleConfigByRoleId = WheelTowerConfig.Instance.GetRoleConfigByRoleId(roleId);
		IReadOnlyList<Aki.Config.Skill> skillList = RoleSkillConfig.Instance.GetSkillList(roleId);
		List<WheelTowerRoleEnhanceSkillData> list = new List<WheelTowerRoleEnhanceSkillData>();
		foreach (int num in new int[]
		{
			11,
			2,
			3,
			6
		})
		{
			string enhanceSkillDesc = roleConfigByRoleId.Value.GetEnhanceSkillDesc(num);
			StringArray? enhanceSkillDescParam = roleConfigByRoleId.Value.GetEnhanceSkillDescParam(num);
			if (enhanceSkillDesc != null && enhanceSkillDescParam != null)
			{
				bool flag = false;
				foreach (Aki.Config.Skill skill in skillList)
				{
					if (skill.SkillType == num)
					{
						flag = true;
						list.Add(new WheelTowerRoleEnhanceSkillData
						{
							SkillName = skill.SkillName,
							SkillIcon = skill.Icon,
							SkillDesc = this.GetLocalDesc(enhanceSkillDesc, enhanceSkillDescParam.Value.ArrayString())
						});
						break;
					}
				}
				if (!flag)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.WheelTower;
					ELogAuthor author = ELogAuthor.CXJ;
					string message = "角色技能信息不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillType", num);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}
		return list;
	}

	// Token: 0x0600750F RID: 29967 RVA: 0x00242DC8 File Offset: 0x00240FC8
	public bool IsEnhanceRole(int roleId)
	{
		int item = this.TryGetRealRoleId(roleId);
		return this.EnhancedRoleSet.Contains(item);
	}

	// Token: 0x06007510 RID: 29968 RVA: 0x00242DEC File Offset: 0x00240FEC
	public List<string> GetRoleEnhanceDesc(int roleId)
	{
		NewTowerRole? roleConfigByRoleId = WheelTowerConfig.Instance.GetRoleConfigByRoleId(roleId);
		List<string> list = new List<string>();
		foreach (int key in new int[]
		{
			11,
			2,
			3,
			6
		})
		{
			string enhanceSkillDesc = roleConfigByRoleId.Value.GetEnhanceSkillDesc(key);
			StringArray? enhanceSkillDescParam = roleConfigByRoleId.Value.GetEnhanceSkillDescParam(key);
			if (enhanceSkillDesc != null && enhanceSkillDescParam != null)
			{
				list.Add(this.GetLocalDesc(enhanceSkillDesc, enhanceSkillDescParam.Value.ArrayString()));
			}
		}
		return list;
	}

	// Token: 0x06007511 RID: 29969 RVA: 0x00242E84 File Offset: 0x00241084
	private string GetLocalDesc(string textId, string[] param)
	{
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(textId, null), param);
	}

	// Token: 0x06007512 RID: 29970 RVA: 0x00242E94 File Offset: 0x00241094
	public bool IsEnhanceSkill(int roleId, int skillId)
	{
		if (!this.IsEnhanceRole(roleId))
		{
			return false;
		}
		int skillType = RoleSkillConfig.Instance.GetSkillConfigById(skillId).Value.SkillType;
		return this.GetRoleSkillEnhanceDescAndParam(roleId, skillType) != null;
	}

	// Token: 0x06007513 RID: 29971 RVA: 0x00242ED8 File Offset: 0x002410D8
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public ValueTuple<string, string[]>? GetRoleSkillEnhanceDescAndParam(int roleId, int skillType)
	{
		NewTowerRole? roleConfigByRoleId = WheelTowerConfig.Instance.GetRoleConfigByRoleId(roleId);
		string enhanceSkillDesc = roleConfigByRoleId.Value.GetEnhanceSkillDesc(skillType);
		if (enhanceSkillDesc == null)
		{
			return null;
		}
		StringArray? enhanceSkillDescParam = roleConfigByRoleId.Value.GetEnhanceSkillDescParam(skillType);
		if (enhanceSkillDescParam == null)
		{
			return null;
		}
		return new ValueTuple<string, string[]>?(new ValueTuple<string, string[]>(enhanceSkillDesc, enhanceSkillDescParam.Value.ArrayString()));
	}

	// Token: 0x17000DB8 RID: 3512
	// (get) Token: 0x06007514 RID: 29972 RVA: 0x00242F50 File Offset: 0x00241150
	public Dictionary<int, int> SpecialUpRoleMap
	{
		get
		{
			if (this.SpecialUpRoleMapInternal == null)
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				NewTowerParam towerConfig = this.GetTowerConfig();
				int specialUpRoleIdsLength = towerConfig.SpecialUpRoleIdsLength;
				for (int i = 0; i < specialUpRoleIdsLength; i++)
				{
					DicIntInt? dicIntInt = towerConfig.SpecialUpRoleIds(i);
					if (dicIntInt != null)
					{
						dictionary[dicIntInt.Value.Key] = dicIntInt.Value.Value;
					}
				}
				this.SpecialUpRoleMapInternal = dictionary;
			}
			return this.SpecialUpRoleMapInternal;
		}
	}

	// Token: 0x06007515 RID: 29973 RVA: 0x00242FCC File Offset: 0x002411CC
	public int GetSpecialUpRoleAddEnergy(int roleId)
	{
		int result;
		if (!this.SpecialUpRoleMap.TryGetValue(roleId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06007516 RID: 29974 RVA: 0x00242FEC File Offset: 0x002411EC
	[NullableContext(2)]
	public IWheelTowerMedalGroupData GetMedalGroupData(int groupId)
	{
		return this.ActivityData.GetMedalGroupData(groupId);
	}

	// Token: 0x06007517 RID: 29975 RVA: 0x00242FFC File Offset: 0x002411FC
	public List<IWheelTowerMedalGroupData> GetSeasonMedalGroupList(int seasonId, EWheelTowerMedalType medalType)
	{
		IReadOnlyList<NewTowerMedal> medalConfigListBySeasonId = WheelTowerConfig.Instance.GetMedalConfigListBySeasonId(seasonId);
		if (medalConfigListBySeasonId == null || medalConfigListBySeasonId.Count == 0)
		{
			return new List<IWheelTowerMedalGroupData>();
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (NewTowerMedal newTowerMedal in medalConfigListBySeasonId)
		{
			if (!hashSet.Contains(newTowerMedal.GroupId) && ((medalType == EWheelTowerMedalType.Season) ? (newTowerMedal.CycleId == 0) : (newTowerMedal.CycleId > 0)))
			{
				hashSet.Add(newTowerMedal.GroupId);
			}
		}
		List<IWheelTowerMedalGroupData> list = new List<IWheelTowerMedalGroupData>();
		foreach (int groupId in hashSet)
		{
			IWheelTowerMedalGroupData medalGroupData = this.GetMedalGroupData(groupId);
			if (medalGroupData != null)
			{
				list.Add(medalGroupData);
			}
		}
		return list;
	}

	// Token: 0x06007518 RID: 29976 RVA: 0x002430F0 File Offset: 0x002412F0
	public List<IWheelTowerMedalGroupData> GetAllSeasonMedalGroupList(int seasonId)
	{
		List<IWheelTowerMedalGroupData> seasonMedalGroupList = this.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Season);
		seasonMedalGroupList.AddRange(this.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Stage));
		return seasonMedalGroupList;
	}

	// Token: 0x06007519 RID: 29977 RVA: 0x00243108 File Offset: 0x00241308
	public int GetSeasonMedalReadId(int groupId)
	{
		if (groupId == 0)
		{
			return 0;
		}
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.WheelTowerSeasonReview) as ServerStorageMap;
		if (serverStorageMap == null)
		{
			return 0;
		}
		return serverStorageMap.Get(groupId).GetValueOrDefault();
	}

	// Token: 0x0600751A RID: 29978 RVA: 0x00243140 File Offset: 0x00241340
	public bool HasUnreadSeasonMedalRedDot(int seasonId)
	{
		if (seasonId == 0)
		{
			return false;
		}
		List<IWheelTowerMedalGroupData> allSeasonMedalGroupList = this.GetAllSeasonMedalGroupList(seasonId);
		if (allSeasonMedalGroupList.Count == 0)
		{
			return false;
		}
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.WheelTowerSeasonReview) as ServerStorageMap;
		if (serverStorageMap == null)
		{
			return false;
		}
		foreach (IWheelTowerMedalGroupData wheelTowerMedalGroupData in allSeasonMedalGroupList)
		{
			if (wheelTowerMedalGroupData.GroupId != 0 && wheelTowerMedalGroupData.CurrentMedalId > 0 && serverStorageMap.Get(wheelTowerMedalGroupData.GroupId).GetValueOrDefault() != wheelTowerMedalGroupData.CurrentMedalId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600751B RID: 29979 RVA: 0x002431EC File Offset: 0x002413EC
	public void MarkSeasonMedalsRead(int seasonId)
	{
		if (seasonId == 0)
		{
			return;
		}
		List<IWheelTowerMedalGroupData> allSeasonMedalGroupList = this.GetAllSeasonMedalGroupList(seasonId);
		if (allSeasonMedalGroupList.Count == 0)
		{
			return;
		}
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.WheelTowerSeasonReview) as ServerStorageMap;
		if (serverStorageMap == null)
		{
			return;
		}
		foreach (IWheelTowerMedalGroupData wheelTowerMedalGroupData in allSeasonMedalGroupList)
		{
			if (wheelTowerMedalGroupData.GroupId != 0 && wheelTowerMedalGroupData.CurrentMedalId > 0)
			{
				serverStorageMap.Set(wheelTowerMedalGroupData.GroupId, wheelTowerMedalGroupData.CurrentMedalId);
			}
		}
	}

	// Token: 0x0600751C RID: 29980 RVA: 0x00243284 File Offset: 0x00241484
	public void CleanOldSeasonMedalsStorage(int currentSeasonId)
	{
		IReadOnlyList<NewTowerSeason> allSeasonConfigs = WheelTowerConfig.Instance.GetAllSeasonConfigs();
		if (allSeasonConfigs == null)
		{
			return;
		}
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.WheelTowerSeasonReview) as ServerStorageMap;
		if (serverStorageMap == null)
		{
			return;
		}
		foreach (NewTowerSeason newTowerSeason in allSeasonConfigs)
		{
			if (newTowerSeason.Id != currentSeasonId && newTowerSeason.Id != 0)
			{
				IReadOnlyList<NewTowerMedal> medalConfigListBySeasonId = WheelTowerConfig.Instance.GetMedalConfigListBySeasonId(newTowerSeason.Id);
				if (medalConfigListBySeasonId != null)
				{
					foreach (NewTowerMedal newTowerMedal in medalConfigListBySeasonId)
					{
						if (newTowerMedal.GroupId != 0)
						{
							serverStorageMap.Delete(newTowerMedal.GroupId);
						}
					}
				}
			}
		}
	}

	// Token: 0x17000DB9 RID: 3513
	// (get) Token: 0x0600751D RID: 29981 RVA: 0x00243364 File Offset: 0x00241564
	public static WheelTowerModel Instance
	{
		get
		{
			return WheelTowerModel._Instance;
		}
	}

	// Token: 0x0600751E RID: 29982 RVA: 0x0024336B File Offset: 0x0024156B
	public static WheelTowerModel GetOrCreateInstance()
	{
		if (WheelTowerModel._Instance == null)
		{
			WheelTowerModel.CreateInstance();
		}
		return WheelTowerModel._Instance;
	}

	// Token: 0x0600751F RID: 29983 RVA: 0x0024337F File Offset: 0x0024157F
	public static bool CreateInstance()
	{
		if (WheelTowerModel._Instance != null)
		{
			return true;
		}
		WheelTowerModel._Instance = new WheelTowerModel();
		return true;
	}

	// Token: 0x06007520 RID: 29984 RVA: 0x00243395 File Offset: 0x00241595
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007521 RID: 29985 RVA: 0x00243397 File Offset: 0x00241597
	public static void ResetStaticDefaultValue()
	{
		WheelTowerModel._Instance = null;
	}

	// Token: 0x06007522 RID: 29986 RVA: 0x0024339F File Offset: 0x0024159F
	static WheelTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WheelTowerModel.CreateStaticDefaultValue), new Action(WheelTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x040049ED RID: 18925
	private int ActivityDataIdInternal = -1;

	// Token: 0x040049EE RID: 18926
	[Nullable(2)]
	private Dictionary<int, int> RoleCostMap;

	// Token: 0x040049EF RID: 18927
	private int DefaultRoleCost = -1;

	// Token: 0x040049F0 RID: 18928
	public bool EndlessMode;

	// Token: 0x040049F1 RID: 18929
	public int SelectedRound = -1;

	// Token: 0x040049F2 RID: 18930
	public int SelectedBuff = -1;

	// Token: 0x040049F3 RID: 18931
	public int SelectedBossId = -1;

	// Token: 0x040049F4 RID: 18932
	public List<int> SelectedRoleList = new List<int>();

	// Token: 0x040049F5 RID: 18933
	[Nullable(2)]
	public CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.EnergyInfo SelectedEnergyInfo;

	// Token: 0x040049F6 RID: 18934
	public readonly Dictionary<int, int> TmpSelectedRoleMap = new Dictionary<int, int>();

	// Token: 0x040049F7 RID: 18935
	private readonly Dictionary<bool, IWheelTowerCoverRecordViewData> LevelRecordPopupDataMap = new Dictionary<bool, IWheelTowerCoverRecordViewData>();

	// Token: 0x040049F8 RID: 18936
	private readonly Dictionary<int, List<WheelTowerScoreLevelTargetData>> LevelIdToScoreLevelTargetDataList = new Dictionary<int, List<WheelTowerScoreLevelTargetData>>();

	// Token: 0x040049F9 RID: 18937
	public bool BlockEndlessUnlockTips = true;

	// Token: 0x040049FA RID: 18938
	private bool IsEndlessUnlockedInInstance;

	// Token: 0x040049FB RID: 18939
	public int CachedRoundInProgress = -1;

	// Token: 0x040049FC RID: 18940
	public bool IsTimeStopBanned;

	// Token: 0x040049FD RID: 18941
	private readonly Dictionary<int, int> RoleToTemplate = new Dictionary<int, int>();

	// Token: 0x040049FE RID: 18942
	private readonly Dictionary<int, int> TemplateToRole = new Dictionary<int, int>();

	// Token: 0x040049FF RID: 18943
	private HashSet<int> EnhancedRoleSetInterval = new HashSet<int>();

	// Token: 0x04004A00 RID: 18944
	public int TmpSelectRoleId;

	// Token: 0x04004A01 RID: 18945
	[Nullable(2)]
	private Dictionary<int, int> SpecialUpRoleMapInternal;

	// Token: 0x04004A02 RID: 18946
	[Nullable(2)]
	private static WheelTowerModel _Instance;
}
