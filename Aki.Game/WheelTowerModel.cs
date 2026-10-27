using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x0200165A RID: 5722
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WheelTowerModel : ModelBase
{
	// Token: 0x0600A0E0 RID: 41184 RVA: 0x00237731 File Offset: 0x00235931
	protected override bool OnInit()
	{
		this.BuildRoleData();
		return true;
	}

	// Token: 0x0600A0E1 RID: 41185 RVA: 0x0023773A File Offset: 0x0023593A
	protected override bool OnClear()
	{
		this.ClearRoleData();
		return true;
	}

	// Token: 0x0600A0E2 RID: 41186 RVA: 0x00237743 File Offset: 0x00235943
	public void SetActivityId(int id)
	{
		this.ActivityDataIdInternal = id;
	}

	// Token: 0x17000D95 RID: 3477
	// (get) Token: 0x0600A0E3 RID: 41187 RVA: 0x0023774C File Offset: 0x0023594C
	[Nullable(2)]
	public WheelTowerData ActivityData
	{
		[NullableContext(2)]
		get
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityDataIdInternal) as WheelTowerData;
		}
	}

	// Token: 0x0600A0E4 RID: 41188 RVA: 0x00237764 File Offset: 0x00235964
	public NewTowerParam GetTowerConfig()
	{
		return WheelTowerConfig.Instance.GetTowerConfig(this.ActivityData.CycleId).Value;
	}

	// Token: 0x0600A0E5 RID: 41189 RVA: 0x00237790 File Offset: 0x00235990
	public int GetTeamMaxRoleCount()
	{
		return this.GetTowerConfig().RoleCount;
	}

	// Token: 0x0600A0E6 RID: 41190 RVA: 0x002377AC File Offset: 0x002359AC
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

	// Token: 0x0600A0E7 RID: 41191 RVA: 0x0023784C File Offset: 0x00235A4C
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

	// Token: 0x0600A0E8 RID: 41192 RVA: 0x002378EA File Offset: 0x00235AEA
	public NewTowerClimbingLevelRecord GetCurrentLevelRecord(bool? endless = null)
	{
		if (endless == null)
		{
			return this.ActivityData.GetLevelRecord(this.EndlessMode);
		}
		return this.ActivityData.GetLevelRecord(endless.Value);
	}

	// Token: 0x0600A0E9 RID: 41193 RVA: 0x00237919 File Offset: 0x00235B19
	public int GetTotalScore()
	{
		return this.ActivityData.GetTotalScore(this.EndlessMode);
	}

	// Token: 0x0600A0EA RID: 41194 RVA: 0x0023792C File Offset: 0x00235B2C
	public int GetBestTotalScore()
	{
		return this.ActivityData.GetHistoryBestScore(this.EndlessMode);
	}

	// Token: 0x0600A0EB RID: 41195 RVA: 0x00237940 File Offset: 0x00235B40
	public List<int> GetLevelBuffList()
	{
		int levelId = this.GetCurrentLevelRecord(null).LevelId;
		return WheelTowerConfig.Instance.GetLevelConfigById(levelId).Value.GetNewTowerBuffsArray().ToList<int>();
	}

	// Token: 0x0600A0EC RID: 41196 RVA: 0x00237984 File Offset: 0x00235B84
	public int GetLevelCanSelectBuffCount()
	{
		int levelId = this.GetCurrentLevelRecord(null).LevelId;
		return WheelTowerConfig.Instance.GetLevelConfigById(levelId).Value.NewTowerBuffCount;
	}

	// Token: 0x0600A0ED RID: 41197 RVA: 0x002379C4 File Offset: 0x00235BC4
	public bool IsLevelCompleted(bool endless)
	{
		if (endless)
		{
			return false;
		}
		MonsterInfoPreview nextMonsterInfoPreview = this.ActivityData.GetLevelRecord(false).NextMonsterInfoPreview;
		return nextMonsterInfoPreview != null && this.GetBossHpPercentage(nextMonsterInfoPreview) <= 0.0;
	}

	// Token: 0x0600A0EE RID: 41198 RVA: 0x00237A00 File Offset: 0x00235C00
	public int GetLastChallengeRound(bool? endless = null)
	{
		return this.GetCurrentLevelRecord(endless).TeamChallengeInfos.Count - 1;
	}

	// Token: 0x0600A0EF RID: 41199 RVA: 0x00237A18 File Offset: 0x00235C18
	public bool IsRoundChallenged(int round, bool? endless = null)
	{
		int lastChallengeRound = this.GetLastChallengeRound(endless);
		return lastChallengeRound != -1 && round <= lastChallengeRound;
	}

	// Token: 0x0600A0F0 RID: 41200 RVA: 0x00237A38 File Offset: 0x00235C38
	public bool IsTeamRoundCanChallenge(int round)
	{
		if (this.IsRoundChallenged(round, null))
		{
			return true;
		}
		int maxChallengeRound = this.GetMaxChallengeRound(null);
		return round <= maxChallengeRound;
	}

	// Token: 0x0600A0F1 RID: 41201 RVA: 0x00237A70 File Offset: 0x00235C70
	public bool HasChallengeAnyRound(bool? isEndless = null)
	{
		return this.GetLastChallengeRound(isEndless) >= 0;
	}

	// Token: 0x0600A0F2 RID: 41202 RVA: 0x00237A80 File Offset: 0x00235C80
	public int GetMaxChallengeRound(bool? isEndless = null)
	{
		int lastChallengeRound = this.GetLastChallengeRound(isEndless);
		if (this.IsLastRound(lastChallengeRound, isEndless))
		{
			return lastChallengeRound;
		}
		return lastChallengeRound + 1;
	}

	// Token: 0x0600A0F3 RID: 41203 RVA: 0x00237AA4 File Offset: 0x00235CA4
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

	// Token: 0x0600A0F4 RID: 41204 RVA: 0x00237B58 File Offset: 0x00235D58
	public bool IsLastRoundCheckLimit(int levelId, int round)
	{
		int teamLimit = WheelTowerConfig.Instance.GetLevelConfigById(levelId).Value.TeamLimit;
		return teamLimit != 0 && round == teamLimit - 1;
	}

	// Token: 0x0600A0F5 RID: 41205 RVA: 0x00237B8C File Offset: 0x00235D8C
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

	// Token: 0x0600A0F6 RID: 41206 RVA: 0x00237BE0 File Offset: 0x00235DE0
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

	// Token: 0x0600A0F7 RID: 41207 RVA: 0x00237C20 File Offset: 0x00235E20
	public MonsterInfoPreview GetLastBossInfo(bool isEndless)
	{
		int lastChallengeRound = this.GetLastChallengeRound(new bool?(isEndless));
		return this.GetBossInfoByRound(lastChallengeRound, new bool?(isEndless));
	}

	// Token: 0x0600A0F8 RID: 41208 RVA: 0x00237C48 File Offset: 0x00235E48
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

	// Token: 0x0600A0F9 RID: 41209 RVA: 0x00237D4C File Offset: 0x00235F4C
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

	// Token: 0x0600A0FA RID: 41210 RVA: 0x00237DB4 File Offset: 0x00235FB4
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

	// Token: 0x0600A0FB RID: 41211 RVA: 0x00237E14 File Offset: 0x00236014
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

	// Token: 0x0600A0FC RID: 41212 RVA: 0x00238070 File Offset: 0x00236270
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

	// Token: 0x0600A0FD RID: 41213 RVA: 0x0023811C File Offset: 0x0023631C
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

	// Token: 0x0600A0FE RID: 41214 RVA: 0x00238190 File Offset: 0x00236390
	public double GetBossHpPercentage(MonsterInfoPreview bossPreview)
	{
		if (bossPreview.IsDead)
		{
			return 0.0;
		}
		double num = (double)bossPreview.HpPpb;
		return MathUtils.Instance.Clamp(num / 100.0, 0.01, 100.0);
	}

	// Token: 0x0600A0FF RID: 41215 RVA: 0x002381E0 File Offset: 0x002363E0
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

	// Token: 0x0600A100 RID: 41216 RVA: 0x00238274 File Offset: 0x00236474
	public List<int> GetRoundSelectBuffList(int round)
	{
		return this.GetCurrentLevelRecord(null).TeamChallengeInfos[round].BuffIds.ToList<int>();
	}

	// Token: 0x0600A101 RID: 41217 RVA: 0x002382A8 File Offset: 0x002364A8
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

	// Token: 0x0600A102 RID: 41218 RVA: 0x0023831C File Offset: 0x0023651C
	public int GetRoundScore(int round)
	{
		return this.ActivityData.GetRoundScore(this.EndlessMode, round);
	}

	// Token: 0x0600A103 RID: 41219 RVA: 0x00238330 File Offset: 0x00236530
	public int GetRoundTotalScore(int round)
	{
		return this.ActivityData.GetRoundTotalScore(this.EndlessMode, round);
	}

	// Token: 0x0600A104 RID: 41220 RVA: 0x00238344 File Offset: 0x00236544
	public int GetSelectedRoundTotalScore()
	{
		return this.GetRoundTotalScore(this.SelectedRound);
	}

	// Token: 0x0600A105 RID: 41221 RVA: 0x00238352 File Offset: 0x00236552
	public void SetEndlessMode(bool endless)
	{
		if (this.EndlessMode == endless)
		{
			return;
		}
		this.EndlessMode = endless;
		this.ResetSelectedData();
	}

	// Token: 0x0600A106 RID: 41222 RVA: 0x0023836C File Offset: 0x0023656C
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

	// Token: 0x0600A107 RID: 41223 RVA: 0x002383DD File Offset: 0x002365DD
	public void ResetSelectedData()
	{
		this.SelectedRound = -1;
		this.SelectedBuff = -1;
		this.SelectedRoleList.Clear();
	}

	// Token: 0x0600A108 RID: 41224 RVA: 0x002383F8 File Offset: 0x002365F8
	public bool CheckSelectTeamIsFull()
	{
		return this.SelectedRoleList.Count >= this.GetTeamMaxRoleCount();
	}

	// Token: 0x0600A109 RID: 41225 RVA: 0x00238410 File Offset: 0x00236610
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

	// Token: 0x0600A10A RID: 41226 RVA: 0x00238454 File Offset: 0x00236654
	public bool CheckBuffIsSelected()
	{
		return this.SelectedBuff > 0;
	}

	// Token: 0x0600A10B RID: 41227 RVA: 0x0023845F File Offset: 0x0023665F
	public bool CheckSelectedIsConflict()
	{
		return this.CheckCurrentSelectConflict().Count != 0;
	}

	// Token: 0x0600A10C RID: 41228 RVA: 0x0023846F File Offset: 0x0023666F
	public List<IConflictInfo> CheckCurrentSelectConflict()
	{
		return this.CheckConflictList(this.SelectedRoleList);
	}

	// Token: 0x0600A10D RID: 41229 RVA: 0x00238480 File Offset: 0x00236680
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

	// Token: 0x0600A10E RID: 41230 RVA: 0x002384C0 File Offset: 0x002366C0
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

	// Token: 0x0600A10F RID: 41231 RVA: 0x00238574 File Offset: 0x00236774
	public int GetConflictWeaponRoleId(int roleId)
	{
		int value = (WeaponModel.Instance.GetWeaponDataByRoleDataId(roleId, true) as WeaponInstance).GetIncId().Value;
		return this.SelectedEnergyInfo.GetWeaponOccupyRoleId(value, roleId);
	}

	// Token: 0x0600A110 RID: 41232 RVA: 0x002385B0 File Offset: 0x002367B0
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

	// Token: 0x0600A111 RID: 41233 RVA: 0x0023860C File Offset: 0x0023680C
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

	// Token: 0x0600A112 RID: 41234 RVA: 0x00238660 File Offset: 0x00236860
	public void SelectToTmp()
	{
		this.TmpSelectedRoleMap.Clear();
		for (int i = 0; i < this.SelectedRoleList.Count; i++)
		{
			int value = this.SelectedRoleList[i];
			this.TmpSelectedRoleMap[i] = value;
		}
	}

	// Token: 0x0600A113 RID: 41235 RVA: 0x002386A8 File Offset: 0x002368A8
	public void SetTmpSelectRoleList(List<int> roleList)
	{
		this.TmpSelectedRoleMap.Clear();
		for (int i = 0; i < roleList.Count; i++)
		{
			this.TmpSelectedRoleMap[i] = roleList[i];
		}
	}

	// Token: 0x0600A114 RID: 41236 RVA: 0x002386E4 File Offset: 0x002368E4
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

	// Token: 0x0600A115 RID: 41237 RVA: 0x00238738 File Offset: 0x00236938
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

	// Token: 0x0600A116 RID: 41238 RVA: 0x00238773 File Offset: 0x00236973
	public bool IsSelectRole(int roleId)
	{
		return this.GetRoleSlot(roleId) >= 0;
	}

	// Token: 0x0600A117 RID: 41239 RVA: 0x00238782 File Offset: 0x00236982
	public bool IsTempHasAnyEmptySlot()
	{
		return this.GetFirstEmptySlot() >= 0;
	}

	// Token: 0x0600A118 RID: 41240 RVA: 0x00238790 File Offset: 0x00236990
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

	// Token: 0x0600A119 RID: 41241 RVA: 0x002387C0 File Offset: 0x002369C0
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

	// Token: 0x0600A11A RID: 41242 RVA: 0x002387E5 File Offset: 0x002369E5
	public void SetRecordPopupData(IWheelTowerCoverRecordViewData data)
	{
		this.LevelRecordPopupDataMap[this.EndlessMode] = data;
	}

	// Token: 0x0600A11B RID: 41243 RVA: 0x002387F9 File Offset: 0x002369F9
	public void DeleteRecordPopupData()
	{
		this.LevelRecordPopupDataMap.Remove(this.EndlessMode);
	}

	// Token: 0x0600A11C RID: 41244 RVA: 0x00238810 File Offset: 0x00236A10
	public string GetScoreResourceIdByLevel(EScoreLevel level)
	{
		string result;
		if (!WheelTowerDefine.LevelItemMappingTable.TryGetValue(level, out result))
		{
			return "";
		}
		return result;
	}

	// Token: 0x0600A11D RID: 41245 RVA: 0x00238833 File Offset: 0x00236A33
	public EScoreLevel GetRoundScoreLevel(int score)
	{
		return EScoreLevel.None;
	}

	// Token: 0x0600A11E RID: 41246 RVA: 0x00238838 File Offset: 0x00236A38
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

	// Token: 0x0600A11F RID: 41247 RVA: 0x002388DC File Offset: 0x00236ADC
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

	// Token: 0x0600A120 RID: 41248 RVA: 0x00238984 File Offset: 0x00236B84
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

	// Token: 0x0600A121 RID: 41249 RVA: 0x00238A50 File Offset: 0x00236C50
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

	// Token: 0x0600A122 RID: 41250 RVA: 0x00238AA0 File Offset: 0x00236CA0
	public bool GetIsEndlessUnlockedInInstance()
	{
		if (this.IsEndlessUnlockedInInstance)
		{
			this.IsEndlessUnlockedInInstance = false;
			return true;
		}
		return false;
	}

	// Token: 0x0600A123 RID: 41251 RVA: 0x00238AB4 File Offset: 0x00236CB4
	public void SetIsEndlessUnlockedInInstance(bool value)
	{
		this.IsEndlessUnlockedInInstance = value;
	}

	// Token: 0x0600A124 RID: 41252 RVA: 0x00238AC0 File Offset: 0x00236CC0
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

	// Token: 0x0600A125 RID: 41253 RVA: 0x00238AFC File Offset: 0x00236CFC
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

	// Token: 0x0600A126 RID: 41254 RVA: 0x00238B38 File Offset: 0x00236D38
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

	// Token: 0x0600A127 RID: 41255 RVA: 0x00238BB8 File Offset: 0x00236DB8
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

	// Token: 0x0600A128 RID: 41256 RVA: 0x00238C44 File Offset: 0x00236E44
	private void ClearRoleData()
	{
		this.RoleToTemplate.Clear();
		this.TemplateToRole.Clear();
		this.EnhancedRoleSetInterval.Clear();
	}

	// Token: 0x0600A129 RID: 41257 RVA: 0x00238C67 File Offset: 0x00236E67
	public bool IsTemplateRole(int roleId)
	{
		return this.TemplateToRole.ContainsKey(roleId);
	}

	// Token: 0x0600A12A RID: 41258 RVA: 0x00238C78 File Offset: 0x00236E78
	public int GetTemplateRoleId(int roleId)
	{
		int result;
		if (!this.RoleToTemplate.TryGetValue(roleId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0600A12B RID: 41259 RVA: 0x00238C98 File Offset: 0x00236E98
	public int GetRealRoleId(int templateRoleId)
	{
		int result;
		if (!this.TemplateToRole.TryGetValue(templateRoleId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0600A12C RID: 41260 RVA: 0x00238CB8 File Offset: 0x00236EB8
	public int TryGetRealRoleId(int roleId)
	{
		if (!this.IsTemplateRole(roleId))
		{
			return roleId;
		}
		return this.GetRealRoleId(roleId);
	}

	// Token: 0x0600A12D RID: 41261 RVA: 0x00238CCC File Offset: 0x00236ECC
	public string GetTemplateRoleDesc(int roleId)
	{
		int roleId2 = this.TryGetRealRoleId(roleId);
		return WheelTowerConfig.Instance.GetRoleConfigByRoleId(roleId2).Value.TemplateDesc;
	}

	// Token: 0x17000D96 RID: 3478
	// (get) Token: 0x0600A12E RID: 41262 RVA: 0x00238CFC File Offset: 0x00236EFC
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

	// Token: 0x0600A12F RID: 41263 RVA: 0x00238D38 File Offset: 0x00236F38
	public List<int> GetEnhanceRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (int item in this.EnhancedRoleSet)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600A130 RID: 41264 RVA: 0x00238D94 File Offset: 0x00236F94
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

	// Token: 0x0600A131 RID: 41265 RVA: 0x00238F2C File Offset: 0x0023712C
	public bool IsEnhanceRole(int roleId)
	{
		int item = this.TryGetRealRoleId(roleId);
		return this.EnhancedRoleSet.Contains(item);
	}

	// Token: 0x0600A132 RID: 41266 RVA: 0x00238F50 File Offset: 0x00237150
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

	// Token: 0x0600A133 RID: 41267 RVA: 0x00238FE8 File Offset: 0x002371E8
	private string GetLocalDesc(string textId, string[] param)
	{
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(textId, null), param);
	}

	// Token: 0x0600A134 RID: 41268 RVA: 0x00238FF8 File Offset: 0x002371F8
	public bool IsEnhanceSkill(int roleId, int skillId)
	{
		if (!this.IsEnhanceRole(roleId))
		{
			return false;
		}
		int skillType = RoleSkillConfig.Instance.GetSkillConfigById(skillId).Value.SkillType;
		return this.GetRoleSkillEnhanceDescAndParam(roleId, skillType) != null;
	}

	// Token: 0x0600A135 RID: 41269 RVA: 0x0023903C File Offset: 0x0023723C
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

	// Token: 0x17000D97 RID: 3479
	// (get) Token: 0x0600A136 RID: 41270 RVA: 0x002390B4 File Offset: 0x002372B4
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

	// Token: 0x0600A137 RID: 41271 RVA: 0x00239130 File Offset: 0x00237330
	public int GetSpecialUpRoleAddEnergy(int roleId)
	{
		int result;
		if (!this.SpecialUpRoleMap.TryGetValue(roleId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0600A138 RID: 41272 RVA: 0x00239150 File Offset: 0x00237350
	[NullableContext(2)]
	public IWheelTowerMedalGroupData GetMedalGroupData(int groupId)
	{
		return this.ActivityData.GetMedalGroupData(groupId);
	}

	// Token: 0x0600A139 RID: 41273 RVA: 0x00239160 File Offset: 0x00237360
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

	// Token: 0x0600A13A RID: 41274 RVA: 0x00239254 File Offset: 0x00237454
	public List<IWheelTowerMedalGroupData> GetAllSeasonMedalGroupList(int seasonId)
	{
		List<IWheelTowerMedalGroupData> seasonMedalGroupList = this.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Season);
		seasonMedalGroupList.AddRange(this.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Stage));
		return seasonMedalGroupList;
	}

	// Token: 0x0600A13B RID: 41275 RVA: 0x0023926C File Offset: 0x0023746C
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

	// Token: 0x0600A13C RID: 41276 RVA: 0x002392A4 File Offset: 0x002374A4
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

	// Token: 0x0600A13D RID: 41277 RVA: 0x00239350 File Offset: 0x00237550
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

	// Token: 0x0600A13E RID: 41278 RVA: 0x002393E8 File Offset: 0x002375E8
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

	// Token: 0x17000D98 RID: 3480
	// (get) Token: 0x0600A13F RID: 41279 RVA: 0x002394C8 File Offset: 0x002376C8
	public static WheelTowerModel Instance
	{
		get
		{
			return WheelTowerModel._Instance;
		}
	}

	// Token: 0x0600A140 RID: 41280 RVA: 0x002394CF File Offset: 0x002376CF
	public static WheelTowerModel GetOrCreateInstance()
	{
		if (WheelTowerModel._Instance == null)
		{
			WheelTowerModel.CreateInstance();
		}
		return WheelTowerModel._Instance;
	}

	// Token: 0x0600A141 RID: 41281 RVA: 0x002394E3 File Offset: 0x002376E3
	public static bool CreateInstance()
	{
		if (WheelTowerModel._Instance != null)
		{
			return true;
		}
		WheelTowerModel._Instance = new WheelTowerModel();
		return true;
	}

	// Token: 0x0600A142 RID: 41282 RVA: 0x002394F9 File Offset: 0x002376F9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A143 RID: 41283 RVA: 0x002394FB File Offset: 0x002376FB
	public static void ResetStaticDefaultValue()
	{
		WheelTowerModel._Instance = null;
	}

	// Token: 0x0600A144 RID: 41284 RVA: 0x00239503 File Offset: 0x00237703
	static WheelTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WheelTowerModel.CreateStaticDefaultValue), new Action(WheelTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004947 RID: 18759
	private int ActivityDataIdInternal = -1;

	// Token: 0x04004948 RID: 18760
	[Nullable(2)]
	private Dictionary<int, int> RoleCostMap;

	// Token: 0x04004949 RID: 18761
	private int DefaultRoleCost = -1;

	// Token: 0x0400494A RID: 18762
	public bool EndlessMode;

	// Token: 0x0400494B RID: 18763
	public int SelectedRound = -1;

	// Token: 0x0400494C RID: 18764
	public int SelectedBuff = -1;

	// Token: 0x0400494D RID: 18765
	public int SelectedBossId = -1;

	// Token: 0x0400494E RID: 18766
	public List<int> SelectedRoleList = new List<int>();

	// Token: 0x0400494F RID: 18767
	[Nullable(2)]
	public CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.EnergyInfo SelectedEnergyInfo;

	// Token: 0x04004950 RID: 18768
	public readonly Dictionary<int, int> TmpSelectedRoleMap = new Dictionary<int, int>();

	// Token: 0x04004951 RID: 18769
	private readonly Dictionary<bool, IWheelTowerCoverRecordViewData> LevelRecordPopupDataMap = new Dictionary<bool, IWheelTowerCoverRecordViewData>();

	// Token: 0x04004952 RID: 18770
	private readonly Dictionary<int, List<WheelTowerScoreLevelTargetData>> LevelIdToScoreLevelTargetDataList = new Dictionary<int, List<WheelTowerScoreLevelTargetData>>();

	// Token: 0x04004953 RID: 18771
	public bool BlockEndlessUnlockTips = true;

	// Token: 0x04004954 RID: 18772
	private bool IsEndlessUnlockedInInstance;

	// Token: 0x04004955 RID: 18773
	public int CachedRoundInProgress = -1;

	// Token: 0x04004956 RID: 18774
	public bool IsTimeStopBanned;

	// Token: 0x04004957 RID: 18775
	private readonly Dictionary<int, int> RoleToTemplate = new Dictionary<int, int>();

	// Token: 0x04004958 RID: 18776
	private readonly Dictionary<int, int> TemplateToRole = new Dictionary<int, int>();

	// Token: 0x04004959 RID: 18777
	private HashSet<int> EnhancedRoleSetInterval = new HashSet<int>();

	// Token: 0x0400495A RID: 18778
	public int TmpSelectRoleId;

	// Token: 0x0400495B RID: 18779
	[Nullable(2)]
	private Dictionary<int, int> SpecialUpRoleMapInternal;

	// Token: 0x0400495C RID: 18780
	[Nullable(2)]
	private static WheelTowerModel _Instance;
}
