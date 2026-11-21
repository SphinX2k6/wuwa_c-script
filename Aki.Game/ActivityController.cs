using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000B28 RID: 2856
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityController : ControllerBase
{
	// Token: 0x060075C5 RID: 30149 RVA: 0x00245F84 File Offset: 0x00244184
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		ActivityManager.Init();
		this.OnAddOpenViewCheckFunction();
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.CommonActivityView, new Action(this.OpenActivityView));
		this.IsDataInit = false;
		return true;
	}

	// Token: 0x060075C6 RID: 30150 RVA: 0x00245FC0 File Offset: 0x002441C0
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		ActivityManager.Clear();
		this.CancelTimer();
		this.OnRemoveOpenViewCheckFunction();
		this.IsDataInit = false;
		this.DisableRefreshTimer();
		return true;
	}

	// Token: 0x060075C7 RID: 30151 RVA: 0x00245FED File Offset: 0x002441ED
	public void EnableRefreshTimer(float interval)
	{
		if (this.RefreshTimer != null)
		{
			return;
		}
		this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshTimer), interval, 1f, null, null, true);
	}

	// Token: 0x060075C8 RID: 30152 RVA: 0x0024601D File Offset: 0x0024421D
	public void DisableRefreshTimer()
	{
		if (this.RefreshTimer == null)
		{
			return;
		}
		this.RefreshTimerDelegateSet.Clear();
		TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
		this.RefreshTimer = null;
	}

	// Token: 0x060075C9 RID: 30153 RVA: 0x0024604B File Offset: 0x0024424B
	public void RegisterRefreshTimerDelegate(Action<float> @delegate)
	{
		this.RefreshTimerDelegateSet.Add(@delegate);
	}

	// Token: 0x060075CA RID: 30154 RVA: 0x0024605A File Offset: 0x0024425A
	public void UnregisterRefreshTimerDelegate(Action<float> @delegate)
	{
		this.RefreshTimerDelegateSet.Remove(@delegate);
	}

	// Token: 0x060075CB RID: 30155 RVA: 0x0024606C File Offset: 0x0024426C
	private void OnRefreshTimer(float delta)
	{
		if (this.RefreshTimerDelegateSet.Count == 0)
		{
			return;
		}
		foreach (Action<float> action in this.RefreshTimerDelegateSet)
		{
			action(delta);
		}
	}

	// Token: 0x060075CC RID: 30156 RVA: 0x002460CC File Offset: 0x002442CC
	private void OpenActivityView()
	{
		this.OpenActivityById(0, EActivityViewOpenType.HotKey, null, null);
	}

	// Token: 0x060075CD RID: 30157 RVA: 0x002460D9 File Offset: 0x002442D9
	protected void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.CommonActivityView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "ActivityController.CheckCanOpen");
	}

	// Token: 0x060075CE RID: 30158 RVA: 0x002460FB File Offset: 0x002442FB
	protected void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.CommonActivityView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
	}

	// Token: 0x060075CF RID: 30159 RVA: 0x00246118 File Offset: 0x00244318
	public bool CheckCanOpen(EUiViewName viewName, object param)
	{
		if (!FunctionModel.Instance.IsOpen(10053))
		{
			GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
			return false;
		}
		return ActivityModel.Instance.GetCurrentShowingActivities().Count != 0;
	}

	// Token: 0x060075D0 RID: 30160 RVA: 0x00246153 File Offset: 0x00244353
	public bool CheckCanOpenWithoutPrompt()
	{
		return FunctionModel.Instance.IsOpen(10053) && ActivityModel.Instance.GetCurrentShowingActivities().Count != 0;
	}

	// Token: 0x060075D1 RID: 30161 RVA: 0x0024617A File Offset: 0x0024437A
	private void CheckActivityActiveState()
	{
		ActivityModel.Instance.RefreshShowingActivities();
	}

	// Token: 0x060075D2 RID: 30162 RVA: 0x00246188 File Offset: 0x00244388
	public void ShowActivityRefreshAndBackToBattleView()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
		confirmBoxDataNew.FunctionMap.Add(1, new Action(ActivityController.<ShowActivityRefreshAndBackToBattleView>g__ConfirmCallback|17_0));
		confirmBoxDataNew.FunctionMap.Add(0, new Action(ActivityController.<ShowActivityRefreshAndBackToBattleView>g__ConfirmCallback|17_0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060075D3 RID: 30163 RVA: 0x002461DC File Offset: 0x002443DC
	private void ShowActivityClose()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AllActivityClose);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060075D4 RID: 30164 RVA: 0x00246200 File Offset: 0x00244400
	private void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(this.InitActivityLocalRedPointData));
		EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x060075D5 RID: 30165 RVA: 0x002462B8 File Offset: 0x002444B8
	private void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(this.InitActivityLocalRedPointData));
		EventSystem.Instance.Remove(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x060075D6 RID: 30166 RVA: 0x0024636D File Offset: 0x0024456D
	private void OnReceiveActivityData(int type, IReadOnlyList<int> activityIds)
	{
		this.InitActivity(type);
	}

	// Token: 0x060075D7 RID: 30167 RVA: 0x00246376 File Offset: 0x00244576
	public void InitActivity(int type)
	{
	}

	// Token: 0x060075D8 RID: 30168 RVA: 0x00246378 File Offset: 0x00244578
	private void InitActivityLocalRedPointData()
	{
		ActivityModel.Instance.InitCache();
	}

	// Token: 0x060075D9 RID: 30169 RVA: 0x00246384 File Offset: 0x00244584
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ActivityUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.ActivityDisableNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityDisableNotify));
	}

	// Token: 0x060075DA RID: 30170 RVA: 0x002463BE File Offset: 0x002445BE
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ActivityUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ActivityDisableNotify);
	}

	// Token: 0x060075DB RID: 30171 RVA: 0x002463E0 File Offset: 0x002445E0
	private void OnDataDone()
	{
		this.InitTimer();
	}

	// Token: 0x060075DC RID: 30172 RVA: 0x002463E8 File Offset: 0x002445E8
	private void OnWorldDone()
	{
		if (!this.IsDataInit)
		{
			this.IsDataInit = true;
			GameModeController.Instance.AddWorldDoneBlocker(new Func<UniTask>(this.InitActivityDataOnWorldDone), 60000);
		}
	}

	// Token: 0x060075DD RID: 30173 RVA: 0x00246414 File Offset: 0x00244614
	private UniTask InitActivityDataOnWorldDone()
	{
		ActivityController.<InitActivityDataOnWorldDone>d__28 <InitActivityDataOnWorldDone>d__;
		<InitActivityDataOnWorldDone>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitActivityDataOnWorldDone>d__.<>4__this = this;
		<InitActivityDataOnWorldDone>d__.<>1__state = -1;
		<InitActivityDataOnWorldDone>d__.<>t__builder.Start<ActivityController.<InitActivityDataOnWorldDone>d__28>(ref <InitActivityDataOnWorldDone>d__);
		return <InitActivityDataOnWorldDone>d__.<>t__builder.Task;
	}

	// Token: 0x060075DE RID: 30174 RVA: 0x00246458 File Offset: 0x00244658
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		foreach (int id in closeActivities)
		{
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(id);
			if (activityById != null && this.IsOpeningActivityRelativeView((int)activityById.Type))
			{
				this.ShowActivityRefreshAndBackToBattleView();
				break;
			}
		}
	}

	// Token: 0x060075DF RID: 30175 RVA: 0x002464C0 File Offset: 0x002446C0
	private void OnCrossDay()
	{
		this.RequestActivityData().ContinueWith(delegate(bool success)
		{
			if (!success)
			{
				return;
			}
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YYZ, "[CrossDay][Activity] 跨天活动数据刷新完成", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit(EEventName.ActivityCrossDayRefresh);
		});
	}

	// Token: 0x060075E0 RID: 30176 RVA: 0x002464ED File Offset: 0x002446ED
	private void CancelTimer()
	{
		if (this.CheckActivityTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CheckActivityTimer);
			this.CheckActivityTimer = null;
		}
	}

	// Token: 0x060075E1 RID: 30177 RVA: 0x0024650F File Offset: 0x0024470F
	private void InitTimer()
	{
		this.CancelTimer();
		this.CheckActivityTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnCheckActivityTimer), 600000f, 1f, null, null, false);
	}

	// Token: 0x060075E2 RID: 30178 RVA: 0x00246540 File Offset: 0x00244740
	private void OnCheckActivityTimer(float delta)
	{
		this.RequestActivityData();
	}

	// Token: 0x060075E3 RID: 30179 RVA: 0x0024654C File Offset: 0x0024474C
	[NullableContext(2)]
	public bool OpenActivityById(int id = 0, EActivityViewOpenType openType = EActivityViewOpenType.Other, object activityOpenParam = null, Action<bool> finishCallback = null)
	{
		if (!FunctionModel.Instance.IsOpen(10053))
		{
			GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
			return false;
		}
		if (ActivityModel.Instance.GetCurrentShowingActivities().Count == 0)
		{
			this.ShowActivityClose();
			return false;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.CommonActivityView))
		{
			UiManager.Instance.OpenView(EUiViewName.CommonActivityView, new object[]
			{
				openType,
				id,
				activityOpenParam
			}, delegate(bool success, int viewId)
			{
				Action<bool> finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2(success);
			});
		}
		else
		{
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewChange, id);
		}
		return true;
	}

	// Token: 0x060075E4 RID: 30180 RVA: 0x00246603 File Offset: 0x00244803
	public void OpenActivityContentView(ActivityBaseData data)
	{
		ActivityManager.GetActivityController(data.Type).OpenView(data);
	}

	// Token: 0x060075E5 RID: 30181 RVA: 0x00246618 File Offset: 0x00244818
	[NullableContext(2)]
	public void JumpToViewOrOpenPreGuideQuest([Nullable(1)] ActivityBaseData data, EUiViewName unlockedJumpToViewName, object param = null, TOpenViewCallBack finishCallback = null)
	{
		EActivityOpenStatus activityOpenStatus = data.GetActivityOpenStatus();
		if (activityOpenStatus == EActivityOpenStatus.Unlocked)
		{
			UiManager.Instance.OpenView(unlockedJumpToViewName, param ?? data, finishCallback);
			return;
		}
		if (activityOpenStatus == EActivityOpenStatus.PreGuideQuestPending)
		{
			int unFinishPreGuideQuestId = data.GetUnFinishPreGuideQuestId();
			UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
		}
	}

	// Token: 0x060075E6 RID: 30182 RVA: 0x00246664 File Offset: 0x00244864
	[NullableContext(2)]
	public void JumpAndLog([Nullable(1)] ActivityBaseData data, EUiViewName unlockedJumpToViewName, object param = null, TOpenViewCallBack finishCallback = null)
	{
		this.JumpToViewOrOpenPreGuideQuest(data, unlockedJumpToViewName, param ?? data, finishCallback);
		ActivityModel.Instance.SendActivityViewJumpClickLogData(data);
	}

	// Token: 0x060075E7 RID: 30183 RVA: 0x00246681 File Offset: 0x00244881
	public void JumpAndLog(ActivityBaseData data, Action onClicked)
	{
		onClicked();
		ActivityModel.Instance.SendActivityViewJumpClickLogData(data);
	}

	// Token: 0x060075E8 RID: 30184 RVA: 0x00246694 File Offset: 0x00244894
	public void JumpAndLog(ActivityBaseData data, Action<ActivityViewJumpClickLogData> onClicked)
	{
		ActivityViewJumpClickLogData defaultActivityViewJumpClickLogData = ActivityModel.Instance.GetDefaultActivityViewJumpClickLogData(data);
		onClicked(defaultActivityViewJumpClickLogData);
		ActivityModel.Instance.SendActivityViewJumpClickLogData(defaultActivityViewJumpClickLogData);
	}

	// Token: 0x060075E9 RID: 30185 RVA: 0x002466C0 File Offset: 0x002448C0
	[NullableContext(0)]
	public UniTask<bool> RequestActivityData()
	{
		ActivityController.<RequestActivityData>d__40 <RequestActivityData>d__;
		<RequestActivityData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestActivityData>d__.<>1__state = -1;
		<RequestActivityData>d__.<>t__builder.Start<ActivityController.<RequestActivityData>d__40>(ref <RequestActivityData>d__);
		return <RequestActivityData>d__.<>t__builder.Task;
	}

	// Token: 0x060075EA RID: 30186 RVA: 0x002466FC File Offset: 0x002448FC
	[NullableContext(2)]
	public void RequestReadActivity(ActivityBaseData activityData)
	{
		ActivityBaseData activityData2 = activityData;
		if (activityData2 != null && activityData2.GetIfFirstOpen())
		{
			ActivityFirstReadRequest activityFirstReadRequest = ActivityFirstReadRequest.Create();
			activityFirstReadRequest.ActivityId = activityData.Id;
			Net.Instance.Call(ERequestMessageId.ActivityFirstReadRequest, activityFirstReadRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ActivityFirstReadResponse activityFirstReadResponse = (ActivityFirstReadResponse)msg;
				if (activityFirstReadResponse == null)
				{
					return;
				}
				if (activityFirstReadResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(activityFirstReadResponse.ErrorCode, 19193, null, true, true);
				}
				ActivityModel.Instance.OnReceiveActivityRead(activityData.Id);
			}, 0);
		}
		ActivityModel.Instance.OnReceiveActivityRead(activityData.Id);
	}

	// Token: 0x060075EB RID: 30187 RVA: 0x00246774 File Offset: 0x00244974
	[NullableContext(2)]
	public void RequestPreOpenActivity(ActivityBaseData activityData, Action<bool> callback)
	{
		ActivityBaseData activityData2 = activityData;
		if (activityData2 == null || !activityData2.CanPreOpen())
		{
			return;
		}
		ActivityPreOpenRequest activityPreOpenRequest = ActivityPreOpenRequest.Create();
		activityPreOpenRequest.ActivityId = activityData.Id;
		Net.Instance.Call(ERequestMessageId.ActivityPreOpenRequest, activityPreOpenRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ActivityPreOpenResponse activityPreOpenResponse = (ActivityPreOpenResponse)msg;
			if (activityPreOpenResponse == null)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else if (activityPreOpenResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(activityPreOpenResponse.ErrorCode, 26181, null, true, true);
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(false);
				return;
			}
			else
			{
				EventSystem.Instance.Emit<int>(EEventName.OnActivityPreOpen, activityData.Id);
				Action<bool> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(true);
				return;
			}
		}, 0);
	}

	// Token: 0x060075EC RID: 30188 RVA: 0x002467E4 File Offset: 0x002449E4
	[NullableContext(2)]
	private void OnActivityUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		ActivityUpdateNotify activityUpdateNotify = (ActivityUpdateNotify)msg;
		ActivityModel.Instance.OnActivityUpdate(activityUpdateNotify.Activities);
		this.CheckActivityActiveState();
	}

	// Token: 0x060075ED RID: 30189 RVA: 0x00246810 File Offset: 0x00244A10
	[NullableContext(2)]
	private void OnActivityDisableNotify(IMessage msg, Net.CallbackStatus status)
	{
		ActivityDisableNotify activityDisableNotify = (ActivityDisableNotify)msg;
		ActivityModel.Instance.OnDisableActivity(activityDisableNotify.ActivityIds);
		this.CheckActivityActiveState();
	}

	// Token: 0x060075EE RID: 30190 RVA: 0x0024683A File Offset: 0x00244A3A
	public ActivityBaseData CreateActivityData(ActivityData data)
	{
		return ActivityManager.GetActivityController(data.Type).CreateActivityData(data);
	}

	// Token: 0x060075EF RID: 30191 RVA: 0x0024684D File Offset: 0x00244A4D
	public bool IsOpeningActivityRelativeView(int type)
	{
		IActivityControllerBase activityController = ActivityManager.GetActivityController(type);
		return activityController != null && activityController.GetIsOpeningActivityRelativeView();
	}

	// Token: 0x060075F0 RID: 30192 RVA: 0x00246860 File Offset: 0x00244A60
	public void OpenActivityConditionView(int activityId)
	{
		if (activityId != 0)
		{
			ActivityConditionGroupData param = new ActivityConditionGroupData(activityId);
			UiManager.Instance.OpenView(EUiViewName.ActivityConditionView, param, null);
		}
	}

	// Token: 0x060075F1 RID: 30193 RVA: 0x00246888 File Offset: 0x00244A88
	public void CheckIsActivityClose(int? type = null, int? activityId = null)
	{
		if (activityId != null)
		{
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(activityId.Value);
			if (activityById != null && activityById.CheckIfClose())
			{
				this.ShowActivityRefreshAndBackToBattleView();
			}
			return;
		}
		if (type == null)
		{
			return;
		}
		using (List<ActivityBaseData>.Enumerator enumerator = ActivityModel.Instance.GetActivitiesByType(type.Value).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CheckIfClose())
				{
					this.ShowActivityRefreshAndBackToBattleView();
					break;
				}
			}
		}
	}

	// Token: 0x17000DC7 RID: 3527
	// (get) Token: 0x060075F2 RID: 30194 RVA: 0x00246928 File Offset: 0x00244B28
	public static ActivityController Instance
	{
		get
		{
			return ActivityController._Instance;
		}
	}

	// Token: 0x060075F3 RID: 30195 RVA: 0x0024692F File Offset: 0x00244B2F
	public static ActivityController GetOrCreateInstance()
	{
		if (ActivityController._Instance == null)
		{
			ActivityController.CreateInstance();
		}
		return ActivityController._Instance;
	}

	// Token: 0x060075F4 RID: 30196 RVA: 0x00246943 File Offset: 0x00244B43
	public static bool CreateInstance()
	{
		if (ActivityController._Instance != null)
		{
			return true;
		}
		ActivityController._Instance = new ActivityController();
		return true;
	}

	// Token: 0x060075F5 RID: 30197 RVA: 0x00246959 File Offset: 0x00244B59
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060075F6 RID: 30198 RVA: 0x0024695B File Offset: 0x00244B5B
	public static void ResetStaticDefaultValue()
	{
		ActivityController._Instance = null;
	}

	// Token: 0x060075F7 RID: 30199 RVA: 0x00246963 File Offset: 0x00244B63
	static ActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityController.CreateStaticDefaultValue), new Action(ActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x060075F9 RID: 30201 RVA: 0x00246995 File Offset: 0x00244B95
	[CompilerGenerated]
	internal static void <ShowActivityRefreshAndBackToBattleView>g__ConfirmCallback|17_0()
	{
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x04004A6D RID: 19053
	[Nullable(2)]
	private TimerHandle CheckActivityTimer;

	// Token: 0x04004A6E RID: 19054
	private bool IsDataInit;

	// Token: 0x04004A6F RID: 19055
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x04004A70 RID: 19056
	private HashSet<Action<float>> RefreshTimerDelegateSet = new HashSet<Action<float>>();

	// Token: 0x04004A71 RID: 19057
	[Nullable(2)]
	private static ActivityController _Instance;
}
