using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020023FA RID: 9210
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigData
{
	// Token: 0x060126B4 RID: 75444 RVA: 0x0048AA44 File Offset: 0x00488C44
	public void UpdateFetterMap(List<PhBaOneSuitPlan> fetterData)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhBaOneSuitPlan phBaOneSuitPlan in fetterData)
		{
			int suitId = phBaOneSuitPlan.SuitId;
			hashSet.Add(suitId);
			if (!this.FetterMap.ContainsKey(suitId))
			{
				this.FetterMap[suitId] = new PhantomManagerConfigFetterData(suitId);
			}
			this.UpdateFetterUsing(suitId, phBaOneSuitPlan.IsOpen);
			this.FetterMap[suitId].UpdateMainPropMap(phBaOneSuitPlan.OneCostList.ToList<PhBaOneCostPlan>());
		}
		foreach (KeyValuePair<int, PhantomManagerConfigFetterData> keyValuePair in this.FetterMap)
		{
			if (!hashSet.Contains(keyValuePair.Key))
			{
				this.UpdateFetterUsing(keyValuePair.Key, false);
				keyValuePair.Value.UpdateMainPropMap(new List<PhBaOneCostPlan>());
			}
		}
	}

	// Token: 0x060126B5 RID: 75445 RVA: 0x0048AB54 File Offset: 0x00488D54
	public void CacheShareFetterMap(List<PhBaOneSuitPlan> fetterData)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhBaOneSuitPlan phBaOneSuitPlan in fetterData)
		{
			int suitId = phBaOneSuitPlan.SuitId;
			hashSet.Add(suitId);
			if (!this.FetterMap.ContainsKey(suitId))
			{
				this.FetterMap[suitId] = new PhantomManagerConfigFetterData(suitId);
			}
			this.FetterMap[suitId].CacheSharePropMap(phBaOneSuitPlan.OneCostList.ToList<PhBaOneCostPlan>());
		}
		foreach (KeyValuePair<int, PhantomManagerConfigFetterData> keyValuePair in this.FetterMap)
		{
			if (!hashSet.Contains(keyValuePair.Key))
			{
				keyValuePair.Value.CacheSharePropMap(new List<PhBaOneCostPlan>());
			}
		}
	}

	// Token: 0x060126B6 RID: 75446 RVA: 0x0048AC4C File Offset: 0x00488E4C
	public void UpdateFetterUsing(int fetterId, bool isOpen)
	{
		this.IsUsingMap[fetterId] = isOpen;
	}

	// Token: 0x060126B7 RID: 75447 RVA: 0x0048AC5B File Offset: 0x00488E5B
	public bool CheckHasInited()
	{
		return this.FetterMap.Count > 0;
	}

	// Token: 0x060126B8 RID: 75448 RVA: 0x0048AC6C File Offset: 0x00488E6C
	public EPhantomManagerConfigState GetPropCurrentState(IPhantomManagerConfigNewSettingDetailInfo data)
	{
		PhantomManagerConfigFetterData phantomManagerConfigFetterData;
		if (!this.FetterMap.TryGetValue(data.FetterId, out phantomManagerConfigFetterData))
		{
			return EPhantomManagerConfigState.Default;
		}
		return phantomManagerConfigFetterData.GetPropCurrentState(data);
	}

	// Token: 0x060126B9 RID: 75449 RVA: 0x0048AC98 File Offset: 0x00488E98
	public void SetPropCurrentState(IPhantomManagerConfigNewSettingDetailInfo data, EPhantomManagerConfigState state, bool isCache)
	{
		if (!this.FetterMap.ContainsKey(data.FetterId))
		{
			this.FetterMap[data.FetterId] = new PhantomManagerConfigFetterData(data.FetterId);
		}
		this.FetterMap[data.FetterId].SetPropState(data, state, isCache);
	}

	// Token: 0x060126BA RID: 75450 RVA: 0x0048ACF0 File Offset: 0x00488EF0
	public void DoCacheDataUpdate(bool apply)
	{
		foreach (KeyValuePair<int, PhantomManagerConfigFetterData> keyValuePair in this.FetterMap)
		{
			keyValuePair.Value.DoCacheDataUpdate(apply);
		}
	}

	// Token: 0x060126BB RID: 75451 RVA: 0x0048AD4C File Offset: 0x00488F4C
	[NullableContext(2)]
	public PhBaOneAllSuitPlan GetCacheStateProto()
	{
		PhBaOneAllSuitPlan phBaOneAllSuitPlan = PhBaOneAllSuitPlan.Create();
		bool flag = false;
		foreach (KeyValuePair<int, PhantomManagerConfigFetterData> keyValuePair in this.FetterMap)
		{
			ValueTuple<bool, PhBaOneSuitPlan> cacheProtoData = keyValuePair.Value.GetCacheProtoData();
			bool item = cacheProtoData.Item1;
			PhBaOneSuitPlan item2 = cacheProtoData.Item2;
			flag = (flag || item);
			if (item2.OneCostList.Count != 0)
			{
				phBaOneAllSuitPlan.SuitPlanList.Add(item2);
			}
		}
		if (!flag)
		{
			return null;
		}
		return phBaOneAllSuitPlan;
	}

	// Token: 0x060126BC RID: 75452 RVA: 0x0048ADE4 File Offset: 0x00488FE4
	public void ResetFetterConfig(int fetterId)
	{
		PhantomManagerConfigFetterData phantomManagerConfigFetterData;
		if (this.FetterMap.TryGetValue(fetterId, out phantomManagerConfigFetterData))
		{
			phantomManagerConfigFetterData.ResetFetterConfig();
		}
	}

	// Token: 0x060126BD RID: 75453 RVA: 0x0048AE07 File Offset: 0x00489007
	public bool CheckEditFetterConfigRecommendDirty(int fetterId)
	{
		if (!this.FetterMap.ContainsKey(fetterId))
		{
			this.FetterMap[fetterId] = new PhantomManagerConfigFetterData(fetterId);
		}
		return this.FetterMap[fetterId].GetEditFetterConfigRecommendDirty();
	}

	// Token: 0x060126BE RID: 75454 RVA: 0x0048AE3A File Offset: 0x0048903A
	public bool SetFetterConfigRecommend(int fetterId)
	{
		if (!this.FetterMap.ContainsKey(fetterId))
		{
			this.FetterMap[fetterId] = new PhantomManagerConfigFetterData(fetterId);
		}
		return this.FetterMap[fetterId].SetFetterConfigRecommend();
	}

	// Token: 0x060126BF RID: 75455 RVA: 0x0048AE70 File Offset: 0x00489070
	public bool GetFetterConfigIsOpen(int fetterId)
	{
		bool flag;
		return this.IsUsingMap.TryGetValue(fetterId, out flag) && flag;
	}

	// Token: 0x060126C0 RID: 75456 RVA: 0x0048AE90 File Offset: 0x00489090
	[NullableContext(0)]
	public UniTask<bool> ResetAllFetterOpen(bool needResetConfig)
	{
		PhantomManagerConfigData.<ResetAllFetterOpen>d__22 <ResetAllFetterOpen>d__;
		<ResetAllFetterOpen>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ResetAllFetterOpen>d__.<>4__this = this;
		<ResetAllFetterOpen>d__.needResetConfig = needResetConfig;
		<ResetAllFetterOpen>d__.<>1__state = -1;
		<ResetAllFetterOpen>d__.<>t__builder.Start<PhantomManagerConfigData.<ResetAllFetterOpen>d__22>(ref <ResetAllFetterOpen>d__);
		return <ResetAllFetterOpen>d__.<>t__builder.Task;
	}

	// Token: 0x060126C1 RID: 75457 RVA: 0x0048AEDC File Offset: 0x004890DC
	public bool CheckDirty()
	{
		bool flag = false;
		foreach (KeyValuePair<int, PhantomManagerConfigFetterData> keyValuePair in this.FetterMap)
		{
			flag |= keyValuePair.Value.GetCacheProtoData().Item1;
		}
		return flag;
	}

	// Token: 0x060126C2 RID: 75458 RVA: 0x0048AF40 File Offset: 0x00489140
	public IPhantomManagerApplySettingDetailInfo GetPhantomPlanMatchApplyData()
	{
		PhantomManagerApplySettingDetailInfo phantomManagerApplySettingDetailInfo = new PhantomManagerApplySettingDetailInfo();
		foreach (PhantomItemData phantomItemData in InventoryModel.Instance.GetPhantomItemDataList())
		{
			int uniqueId = phantomItemData.GetUniqueId();
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			bool flag = this.DownFiveStarSwitch && phantomBattleData.GetQuality() < 5;
			int id = phantomItemData.GetFetterGroupConfig().Value.Id;
			bool flag2;
			if (phantomBattleData.GetVisionNoCultivated() && !flag && this.IsUsingMap.TryGetValue(id, out flag2) && flag2)
			{
				int id2 = phantomBattleData.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false)[0].Id;
				PhantomManagerConfigNewSettingDetailInfo data = new PhantomManagerConfigNewSettingDetailInfo
				{
					FetterId = id,
					Cost = phantomBattleData.GetCost(),
					MainPropId = id2,
					IsEdit = true
				};
				EPhantomManagerConfigState propCurrentState = this.GetPropCurrentState(data);
				if (propCurrentState == EPhantomManagerConfigState.Discard && !phantomItemData.GetIsDeprecated())
				{
					phantomManagerApplySettingDetailInfo.DiscardList.Add(phantomItemData);
				}
				else if (propCurrentState == EPhantomManagerConfigState.Lock && !phantomItemData.GetIsLock())
				{
					phantomManagerApplySettingDetailInfo.LockList.Add(phantomItemData);
				}
			}
		}
		return phantomManagerApplySettingDetailInfo;
	}

	// Token: 0x060126C3 RID: 75459 RVA: 0x0048B098 File Offset: 0x00489298
	[NullableContext(0)]
	public UniTask<bool> DoApplyOpera([Nullable(1)] IPhantomManagerApplySettingDetailInfo applyData)
	{
		PhantomManagerConfigData.<DoApplyOpera>d__25 <DoApplyOpera>d__;
		<DoApplyOpera>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<DoApplyOpera>d__.applyData = applyData;
		<DoApplyOpera>d__.<>1__state = -1;
		<DoApplyOpera>d__.<>t__builder.Start<PhantomManagerConfigData.<DoApplyOpera>d__25>(ref <DoApplyOpera>d__);
		return <DoApplyOpera>d__.<>t__builder.Task;
	}

	// Token: 0x060126C4 RID: 75460 RVA: 0x0048B0DC File Offset: 0x004892DC
	public List<PhantomItemData> GetPhantomSmartDiscardUserPlan()
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItemData phantomItemData in InventoryModel.Instance.GetPhantomItemDataList())
		{
			if (!phantomItemData.GetIsLock())
			{
				int uniqueId = phantomItemData.GetUniqueId();
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
				int id = phantomItemData.GetFetterGroupConfig().Value.Id;
				bool flag;
				if (this.IsUsingMap.TryGetValue(id, out flag) && flag && this.IsPhantomSmartPlanDataValid(phantomBattleData))
				{
					int id2 = phantomBattleData.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false)[0].Id;
					PhantomManagerConfigNewSettingDetailInfo data = new PhantomManagerConfigNewSettingDetailInfo
					{
						FetterId = id,
						Cost = phantomBattleData.GetCost(),
						MainPropId = id2,
						IsEdit = true
					};
					if (this.GetPropCurrentState(data) == EPhantomManagerConfigState.Discard && !phantomItemData.GetIsDeprecated())
					{
						list.Add(phantomItemData);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060126C5 RID: 75461 RVA: 0x0048B1EC File Offset: 0x004893EC
	public List<PhantomItemData> GetPhantomSmartDiscardRecommendPlan()
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		if (this.RecommendAllDiscardMap.Count == 0)
		{
			foreach (PhantomManagePlanV2 phantomManagePlanV in PhantomBattleConfig.Instance.GetPhantomManagerPlanAll())
			{
				if (phantomManagePlanV.DiscardGroupLength != 0)
				{
					if (!this.RecommendAllDiscardMap.ContainsKey(phantomManagePlanV.FetterId))
					{
						this.RecommendAllDiscardMap[phantomManagePlanV.FetterId] = new Dictionary<int, HashSet<int>>();
					}
					this.RecommendAllDiscardMap[phantomManagePlanV.FetterId][phantomManagePlanV.Cost] = new HashSet<int>(phantomManagePlanV.GetDiscardGroupBytes().ToArray());
				}
			}
		}
		foreach (PhantomItemData phantomItemData in InventoryModel.Instance.GetPhantomItemDataList())
		{
			if (!phantomItemData.GetIsLock())
			{
				int uniqueId = phantomItemData.GetUniqueId();
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
				int id = phantomItemData.GetFetterGroupConfig().Value.Id;
				if (this.IsPhantomSmartPlanDataValid(phantomBattleData))
				{
					int cost = phantomBattleData.GetCost();
					Dictionary<int, HashSet<int>> dictionary;
					HashSet<int> hashSet;
					if (this.RecommendAllDiscardMap.TryGetValue(id, out dictionary) && dictionary.TryGetValue(cost, out hashSet))
					{
						int id2 = phantomBattleData.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false)[0].Id;
						if (hashSet.Contains(id2))
						{
							list.Add(phantomItemData);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060126C6 RID: 75462 RVA: 0x0048B394 File Offset: 0x00489594
	public void DoLogReport(List<int> fetterList, bool isRecommendAll = false)
	{
		foreach (int num in fetterList)
		{
			PhantomDiscardLockPlanReport phantomDiscardLockPlanReport = new PhantomDiscardLockPlanReport();
			PhantomManagerConfigFetterData phantomManagerConfigFetterData;
			this.FetterMap.TryGetValue(num, out phantomManagerConfigFetterData);
			phantomDiscardLockPlanReport.i_suit_id = num;
			phantomDiscardLockPlanReport.i_success = ((this.GetFetterConfigIsOpen(num) > false) ? 1 : 0);
			phantomDiscardLockPlanReport.i_type = ((phantomManagerConfigFetterData != null && !phantomManagerConfigFetterData.GetEditFetterConfigRecommendDirty()) ? 1 : 0);
			phantomDiscardLockPlanReport.i_if_finish = ((isRecommendAll > false) ? 1 : 0);
			if (phantomManagerConfigFetterData != null)
			{
				phantomDiscardLockPlanReport.o_setting_plan = phantomManagerConfigFetterData.GetLogReport();
			}
			LogReportController.Instance.LogReport(phantomDiscardLockPlanReport);
		}
	}

	// Token: 0x060126C7 RID: 75463 RVA: 0x0048B440 File Offset: 0x00489640
	private bool IsPhantomSmartPlanDataValid(PhantomBattleData phantomBattleData)
	{
		return phantomBattleData.GetVisionNoCultivated() && !phantomBattleData.GetIsDeprecated() && !PhantomBattleController.Instance.CheckIsEquip(phantomBattleData.GetUniqueId());
	}

	// Token: 0x04008B4B RID: 35659
	protected readonly Dictionary<int, PhantomManagerConfigFetterData> FetterMap = new Dictionary<int, PhantomManagerConfigFetterData>();

	// Token: 0x04008B4C RID: 35660
	public Dictionary<int, bool> IsUsingMap = new Dictionary<int, bool>();

	// Token: 0x04008B4D RID: 35661
	public string SelfPhantomConfigCode = string.Empty;

	// Token: 0x04008B4E RID: 35662
	public bool PhantomSelfConfigNeedUpdate;

	// Token: 0x04008B4F RID: 35663
	public bool DownFiveStarSwitch;

	// Token: 0x04008B50 RID: 35664
	public HashSet<EConfirmBoxConfigId> ConfirmBoxLoginSet = new HashSet<EConfirmBoxConfigId>();

	// Token: 0x04008B51 RID: 35665
	public EPhantomManagerEditCloseState ConfigViewEditCloseSelect;

	// Token: 0x04008B52 RID: 35666
	public EPhantomManagerEditCloseState ConfigViewShareUpdateSelect;

	// Token: 0x04008B53 RID: 35667
	public long LastSharedCheckTime;

	// Token: 0x04008B54 RID: 35668
	protected readonly Dictionary<int, Dictionary<int, HashSet<int>>> RecommendAllDiscardMap = new Dictionary<int, Dictionary<int, HashSet<int>>>();
}
