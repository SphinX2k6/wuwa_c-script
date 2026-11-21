using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200071D RID: 1821
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoActivityData : ActivityBaseData
{
	// Token: 0x060053E6 RID: 21478 RVA: 0x001BB4A4 File Offset: 0x001B96A4
	private unsafe void InitLevelGroupData()
	{
		IReadOnlyList<PhotoFightActivityGroup> configList = ConfigPhotoFightActivityGroupByActivityId.GetConfigList(base.Id, true);
		if (configList == null)
		{
			return;
		}
		foreach (PhotoFightActivityGroup config in configList)
		{
			FightPhotoLevelGroupData fightPhotoLevelGroupData = new FightPhotoLevelGroupData(config);
			this.LevelGroupDataMap[config.Id] = fightPhotoLevelGroupData;
			this.LevelGroupDataList.Add(fightPhotoLevelGroupData);
			Span<int> levelIdList = fightPhotoLevelGroupData.LevelIdList;
			for (int i = 0; i < levelIdList.Length; i++)
			{
				int num = *levelIdList[i];
				PhotoFightActivity? config2 = ConfigPhotoFightActivityById.GetConfig(num, true);
				if (config2 == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.FightPhotograph;
					ELogAuthor author = ELogAuthor.CXJ;
					string message = "战斗拍照关卡配置不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					FightPhotoLevelData fightPhotoLevelData = new FightPhotoLevelData(config2.Value);
					fightPhotoLevelData.LevelGroupData = fightPhotoLevelGroupData;
					this.LevelDataMap[num] = fightPhotoLevelData;
					fightPhotoLevelGroupData.PushFightPhotoLevel(fightPhotoLevelData);
				}
			}
		}
		this.LevelGroupDataList.Sort((FightPhotoLevelGroupData a, FightPhotoLevelGroupData b) => a.SortId - b.SortId);
	}

	// Token: 0x060053E7 RID: 21479 RVA: 0x001BB5F4 File Offset: 0x001B97F4
	[NullableContext(2)]
	private FightPhotoLevelGroupData GetLevelGroupData(int levelGroupId)
	{
		FightPhotoLevelGroupData result;
		if (!this.LevelGroupDataMap.TryGetValue(levelGroupId, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FightPhotograph;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "战斗拍照关卡组配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelGroupId", levelGroupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x060053E8 RID: 21480 RVA: 0x001BB644 File Offset: 0x001B9844
	[NullableContext(2)]
	public FightPhotoLevelData GetLevelData(int levelId)
	{
		FightPhotoLevelData result;
		if (!this.LevelDataMap.TryGetValue(levelId, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FightPhotograph;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "战斗拍照关卡配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelId", levelId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x060053E9 RID: 21481 RVA: 0x001BB694 File Offset: 0x001B9894
	[NullableContext(2)]
	public FightPhotoLevelData GetLevelDataById(int levelId)
	{
		FightPhotoLevelData result;
		this.LevelDataMap.TryGetValue(levelId, out result);
		return result;
	}

	// Token: 0x060053EA RID: 21482 RVA: 0x001BB6B4 File Offset: 0x001B98B4
	[NullableContext(2)]
	public FightPhotoLevelData GetNextLevelData(int currentLevelId)
	{
		FightPhotoLevelData currentLevelData;
		if (!this.LevelDataMap.TryGetValue(currentLevelId, out currentLevelData))
		{
			return null;
		}
		List<FightPhotoLevelData> levelDataList = currentLevelData.LevelGroupData.LevelDataList;
		int num = levelDataList.FindIndex((FightPhotoLevelData d) => d.LevelId == currentLevelId);
		if (num >= 0 && num + 1 < levelDataList.Count)
		{
			return levelDataList[num + 1];
		}
		int num2 = this.LevelGroupDataList.FindIndex((FightPhotoLevelGroupData g) => g.Id == currentLevelData.LevelGroupData.Id);
		if (num2 < 0 || num2 + 1 >= this.LevelGroupDataList.Count)
		{
			return null;
		}
		List<FightPhotoLevelData> levelDataList2 = this.LevelGroupDataList[num2 + 1].LevelDataList;
		if (levelDataList2.Count <= 0)
		{
			return null;
		}
		return levelDataList2[0];
	}

	// Token: 0x060053EB RID: 21483 RVA: 0x001BB780 File Offset: 0x001B9980
	public void UpdateLevelGroupData(IReadOnlyList<PhotoFightLevelGroupPb> levelGroupInfoList)
	{
		foreach (PhotoFightLevelGroupPb photoFightLevelGroupPb in levelGroupInfoList)
		{
			FightPhotoLevelGroupData levelGroupData = this.GetLevelGroupData(photoFightLevelGroupPb.GroupId);
			if (levelGroupData != null)
			{
				levelGroupData.UnlockTime = MathUtils.Instance.LongToNumber(photoFightLevelGroupPb.OpenTime);
				this.UpdateLevelData(photoFightLevelGroupPb.PhotoFightLevelInfo, true);
			}
		}
	}

	// Token: 0x060053EC RID: 21484 RVA: 0x001BB7F4 File Offset: 0x001B99F4
	public void UpdateLevelData(IReadOnlyList<PhotoFightLevelPb> levelInfoList, bool isInit = true)
	{
		foreach (PhotoFightLevelPb photoFightLevelPb in levelInfoList)
		{
			FightPhotoLevelData levelData = this.GetLevelData(photoFightLevelPb.LevelId);
			if (levelData != null)
			{
				if (!isInit && levelData.IsDifficulty && !levelData.IsUnLock && photoFightLevelPb.IsOpen)
				{
					this.IsNeedShowTip = true;
				}
				levelData.IsUnLock = photoFightLevelPb.IsOpen;
				levelData.IsFinished = (photoFightLevelPb.ClearTimes > 0);
				levelData.SetRoleIdList(new List<int>(photoFightLevelPb.Roles));
			}
		}
	}

	// Token: 0x060053ED RID: 21485 RVA: 0x001BB894 File Offset: 0x001B9A94
	public int GetSelectLevelGroupDataIndex()
	{
		FightPhotoLevelData currentLevel = this.GetCurrentLevelData(false);
		if (currentLevel != null)
		{
			return this.LevelGroupDataList.FindIndex((FightPhotoLevelGroupData data) => data.Id == currentLevel.LevelGroupData.Id);
		}
		return this.GetFirstUnFinishedLevelGroupDataIndex();
	}

	// Token: 0x060053EE RID: 21486 RVA: 0x001BB8DC File Offset: 0x001B9ADC
	public int GetFirstUnFinishedLevelGroupDataIndex()
	{
		int count = this.LevelGroupDataList.Count;
		int num = -1;
		for (int i = 0; i < count; i++)
		{
			FightPhotoLevelGroupData fightPhotoLevelGroupData = this.LevelGroupDataList[i];
			if (fightPhotoLevelGroupData.IsUnLock && !fightPhotoLevelGroupData.IsFinished)
			{
				return i;
			}
			if (num == -1 && !fightPhotoLevelGroupData.IsUnLock)
			{
				num = i;
			}
		}
		if (num != -1)
		{
			return num - 1;
		}
		return count - 1;
	}

	// Token: 0x060053EF RID: 21487 RVA: 0x001BB93C File Offset: 0x001B9B3C
	public bool IsLevelHasRedDot()
	{
		using (Dictionary<int, FightPhotoLevelData>.ValueCollection.Enumerator enumerator = this.LevelDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.HasRedDot)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060053F0 RID: 21488 RVA: 0x001BB99C File Offset: 0x001B9B9C
	public List<FightPhotoLevelGroupData> GetLevelGroupDataList()
	{
		return this.LevelGroupDataList;
	}

	// Token: 0x060053F1 RID: 21489 RVA: 0x001BB9A4 File Offset: 0x001B9BA4
	public int GetTotalLevelNum()
	{
		return this.LevelGroupDataMap.Count;
	}

	// Token: 0x060053F2 RID: 21490 RVA: 0x001BB9B4 File Offset: 0x001B9BB4
	public int GetFinishedLevelNum()
	{
		int num = 0;
		using (Dictionary<int, FightPhotoLevelGroupData>.ValueCollection.Enumerator enumerator = this.LevelGroupDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsFinished)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060053F3 RID: 21491 RVA: 0x001BBA14 File Offset: 0x001B9C14
	private void InitTaskData()
	{
		IReadOnlyList<PhotoFightReward> configList = ConfigPhotoFightRewardByActivityId.GetConfigList(base.Id, true);
		if (configList == null)
		{
			return;
		}
		foreach (PhotoFightReward config in configList)
		{
			FightPhotoTaskData fightPhotoTaskData = new FightPhotoTaskData(config);
			this.TaskDataMap[config.Id] = fightPhotoTaskData;
			List<FightPhotoTaskData> list;
			if (!this.TabToTaskDataListMap.TryGetValue(fightPhotoTaskData.TabType, out list))
			{
				list = new List<FightPhotoTaskData>();
				this.TabToTaskDataListMap[fightPhotoTaskData.TabType] = list;
			}
			list.Add(fightPhotoTaskData);
		}
	}

	// Token: 0x060053F4 RID: 21492 RVA: 0x001BBAB8 File Offset: 0x001B9CB8
	[NullableContext(2)]
	private FightPhotoTaskData GetFightPhotoTaskData(int taskId)
	{
		FightPhotoTaskData result;
		if (!this.TaskDataMap.TryGetValue(taskId, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FightPhotograph;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "战斗拍照任务配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", taskId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x060053F5 RID: 21493 RVA: 0x001BBB08 File Offset: 0x001B9D08
	public void UpdateTaskData(IReadOnlyList<PhotoFightTargetPb> targetInfoList)
	{
		foreach (PhotoFightTargetPb photoFightTargetPb in targetInfoList)
		{
			FightPhotoTaskData fightPhotoTaskData = this.GetFightPhotoTaskData(photoFightTargetPb.Id);
			if (fightPhotoTaskData != null)
			{
				fightPhotoTaskData.Status = TaskStateResolver.TaskState[photoFightTargetPb.Status];
			}
		}
	}

	// Token: 0x060053F6 RID: 21494 RVA: 0x001BBB70 File Offset: 0x001B9D70
	public void RequestTaskReward(int tabId)
	{
		List<FightPhotoTaskData> taskDataList = this.GetTaskDataList(tabId);
		List<int> list = new List<int>();
		foreach (FightPhotoTaskData fightPhotoTaskData in taskDataList)
		{
			if (fightPhotoTaskData.IsUnclaimed)
			{
				list.Add(fightPhotoTaskData.Id);
			}
		}
		FightPhotoController.Instance.RequestTaskReward(list.ToArray());
	}

	// Token: 0x060053F7 RID: 21495 RVA: 0x001BBBE8 File Offset: 0x001B9DE8
	public void UpdateTaskRewardStatus(IReadOnlyList<PhotoFightTargetPb> taskInfoList)
	{
		foreach (PhotoFightTargetPb photoFightTargetPb in taskInfoList)
		{
			FightPhotoTaskData fightPhotoTaskData = this.GetFightPhotoTaskData(photoFightTargetPb.Id);
			if (fightPhotoTaskData != null)
			{
				fightPhotoTaskData.Status = TaskStateResolver.TaskState[photoFightTargetPb.Status];
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060053F8 RID: 21496 RVA: 0x001BBC68 File Offset: 0x001B9E68
	public bool IsTaskHasRedDot()
	{
		using (Dictionary<int, FightPhotoTaskData>.ValueCollection.Enumerator enumerator = this.TaskDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060053F9 RID: 21497 RVA: 0x001BBCC8 File Offset: 0x001B9EC8
	public bool IsTaskHasRedDotByTab(int tabId)
	{
		List<FightPhotoTaskData> list;
		if (!this.TabToTaskDataListMap.TryGetValue(tabId, out list))
		{
			list = new List<FightPhotoTaskData>();
		}
		using (List<FightPhotoTaskData>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060053FA RID: 21498 RVA: 0x001BBD34 File Offset: 0x001B9F34
	public List<FightPhotoTaskData> GetTaskDataList(int tabId)
	{
		List<FightPhotoTaskData> list;
		if (!this.TabToTaskDataListMap.TryGetValue(tabId, out list))
		{
			list = new List<FightPhotoTaskData>();
		}
		list.Sort(new Comparison<FightPhotoTaskData>(this.SortTaskData));
		return list;
	}

	// Token: 0x060053FB RID: 21499 RVA: 0x001BBD6A File Offset: 0x001B9F6A
	private int SortTaskData(FightPhotoTaskData a, FightPhotoTaskData b)
	{
		if (a.Status != b.Status)
		{
			return a.Status - b.Status;
		}
		return a.Id - b.Id;
	}

	// Token: 0x060053FC RID: 21500 RVA: 0x001BBD95 File Offset: 0x001B9F95
	public int GetTotalTaskNum()
	{
		return this.TaskDataMap.Count;
	}

	// Token: 0x060053FD RID: 21501 RVA: 0x001BBDA4 File Offset: 0x001B9FA4
	public int GetFinishedTaskNum()
	{
		int num = 0;
		using (Dictionary<int, FightPhotoTaskData>.ValueCollection.Enumerator enumerator = this.TaskDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsFinished)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060053FE RID: 21502 RVA: 0x001BBE04 File Offset: 0x001BA004
	public List<PhotoFightRewardTab> GetFightPhotoTaskTabList()
	{
		if (this.FightPhotoTaskTabList.Count == 0)
		{
			IReadOnlyList<PhotoFightRewardTab> configList = ConfigPhotoFightRewardTabByActivityId.GetConfigList(base.Id, true);
			if (configList != null)
			{
				this.FightPhotoTaskTabList = new List<PhotoFightRewardTab>(configList);
			}
		}
		return this.FightPhotoTaskTabList;
	}

	// Token: 0x060053FF RID: 21503 RVA: 0x001BBE40 File Offset: 0x001BA040
	[NullableContext(2)]
	public FightPhotoLevelData GetCurrentLevelData(bool isNeedLog = true)
	{
		if (this.CurrentLevelId != 0)
		{
			return this.GetLevelData(this.CurrentLevelId);
		}
		if (FightPhotoController.Instance.CheckInFightPhotoDungeon())
		{
			PhotoFightActivity? config = ConfigPhotoFightActivityByInstId.GetConfig(CreatureModel.Instance.GetInstanceId(), true);
			if (config != null)
			{
				this.CurrentLevelId = config.Value.Id;
			}
		}
		if (this.CurrentLevelId == 0)
		{
			if (isNeedLog)
			{
				Log.Instance.Error(ELogModule.FightPhotograph, ELogAuthor.CXJ, "当前不存在正在进行的战斗拍照关卡", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return null;
		}
		return this.GetLevelData(this.CurrentLevelId);
	}

	// Token: 0x06005400 RID: 21504 RVA: 0x001BBED5 File Offset: 0x001BA0D5
	public int GetCurrentLevelId()
	{
		return this.CurrentLevelId;
	}

	// Token: 0x06005401 RID: 21505 RVA: 0x001BBEDD File Offset: 0x001BA0DD
	public void SetCurrentLevelId(int id)
	{
		this.CurrentLevelId = id;
	}

	// Token: 0x17000B0A RID: 2826
	// (get) Token: 0x06005402 RID: 21506 RVA: 0x001BBEE6 File Offset: 0x001BA0E6
	// (set) Token: 0x06005403 RID: 21507 RVA: 0x001BBEEE File Offset: 0x001BA0EE
	public bool IsNeedShowFightPhotoMainView
	{
		get
		{
			return this.NeedShowFightPhotoMainView;
		}
		set
		{
			this.NeedShowFightPhotoMainView = value;
		}
	}

	// Token: 0x06005404 RID: 21508 RVA: 0x001BBEF8 File Offset: 0x001BA0F8
	protected override void OnInit(ActivityData data)
	{
		PhotoFightActivityPb photoFightActivityData = data.PhotoFightActivityData;
		if (photoFightActivityData == null)
		{
			Log.Instance.Error(ELogModule.FightPhotograph, ELogAuthor.CXJ, "PhotoFightActivityData未初始化 无效activityInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.InitLevelGroupData();
		this.InitTaskData();
		this.UpdateLevelGroupData(photoFightActivityData.PhotoFightLevelGroupInfo);
		this.UpdateTaskData(photoFightActivityData.Targets);
	}

	// Token: 0x06005405 RID: 21509 RVA: 0x001BBF53 File Offset: 0x001BA153
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckRedDot();
	}

	// Token: 0x06005406 RID: 21510 RVA: 0x001BBF5B File Offset: 0x001BA15B
	public bool CheckRedDot()
	{
		return base.IsUnLock() && base.GetPreGuideQuestFinishState() && (this.IsTaskHasRedDot() || this.IsLevelHasRedDot());
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x001BBF84 File Offset: 0x001BA184
	protected override bool GetExDataFinishShowState()
	{
		using (List<FightPhotoLevelGroupData>.Enumerator enumerator = this.LevelGroupDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsFinished)
				{
					return false;
				}
			}
		}
		using (Dictionary<int, FightPhotoTaskData>.ValueCollection.Enumerator enumerator2 = this.TaskDataMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (!enumerator2.Current.IsFinished)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x04003AD6 RID: 15062
	private readonly Dictionary<int, FightPhotoLevelGroupData> LevelGroupDataMap = new Dictionary<int, FightPhotoLevelGroupData>();

	// Token: 0x04003AD7 RID: 15063
	private readonly Dictionary<int, FightPhotoLevelData> LevelDataMap = new Dictionary<int, FightPhotoLevelData>();

	// Token: 0x04003AD8 RID: 15064
	private readonly List<FightPhotoLevelGroupData> LevelGroupDataList = new List<FightPhotoLevelGroupData>();

	// Token: 0x04003AD9 RID: 15065
	public bool IsNeedShowTip;

	// Token: 0x04003ADA RID: 15066
	private readonly Dictionary<int, FightPhotoTaskData> TaskDataMap = new Dictionary<int, FightPhotoTaskData>();

	// Token: 0x04003ADB RID: 15067
	private readonly Dictionary<int, List<FightPhotoTaskData>> TabToTaskDataListMap = new Dictionary<int, List<FightPhotoTaskData>>();

	// Token: 0x04003ADC RID: 15068
	private List<PhotoFightRewardTab> FightPhotoTaskTabList = new List<PhotoFightRewardTab>();

	// Token: 0x04003ADD RID: 15069
	private int CurrentLevelId;

	// Token: 0x04003ADE RID: 15070
	private bool NeedShowFightPhotoMainView;
}
