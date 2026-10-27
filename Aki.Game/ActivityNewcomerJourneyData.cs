using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using Google.Protobuf.Collections;

// Token: 0x020013A0 RID: 5024
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewcomerJourneyData : ActivityBaseData
{
	// Token: 0x06008D10 RID: 36112 RVA: 0x001E4478 File Offset: 0x001E2678
	protected override void PhraseEx(ActivityData data)
	{
		if (data.NewbieAdventureV2Pb == null)
		{
			return;
		}
		this.ChapterDataMap.Clear();
		foreach (NewbieAdventureV2ChapterPb newbieAdventureV2ChapterPb in data.NewbieAdventureV2Pb.Chapter)
		{
			NewcomerJourneyChapterData newcomerJourneyChapterData = new NewcomerJourneyChapterData(newbieAdventureV2ChapterPb.Id);
			List<NewcomerJourneyTaskData> list = new List<NewcomerJourneyTaskData>();
			newcomerJourneyChapterData.TaskDataList = list;
			newcomerJourneyChapterData.ChapterId = newbieAdventureV2ChapterPb.Id;
			newcomerJourneyChapterData.Data = newbieAdventureV2ChapterPb;
			this.ChapterDataMap[newbieAdventureV2ChapterPb.Id] = newcomerJourneyChapterData;
			Dictionary<int, NewcomerJourneyTaskData> dictionary = new Dictionary<int, NewcomerJourneyTaskData>();
			foreach (ConditionTask conditionTask in newbieAdventureV2ChapterPb.Task)
			{
				NewcomerJourneyTaskData newcomerJourneyTaskData = new NewcomerJourneyTaskData(conditionTask.Id);
				newcomerJourneyTaskData.Config = ActivityNewcomerJourneyConfig.Instance.GetTaskById(conditionTask.Id);
				newcomerJourneyTaskData.TaskData = conditionTask;
				newcomerJourneyTaskData.ChapterId = newbieAdventureV2ChapterPb.Id;
				list.Add(newcomerJourneyTaskData);
				dictionary[conditionTask.Id] = newcomerJourneyTaskData;
			}
			newcomerJourneyChapterData.TaskDataMap = dictionary;
			AdventureTaskChapterV2? chapterById = ActivityNewcomerJourneyConfig.Instance.GetChapterById(newbieAdventureV2ChapterPb.Id);
			if (chapterById != null && chapterById.Value.RolesLength > 0)
			{
				this.ChooseRoleChapterId = chapterById.Value.Id;
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
	}

	// Token: 0x06008D11 RID: 36113 RVA: 0x001E4644 File Offset: 0x001E2844
	public override bool GetExDataRedPointShowState()
	{
		foreach (int chapterId in this.ChapterDataMap.Keys)
		{
			if (this.GetChapterHasReward(chapterId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008D12 RID: 36114 RVA: 0x001E46A8 File Offset: 0x001E28A8
	public void UpdateChapterData(List<NewbieAdventureV2ChapterPb> dataList)
	{
		foreach (NewbieAdventureV2ChapterPb newbieAdventureV2ChapterPb in dataList)
		{
			NewcomerJourneyChapterData newcomerJourneyChapterData;
			if (this.ChapterDataMap.TryGetValue(newbieAdventureV2ChapterPb.Id, out newcomerJourneyChapterData) && newcomerJourneyChapterData.TaskDataMap != null)
			{
				Dictionary<int, NewcomerJourneyTaskData> taskDataMap = newcomerJourneyChapterData.TaskDataMap;
				RepeatedField<ConditionTask> task = newbieAdventureV2ChapterPb.Task;
				if (task != null)
				{
					foreach (ConditionTask conditionTask in task)
					{
						NewcomerJourneyTaskData newcomerJourneyTaskData;
						if (taskDataMap.TryGetValue(conditionTask.Id, out newcomerJourneyTaskData))
						{
							newcomerJourneyTaskData.TaskData = conditionTask;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D13 RID: 36115 RVA: 0x001E4774 File Offset: 0x001E2974
	public List<int> GetPreviewCharacterList()
	{
		if (this.PreviewCharacterList == null || this.PreviewCharacterList.Count <= 0)
		{
			this.PreviewCharacterList = new List<int>();
			AdventureTaskChapterV2? chapterById = ActivityNewcomerJourneyConfig.Instance.GetChapterById(this.ChooseRoleChapterId);
			if (chapterById != null && chapterById.Value.RolesLength > 0)
			{
				foreach (int id in chapterById.Value.GetRolesArray())
				{
					AdventureRole? roleById = ActivityNewcomerJourneyConfig.Instance.GetRoleById(id);
					this.PreviewCharacterList.Add(roleById.Value.TrialRoleId);
				}
			}
		}
		return this.PreviewCharacterList;
	}

	// Token: 0x06008D14 RID: 36116 RVA: 0x001E4824 File Offset: 0x001E2A24
	public bool GetCanGetCharacter()
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		if (!this.ChapterDataMap.TryGetValue(this.ChooseRoleChapterId, out newcomerJourneyChapterData))
		{
			return false;
		}
		int chapterCompleteNum = this.GetChapterCompleteNum(this.ChooseRoleChapterId);
		AdventureTaskChapterV2? chapterById = ActivityNewcomerJourneyConfig.Instance.GetChapterById(this.ChooseRoleChapterId);
		return chapterById != null && chapterById.Value.RewardUnlockCount <= chapterCompleteNum && !newcomerJourneyChapterData.Data.RewardRoleId;
	}

	// Token: 0x06008D15 RID: 36117 RVA: 0x001E4894 File Offset: 0x001E2A94
	public bool GetCharacterHasGet()
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		return this.ChapterDataMap.TryGetValue(this.ChooseRoleChapterId, out newcomerJourneyChapterData) && newcomerJourneyChapterData.Data.RewardRoleId;
	}

	// Token: 0x06008D16 RID: 36118 RVA: 0x001E48C4 File Offset: 0x001E2AC4
	public bool GetChapterCanGetReward(int chapterId)
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		if (!this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData))
		{
			return false;
		}
		int chapterCompleteNum = this.GetChapterCompleteNum(chapterId);
		AdventureTaskChapterV2? chapterById = ActivityNewcomerJourneyConfig.Instance.GetChapterById(chapterId);
		return chapterById != null && chapterById.Value.RewardUnlockCount <= chapterCompleteNum && !newcomerJourneyChapterData.Data.RewardDrop && !this.GetChapterIsLock(chapterId);
	}

	// Token: 0x06008D17 RID: 36119 RVA: 0x001E4934 File Offset: 0x001E2B34
	public bool GetChapterRewardHasGet(int chapterId)
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		return this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData) && newcomerJourneyChapterData.Data.RewardDrop;
	}

	// Token: 0x06008D18 RID: 36120 RVA: 0x001E4960 File Offset: 0x001E2B60
	public bool GetChapterHasReward(int chapterId)
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		if (!this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData))
		{
			return false;
		}
		if (this.GetChapterIsLock(chapterId))
		{
			return false;
		}
		if (this.GetChapterCanGetReward(chapterId))
		{
			return true;
		}
		bool result = false;
		using (List<NewcomerJourneyTaskData>.Enumerator enumerator = this.GetChapterTaskList(chapterId).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.TaskData.Status == ConditionTaskState.ConditionTaskFinish)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06008D19 RID: 36121 RVA: 0x001E49E8 File Offset: 0x001E2BE8
	public List<TItem> GetChapterRewardList(int chapterId)
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		if (!this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData))
		{
			return new List<TItem>();
		}
		AdventureTaskChapterV2? chapterById = ActivityNewcomerJourneyConfig.Instance.GetChapterById(newcomerJourneyChapterData.Data.Id);
		Dictionary<int, int> dropShowInfo = AdventureGuideConfig.Instance.GetDropShowInfo(chapterById.Value.DropId);
		List<TItem> list = new List<TItem>();
		foreach (int num in dropShowInfo.Keys)
		{
			TItem item = new TItem(new InventoryDefine.GetItemData(num, 0), dropShowInfo[num]);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06008D1A RID: 36122 RVA: 0x001E4AA4 File Offset: 0x001E2CA4
	public List<NewcomerJourneyTaskData> GetChapterTaskList(int chapterId)
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		if (!this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData))
		{
			return new List<NewcomerJourneyTaskData>();
		}
		List<NewcomerJourneyTaskData> taskDataList = newcomerJourneyChapterData.TaskDataList;
		taskDataList.Sort(delegate(NewcomerJourneyTaskData a, NewcomerJourneyTaskData b)
		{
			int num = ActivityNewcomerJourneyData.<GetChapterTaskList>g__GetPriority|13_0(a.TaskData.Status);
			int num2 = ActivityNewcomerJourneyData.<GetChapterTaskList>g__GetPriority|13_0(b.TaskData.Status);
			if (num != num2)
			{
				return num - num2;
			}
			return a.TaskData.Id - b.TaskData.Id;
		});
		return taskDataList;
	}

	// Token: 0x06008D1B RID: 36123 RVA: 0x001E4AF4 File Offset: 0x001E2CF4
	public List<AdventureTaskChapterV2> GetChapterList()
	{
		List<AdventureTaskChapterV2> list = new List<AdventureTaskChapterV2>();
		foreach (NewcomerJourneyChapterData newcomerJourneyChapterData in this.ChapterDataMap.Values)
		{
			list.Add(ActivityNewcomerJourneyConfig.Instance.GetChapterById(newcomerJourneyChapterData.Data.Id).Value);
		}
		list.Sort((AdventureTaskChapterV2 a, AdventureTaskChapterV2 b) => a.Sort - b.Sort);
		return list;
	}

	// Token: 0x06008D1C RID: 36124 RVA: 0x001E4B94 File Offset: 0x001E2D94
	public int GetChapterCompleteNum(int chapterId)
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		if (!this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData) || newcomerJourneyChapterData.Data.Task == null)
		{
			return 0;
		}
		return newcomerJourneyChapterData.Data.Task.Count((ConditionTask task) => task.Status >= ConditionTaskState.ConditionTaskTaken);
	}

	// Token: 0x06008D1D RID: 36125 RVA: 0x001E4BF0 File Offset: 0x001E2DF0
	public bool GetChapterTaskAllComplete(int chapterId)
	{
		int chapterCompleteNum = this.GetChapterCompleteNum(chapterId);
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		return this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData) && newcomerJourneyChapterData.Data.Task.Count <= chapterCompleteNum && !this.GetChapterIsLock(chapterId);
	}

	// Token: 0x06008D1E RID: 36126 RVA: 0x001E4C3C File Offset: 0x001E2E3C
	public bool GetChapterIsLock(int chapterId)
	{
		AdventureTaskChapterV2? chapterById = ActivityNewcomerJourneyConfig.Instance.GetChapterById(chapterId);
		if (chapterById == null)
		{
			return true;
		}
		if (chapterById.Value.Sort == 1)
		{
			return false;
		}
		AdventureTaskChapterV2? adventureTaskChapterV = null;
		foreach (NewcomerJourneyChapterData newcomerJourneyChapterData in this.ChapterDataMap.Values)
		{
			AdventureTaskChapterV2? chapterById2 = ActivityNewcomerJourneyConfig.Instance.GetChapterById(newcomerJourneyChapterData.Data.Id);
			if (chapterById2 != null && chapterById2.Value.Sort == chapterById.Value.Sort - 1)
			{
				adventureTaskChapterV = chapterById2;
				break;
			}
		}
		return adventureTaskChapterV == null || this.GetChapterCompleteNum(adventureTaskChapterV.Value.Id) < chapterById.Value.LevelUnlockCount;
	}

	// Token: 0x06008D1F RID: 36127 RVA: 0x001E4D3C File Offset: 0x001E2F3C
	public int GetLastUnLockChapterIndex()
	{
		List<AdventureTaskChapterV2> chapterList = this.GetChapterList();
		if (chapterList == null)
		{
			return -1;
		}
		int num = 1;
		foreach (AdventureTaskChapterV2 adventureTaskChapterV in chapterList)
		{
			if (!this.GetChapterIsLock(adventureTaskChapterV.Id) && num < adventureTaskChapterV.Sort)
			{
				num = adventureTaskChapterV.Sort;
			}
		}
		return num;
	}

	// Token: 0x06008D20 RID: 36128 RVA: 0x001E4DB4 File Offset: 0x001E2FB4
	protected override bool GetExDataFinishShowState()
	{
		bool flag = true;
		foreach (int chapterId in this.ChapterDataMap.Keys)
		{
			if (!this.GetChapterRewardHasGet(chapterId) || !this.GetChapterTaskAllComplete(chapterId))
			{
				flag = false;
				break;
			}
		}
		return flag && this.GetCharacterHasGet();
	}

	// Token: 0x06008D22 RID: 36130 RVA: 0x001E4E42 File Offset: 0x001E3042
	[CompilerGenerated]
	internal static int <GetChapterTaskList>g__GetPriority|13_0(ConditionTaskState status)
	{
		switch (status)
		{
		case ConditionTaskState.ConditionTaskRunning:
			return 1;
		case ConditionTaskState.ConditionTaskFinish:
			return 0;
		}
		return 2;
	}

	// Token: 0x04003E83 RID: 16003
	private readonly Dictionary<int, NewcomerJourneyChapterData> ChapterDataMap = new Dictionary<int, NewcomerJourneyChapterData>();

	// Token: 0x04003E84 RID: 16004
	[Nullable(2)]
	private List<int> PreviewCharacterList;

	// Token: 0x04003E85 RID: 16005
	public int ChooseRoleChapterId = -1;
}
