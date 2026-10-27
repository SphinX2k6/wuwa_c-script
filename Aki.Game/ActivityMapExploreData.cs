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

// Token: 0x020012C5 RID: 4805
[NullableContext(1)]
[Nullable(0)]
public class ActivityMapExploreData : ActivityBaseData
{
	// Token: 0x06008403 RID: 33795 RVA: 0x001C1A57 File Offset: 0x001BFC57
	public override bool GetExDataRedPointShowState()
	{
		return this.IsFirstUnlockState(EActivityExploreFirstUnlockState.Set) || this.IsCanGetReward();
	}

	// Token: 0x06008404 RID: 33796 RVA: 0x001C1A6C File Offset: 0x001BFC6C
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

	// Token: 0x06008405 RID: 33797 RVA: 0x001C1AA8 File Offset: 0x001BFCA8
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

	// Token: 0x06008406 RID: 33798 RVA: 0x001C1AE1 File Offset: 0x001BFCE1
	protected override void OnInit(ActivityData data)
	{
		ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.ExploreActivityFirstUnlock, EClientStorageSystemIdType.ExploreActivityFirstUnlock);
	}

	// Token: 0x06008407 RID: 33799 RVA: 0x001C1AF0 File Offset: 0x001BFCF0
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

	// Token: 0x06008408 RID: 33800 RVA: 0x001C1B30 File Offset: 0x001BFD30
	public void SetFirstUnlockState(EActivityExploreFirstUnlockState value)
	{
		ServerStorageNumber serverStorageNumber = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ExploreActivityFirstUnlock) as ServerStorageNumber;
		if (serverStorageNumber != null)
		{
			serverStorageNumber.Set(new int?((int)value));
		}
	}

	// Token: 0x06008409 RID: 33801 RVA: 0x001C1B5E File Offset: 0x001BFD5E
	public bool IsFirstUnlockState(EActivityExploreFirstUnlockState state)
	{
		return this.GetFirstUnlockState() == state;
	}

	// Token: 0x0600840A RID: 33802 RVA: 0x001C1B6C File Offset: 0x001BFD6C
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

	// Token: 0x0600840B RID: 33803 RVA: 0x001C1D20 File Offset: 0x001BFF20
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

	// Token: 0x0600840C RID: 33804 RVA: 0x001C1DC4 File Offset: 0x001BFFC4
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

	// Token: 0x04003B63 RID: 15203
	private readonly int ItemId = 3;

	// Token: 0x04003B64 RID: 15204
	public readonly List<IActivitySubMapExploreItemData> TaskList = new List<IActivitySubMapExploreItemData>();
}
