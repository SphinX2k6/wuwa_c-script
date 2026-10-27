using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using Google.Protobuf.Collections;

// Token: 0x02001198 RID: 4504
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalData : ActivityBaseData
{
	// Token: 0x17000A3D RID: 2621
	// (get) Token: 0x06007744 RID: 30532 RVA: 0x0018DF05 File Offset: 0x0018C105
	public Dictionary<int, List<ActivityTask>> TaskDataMap { get; } = new Dictionary<int, List<ActivityTask>>();

	// Token: 0x17000A3E RID: 2622
	// (get) Token: 0x06007745 RID: 30533 RVA: 0x0018DF0D File Offset: 0x0018C10D
	public Dictionary<int, List<int>> JumpTaskMap { get; } = new Dictionary<int, List<int>>();

	// Token: 0x17000A3F RID: 2623
	// (get) Token: 0x06007746 RID: 30534 RVA: 0x0018DF15 File Offset: 0x0018C115
	public List<int> GachaId { get; } = new List<int>();

	// Token: 0x17000A40 RID: 2624
	// (get) Token: 0x06007747 RID: 30535 RVA: 0x0018DF1D File Offset: 0x0018C11D
	public List<int> GiftId { get; } = new List<int>();

	// Token: 0x06007748 RID: 30536 RVA: 0x0018DF28 File Offset: 0x0018C128
	protected override void PhraseEx(ActivityData data)
	{
		this.TaskDataMap.Clear();
		NewbieCarnivalData newbieCarnivalData = data.NewbieCarnivalData;
		RepeatedField<ActivityTask> repeatedField;
		if (newbieCarnivalData == null)
		{
			repeatedField = null;
		}
		else
		{
			Aki.Protocol.ActivityTaskData activityTaskData = newbieCarnivalData.ActivityTaskData;
			repeatedField = ((activityTaskData != null) ? activityTaskData.ActivityTasks : null);
		}
		RepeatedField<ActivityTask> repeatedField2 = repeatedField;
		if (repeatedField2 != null)
		{
			foreach (ActivityTask activityTask in repeatedField2)
			{
				NewbieCarnivalTask? newbieCarnivalTask = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalTask(activityTask.Id);
				if (newbieCarnivalTask != null)
				{
					List<ActivityTask> list;
					if (!this.TaskDataMap.TryGetValue(newbieCarnivalTask.Value.TaskType, out list) || list == null)
					{
						list = new List<ActivityTask>();
					}
					list.Add(activityTask);
					this.TaskDataMap[newbieCarnivalTask.Value.TaskType] = list;
				}
			}
		}
		this.JumpTaskMap.Clear();
		NewbieCarnivalData newbieCarnivalData2 = data.NewbieCarnivalData;
		RepeatedField<JumpTaskCondInfo> repeatedField3 = (newbieCarnivalData2 != null) ? newbieCarnivalData2.JumpTaskCondInfos : null;
		if (repeatedField3 != null)
		{
			foreach (JumpTaskCondInfo jumpTaskCondInfo in repeatedField3)
			{
				this.JumpTaskMap[jumpTaskCondInfo.JumpTaskId] = new List<int>(jumpTaskCondInfo.ConditionGroupIds);
			}
		}
		this.ChoseRoleId = ((data.NewbieCarnivalData != null) ? data.NewbieCarnivalData.RoleId : 0);
		NewbieCarnivalParam value = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalParam(data.Id).Value;
		this.ItemId = value.ItemId;
		this.GachaId.Clear();
		this.GachaId.AddRange(value.GetGachaIdsArray().ToArray<int>());
		this.GiftId.Clear();
		this.GiftId.AddRange(value.GetPayGiftsArray());
		this.GetRoleTaskId = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalTaskByTaskType(0).Value.TaskId;
	}

	// Token: 0x06007749 RID: 30537 RVA: 0x0018E120 File Offset: 0x0018C320
	[NullableContext(0)]
	public ValueTuple<int, int> GetProgress(int typeId)
	{
		List<ActivityTask> list;
		if (!this.TaskDataMap.TryGetValue(typeId, out list) || list == null)
		{
			return new ValueTuple<int, int>(0, 0);
		}
		int count = list.Count;
		int num = 0;
		using (List<ActivityTask>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == ActivityTaskState.ActivityTaskTaken)
				{
					num++;
				}
			}
		}
		return new ValueTuple<int, int>(num, count);
	}

	// Token: 0x0600774A RID: 30538 RVA: 0x0018E1A0 File Offset: 0x0018C3A0
	[NullableContext(2)]
	public ActivityTask GetTaskDataById(int taskId)
	{
		foreach (KeyValuePair<int, List<ActivityTask>> keyValuePair in this.TaskDataMap)
		{
			foreach (ActivityTask activityTask in keyValuePair.Value)
			{
				if (activityTask.Id == taskId)
				{
					return activityTask;
				}
			}
		}
		return null;
	}

	// Token: 0x0600774B RID: 30539 RVA: 0x0018E23C File Offset: 0x0018C43C
	public List<int> GetTaskIdListByTypeId(int typeId)
	{
		List<int> list = new List<int>();
		List<ActivityTask> list2;
		if (this.TaskDataMap.TryGetValue(typeId, out list2) && list2 != null)
		{
			foreach (ActivityTask activityTask in list2)
			{
				list.Add(activityTask.Id);
			}
		}
		return list;
	}

	// Token: 0x0600774C RID: 30540 RVA: 0x0018E2AC File Offset: 0x0018C4AC
	public bool GetAnyRedDotShow()
	{
		foreach (KeyValuePair<int, List<ActivityTask>> keyValuePair in this.TaskDataMap)
		{
			using (List<ActivityTask>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.Status == ActivityTaskState.ActivityTaskFinish)
					{
						return true;
					}
				}
			}
		}
		if (FunctionModel.Instance.IsOpen(10009) && GachaModel.Instance.GachaInfoArray != null && !this.GetHaveGachaEnter())
		{
			bool gachaInfo = GachaModel.Instance.GetGachaInfo(this.GachaId[0]) != null;
			ProtoGachaInfo gachaInfo2 = GachaModel.Instance.GetGachaInfo(this.GachaId[1]);
			if (gachaInfo || gachaInfo2 != null)
			{
				return true;
			}
		}
		if (FunctionModel.Instance.IsOpen(10010) && !this.GetHaveShopEnter())
		{
			bool flag = false;
			foreach (PayShopGoods payShopGoods in PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.GiftBag, 5, true))
			{
				IRemainingData remainingData = payShopGoods.GetRemainingData();
				if (remainingData != null && remainingData.Count > 0)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return true;
			}
		}
		return this.ChoseRoleId == 0;
	}

	// Token: 0x0600774D RID: 30541 RVA: 0x0018E428 File Offset: 0x0018C628
	public bool GetAnyTaskRedDotShow()
	{
		foreach (KeyValuePair<int, List<ActivityTask>> keyValuePair in this.TaskDataMap)
		{
			using (List<ActivityTask>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.Status == ActivityTaskState.ActivityTaskFinish)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600774E RID: 30542 RVA: 0x0018E4C0 File Offset: 0x0018C6C0
	public bool GetTabRedDotShow(int tabIndex)
	{
		List<ActivityTask> list;
		if (!this.TaskDataMap.TryGetValue(tabIndex, out list) || list == null)
		{
			return false;
		}
		using (List<ActivityTask>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600774F RID: 30543 RVA: 0x0018E52C File Offset: 0x0018C72C
	public bool GetRoleGetTaskTabRedDotShow(int tabIndex)
	{
		List<ActivityTask> list;
		if (!this.TaskDataMap.TryGetValue(tabIndex, out list) || list == null)
		{
			return false;
		}
		using (List<ActivityTask>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
		}
		List<ActivityTask> list2;
		using (List<ActivityTask>.Enumerator enumerator = ((this.TaskDataMap.TryGetValue(0, out list2) && list2 != null) ? list2 : new List<ActivityTask>()).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
		}
		return this.ChoseRoleId == 0;
	}

	// Token: 0x06007750 RID: 30544 RVA: 0x0018E5FC File Offset: 0x0018C7FC
	public override bool GetExDataRedPointShowState()
	{
		return this.GetAnyRedDotShow();
	}

	// Token: 0x06007751 RID: 30545 RVA: 0x0018E604 File Offset: 0x0018C804
	public int GetCurrentItemCount()
	{
		if (this.ItemId == 0)
		{
			return 0;
		}
		return InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
	}

	// Token: 0x06007752 RID: 30546 RVA: 0x0018E624 File Offset: 0x0018C824
	public bool GetHaveShopEnter()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalShop, false);
		return player && player;
	}

	// Token: 0x06007753 RID: 30547 RVA: 0x0018E643 File Offset: 0x0018C843
	public void SetShopEnter()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalShop, true);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06007754 RID: 30548 RVA: 0x0018E668 File Offset: 0x0018C868
	public bool GetHaveGachaEnter()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalGacha, false);
		return player && player;
	}

	// Token: 0x06007755 RID: 30549 RVA: 0x0018E687 File Offset: 0x0018C887
	public void SetGachaEnter()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalGacha, true);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06007756 RID: 30550 RVA: 0x0018E6AC File Offset: 0x0018C8AC
	public bool GetHaveChoseRoleViewEnter()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalChoseRoleView, false);
		return player && player;
	}

	// Token: 0x06007757 RID: 30551 RVA: 0x0018E6CB File Offset: 0x0018C8CB
	public void SetChoseRoleViewEnter()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalChoseRoleView, true);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x040036B5 RID: 14005
	public int ChoseRoleId;

	// Token: 0x040036B6 RID: 14006
	public int GetRoleTaskId;

	// Token: 0x040036B7 RID: 14007
	public int ItemId;
}
