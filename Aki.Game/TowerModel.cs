using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

// Token: 0x02002BDD RID: 11229
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TowerModel : ModelBase
{
	// Token: 0x060174F3 RID: 95475 RVA: 0x005ECD40 File Offset: 0x005EAF40
	protected override bool OnInit()
	{
		this.MaxRoleCost = ConfigCommonParamById.GetIntConfig("TowerRoleTotalCost").Value;
		this.TowerGuideDelayTime = ConfigCommonParamById.GetIntConfig("TowerGuideDelayTime").Value;
		this.TowerSettlementDelayTime = ConfigCommonParamById.GetIntConfig("TowerSettleDelayTime").Value;
		return true;
	}

	// Token: 0x060174F4 RID: 95476 RVA: 0x005ECD96 File Offset: 0x005EAF96
	protected override bool OnLeaveLevel()
	{
		this.CurrentSelectFloor = -1;
		return true;
	}

	// Token: 0x060174F5 RID: 95477 RVA: 0x005ECDA0 File Offset: 0x005EAFA0
	private void InitReward()
	{
		this.SetDifficultyReward(1, null);
		this.SetDifficultyReward(2, null);
		this.SetDifficultyReward(3, null);
		this.SetDifficultyReward(4, null);
	}

	// Token: 0x060174F6 RID: 95478 RVA: 0x005ECDC4 File Offset: 0x005EAFC4
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

	// Token: 0x060174F7 RID: 95479 RVA: 0x005ECE60 File Offset: 0x005EB060
	public void RefreshTowerInfoByFloor(IList<TowerFloorPb> floorInfo)
	{
		foreach (TowerFloorPb infoFormFloor in floorInfo)
		{
			this.SetInfoFormFloor(infoFormFloor);
		}
	}

	// Token: 0x060174F8 RID: 95480 RVA: 0x005ECEA8 File Offset: 0x005EB0A8
	public void RefreshTowerInfoByDifficulty(IList<TowerDifficultyPb> difficultyInfo)
	{
		foreach (TowerDifficultyPb towerDifficultyPb in difficultyInfo)
		{
			this.SetDifficultyReward(towerDifficultyPb.Difficulty, towerDifficultyPb.RewardIndex);
			this.SetTowerInfoMapFormAreasData(towerDifficultyPb.TowerAreas);
			this.TowerDifficultiesMaxStarMap[towerDifficultyPb.Difficulty] = towerDifficultyPb.MaxStar;
		}
	}

	// Token: 0x060174F9 RID: 95481 RVA: 0x005ECF20 File Offset: 0x005EB120
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

	// Token: 0x060174FA RID: 95482 RVA: 0x005ED014 File Offset: 0x005EB214
	public int? GetFloorStars(int towerId)
	{
		TowerFloorInfo towerFloorInfo;
		if (this.TowerInfoMap.TryGetValue(towerId, out towerFloorInfo))
		{
			return new int?(towerFloorInfo.Star);
		}
		return null;
	}

	// Token: 0x060174FB RID: 95483 RVA: 0x005ED048 File Offset: 0x005EB248
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

	// Token: 0x060174FC RID: 95484 RVA: 0x005ED070 File Offset: 0x005EB270
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

	// Token: 0x060174FD RID: 95485 RVA: 0x005ED148 File Offset: 0x005EB348
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

	// Token: 0x060174FE RID: 95486 RVA: 0x005ED1A4 File Offset: 0x005EB3A4
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

	// Token: 0x060174FF RID: 95487 RVA: 0x005ED20C File Offset: 0x005EB40C
	public int GetAreaAllStars(int difficulty, int area)
	{
		return 3 * TowerClimbConfig.Instance.GetAreaFloorNumber(this.CurrentSeason, difficulty, area);
	}

	// Token: 0x06017500 RID: 95488 RVA: 0x005ED222 File Offset: 0x005EB422
	public int GetDifficultyAllStars(int difficulty, bool useHandle = false)
	{
		return 3 * TowerClimbConfig.Instance.GetDifficultyFloorNumber(useHandle ? this.SeasonHandle : this.CurrentSeason, difficulty);
	}

	// Token: 0x06017501 RID: 95489 RVA: 0x005ED244 File Offset: 0x005EB444
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

	// Token: 0x06017502 RID: 95490 RVA: 0x005ED264 File Offset: 0x005EB464
	public bool GetHaveChallengeFloor(int floorId)
	{
		return this.TowerInfoMap.ContainsKey(floorId);
	}

	// Token: 0x06017503 RID: 95491 RVA: 0x005ED274 File Offset: 0x005EB474
	public bool GetHaveChallengeFloorAndFormation(int floorId)
	{
		TowerFloorInfo towerFloorInfo;
		return this.TowerInfoMap.TryGetValue(floorId, out towerFloorInfo) && towerFloorInfo.Formation != null && towerFloorInfo.Formation.Count != 0;
	}

	// Token: 0x06017504 RID: 95492 RVA: 0x005ED2AC File Offset: 0x005EB4AC
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

	// Token: 0x06017505 RID: 95493 RVA: 0x005ED2CC File Offset: 0x005EB4CC
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

	// Token: 0x06017506 RID: 95494 RVA: 0x005ED3D4 File Offset: 0x005EB5D4
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

	// Token: 0x06017507 RID: 95495 RVA: 0x005ED450 File Offset: 0x005EB650
	private void SetInfoFormFloor(TowerFloorPb floorData)
	{
		TowerFloorInfo towerFloorInfo;
		if (this.TowerInfoMap.TryGetValue(floorData.TowerConfigId, out towerFloorInfo))
		{
			towerFloorInfo.Star = floorData.Star;
			towerFloorInfo.StarIndex = floorData.StarIndex.ToList<int>();
			towerFloorInfo.IsQuickPass = floorData.IsQuickPass;
			if (towerFloorInfo.Formation != null)
			{
				for (int i = 0; i < towerFloorInfo.Formation.Count; i++)
				{
					TowerRolePb towerRolePb = towerFloorInfo.Formation[i];
					this.ReduceRoleFormationCost(towerRolePb.RoleId, towerFloorInfo.Difficulties, towerFloorInfo.Cost);
				}
			}
			towerFloorInfo.Formation = floorData.Formation.ToList<TowerRolePb>();
		}
		else
		{
			towerFloorInfo = new TowerFloorInfo(floorData.TowerConfigId, floorData.Star, floorData.Formation.ToList<TowerRolePb>(), floorData.StarIndex.ToList<int>(), floorData.IsQuickPass);
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

	// Token: 0x06017508 RID: 95496 RVA: 0x005ED594 File Offset: 0x005EB794
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

	// Token: 0x06017509 RID: 95497 RVA: 0x005ED5E8 File Offset: 0x005EB7E8
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

	// Token: 0x0601750A RID: 95498 RVA: 0x005ED620 File Offset: 0x005EB820
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

	// Token: 0x0601750B RID: 95499 RVA: 0x005ED670 File Offset: 0x005EB870
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

	// Token: 0x0601750C RID: 95500 RVA: 0x005ED6BD File Offset: 0x005EB8BD
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

	// Token: 0x0601750D RID: 95501 RVA: 0x005ED6FA File Offset: 0x005EB8FA
	public int[] GetDifficultyAllAreaFirstFloor(int difficulty, bool useHandle = false)
	{
		return TowerClimbConfig.Instance.GetDifficultyAllAreaFirstFloor(useHandle ? this.SeasonHandle : this.CurrentSeason, difficulty);
	}

	// Token: 0x0601750E RID: 95502 RVA: 0x005ED718 File Offset: 0x005EB918
	public int[] GetDifficultyAreaAllFloor(int difficulty, int area)
	{
		return TowerClimbConfig.Instance.GetDifficultyAreaAllFloor(this.CurrentSeason, difficulty, area);
	}

	// Token: 0x0601750F RID: 95503 RVA: 0x005ED72C File Offset: 0x005EB92C
	public int[] GetDifficultyAllFloor(int difficulty)
	{
		return TowerClimbConfig.Instance.GetDifficultyAllFloor(this.CurrentSeason, difficulty);
	}

	// Token: 0x06017510 RID: 95504 RVA: 0x005ED740 File Offset: 0x005EB940
	public bool GetFloorIsUnlock(int towerId)
	{
		if (this.GetHaveChallengeFloor(towerId))
		{
			return true;
		}
		int lastFloorInArea = TowerClimbConfig.Instance.GetLastFloorInArea(towerId);
		return lastFloorInArea == 0 || this.GetHaveChallengeFloor(lastFloorInArea);
	}

	// Token: 0x06017511 RID: 95505 RVA: 0x005ED770 File Offset: 0x005EB970
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

	// Token: 0x06017512 RID: 95506 RVA: 0x005ED7B0 File Offset: 0x005EB9B0
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

	// Token: 0x06017513 RID: 95507 RVA: 0x005ED806 File Offset: 0x005EBA06
	public void OpenTowerFormationView(int towerId)
	{
		this.CurrentSelectFloor = towerId;
		UiManager.Instance.OpenView(EUiViewName.TowerChallengeFormationView, towerId, null);
	}

	// Token: 0x06017514 RID: 95508 RVA: 0x005ED825 File Offset: 0x005EBA25
	public bool IsOpenFloorFormation()
	{
		return this.CurrentSelectFloor != -1;
	}

	// Token: 0x06017515 RID: 95509 RVA: 0x005ED833 File Offset: 0x005EBA33
	public string GetCurrentFloorName()
	{
		return this.GetFloorNameById(this.CurrentTowerId);
	}

	// Token: 0x06017516 RID: 95510 RVA: 0x005ED844 File Offset: 0x005EBA44
	public string GetFloorNameById(int towerId)
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("TowerAreaFloor"), null);
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(towerId).Value;
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(value.AreaName, null);
		return localTextNew.Replace("{0}", localTextNew2).Replace("{1}", value.Floor.ToString() ?? "");
	}

	// Token: 0x06017517 RID: 95511 RVA: 0x005ED8B8 File Offset: 0x005EBAB8
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

	// Token: 0x06017518 RID: 95512 RVA: 0x005ED913 File Offset: 0x005EBB13
	public void SaveNeedOpenConfirmView()
	{
		this.NeedOpenConfirmViewTowerId = this.CurrentTowerId;
		this.NeedOpenConfirmView = true;
	}

	// Token: 0x06017519 RID: 95513 RVA: 0x005ED928 File Offset: 0x005EBB28
	public void ClearNotConfirmedData()
	{
		this.NeedOpenConfirmViewTowerId = -1;
		this.NeedOpenConfirmView = false;
		this.CurrentNotConfirmedFloor = null;
	}

	// Token: 0x0601751A RID: 95514 RVA: 0x005ED93F File Offset: 0x005EBB3F
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

	// Token: 0x0601751B RID: 95515 RVA: 0x005ED979 File Offset: 0x005EBB79
	public void SaveHandleData()
	{
		this.TowerInfoMapHandle = new Dictionary<int, TowerFloorInfo>(this.TowerInfoMap);
		this.TowerDifficultiesMaxStarMapHandle = new Dictionary<int, int>(this.TowerDifficultiesMaxStarMap);
		this.SeasonHandle = this.DataSeason;
	}

	// Token: 0x0601751C RID: 95516 RVA: 0x005ED9A9 File Offset: 0x005EBBA9
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

	// Token: 0x0601751D RID: 95517 RVA: 0x005ED9E2 File Offset: 0x005EBBE2
	public bool CheckInTower()
	{
		return this.CurrentTowerId != -1;
	}

	// Token: 0x0601751E RID: 95518 RVA: 0x005ED9F0 File Offset: 0x005EBBF0
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

	// Token: 0x0601751F RID: 95519 RVA: 0x005EDA8C File Offset: 0x005EBC8C
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

	// Token: 0x06017520 RID: 95520 RVA: 0x005EDB00 File Offset: 0x005EBD00
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

	// Token: 0x06017521 RID: 95521 RVA: 0x005EDB68 File Offset: 0x005EBD68
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

	// Token: 0x06017522 RID: 95522 RVA: 0x005EDBE0 File Offset: 0x005EBDE0
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

	// Token: 0x06017523 RID: 95523 RVA: 0x005EDC50 File Offset: 0x005EBE50
	public bool IsRoleCostEnough(int roleId)
	{
		TowerConfig? towerConfig;
		return this.GetFloorIncludeRole(roleId, this.CurrentSelectFloor) || this.GetRoleRemainCost(roleId, this.CurrentSelectDifficulties) >= ((TowerClimbConfig.Instance.GetTowerInfo(this.CurrentSelectFloor) != null) ? new int?(towerConfig.GetValueOrDefault().Cost) : null).GetValueOrDefault();
	}

	// Token: 0x06017524 RID: 95524 RVA: 0x005EDCC4 File Offset: 0x005EBEC4
	public bool GetIsInOnceTower()
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(this.CurrentTowerId).Value;
		return value.Difficulty == 1 || value.Difficulty == 2;
	}

	// Token: 0x06017525 RID: 95525 RVA: 0x005EDD04 File Offset: 0x005EBF04
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

	// Token: 0x06017526 RID: 95526 RVA: 0x005EDD5C File Offset: 0x005EBF5C
	public bool GetOverLockHasShow()
	{
		bool? flag = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TowerOverLockArea) as ServerStorageBoolean).Get();
		if (!flag.GetValueOrDefault())
		{
			flag = new bool?(LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.TowerOverLockArea, false));
		}
		return flag.GetValueOrDefault();
	}

	// Token: 0x06017527 RID: 95527 RVA: 0x005EDD9E File Offset: 0x005EBF9E
	public void SetOverLockHasShow()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TowerOverLockArea) as ServerStorageBoolean).Set(new bool?(true));
	}

	// Token: 0x06017528 RID: 95528 RVA: 0x005EDDBC File Offset: 0x005EBFBC
	public int GetLoopTowerIsClickSeason()
	{
		ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.LoopTowerIsClickSeason, EClientStorageSystemIdType.LoopTowerIsClickSeason);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.LoopTowerIsClickSeason) as ServerStorageNumber).Get().GetValueOrDefault(-1);
	}

	// Token: 0x06017529 RID: 95529 RVA: 0x005EDDF0 File Offset: 0x005EBFF0
	public void SetLoopTowerIsClickSeason(int season)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.LoopTowerIsClickSeason) as ServerStorageNumber).Set(new int?(season));
		EventSystem.Instance.Emit(EEventName.RedDotAdventurePeriodicityTabUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, 100300002);
	}

	// Token: 0x0601752A RID: 95530 RVA: 0x005EDE40 File Offset: 0x005EC040
	public bool GetLoopTowerIsClickShop()
	{
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.LoopTowerIsClickShop, EClientStorageSystemIdType.LoopTowerIsClickShop);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.LoopTowerIsClickShop) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x0601752B RID: 95531 RVA: 0x005EDE73 File Offset: 0x005EC073
	public void SetLoopTowerIsClickShop(bool click)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.LoopTowerIsClickShop) as ServerStorageBoolean).Set(new bool?(click));
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, 100300002);
	}

	// Token: 0x0601752C RID: 95532 RVA: 0x005EDEA8 File Offset: 0x005EC0A8
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

	// Token: 0x0601752D RID: 95533 RVA: 0x005EDF4C File Offset: 0x005EC14C
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

	// Token: 0x0601752E RID: 95534 RVA: 0x005EDF8C File Offset: 0x005EC18C
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

	// Token: 0x17001F68 RID: 8040
	// (get) Token: 0x0601752F RID: 95535 RVA: 0x005EDFB7 File Offset: 0x005EC1B7
	public static TowerModel Instance
	{
		get
		{
			return TowerModel._Instance;
		}
	}

	// Token: 0x06017530 RID: 95536 RVA: 0x005EDFBE File Offset: 0x005EC1BE
	public static TowerModel GetOrCreateInstance()
	{
		if (TowerModel._Instance == null)
		{
			TowerModel.CreateInstance();
		}
		return TowerModel._Instance;
	}

	// Token: 0x06017531 RID: 95537 RVA: 0x005EDFD2 File Offset: 0x005EC1D2
	public static bool CreateInstance()
	{
		if (TowerModel._Instance != null)
		{
			return true;
		}
		TowerModel._Instance = new TowerModel();
		return true;
	}

	// Token: 0x06017532 RID: 95538 RVA: 0x005EDFE8 File Offset: 0x005EC1E8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017533 RID: 95539 RVA: 0x005EDFEA File Offset: 0x005EC1EA
	public static void ResetStaticDefaultValue()
	{
		TowerModel._Instance = null;
	}

	// Token: 0x06017534 RID: 95540 RVA: 0x005EDFF2 File Offset: 0x005EC1F2
	static TowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerModel.CreateStaticDefaultValue), new Action(TowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AE88 RID: 44680
	public const int FLOOR_STAR = 3;

	// Token: 0x0400AE89 RID: 44681
	public const string FINISH_COLOR = "#FFD12F";

	// Token: 0x0400AE8A RID: 44682
	public const string NORMOL_COLOR = "#ECE5D8";

	// Token: 0x0400AE8B RID: 44683
	public const string LOCK_COLOR = "#ADADAD";

	// Token: 0x0400AE8C RID: 44684
	public const int TOWER_LOOP_ACTIVITY_ID = 100300002;

	// Token: 0x0400AE8D RID: 44685
	public long? TowerBeginTime;

	// Token: 0x0400AE8E RID: 44686
	public long? TowerEndTime;

	// Token: 0x0400AE8F RID: 44687
	public int CurrentSeason = -1;

	// Token: 0x0400AE90 RID: 44688
	public int DataSeason;

	// Token: 0x0400AE91 RID: 44689
	public int CurrentSelectDifficulties = -1;

	// Token: 0x0400AE92 RID: 44690
	public int CurrentTowerId = -1;

	// Token: 0x0400AE93 RID: 44691
	[Nullable(2)]
	public List<int> CurrentTowerFormation;

	// Token: 0x0400AE94 RID: 44692
	public bool NeedChangeFormation;

	// Token: 0x0400AE95 RID: 44693
	[Nullable(2)]
	public TowerFloorInfo CurrentNotConfirmedFloor;

	// Token: 0x0400AE96 RID: 44694
	public int NeedOpenConfirmViewTowerId = -1;

	// Token: 0x0400AE97 RID: 44695
	public bool NeedOpenConfirmView;

	// Token: 0x0400AE98 RID: 44696
	public int CurrentSelectFloor = -1;

	// Token: 0x0400AE99 RID: 44697
	public Dictionary<int, Dictionary<int, int>> RoleDifficultyFormationMap = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400AE9A RID: 44698
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TowerRecommendFormation[] RecommendFormation;

	// Token: 0x0400AE9B RID: 44699
	public bool CurrentTowerLock;

	// Token: 0x0400AE9C RID: 44700
	public int DefaultFloor = -1;

	// Token: 0x0400AE9D RID: 44701
	private int MaxRoleCost;

	// Token: 0x0400AE9E RID: 44702
	public int TowerGuideDelayTime;

	// Token: 0x0400AE9F RID: 44703
	public int TowerSettlementDelayTime;

	// Token: 0x0400AEA0 RID: 44704
	private readonly Dictionary<int, TowerFloorInfo> TowerInfoMap = new Dictionary<int, TowerFloorInfo>();

	// Token: 0x0400AEA1 RID: 44705
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, TowerFloorInfo> TowerInfoMapHandle;

	// Token: 0x0400AEA2 RID: 44706
	private int SeasonHandle = -1;

	// Token: 0x0400AEA3 RID: 44707
	private readonly Dictionary<int, List<TowerReward>> TowerDifficultiesRewardMap = new Dictionary<int, List<TowerReward>>();

	// Token: 0x0400AEA4 RID: 44708
	private readonly Dictionary<int, int> TowerDifficultiesMaxStarMap = new Dictionary<int, int>();

	// Token: 0x0400AEA5 RID: 44709
	[Nullable(2)]
	private Dictionary<int, int> TowerDifficultiesMaxStarMapHandle;

	// Token: 0x0400AEA6 RID: 44710
	public bool NeedOpenReviveView;

	// Token: 0x0400AEA7 RID: 44711
	public int MaxUnlockDifficulty;

	// Token: 0x0400AEA8 RID: 44712
	public int QuickPassId;

	// Token: 0x0400AEA9 RID: 44713
	public bool IsWaitTowerStart;

	// Token: 0x0400AEAA RID: 44714
	public bool IsWaitTowerSettlement;

	// Token: 0x0400AEAB RID: 44715
	[Nullable(2)]
	private static TowerModel _Instance;
}
