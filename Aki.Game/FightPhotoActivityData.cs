using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001269 RID: 4713
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoActivityData : ActivityBaseData
{
	// Token: 0x0600804F RID: 32847 RVA: 0x001B27D4 File Offset: 0x001B09D4
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

	// Token: 0x06008050 RID: 32848 RVA: 0x001B2924 File Offset: 0x001B0B24
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

	// Token: 0x06008051 RID: 32849 RVA: 0x001B2974 File Offset: 0x001B0B74
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

	// Token: 0x06008052 RID: 32850 RVA: 0x001B29C4 File Offset: 0x001B0BC4
	[NullableContext(2)]
	public FightPhotoLevelData GetLevelDataById(int levelId)
	{
		FightPhotoLevelData result;
		this.LevelDataMap.TryGetValue(levelId, out result);
		return result;
	}

	// Token: 0x06008053 RID: 32851 RVA: 0x001B29E4 File Offset: 0x001B0BE4
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

	// Token: 0x06008054 RID: 32852 RVA: 0x001B2AB0 File Offset: 0x001B0CB0
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

	// Token: 0x06008055 RID: 32853 RVA: 0x001B2B24 File Offset: 0x001B0D24
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
				levelData.SetRoleIdList(photoFightLevelPb.Roles.ToList<int>());
			}
		}
	}

	// Token: 0x06008056 RID: 32854 RVA: 0x001B2BC4 File Offset: 0x001B0DC4
	public int GetSelectLevelGroupDataIndex()
	{
		FightPhotoLevelData currentLevel = this.GetCurrentLevelData(false);
		if (currentLevel != null)
		{
			return this.LevelGroupDataList.FindIndex((FightPhotoLevelGroupData data) => data.Id == currentLevel.LevelGroupData.Id);
		}
		return this.GetFirstUnFinishedLevelGroupDataIndex();
	}

	// Token: 0x06008057 RID: 32855 RVA: 0x001B2C0C File Offset: 0x001B0E0C
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

	// Token: 0x06008058 RID: 32856 RVA: 0x001B2C6C File Offset: 0x001B0E6C
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

	// Token: 0x06008059 RID: 32857 RVA: 0x001B2CCC File Offset: 0x001B0ECC
	public List<FightPhotoLevelGroupData> GetLevelGroupDataList()
	{
		return this.LevelGroupDataList;
	}

	// Token: 0x0600805A RID: 32858 RVA: 0x001B2CD4 File Offset: 0x001B0ED4
	public int GetTotalLevelNum()
	{
		return this.LevelGroupDataMap.Count;
	}

	// Token: 0x0600805B RID: 32859 RVA: 0x001B2CE4 File Offset: 0x001B0EE4
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

	// Token: 0x0600805C RID: 32860 RVA: 0x001B2D44 File Offset: 0x001B0F44
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

	// Token: 0x0600805D RID: 32861 RVA: 0x001B2DE8 File Offset: 0x001B0FE8
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

	// Token: 0x0600805E RID: 32862 RVA: 0x001B2E38 File Offset: 0x001B1038
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

	// Token: 0x0600805F RID: 32863 RVA: 0x001B2EA0 File Offset: 0x001B10A0
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

	// Token: 0x06008060 RID: 32864 RVA: 0x001B2F18 File Offset: 0x001B1118
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

	// Token: 0x06008061 RID: 32865 RVA: 0x001B2F98 File Offset: 0x001B1198
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

	// Token: 0x06008062 RID: 32866 RVA: 0x001B2FF8 File Offset: 0x001B11F8
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

	// Token: 0x06008063 RID: 32867 RVA: 0x001B3064 File Offset: 0x001B1264
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

	// Token: 0x06008064 RID: 32868 RVA: 0x001B309A File Offset: 0x001B129A
	private int SortTaskData(FightPhotoTaskData a, FightPhotoTaskData b)
	{
		if (a.Status != b.Status)
		{
			return a.Status - b.Status;
		}
		return a.Id - b.Id;
	}

	// Token: 0x06008065 RID: 32869 RVA: 0x001B30C5 File Offset: 0x001B12C5
	public int GetTotalTaskNum()
	{
		return this.TaskDataMap.Count;
	}

	// Token: 0x06008066 RID: 32870 RVA: 0x001B30D4 File Offset: 0x001B12D4
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

	// Token: 0x06008067 RID: 32871 RVA: 0x001B3134 File Offset: 0x001B1334
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

	// Token: 0x06008068 RID: 32872 RVA: 0x001B3170 File Offset: 0x001B1370
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

	// Token: 0x06008069 RID: 32873 RVA: 0x001B3205 File Offset: 0x001B1405
	public int GetCurrentLevelId()
	{
		return this.CurrentLevelId;
	}

	// Token: 0x0600806A RID: 32874 RVA: 0x001B320D File Offset: 0x001B140D
	public void SetCurrentLevelId(int id)
	{
		this.CurrentLevelId = id;
	}

	// Token: 0x17000AEA RID: 2794
	// (get) Token: 0x0600806B RID: 32875 RVA: 0x001B3216 File Offset: 0x001B1416
	// (set) Token: 0x0600806C RID: 32876 RVA: 0x001B321E File Offset: 0x001B141E
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

	// Token: 0x0600806D RID: 32877 RVA: 0x001B3228 File Offset: 0x001B1428
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

	// Token: 0x0600806E RID: 32878 RVA: 0x001B3283 File Offset: 0x001B1483
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckRedDot();
	}

	// Token: 0x0600806F RID: 32879 RVA: 0x001B328B File Offset: 0x001B148B
	public bool CheckRedDot()
	{
		return base.IsUnLock() && base.GetPreGuideQuestFinishState() && (this.IsTaskHasRedDot() || this.IsLevelHasRedDot());
	}

	// Token: 0x06008070 RID: 32880 RVA: 0x001B32B4 File Offset: 0x001B14B4
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

	// Token: 0x04003A3E RID: 14910
	private readonly Dictionary<int, FightPhotoLevelGroupData> LevelGroupDataMap = new Dictionary<int, FightPhotoLevelGroupData>();

	// Token: 0x04003A3F RID: 14911
	private readonly Dictionary<int, FightPhotoLevelData> LevelDataMap = new Dictionary<int, FightPhotoLevelData>();

	// Token: 0x04003A40 RID: 14912
	private readonly List<FightPhotoLevelGroupData> LevelGroupDataList = new List<FightPhotoLevelGroupData>();

	// Token: 0x04003A41 RID: 14913
	public bool IsNeedShowTip;

	// Token: 0x04003A42 RID: 14914
	private readonly Dictionary<int, FightPhotoTaskData> TaskDataMap = new Dictionary<int, FightPhotoTaskData>();

	// Token: 0x04003A43 RID: 14915
	private readonly Dictionary<int, List<FightPhotoTaskData>> TabToTaskDataListMap = new Dictionary<int, List<FightPhotoTaskData>>();

	// Token: 0x04003A44 RID: 14916
	private List<PhotoFightRewardTab> FightPhotoTaskTabList = new List<PhotoFightRewardTab>();

	// Token: 0x04003A45 RID: 14917
	private int CurrentLevelId;

	// Token: 0x04003A46 RID: 14918
	private bool NeedShowFightPhotoMainView;
}
