using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using Google.Protobuf.Collections;

// Token: 0x02000854 RID: 2132
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewcomerJourneyData : ActivityBaseData
{
	// Token: 0x060060A6 RID: 24742 RVA: 0x001ED094 File Offset: 0x001EB294
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

	// Token: 0x060060A7 RID: 24743 RVA: 0x001ED260 File Offset: 0x001EB460
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

	// Token: 0x060060A8 RID: 24744 RVA: 0x001ED2C4 File Offset: 0x001EB4C4
	public void UpdateChapterData(IEnumerable<NewbieAdventureV2ChapterPb> dataList)
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

	// Token: 0x060060A9 RID: 24745 RVA: 0x001ED38C File Offset: 0x001EB58C
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

	// Token: 0x060060AA RID: 24746 RVA: 0x001ED43C File Offset: 0x001EB63C
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

	// Token: 0x060060AB RID: 24747 RVA: 0x001ED4AC File Offset: 0x001EB6AC
	public bool GetCharacterHasGet()
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		return this.ChapterDataMap.TryGetValue(this.ChooseRoleChapterId, out newcomerJourneyChapterData) && newcomerJourneyChapterData.Data.RewardRoleId;
	}

	// Token: 0x060060AC RID: 24748 RVA: 0x001ED4DC File Offset: 0x001EB6DC
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

	// Token: 0x060060AD RID: 24749 RVA: 0x001ED54C File Offset: 0x001EB74C
	public bool GetChapterRewardHasGet(int chapterId)
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		return this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData) && newcomerJourneyChapterData.Data.RewardDrop;
	}

	// Token: 0x060060AE RID: 24750 RVA: 0x001ED578 File Offset: 0x001EB778
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

	// Token: 0x060060AF RID: 24751 RVA: 0x001ED600 File Offset: 0x001EB800
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

	// Token: 0x060060B0 RID: 24752 RVA: 0x001ED6BC File Offset: 0x001EB8BC
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

	// Token: 0x060060B1 RID: 24753 RVA: 0x001ED70C File Offset: 0x001EB90C
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

	// Token: 0x060060B2 RID: 24754 RVA: 0x001ED7AC File Offset: 0x001EB9AC
	public int GetChapterCompleteNum(int chapterId)
	{
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		if (!this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData) || newcomerJourneyChapterData.Data.Task == null)
		{
			return 0;
		}
		int num = 0;
		using (IEnumerator<ConditionTask> enumerator = newcomerJourneyChapterData.Data.Task.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status >= ConditionTaskState.ConditionTaskTaken)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060060B3 RID: 24755 RVA: 0x001ED824 File Offset: 0x001EBA24
	public bool GetChapterTaskAllComplete(int chapterId)
	{
		int chapterCompleteNum = this.GetChapterCompleteNum(chapterId);
		NewcomerJourneyChapterData newcomerJourneyChapterData;
		return this.ChapterDataMap.TryGetValue(chapterId, out newcomerJourneyChapterData) && newcomerJourneyChapterData.Data.Task.Count <= chapterCompleteNum && !this.GetChapterIsLock(chapterId);
	}

	// Token: 0x060060B4 RID: 24756 RVA: 0x001ED870 File Offset: 0x001EBA70
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

	// Token: 0x060060B5 RID: 24757 RVA: 0x001ED970 File Offset: 0x001EBB70
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

	// Token: 0x060060B6 RID: 24758 RVA: 0x001ED9E8 File Offset: 0x001EBBE8
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

	// Token: 0x060060B8 RID: 24760 RVA: 0x001EDA76 File Offset: 0x001EBC76
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

	// Token: 0x04003F1B RID: 16155
	private readonly Dictionary<int, NewcomerJourneyChapterData> ChapterDataMap = new Dictionary<int, NewcomerJourneyChapterData>();

	// Token: 0x04003F1C RID: 16156
	[Nullable(2)]
	private List<int> PreviewCharacterList;

	// Token: 0x04003F1D RID: 16157
	public int ChooseRoleChapterId = -1;
}
