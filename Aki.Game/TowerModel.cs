using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

// Token: 0x02002158 RID: 8536
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TowerModel : ModelBase
{
	// Token: 0x06014F24 RID: 85796 RVA: 0x0061987C File Offset: 0x00617A7C
	protected override bool OnInit()
	{
		this.MaxRoleCost = ConfigCommonParamById.GetIntConfig("TowerRoleTotalCost").Value;
		this.TowerGuideDelayTime = ConfigCommonParamById.GetIntConfig("TowerGuideDelayTime").Value;
		this.TowerSettlementDelayTime = ConfigCommonParamById.GetIntConfig("TowerSettleDelayTime").Value;
		return true;
	}

	// Token: 0x06014F25 RID: 85797 RVA: 0x006198D2 File Offset: 0x00617AD2
	protected override bool OnLeaveLevel()
	{
		this.CurrentSelectFloor = -1;
		return true;
	}

	// Token: 0x06014F26 RID: 85798 RVA: 0x006198DC File Offset: 0x00617ADC
	private void InitReward()
	{
		this.SetDifficultyReward(1, null);
		this.SetDifficultyReward(2, null);
		this.SetDifficultyReward(3, null);
		this.SetDifficultyReward(4, null);
	}

	// Token: 0x06014F27 RID: 85799 RVA: 0x00619900 File Offset: 0x00617B00
	public void RefreshTowerInfo(TowerInfo towerInfo)
	{
		this.TowerBeginTime = new long?(towerInfo.BeginTime);
		this.TowerEndTime = new long?(towerInfo.EndTime);
		this.MaxUnlockDifficulty = towerInfo.MaxUnlockDifficulty;
		this.QuickPassId = towerInfo.QuickPassId;
		if (this.CurrentSeason != towerInfo.CurrentSeason)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, 100300002);
		}
		this.CurrentSeason = towerInfo.CurrentSeason;
		this.InitReward();
		this.DataSeason = towerInfo.DataSeason;
		this.RefreshTowerInfoByDifficulty(towerInfo.TowerDifficulties);
		this.ReportPeriodicActivityRedAppear();
	}

	// Token: 0x06014F28 RID: 85800 RVA: 0x0061999C File Offset: 0x00617B9C
	public void RefreshTowerInfoByFloor(IList<TowerFloorPb> floorInfo)
	{
		foreach (TowerFloorPb infoFormFloor in floorInfo)
		{
			this.SetInfoFormFloor(infoFormFloor);
		}
	}

	// Token: 0x06014F29 RID: 85801 RVA: 0x006199E4 File Offset: 0x00617BE4
	public void RefreshTowerInfoByDifficulty(IList<TowerDifficultyPb> difficultyInfo)
	{
		foreach (TowerDifficultyPb towerDifficultyPb in difficultyInfo)
		{
			this.SetDifficultyReward(towerDifficultyPb.Difficulty, towerDifficultyPb.RewardIndex);
			this.SetTowerInfoMapFormAreasData(towerDifficultyPb.TowerAreas);
			this.TowerDifficultiesMaxStarMap[towerDifficultyPb.Difficulty] = towerDifficultyPb.MaxStar;
		}
	}

	// Token: 0x06014F2A RID: 85802 RVA: 0x00619A5C File Offset: 0x00617C5C
	public void DeleteVariationTowerInfo()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, TowerFloorInfo> keyValuePair in this.TowerInfoMap)
		{
			if (keyValuePair.Value.Difficulties == 3)
			{
				list.Add(keyValuePair.Key);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			this.TowerInfoMap.Remove(list[i]);
		}
		this.TowerDifficultiesRewardMap.Remove(3);
		this.TowerDifficultiesMaxStarMap[3] = 0;
		foreach (Dictionary<int, int> dictionary in this.RoleDifficultyFormationMap.Values)
		{
			dictionary[3] = 0;
		}
	}

	// Token: 0x06014F2B RID: 85803 RVA: 0x00619B50 File Offset: 0x00617D50
	public int? GetFloorStars(int towerId)
	{
		TowerFloorInfo towerFloorInfo;
		if (this.TowerInfoMap.TryGetValue(towerId, out towerFloorInfo))
		{
			return new int?(towerFloorInfo.Star);
		}
		return null;
	}

	// Token: 0x06014F2C RID: 85804 RVA: 0x00619B84 File Offset: 0x00617D84
	[NullableContext(2)]
	public List<int> GetFloorStarsIndex(int towerId)
	{
		TowerFloorInfo towerFloorInfo;
		if (this.TowerInfoMap.TryGetValue(towerId, out towerFloorInfo))
		{
			return towerFloorInfo.StarIndex;
		}
		return null;
	}

	// Token: 0x06014F2D RID: 85805 RVA: 0x00619BAC File Offset: 0x00617DAC
	public int GetAreaStars(int difficulty, int area, bool useHandle = false)
	{
		int num = 0;
		if (!useHandle)
		{
			using (Dictionary<int, TowerFloorInfo>.ValueCollection.Enumerator enumerator = this.TowerInfoMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TowerFloorInfo towerFloorInfo = enumerator.Current;
					if (towerFloorInfo.Difficulties == difficulty && towerFloorInfo.Area == area)
					{
						num += towerFloorInfo.Star;
					}
				}
				return num;
			}
		}
		if (this.TowerInfoMapHandle != null)
		{
			foreach (TowerFloorInfo towerFloorInfo2 in this.TowerInfoMapHandle.Values)
			{
				if (towerFloorInfo2.Difficulties == difficulty && towerFloorInfo2.Area == area)
				{
					num += towerFloorInfo2.Star;
				}
			}
		}
		return num;
	}

	// Token: 0x06014F2E RID: 85806 RVA: 0x00619C84 File Offset: 0x00617E84
	public int GetDifficultyMaxStars(int difficulty, bool useHandle = false)
	{
		int? num = null;
		int value2;
		if (!useHandle)
		{
			int value;
			if (this.TowerDifficultiesMaxStarMap.TryGetValue(difficulty, out value))
			{
				num = new int?(value);
			}
		}
		else if (this.TowerDifficultiesMaxStarMapHandle != null && this.TowerDifficultiesMaxStarMapHandle.TryGetValue(difficulty, out value2))
		{
			num = new int?(value2);
		}
		return num.GetValueOrDefault();
	}

	// Token: 0x06014F2F RID: 85807 RVA: 0x00619CE0 File Offset: 0x00617EE0
	public int GetDifficultyStars(int difficulty)
	{
		int num = 0;
		foreach (TowerFloorInfo towerFloorInfo in this.TowerInfoMap.Values)
		{
			if (towerFloorInfo.Difficulties == difficulty)
			{
				num += towerFloorInfo.Star;
			}
		}
		return num;
	}

	// Token: 0x06014F30 RID: 85808 RVA: 0x00619D48 File Offset: 0x00617F48
	public int GetAreaAllStars(int difficulty, int area)
	{
		return 3 * TowerClimbConfig.Instance.GetAreaFloorNumber(this.CurrentSeason, difficulty, area);
	}

	// Token: 0x06014F31 RID: 85809 RVA: 0x00619D5E File Offset: 0x00617F5E
	public int GetDifficultyAllStars(int difficulty, bool useHandle = false)
	{
		return 3 * TowerClimbConfig.Instance.GetDifficultyFloorNumber(useHandle ? this.SeasonHandle : this.CurrentSeason, difficulty);
	}

	// Token: 0x06014F32 RID: 85810 RVA: 0x00619D80 File Offset: 0x00617F80
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<TowerReward> GetDifficultyReward(int difficulty)
	{
		List<TowerReward> result;
		if (this.TowerDifficultiesRewardMap.TryGetValue(difficulty, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06014F33 RID: 85811 RVA: 0x00619DA0 File Offset: 0x00617FA0
	public bool GetHaveChallengeFloor(int floorId)
	{
		return this.TowerInfoMap.ContainsKey(floorId);
	}

	// Token: 0x06014F34 RID: 85812 RVA: 0x00619DB0 File Offset: 0x00617FB0
	public bool GetHaveChallengeFloorAndFormation(int floorId)
	{
		TowerFloorInfo towerFloorInfo;
		return this.TowerInfoMap.TryGetValue(floorId, out towerFloorInfo) && towerFloorInfo.Formation != null && towerFloorInfo.Formation.Count != 0;
	}

	// Token: 0x06014F35 RID: 85813 RVA: 0x00619DE8 File Offset: 0x00617FE8
	[NullableContext(2)]
	public TowerFloorInfo GetFloorData(int floorId)
	{
		TowerFloorInfo result;
		if (this.TowerInfoMap.TryGetValue(floorId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06014F36 RID: 85814 RVA: 0x00619E08 File Offset: 0x00618008
	[NullableContext(2)]
	private void SetDifficultyReward(int difficulty, IList<int> rewardIndex)
	{
		List<TowerReward> difficultyReward = this.GetDifficultyReward(difficulty);
		if (difficultyReward != null)
		{
			for (int i = 0; i < difficultyReward.Count; i++)
			{
				TowerReward towerReward = difficultyReward[i];
				towerReward.IsReceived = new bool?(rewardIndex != null && this.Contains(rewardIndex, towerReward.Index));
			}
			return;
		}
		TowerSeason? towerSeason = TowerClimbConfig.Instance.GetTowerSeason(this.CurrentSeason);
		IReadOnlyList<IntPair> difficultyReward2 = TowerClimbConfig.Instance.GetDifficultyReward(difficulty, (towerSeason != null) ? towerSeason.GetValueOrDefault().RewardGroup : 0);
		int num = (difficultyReward2 != null) ? difficultyReward2.Count : 0;
		List<TowerReward> list = new List<TowerReward>();
		for (int j = 0; j < num; j++)
		{
			IntPair intPair = difficultyReward2[j];
			list.Add(new TowerReward(intPair.Item1, intPair.Item2, j)
			{
				IsReceived = new bool?(rewardIndex != null && this.Contains(rewardIndex, j))
			});
		}
		this.TowerDifficultiesRewardMap[difficulty] = list;
	}

	// Token: 0x06014F37 RID: 85815 RVA: 0x00619F10 File Offset: 0x00618110
	private void SetTowerInfoMapFormAreasData(IList<TowerAreaPb> areas)
	{
		foreach (TowerAreaPb towerAreaPb in areas)
		{
			foreach (TowerFloorPb infoFormFloor in towerAreaPb.TowerFloors)
			{
				this.SetInfoFormFloor(infoFormFloor);
			}
		}
	}

	// Token: 0x06014F38 RID: 85816 RVA: 0x00619F8C File Offset: 0x0061818C
	private void SetInfoFormFloor(TowerFloorPb floorData)
	{
		TowerFloorInfo towerFloorInfo;
		if (this.TowerInfoMap.TryGetValue(floorData.TowerConfigId, out towerFloorInfo))
		{
			towerFloorInfo.Star = floorData.Star;
			towerFloorInfo.StarIndex = new List<int>(floorData.StarIndex);
			towerFloorInfo.IsQuickPass = floorData.IsQuickPass;
			if (towerFloorInfo.Formation != null)
			{
				for (int i = 0; i < towerFloorInfo.Formation.Count; i++)
				{
					TowerRolePb towerRolePb = towerFloorInfo.Formation[i];
					this.ReduceRoleFormationCost(towerRolePb.RoleId, towerFloorInfo.Difficulties, towerFloorInfo.Cost);
				}
			}
			towerFloorInfo.Formation = new List<TowerRolePb>(floorData.Formation);
		}
		else
		{
			towerFloorInfo = new TowerFloorInfo(floorData.TowerConfigId, floorData.Star, new List<TowerRolePb>(floorData.Formation), new List<int>(floorData.StarIndex), floorData.IsQuickPass);
			this.TowerInfoMap[floorData.TowerConfigId] = towerFloorInfo;
			EventSystem.Instance.Emit<int, int>(EEventName.OnTowerRecordUpdate, floorData.TowerConfigId, towerFloorInfo.Difficulties);
		}
		if (towerFloorInfo.Formation != null)
		{
			for (int j = 0; j < towerFloorInfo.Formation.Count; j++)
			{
				TowerRolePb towerRolePb2 = towerFloorInfo.Formation[j];
				this.AddRoleFormationCost(towerRolePb2.RoleId, towerFloorInfo.Difficulties, towerFloorInfo.Cost);
			}
		}
	}

	// Token: 0x06014F39 RID: 85817 RVA: 0x0061A0D0 File Offset: 0x006182D0
	private void AddRoleFormationCost(int roleId, int difficulty, int cost)
	{
		Dictionary<int, int> dictionary;
		if (!this.RoleDifficultyFormationMap.TryGetValue(roleId, out dictionary))
		{
			dictionary = new Dictionary<int, int>();
		}
		int num;
		if (dictionary.TryGetValue(difficulty, out num))
		{
			num += cost;
			dictionary[difficulty] = num;
		}
		else
		{
			dictionary[difficulty] = cost;
		}
		this.RoleDifficultyFormationMap[roleId] = dictionary;
	}

	// Token: 0x06014F3A RID: 85818 RVA: 0x0061A124 File Offset: 0x00618324
	public void ReduceRoleFormationCost(int roleId, int difficulty, int cost)
	{
		Dictionary<int, int> dictionary;
		int num;
		if (this.RoleDifficultyFormationMap.TryGetValue(roleId, out dictionary) && dictionary.TryGetValue(difficulty, out num) && num != 0)
		{
			num -= cost;
			dictionary[difficulty] = num;
		}
	}

	// Token: 0x06014F3B RID: 85819 RVA: 0x0061A15C File Offset: 0x0061835C
	[NullableContext(0)]
	public ValueTuple<int, int> GetDifficultyProgress(int difficultId)
	{
		int[] difficultyAllFloor = TowerClimbConfig.Instance.GetDifficultyAllFloor(this.CurrentSeason, difficultId);
		int num = 0;
		foreach (int key in difficultyAllFloor)
		{
			if (this.TowerInfoMap.ContainsKey(key))
			{
				num++;
			}
		}
		return new ValueTuple<int, int>(num, difficultyAllFloor.Length);
	}

	// Token: 0x06014F3C RID: 85820 RVA: 0x0061A1AC File Offset: 0x006183AC
	public bool GetDifficultyIsClear(int currentDifficulty)
	{
		if (this.MaxUnlockDifficulty > currentDifficulty)
		{
			return true;
		}
		foreach (int key in TowerClimbConfig.Instance.GetDifficultyAllFloor(this.CurrentSeason, currentDifficulty))
		{
			if (!this.TowerInfoMap.ContainsKey(key))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014F3D RID: 85821 RVA: 0x0061A1F9 File Offset: 0x006183F9
	public int GetMaxDifficulty()
	{
		if (!this.GetDifficultyIsClear(1))
		{
			return 1;
		}
		if (!this.GetDifficultyIsClear(2))
		{
			return 2;
		}
		if (this.GetDifficultyRewardProgress(3) != 1f)
		{
			return 3;
		}
		if (this.GetDifficultyRewardProgress(4) != 1f)
		{
			return 4;
		}
		return 3;
	}

	// Token: 0x06014F3E RID: 85822 RVA: 0x0061A236 File Offset: 0x00618436
	public int[] GetDifficultyAllAreaFirstFloor(int difficulty, bool useHandle = false)
	{
		return TowerClimbConfig.Instance.GetDifficultyAllAreaFirstFloor(useHandle ? this.SeasonHandle : this.CurrentSeason, difficulty);
	}

	// Token: 0x06014F3F RID: 85823 RVA: 0x0061A254 File Offset: 0x00618454
	public int[] GetDifficultyAreaAllFloor(int difficulty, int area)
	{
		return TowerClimbConfig.Instance.GetDifficultyAreaAllFloor(this.CurrentSeason, difficulty, area);
	}

	// Token: 0x06014F40 RID: 85824 RVA: 0x0061A268 File Offset: 0x00618468
	public int[] GetDifficultyAllFloor(int difficulty)
	{
		return TowerClimbConfig.Instance.GetDifficultyAllFloor(this.CurrentSeason, difficulty);
	}

	// Token: 0x06014F41 RID: 85825 RVA: 0x0061A27C File Offset: 0x0061847C
	public bool GetFloorIsUnlock(int towerId)
	{
		if (this.GetHaveChallengeFloor(towerId))
		{
			return true;
		}
		int lastFloorInArea = TowerClimbConfig.Instance.GetLastFloorInArea(towerId);
		return lastFloorInArea == 0 || this.GetHaveChallengeFloor(lastFloorInArea);
	}

	// Token: 0x06014F42 RID: 85826 RVA: 0x0061A2AC File Offset: 0x006184AC
	public int GetRoleRemainCost(int roleId, int difficulty)
	{
		Dictionary<int, int> dictionary;
		if (!this.RoleDifficultyFormationMap.TryGetValue(roleId, out dictionary))
		{
			return this.MaxRoleCost;
		}
		int num;
		if (!dictionary.TryGetValue(difficulty, out num))
		{
			return this.MaxRoleCost;
		}
		return this.MaxRoleCost - num;
	}

	// Token: 0x06014F43 RID: 85827 RVA: 0x0061A2EC File Offset: 0x006184EC
	public bool GetFloorIncludeRole(int roleId, int towerId)
	{
		TowerFloorInfo towerFloorInfo;
		if (!this.TowerInfoMap.TryGetValue(towerId, out towerFloorInfo))
		{
			return false;
		}
		if (towerFloorInfo.Formation == null)
		{
			return false;
		}
		for (int i = 0; i < towerFloorInfo.Formation.Count; i++)
		{
			if (towerFloorInfo.Formation[i].RoleId == roleId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014F44 RID: 85828 RVA: 0x0061A342 File Offset: 0x00618542
	public void OpenTowerFormationView(int towerId)
	{
		this.CurrentSelectFloor = towerId;
		UiManager.Instance.OpenView(EUiViewName.TowerChallengeFormationView, towerId, null);
	}

	// Token: 0x06014F45 RID: 85829 RVA: 0x0061A361 File Offset: 0x00618561
	public bool IsOpenFloorFormation()
	{
		return this.CurrentSelectFloor != -1;
	}

	// Token: 0x06014F46 RID: 85830 RVA: 0x0061A36F File Offset: 0x0061856F
	public string GetCurrentFloorName()
	{
		return this.GetFloorNameById(this.CurrentTowerId);
	}

	// Token: 0x06014F47 RID: 85831 RVA: 0x0061A380 File Offset: 0x00618580
	public string GetFloorNameById(int towerId)
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("TowerAreaFloor"), null);
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(towerId).Value;
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(value.AreaName, null);
		return localTextNew.Replace("{0}", localTextNew2).Replace("{1}", value.Floor.ToString() ?? "");
	}

	// Token: 0x06014F48 RID: 85832 RVA: 0x0061A3F4 File Offset: 0x006185F4
	public List<int> GetFloorFormation(int towerId)
	{
		List<int> list = new List<int>();
		TowerFloorInfo towerFloorInfo;
		if (!this.TowerInfoMap.TryGetValue(towerId, out towerFloorInfo) || towerFloorInfo.Formation == null)
		{
			return list;
		}
		for (int i = 0; i < towerFloorInfo.Formation.Count; i++)
		{
			list.Add(towerFloorInfo.Formation[i].RoleId);
		}
		return list;
	}

	// Token: 0x06014F49 RID: 85833 RVA: 0x0061A44F File Offset: 0x0061864F
	public void SaveNeedOpenConfirmView()
	{
		this.NeedOpenConfirmViewTowerId = this.CurrentTowerId;
		this.NeedOpenConfirmView = true;
	}

	// Token: 0x06014F4A RID: 85834 RVA: 0x0061A464 File Offset: 0x00618664
	public void ClearNotConfirmedData()
	{
		this.NeedOpenConfirmViewTowerId = -1;
		this.NeedOpenConfirmView = false;
		this.CurrentNotConfirmedFloor = null;
	}

	// Token: 0x06014F4B RID: 85835 RVA: 0x0061A47B File Offset: 0x0061867B
	public void OpenReviewView()
	{
		if (!this.NeedOpenReviveView)
		{
			return;
		}
		this.NeedOpenReviveView = false;
		if (this.GetDifficultyMaxStars(3, true) > 0)
		{
			UiManager.Instance.OpenView(EUiViewName.TowerReviewView, null, null);
		}
		this.DataSeason = this.CurrentSeason;
	}

	// Token: 0x06014F4C RID: 85836 RVA: 0x0061A4B5 File Offset: 0x006186B5
	public void SaveHandleData()
	{
		this.TowerInfoMapHandle = new Dictionary<int, TowerFloorInfo>(this.TowerInfoMap);
		this.TowerDifficultiesMaxStarMapHandle = new Dictionary<int, int>(this.TowerDifficultiesMaxStarMap);
		this.SeasonHandle = this.DataSeason;
	}

	// Token: 0x06014F4D RID: 85837 RVA: 0x0061A4E5 File Offset: 0x006186E5
	public void ClearHandleData()
	{
		Dictionary<int, TowerFloorInfo> towerInfoMapHandle = this.TowerInfoMapHandle;
		if (towerInfoMapHandle != null)
		{
			towerInfoMapHandle.Clear();
		}
		this.TowerInfoMapHandle = null;
		Dictionary<int, int> towerDifficultiesMaxStarMapHandle = this.TowerDifficultiesMaxStarMapHandle;
		if (towerDifficultiesMaxStarMapHandle != null)
		{
			towerDifficultiesMaxStarMapHandle.Clear();
		}
		this.TowerDifficultiesMaxStarMapHandle = null;
		this.SeasonHandle = -1;
	}

	// Token: 0x06014F4E RID: 85838 RVA: 0x0061A51E File Offset: 0x0061871E
	public bool CheckInTower()
	{
		return this.CurrentTowerId != -1;
	}

	// Token: 0x06014F4F RID: 85839 RVA: 0x0061A52C File Offset: 0x0061872C
	public CommonDefine.ICountDown GetSeasonCountDownData()
	{
		double num = (double)MathUtils.Instance.LongToNumber(this.TowerEndTime.GetValueOrDefault()) - TimeUtil.Instance.GetServerTime();
		if (num <= 1.0)
		{
			num = 1.0;
		}
		CommonDefine.ETimeType value = (num >= 86400.0) ? CommonDefine.ETimeType.Day : ((num >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
		CommonDefine.ETimeType value2 = (num >= 86400.0) ? CommonDefine.ETimeType.Hour : ((num >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
		return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2));
	}

	// Token: 0x06014F50 RID: 85840 RVA: 0x0061A5C8 File Offset: 0x006187C8
	public bool CanGetReward()
	{
		List<TowerReward> difficultyReward = this.GetDifficultyReward(this.CurrentSelectDifficulties);
		if (difficultyReward == null)
		{
			return false;
		}
		int difficultyMaxStars = this.GetDifficultyMaxStars(this.CurrentSelectDifficulties, false);
		for (int i = 0; i < difficultyReward.Count; i++)
		{
			TowerReward towerReward = difficultyReward[i];
			if (difficultyMaxStars >= towerReward.Target)
			{
				bool? isReceived = towerReward.IsReceived;
				bool flag = false;
				if (isReceived.GetValueOrDefault() == flag & isReceived != null)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06014F51 RID: 85841 RVA: 0x0061A63C File Offset: 0x0061883C
	public bool CanGetRewardByDifficulties(int difficultId)
	{
		List<TowerReward> difficultyReward = this.GetDifficultyReward(difficultId);
		if (difficultyReward == null)
		{
			return false;
		}
		int difficultyMaxStars = this.GetDifficultyMaxStars(difficultId, false);
		for (int i = 0; i < difficultyReward.Count; i++)
		{
			TowerReward towerReward = difficultyReward[i];
			if (difficultyMaxStars >= towerReward.Target)
			{
				bool? isReceived = towerReward.IsReceived;
				bool flag = false;
				if (isReceived.GetValueOrDefault() == flag & isReceived != null)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06014F52 RID: 85842 RVA: 0x0061A6A4 File Offset: 0x006188A4
	public bool CanGetRewardAllDifficulties()
	{
		for (int i = 1; i <= 3; i++)
		{
			List<TowerReward> difficultyReward = this.GetDifficultyReward(i);
			int difficultyMaxStars = this.GetDifficultyMaxStars(i, false);
			if (difficultyReward != null)
			{
				for (int j = 0; j < difficultyReward.Count; j++)
				{
					TowerReward towerReward = difficultyReward[j];
					if (difficultyMaxStars >= towerReward.Target)
					{
						bool? isReceived = towerReward.IsReceived;
						bool flag = false;
						if (isReceived.GetValueOrDefault() == flag & isReceived != null)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06014F53 RID: 85843 RVA: 0x0061A71C File Offset: 0x0061891C
	public bool IsRewardAllFinished(int? difficultId = null)
	{
		int difficulty = difficultId ?? this.CurrentSelectDifficulties;
		List<TowerReward> difficultyReward = this.GetDifficultyReward(difficulty);
		if (difficultyReward == null)
		{
			return true;
		}
		for (int i = 0; i < difficultyReward.Count; i++)
		{
			bool? isReceived = difficultyReward[i].IsReceived;
			bool flag = false;
			if (isReceived.GetValueOrDefault() == flag & isReceived != null)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014F54 RID: 85844 RVA: 0x0061A78C File Offset: 0x0061898C
	public bool IsRoleCostEnough(int roleId)
	{
		TowerConfig? towerConfig;
		return this.GetFloorIncludeRole(roleId, this.CurrentSelectFloor) || this.GetRoleRemainCost(roleId, this.CurrentSelectDifficulties) >= ((TowerClimbConfig.Instance.GetTowerInfo(this.CurrentSelectFloor) != null) ? new int?(towerConfig.GetValueOrDefault().Cost) : null).GetValueOrDefault();
	}

	// Token: 0x06014F55 RID: 85845 RVA: 0x0061A800 File Offset: 0x00618A00
	public bool GetIsInOnceTower()
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(this.CurrentTowerId).Value;
		return value.Difficulty == 1 || value.Difficulty == 2;
	}

	// Token: 0x06014F56 RID: 85846 RVA: 0x0061A840 File Offset: 0x00618A40
	public float GetDifficultyRewardProgress(int difficulty)
	{
		List<TowerReward> difficultyReward = this.GetDifficultyReward(difficulty);
		int num = 0;
		for (int i = 0; i < ((difficultyReward != null) ? difficultyReward.Count : 0); i++)
		{
			if (difficultyReward[i].IsReceived.GetValueOrDefault())
			{
				num++;
			}
		}
		return (float)num / (float)((difficultyReward != null) ? difficultyReward.Count : 1);
	}

	// Token: 0x06014F57 RID: 85847 RVA: 0x0061A898 File Offset: 0x00618A98
	public bool GetOverLockHasShow()
	{
		bool? flag = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TowerOverLockArea) as ServerStorageBoolean).Get();
		if (!flag.GetValueOrDefault())
		{
			flag = new bool?(LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.TowerOverLockArea, false));
		}
		return flag.GetValueOrDefault();
	}

	// Token: 0x06014F58 RID: 85848 RVA: 0x0061A8DA File Offset: 0x00618ADA
	public void SetOverLockHasShow()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TowerOverLockArea) as ServerStorageBoolean).Set(new bool?(true));
	}

	// Token: 0x06014F59 RID: 85849 RVA: 0x0061A8F8 File Offset: 0x00618AF8
	public int GetLoopTowerIsClickSeason()
	{
		ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.LoopTowerIsClickSeason, EClientStorageSystemIdType.LoopTowerIsClickSeason, true);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.LoopTowerIsClickSeason) as ServerStorageNumber).Get().GetValueOrDefault(-1);
	}

	// Token: 0x06014F5A RID: 85850 RVA: 0x0061A930 File Offset: 0x00618B30
	public void SetLoopTowerIsClickSeason(int season)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.LoopTowerIsClickSeason) as ServerStorageNumber).Set(new int?(season));
		EventSystem.Instance.Emit(EEventName.RedDotAdventurePeriodicityTabUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, 100300002);
	}

	// Token: 0x06014F5B RID: 85851 RVA: 0x0061A980 File Offset: 0x00618B80
	public bool GetLoopTowerIsClickShop()
	{
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.LoopTowerIsClickShop, EClientStorageSystemIdType.LoopTowerIsClickShop, true);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.LoopTowerIsClickShop) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x06014F5C RID: 85852 RVA: 0x0061A9B4 File Offset: 0x00618BB4
	public void SetLoopTowerIsClickShop(bool click)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.LoopTowerIsClickShop) as ServerStorageBoolean).Set(new bool?(click));
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, 100300002);
	}

	// Token: 0x06014F5D RID: 85853 RVA: 0x0061A9E8 File Offset: 0x00618BE8
	[NullableContext(2)]
	public int[] GetRewardIdsByDifficulties(int difficultId, bool isCanReceive)
	{
		List<TowerReward> difficultyReward = this.GetDifficultyReward(difficultId);
		if (difficultyReward == null)
		{
			return null;
		}
		int difficultyMaxStars = this.GetDifficultyMaxStars(difficultId, false);
		List<int> list = new List<int>();
		for (int i = 0; i < difficultyReward.Count; i++)
		{
			TowerReward towerReward = difficultyReward[i];
			if (isCanReceive)
			{
				if (difficultyMaxStars >= towerReward.Target)
				{
					bool? isReceived = towerReward.IsReceived;
					bool flag = false;
					if (isReceived.GetValueOrDefault() == flag & isReceived != null)
					{
						list.Add(towerReward.RewardId);
					}
				}
			}
			else if (towerReward.IsReceived.GetValueOrDefault())
			{
				list.Add(towerReward.RewardId);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06014F5E RID: 85854 RVA: 0x0061AA8C File Offset: 0x00618C8C
	private void ReportPeriodicActivityRedAppear()
	{
		ActivityLoopTowerData activityLoopTowerData = ActivityModel.Instance.GetActivityById(100300002) as ActivityLoopTowerData;
		if (activityLoopTowerData != null && activityLoopTowerData.RedPointShowState)
		{
			AdventureGuideModel instance = AdventureGuideModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ReportPeriodicActivityRedAppear(EDungeonSubType.LoopTower);
		}
	}

	// Token: 0x06014F5F RID: 85855 RVA: 0x0061AACC File Offset: 0x00618CCC
	private bool Contains(IList<int> list, int value)
	{
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x17001FC0 RID: 8128
	// (get) Token: 0x06014F60 RID: 85856 RVA: 0x0061AAF7 File Offset: 0x00618CF7
	public static TowerModel Instance
	{
		get
		{
			return TowerModel._Instance;
		}
	}

	// Token: 0x06014F61 RID: 85857 RVA: 0x0061AAFE File Offset: 0x00618CFE
	public static TowerModel GetOrCreateInstance()
	{
		if (TowerModel._Instance == null)
		{
			TowerModel.CreateInstance();
		}
		return TowerModel._Instance;
	}

	// Token: 0x06014F62 RID: 85858 RVA: 0x0061AB12 File Offset: 0x00618D12
	public static bool CreateInstance()
	{
		if (TowerModel._Instance != null)
		{
			return true;
		}
		TowerModel._Instance = new TowerModel();
		return true;
	}

	// Token: 0x06014F63 RID: 85859 RVA: 0x0061AB28 File Offset: 0x00618D28
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014F64 RID: 85860 RVA: 0x0061AB2A File Offset: 0x00618D2A
	public static void ResetStaticDefaultValue()
	{
		TowerModel._Instance = null;
	}

	// Token: 0x06014F65 RID: 85861 RVA: 0x0061AB32 File Offset: 0x00618D32
	static TowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerModel.CreateStaticDefaultValue), new Action(TowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B28D RID: 45709
	public const int FLOOR_STAR = 3;

	// Token: 0x0400B28E RID: 45710
	public const string FINISH_COLOR = "#FFD12F";

	// Token: 0x0400B28F RID: 45711
	public const string NORMOL_COLOR = "#ECE5D8";

	// Token: 0x0400B290 RID: 45712
	public const string LOCK_COLOR = "#ADADAD";

	// Token: 0x0400B291 RID: 45713
	public const int TOWER_LOOP_ACTIVITY_ID = 100300002;

	// Token: 0x0400B292 RID: 45714
	public long? TowerBeginTime;

	// Token: 0x0400B293 RID: 45715
	public long? TowerEndTime;

	// Token: 0x0400B294 RID: 45716
	public int CurrentSeason = -1;

	// Token: 0x0400B295 RID: 45717
	public int DataSeason;

	// Token: 0x0400B296 RID: 45718
	public int CurrentSelectDifficulties = -1;

	// Token: 0x0400B297 RID: 45719
	public int CurrentTowerId = -1;

	// Token: 0x0400B298 RID: 45720
	[Nullable(2)]
	public List<int> CurrentTowerFormation;

	// Token: 0x0400B299 RID: 45721
	public bool NeedChangeFormation;

	// Token: 0x0400B29A RID: 45722
	[Nullable(2)]
	public TowerFloorInfo CurrentNotConfirmedFloor;

	// Token: 0x0400B29B RID: 45723
	public int NeedOpenConfirmViewTowerId = -1;

	// Token: 0x0400B29C RID: 45724
	public bool NeedOpenConfirmView;

	// Token: 0x0400B29D RID: 45725
	public int CurrentSelectFloor = -1;

	// Token: 0x0400B29E RID: 45726
	public Dictionary<int, Dictionary<int, int>> RoleDifficultyFormationMap = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400B29F RID: 45727
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TowerRecommendFormation[] RecommendFormation;

	// Token: 0x0400B2A0 RID: 45728
	public bool CurrentTowerLock;

	// Token: 0x0400B2A1 RID: 45729
	public int DefaultFloor = -1;

	// Token: 0x0400B2A2 RID: 45730
	private int MaxRoleCost;

	// Token: 0x0400B2A3 RID: 45731
	public int TowerGuideDelayTime;

	// Token: 0x0400B2A4 RID: 45732
	public int TowerSettlementDelayTime;

	// Token: 0x0400B2A5 RID: 45733
	private readonly Dictionary<int, TowerFloorInfo> TowerInfoMap = new Dictionary<int, TowerFloorInfo>();

	// Token: 0x0400B2A6 RID: 45734
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, TowerFloorInfo> TowerInfoMapHandle;

	// Token: 0x0400B2A7 RID: 45735
	private int SeasonHandle = -1;

	// Token: 0x0400B2A8 RID: 45736
	private readonly Dictionary<int, List<TowerReward>> TowerDifficultiesRewardMap = new Dictionary<int, List<TowerReward>>();

	// Token: 0x0400B2A9 RID: 45737
	private readonly Dictionary<int, int> TowerDifficultiesMaxStarMap = new Dictionary<int, int>();

	// Token: 0x0400B2AA RID: 45738
	[Nullable(2)]
	private Dictionary<int, int> TowerDifficultiesMaxStarMapHandle;

	// Token: 0x0400B2AB RID: 45739
	public bool NeedOpenReviveView;

	// Token: 0x0400B2AC RID: 45740
	public int MaxUnlockDifficulty;

	// Token: 0x0400B2AD RID: 45741
	public int QuickPassId;

	// Token: 0x0400B2AE RID: 45742
	public bool IsWaitTowerStart;

	// Token: 0x0400B2AF RID: 45743
	public bool IsWaitTowerSettlement;

	// Token: 0x0400B2B0 RID: 45744
	[Nullable(2)]
	private static TowerModel _Instance;
}
