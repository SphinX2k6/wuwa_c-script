using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x0200132B RID: 4907
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryActivityData : ActivityBaseData
{
	// Token: 0x0600C0CE RID: 49358 RVA: 0x00391A68 File Offset: 0x0038FC68
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
		this.InitSubQuestTaskDataList(honamiStoryActivityInfo.AreaTask);
		this.UpdateHonamiStoryAreaDataList(honamiStoryActivityInfo.HonamiStoryAreaInfos);
		this.UpdateHonamiStoryMascotDataList(honamiStoryActivityInfo.HonamiStoryMascotInfos);
		this.UpdatePermanentTaskDataList(honamiStoryActivityInfo.HonamiStoryResidentTask);
		this.UpdateLimitTaskDataList(honamiStoryActivityInfo.HonamiStoryLimitTask);
		this.UpdateScoreRewardDataList(honamiStoryActivityInfo.HonamiStoryScoreRewardInfos);
		this.UpdateItemCollectionDataList(honamiStoryActivityInfo.HonamiStoryItemCollectionInfos);
		this.RefreshTowerData(honamiStoryActivityInfo.HonamiStoryTopInfos);
		this.InitLevelSelectPanelData();
	}

	// Token: 0x0600C0CF RID: 49359 RVA: 0x00391B3C File Offset: 0x0038FD3C
	protected override void PhraseEx(ActivityData data)
	{
		HonamiStoryActivityInfo honamiStoryActivityInfo = data.HonamiStoryActivityInfo;
		if (honamiStoryActivityInfo == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "HonamiStoryActivityDataPhrase 无效activityInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		HonamiStoryModel.Instance.UpdateActivityInfo(base.Id, honamiStoryActivityInfo);
		this.UpdateHonamiStoryAreaDataList(honamiStoryActivityInfo.HonamiStoryAreaInfos);
		this.UpdateHonamiStoryMascotDataList(honamiStoryActivityInfo.HonamiStoryMascotInfos);
		this.UpdatePermanentTaskDataList(honamiStoryActivityInfo.HonamiStoryResidentTask);
		this.UpdateLimitTaskDataList(honamiStoryActivityInfo.HonamiStoryLimitTask);
		this.UpdateScoreRewardDataList(honamiStoryActivityInfo.HonamiStoryScoreRewardInfos);
		this.UpdateItemCollectionDataList(honamiStoryActivityInfo.HonamiStoryItemCollectionInfos);
		this.UpdateSubQuestTaskDataList(honamiStoryActivityInfo.AreaTask);
		this.RefreshTowerData(honamiStoryActivityInfo.HonamiStoryTopInfos);
		HonamiStoryModel.Instance.SetTotalRevenueInternal(honamiStoryActivityInfo.TotalRevenue);
	}

	// Token: 0x0600C0D0 RID: 49360 RVA: 0x00391BF4 File Offset: 0x0038FDF4
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

	// Token: 0x0600C0D1 RID: 49361 RVA: 0x00391D34 File Offset: 0x0038FF34
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckAllFunctionRedDot();
	}

	// Token: 0x0600C0D2 RID: 49362 RVA: 0x00391D3C File Offset: 0x0038FF3C
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

	// Token: 0x0600C0D3 RID: 49363 RVA: 0x00391DEC File Offset: 0x0038FFEC
	private void InitHonamiStoryAreaData()
	{
		foreach (HonamiStoryArea honamiStoryArea in HonamiStoryConfig.Instance.GetHonamiStoryAreaConfigList(base.Id))
		{
			HonamiStoryAreaData honamiStoryAreaData = new HonamiStoryAreaData(honamiStoryArea.Id);
			this.AreaDataMap[honamiStoryArea.Id] = honamiStoryAreaData;
			this.AreaDataList.Add(honamiStoryAreaData);
		}
	}

	// Token: 0x0600C0D4 RID: 49364 RVA: 0x00391E68 File Offset: 0x00390068
	public void UpdateHonamiStoryAreaDataList(IEnumerable<HonamiStoryAreaInfo> areaInfoList)
	{
		foreach (HonamiStoryAreaInfo areaInfo in areaInfoList)
		{
			this.UpdateHonamiStoryAreaData(areaInfo);
		}
	}

	// Token: 0x0600C0D5 RID: 49365 RVA: 0x00391EB0 File Offset: 0x003900B0
	public void UpdateHonamiStoryAreaData(HonamiStoryAreaInfo areaInfo)
	{
		HonamiStoryAreaData honamiStoryAreaData = this.GetHonamiStoryAreaData(areaInfo.HonamiStoryAreaId);
		if (honamiStoryAreaData == null)
		{
			return;
		}
		honamiStoryAreaData.UpdateData(areaInfo);
	}

	// Token: 0x0600C0D6 RID: 49366 RVA: 0x00391ED8 File Offset: 0x003900D8
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

	// Token: 0x0600C0D7 RID: 49367 RVA: 0x00391F28 File Offset: 0x00390128
	public List<HonamiStoryAreaData> GetHonamiStoryAreaDataList()
	{
		if (this.AreaDataList.Count == 0)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "HonamiStoryAreaDataList为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return this.AreaDataList;
	}

	// Token: 0x0600C0D8 RID: 49368 RVA: 0x00391F68 File Offset: 0x00390168
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

	// Token: 0x0600C0D9 RID: 49369 RVA: 0x00391FE0 File Offset: 0x003901E0
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

	// Token: 0x0600C0DA RID: 49370 RVA: 0x00392060 File Offset: 0x00390260
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

	// Token: 0x0600C0DB RID: 49371 RVA: 0x003920CC File Offset: 0x003902CC
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

	// Token: 0x0600C0DC RID: 49372 RVA: 0x00392130 File Offset: 0x00390330
	public void RefreshTowerData(IEnumerable<HonamiStoryTopInfo> towerInfoList)
	{
		foreach (HonamiStoryTopInfo honamiStoryTopInfo in towerInfoList)
		{
			this.TowerDangerLv2MaxFloorMap[honamiStoryTopInfo.DangerLevel] = honamiStoryTopInfo.MaxFloor;
		}
	}

	// Token: 0x0600C0DD RID: 49373 RVA: 0x00392188 File Offset: 0x00390388
	public int GetMaxFloorByDangerLv(int lv)
	{
		int result;
		if (this.TowerDangerLv2MaxFloorMap.TryGetValue(lv, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x0600C0DE RID: 49374 RVA: 0x003921A8 File Offset: 0x003903A8
	private void InitHonamiStoryMascotData()
	{
		foreach (HonamiStoryMascot honamiStoryMascot in HonamiStoryConfig.Instance.GetHonamiStoryMascotConfigList(base.Id))
		{
			HonamiStoryMascotData honamiStoryMascotData = new HonamiStoryMascotData(honamiStoryMascot.Id);
			this.MascotDataMap[honamiStoryMascot.Id] = honamiStoryMascotData;
			this.MascotDataList.Add(honamiStoryMascotData);
		}
	}

	// Token: 0x0600C0DF RID: 49375 RVA: 0x00392224 File Offset: 0x00390424
	public void UpdateHonamiStoryMascotDataList(IEnumerable<HonamiStoryMascotInfo> mascotInfoList)
	{
		foreach (HonamiStoryMascotInfo mascotInfo in mascotInfoList)
		{
			this.UpdateHonamiStoryMascotData(mascotInfo);
		}
	}

	// Token: 0x0600C0E0 RID: 49376 RVA: 0x0039226C File Offset: 0x0039046C
	public void UpdateHonamiStoryMascotData(HonamiStoryMascotInfo mascotInfo)
	{
		HonamiStoryMascotData honamiStoryMascotData = this.GetHonamiStoryMascotData(mascotInfo.HonamiStoryMascotId);
		if (honamiStoryMascotData == null)
		{
			return;
		}
		honamiStoryMascotData.UpdateState((EHonamiStoryCollectState)mascotInfo.Status);
	}

	// Token: 0x0600C0E1 RID: 49377 RVA: 0x00392298 File Offset: 0x00390498
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

	// Token: 0x0600C0E2 RID: 49378 RVA: 0x003922E8 File Offset: 0x003904E8
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

	// Token: 0x0600C0E3 RID: 49379 RVA: 0x0039234C File Offset: 0x0039054C
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

	// Token: 0x0600C0E4 RID: 49380 RVA: 0x003923A8 File Offset: 0x003905A8
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

	// Token: 0x0600C0E5 RID: 49381 RVA: 0x00392404 File Offset: 0x00390604
	private void InitHonamiStoryPermanentTaskData()
	{
		foreach (HonamiStoryResidentTask honamiStoryResidentTask in HonamiStoryConfig.Instance.GetHonamiStoryPermanentTaskConfigList(base.Id))
		{
			HonamiStoryPermanentTaskData value = new HonamiStoryPermanentTaskData(honamiStoryResidentTask.Id);
			this.PermanentTaskDataMap[honamiStoryResidentTask.Id] = value;
		}
	}

	// Token: 0x0600C0E6 RID: 49382 RVA: 0x00392474 File Offset: 0x00390674
	public void UpdatePermanentTaskDataList(IEnumerable<ConditionTask> taskInfoList)
	{
		foreach (ConditionTask taskInfo in taskInfoList)
		{
			this.UpdatePermanentTaskData(taskInfo);
		}
	}

	// Token: 0x0600C0E7 RID: 49383 RVA: 0x003924BC File Offset: 0x003906BC
	public void UpdatePermanentTaskData(ConditionTask taskInfo)
	{
		HonamiStoryPermanentTaskData permanentTaskData = this.GetPermanentTaskData(taskInfo.Id);
		if (permanentTaskData == null)
		{
			return;
		}
		permanentTaskData.UpdateData(taskInfo);
	}

	// Token: 0x0600C0E8 RID: 49384 RVA: 0x003924E4 File Offset: 0x003906E4
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

	// Token: 0x0600C0E9 RID: 49385 RVA: 0x00392534 File Offset: 0x00390734
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

	// Token: 0x0600C0EA RID: 49386 RVA: 0x003925BC File Offset: 0x003907BC
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

	// Token: 0x0600C0EB RID: 49387 RVA: 0x0039262C File Offset: 0x0039082C
	public int GetPermanentTaskTotalNum()
	{
		return this.PermanentTaskDataMap.Count;
	}

	// Token: 0x0600C0EC RID: 49388 RVA: 0x0039263C File Offset: 0x0039083C
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

	// Token: 0x0600C0ED RID: 49389 RVA: 0x0039269C File Offset: 0x0039089C
	private void InitHonamiStoryLimitTaskData()
	{
		foreach (HonamiStoryLimitTask honamiStoryLimitTask in HonamiStoryConfig.Instance.GetHonamiStoryLimitTaskConfigList(base.Id))
		{
			HonamiStoryLimitTaskData value = new HonamiStoryLimitTaskData(honamiStoryLimitTask.Id);
			this.LimitTaskDataMap[honamiStoryLimitTask.Id] = value;
		}
	}

	// Token: 0x0600C0EE RID: 49390 RVA: 0x0039270C File Offset: 0x0039090C
	public void UpdateLimitTaskDataList(IEnumerable<ConditionTask> limitTaskInfoList)
	{
		foreach (ConditionTask limitTaskInfo in limitTaskInfoList)
		{
			this.UpdateLimitTaskData(limitTaskInfo);
		}
	}

	// Token: 0x0600C0EF RID: 49391 RVA: 0x00392754 File Offset: 0x00390954
	public void UpdateLimitTaskData(ConditionTask limitTaskInfo)
	{
		HonamiStoryLimitTaskData limitTaskData = this.GetLimitTaskData(limitTaskInfo.Id);
		if (limitTaskData == null)
		{
			return;
		}
		limitTaskData.UpdateData(limitTaskInfo);
	}

	// Token: 0x0600C0F0 RID: 49392 RVA: 0x0039277C File Offset: 0x0039097C
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

	// Token: 0x0600C0F1 RID: 49393 RVA: 0x003927CC File Offset: 0x003909CC
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

	// Token: 0x0600C0F2 RID: 49394 RVA: 0x00392854 File Offset: 0x00390A54
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

	// Token: 0x0600C0F3 RID: 49395 RVA: 0x003928C4 File Offset: 0x00390AC4
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

	// Token: 0x0600C0F4 RID: 49396 RVA: 0x00392970 File Offset: 0x00390B70
	private void InitHonamiStoryScoreRewardData()
	{
		foreach (HonamiStoryScoreReward honamiStoryScoreReward in HonamiStoryConfig.Instance.GetHonamiStoryScoreRewardConfigList(base.Id))
		{
			HonamiStoryScoreRewardData value = new HonamiStoryScoreRewardData(honamiStoryScoreReward.Id);
			this.ScoreRewardDataMap[honamiStoryScoreReward.Id] = value;
		}
	}

	// Token: 0x0600C0F5 RID: 49397 RVA: 0x003929E0 File Offset: 0x00390BE0
	public void UpdateScoreRewardDataList(IEnumerable<HonamiStoryScoreRewardInfo> infoList)
	{
		foreach (HonamiStoryScoreRewardInfo info in infoList)
		{
			this.UpdateScoreRewardData(info);
		}
	}

	// Token: 0x0600C0F6 RID: 49398 RVA: 0x00392A28 File Offset: 0x00390C28
	public void UpdateScoreRewardData(HonamiStoryScoreRewardInfo info)
	{
		HonamiStoryScoreRewardData honamiStoryScoreRewardData;
		if (this.ScoreRewardDataMap.TryGetValue(info.ScoreRewardId, out honamiStoryScoreRewardData))
		{
			honamiStoryScoreRewardData.UpdateState((EHonamiStoryCollectState)info.Status);
		}
	}

	// Token: 0x0600C0F7 RID: 49399 RVA: 0x00392A58 File Offset: 0x00390C58
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

	// Token: 0x0600C0F8 RID: 49400 RVA: 0x00392A78 File Offset: 0x00390C78
	public List<HonamiStoryScoreRewardData> GetScoreRewardDataList()
	{
		List<HonamiStoryScoreRewardData> list = new List<HonamiStoryScoreRewardData>();
		foreach (KeyValuePair<int, HonamiStoryScoreRewardData> keyValuePair in this.ScoreRewardDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list;
	}

	// Token: 0x0600C0F9 RID: 49401 RVA: 0x00392AD8 File Offset: 0x00390CD8
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

	// Token: 0x0600C0FA RID: 49402 RVA: 0x00392B48 File Offset: 0x00390D48
	public int GetCurrentScore()
	{
		return InventoryModel.Instance.GetItemCountByConfigId(this.Config.Value.ScoreItemId, 0);
	}

	// Token: 0x0600C0FB RID: 49403 RVA: 0x00392B78 File Offset: 0x00390D78
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

	// Token: 0x0600C0FC RID: 49404 RVA: 0x00392BE0 File Offset: 0x00390DE0
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

	// Token: 0x0600C0FD RID: 49405 RVA: 0x00392C68 File Offset: 0x00390E68
	public void UpdateSubQuestTaskDataList(IEnumerable<ConditionTask> subQuestInfoList)
	{
		foreach (ConditionTask subQuestInfo in subQuestInfoList)
		{
			this.UpdateSubQuestTaskData(subQuestInfo);
		}
	}

	// Token: 0x0600C0FE RID: 49406 RVA: 0x00392CB0 File Offset: 0x00390EB0
	public void UpdateSubQuestTaskData(ConditionTask subQuestInfo)
	{
		HonamiStorySubQuestData subQuestTaskData = this.GetSubQuestTaskData(subQuestInfo.Id);
		if (subQuestTaskData == null)
		{
			return;
		}
		subQuestTaskData.UpdateData(subQuestInfo);
	}

	// Token: 0x0600C0FF RID: 49407 RVA: 0x00392CD8 File Offset: 0x00390ED8
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

	// Token: 0x0600C100 RID: 49408 RVA: 0x00392D27 File Offset: 0x00390F27
	public List<HonamiStorySubQuestData> GetSubQuestTaskDataList()
	{
		return this.SubTaskDataList;
	}

	// Token: 0x0600C101 RID: 49409 RVA: 0x00392D30 File Offset: 0x00390F30
	private void InitItemCollectionData()
	{
		foreach (HonamiStoryItemCollection config in HonamiStoryConfig.Instance.GetHonamiStoryItemCollectionConfigList(base.Id))
		{
			HonamiStoryItemCollectionData value = new HonamiStoryItemCollectionData(config);
			this.ItemCollectionDataMap[config.ItemId] = value;
		}
	}

	// Token: 0x0600C102 RID: 49410 RVA: 0x00392D9C File Offset: 0x00390F9C
	public void UpdateItemCollectionDataList(IEnumerable<HonamiStoryItemCollectionInfo> itemCollectionInfoList)
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

	// Token: 0x0600C103 RID: 49411 RVA: 0x00392DF4 File Offset: 0x00390FF4
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

	// Token: 0x0600C104 RID: 49412 RVA: 0x00392E44 File Offset: 0x00391044
	public List<HonamiStoryItemCollectionData> GetItemCollectionDataList()
	{
		List<HonamiStoryItemCollectionData> list = new List<HonamiStoryItemCollectionData>();
		foreach (KeyValuePair<int, HonamiStoryItemCollectionData> keyValuePair in this.ItemCollectionDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list;
	}

	// Token: 0x0600C105 RID: 49413 RVA: 0x00392EA4 File Offset: 0x003910A4
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

	// Token: 0x0600C106 RID: 49414 RVA: 0x00392F04 File Offset: 0x00391104
	private void InitLevelSelectPanelData()
	{
		HonamiStoryActivity? config = this.Config;
		this.CurHonamiLv = ((config != null) ? config.GetValueOrDefault().OriAreaDangerLevel : 0);
		config = this.Config;
		this.CurTowerLv = ((config != null) ? config.GetValueOrDefault().OriTopTowerDangerLevel : 0);
	}

	// Token: 0x0600C107 RID: 49415 RVA: 0x00392F64 File Offset: 0x00391164
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

	// Token: 0x170012B9 RID: 4793
	// (get) Token: 0x0600C108 RID: 49416 RVA: 0x00392FBB File Offset: 0x003911BB
	private HonamiStoryActivity? Config
	{
		get
		{
			return HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(base.Id);
		}
	}

	// Token: 0x170012BA RID: 4794
	// (get) Token: 0x0600C109 RID: 49417 RVA: 0x00392FD0 File Offset: 0x003911D0
	public int HelpId
	{
		get
		{
			return this.Config.Value.HelpId;
		}
	}

	// Token: 0x170012BB RID: 4795
	// (get) Token: 0x0600C10A RID: 49418 RVA: 0x00392FF4 File Offset: 0x003911F4
	public int MarkId
	{
		get
		{
			return this.Config.Value.MarkId;
		}
	}

	// Token: 0x170012BC RID: 4796
	// (get) Token: 0x0600C10B RID: 49419 RVA: 0x00393018 File Offset: 0x00391218
	public int ShopId
	{
		get
		{
			return this.Config.Value.ShopId;
		}
	}

	// Token: 0x170012BD RID: 4797
	// (get) Token: 0x0600C10C RID: 49420 RVA: 0x0039303C File Offset: 0x0039123C
	public int GetActHelpId
	{
		get
		{
			return this.Config.Value.HelpId;
		}
	}

	// Token: 0x170012BE RID: 4798
	// (get) Token: 0x0600C10D RID: 49421 RVA: 0x00393060 File Offset: 0x00391260
	public int ActivityQuestId
	{
		get
		{
			return this.Config.Value.MainQuestId;
		}
	}

	// Token: 0x170012BF RID: 4799
	// (get) Token: 0x0600C10E RID: 49422 RVA: 0x00393084 File Offset: 0x00391284
	public int AreaInstId
	{
		get
		{
			return this.Config.Value.AreaInstId;
		}
	}

	// Token: 0x170012C0 RID: 4800
	// (get) Token: 0x0600C10F RID: 49423 RVA: 0x003930A8 File Offset: 0x003912A8
	public int OutCoinItemId
	{
		get
		{
			return this.Config.Value.OutCoinItemId;
		}
	}

	// Token: 0x170012C1 RID: 4801
	// (get) Token: 0x0600C110 RID: 49424 RVA: 0x003930CC File Offset: 0x003912CC
	public string TowerName
	{
		get
		{
			return this.Config.Value.TowerName;
		}
	}

	// Token: 0x04006EDC RID: 28380
	private readonly Dictionary<int, HonamiStoryAreaData> AreaDataMap = new Dictionary<int, HonamiStoryAreaData>();

	// Token: 0x04006EDD RID: 28381
	private readonly List<HonamiStoryAreaData> AreaDataList = new List<HonamiStoryAreaData>();

	// Token: 0x04006EDE RID: 28382
	private readonly Dictionary<int, int> TowerDangerLv2MaxFloorMap = new Dictionary<int, int>();

	// Token: 0x04006EDF RID: 28383
	private readonly Dictionary<int, HonamiStoryMascotData> MascotDataMap = new Dictionary<int, HonamiStoryMascotData>();

	// Token: 0x04006EE0 RID: 28384
	private readonly List<HonamiStoryMascotData> MascotDataList = new List<HonamiStoryMascotData>();

	// Token: 0x04006EE1 RID: 28385
	private readonly Dictionary<int, HonamiStoryPermanentTaskData> PermanentTaskDataMap = new Dictionary<int, HonamiStoryPermanentTaskData>();

	// Token: 0x04006EE2 RID: 28386
	private readonly Dictionary<int, HonamiStoryLimitTaskData> LimitTaskDataMap = new Dictionary<int, HonamiStoryLimitTaskData>();

	// Token: 0x04006EE3 RID: 28387
	private readonly Dictionary<int, HonamiStoryScoreRewardData> ScoreRewardDataMap = new Dictionary<int, HonamiStoryScoreRewardData>();

	// Token: 0x04006EE4 RID: 28388
	private readonly Dictionary<int, HonamiStorySubQuestData> SubQuestDataMap = new Dictionary<int, HonamiStorySubQuestData>();

	// Token: 0x04006EE5 RID: 28389
	private readonly List<HonamiStorySubQuestData> SubTaskDataList = new List<HonamiStorySubQuestData>();

	// Token: 0x04006EE6 RID: 28390
	private readonly Dictionary<int, HonamiStoryItemCollectionData> ItemCollectionDataMap = new Dictionary<int, HonamiStoryItemCollectionData>();

	// Token: 0x04006EE7 RID: 28391
	public int CurTarget;

	// Token: 0x04006EE8 RID: 28392
	public int CurHonamiLv;

	// Token: 0x04006EE9 RID: 28393
	public int CurTowerLv;
}
