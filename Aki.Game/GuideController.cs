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

// Token: 0x02001DBA RID: 7610
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GuideController : UiControllerBase
{
	// Token: 0x0600E6F5 RID: 59125 RVA: 0x00366664 File Offset: 0x00364864
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.GuideCondDoneNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGuideGroupOpenByServer));
		Net.Instance.Register(ENotifyMessageId.GuideGroupResetNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGuideGroupResetNotify));
	}

	// Token: 0x0600E6F6 RID: 59126 RVA: 0x0036669E File Offset: 0x0036489E
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GuideCondDoneNotify);
		Net.Instance.UnRegister(ENotifyMessageId.GuideGroupResetNotify);
	}

	// Token: 0x0600E6F7 RID: 59127 RVA: 0x003666C0 File Offset: 0x003648C0
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

	// Token: 0x0600E6F8 RID: 59128 RVA: 0x00366704 File Offset: 0x00364904
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

	// Token: 0x0600E6F9 RID: 59129 RVA: 0x00366778 File Offset: 0x00364978
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

	// Token: 0x0600E6FA RID: 59130 RVA: 0x0036679C File Offset: 0x0036499C
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

	// Token: 0x0600E6FB RID: 59131 RVA: 0x00366854 File Offset: 0x00364A54
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

	// Token: 0x0600E6FC RID: 59132 RVA: 0x003668DC File Offset: 0x00364ADC
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

	// Token: 0x0600E6FD RID: 59133 RVA: 0x00366A74 File Offset: 0x00364C74
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

	// Token: 0x0600E6FE RID: 59134 RVA: 0x00366C14 File Offset: 0x00364E14
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

	// Token: 0x0600E6FF RID: 59135 RVA: 0x00366C7F File Offset: 0x00364E7F
	private static void LogGuideTriggerEvent(string name)
	{
	}

	// Token: 0x0600E700 RID: 59136 RVA: 0x00366C81 File Offset: 0x00364E81
	private static bool CanOpenTutorial(EUiViewName viewName, object param)
	{
		return !BattleUiModel.Instance.IsInBattleSettlement;
	}

	// Token: 0x0600E701 RID: 59137 RVA: 0x00366C90 File Offset: 0x00364E90
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

	// Token: 0x0600E702 RID: 59138 RVA: 0x00366D60 File Offset: 0x00364F60
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(guideTriggerResponse.ErrorCode, 25821, guideTriggerResponse.ErrorParams, true, true);
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

	// Token: 0x0600E703 RID: 59139 RVA: 0x00366DB0 File Offset: 0x00364FB0
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

	// Token: 0x0600E704 RID: 59140 RVA: 0x00366E10 File Offset: 0x00365010
	private static void OnNotifyGuideBreakFocus()
	{
		GuideModel.Instance.BreakTypeViewStep(EGuideViewType.GuideFocus);
	}

	// Token: 0x0600E705 RID: 59141 RVA: 0x00366E1D File Offset: 0x0036501D
	private static void OnActiveBattleView()
	{
		GuideModel.Instance.ShowFailedOpenTutorialView();
	}

	// Token: 0x0600E706 RID: 59142 RVA: 0x00366E29 File Offset: 0x00365029
	private static void OnBlackFadeScreenFinish()
	{
		GuideModel.Instance.ShowFailedOpenTutorialView();
	}

	// Token: 0x0600E707 RID: 59143 RVA: 0x00366E35 File Offset: 0x00365035
	private static void OnGuideTutorialEnabled(bool state)
	{
		GuideModel.Instance.ShowFailedOpenTutorialView();
	}

	// Token: 0x0600E708 RID: 59144 RVA: 0x00366E41 File Offset: 0x00365041
	private static void OnWorldDone()
	{
		GuideModel.Instance.EnsureCurrentDungeonId();
	}

	// Token: 0x0600E709 RID: 59145 RVA: 0x00366E50 File Offset: 0x00365050
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

	// Token: 0x0600E70A RID: 59146 RVA: 0x00366ECE File Offset: 0x003650CE
	public void GmCleanGuideData()
	{
		GuideModel.Instance.GmResetAllGuideGroup();
		this.UnRegisterEventsForAllAutoOpenConditions();
		this.RegisterEventsForAllAutoOpenConditions();
	}

	// Token: 0x0600E70B RID: 59147 RVA: 0x00366EE6 File Offset: 0x003650E6
	public void OnGmCleanGuideGroupDataByGroupId(int groupId)
	{
		this.ResetFinishedGuide(groupId);
	}

	// Token: 0x0600E70C RID: 59148 RVA: 0x00366EF0 File Offset: 0x003650F0
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

	// Token: 0x0600E70D RID: 59149 RVA: 0x00366F20 File Offset: 0x00365120
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		GuideModel.Instance.ClearAllGroup();
	}

	// Token: 0x0600E70E RID: 59150 RVA: 0x00366F2C File Offset: 0x0036512C
	private void OnCameraSequenceSetUiVisible(bool isVisible, string cameraName)
	{
		if (cameraName != "MainCamera")
		{
			return;
		}
		GuideModel.Instance.ShouldBlockGuideBecauseUiNotRender = !isVisible;
	}

	// Token: 0x0600E70F RID: 59151 RVA: 0x00366F4C File Offset: 0x0036514C
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

	// Token: 0x0600E710 RID: 59152 RVA: 0x00366F74 File Offset: 0x00365174
	public bool TryFinishGuide(int guideId)
	{
		if (GuideModel.Instance.IsGroupFinished(guideId).Value)
		{
			return false;
		}
		this.FinishGuide(guideId, false);
		return true;
	}

	// Token: 0x0600E711 RID: 59153 RVA: 0x00366FA4 File Offset: 0x003651A4
	public void TryFinishRunningGuides()
	{
		foreach (int guideId in GuideModel.Instance.GetRunningGroupIdList())
		{
			this.TryFinishGuide(guideId);
		}
	}

	// Token: 0x0600E712 RID: 59154 RVA: 0x00366FD8 File Offset: 0x003651D8
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

	// Token: 0x0600E713 RID: 59155 RVA: 0x00367026 File Offset: 0x00365226
	private void OnGuideFinished(int groupId)
	{
		GuideModel.Instance.FinishGroup(groupId);
		this.UnRegisterEventsForAutoOpenCondition(groupId);
		EventSystem.Instance.Emit<int>(EEventName.GuideGroupFinished, groupId);
	}

	// Token: 0x0600E714 RID: 59156 RVA: 0x0036704C File Offset: 0x0036524C
	public void ResetFinishedGuide(int groupId)
	{
		if (!GuideModel.Instance.IsGroupFinished(groupId).Value)
		{
			return;
		}
		GuideModel.Instance.ResetFinishedGuide(groupId);
		this.RegisterEventsForAutoOpenCondition(groupId);
	}

	// Token: 0x0600E715 RID: 59157 RVA: 0x00367084 File Offset: 0x00365284
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

	// Token: 0x0600E716 RID: 59158 RVA: 0x00367140 File Offset: 0x00365340
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

	// Token: 0x0600E717 RID: 59159 RVA: 0x003671A5 File Offset: 0x003653A5
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

	// Token: 0x0600E718 RID: 59160 RVA: 0x003671C0 File Offset: 0x003653C0
	public bool CheckHasNewTagInHookNameForShow(GuideFocusNew config)
	{
		return config.HookNameForShow.Contains("New:") || (config.ExtraParam().Length != 0 && config.ExtraParam()[0].Contains("New:"));
	}

	// Token: 0x0600E719 RID: 59161 RVA: 0x003671F8 File Offset: 0x003653F8
	public UniTask WaitForCurrentTutorialFinish()
	{
		GuideController.<WaitForCurrentTutorialFinish>d__38 <WaitForCurrentTutorialFinish>d__;
		<WaitForCurrentTutorialFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForCurrentTutorialFinish>d__.<>1__state = -1;
		<WaitForCurrentTutorialFinish>d__.<>t__builder.Start<GuideController.<WaitForCurrentTutorialFinish>d__38>(ref <WaitForCurrentTutorialFinish>d__);
		return <WaitForCurrentTutorialFinish>d__.<>t__builder.Task;
	}

	// Token: 0x17001270 RID: 4720
	// (get) Token: 0x0600E71A RID: 59162 RVA: 0x00367233 File Offset: 0x00365433
	// (set) Token: 0x0600E71B RID: 59163 RVA: 0x0036723B File Offset: 0x0036543B
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

	// Token: 0x17001271 RID: 4721
	// (get) Token: 0x0600E71C RID: 59164 RVA: 0x00367244 File Offset: 0x00365444
	public static GuideController Instance
	{
		get
		{
			return GuideController._Instance;
		}
	}

	// Token: 0x0600E71D RID: 59165 RVA: 0x0036724B File Offset: 0x0036544B
	public static GuideController GetOrCreateInstance()
	{
		if (GuideController._Instance == null)
		{
			GuideController.CreateInstance();
		}
		return GuideController._Instance;
	}

	// Token: 0x0600E71E RID: 59166 RVA: 0x0036725F File Offset: 0x0036545F
	public static bool CreateInstance()
	{
		if (GuideController._Instance != null)
		{
			return true;
		}
		GuideController._Instance = new GuideController();
		return true;
	}

	// Token: 0x0600E71F RID: 59167 RVA: 0x00367275 File Offset: 0x00365475
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E720 RID: 59168 RVA: 0x00367277 File Offset: 0x00365477
	public static void ResetStaticDefaultValue()
	{
		GuideController._Instance = null;
	}

	// Token: 0x0600E721 RID: 59169 RVA: 0x0036727F File Offset: 0x0036547F
	static GuideController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideController.CreateStaticDefaultValue), new Action(GuideController.ResetStaticDefaultValue));
	}

	// Token: 0x04006AE7 RID: 27367
	private readonly Dictionary<int, ConditionPassCallback> AutoOpenConditionCallBackMap = new Dictionary<int, ConditionPassCallback>();

	// Token: 0x04006AE8 RID: 27368
	private readonly int[] OnWorldDoneGuideKillList = new int[]
	{
		20013
	};

	// Token: 0x04006AE9 RID: 27369
	private bool GmEnableFocusTextPosTickInternal = true;

	// Token: 0x04006AEA RID: 27370
	[Nullable(2)]
	private static GuideController _Instance;

	// Token: 0x0200838C RID: 33676
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402ADC2 RID: 175554
		[Nullable(0)]
		public static Action <0>__OnWorldDone;

		// Token: 0x0402ADC3 RID: 175555
		[Nullable(0)]
		public static Action <1>__OnActiveBattleView;

		// Token: 0x0402ADC4 RID: 175556
		[Nullable(0)]
		public static Action <2>__OnBlackFadeScreenFinish;

		// Token: 0x0402ADC5 RID: 175557
		[Nullable(0)]
		public static Action<bool> <3>__OnGuideTutorialEnabled;

		// Token: 0x0402ADC6 RID: 175558
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <4>__LogGuideTriggerEvent;

		// Token: 0x0402ADC7 RID: 175559
		[Nullable(0)]
		public static Action <5>__OnNotifyGuideBreakFocus;

		// Token: 0x0402ADC8 RID: 175560
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EUiViewName, object, bool> <6>__CanOpenTutorial;
	}
}
