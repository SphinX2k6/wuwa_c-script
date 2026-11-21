using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020018DF RID: 6367
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigData
{
	// Token: 0x0600FB66 RID: 64358 RVA: 0x00497F4C File Offset: 0x0049614C
	public void UpdateFetterMap(IEnumerable<PhBaOneSuitPlan> fetterData)
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
			this.FetterMap[suitId].UpdateMainPropMap(phBaOneSuitPlan.OneCostList);
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

	// Token: 0x0600FB67 RID: 64359 RVA: 0x00498054 File Offset: 0x00496254
	public void CacheShareFetterMap(IEnumerable<PhBaOneSuitPlan> fetterData)
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
			this.FetterMap[suitId].CacheSharePropMap(phBaOneSuitPlan.OneCostList);
		}
		foreach (KeyValuePair<int, PhantomManagerConfigFetterData> keyValuePair in this.FetterMap)
		{
			if (!hashSet.Contains(keyValuePair.Key))
			{
				keyValuePair.Value.CacheSharePropMap(new List<PhBaOneCostPlan>());
			}
		}
	}

	// Token: 0x0600FB68 RID: 64360 RVA: 0x00498140 File Offset: 0x00496340
	public void UpdateFetterUsing(int fetterId, bool isOpen)
	{
		this.IsUsingMap[fetterId] = isOpen;
	}

	// Token: 0x0600FB69 RID: 64361 RVA: 0x0049814F File Offset: 0x0049634F
	public bool CheckHasInited()
	{
		return this.FetterMap.Count > 0;
	}

	// Token: 0x0600FB6A RID: 64362 RVA: 0x00498160 File Offset: 0x00496360
	public EPhantomManagerConfigState GetPropCurrentState(IPhantomManagerConfigNewSettingDetailInfo data)
	{
		PhantomManagerConfigFetterData phantomManagerConfigFetterData;
		if (!this.FetterMap.TryGetValue(data.FetterId, out phantomManagerConfigFetterData))
		{
			return EPhantomManagerConfigState.Default;
		}
		return phantomManagerConfigFetterData.GetPropCurrentState(data);
	}

	// Token: 0x0600FB6B RID: 64363 RVA: 0x0049818C File Offset: 0x0049638C
	public void SetPropCurrentState(IPhantomManagerConfigNewSettingDetailInfo data, EPhantomManagerConfigState state, bool isCache)
	{
		if (!this.FetterMap.ContainsKey(data.FetterId))
		{
			this.FetterMap[data.FetterId] = new PhantomManagerConfigFetterData(data.FetterId);
		}
		this.FetterMap[data.FetterId].SetPropState(data, state, isCache);
	}

	// Token: 0x0600FB6C RID: 64364 RVA: 0x004981E4 File Offset: 0x004963E4
	public void DoCacheDataUpdate(bool apply)
	{
		foreach (KeyValuePair<int, PhantomManagerConfigFetterData> keyValuePair in this.FetterMap)
		{
			keyValuePair.Value.DoCacheDataUpdate(apply);
		}
	}

	// Token: 0x0600FB6D RID: 64365 RVA: 0x00498240 File Offset: 0x00496440
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

	// Token: 0x0600FB6E RID: 64366 RVA: 0x004982D8 File Offset: 0x004964D8
	public void ResetFetterConfig(int fetterId)
	{
		PhantomManagerConfigFetterData phantomManagerConfigFetterData;
		if (this.FetterMap.TryGetValue(fetterId, out phantomManagerConfigFetterData))
		{
			phantomManagerConfigFetterData.ResetFetterConfig();
		}
	}

	// Token: 0x0600FB6F RID: 64367 RVA: 0x004982FB File Offset: 0x004964FB
	public bool CheckEditFetterConfigRecommendDirty(int fetterId)
	{
		if (!this.FetterMap.ContainsKey(fetterId))
		{
			this.FetterMap[fetterId] = new PhantomManagerConfigFetterData(fetterId);
		}
		return this.FetterMap[fetterId].GetEditFetterConfigRecommendDirty();
	}

	// Token: 0x0600FB70 RID: 64368 RVA: 0x0049832E File Offset: 0x0049652E
	public bool SetFetterConfigRecommend(int fetterId)
	{
		if (!this.FetterMap.ContainsKey(fetterId))
		{
			this.FetterMap[fetterId] = new PhantomManagerConfigFetterData(fetterId);
		}
		return this.FetterMap[fetterId].SetFetterConfigRecommend();
	}

	// Token: 0x0600FB71 RID: 64369 RVA: 0x00498364 File Offset: 0x00496564
	public bool GetFetterConfigIsOpen(int fetterId)
	{
		bool flag;
		return this.IsUsingMap.TryGetValue(fetterId, out flag) && flag;
	}

	// Token: 0x0600FB72 RID: 64370 RVA: 0x00498384 File Offset: 0x00496584
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

	// Token: 0x0600FB73 RID: 64371 RVA: 0x004983D0 File Offset: 0x004965D0
	public bool CheckDirty()
	{
		bool flag = false;
		foreach (KeyValuePair<int, PhantomManagerConfigFetterData> keyValuePair in this.FetterMap)
		{
			flag |= keyValuePair.Value.GetCacheProtoData().Item1;
		}
		return flag;
	}

	// Token: 0x0600FB74 RID: 64372 RVA: 0x00498434 File Offset: 0x00496634
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

	// Token: 0x0600FB75 RID: 64373 RVA: 0x0049858C File Offset: 0x0049678C
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

	// Token: 0x0600FB76 RID: 64374 RVA: 0x004985D0 File Offset: 0x004967D0
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

	// Token: 0x0600FB77 RID: 64375 RVA: 0x004986E0 File Offset: 0x004968E0
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

	// Token: 0x0600FB78 RID: 64376 RVA: 0x00498888 File Offset: 0x00496A88
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

	// Token: 0x0600FB79 RID: 64377 RVA: 0x00498934 File Offset: 0x00496B34
	private bool IsPhantomSmartPlanDataValid(PhantomBattleData phantomBattleData)
	{
		return phantomBattleData.GetVisionNoCultivated() && !phantomBattleData.GetIsDeprecated() && !PhantomBattleController.Instance.CheckIsEquip(phantomBattleData.GetUniqueId());
	}

	// Token: 0x04008C92 RID: 35986
	protected readonly Dictionary<int, PhantomManagerConfigFetterData> FetterMap = new Dictionary<int, PhantomManagerConfigFetterData>();

	// Token: 0x04008C93 RID: 35987
	public Dictionary<int, bool> IsUsingMap = new Dictionary<int, bool>();

	// Token: 0x04008C94 RID: 35988
	public string SelfPhantomConfigCode = string.Empty;

	// Token: 0x04008C95 RID: 35989
	public bool PhantomSelfConfigNeedUpdate;

	// Token: 0x04008C96 RID: 35990
	public bool DownFiveStarSwitch;

	// Token: 0x04008C97 RID: 35991
	public HashSet<EConfirmBoxConfigId> ConfirmBoxLoginSet = new HashSet<EConfirmBoxConfigId>();

	// Token: 0x04008C98 RID: 35992
	public EPhantomManagerEditCloseState ConfigViewEditCloseSelect;

	// Token: 0x04008C99 RID: 35993
	public EPhantomManagerEditCloseState ConfigViewShareUpdateSelect;

	// Token: 0x04008C9A RID: 35994
	public long LastSharedCheckTime;

	// Token: 0x04008C9B RID: 35995
	protected readonly Dictionary<int, Dictionary<int, HashSet<int>>> RecommendAllDiscardMap = new Dictionary<int, Dictionary<int, HashSet<int>>>();
}
