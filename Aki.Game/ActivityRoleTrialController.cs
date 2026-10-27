using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.Activity.ActivityContent.RoleTrial;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020014CB RID: 5323
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRoleTrialController : ActivityControllerBase
{
	// Token: 0x0600971B RID: 38683 RVA: 0x0020A129 File Offset: 0x00208329
	protected override bool OnClear()
	{
		this.ClearAllRefreshTimer();
		return base.OnClear();
	}

	// Token: 0x0600971C RID: 38684 RVA: 0x0020A137 File Offset: 0x00208337
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleTrialSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleTrialSettleNotify));
	}

	// Token: 0x0600971D RID: 38685 RVA: 0x0020A155 File Offset: 0x00208355
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleTrialSettleNotify);
	}

	// Token: 0x0600971E RID: 38686 RVA: 0x0020A168 File Offset: 0x00208368
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.CrossDayZone, new Action(this.OnCrossDayZone));
	}

	// Token: 0x0600971F RID: 38687 RVA: 0x0020A1CC File Offset: 0x002083CC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.CrossDayZone, new Action(this.OnCrossDayZone));
	}

	// Token: 0x06009720 RID: 38688 RVA: 0x0020A230 File Offset: 0x00208430
	private void OnRoleSystemChangeRole(int trialRoleId)
	{
		if (trialRoleId.Equals(0))
		{
			return;
		}
		foreach (int id in this.CurrentActivityIdList)
		{
			ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(id) as ActivityRoleTrialData;
			if (activityRoleTrialData != null && activityRoleTrialData.IsRolePreviewOn())
			{
				int num;
				activityRoleTrialData.TrialToIdMap.TryGetValue(trialRoleId, out num);
				if (num != 0)
				{
					activityRoleTrialData.CurrentRoleId = num;
				}
			}
		}
	}

	// Token: 0x06009721 RID: 38689 RVA: 0x0020A2BC File Offset: 0x002084BC
	private void OnWorldDone()
	{
		foreach (int num in this.CurrentActivityIdList)
		{
			ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(num) as ActivityRoleTrialData;
			if (activityRoleTrialData != null && activityRoleTrialData.IsRoleInstanceOn() && !GameModeController.Instance.IsInInstance())
			{
				IReadOnlyList<EdgeRunnerTrial> trialRoleListByTrialActivityId = CyberPunkConfig.Instance.GetTrialRoleListByTrialActivityId(num);
				if (trialRoleListByTrialActivityId == null || trialRoleListByTrialActivityId.Count <= 0)
				{
					ActivityController.Instance.OpenActivityById(num, EActivityViewOpenType.Other, null, null);
					break;
				}
			}
		}
	}

	// Token: 0x06009722 RID: 38690 RVA: 0x0020A35C File Offset: 0x0020855C
	private void OnCrossDayZone()
	{
		foreach (int id in this.CurrentActivityIdList)
		{
			ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(id) as ActivityRoleTrialData;
			if (activityRoleTrialData != null)
			{
				this.TryRefreshIsNewMap(activityRoleTrialData);
			}
		}
	}

	// Token: 0x06009723 RID: 38691 RVA: 0x0020A3C4 File Offset: 0x002085C4
	public void TryRefreshIsNewMap(ActivityRoleTrialData data)
	{
		this.ClearSingleRefreshTimer(data.Id);
		double serverTime = TimeUtil.Instance.GetServerTime();
		double nearestTime = double.MaxValue;
		foreach (Tuple<double, double> tuple in data.RoleBeginEndTimeMap.Values)
		{
			double item = tuple.Item1;
			double item2 = tuple.Item2;
			double num = 0.0;
			if (serverTime < item)
			{
				num = item;
			}
			else if (serverTime < item2)
			{
				num = item2;
			}
			if (Math.Floor(serverTime / (double)TimeUtil.Instance.OneDaySeconds) == Math.Floor(num / (double)TimeUtil.Instance.OneDaySeconds) && num < nearestTime)
			{
				nearestTime = num;
			}
		}
		if (nearestTime < 9.223372036854776E+18)
		{
			this.RefreshTimerHandle[data.Id] = TimerSystem.RealTimeInstance.Forever(delegate(float _)
			{
				this.OnTimerRefresh(data, nearestTime);
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}
	}

	// Token: 0x06009724 RID: 38692 RVA: 0x0020A510 File Offset: 0x00208710
	private void OnTimerRefresh(ActivityRoleTrialData data, double refreshTime)
	{
		if (TimeUtil.Instance.GetServerTime() >= refreshTime)
		{
			data.RefreshExData();
			data.RefreshIsNewMap();
			EventSystem.Instance.Emit<int>(EEventName.OnTrialRoleDataChanged, data.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			this.ClearSingleRefreshTimer(data.Id);
			this.TryRefreshIsNewMap(data);
		}
	}

	// Token: 0x06009725 RID: 38693 RVA: 0x0020A578 File Offset: 0x00208778
	private void ClearSingleRefreshTimer(int activityId)
	{
		TimerHandle timerHandle;
		if (this.RefreshTimerHandle.Count > 0 && this.RefreshTimerHandle.TryGetValue(activityId, out timerHandle) && timerHandle != null && TimerSystem.RealTimeInstance.Has(timerHandle))
		{
			timerHandle.Remove();
			this.RefreshTimerHandle.Remove(activityId);
		}
	}

	// Token: 0x06009726 RID: 38694 RVA: 0x0020A5C8 File Offset: 0x002087C8
	private void ClearAllRefreshTimer()
	{
		if (this.RefreshTimerHandle.Count > 0)
		{
			foreach (TimerHandle timerHandle in this.RefreshTimerHandle.Values)
			{
				if (timerHandle != null && TimerSystem.RealTimeInstance.Has(timerHandle))
				{
					timerHandle.Remove();
				}
			}
			this.RefreshTimerHandle.Clear();
		}
	}

	// Token: 0x06009727 RID: 38695 RVA: 0x0020A64C File Offset: 0x0020884C
	public List<ActivityRoleTrialData> GetCurrentActivityDataList()
	{
		return ActivityModel.Instance.GetCurrentActivitiesByType(8).Cast<ActivityRoleTrialData>().ToList<ActivityRoleTrialData>();
	}

	// Token: 0x06009728 RID: 38696 RVA: 0x0020A663 File Offset: 0x00208863
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleTrial";
	}

	// Token: 0x06009729 RID: 38697 RVA: 0x0020A66A File Offset: 0x0020886A
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRoleTrial();
	}

	// Token: 0x0600972A RID: 38698 RVA: 0x0020A671 File Offset: 0x00208871
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityRoleTrialData();
	}

	// Token: 0x0600972B RID: 38699 RVA: 0x0020A678 File Offset: 0x00208878
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600972C RID: 38700 RVA: 0x0020A67A File Offset: 0x0020887A
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600972D RID: 38701 RVA: 0x0020A680 File Offset: 0x00208880
	[NullableContext(2)]
	private void OnRoleTrialSettleNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleTrialSettleNotify roleTrialSettleNotify = (RoleTrialSettleNotify)msg;
		if (roleTrialSettleNotify.ErrorCode > Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleTrialSettleNotify.ErrorCode, 25527, null, true, true);
			Action<int> onClickedCallback = delegate(int _)
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			};
			RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_250_ButtonText_0",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = onClickedCallback
			};
			ItemRewardController.Instance.OpenExploreRewardView(3014, false, null, null, null, new List<IRewardExploreConfirmButton>
			{
				item
			}, null, null, null, null, null, null, null, null, null, null, null);
			return;
		}
	}

	// Token: 0x0600972E RID: 38702 RVA: 0x0020A744 File Offset: 0x00208944
	public void RequestRoleInstanceReward(int roleId, int activityId)
	{
		TrialRoleRewardRequest trialRoleRewardRequest = TrialRoleRewardRequest.Create();
		trialRoleRewardRequest.RoleId = roleId;
		Net.Instance.Call(ERequestMessageId.TrialRoleRewardRequest, trialRoleRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrialRoleRewardResponse trialRoleRewardResponse = (TrialRoleRewardResponse)msg;
			if (trialRoleRewardResponse == null)
			{
				return;
			}
			if (trialRoleRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trialRoleRewardResponse.ErrorCode, 23104, null, true, true);
			}
			ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(activityId) as ActivityRoleTrialData;
			if (activityRoleTrialData == null)
			{
				return;
			}
			activityRoleTrialData.SetRewardStateByRoleId(roleId, ERoleTrialRewardState.FinishedAndClaimed);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[角色试用活动]试用副本奖励领取成功";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", roleId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x0600972F RID: 38703 RVA: 0x0020A794 File Offset: 0x00208994
	[NullableContext(0)]
	public UniTask<bool> EnterRoleTrialDungeonDirectly(int instanceId, int activityId, int roleId)
	{
		ActivityRoleTrialController.<EnterRoleTrialDungeonDirectly>d__22 <EnterRoleTrialDungeonDirectly>d__;
		<EnterRoleTrialDungeonDirectly>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<EnterRoleTrialDungeonDirectly>d__.instanceId = instanceId;
		<EnterRoleTrialDungeonDirectly>d__.activityId = activityId;
		<EnterRoleTrialDungeonDirectly>d__.roleId = roleId;
		<EnterRoleTrialDungeonDirectly>d__.<>1__state = -1;
		<EnterRoleTrialDungeonDirectly>d__.<>t__builder.Start<ActivityRoleTrialController.<EnterRoleTrialDungeonDirectly>d__22>(ref <EnterRoleTrialDungeonDirectly>d__);
		return <EnterRoleTrialDungeonDirectly>d__.<>t__builder.Task;
	}

	// Token: 0x06009730 RID: 38704 RVA: 0x0020A7E8 File Offset: 0x002089E8
	public void PushRoleIntroductionViewDone()
	{
		RoleTrialUiEndPush message = RoleTrialUiEndPush.Create();
		Net.Instance.Send(EPushMessageId.RoleTrialUiEndPush, message);
	}

	// Token: 0x17000D0F RID: 3343
	// (get) Token: 0x06009731 RID: 38705 RVA: 0x0020A80B File Offset: 0x00208A0B
	public static ActivityRoleTrialController Instance
	{
		get
		{
			return ActivityRoleTrialController._Instance;
		}
	}

	// Token: 0x06009732 RID: 38706 RVA: 0x0020A812 File Offset: 0x00208A12
	public static ActivityRoleTrialController GetOrCreateInstance()
	{
		if (ActivityRoleTrialController._Instance == null)
		{
			ActivityRoleTrialController.CreateInstance();
		}
		return ActivityRoleTrialController._Instance;
	}

	// Token: 0x06009733 RID: 38707 RVA: 0x0020A826 File Offset: 0x00208A26
	public static bool CreateInstance()
	{
		if (ActivityRoleTrialController._Instance != null)
		{
			return true;
		}
		ActivityRoleTrialController._Instance = new ActivityRoleTrialController();
		return true;
	}

	// Token: 0x06009734 RID: 38708 RVA: 0x0020A83C File Offset: 0x00208A3C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009735 RID: 38709 RVA: 0x0020A83E File Offset: 0x00208A3E
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleTrialController._Instance = null;
	}

	// Token: 0x06009736 RID: 38710 RVA: 0x0020A846 File Offset: 0x00208A46
	static ActivityRoleTrialController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleTrialController.CreateStaticDefaultValue), new Action(ActivityRoleTrialController.ResetStaticDefaultValue));
	}

	// Token: 0x0400428E RID: 17038
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, TimerHandle> RefreshTimerHandle = new Dictionary<int, TimerHandle>();

	// Token: 0x0400428F RID: 17039
	public List<int> CurrentActivityIdList = new List<int>();

	// Token: 0x04004290 RID: 17040
	[Nullable(2)]
	private static ActivityRoleTrialController _Instance;
}
