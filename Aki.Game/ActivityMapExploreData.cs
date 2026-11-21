using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

// Token: 0x02000779 RID: 1913
[NullableContext(1)]
[Nullable(0)]
public class ActivityMapExploreData : ActivityBaseData
{
	// Token: 0x0600579E RID: 22430 RVA: 0x001CA8B3 File Offset: 0x001C8AB3
	public override bool GetExDataRedPointShowState()
	{
		return this.IsFirstUnlockState(EActivityExploreFirstUnlockState.Set) || this.IsCanGetReward();
	}

	// Token: 0x0600579F RID: 22431 RVA: 0x001CA8C8 File Offset: 0x001C8AC8
	protected override bool GetExDataFinishShowState()
	{
		for (int i = 0; i < this.TaskList.Count; i++)
		{
			if (!this.TaskList[i].IsComplete)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060057A0 RID: 22432 RVA: 0x001CA904 File Offset: 0x001C8B04
	public bool IsCanGetReward()
	{
		for (int i = 0; i < this.TaskList.Count; i++)
		{
			if (this.TaskList[i].IsCanGet)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060057A1 RID: 22433 RVA: 0x001CA93D File Offset: 0x001C8B3D
	protected override void OnInit(ActivityData data)
	{
		ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.ExploreActivityFirstUnlock, EClientStorageSystemIdType.ExploreActivityFirstUnlock, true);
	}

	// Token: 0x060057A2 RID: 22434 RVA: 0x001CA94C File Offset: 0x001C8B4C
	private EActivityExploreFirstUnlockState GetFirstUnlockState()
	{
		ServerStorageNumber serverStorageNumber = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ExploreActivityFirstUnlock) as ServerStorageNumber;
		if (serverStorageNumber == null)
		{
			return EActivityExploreFirstUnlockState.None;
		}
		int? num = serverStorageNumber.Get();
		if (num == null)
		{
			return EActivityExploreFirstUnlockState.None;
		}
		return (EActivityExploreFirstUnlockState)num.Value;
	}

	// Token: 0x060057A3 RID: 22435 RVA: 0x001CA98C File Offset: 0x001C8B8C
	public void SetFirstUnlockState(EActivityExploreFirstUnlockState value)
	{
		ServerStorageNumber serverStorageNumber = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ExploreActivityFirstUnlock) as ServerStorageNumber;
		if (serverStorageNumber != null)
		{
			serverStorageNumber.Set(new int?((int)value));
		}
	}

	// Token: 0x060057A4 RID: 22436 RVA: 0x001CA9BA File Offset: 0x001C8BBA
	public bool IsFirstUnlockState(EActivityExploreFirstUnlockState state)
	{
		return this.GetFirstUnlockState() == state;
	}

	// Token: 0x060057A5 RID: 22437 RVA: 0x001CA9C8 File Offset: 0x001C8BC8
	protected override void PhraseEx(ActivityData data)
	{
		this.TaskList.Clear();
		ExploreActivityInfo exploreActivityInfo = data.ExploreActivityInfo;
		if (exploreActivityInfo == null)
		{
			return;
		}
		foreach (ExploreActivityTask exploreActivityTask in ActivityMapExploreConfig.Instance.GetExploreTaskList(data.Id))
		{
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(exploreActivityTask.DropId);
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			if (dropPackage != null)
			{
				foreach (DicIntInt dicIntInt in dropPackage.Value.DropPreviewIter())
				{
					list.Add(new ValueTuple<int, int>(dicIntInt.Key, dicIntInt.Value));
				}
			}
			this.TaskList.Add(new ActivitySubMapExploreItemData
			{
				TaskId = exploreActivityTask.TaskId,
				RewardDesc = exploreActivityTask.Desc,
				RewardItemId = ((list.Count > 0) ? list[0].Item1 : this.ItemId),
				RewardItemCount = new int?((list.Count > 0) ? list[0].Item2 : 0),
				IsComplete = false,
				IsCanGet = false,
				IsRunning = true
			});
		}
		if (this.IsFirstUnlockState(EActivityExploreFirstUnlockState.None) && base.CanPreOpen())
		{
			this.SetFirstUnlockState(EActivityExploreFirstUnlockState.Set);
		}
		this.UpdateTaskState(exploreActivityInfo.ActivityTasks);
	}

	// Token: 0x060057A6 RID: 22438 RVA: 0x001CAB7C File Offset: 0x001C8D7C
	public void UpdateTaskState(MapField<int, ActivityTaskState> stateMap)
	{
		if (stateMap == null)
		{
			return;
		}
		foreach (IActivitySubMapExploreItemData activitySubMapExploreItemData in this.TaskList)
		{
			ActivityTaskState activityTaskState;
			if (stateMap.TryGetValue(activitySubMapExploreItemData.TaskId, out activityTaskState))
			{
				activitySubMapExploreItemData.IsComplete = (activityTaskState == ActivityTaskState.ActivityTaskTaken);
				activitySubMapExploreItemData.IsCanGet = (activityTaskState == ActivityTaskState.ActivityTaskFinish);
				activitySubMapExploreItemData.IsRunning = (!activitySubMapExploreItemData.IsComplete && !activitySubMapExploreItemData.IsCanGet);
			}
		}
		this.SortTaskList();
		EventSystem.Instance.Emit(EEventName.ActivityMapExploreStateUpdate);
	}

	// Token: 0x060057A7 RID: 22439 RVA: 0x001CAC20 File Offset: 0x001C8E20
	private void SortTaskList()
	{
		this.TaskList.Sort(delegate(IActivitySubMapExploreItemData a, IActivitySubMapExploreItemData b)
		{
			if (a.IsCanGet != b.IsCanGet)
			{
				if (!a.IsCanGet)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (a.IsRunning == b.IsRunning)
				{
					return a.TaskId - b.TaskId;
				}
				if (!a.IsRunning)
				{
					return 1;
				}
				return -1;
			}
		});
	}

	// Token: 0x04003BFB RID: 15355
	private readonly int ItemId = 3;

	// Token: 0x04003BFC RID: 15356
	public readonly List<IActivitySubMapExploreItemData> TaskList = new List<IActivitySubMapExploreItemData>();
}
