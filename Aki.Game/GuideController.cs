using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.GroupInfo;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x0200127C RID: 4732
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GuideController : UiControllerBase
{
	// Token: 0x0600BB13 RID: 47891 RVA: 0x003722C4 File Offset: 0x003704C4
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.GuideCondDoneNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGuideGroupOpenByServer));
		Net.Instance.Register(ENotifyMessageId.GuideGroupResetNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGuideGroupResetNotify));
	}

	// Token: 0x0600BB14 RID: 47892 RVA: 0x003722FE File Offset: 0x003704FE
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GuideCondDoneNotify);
		Net.Instance.UnRegister(ENotifyMessageId.GuideGroupResetNotify);
	}

	// Token: 0x0600BB15 RID: 47893 RVA: 0x00372320 File Offset: 0x00370520
	[NullableContext(2)]
	private void OnGuideGroupOpenByServer(IMessage msg, Net.CallbackStatus status)
	{
		GuideCondDoneNotify guideCondDoneNotify = (GuideCondDoneNotify)msg;
		if (guideCondDoneNotify == null)
		{
			Log.Instance.Error(ELogModule.Guide, ELogAuthor.TL, "服务端发来的GuideTriggerNotify为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int groupId = guideCondDoneNotify.GroupId;
		this.TryStartGuide(groupId);
	}

	// Token: 0x0600BB16 RID: 47894 RVA: 0x00372364 File Offset: 0x00370564
	[NullableContext(2)]
	private void OnGuideGroupResetNotify(IMessage msg, Net.CallbackStatus status)
	{
		GuideGroupResetNotify guideGroupResetNotify = (GuideGroupResetNotify)msg;
		if (guideGroupResetNotify == null)
		{
			Log.Instance.Error(ELogModule.Guide, ELogAuthor.TZJ, "服务端发来的GuideGroupResetNotify为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (int groupId in guideGroupResetNotify.GroupIds)
		{
			this.ResetFinishedGuide(groupId);
		}
	}

	// Token: 0x0600BB17 RID: 47895 RVA: 0x003723D8 File Offset: 0x003705D8
	private void OnAutoOpenConditionPass([Nullable(new byte[]
	{
		2,
		1
	})] object[] param)
	{
		if (!this.TryStartGuide((int)param[0]))
		{
			EventSystem.Instance.Emit(EEventName.OnGuideTriggerResetEvent);
		}
	}

	// Token: 0x0600BB18 RID: 47896 RVA: 0x003723FC File Offset: 0x003705FC
	private void RegisterEventsForAllAutoOpenConditions()
	{
		foreach (GuideGroup guideGroup in GuideConfig.Instance.GetAllGroup())
		{
			int autoOpenCondition = guideGroup.AutoOpenCondition;
			if (autoOpenCondition != 0)
			{
				int id = guideGroup.Id;
				if (GuideModel.Instance.CanGroupInvoke(id) && !this.AutoOpenConditionCallBackMap.ContainsKey(id))
				{
					ConditionPassCallback conditionPassCallback = new ConditionPassCallback(new TConditionPassCallback(this.OnAutoOpenConditionPass), new object[]
					{
						id
					});
					LevelConditionRegistry.Instance.RegisterConditionGroup(autoOpenCondition, conditionPassCallback);
					this.AutoOpenConditionCallBackMap.Add(id, conditionPassCallback);
				}
			}
		}
	}

	// Token: 0x0600BB19 RID: 47897 RVA: 0x003724B4 File Offset: 0x003706B4
	private void UnRegisterEventsForAllAutoOpenConditions()
	{
		foreach (GuideGroup guideGroup in GuideConfig.Instance.GetAllGroup())
		{
			int autoOpenCondition = guideGroup.AutoOpenCondition;
			if (autoOpenCondition != 0)
			{
				int id = guideGroup.Id;
				ConditionPassCallback conditionPassCallback;
				if (this.AutoOpenConditionCallBackMap.TryGetValue(id, out conditionPassCallback))
				{
					LevelConditionRegistry.Instance.UnRegisterConditionGroup(autoOpenCondition, conditionPassCallback);
					this.AutoOpenConditionCallBackMap.Remove(id);
				}
			}
		}
	}

	// Token: 0x0600BB1A RID: 47898 RVA: 0x0037253C File Offset: 0x0037073C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, bool>(EEventName.GuideGroupOpening, new Action<int, bool>(this.OnGuideGroupOpening));
		EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.OnEnterGameSuccess));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.WorldDone;
		Action handle;
		if ((handle = GuideController.<>O.<0>__OnWorldDone) == null)
		{
			handle = (GuideController.<>O.<0>__OnWorldDone = new Action(GuideController.OnWorldDone));
		}
		instance.Add(name, handle);
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.ActiveBattleView;
		Action handle2;
		if ((handle2 = GuideController.<>O.<1>__OnActiveBattleView) == null)
		{
			handle2 = (GuideController.<>O.<1>__OnActiveBattleView = new Action(GuideController.OnActiveBattleView));
		}
		instance2.Add(name2, handle2);
		EventSystem instance3 = EventSystem.Instance;
		EEventName name3 = EEventName.OnBlackFadeScreenFinish;
		Action handle3;
		if ((handle3 = GuideController.<>O.<2>__OnBlackFadeScreenFinish) == null)
		{
			handle3 = (GuideController.<>O.<2>__OnBlackFadeScreenFinish = new Action(GuideController.OnBlackFadeScreenFinish));
		}
		instance3.Add(name3, handle3);
		EventSystem instance4 = EventSystem.Instance;
		EEventName name4 = EEventName.BattleSettlementStateChanged;
		Action<bool> handle4;
		if ((handle4 = GuideController.<>O.<3>__OnGuideTutorialEnabled) == null)
		{
			handle4 = (GuideController.<>O.<3>__OnGuideTutorialEnabled = new Action<bool>(GuideController.OnGuideTutorialEnabled));
		}
		instance4.Add<bool>(name4, handle4);
		EventSystem.Instance.Add<bool, string>(EEventName.OnCameraSequenceSetUiVisible, new Action<bool, string>(this.OnCameraSequenceSetUiVisible));
		EventSystem instance5 = EventSystem.Instance;
		EEventName name5 = EEventName.OnGuideTriggerEvent;
		Action<string> handle5;
		if ((handle5 = GuideController.<>O.<4>__LogGuideTriggerEvent) == null)
		{
			handle5 = (GuideController.<>O.<4>__LogGuideTriggerEvent = new Action<string>(GuideController.LogGuideTriggerEvent));
		}
		instance5.Add<string>(name5, handle5);
		EventSystem instance6 = EventSystem.Instance;
		EEventName name6 = EEventName.NotifyGuideBreakFocus;
		Action handle6;
		if ((handle6 = GuideController.<>O.<5>__OnNotifyGuideBreakFocus) == null)
		{
			handle6 = (GuideController.<>O.<5>__OnNotifyGuideBreakFocus = new Action(GuideController.OnNotifyGuideBreakFocus));
		}
		instance6.Add(name6, handle6);
	}

	// Token: 0x0600BB1B RID: 47899 RVA: 0x003726D4 File Offset: 0x003708D4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.GuideGroupOpening, new Action<int, bool>(this.OnGuideGroupOpening));
		EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.OnEnterGameSuccess));
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.WorldDone;
		Action handle;
		if ((handle = GuideController.<>O.<0>__OnWorldDone) == null)
		{
			handle = (GuideController.<>O.<0>__OnWorldDone = new Action(GuideController.OnWorldDone));
		}
		instance.Remove(name, handle);
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.ActiveBattleView;
		Action handle2;
		if ((handle2 = GuideController.<>O.<1>__OnActiveBattleView) == null)
		{
			handle2 = (GuideController.<>O.<1>__OnActiveBattleView = new Action(GuideController.OnActiveBattleView));
		}
		instance2.Remove(name2, handle2);
		EventSystem instance3 = EventSystem.Instance;
		EEventName name3 = EEventName.OnBlackFadeScreenFinish;
		Action handle3;
		if ((handle3 = GuideController.<>O.<2>__OnBlackFadeScreenFinish) == null)
		{
			handle3 = (GuideController.<>O.<2>__OnBlackFadeScreenFinish = new Action(GuideController.OnBlackFadeScreenFinish));
		}
		instance3.Remove(name3, handle3);
		EventSystem instance4 = EventSystem.Instance;
		EEventName name4 = EEventName.BattleSettlementStateChanged;
		Action<bool> handle4;
		if ((handle4 = GuideController.<>O.<3>__OnGuideTutorialEnabled) == null)
		{
			handle4 = (GuideController.<>O.<3>__OnGuideTutorialEnabled = new Action<bool>(GuideController.OnGuideTutorialEnabled));
		}
		instance4.Remove(name4, handle4);
		EventSystem.Instance.Remove(EEventName.OnCameraSequenceSetUiVisible, new Action<bool, string>(this.OnCameraSequenceSetUiVisible));
		EventSystem instance5 = EventSystem.Instance;
		EEventName name5 = EEventName.OnGuideTriggerEvent;
		Action<string> handle5;
		if ((handle5 = GuideController.<>O.<4>__LogGuideTriggerEvent) == null)
		{
			handle5 = (GuideController.<>O.<4>__LogGuideTriggerEvent = new Action<string>(GuideController.LogGuideTriggerEvent));
		}
		instance5.Remove(name5, handle5);
		EventSystem instance6 = EventSystem.Instance;
		EEventName name6 = EEventName.NotifyGuideBreakFocus;
		Action handle6;
		if ((handle6 = GuideController.<>O.<5>__OnNotifyGuideBreakFocus) == null)
		{
			handle6 = (GuideController.<>O.<5>__OnNotifyGuideBreakFocus = new Action(GuideController.OnNotifyGuideBreakFocus));
		}
		instance6.Remove(name6, handle6);
		this.UnRegisterEventsForAllAutoOpenConditions();
	}

	// Token: 0x0600BB1C RID: 47900 RVA: 0x00372874 File Offset: 0x00370A74
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName guideTutorialView = EUiViewName.GuideTutorialView;
		Func<EUiViewName, object, bool> func;
		if ((func = GuideController.<>O.<6>__CanOpenTutorial) == null)
		{
			func = (GuideController.<>O.<6>__CanOpenTutorial = new Func<EUiViewName, object, bool>(GuideController.CanOpenTutorial));
		}
		instance.AddOpenViewCheckFunction(guideTutorialView, func, "GuideController.CanOpenTutorial");
		UiManager instance2 = UiManager.Instance;
		EUiViewName guideTutorialPopView = EUiViewName.GuideTutorialPopView;
		Func<EUiViewName, object, bool> func2;
		if ((func2 = GuideController.<>O.<6>__CanOpenTutorial) == null)
		{
			func2 = (GuideController.<>O.<6>__CanOpenTutorial = new Func<EUiViewName, object, bool>(GuideController.CanOpenTutorial));
		}
		instance2.AddOpenViewCheckFunction(guideTutorialPopView, func2, "GuideController.CanOpenTutorial");
	}

	// Token: 0x0600BB1D RID: 47901 RVA: 0x003728DF File Offset: 0x00370ADF
	private static void LogGuideTriggerEvent(string name)
	{
	}

	// Token: 0x0600BB1E RID: 47902 RVA: 0x003728E1 File Offset: 0x00370AE1
	private static bool CanOpenTutorial(EUiViewName viewName, object param)
	{
		return !BattleUiModel.Instance.IsInBattleSettlement;
	}

	// Token: 0x0600BB1F RID: 47903 RVA: 0x003728F0 File Offset: 0x00370AF0
	public void InvokeGuideGroupByGm(int groupId, bool isfake)
	{
		GuideModel.Instance.IsGmInvoke = true;
		GuideGroupInfo guideGroupInfo = GuideModel.Instance.TryGetGuideGroup(groupId);
		GuideModel.Instance.IsGmInvoke = false;
		if (guideGroupInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "引导组  数据创建失败！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		guideGroupInfo.IsFake = isfake;
		if (!isfake)
		{
			this.TryStartGuide(groupId);
			return;
		}
		EGuideGroupState? currentState = guideGroupInfo.StateMachine.CurrentState;
		EGuideGroupState eguideGroupState = EGuideGroupState.Init;
		if (!(currentState.GetValueOrDefault() == eguideGroupState & currentState != null))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "(GM)引导组  正在执行中, 不再重复执行";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("group.Id", guideGroupInfo.Id);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		guideGroupInfo.SwitchState(EGuideGroupState.Executing);
	}

	// Token: 0x0600BB20 RID: 47904 RVA: 0x003729C0 File Offset: 0x00370BC0
	private void OnGuideGroupOpening(int groupId, bool isPreExecute)
	{
		GuideTriggerRequest guideTriggerRequest = GuideTriggerRequest.Create();
		guideTriggerRequest.GroupId = groupId;
		Net.Instance.Call(ERequestMessageId.GuideTriggerRequest, guideTriggerRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			GuideTriggerResponse guideTriggerResponse = (GuideTriggerResponse)msg;
			if (guideTriggerResponse == null || guideTriggerResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				GuideModel.Instance.SwitchGroupState(groupId, EGuideGroupState.Init);
				if (guideTriggerResponse != null)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(guideTriggerResponse.ErrorCode, 25835, guideTriggerResponse.ErrorParams, true, true);
				}
				return;
			}
			if (isPreExecute)
			{
				return;
			}
			GuideModel.Instance.SwitchGroupState(groupId, EGuideGroupState.Executing);
		}, 0);
	}

	// Token: 0x0600BB21 RID: 47905 RVA: 0x00372A10 File Offset: 0x00370C10
	public unsafe void FinishGuide(int groupId, bool isFake = false)
	{
		if (isFake)
		{
			this.OnGuideFinished(groupId);
			return;
		}
		GuideFinishRequest guideFinishRequest = GuideFinishRequest.Create();
		guideFinishRequest.GroupId = groupId;
		Net.Instance.Call(ERequestMessageId.GuideFinishRequest, guideFinishRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			GuideFinishResponse guideFinishResponse = (GuideFinishResponse)msg;
			if (guideFinishResponse == null || guideFinishResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				Aki.Protocol.ErrorCode? errorCode = (guideFinishResponse != null) ? new Aki.Protocol.ErrorCode?(guideFinishResponse.ErrorCode) : null;
				bool flag = guideFinishResponse == null;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "引导请求服务端完成失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("组Id", groupId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("errorCode", errorCode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("responseNull", flag);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			this.OnGuideFinished(groupId);
		}, 0);
	}

	// Token: 0x0600BB22 RID: 47906 RVA: 0x00372A70 File Offset: 0x00370C70
	private static void OnNotifyGuideBreakFocus()
	{
		GuideModel.Instance.BreakTypeViewStep(EGuideViewType.GuideFocus);
	}

	// Token: 0x0600BB23 RID: 47907 RVA: 0x00372A7D File Offset: 0x00370C7D
	private static void OnActiveBattleView()
	{
		GuideModel.Instance.ShowFailedOpenTutorialView();
	}

	// Token: 0x0600BB24 RID: 47908 RVA: 0x00372A89 File Offset: 0x00370C89
	private static void OnBlackFadeScreenFinish()
	{
		GuideModel.Instance.ShowFailedOpenTutorialView();
	}

	// Token: 0x0600BB25 RID: 47909 RVA: 0x00372A95 File Offset: 0x00370C95
	private static void OnGuideTutorialEnabled(bool state)
	{
		GuideModel.Instance.ShowFailedOpenTutorialView();
	}

	// Token: 0x0600BB26 RID: 47910 RVA: 0x00372AA1 File Offset: 0x00370CA1
	private static void OnWorldDone()
	{
		GuideModel.Instance.EnsureCurrentDungeonId();
	}

	// Token: 0x0600BB27 RID: 47911 RVA: 0x00372AB0 File Offset: 0x00370CB0
	private void OnWorldDoneAndCloseLoading()
	{
		Dictionary<int, GuideGroupInfo> currentGroupMap = GuideModel.Instance.CurrentGroupMap;
		if (currentGroupMap != null)
		{
			foreach (int num in this.OnWorldDoneGuideKillList)
			{
				GuideGroupInfo guideGroupInfo;
				if (currentGroupMap.TryGetValue(num, out guideGroupInfo))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Guide;
					ELogAuthor author = ELogAuthor.TL;
					string message = "引导组在场景加载完成（包括客户端加载和服务器交互确认）前被触发，强制终止引导";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GuideGroupId", num);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					guideGroupInfo.Break();
					currentGroupMap.Remove(num);
				}
			}
		}
	}

	// Token: 0x0600BB28 RID: 47912 RVA: 0x00372B2E File Offset: 0x00370D2E
	public void GmCleanGuideData()
	{
		GuideModel.Instance.GmResetAllGuideGroup();
		this.UnRegisterEventsForAllAutoOpenConditions();
		this.RegisterEventsForAllAutoOpenConditions();
	}

	// Token: 0x0600BB29 RID: 47913 RVA: 0x00372B46 File Offset: 0x00370D46
	public void OnGmCleanGuideGroupDataByGroupId(int groupId)
	{
		this.ResetFinishedGuide(groupId);
	}

	// Token: 0x0600BB2A RID: 47914 RVA: 0x00372B50 File Offset: 0x00370D50
	private void OnEnterGameSuccess()
	{
		GuideInfoRequest message = GuideInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.GuideInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			GuideInfoResponse guideInfoResponse = (GuideInfoResponse)msg;
			if (guideInfoResponse == null)
			{
				Log.Instance.Error(ELogModule.Guide, ELogAuthor.TL, "服务端发来的GuideInfoNotify为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (int groupId in guideInfoResponse.GuideGroupFinishList)
			{
				GuideModel.Instance.FinishGroup(groupId);
			}
			this.RegisterEventsForAllAutoOpenConditions();
		}, 0);
	}

	// Token: 0x0600BB2B RID: 47915 RVA: 0x00372B80 File Offset: 0x00370D80
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		GuideModel.Instance.ClearAllGroup();
	}

	// Token: 0x0600BB2C RID: 47916 RVA: 0x00372B8C File Offset: 0x00370D8C
	private void OnCameraSequenceSetUiVisible(bool isVisible, string cameraName)
	{
		if (cameraName != "MainCamera")
		{
			return;
		}
		GuideModel.Instance.ShouldBlockGuideBecauseUiNotRender = !isVisible;
	}

	// Token: 0x0600BB2D RID: 47917 RVA: 0x00372BAC File Offset: 0x00370DAC
	public bool TryStartGuide(int guideId)
	{
		GuideGroupInfo guideGroupInfo = GuideModel.Instance.TryGetGuideGroup(guideId);
		if (guideGroupInfo == null)
		{
			return false;
		}
		guideGroupInfo.SwitchState(EGuideGroupState.Opening);
		return true;
	}

	// Token: 0x0600BB2E RID: 47918 RVA: 0x00372BD4 File Offset: 0x00370DD4
	public bool TryFinishGuide(int guideId)
	{
		if (GuideModel.Instance.IsGroupFinished(guideId).Value)
		{
			return false;
		}
		this.FinishGuide(guideId, false);
		return true;
	}

	// Token: 0x0600BB2F RID: 47919 RVA: 0x00372C04 File Offset: 0x00370E04
	public void TryFinishRunningGuides()
	{
		foreach (int guideId in GuideModel.Instance.GetRunningGroupIdList())
		{
			this.TryFinishGuide(guideId);
		}
	}

	// Token: 0x0600BB30 RID: 47920 RVA: 0x00372C38 File Offset: 0x00370E38
	public void FinishGuideGm(int groupId)
	{
		if (!GuideModel.Instance.CheckGuideInfoExist(groupId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "引导GM命令请求完成时错误, 当前引导数据不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("引导Id", groupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.OnGuideFinished(groupId);
	}

	// Token: 0x0600BB31 RID: 47921 RVA: 0x00372C86 File Offset: 0x00370E86
	private void OnGuideFinished(int groupId)
	{
		GuideModel.Instance.FinishGroup(groupId);
		this.UnRegisterEventsForAutoOpenCondition(groupId);
		EventSystem.Instance.Emit<int>(EEventName.GuideGroupFinished, groupId);
	}

	// Token: 0x0600BB32 RID: 47922 RVA: 0x00372CAC File Offset: 0x00370EAC
	public void ResetFinishedGuide(int groupId)
	{
		if (!GuideModel.Instance.IsGroupFinished(groupId).Value)
		{
			return;
		}
		GuideModel.Instance.ResetFinishedGuide(groupId);
		this.RegisterEventsForAutoOpenCondition(groupId);
	}

	// Token: 0x0600BB33 RID: 47923 RVA: 0x00372CE4 File Offset: 0x00370EE4
	private void RegisterEventsForAutoOpenCondition(int groupId)
	{
		if (this.AutoOpenConditionCallBackMap.ContainsKey(groupId))
		{
			return;
		}
		if (!GuideModel.Instance.CanGroupInvoke(groupId))
		{
			return;
		}
		GuideGroup? group = GuideConfig.Instance.GetGroup(groupId);
		if (group == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "注册引导自动触发条件时配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		int autoOpenCondition = group.Value.AutoOpenCondition;
		if (autoOpenCondition == 0)
		{
			return;
		}
		ConditionPassCallback conditionPassCallback = new ConditionPassCallback(new TConditionPassCallback(this.OnAutoOpenConditionPass), new object[]
		{
			groupId
		});
		LevelConditionRegistry.Instance.RegisterConditionGroup(autoOpenCondition, conditionPassCallback);
		this.AutoOpenConditionCallBackMap.Add(groupId, conditionPassCallback);
	}

	// Token: 0x0600BB34 RID: 47924 RVA: 0x00372DA0 File Offset: 0x00370FA0
	private void UnRegisterEventsForAutoOpenCondition(int groupId)
	{
		ConditionPassCallback conditionPassCallback;
		if (!this.AutoOpenConditionCallBackMap.TryGetValue(groupId, out conditionPassCallback))
		{
			return;
		}
		if (GuideModel.Instance.CanGroupInvoke(groupId))
		{
			return;
		}
		int autoOpenCondition = GuideConfig.Instance.GetGroup(groupId).Value.AutoOpenCondition;
		if (autoOpenCondition == 0)
		{
			return;
		}
		LevelConditionRegistry.Instance.UnRegisterConditionGroup(autoOpenCondition, conditionPassCallback);
		this.AutoOpenConditionCallBackMap.Remove(groupId);
	}

	// Token: 0x0600BB35 RID: 47925 RVA: 0x00372E05 File Offset: 0x00371005
	public bool CheckAvailableWhenOnline(EGuideOnlineMode modeInGuideCfg)
	{
		if (GameModeModel.Instance.IsMulti)
		{
			if (modeInGuideCfg != EGuideOnlineMode.OffOnly)
			{
				return true;
			}
		}
		else if (modeInGuideCfg != EGuideOnlineMode.OnOnly)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BB36 RID: 47926 RVA: 0x00372E20 File Offset: 0x00371020
	public bool CheckHasNewTagInHookNameForShow(GuideFocusNew config)
	{
		return config.HookNameForShow.Contains("New:") || (config.ExtraParam().Length != 0 && config.ExtraParam()[0].Contains("New:"));
	}

	// Token: 0x0600BB37 RID: 47927 RVA: 0x00372E58 File Offset: 0x00371058
	public UniTask WaitForCurrentTutorialFinish()
	{
		GuideController.<WaitForCurrentTutorialFinish>d__38 <WaitForCurrentTutorialFinish>d__;
		<WaitForCurrentTutorialFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForCurrentTutorialFinish>d__.<>1__state = -1;
		<WaitForCurrentTutorialFinish>d__.<>t__builder.Start<GuideController.<WaitForCurrentTutorialFinish>d__38>(ref <WaitForCurrentTutorialFinish>d__);
		return <WaitForCurrentTutorialFinish>d__.<>t__builder.Task;
	}

	// Token: 0x1700129A RID: 4762
	// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x00372E93 File Offset: 0x00371093
	// (set) Token: 0x0600BB39 RID: 47929 RVA: 0x00372E9B File Offset: 0x0037109B
	public bool GmEnableFocusTextPosTick
	{
		get
		{
			return this.GmEnableFocusTextPosTickInternal;
		}
		set
		{
			this.GmEnableFocusTextPosTickInternal = value;
		}
	}

	// Token: 0x1700129B RID: 4763
	// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x00372EA4 File Offset: 0x003710A4
	public static GuideController Instance
	{
		get
		{
			return GuideController._Instance;
		}
	}

	// Token: 0x0600BB3B RID: 47931 RVA: 0x00372EAB File Offset: 0x003710AB
	public static GuideController GetOrCreateInstance()
	{
		if (GuideController._Instance == null)
		{
			GuideController.CreateInstance();
		}
		return GuideController._Instance;
	}

	// Token: 0x0600BB3C RID: 47932 RVA: 0x00372EBF File Offset: 0x003710BF
	public static bool CreateInstance()
	{
		if (GuideController._Instance != null)
		{
			return true;
		}
		GuideController._Instance = new GuideController();
		return true;
	}

	// Token: 0x0600BB3D RID: 47933 RVA: 0x00372ED5 File Offset: 0x003710D5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BB3E RID: 47934 RVA: 0x00372ED7 File Offset: 0x003710D7
	public static void ResetStaticDefaultValue()
	{
		GuideController._Instance = null;
	}

	// Token: 0x0600BB3F RID: 47935 RVA: 0x00372EDF File Offset: 0x003710DF
	static GuideController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideController.CreateStaticDefaultValue), new Action(GuideController.ResetStaticDefaultValue));
	}

	// Token: 0x04006BC8 RID: 27592
	private readonly Dictionary<int, ConditionPassCallback> AutoOpenConditionCallBackMap = new Dictionary<int, ConditionPassCallback>();

	// Token: 0x04006BC9 RID: 27593
	private readonly int[] OnWorldDoneGuideKillList = new int[]
	{
		20013
	};

	// Token: 0x04006BCA RID: 27594
	private bool GmEnableFocusTextPosTickInternal = true;

	// Token: 0x04006BCB RID: 27595
	[Nullable(2)]
	private static GuideController _Instance;

	// Token: 0x02007514 RID: 29972
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040260E8 RID: 155880
		[Nullable(0)]
		public static Action <0>__OnWorldDone;

		// Token: 0x040260E9 RID: 155881
		[Nullable(0)]
		public static Action <1>__OnActiveBattleView;

		// Token: 0x040260EA RID: 155882
		[Nullable(0)]
		public static Action <2>__OnBlackFadeScreenFinish;

		// Token: 0x040260EB RID: 155883
		[Nullable(0)]
		public static Action<bool> <3>__OnGuideTutorialEnabled;

		// Token: 0x040260EC RID: 155884
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <4>__LogGuideTriggerEvent;

		// Token: 0x040260ED RID: 155885
		[Nullable(0)]
		public static Action <5>__OnNotifyGuideBreakFocus;

		// Token: 0x040260EE RID: 155886
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EUiViewName, object, bool> <6>__CanOpenTutorial;
	}
}
