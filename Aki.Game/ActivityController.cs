using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001670 RID: 5744
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityController : ControllerBase
{
	// Token: 0x0600A1E7 RID: 41447 RVA: 0x0023C0E8 File Offset: 0x0023A2E8
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

	// Token: 0x0600A1E8 RID: 41448 RVA: 0x0023C124 File Offset: 0x0023A324
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

	// Token: 0x0600A1E9 RID: 41449 RVA: 0x0023C151 File Offset: 0x0023A351
	public void EnableRefreshTimer(float interval)
	{
		if (this.RefreshTimer != null)
		{
			return;
		}
		this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshTimer), interval, 1f, null, null, true);
	}

	// Token: 0x0600A1EA RID: 41450 RVA: 0x0023C181 File Offset: 0x0023A381
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

	// Token: 0x0600A1EB RID: 41451 RVA: 0x0023C1AF File Offset: 0x0023A3AF
	public void RegisterRefreshTimerDelegate(Action<float> @delegate)
	{
		this.RefreshTimerDelegateSet.Add(@delegate);
	}

	// Token: 0x0600A1EC RID: 41452 RVA: 0x0023C1BE File Offset: 0x0023A3BE
	public void UnregisterRefreshTimerDelegate(Action<float> @delegate)
	{
		this.RefreshTimerDelegateSet.Remove(@delegate);
	}

	// Token: 0x0600A1ED RID: 41453 RVA: 0x0023C1D0 File Offset: 0x0023A3D0
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

	// Token: 0x0600A1EE RID: 41454 RVA: 0x0023C230 File Offset: 0x0023A430
	private void OpenActivityView()
	{
		this.OpenActivityById(0, EActivityViewOpenType.HotKey, null, null);
	}

	// Token: 0x0600A1EF RID: 41455 RVA: 0x0023C23D File Offset: 0x0023A43D
	protected void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.CommonActivityView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "ActivityController.CheckCanOpen");
	}

	// Token: 0x0600A1F0 RID: 41456 RVA: 0x0023C25F File Offset: 0x0023A45F
	protected void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.CommonActivityView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
	}

	// Token: 0x0600A1F1 RID: 41457 RVA: 0x0023C27C File Offset: 0x0023A47C
	public bool CheckCanOpen(EUiViewName viewName, object param)
	{
		if (!FunctionModel.Instance.IsOpen(10053))
		{
			GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
			return false;
		}
		return ActivityModel.Instance.GetCurrentShowingActivities().Count != 0;
	}

	// Token: 0x0600A1F2 RID: 41458 RVA: 0x0023C2B7 File Offset: 0x0023A4B7
	public bool CheckCanOpenWithoutPrompt()
	{
		return FunctionModel.Instance.IsOpen(10053) && ActivityModel.Instance.GetCurrentShowingActivities().Count != 0;
	}

	// Token: 0x0600A1F3 RID: 41459 RVA: 0x0023C2DE File Offset: 0x0023A4DE
	private void CheckActivityActiveState()
	{
		ActivityModel.Instance.RefreshShowingActivities();
	}

	// Token: 0x0600A1F4 RID: 41460 RVA: 0x0023C2EC File Offset: 0x0023A4EC
	public void ShowActivityRefreshAndBackToBattleView()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
		confirmBoxDataNew.FunctionMap.Add(1, new Action(ActivityController.<ShowActivityRefreshAndBackToBattleView>g__ConfirmCallback|17_0));
		confirmBoxDataNew.FunctionMap.Add(0, new Action(ActivityController.<ShowActivityRefreshAndBackToBattleView>g__ConfirmCallback|17_0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A1F5 RID: 41461 RVA: 0x0023C340 File Offset: 0x0023A540
	private void ShowActivityClose()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AllActivityClose);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A1F6 RID: 41462 RVA: 0x0023C364 File Offset: 0x0023A564
	private void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(this.InitActivityLocalRedPointData));
		EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x0600A1F7 RID: 41463 RVA: 0x0023C41C File Offset: 0x0023A61C
	private void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(this.InitActivityLocalRedPointData));
		EventSystem.Instance.Remove(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x0600A1F8 RID: 41464 RVA: 0x0023C4D1 File Offset: 0x0023A6D1
	private void OnReceiveActivityData(int type, IReadOnlyList<int> activityIds)
	{
		this.InitActivity(type);
	}

	// Token: 0x0600A1F9 RID: 41465 RVA: 0x0023C4DA File Offset: 0x0023A6DA
	public void InitActivity(int type)
	{
	}

	// Token: 0x0600A1FA RID: 41466 RVA: 0x0023C4DC File Offset: 0x0023A6DC
	private void InitActivityLocalRedPointData()
	{
		ActivityModel.Instance.InitCache();
	}

	// Token: 0x0600A1FB RID: 41467 RVA: 0x0023C4E8 File Offset: 0x0023A6E8
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ActivityUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.ActivityDisableNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityDisableNotify));
	}

	// Token: 0x0600A1FC RID: 41468 RVA: 0x0023C522 File Offset: 0x0023A722
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ActivityUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ActivityDisableNotify);
	}

	// Token: 0x0600A1FD RID: 41469 RVA: 0x0023C544 File Offset: 0x0023A744
	private void OnDataDone()
	{
		this.InitTimer();
	}

	// Token: 0x0600A1FE RID: 41470 RVA: 0x0023C54C File Offset: 0x0023A74C
	private void OnWorldDone()
	{
		if (!this.IsDataInit)
		{
			this.IsDataInit = true;
			GameModeController.Instance.AddWorldDoneBlocker(new Func<UniTask>(this.InitActivityDataOnWorldDone), 60000);
		}
	}

	// Token: 0x0600A1FF RID: 41471 RVA: 0x0023C578 File Offset: 0x0023A778
	private UniTask InitActivityDataOnWorldDone()
	{
		ActivityController.<InitActivityDataOnWorldDone>d__28 <InitActivityDataOnWorldDone>d__;
		<InitActivityDataOnWorldDone>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitActivityDataOnWorldDone>d__.<>4__this = this;
		<InitActivityDataOnWorldDone>d__.<>1__state = -1;
		<InitActivityDataOnWorldDone>d__.<>t__builder.Start<ActivityController.<InitActivityDataOnWorldDone>d__28>(ref <InitActivityDataOnWorldDone>d__);
		return <InitActivityDataOnWorldDone>d__.<>t__builder.Task;
	}

	// Token: 0x0600A200 RID: 41472 RVA: 0x0023C5BC File Offset: 0x0023A7BC
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

	// Token: 0x0600A201 RID: 41473 RVA: 0x0023C624 File Offset: 0x0023A824
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

	// Token: 0x0600A202 RID: 41474 RVA: 0x0023C651 File Offset: 0x0023A851
	private void CancelTimer()
	{
		if (this.CheckActivityTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CheckActivityTimer);
			this.CheckActivityTimer = null;
		}
	}

	// Token: 0x0600A203 RID: 41475 RVA: 0x0023C673 File Offset: 0x0023A873
	private void InitTimer()
	{
		this.CancelTimer();
		this.CheckActivityTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnCheckActivityTimer), 600000f, 1f, null, null, false);
	}

	// Token: 0x0600A204 RID: 41476 RVA: 0x0023C6A4 File Offset: 0x0023A8A4
	private void OnCheckActivityTimer(float delta)
	{
		this.RequestActivityData();
	}

	// Token: 0x0600A205 RID: 41477 RVA: 0x0023C6B0 File Offset: 0x0023A8B0
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

	// Token: 0x0600A206 RID: 41478 RVA: 0x0023C767 File Offset: 0x0023A967
	public void OpenActivityContentView(ActivityBaseData data)
	{
		ActivityManager.GetActivityController(data.Type).OpenView(data);
	}

	// Token: 0x0600A207 RID: 41479 RVA: 0x0023C77C File Offset: 0x0023A97C
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

	// Token: 0x0600A208 RID: 41480 RVA: 0x0023C7C8 File Offset: 0x0023A9C8
	[NullableContext(2)]
	public void JumpAndLog([Nullable(1)] ActivityBaseData data, EUiViewName unlockedJumpToViewName, object param = null, TOpenViewCallBack finishCallback = null)
	{
		this.JumpToViewOrOpenPreGuideQuest(data, unlockedJumpToViewName, param ?? data, finishCallback);
		ActivityModel.Instance.SendActivityViewJumpClickLogData(data);
	}

	// Token: 0x0600A209 RID: 41481 RVA: 0x0023C7E5 File Offset: 0x0023A9E5
	public void JumpAndLog(ActivityBaseData data, Action onClicked)
	{
		onClicked();
		ActivityModel.Instance.SendActivityViewJumpClickLogData(data);
	}

	// Token: 0x0600A20A RID: 41482 RVA: 0x0023C7F8 File Offset: 0x0023A9F8
	public void JumpAndLog(ActivityBaseData data, Action<ActivityViewJumpClickLogData> onClicked)
	{
		ActivityViewJumpClickLogData defaultActivityViewJumpClickLogData = ActivityModel.Instance.GetDefaultActivityViewJumpClickLogData(data);
		onClicked(defaultActivityViewJumpClickLogData);
		ActivityModel.Instance.SendActivityViewJumpClickLogData(defaultActivityViewJumpClickLogData);
	}

	// Token: 0x0600A20B RID: 41483 RVA: 0x0023C824 File Offset: 0x0023AA24
	[NullableContext(0)]
	public UniTask<bool> RequestActivityData()
	{
		ActivityController.<RequestActivityData>d__40 <RequestActivityData>d__;
		<RequestActivityData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestActivityData>d__.<>1__state = -1;
		<RequestActivityData>d__.<>t__builder.Start<ActivityController.<RequestActivityData>d__40>(ref <RequestActivityData>d__);
		return <RequestActivityData>d__.<>t__builder.Task;
	}

	// Token: 0x0600A20C RID: 41484 RVA: 0x0023C860 File Offset: 0x0023AA60
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(activityFirstReadResponse.ErrorCode, 25958, null, true, true);
				}
				ActivityModel.Instance.OnReceiveActivityRead(activityData.Id);
			}, 0);
		}
		ActivityModel.Instance.OnReceiveActivityRead(activityData.Id);
	}

	// Token: 0x0600A20D RID: 41485 RVA: 0x0023C8D8 File Offset: 0x0023AAD8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(activityPreOpenResponse.ErrorCode, 26244, null, true, true);
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

	// Token: 0x0600A20E RID: 41486 RVA: 0x0023C948 File Offset: 0x0023AB48
	[NullableContext(2)]
	private void OnActivityUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		ActivityUpdateNotify activityUpdateNotify = (ActivityUpdateNotify)msg;
		ActivityModel.Instance.OnActivityUpdate(activityUpdateNotify.Activities.ToArray<ActivityData>());
		this.CheckActivityActiveState();
	}

	// Token: 0x0600A20F RID: 41487 RVA: 0x0023C978 File Offset: 0x0023AB78
	[NullableContext(2)]
	private void OnActivityDisableNotify(IMessage msg, Net.CallbackStatus status)
	{
		ActivityDisableNotify activityDisableNotify = (ActivityDisableNotify)msg;
		ActivityModel.Instance.OnDisableActivity(activityDisableNotify.ActivityIds.ToArray<int>());
		this.CheckActivityActiveState();
	}

	// Token: 0x0600A210 RID: 41488 RVA: 0x0023C9A7 File Offset: 0x0023ABA7
	public ActivityBaseData CreateActivityData(ActivityData data)
	{
		return ActivityManager.GetActivityController(data.Type).CreateActivityData(data);
	}

	// Token: 0x0600A211 RID: 41489 RVA: 0x0023C9BA File Offset: 0x0023ABBA
	public bool IsOpeningActivityRelativeView(int type)
	{
		IActivityControllerBase activityController = ActivityManager.GetActivityController(type);
		return activityController != null && activityController.GetIsOpeningActivityRelativeView();
	}

	// Token: 0x0600A212 RID: 41490 RVA: 0x0023C9D0 File Offset: 0x0023ABD0
	public void OpenActivityConditionView(int activityId)
	{
		if (activityId != 0)
		{
			ActivityConditionGroupData param = new ActivityConditionGroupData(activityId);
			UiManager.Instance.OpenView(EUiViewName.ActivityConditionView, param, null);
		}
	}

	// Token: 0x0600A213 RID: 41491 RVA: 0x0023C9F8 File Offset: 0x0023ABF8
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

	// Token: 0x17000DA6 RID: 3494
	// (get) Token: 0x0600A214 RID: 41492 RVA: 0x0023CA98 File Offset: 0x0023AC98
	public static ActivityController Instance
	{
		get
		{
			return ActivityController._Instance;
		}
	}

	// Token: 0x0600A215 RID: 41493 RVA: 0x0023CA9F File Offset: 0x0023AC9F
	public static ActivityController GetOrCreateInstance()
	{
		if (ActivityController._Instance == null)
		{
			ActivityController.CreateInstance();
		}
		return ActivityController._Instance;
	}

	// Token: 0x0600A216 RID: 41494 RVA: 0x0023CAB3 File Offset: 0x0023ACB3
	public static bool CreateInstance()
	{
		if (ActivityController._Instance != null)
		{
			return true;
		}
		ActivityController._Instance = new ActivityController();
		return true;
	}

	// Token: 0x0600A217 RID: 41495 RVA: 0x0023CAC9 File Offset: 0x0023ACC9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A218 RID: 41496 RVA: 0x0023CACB File Offset: 0x0023ACCB
	public static void ResetStaticDefaultValue()
	{
		ActivityController._Instance = null;
	}

	// Token: 0x0600A219 RID: 41497 RVA: 0x0023CAD3 File Offset: 0x0023ACD3
	static ActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityController.CreateStaticDefaultValue), new Action(ActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x0600A21B RID: 41499 RVA: 0x0023CB05 File Offset: 0x0023AD05
	[CompilerGenerated]
	internal static void <ShowActivityRefreshAndBackToBattleView>g__ConfirmCallback|17_0()
	{
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x040049C7 RID: 18887
	[Nullable(2)]
	private TimerHandle CheckActivityTimer;

	// Token: 0x040049C8 RID: 18888
	private bool IsDataInit;

	// Token: 0x040049C9 RID: 18889
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x040049CA RID: 18890
	private HashSet<Action<float>> RefreshTimerDelegateSet = new HashSet<Action<float>>();

	// Token: 0x040049CB RID: 18891
	[Nullable(2)]
	private static ActivityController _Instance;
}
