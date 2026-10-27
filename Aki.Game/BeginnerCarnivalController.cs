using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001197 RID: 4503
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalController : ActivityControllerBase
{
	// Token: 0x06007730 RID: 30512 RVA: 0x0018DB80 File Offset: 0x0018BD80
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007731 RID: 30513 RVA: 0x0018DB82 File Offset: 0x0018BD82
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_NewPlayerCelebration";
	}

	// Token: 0x06007732 RID: 30514 RVA: 0x0018DB89 File Offset: 0x0018BD89
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new BeginnerCarnivalSubView();
	}

	// Token: 0x06007733 RID: 30515 RVA: 0x0018DB90 File Offset: 0x0018BD90
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new BeginnerCarnivalData();
	}

	// Token: 0x06007734 RID: 30516 RVA: 0x0018DBA3 File Offset: 0x0018BDA3
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06007735 RID: 30517 RVA: 0x0018DBA6 File Offset: 0x0018BDA6
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalUnlockTipView, null, null);
	}

	// Token: 0x06007736 RID: 30518 RVA: 0x0018DBB9 File Offset: 0x0018BDB9
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewbieCarnivalTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.NewbieCarnivalTaskDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewbieCarnivalTaskJumpUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.NewbieCarnivalTaskJumpUpdateNotify));
	}

	// Token: 0x06007737 RID: 30519 RVA: 0x0018DBF3 File Offset: 0x0018BDF3
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewbieCarnivalTaskDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewbieCarnivalTaskJumpUpdateNotify);
	}

	// Token: 0x06007738 RID: 30520 RVA: 0x0018DC18 File Offset: 0x0018BE18
	[NullableContext(2)]
	public void NewbieCarnivalTaskDataUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<ActivityTask> activityTasks = ((NewbieCarnivalTaskDataUpdateNotify)msg).ActivityTaskData.ActivityTasks;
		BeginnerCarnivalData beginnerCarnivalData = this.GetBeginnerCarnivalData();
		if (beginnerCarnivalData == null)
		{
			return;
		}
		foreach (ActivityTask activityTask in activityTasks)
		{
			NewbieCarnivalTask? newbieCarnivalTask = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalTask(activityTask.Id);
			if (newbieCarnivalTask != null)
			{
				List<ActivityTask> list;
				if (!beginnerCarnivalData.TaskDataMap.TryGetValue(newbieCarnivalTask.Value.TaskType, out list) || list == null)
				{
					list = new List<ActivityTask>();
				}
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Id == activityTask.Id)
					{
						list[i] = activityTask;
						break;
					}
				}
				beginnerCarnivalData.TaskDataMap[newbieCarnivalTask.Value.TaskType] = list;
				EventSystem.Instance.Emit<int>(EEventName.RefreshBeginnerCarnivalTask, newbieCarnivalTask.Value.TaskType);
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
	}

	// Token: 0x06007739 RID: 30521 RVA: 0x0018DD50 File Offset: 0x0018BF50
	[NullableContext(2)]
	public void NewbieCarnivalTaskJumpUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		NewbieCarnivalTaskJumpUpdateNotify newbieCarnivalTaskJumpUpdateNotify = (NewbieCarnivalTaskJumpUpdateNotify)msg;
		BeginnerCarnivalData beginnerCarnivalData = this.GetBeginnerCarnivalData();
		foreach (JumpTaskCondInfo jumpTaskCondInfo in newbieCarnivalTaskJumpUpdateNotify.JumpTaskCondInfos)
		{
			beginnerCarnivalData.JumpTaskMap[jumpTaskCondInfo.JumpTaskId] = jumpTaskCondInfo.ConditionGroupIds.ToList<int>();
			EventSystem.Instance.Emit<int>(EEventName.RefreshBeginnerCarnivalTask, jumpTaskCondInfo.JumpTaskId);
		}
	}

	// Token: 0x0600773A RID: 30522 RVA: 0x0018DDD4 File Offset: 0x0018BFD4
	public void NewbieCarnivalAwardRequest(int taskId)
	{
		NewbieCarnivalAwardRequest newbieCarnivalAwardRequest = Aki.Protocol.NewbieCarnivalAwardRequest.Create();
		newbieCarnivalAwardRequest.ActivityId = this.ActivityId;
		newbieCarnivalAwardRequest.Config = taskId;
		Net.Instance.Call(ERequestMessageId.NewbieCarnivalAwardRequest, newbieCarnivalAwardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			NewbieCarnivalAwardResponse newbieCarnivalAwardResponse = (NewbieCarnivalAwardResponse)msg;
			if (newbieCarnivalAwardResponse == null)
			{
				return;
			}
			if (newbieCarnivalAwardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieCarnivalAwardResponse.ErrorCode, 25525, null, true, true);
			}
			BeginnerCarnivalData beginnerCarnivalData = this.GetBeginnerCarnivalData();
			if (beginnerCarnivalData == null)
			{
				return;
			}
			foreach (KeyValuePair<int, List<ActivityTask>> keyValuePair in beginnerCarnivalData.TaskDataMap)
			{
				int key = keyValuePair.Key;
				List<ActivityTask> value = keyValuePair.Value;
				for (int i = 0; i < value.Count; i++)
				{
					ActivityTask activityTask = value[i];
					if (activityTask.Id == taskId)
					{
						activityTask.Status = ActivityTaskState.ActivityTaskTaken;
						value[i] = activityTask;
						EventSystem.Instance.Emit<int>(EEventName.RefreshBeginnerCarnivalTask, key);
						break;
					}
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}, 0);
	}

	// Token: 0x0600773B RID: 30523 RVA: 0x0018DE30 File Offset: 0x0018C030
	public void NewbieCarnivalSwitchRoleRequest(int roleId)
	{
		NewbieCarnivalSwitchRoleRequest newbieCarnivalSwitchRoleRequest = Aki.Protocol.NewbieCarnivalSwitchRoleRequest.Create();
		newbieCarnivalSwitchRoleRequest.ActivityId = this.ActivityId;
		newbieCarnivalSwitchRoleRequest.RoleId = roleId;
		Net.Instance.Call(ERequestMessageId.NewbieCarnivalSwitchRoleRequest, newbieCarnivalSwitchRoleRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			NewbieCarnivalSwitchRoleResponse newbieCarnivalSwitchRoleResponse = (NewbieCarnivalSwitchRoleResponse)msg;
			if (newbieCarnivalSwitchRoleResponse == null)
			{
				return;
			}
			if (newbieCarnivalSwitchRoleResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieCarnivalSwitchRoleResponse.ErrorCode, 18412, null, true, true);
			}
			this.GetBeginnerCarnivalData().ChoseRoleId = roleId;
			EventSystem.Instance.Emit(EEventName.OnRefreshBeginnerCarnivalChoseRole);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}, 0);
	}

	// Token: 0x0600773C RID: 30524 RVA: 0x0018DE8C File Offset: 0x0018C08C
	public BeginnerCarnivalData GetBeginnerCarnivalData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as BeginnerCarnivalData;
	}

	// Token: 0x17000A3C RID: 2620
	// (get) Token: 0x0600773D RID: 30525 RVA: 0x0018DEA3 File Offset: 0x0018C0A3
	public static BeginnerCarnivalController Instance
	{
		get
		{
			return BeginnerCarnivalController._Instance;
		}
	}

	// Token: 0x0600773E RID: 30526 RVA: 0x0018DEAA File Offset: 0x0018C0AA
	public static BeginnerCarnivalController GetOrCreateInstance()
	{
		if (BeginnerCarnivalController._Instance == null)
		{
			BeginnerCarnivalController.CreateInstance();
		}
		return BeginnerCarnivalController._Instance;
	}

	// Token: 0x0600773F RID: 30527 RVA: 0x0018DEBE File Offset: 0x0018C0BE
	public static bool CreateInstance()
	{
		if (BeginnerCarnivalController._Instance != null)
		{
			return true;
		}
		BeginnerCarnivalController._Instance = new BeginnerCarnivalController();
		return true;
	}

	// Token: 0x06007740 RID: 30528 RVA: 0x0018DED4 File Offset: 0x0018C0D4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007741 RID: 30529 RVA: 0x0018DED6 File Offset: 0x0018C0D6
	public static void ResetStaticDefaultValue()
	{
		BeginnerCarnivalController._Instance = null;
	}

	// Token: 0x06007742 RID: 30530 RVA: 0x0018DEDE File Offset: 0x0018C0DE
	static BeginnerCarnivalController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BeginnerCarnivalController.CreateStaticDefaultValue), new Action(BeginnerCarnivalController.ResetStaticDefaultValue));
	}

	// Token: 0x040036B1 RID: 14001
	public int ActivityId;

	// Token: 0x040036B2 RID: 14002
	[Nullable(2)]
	private static BeginnerCarnivalController _Instance;
}
