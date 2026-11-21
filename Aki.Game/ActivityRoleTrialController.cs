using System;
using System.Collections.Generic;
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

// Token: 0x02000983 RID: 2435
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRoleTrialController : ActivityControllerBase
{
	// Token: 0x06006AF5 RID: 27381 RVA: 0x00213E13 File Offset: 0x00212013
	protected override bool OnClear()
	{
		this.ClearAllRefreshTimer();
		return base.OnClear();
	}

	// Token: 0x06006AF6 RID: 27382 RVA: 0x00213E21 File Offset: 0x00212021
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleTrialSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleTrialSettleNotify));
	}

	// Token: 0x06006AF7 RID: 27383 RVA: 0x00213E3F File Offset: 0x0021203F
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleTrialSettleNotify);
	}

	// Token: 0x06006AF8 RID: 27384 RVA: 0x00213E54 File Offset: 0x00212054
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.CrossDayZone, new Action(this.OnCrossDayZone));
	}

	// Token: 0x06006AF9 RID: 27385 RVA: 0x00213EB8 File Offset: 0x002120B8
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.CrossDayZone, new Action(this.OnCrossDayZone));
	}

	// Token: 0x06006AFA RID: 27386 RVA: 0x00213F1C File Offset: 0x0021211C
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

	// Token: 0x06006AFB RID: 27387 RVA: 0x00213FA8 File Offset: 0x002121A8
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

	// Token: 0x06006AFC RID: 27388 RVA: 0x00214048 File Offset: 0x00212248
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

	// Token: 0x06006AFD RID: 27389 RVA: 0x002140B0 File Offset: 0x002122B0
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

	// Token: 0x06006AFE RID: 27390 RVA: 0x002141FC File Offset: 0x002123FC
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

	// Token: 0x06006AFF RID: 27391 RVA: 0x00214264 File Offset: 0x00212464
	private void ClearSingleRefreshTimer(int activityId)
	{
		TimerHandle timerHandle;
		if (this.RefreshTimerHandle.Count > 0 && this.RefreshTimerHandle.TryGetValue(activityId, out timerHandle) && timerHandle != null && TimerSystem.RealTimeInstance.Has(timerHandle))
		{
			timerHandle.Remove();
			this.RefreshTimerHandle.Remove(activityId);
		}
	}

	// Token: 0x06006B00 RID: 27392 RVA: 0x002142B4 File Offset: 0x002124B4
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

	// Token: 0x06006B01 RID: 27393 RVA: 0x00214338 File Offset: 0x00212538
	public List<ActivityRoleTrialData> GetCurrentActivityDataList()
	{
		List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(8);
		List<ActivityRoleTrialData> list = new List<ActivityRoleTrialData>(currentActivitiesByType.Count);
		foreach (ActivityBaseData activityBaseData in currentActivitiesByType)
		{
			list.Add((ActivityRoleTrialData)activityBaseData);
		}
		return list;
	}

	// Token: 0x06006B02 RID: 27394 RVA: 0x002143A4 File Offset: 0x002125A4
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleTrial";
	}

	// Token: 0x06006B03 RID: 27395 RVA: 0x002143AB File Offset: 0x002125AB
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRoleTrial();
	}

	// Token: 0x06006B04 RID: 27396 RVA: 0x002143B2 File Offset: 0x002125B2
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityRoleTrialData();
	}

	// Token: 0x06006B05 RID: 27397 RVA: 0x002143B9 File Offset: 0x002125B9
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006B06 RID: 27398 RVA: 0x002143BB File Offset: 0x002125BB
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006B07 RID: 27399 RVA: 0x002143C0 File Offset: 0x002125C0
	[NullableContext(2)]
	private void OnRoleTrialSettleNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleTrialSettleNotify roleTrialSettleNotify = (RoleTrialSettleNotify)msg;
		if (roleTrialSettleNotify.ErrorCode > Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleTrialSettleNotify.ErrorCode, 22045, null, true, true);
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

	// Token: 0x06006B08 RID: 27400 RVA: 0x00214484 File Offset: 0x00212684
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(trialRoleRewardResponse.ErrorCode, 26824, null, true, true);
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

	// Token: 0x06006B09 RID: 27401 RVA: 0x002144D4 File Offset: 0x002126D4
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

	// Token: 0x06006B0A RID: 27402 RVA: 0x00214528 File Offset: 0x00212728
	public void PushRoleIntroductionViewDone()
	{
		RoleTrialUiEndPush message = RoleTrialUiEndPush.Create();
		Net.Instance.Send(EPushMessageId.RoleTrialUiEndPush, message);
	}

	// Token: 0x17000D30 RID: 3376
	// (get) Token: 0x06006B0B RID: 27403 RVA: 0x0021454B File Offset: 0x0021274B
	public static ActivityRoleTrialController Instance
	{
		get
		{
			return ActivityRoleTrialController._Instance;
		}
	}

	// Token: 0x06006B0C RID: 27404 RVA: 0x00214552 File Offset: 0x00212752
	public static ActivityRoleTrialController GetOrCreateInstance()
	{
		if (ActivityRoleTrialController._Instance == null)
		{
			ActivityRoleTrialController.CreateInstance();
		}
		return ActivityRoleTrialController._Instance;
	}

	// Token: 0x06006B0D RID: 27405 RVA: 0x00214566 File Offset: 0x00212766
	public static bool CreateInstance()
	{
		if (ActivityRoleTrialController._Instance != null)
		{
			return true;
		}
		ActivityRoleTrialController._Instance = new ActivityRoleTrialController();
		return true;
	}

	// Token: 0x06006B0E RID: 27406 RVA: 0x0021457C File Offset: 0x0021277C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006B0F RID: 27407 RVA: 0x0021457E File Offset: 0x0021277E
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleTrialController._Instance = null;
	}

	// Token: 0x06006B10 RID: 27408 RVA: 0x00214586 File Offset: 0x00212786
	static ActivityRoleTrialController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleTrialController.CreateStaticDefaultValue), new Action(ActivityRoleTrialController.ResetStaticDefaultValue));
	}

	// Token: 0x04004333 RID: 17203
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, TimerHandle> RefreshTimerHandle = new Dictionary<int, TimerHandle>();

	// Token: 0x04004334 RID: 17204
	public List<int> CurrentActivityIdList = new List<int>();

	// Token: 0x04004335 RID: 17205
	[Nullable(2)]
	private static ActivityRoleTrialController _Instance;
}
