using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E69 RID: 7785
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryActivityData : ActivityBaseData
{
	// Token: 0x0600ECAF RID: 60591 RVA: 0x00385DAC File Offset: 0x00383FAC
	protected override void OnInit(ActivityData data)
	{
		HonamiStoryActivityInfo honamiStoryActivityInfo = data.HonamiStoryActivityInfo;
		if (honamiStoryActivityInfo == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "HonamiStoryActivityData初始化 无效activityInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		HonamiStoryModel.Instance.InitActivityInfo(base.Id, honamiStoryActivityInfo);
		this.InitHonamiStoryAreaData();
		this.InitHonamiStoryMascotData();
		this.InitHonamiStoryPermanentTaskData();
		this.InitHonamiStoryLimitTaskData();
		this.InitHonamiStoryScoreRewardData();
		this.InitItemCollectionData();
		this.InitSubQuestTaskDataList(honamiStoryActivityInfo.AreaTask.ToList<ConditionTask>());
		this.UpdateHonamiStoryAreaDataList(honamiStoryActivityInfo.HonamiStoryAreaInfos.ToList<HonamiStoryAreaInfo>());
		this.UpdateHonamiStoryMascotDataList(honamiStoryActivityInfo.HonamiStoryMascotInfos.ToList<HonamiStoryMascotInfo>());
		this.UpdatePermanentTaskDataList(honamiStoryActivityInfo.HonamiStoryResidentTask.ToList<ConditionTask>());
		this.UpdateLimitTaskDataList(honamiStoryActivityInfo.HonamiStoryLimitTask.ToList<ConditionTask>());
		this.UpdateScoreRewardDataList(honamiStoryActivityInfo.HonamiStoryScoreRewardInfos.ToList<HonamiStoryScoreRewardInfo>());
		this.UpdateItemCollectionDataList(honamiStoryActivityInfo.HonamiStoryItemCollectionInfos.ToList<HonamiStoryItemCollectionInfo>());
		this.RefreshTowerData(honamiStoryActivityInfo.HonamiStoryTopInfos.ToList<HonamiStoryTopInfo>());
		this.InitLevelSelectPanelData();
	}

	// Token: 0x0600ECB0 RID: 60592 RVA: 0x00385EA8 File Offset: 0x003840A8
	protected override void PhraseEx(ActivityData data)
	{
		HonamiStoryActivityInfo honamiStoryActivityInfo = data.HonamiStoryActivityInfo;
		if (honamiStoryActivityInfo == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "HonamiStoryActivityDataPhrase 无效activityInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		HonamiStoryModel.Instance.UpdateActivityInfo(base.Id, honamiStoryActivityInfo);
		this.UpdateHonamiStoryAreaDataList(honamiStoryActivityInfo.HonamiStoryAreaInfos.ToList<HonamiStoryAreaInfo>());
		this.UpdateHonamiStoryMascotDataList(honamiStoryActivityInfo.HonamiStoryMascotInfos.ToList<HonamiStoryMascotInfo>());
		this.UpdatePermanentTaskDataList(honamiStoryActivityInfo.HonamiStoryResidentTask.ToList<ConditionTask>());
		this.UpdateLimitTaskDataList(honamiStoryActivityInfo.HonamiStoryLimitTask.ToList<ConditionTask>());
		this.UpdateScoreRewardDataList(honamiStoryActivityInfo.HonamiStoryScoreRewardInfos.ToList<HonamiStoryScoreRewardInfo>());
		this.UpdateItemCollectionDataList(honamiStoryActivityInfo.HonamiStoryItemCollectionInfos.ToList<HonamiStoryItemCollectionInfo>());
		this.UpdateSubQuestTaskDataList(honamiStoryActivityInfo.AreaTask.ToList<ConditionTask>());
		this.RefreshTowerData(honamiStoryActivityInfo.HonamiStoryTopInfos.ToList<HonamiStoryTopInfo>());
		HonamiStoryModel.Instance.SetTotalRevenueInternal(honamiStoryActivityInfo.TotalRevenue);
	}

	// Token: 0x0600ECB1 RID: 60593 RVA: 0x00385F88 File Offset: 0x00384188
	protected override bool GetExDataFinishShowState()
	{
		using (Dictionary<int, HonamiStoryPermanentTaskData>.ValueCollection.Enumerator enumerator = this.PermanentTaskDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status != EActivityTaskState.FinishedAndClaimed)
				{
					return false;
				}
			}
		}
		using (List<HonamiStoryMascotData>.Enumerator enumerator2 = this.MascotDataList.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (enumerator2.Current.State != EHonamiStoryCollectState.GotReward)
				{
					return false;
				}
			}
		}
		using (List<HonamiStoryAreaData>.Enumerator enumerator3 = this.GetHonamiStoryMascotAreaDataList().GetEnumerator())
		{
			while (enumerator3.MoveNext())
			{
				if (enumerator3.Current.CollectMascotState != EHonamiStoryCollectState.GotReward)
				{
					return false;
				}
			}
		}
		using (Dictionary<int, HonamiStoryItemCollectionData>.ValueCollection.Enumerator enumerator4 = this.ItemCollectionDataMap.Values.GetEnumerator())
		{
			while (enumerator4.MoveNext())
			{
				if (enumerator4.Current.State != EHonamiStoryCollectState.GotReward)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600ECB2 RID: 60594 RVA: 0x003860C8 File Offset: 0x003842C8
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckAllFunctionRedDot();
	}

	// Token: 0x0600ECB3 RID: 60595 RVA: 0x003860D0 File Offset: 0x003842D0
	public bool CheckAllFunctionRedDot()
	{
		if (!base.IsUnLock())
		{
			return false;
		}
		bool flag = this.IsLimitTaskHasRedDot() || this.IsPermanentTaskHasRedDot();
		if (flag)
		{
			return flag;
		}
		FunctionModel instance = FunctionModel.Instance;
		if (instance != null && instance.IsOpen(10116))
		{
			flag = (this.CanMascotCollectGetReward() || this.CanAreaCollectGetReward());
			if (flag)
			{
				return flag;
			}
		}
		FunctionModel instance2 = FunctionModel.Instance;
		if (instance2 != null && instance2.IsOpen(10123))
		{
			flag = (LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, new HashSet<int>()).Count > 0);
			if (flag)
			{
				return flag;
			}
		}
		if (FunctionModel.Instance.IsOpen(10118))
		{
			flag = this.IsItemCollectionHasRedDot();
			if (flag)
			{
				return flag;
			}
		}
		return false;
	}

	// Token: 0x0600ECB4 RID: 60596 RVA: 0x00386180 File Offset: 0x00384380
	private void InitHonamiStoryAreaData()
	{
		foreach (HonamiStoryArea honamiStoryArea in HonamiStoryConfig.Instance.GetHonamiStoryAreaConfigList(base.Id))
		{
			HonamiStoryAreaData honamiStoryAreaData = new HonamiStoryAreaData(honamiStoryArea.Id);
			this.AreaDataMap[honamiStoryArea.Id] = honamiStoryAreaData;
			this.AreaDataList.Add(honamiStoryAreaData);
		}
	}

	// Token: 0x0600ECB5 RID: 60597 RVA: 0x003861FC File Offset: 0x003843FC
	public void UpdateHonamiStoryAreaDataList(List<HonamiStoryAreaInfo> areaInfoList)
	{
		foreach (HonamiStoryAreaInfo areaInfo in areaInfoList)
		{
			this.UpdateHonamiStoryAreaData(areaInfo);
		}
	}

	// Token: 0x0600ECB6 RID: 60598 RVA: 0x0038624C File Offset: 0x0038444C
	public void UpdateHonamiStoryAreaData(HonamiStoryAreaInfo areaInfo)
	{
		HonamiStoryAreaData honamiStoryAreaData = this.GetHonamiStoryAreaData(areaInfo.HonamiStoryAreaId);
		if (honamiStoryAreaData == null)
		{
			return;
		}
		honamiStoryAreaData.UpdateData(areaInfo);
	}

	// Token: 0x0600ECB7 RID: 60599 RVA: 0x00386274 File Offset: 0x00384474
	[NullableContext(2)]
	public HonamiStoryAreaData GetHonamiStoryAreaData(int id)
	{
		HonamiStoryAreaData result;
		if (this.AreaDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HonamiStory;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "HonamiStoryAreaData 无效Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600ECB8 RID: 60600 RVA: 0x003862C4 File Offset: 0x003844C4
	public List<HonamiStoryAreaData> GetHonamiStoryAreaDataList()
	{
		if (this.AreaDataList.Count == 0)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "HonamiStoryAreaDataList为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return this.AreaDataList;
	}

	// Token: 0x0600ECB9 RID: 60601 RVA: 0x00386304 File Offset: 0x00384504
	public List<HonamiStoryAreaData> GetHonamiStoryMascotAreaDataList()
	{
		List<HonamiStoryAreaData> list = new List<HonamiStoryAreaData>();
		foreach (HonamiStoryAreaData honamiStoryAreaData in this.AreaDataList)
		{
			if (honamiStoryAreaData.Id != 1 && this.GetHonamiStoryMascotDataListByAreaId(honamiStoryAreaData.Id).Count != 0)
			{
				list.Add(honamiStoryAreaData);
			}
		}
		return list;
	}

	// Token: 0x0600ECBA RID: 60602 RVA: 0x0038637C File Offset: 0x0038457C
	public int GetCurrentProgressAreaDataId()
	{
		List<HonamiStoryAreaData> honamiStoryAreaDataList = this.GetHonamiStoryAreaDataList();
		if (honamiStoryAreaDataList.Count <= 0)
		{
			return 1;
		}
		foreach (HonamiStoryAreaData honamiStoryAreaData in honamiStoryAreaDataList)
		{
			if (honamiStoryAreaData.GetAreaState != EHonamiStoryAreaState.Finished)
			{
				return honamiStoryAreaData.Id;
			}
		}
		return honamiStoryAreaDataList[honamiStoryAreaDataList.Count - 1].Id;
	}

	// Token: 0x0600ECBB RID: 60603 RVA: 0x003863FC File Offset: 0x003845FC
	public bool IsAllAreaPass()
	{
		List<HonamiStoryAreaData> honamiStoryAreaDataList = this.GetHonamiStoryAreaDataList();
		int count = honamiStoryAreaDataList.Count;
		int num = 0;
		using (List<HonamiStoryAreaData>.Enumerator enumerator = honamiStoryAreaDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetAreaState != EHonamiStoryAreaState.Finished)
				{
					break;
				}
				num++;
			}
		}
		return count > 0 && num == count;
	}

	// Token: 0x0600ECBC RID: 60604 RVA: 0x00386468 File Offset: 0x00384668
	public bool CanAreaCollectGetReward()
	{
		foreach (HonamiStoryAreaData honamiStoryAreaData in this.AreaDataList)
		{
			if (honamiStoryAreaData.IsAreaUnlock && honamiStoryAreaData.IsSecretFinished)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600ECBD RID: 60605 RVA: 0x003864CC File Offset: 0x003846CC
	public void RefreshTowerData(List<HonamiStoryTopInfo> towerInfoList)
	{
		foreach (HonamiStoryTopInfo honamiStoryTopInfo in towerInfoList)
		{
			this.TowerDangerLv2MaxFloorMap[honamiStoryTopInfo.DangerLevel] = honamiStoryTopInfo.MaxFloor;
		}
	}

	// Token: 0x0600ECBE RID: 60606 RVA: 0x0038652C File Offset: 0x0038472C
	public int GetMaxFloorByDangerLv(int lv)
	{
		int result;
		if (this.TowerDangerLv2MaxFloorMap.TryGetValue(lv, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x0600ECBF RID: 60607 RVA: 0x0038654C File Offset: 0x0038474C
	private void InitHonamiStoryMascotData()
	{
		foreach (HonamiStoryMascot honamiStoryMascot in HonamiStoryConfig.Instance.GetHonamiStoryMascotConfigList(base.Id))
		{
			HonamiStoryMascotData honamiStoryMascotData = new HonamiStoryMascotData(honamiStoryMascot.Id);
			this.MascotDataMap[honamiStoryMascot.Id] = honamiStoryMascotData;
			this.MascotDataList.Add(honamiStoryMascotData);
		}
	}

	// Token: 0x0600ECC0 RID: 60608 RVA: 0x003865C8 File Offset: 0x003847C8
	public void UpdateHonamiStoryMascotDataList(List<HonamiStoryMascotInfo> mascotInfoList)
	{
		foreach (HonamiStoryMascotInfo mascotInfo in mascotInfoList)
		{
			this.UpdateHonamiStoryMascotData(mascotInfo);
		}
	}

	// Token: 0x0600ECC1 RID: 60609 RVA: 0x00386618 File Offset: 0x00384818
	public void UpdateHonamiStoryMascotData(HonamiStoryMascotInfo mascotInfo)
	{
		HonamiStoryMascotData honamiStoryMascotData = this.GetHonamiStoryMascotData(mascotInfo.HonamiStoryMascotId);
		if (honamiStoryMascotData == null)
		{
			return;
		}
		honamiStoryMascotData.UpdateState((EHonamiStoryCollectState)mascotInfo.Status);
	}

	// Token: 0x0600ECC2 RID: 60610 RVA: 0x00386644 File Offset: 0x00384844
	[NullableContext(2)]
	public HonamiStoryMascotData GetHonamiStoryMascotData(int id)
	{
		HonamiStoryMascotData result;
		if (this.MascotDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HonamiStory;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "HonamiStoryMascotData 无效Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600ECC3 RID: 60611 RVA: 0x00386694 File Offset: 0x00384894
	public List<HonamiStoryMascotData> GetHonamiStoryMascotDataListByAreaId(int areaId)
	{
		List<HonamiStoryMascotData> list = new List<HonamiStoryMascotData>();
		foreach (HonamiStoryMascotData honamiStoryMascotData in this.MascotDataList)
		{
			if (honamiStoryMascotData.AreaId == areaId)
			{
				list.Add(honamiStoryMascotData);
			}
		}
		return list;
	}

	// Token: 0x0600ECC4 RID: 60612 RVA: 0x003866F8 File Offset: 0x003848F8
	public bool CanMascotCollectGetReward()
	{
		using (List<HonamiStoryMascotData>.Enumerator enumerator = this.MascotDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.State == EHonamiStoryCollectState.Finished)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600ECC5 RID: 60613 RVA: 0x00386754 File Offset: 0x00384954
	public bool CheckMascotCollectFinished()
	{
		using (List<HonamiStoryMascotData>.Enumerator enumerator = this.MascotDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.State == EHonamiStoryCollectState.Unfinished)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600ECC6 RID: 60614 RVA: 0x003867B0 File Offset: 0x003849B0
	private void InitHonamiStoryPermanentTaskData()
	{
		foreach (HonamiStoryResidentTask honamiStoryResidentTask in HonamiStoryConfig.Instance.GetHonamiStoryPermanentTaskConfigList(base.Id))
		{
			HonamiStoryPermanentTaskData value = new HonamiStoryPermanentTaskData(honamiStoryResidentTask.Id);
			this.PermanentTaskDataMap[honamiStoryResidentTask.Id] = value;
		}
	}

	// Token: 0x0600ECC7 RID: 60615 RVA: 0x00386820 File Offset: 0x00384A20
	public void UpdatePermanentTaskDataList(List<ConditionTask> taskInfoList)
	{
		foreach (ConditionTask taskInfo in taskInfoList)
		{
			this.UpdatePermanentTaskData(taskInfo);
		}
	}

	// Token: 0x0600ECC8 RID: 60616 RVA: 0x00386870 File Offset: 0x00384A70
	public void UpdatePermanentTaskData(ConditionTask taskInfo)
	{
		HonamiStoryPermanentTaskData permanentTaskData = this.GetPermanentTaskData(taskInfo.Id);
		if (permanentTaskData == null)
		{
			return;
		}
		permanentTaskData.UpdateData(taskInfo);
	}

	// Token: 0x0600ECC9 RID: 60617 RVA: 0x00386898 File Offset: 0x00384A98
	[NullableContext(2)]
	public HonamiStoryPermanentTaskData GetPermanentTaskData(int id)
	{
		HonamiStoryPermanentTaskData result;
		if (this.PermanentTaskDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HonamiStory;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "HonamiStoryPermanentTaskData 无效Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600ECCA RID: 60618 RVA: 0x003868E8 File Offset: 0x00384AE8
	public List<HonamiStoryPermanentTaskData> GetPermanentTaskDataList()
	{
		List<HonamiStoryPermanentTaskData> list = new List<HonamiStoryPermanentTaskData>();
		foreach (KeyValuePair<int, HonamiStoryPermanentTaskData> keyValuePair in this.PermanentTaskDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		list.Sort(delegate(HonamiStoryPermanentTaskData a, HonamiStoryPermanentTaskData b)
		{
			if (a.Status != b.Status)
			{
				return a.Status.CompareTo(b.Status);
			}
			return a.Id.CompareTo(b.Id);
		});
		return list;
	}

	// Token: 0x0600ECCB RID: 60619 RVA: 0x00386970 File Offset: 0x00384B70
	public List<int> GetPermanentTaskIdsByState(EActivityTaskState state)
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, HonamiStoryPermanentTaskData> keyValuePair in this.PermanentTaskDataMap)
		{
			if (keyValuePair.Value.Status == state)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x0600ECCC RID: 60620 RVA: 0x003869E0 File Offset: 0x00384BE0
	public int GetPermanentTaskTotalNum()
	{
		return this.PermanentTaskDataMap.Count;
	}

	// Token: 0x0600ECCD RID: 60621 RVA: 0x003869F0 File Offset: 0x00384BF0
	public bool IsPermanentTaskHasRedDot()
	{
		using (Dictionary<int, HonamiStoryPermanentTaskData>.ValueCollection.Enumerator enumerator = this.PermanentTaskDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600ECCE RID: 60622 RVA: 0x00386A50 File Offset: 0x00384C50
	private void InitHonamiStoryLimitTaskData()
	{
		foreach (HonamiStoryLimitTask honamiStoryLimitTask in HonamiStoryConfig.Instance.GetHonamiStoryLimitTaskConfigList(base.Id))
		{
			HonamiStoryLimitTaskData value = new HonamiStoryLimitTaskData(honamiStoryLimitTask.Id);
			this.LimitTaskDataMap[honamiStoryLimitTask.Id] = value;
		}
	}

	// Token: 0x0600ECCF RID: 60623 RVA: 0x00386AC0 File Offset: 0x00384CC0
	public void UpdateLimitTaskDataList(List<ConditionTask> limitTaskInfoList)
	{
		foreach (ConditionTask limitTaskInfo in limitTaskInfoList)
		{
			this.UpdateLimitTaskData(limitTaskInfo);
		}
	}

	// Token: 0x0600ECD0 RID: 60624 RVA: 0x00386B10 File Offset: 0x00384D10
	public void UpdateLimitTaskData(ConditionTask limitTaskInfo)
	{
		HonamiStoryLimitTaskData limitTaskData = this.GetLimitTaskData(limitTaskInfo.Id);
		if (limitTaskData == null)
		{
			return;
		}
		limitTaskData.UpdateData(limitTaskInfo);
	}

	// Token: 0x0600ECD1 RID: 60625 RVA: 0x00386B38 File Offset: 0x00384D38
	[NullableContext(2)]
	public HonamiStoryLimitTaskData GetLimitTaskData(int id)
	{
		HonamiStoryLimitTaskData result;
		if (this.LimitTaskDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HonamiStory;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "HonamiStoryLimitTaskData 无效Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600ECD2 RID: 60626 RVA: 0x00386B88 File Offset: 0x00384D88
	public List<HonamiStoryLimitTaskData> GetLimitTaskDataList()
	{
		List<HonamiStoryLimitTaskData> list = new List<HonamiStoryLimitTaskData>();
		foreach (KeyValuePair<int, HonamiStoryLimitTaskData> keyValuePair in this.LimitTaskDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		list.Sort(delegate(HonamiStoryLimitTaskData a, HonamiStoryLimitTaskData b)
		{
			if (a.Status != b.Status)
			{
				return a.Status.CompareTo(b.Status);
			}
			return a.Id.CompareTo(b.Id);
		});
		return list;
	}

	// Token: 0x0600ECD3 RID: 60627 RVA: 0x00386C10 File Offset: 0x00384E10
	public List<int> GetFinishedLimitTaskIds()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, HonamiStoryLimitTaskData> keyValuePair in this.LimitTaskDataMap)
		{
			if (keyValuePair.Value.Status == EActivityTaskState.FinishedAndUnclaimed)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x0600ECD4 RID: 60628 RVA: 0x00386C80 File Offset: 0x00384E80
	public bool IsLimitTaskHasRedDot()
	{
		using (Dictionary<int, HonamiStoryLimitTaskData>.ValueCollection.Enumerator enumerator = this.LimitTaskDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		using (Dictionary<int, HonamiStoryScoreRewardData>.ValueCollection.Enumerator enumerator2 = this.ScoreRewardDataMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (enumerator2.Current.State == EHonamiStoryCollectState.Finished)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600ECD5 RID: 60629 RVA: 0x00386D2C File Offset: 0x00384F2C
	private void InitHonamiStoryScoreRewardData()
	{
		foreach (HonamiStoryScoreReward honamiStoryScoreReward in HonamiStoryConfig.Instance.GetHonamiStoryScoreRewardConfigList(base.Id))
		{
			HonamiStoryScoreRewardData value = new HonamiStoryScoreRewardData(honamiStoryScoreReward.Id);
			this.ScoreRewardDataMap[honamiStoryScoreReward.Id] = value;
		}
	}

	// Token: 0x0600ECD6 RID: 60630 RVA: 0x00386D9C File Offset: 0x00384F9C
	public void UpdateScoreRewardDataList(List<HonamiStoryScoreRewardInfo> infoList)
	{
		foreach (HonamiStoryScoreRewardInfo info in infoList)
		{
			this.UpdateScoreRewardData(info);
		}
	}

	// Token: 0x0600ECD7 RID: 60631 RVA: 0x00386DEC File Offset: 0x00384FEC
	public void UpdateScoreRewardData(HonamiStoryScoreRewardInfo info)
	{
		HonamiStoryScoreRewardData honamiStoryScoreRewardData;
		if (this.ScoreRewardDataMap.TryGetValue(info.ScoreRewardId, out honamiStoryScoreRewardData))
		{
			honamiStoryScoreRewardData.UpdateState((EHonamiStoryCollectState)info.Status);
		}
	}

	// Token: 0x0600ECD8 RID: 60632 RVA: 0x00386E1C File Offset: 0x0038501C
	[NullableContext(2)]
	public HonamiStoryScoreRewardData GetScoreRewardData(int scoreRewardId)
	{
		HonamiStoryScoreRewardData result;
		if (this.ScoreRewardDataMap.TryGetValue(scoreRewardId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600ECD9 RID: 60633 RVA: 0x00386E3C File Offset: 0x0038503C
	public List<HonamiStoryScoreRewardData> GetScoreRewardDataList()
	{
		List<HonamiStoryScoreRewardData> list = new List<HonamiStoryScoreRewardData>();
		foreach (KeyValuePair<int, HonamiStoryScoreRewardData> keyValuePair in this.ScoreRewardDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list;
	}

	// Token: 0x0600ECDA RID: 60634 RVA: 0x00386E9C File Offset: 0x0038509C
	public List<int> GetFinishedScoreRewardIds()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, HonamiStoryScoreRewardData> keyValuePair in this.ScoreRewardDataMap)
		{
			if (keyValuePair.Value.State == EHonamiStoryCollectState.Finished)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x0600ECDB RID: 60635 RVA: 0x00386F0C File Offset: 0x0038510C
	public int GetCurrentScore()
	{
		return InventoryModel.Instance.GetItemCountByConfigId(this.Config.Value.ScoreItemId, 0);
	}

	// Token: 0x0600ECDC RID: 60636 RVA: 0x00386F3C File Offset: 0x0038513C
	public int GetMaxScore()
	{
		int num = 0;
		foreach (HonamiStoryScoreReward honamiStoryScoreReward in HonamiStoryConfig.Instance.GetHonamiStoryScoreRewardConfigList(base.Id))
		{
			if (num < honamiStoryScoreReward.Score)
			{
				num = honamiStoryScoreReward.Score;
			}
		}
		return num;
	}

	// Token: 0x0600ECDD RID: 60637 RVA: 0x00386FA4 File Offset: 0x003851A4
	public void InitSubQuestTaskDataList(IReadOnlyList<ConditionTask> subQuestInfoList)
	{
		this.SubQuestDataMap.Clear();
		this.SubTaskDataList.Clear();
		foreach (ConditionTask conditionTask in subQuestInfoList)
		{
			HonamiStorySubQuestData honamiStorySubQuestData = new HonamiStorySubQuestData(conditionTask.Id);
			this.SubQuestDataMap[conditionTask.Id] = honamiStorySubQuestData;
			this.SubTaskDataList.Add(honamiStorySubQuestData);
			honamiStorySubQuestData.UpdateData(conditionTask);
		}
	}

	// Token: 0x0600ECDE RID: 60638 RVA: 0x0038702C File Offset: 0x0038522C
	public void UpdateSubQuestTaskDataList(List<ConditionTask> subQuestInfoList)
	{
		foreach (ConditionTask subQuestInfo in subQuestInfoList)
		{
			this.UpdateSubQuestTaskData(subQuestInfo);
		}
	}

	// Token: 0x0600ECDF RID: 60639 RVA: 0x0038707C File Offset: 0x0038527C
	public void UpdateSubQuestTaskData(ConditionTask subQuestInfo)
	{
		HonamiStorySubQuestData subQuestTaskData = this.GetSubQuestTaskData(subQuestInfo.Id);
		if (subQuestTaskData == null)
		{
			return;
		}
		subQuestTaskData.UpdateData(subQuestInfo);
	}

	// Token: 0x0600ECE0 RID: 60640 RVA: 0x003870A4 File Offset: 0x003852A4
	[NullableContext(2)]
	public HonamiStorySubQuestData GetSubQuestTaskData(int id)
	{
		HonamiStorySubQuestData result;
		if (this.SubQuestDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HonamiStory;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "HonamiStoryAreaTaskData 无效Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600ECE1 RID: 60641 RVA: 0x003870F3 File Offset: 0x003852F3
	public List<HonamiStorySubQuestData> GetSubQuestTaskDataList()
	{
		return this.SubTaskDataList;
	}

	// Token: 0x0600ECE2 RID: 60642 RVA: 0x003870FC File Offset: 0x003852FC
	private void InitItemCollectionData()
	{
		foreach (HonamiStoryItemCollection config in HonamiStoryConfig.Instance.GetHonamiStoryItemCollectionConfigList(base.Id))
		{
			HonamiStoryItemCollectionData value = new HonamiStoryItemCollectionData(config);
			this.ItemCollectionDataMap[config.ItemId] = value;
		}
	}

	// Token: 0x0600ECE3 RID: 60643 RVA: 0x00387168 File Offset: 0x00385368
	public void UpdateItemCollectionDataList(List<HonamiStoryItemCollectionInfo> itemCollectionInfoList)
	{
		foreach (HonamiStoryItemCollectionInfo honamiStoryItemCollectionInfo in itemCollectionInfoList)
		{
			HonamiStoryItemCollectionData itemCollectionData = this.GetItemCollectionData(honamiStoryItemCollectionInfo.HonamiStoryItemId);
			if (itemCollectionData != null)
			{
				itemCollectionData.UpdateData(honamiStoryItemCollectionInfo);
			}
		}
	}

	// Token: 0x0600ECE4 RID: 60644 RVA: 0x003871C8 File Offset: 0x003853C8
	[NullableContext(2)]
	public HonamiStoryItemCollectionData GetItemCollectionData(int id)
	{
		HonamiStoryItemCollectionData result;
		if (this.ItemCollectionDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HonamiStory;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "HonamiStoryItemCollectionData 无效Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600ECE5 RID: 60645 RVA: 0x00387218 File Offset: 0x00385418
	public List<HonamiStoryItemCollectionData> GetItemCollectionDataList()
	{
		List<HonamiStoryItemCollectionData> list = new List<HonamiStoryItemCollectionData>();
		foreach (KeyValuePair<int, HonamiStoryItemCollectionData> keyValuePair in this.ItemCollectionDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list;
	}

	// Token: 0x0600ECE6 RID: 60646 RVA: 0x00387278 File Offset: 0x00385478
	public bool IsItemCollectionHasRedDot()
	{
		using (Dictionary<int, HonamiStoryItemCollectionData>.ValueCollection.Enumerator enumerator = this.ItemCollectionDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.State == EHonamiStoryCollectState.Finished)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600ECE7 RID: 60647 RVA: 0x003872D8 File Offset: 0x003854D8
	private void InitLevelSelectPanelData()
	{
		HonamiStoryActivity? config = this.Config;
		this.CurHonamiLv = ((config != null) ? config.GetValueOrDefault().OriAreaDangerLevel : 0);
		config = this.Config;
		this.CurTowerLv = ((config != null) ? config.GetValueOrDefault().OriTopTowerDangerLevel : 0);
	}

	// Token: 0x0600ECE8 RID: 60648 RVA: 0x00387338 File Offset: 0x00385538
	public bool IsLevelSelectHasViewRedDot()
	{
		if (!FunctionModel.Instance.IsOpen(10121))
		{
			int currentProgressAreaDataId = this.GetCurrentProgressAreaDataId();
			int count = this.GetHonamiStoryAreaDataList().Count;
			HonamiStoryAreaData honamiStoryAreaData = this.GetHonamiStoryAreaData(currentProgressAreaDataId);
			return currentProgressAreaDataId <= count && honamiStoryAreaData != null && honamiStoryAreaData.IsAreaCanEnter;
		}
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockTogRedDot, false);
	}

	// Token: 0x1700128F RID: 4751
	// (get) Token: 0x0600ECE9 RID: 60649 RVA: 0x0038738F File Offset: 0x0038558F
	private HonamiStoryActivity? Config
	{
		get
		{
			return HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(base.Id);
		}
	}

	// Token: 0x17001290 RID: 4752
	// (get) Token: 0x0600ECEA RID: 60650 RVA: 0x003873A4 File Offset: 0x003855A4
	public int HelpId
	{
		get
		{
			return this.Config.Value.HelpId;
		}
	}

	// Token: 0x17001291 RID: 4753
	// (get) Token: 0x0600ECEB RID: 60651 RVA: 0x003873C8 File Offset: 0x003855C8
	public int MarkId
	{
		get
		{
			return this.Config.Value.MarkId;
		}
	}

	// Token: 0x17001292 RID: 4754
	// (get) Token: 0x0600ECEC RID: 60652 RVA: 0x003873EC File Offset: 0x003855EC
	public int ShopId
	{
		get
		{
			return this.Config.Value.ShopId;
		}
	}

	// Token: 0x17001293 RID: 4755
	// (get) Token: 0x0600ECED RID: 60653 RVA: 0x00387410 File Offset: 0x00385610
	public int GetActHelpId
	{
		get
		{
			return this.Config.Value.HelpId;
		}
	}

	// Token: 0x17001294 RID: 4756
	// (get) Token: 0x0600ECEE RID: 60654 RVA: 0x00387434 File Offset: 0x00385634
	public int ActivityQuestId
	{
		get
		{
			return this.Config.Value.MainQuestId;
		}
	}

	// Token: 0x17001295 RID: 4757
	// (get) Token: 0x0600ECEF RID: 60655 RVA: 0x00387458 File Offset: 0x00385658
	public int AreaInstId
	{
		get
		{
			return this.Config.Value.AreaInstId;
		}
	}

	// Token: 0x17001296 RID: 4758
	// (get) Token: 0x0600ECF0 RID: 60656 RVA: 0x0038747C File Offset: 0x0038567C
	public int OutCoinItemId
	{
		get
		{
			return this.Config.Value.OutCoinItemId;
		}
	}

	// Token: 0x17001297 RID: 4759
	// (get) Token: 0x0600ECF1 RID: 60657 RVA: 0x003874A0 File Offset: 0x003856A0
	public string TowerName
	{
		get
		{
			return this.Config.Value.TowerName;
		}
	}

	// Token: 0x04006DFB RID: 28155
	private readonly Dictionary<int, HonamiStoryAreaData> AreaDataMap = new Dictionary<int, HonamiStoryAreaData>();

	// Token: 0x04006DFC RID: 28156
	private readonly List<HonamiStoryAreaData> AreaDataList = new List<HonamiStoryAreaData>();

	// Token: 0x04006DFD RID: 28157
	private readonly Dictionary<int, int> TowerDangerLv2MaxFloorMap = new Dictionary<int, int>();

	// Token: 0x04006DFE RID: 28158
	private readonly Dictionary<int, HonamiStoryMascotData> MascotDataMap = new Dictionary<int, HonamiStoryMascotData>();

	// Token: 0x04006DFF RID: 28159
	private readonly List<HonamiStoryMascotData> MascotDataList = new List<HonamiStoryMascotData>();

	// Token: 0x04006E00 RID: 28160
	private readonly Dictionary<int, HonamiStoryPermanentTaskData> PermanentTaskDataMap = new Dictionary<int, HonamiStoryPermanentTaskData>();

	// Token: 0x04006E01 RID: 28161
	private readonly Dictionary<int, HonamiStoryLimitTaskData> LimitTaskDataMap = new Dictionary<int, HonamiStoryLimitTaskData>();

	// Token: 0x04006E02 RID: 28162
	private readonly Dictionary<int, HonamiStoryScoreRewardData> ScoreRewardDataMap = new Dictionary<int, HonamiStoryScoreRewardData>();

	// Token: 0x04006E03 RID: 28163
	private readonly Dictionary<int, HonamiStorySubQuestData> SubQuestDataMap = new Dictionary<int, HonamiStorySubQuestData>();

	// Token: 0x04006E04 RID: 28164
	private readonly List<HonamiStorySubQuestData> SubTaskDataList = new List<HonamiStorySubQuestData>();

	// Token: 0x04006E05 RID: 28165
	private readonly Dictionary<int, HonamiStoryItemCollectionData> ItemCollectionDataMap = new Dictionary<int, HonamiStoryItemCollectionData>();

	// Token: 0x04006E06 RID: 28166
	public int CurTarget;

	// Token: 0x04006E07 RID: 28167
	public int CurHonamiLv;

	// Token: 0x04006E08 RID: 28168
	public int CurTowerLv;
}
