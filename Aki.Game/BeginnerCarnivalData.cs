using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using Google.Protobuf.Collections;

// Token: 0x0200064C RID: 1612
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalData : ActivityBaseData
{
	// Token: 0x17000A5D RID: 2653
	// (get) Token: 0x06004ADB RID: 19163 RVA: 0x00196AED File Offset: 0x00194CED
	public Dictionary<int, List<ActivityTask>> TaskDataMap { get; } = new Dictionary<int, List<ActivityTask>>();

	// Token: 0x17000A5E RID: 2654
	// (get) Token: 0x06004ADC RID: 19164 RVA: 0x00196AF5 File Offset: 0x00194CF5
	public Dictionary<int, List<int>> JumpTaskMap { get; } = new Dictionary<int, List<int>>();

	// Token: 0x17000A5F RID: 2655
	// (get) Token: 0x06004ADD RID: 19165 RVA: 0x00196AFD File Offset: 0x00194CFD
	public List<int> GachaId { get; } = new List<int>();

	// Token: 0x17000A60 RID: 2656
	// (get) Token: 0x06004ADE RID: 19166 RVA: 0x00196B05 File Offset: 0x00194D05
	public List<int> GiftId { get; } = new List<int>();

	// Token: 0x06004ADF RID: 19167 RVA: 0x00196B10 File Offset: 0x00194D10
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
		this.GachaId.AddRange(value.GetGachaIdsArray());
		this.GiftId.Clear();
		this.GiftId.AddRange(value.GetPayGiftsArray());
		this.GetRoleTaskId = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalTaskByTaskType(0).Value.TaskId;
	}

	// Token: 0x06004AE0 RID: 19168 RVA: 0x00196D04 File Offset: 0x00194F04
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

	// Token: 0x06004AE1 RID: 19169 RVA: 0x00196D84 File Offset: 0x00194F84
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

	// Token: 0x06004AE2 RID: 19170 RVA: 0x00196E20 File Offset: 0x00195020
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

	// Token: 0x06004AE3 RID: 19171 RVA: 0x00196E90 File Offset: 0x00195090
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

	// Token: 0x06004AE4 RID: 19172 RVA: 0x0019700C File Offset: 0x0019520C
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

	// Token: 0x06004AE5 RID: 19173 RVA: 0x001970A4 File Offset: 0x001952A4
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

	// Token: 0x06004AE6 RID: 19174 RVA: 0x00197110 File Offset: 0x00195310
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

	// Token: 0x06004AE7 RID: 19175 RVA: 0x001971E0 File Offset: 0x001953E0
	public override bool GetExDataRedPointShowState()
	{
		return this.GetAnyRedDotShow();
	}

	// Token: 0x06004AE8 RID: 19176 RVA: 0x001971E8 File Offset: 0x001953E8
	public int GetCurrentItemCount()
	{
		if (this.ItemId == 0)
		{
			return 0;
		}
		return InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
	}

	// Token: 0x06004AE9 RID: 19177 RVA: 0x00197208 File Offset: 0x00195408
	public bool GetHaveShopEnter()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalShop, false);
		return player && player;
	}

	// Token: 0x06004AEA RID: 19178 RVA: 0x00197227 File Offset: 0x00195427
	public void SetShopEnter()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalShop, true);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06004AEB RID: 19179 RVA: 0x0019724C File Offset: 0x0019544C
	public bool GetHaveGachaEnter()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalGacha, false);
		return player && player;
	}

	// Token: 0x06004AEC RID: 19180 RVA: 0x0019726B File Offset: 0x0019546B
	public void SetGachaEnter()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalGacha, true);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06004AED RID: 19181 RVA: 0x00197290 File Offset: 0x00195490
	public bool GetHaveChoseRoleViewEnter()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalChoseRoleView, false);
		return player && player;
	}

	// Token: 0x06004AEE RID: 19182 RVA: 0x001972AF File Offset: 0x001954AF
	public void SetChoseRoleViewEnter()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.BeginnerCarnivalChoseRoleView, true);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0400374E RID: 14158
	public int ChoseRoleId;

	// Token: 0x0400374F RID: 14159
	public int GetRoleTaskId;

	// Token: 0x04003750 RID: 14160
	public int ItemId;
}
