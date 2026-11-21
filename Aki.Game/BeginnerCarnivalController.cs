using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x0200064B RID: 1611
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalController : ActivityControllerBase
{
	// Token: 0x06004AC7 RID: 19143 RVA: 0x00196768 File Offset: 0x00194968
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004AC8 RID: 19144 RVA: 0x0019676A File Offset: 0x0019496A
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_NewPlayerCelebration";
	}

	// Token: 0x06004AC9 RID: 19145 RVA: 0x00196771 File Offset: 0x00194971
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new BeginnerCarnivalSubView();
	}

	// Token: 0x06004ACA RID: 19146 RVA: 0x00196778 File Offset: 0x00194978
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new BeginnerCarnivalData();
	}

	// Token: 0x06004ACB RID: 19147 RVA: 0x0019678B File Offset: 0x0019498B
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004ACC RID: 19148 RVA: 0x0019678E File Offset: 0x0019498E
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalUnlockTipView, null, null);
	}

	// Token: 0x06004ACD RID: 19149 RVA: 0x001967A1 File Offset: 0x001949A1
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewbieCarnivalTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.NewbieCarnivalTaskDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewbieCarnivalTaskJumpUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.NewbieCarnivalTaskJumpUpdateNotify));
	}

	// Token: 0x06004ACE RID: 19150 RVA: 0x001967DB File Offset: 0x001949DB
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewbieCarnivalTaskDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewbieCarnivalTaskJumpUpdateNotify);
	}

	// Token: 0x06004ACF RID: 19151 RVA: 0x00196800 File Offset: 0x00194A00
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

	// Token: 0x06004AD0 RID: 19152 RVA: 0x00196938 File Offset: 0x00194B38
	[NullableContext(2)]
	public void NewbieCarnivalTaskJumpUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		NewbieCarnivalTaskJumpUpdateNotify newbieCarnivalTaskJumpUpdateNotify = (NewbieCarnivalTaskJumpUpdateNotify)msg;
		BeginnerCarnivalData beginnerCarnivalData = this.GetBeginnerCarnivalData();
		foreach (JumpTaskCondInfo jumpTaskCondInfo in newbieCarnivalTaskJumpUpdateNotify.JumpTaskCondInfos)
		{
			beginnerCarnivalData.JumpTaskMap[jumpTaskCondInfo.JumpTaskId] = new List<int>(jumpTaskCondInfo.ConditionGroupIds);
			EventSystem.Instance.Emit<int>(EEventName.RefreshBeginnerCarnivalTask, jumpTaskCondInfo.JumpTaskId);
		}
	}

	// Token: 0x06004AD1 RID: 19153 RVA: 0x001969BC File Offset: 0x00194BBC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieCarnivalAwardResponse.ErrorCode, 19176, null, true, true);
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

	// Token: 0x06004AD2 RID: 19154 RVA: 0x00196A18 File Offset: 0x00194C18
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieCarnivalSwitchRoleResponse.ErrorCode, 27062, null, true, true);
			}
			this.GetBeginnerCarnivalData().ChoseRoleId = roleId;
			EventSystem.Instance.Emit(EEventName.OnRefreshBeginnerCarnivalChoseRole);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}, 0);
	}

	// Token: 0x06004AD3 RID: 19155 RVA: 0x00196A74 File Offset: 0x00194C74
	public BeginnerCarnivalData GetBeginnerCarnivalData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as BeginnerCarnivalData;
	}

	// Token: 0x17000A5C RID: 2652
	// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x00196A8B File Offset: 0x00194C8B
	public static BeginnerCarnivalController Instance
	{
		get
		{
			return BeginnerCarnivalController._Instance;
		}
	}

	// Token: 0x06004AD5 RID: 19157 RVA: 0x00196A92 File Offset: 0x00194C92
	public static BeginnerCarnivalController GetOrCreateInstance()
	{
		if (BeginnerCarnivalController._Instance == null)
		{
			BeginnerCarnivalController.CreateInstance();
		}
		return BeginnerCarnivalController._Instance;
	}

	// Token: 0x06004AD6 RID: 19158 RVA: 0x00196AA6 File Offset: 0x00194CA6
	public static bool CreateInstance()
	{
		if (BeginnerCarnivalController._Instance != null)
		{
			return true;
		}
		BeginnerCarnivalController._Instance = new BeginnerCarnivalController();
		return true;
	}

	// Token: 0x06004AD7 RID: 19159 RVA: 0x00196ABC File Offset: 0x00194CBC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004AD8 RID: 19160 RVA: 0x00196ABE File Offset: 0x00194CBE
	public static void ResetStaticDefaultValue()
	{
		BeginnerCarnivalController._Instance = null;
	}

	// Token: 0x06004AD9 RID: 19161 RVA: 0x00196AC6 File Offset: 0x00194CC6
	static BeginnerCarnivalController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BeginnerCarnivalController.CreateStaticDefaultValue), new Action(BeginnerCarnivalController.ResetStaticDefaultValue));
	}

	// Token: 0x0400374A RID: 14154
	public int ActivityId;

	// Token: 0x0400374B RID: 14155
	[Nullable(2)]
	private static BeginnerCarnivalController _Instance;
}
