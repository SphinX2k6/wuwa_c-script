using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x0200144E RID: 5198
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRegressController : ActivityControllerBase
{
	// Token: 0x060092E6 RID: 37606 RVA: 0x001F87D2 File Offset: 0x001F69D2
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060092E7 RID: 37607 RVA: 0x001F87D5 File Offset: 0x001F69D5
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060092E8 RID: 37608 RVA: 0x001F87D8 File Offset: 0x001F69D8
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060092E9 RID: 37609 RVA: 0x001F8858 File Offset: 0x001F6A58
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Remove<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060092EA RID: 37610 RVA: 0x001F88D5 File Offset: 0x001F6AD5
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RegressActivityTrialRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RegressActivityTrialRoleUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RegressTrialRoleUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.RegressTrialRoleUnlockNotify));
	}

	// Token: 0x060092EB RID: 37611 RVA: 0x001F890F File Offset: 0x001F6B0F
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RegressActivityTrialRoleUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RegressTrialRoleUnlockNotify);
	}

	// Token: 0x060092EC RID: 37612 RVA: 0x001F8931 File Offset: 0x001F6B31
	protected override bool OnClear()
	{
		this.ActivityStartConditionMap.Clear();
		return true;
	}

	// Token: 0x060092ED RID: 37613 RVA: 0x001F893F File Offset: 0x001F6B3F
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_CircumfluenceMain30";
	}

	// Token: 0x060092EE RID: 37614 RVA: 0x001F8946 File Offset: 0x001F6B46
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		ActivityRegressModel.Instance.ActivityId = data.Id;
		return new ActivityRegressData();
	}

	// Token: 0x060092EF RID: 37615 RVA: 0x001F895D File Offset: 0x001F6B5D
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityRegress30MainView();
	}

	// Token: 0x060092F0 RID: 37616 RVA: 0x001F8964 File Offset: 0x001F6B64
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		foreach (EUiViewName viewName in new EUiViewName[]
		{
			EUiViewName.ActivityNewPlayerSupportTrialRoleView
		})
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060092F1 RID: 37617 RVA: 0x001F89AA File Offset: 0x001F6BAA
	public void RequestClaimSignReward(int rewardId)
	{
		this.RegressTaskRewardRequest(rewardId, RegressTaskTypeEnum.SignReward);
	}

	// Token: 0x060092F2 RID: 37618 RVA: 0x001F89B4 File Offset: 0x001F6BB4
	public void RequestClaimQuestionnaireReward(ERegressQuestionnaireType type)
	{
		RegressInvestigation? regressQuestionnaireConfig = ActivityRegressConfig.Instance.GetRegressQuestionnaireConfig(type);
		if (regressQuestionnaireConfig == null)
		{
			return;
		}
		this.RegressTaskRewardRequest(regressQuestionnaireConfig.Value.Id, RegressTaskTypeEnum.Questionnaire);
	}

	// Token: 0x060092F3 RID: 37619 RVA: 0x001F89F0 File Offset: 0x001F6BF0
	public void RequestClaimScoreReward(List<int> rewardIds)
	{
		ActivityRegressController.<>c__DisplayClass15_0 CS$<>8__locals1 = new ActivityRegressController.<>c__DisplayClass15_0();
		CS$<>8__locals1.rewardIds = rewardIds;
		int activityId = ActivityRegressModel.Instance.ActivityId;
		RegressBonusRequest regressBonusRequest = RegressBonusRequest.Create();
		regressBonusRequest.Ids.AddRange(CS$<>8__locals1.rewardIds);
		regressBonusRequest.ActivityId = activityId;
		Net.Instance.Call(ERequestMessageId.RegressBonusRequest, regressBonusRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestClaimScoreReward>g__Response|0), 0);
	}

	// Token: 0x060092F4 RID: 37620 RVA: 0x001F8A50 File Offset: 0x001F6C50
	public void RequestClaimTaskReward(int taskId)
	{
		this.RegressTaskRewardRequest(taskId, RegressTaskTypeEnum.TaskReward);
	}

	// Token: 0x060092F5 RID: 37621 RVA: 0x001F8A5C File Offset: 0x001F6C5C
	private void RegressTaskRewardRequest(int taskId, RegressTaskTypeEnum rewardType)
	{
		int activityId = ActivityRegressModel.Instance.ActivityId;
		RegressTaskRequest regressTaskRequest = RegressTaskRequest.Create();
		regressTaskRequest.ActivityId = activityId;
		regressTaskRequest.RewardType = rewardType;
		regressTaskRequest.TaskId = taskId;
		Net.Instance.Call(ERequestMessageId.RegressTaskRequest, regressTaskRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ActivityRegressController.<RegressTaskRewardRequest>g__Response|17_0((RegressTaskResponse)msg, status);
		}, 0);
	}

	// Token: 0x060092F6 RID: 37622 RVA: 0x001F8AC0 File Offset: 0x001F6CC0
	public void RequestClaimAllTaskReward()
	{
		List<RegressQuest> list = ActivityRegressModel.Instance.ActivityData.GetRegressTaskListByType(ERegressTaskType.Constant) ?? new List<RegressQuest>();
		List<RegressQuest> regressTaskListByType = ActivityRegressModel.Instance.ActivityData.GetRegressTaskListByType(ERegressTaskType.Daily);
		if (regressTaskListByType != null)
		{
			list.AddRange(regressTaskListByType);
		}
		List<RegressQuest> regressTaskListByType2 = ActivityRegressModel.Instance.ActivityData.GetRegressTaskListByType(ERegressTaskType.Once);
		if (regressTaskListByType2 != null)
		{
			list.AddRange(regressTaskListByType2);
		}
		List<int> list2 = new List<int>();
		for (int i = 0; i < list.Count; i++)
		{
			int id = list[i].Id;
			if (ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(id) == ERegressRewardState.Reached)
			{
				list2.Add(id);
			}
		}
		if (list2.Count == 0)
		{
			return;
		}
		int activityId = ActivityRegressModel.Instance.ActivityId;
		RegressRepeatedTaskRequest regressRepeatedTaskRequest = RegressRepeatedTaskRequest.Create();
		regressRepeatedTaskRequest.ActivityId = activityId;
		regressRepeatedTaskRequest.TaskId.AddRange(list2);
		Net.Instance.Call(ERequestMessageId.RegressRepeatedTaskRequest, regressRepeatedTaskRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ActivityRegressController.<RequestClaimAllTaskReward>g__Response|18_0((RegressRepeatedTaskResponse)msg, status);
		}, 0);
	}

	// Token: 0x060092F7 RID: 37623 RVA: 0x001F8BCC File Offset: 0x001F6DCC
	public UniTask RequestGachaInfo()
	{
		ActivityRegressController.<RequestGachaInfo>d__19 <RequestGachaInfo>d__;
		<RequestGachaInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestGachaInfo>d__.<>1__state = -1;
		<RequestGachaInfo>d__.<>t__builder.Start<ActivityRegressController.<RequestGachaInfo>d__19>(ref <RequestGachaInfo>d__);
		return <RequestGachaInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060092F8 RID: 37624 RVA: 0x001F8C08 File Offset: 0x001F6E08
	public void RegressSetCurUseTrialRoleRequest(int roleId, Action<int> callback)
	{
		RegressSetCurUseTrialRoleRequest regressSetCurUseTrialRoleRequest = Aki.Protocol.RegressSetCurUseTrialRoleRequest.Create();
		regressSetCurUseTrialRoleRequest.TrialRoleId = roleId;
		Net.Instance.Call(ERequestMessageId.RegressSetCurUseTrialRoleRequest, regressSetCurUseTrialRoleRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			base.<RegressSetCurUseTrialRoleRequest>g__Response|0((RegressSetCurUseTrialRoleResponse)msg, status);
		}, 0);
	}

	// Token: 0x060092F9 RID: 37625 RVA: 0x001F8C4C File Offset: 0x001F6E4C
	[NullableContext(2)]
	private void RegressActivityTrialRoleUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		RegressActivityTrialRoleUpdateNotify regressActivityTrialRoleUpdateNotify = (RegressActivityTrialRoleUpdateNotify)msg;
		RepeatedField<int> trialRoleId = regressActivityTrialRoleUpdateNotify.TrialRoleId;
		roleInfo curUseRoleInfo = regressActivityTrialRoleUpdateNotify.CurUseRoleInfo;
		foreach (int num in trialRoleId)
		{
			if (curUseRoleInfo != null && curUseRoleInfo.RoleId == num)
			{
				this.UpdateActivatedTrialRoleInternal(num, curUseRoleInfo);
			}
			else
			{
				this.UpdateActivatedTrialRoleInternal(num, null);
			}
		}
	}

	// Token: 0x060092FA RID: 37626 RVA: 0x001F8CC0 File Offset: 0x001F6EC0
	[NullableContext(2)]
	private void RegressTrialRoleUnlockNotify(IMessage msg, Net.CallbackStatus _)
	{
		foreach (int roleId in ((RegressTrialRoleUnlockNotify)msg).RoleId)
		{
			this.UpdateActivatedTrialRoleInternal(roleId, null);
		}
	}

	// Token: 0x060092FB RID: 37627 RVA: 0x001F8D14 File Offset: 0x001F6F14
	[NullableContext(2)]
	private void UpdateActivatedTrialRoleInternal(int roleId, roleInfo trialRoleInfo = null)
	{
		TrialRoleConfig instance = TrialRoleConfig.Instance;
		int? num = (instance != null) ? instance.GetTrialRoleGroupId(roleId) : null;
		if (TrialRoleModel.Instance.GetDataByGroupId(num.Value).IsLocked())
		{
			ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
			if (activityData != null)
			{
				activityData.SetTrialRoleRedDotChecked(false);
			}
		}
		TrialRoleModel.Instance.SetGroupTrialRoleId(roleId, trialRoleInfo);
	}

	// Token: 0x060092FC RID: 37628 RVA: 0x001F8D78 File Offset: 0x001F6F78
	public void RegressTrialRoleLvUpRequest(int trialRoleId)
	{
		RegressTrialRoleLvUpRequest regressTrialRoleLvUpRequest = Aki.Protocol.RegressTrialRoleLvUpRequest.Create();
		regressTrialRoleLvUpRequest.TrialRoleId = trialRoleId;
		Net.Instance.Call(ERequestMessageId.RegressTrialRoleLvUpRequest, regressTrialRoleLvUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RegressTrialRoleLvUpResponse regressTrialRoleLvUpResponse = (RegressTrialRoleLvUpResponse)msg;
			if (regressTrialRoleLvUpResponse == null || regressTrialRoleLvUpResponse.Code != Aki.Protocol.ErrorCode.Success)
			{
				if (regressTrialRoleLvUpResponse != null)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(regressTrialRoleLvUpResponse.Code, EResponseMessageId.RegressTrialRoleLvUpResponse, null, true, true);
				}
				return;
			}
			this.UpdateActivatedTrialRoleInternal(regressTrialRoleLvUpResponse.RoleId, regressTrialRoleLvUpResponse.CurUseRoleInfo);
		}, 0);
	}

	// Token: 0x060092FD RID: 37629 RVA: 0x001F8DAF File Offset: 0x001F6FAF
	private void OnWorldDone()
	{
		this.ActivityStartConditionMap[ERecallStartCondition.WorldDone] = true;
		this.CheckIsStart(false);
	}

	// Token: 0x060092FE RID: 37630 RVA: 0x001F8DC8 File Offset: 0x001F6FC8
	private void OnActivityUpdate()
	{
		bool isActivityRecallReady = ActivityRegressModel.Instance.IsActivityRecallReady;
		this.ActivityStartConditionMap[ERecallStartCondition.RecallReady] = isActivityRecallReady;
		bool value = ActivityRegressModel.Instance.IsActivityRecallSplashFirstShow();
		this.ActivityStartConditionMap[ERecallStartCondition.FirstShow] = value;
		bool activityRecallForbidStart = ActivityRegressModel.Instance.ActivityRecallForbidStart;
		this.ActivityStartConditionMap[ERecallStartCondition.UnForbidStart] = !activityRecallForbidStart;
		bool isActivityOpen = ActivityRegressModel.Instance.IsActivityOpen;
		this.ActivityStartConditionMap[ERecallStartCondition.IsOpen] = isActivityOpen;
		this.CheckIsStart(true);
	}

	// Token: 0x060092FF RID: 37631 RVA: 0x001F8E40 File Offset: 0x001F7040
	private void CheckIsStart(bool isInstantly = false)
	{
		bool flag = true;
		foreach (object obj in Enum.GetValues(typeof(ERecallStartCondition)))
		{
			ERecallStartCondition key = (ERecallStartCondition)obj;
			bool flag2;
			if (!this.ActivityStartConditionMap.TryGetValue(key, out flag2) || !flag2)
			{
				flag = false;
				key.ToString();
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		if (ActivityRegressModel.Instance.AlreadyStartView)
		{
			return;
		}
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.Recall, ESplashScreenType.Config, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityRegressStartupView, null, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
	}

	// Token: 0x06009300 RID: 37632 RVA: 0x001F8F0C File Offset: 0x001F710C
	private void OnInventoryUpdate(int configId, int count)
	{
		if (ActivityRegressModel.Instance.ActivityData != null && 20 == configId)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActivityRegressModel.Instance.ActivityId);
			ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
			int prevBpExp = activityData.PrevBpExp;
			IRegressLevelProgressData? levelProgressDataByScore = activityData.GetLevelProgressDataByScore(prevBpExp);
			IRegressLevelProgressData? levelProgressDataByScore2 = activityData.GetLevelProgressDataByScore(count);
			if (levelProgressDataByScore == null || levelProgressDataByScore2 == null)
			{
				return;
			}
			int level = levelProgressDataByScore.Value.Level;
			int level2 = levelProgressDataByScore2.Value.Level;
			float p = (levelProgressDataByScore.Value.NeedScore > 0) ? ((float)levelProgressDataByScore.Value.CurScore / (float)levelProgressDataByScore.Value.NeedScore) : 0f;
			float p2 = (levelProgressDataByScore2.Value.NeedScore > 0) ? ((float)levelProgressDataByScore2.Value.CurScore / (float)levelProgressDataByScore2.Value.NeedScore) : 0f;
			EventSystem.Instance.Emit<int, int, float, float>(EEventName.RegressBpExpAnim, level, level2, p, p2);
			activityData.RefreshPrevBpExp();
		}
	}

	// Token: 0x06009301 RID: 37633 RVA: 0x001F9044 File Offset: 0x001F7244
	public void OpenQuestionnaire(ERegressQuestionnaireType type)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ActivityRegress;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "回流活动->打开调查问卷";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		bool flag = !KuroSdkController.Instance.CanUseSdk();
		string questionnaireUrl = this.GetQuestionnaireUrl(type);
		bool isLandscape = true;
		string title = "";
		if (flag)
		{
			MailModel.Instance.OpenWebBrowser(questionnaireUrl);
			return;
		}
		KuroSdkController.Instance.SdkOpenUrlWnd(title, questionnaireUrl, isLandscape, false, true);
	}

	// Token: 0x06009302 RID: 37634 RVA: 0x001F90BC File Offset: 0x001F72BC
	public void RequestQuestionOpen(ERegressQuestionnaireType type)
	{
		RegressInvestigation? regressQuestionnaireConfig = ActivityRegressConfig.Instance.GetRegressQuestionnaireConfig(type);
		if (regressQuestionnaireConfig == null)
		{
			return;
		}
		RegressInvestigation questionConfig = regressQuestionnaireConfig.Value;
		RegressQuestionOpenRequest regressQuestionOpenRequest = RegressQuestionOpenRequest.Create();
		regressQuestionOpenRequest.QuestionId = questionConfig.Id;
		Net.Instance.Call(ERequestMessageId.RegressQuestionOpenRequest, regressQuestionOpenRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			base.<RequestQuestionOpen>g__Response|0((RegressQuestionOpenResponse)msg, status);
		}, 0);
	}

	// Token: 0x06009303 RID: 37635 RVA: 0x001F9128 File Offset: 0x001F7328
	public UniTask NewTrialRoleGetNightmarePhantomInstInfoRequest()
	{
		ActivityRegressController.<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__31 <NewTrialRoleGetNightmarePhantomInstInfoRequest>d__;
		<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__.<>1__state = -1;
		<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__.<>t__builder.Start<ActivityRegressController.<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__31>(ref <NewTrialRoleGetNightmarePhantomInstInfoRequest>d__);
		return <NewTrialRoleGetNightmarePhantomInstInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06009304 RID: 37636 RVA: 0x001F9164 File Offset: 0x001F7364
	public string GetQuestionnaireUrl(ERegressQuestionnaireType type)
	{
		RegressInvestigation value = ActivityRegressConfig.Instance.GetRegressQuestionnaireConfig(type).Value;
		string value2 = LoginModel.Instance.GetServerId() ?? "";
		int? id = PlayerInfoModel.Instance.GetId();
		string stringConfig = ConfigCommonParamById.GetStringConfig("mail_question_key");
		int questionnaireId = value.QuestionnaireId;
		string hyperLink = value.HyperLink;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 4);
		defaultInterpolatedStringHandler.AppendFormatted<int>(questionnaireId);
		defaultInterpolatedStringHandler.AppendFormatted<int?>(id);
		defaultInterpolatedStringHandler.AppendLiteral(";");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendFormatted(stringConfig);
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		text = UKuroStaticLibrary.HashStringWithSHA1(text);
		int questionnaireId2 = LanguageConfig.Instance.GetLanguageDefineByLanguageCode(LanguageSystem.Instance.PackageLanguage).Value.QuestionnaireId;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 5);
		defaultInterpolatedStringHandler.AppendFormatted(hyperLink);
		defaultInterpolatedStringHandler.AppendLiteral("?sojumpparm=");
		defaultInterpolatedStringHandler.AppendFormatted<int?>(id);
		defaultInterpolatedStringHandler.AppendLiteral(";");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral("&parmsign=");
		defaultInterpolatedStringHandler.AppendFormatted(text);
		defaultInterpolatedStringHandler.AppendLiteral("&langv=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(questionnaireId2);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06009305 RID: 37637 RVA: 0x001F92A0 File Offset: 0x001F74A0
	public void RequestAllTaskScoreRewards()
	{
		IReadOnlyList<RegressBonusReward> sortedRegressBonusRewardConfigList = ActivityRegressModel.Instance.ActivityData.GetSortedRegressBonusRewardConfigList();
		List<int> list = new List<int>();
		ActivityRegressModel.Instance.NeedShowExtraRewardView = false;
		for (int i = 0; i < sortedRegressBonusRewardConfigList.Count; i++)
		{
			RegressBonusReward config = sortedRegressBonusRewardConfigList[i];
			int id = config.Id;
			ERegressRewardState regressTaskScoreRewardState = ActivityRegressModel.Instance.ActivityData.GetRegressTaskScoreRewardState(config);
			ERegressRewardState regressTaskPayScoreRewardState = ActivityRegressModel.Instance.ActivityData.GetRegressTaskPayScoreRewardState(config);
			if ((i + 1) % 5 == 0 && regressTaskScoreRewardState == ERegressRewardState.Reached)
			{
				ActivityRegressModel.Instance.NeedShowExtraRewardView = true;
			}
			if (regressTaskScoreRewardState == ERegressRewardState.Reached || regressTaskPayScoreRewardState == ERegressRewardState.Reached)
			{
				list.Add(id);
			}
		}
		if (list.Count > 0)
		{
			this.RequestClaimScoreReward(list);
		}
	}

	// Token: 0x06009306 RID: 37638 RVA: 0x001F9350 File Offset: 0x001F7550
	public unsafe bool JumpByQuestConfig(RegressQuest config)
	{
		ERegressTaskType taskType = (ERegressTaskType)config.TaskType;
		if (taskType == ERegressTaskType.Constant || taskType == ERegressTaskType.Once)
		{
			ERegressConstantTaskSubType taskSubType = (ERegressConstantTaskSubType)config.TaskSubType;
			if (taskSubType == ERegressConstantTaskSubType.MainQuestAndRole)
			{
				int? firstUnFinishMainQuestId = ActivityRegressModel.Instance.GetFirstUnFinishMainQuestId();
				global::RoleQuest firstShowRoleQuest = ActivityRegressModel.Instance.GetFirstShowRoleQuest();
				if (firstUnFinishMainQuestId != null)
				{
					return this.JumpToMainlineQuest(config);
				}
				if (firstShowRoleQuest != null)
				{
					return this.JumpToRoleQuest(config);
				}
				return this.JumpToMainlineQuest(config);
			}
			else
			{
				if (taskSubType == ERegressConstantTaskSubType.Explore)
				{
					return this.ExploreJump();
				}
				SkipTaskManager.RunByConfigId(config.AccessPathId, null);
				return true;
			}
		}
		else
		{
			if (taskType == ERegressTaskType.Daily)
			{
				AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.DailyActivityTabView), null, null);
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "回流活动->JumpToQuestView 没有定义该类型的回流活动任务跳转！";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("taskType: ", taskType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("taskSubType: ", config.TaskSubType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("config: ", config);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
	}

	// Token: 0x06009307 RID: 37639 RVA: 0x001F9478 File Offset: 0x001F7678
	private bool JumpToMainlineQuest(RegressQuest config)
	{
		int? firstUnFinishMainQuestId = ActivityRegressModel.Instance.GetFirstUnFinishMainQuestId();
		if (firstUnFinishMainQuestId == null)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Tips_01", Array.Empty<object>());
			return false;
		}
		UiManager.Instance.OpenView(EUiViewName.QuestView, firstUnFinishMainQuestId.Value, null);
		return true;
	}

	// Token: 0x06009308 RID: 37640 RVA: 0x001F94CC File Offset: 0x001F76CC
	private bool JumpToRoleQuest(RegressQuest config)
	{
		global::RoleQuest firstShowRoleQuest = ActivityRegressModel.Instance.GetFirstShowRoleQuest();
		if (firstShowRoleQuest == null)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Role_Precondition", Array.Empty<object>());
			return false;
		}
		UiManager.Instance.OpenView(EUiViewName.QuestView, firstShowRoleQuest.Id, null);
		return true;
	}

	// Token: 0x06009309 RID: 37641 RVA: 0x001F951C File Offset: 0x001F771C
	public bool ExploreJump()
	{
		ExploreAreaData firstUnlockArea = this.GetFirstUnlockArea();
		if (firstUnlockArea == null)
		{
			return false;
		}
		Aki.Config.Area? areaInfo = AreaConfig.Instance.GetAreaInfo(firstUnlockArea.AreaId);
		if (areaInfo == null)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Tips_01", Array.Empty<object>());
			return false;
		}
		Aki.Config.Area value = areaInfo.Value;
		WorldMapViewOpenParams data = new WorldMapViewOpenParams
		{
			MarkId = new int?(value.DeliveryMarkId),
			MarkType = (EMarkType)value.DeliveryMarkType,
			StartScale = new float?(WorldMapModel.Instance.MapScaleMin),
			OpenFogId = new int?(0)
		};
		WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		return true;
	}

	// Token: 0x0600930A RID: 37642 RVA: 0x001F95C4 File Offset: 0x001F77C4
	[NullableContext(2)]
	public unsafe ExploreAreaData GetFirstUnlockArea()
	{
		Dictionary<int, bool> allUnlockedAreas = MapModel.Instance.GetAllUnlockedAreas();
		if (allUnlockedAreas == null || allUnlockedAreas.Count <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Tips_01", Array.Empty<object>());
			return null;
		}
		List<ExploreAreaData> list = new List<ExploreAreaData>();
		foreach (KeyValuePair<int, bool> keyValuePair in allUnlockedAreas)
		{
			int key = keyValuePair.Key;
			ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(key);
			if (exploreAreaData != null)
			{
				list.Add(exploreAreaData);
			}
		}
		list.Sort((ExploreAreaData a, ExploreAreaData b) => a.GetProgress() - b.GetProgress());
		if (list.Count <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Tips_01", Array.Empty<object>());
			Log.Instance.Warn(ELogModule.ActivityRegress, ELogAuthor.LRX, "[回流活动]ActivityRegress->RecallDailyExploreTaskJump 探索任务跳转失败，当前没有探索度数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		foreach (ExploreAreaData exploreAreaData2 in list)
		{
			int areaId = exploreAreaData2.AreaId;
			Aki.Config.Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
			if (areaInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityRegress;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[回流活动]ActivityRegress->RecallDailyExploreTaskJump 探索任务跳转缺少area配置, 请检查q.区域表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("areaId: ", areaId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				Aki.Config.Area value = areaInfo.Value;
				if (value.DeliveryMarkId != 0)
				{
					return exploreAreaData2;
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Tips_01", Array.Empty<object>());
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ActivityRegress;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "[回流活动]ActivityRegress-> 探索任务跳转缺少DeliveryMarkId配置, 请检查q.区域表,并联系技术策划对齐";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("areaId: ", areaId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DeliveryMarkId: ", value.DeliveryMarkId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		return null;
	}

	// Token: 0x0600930B RID: 37643 RVA: 0x001F980C File Offset: 0x001F7A0C
	public void RegressDisposableRewardRequest()
	{
		RegressDisposableRewardRequest message = Aki.Protocol.RegressDisposableRewardRequest.Create();
		Net.Instance.Call(ERequestMessageId.RegressDisposableRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ActivityRegressController.<RegressDisposableRewardRequest>g__Response|39_0((RegressDisposableRewardResponse)msg, status);
		}, 0);
	}

	// Token: 0x0600930C RID: 37644 RVA: 0x001F984F File Offset: 0x001F7A4F
	public bool IsNeedExtraRewardView()
	{
		return ActivityRegressModel.Instance.NeedShowExtraRewardView;
	}

	// Token: 0x0600930D RID: 37645 RVA: 0x001F985C File Offset: 0x001F7A5C
	public RewardData<IBattlePassExtraRewardInfo> BuildExtraRewardData(List<RewardItemData> rewardItemDataList)
	{
		List<RewardItemData> list = new List<RewardItemData>();
		ERegressGrade grade = ActivityRegressModel.Instance.Grade;
		IReadOnlyList<RegressBonusReward> readOnlyList = ActivityRegressConfig.Instance.GetRegressBonusRewardConfigList(grade) ?? Array.Empty<RegressBonusReward>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		int regressTaskScore = ActivityRegressModel.Instance.ActivityData.GetRegressTaskScore();
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			RegressBonusReward config = readOnlyList[i];
			if (regressTaskScore >= config.NeedScore && ActivityRegressModel.Instance.ActivityData.GetRegressTaskPayScoreRewardState(config) != ERegressRewardState.Claim)
			{
				int payDrop = config.PayDrop;
				if (payDrop > 0)
				{
					DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(payDrop);
					if (dropPackage != null)
					{
						foreach (KeyValuePair<int, int> keyValuePair in dropPackage.Value.DropPreview())
						{
							int key = keyValuePair.Key;
							int value = keyValuePair.Value;
							if (dictionary.ContainsKey(key))
							{
								dictionary[key] += value;
							}
							else
							{
								dictionary[key] = value;
							}
						}
					}
				}
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
		{
			int key2 = keyValuePair2.Key;
			int value2 = keyValuePair2.Value;
			list.Add(new RewardItemData(key2, value2, null, EDropItemType.Normal));
		}
		list.Sort(delegate(RewardItemData a, RewardItemData b)
		{
			int qualityId = a.GetQualityId();
			int qualityId2 = b.GetQualityId();
			if (qualityId == qualityId2)
			{
				return a.Count - b.Count;
			}
			return qualityId2 - qualityId;
		});
		BattlePassExtraRewardInfo battlePassExtraRewardInfo = new BattlePassExtraRewardInfo();
		battlePassExtraRewardInfo.Type = ERewardInfoType.BattlePassExtra;
		battlePassExtraRewardInfo.ViewName = EUiViewName.BattlePassExtraRewardView;
		battlePassExtraRewardInfo.CommonItems = rewardItemDataList;
		battlePassExtraRewardInfo.ExtraItems = list;
		battlePassExtraRewardInfo.TipsTextId = "Regress_BattlePass_Purchase_Tips";
		battlePassExtraRewardInfo.LeftAction = delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.RegressBpPayView, null, null);
		};
		battlePassExtraRewardInfo.RightAction = delegate()
		{
		};
		return new RewardData<IBattlePassExtraRewardInfo>(battlePassExtraRewardInfo, null);
	}

	// Token: 0x0600930E RID: 37646 RVA: 0x001F9AA8 File Offset: 0x001F7CA8
	public void RequestBuyBattlePassLevel(int level)
	{
		RegressBuyBonusLvRequest regressBuyBonusLvRequest = RegressBuyBonusLvRequest.Create();
		regressBuyBonusLvRequest.BuyLv = level;
		Net.Instance.Call(ERequestMessageId.RegressBuyBonusLvRequest, regressBuyBonusLvRequest, delegate(IMessage _, Net.CallbackStatus __)
		{
			EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		}, 0);
	}

	// Token: 0x0600930F RID: 37647 RVA: 0x001F9AF2 File Offset: 0x001F7CF2
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		if (notify.PayItemId == 46)
		{
			ActivityRegressModel.Instance.ActivityData.SetPayRewardUnlock(true);
			EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
			UiManager.Instance.OpenView(EUiViewName.RegressBpLevelUpTipsView, null, null);
		}
	}

	// Token: 0x06009310 RID: 37648 RVA: 0x001F9B30 File Offset: 0x001F7D30
	public static void OpenGameIntroductionByRoleId(int roleId)
	{
		string text = ChannelModel.Instance.GameIntroductionUrl;
		if (text == "")
		{
			if (KuroSdkController.Instance.GetIfGlobalSdk())
			{
				text = CommonConfig.Instance.GetGameIntroductionGlobalUrl();
			}
			else
			{
				text = CommonConfig.Instance.GetGameIntroductionUrl();
			}
		}
		string externalUrl = PublicUtil.Instance.GetExternalUrl(text, PublicUtil.EExternalUrlReason.GameIntroduction);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
		defaultInterpolatedStringHandler.AppendLiteral("&role_id=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
		string url = externalUrl + defaultInterpolatedStringHandler.ToStringAndClear();
		GameInformationClickLogEvent logData = new GameInformationClickLogEvent();
		LogReportController.Instance.LogReport(logData);
		KuroSdkController.Instance.OpenWebView("", url, true, true, true, "Default");
	}

	// Token: 0x06009311 RID: 37649 RVA: 0x001F9BDC File Offset: 0x001F7DDC
	public void OpenTrialRoleView(int? selectedGroupId = null)
	{
		NewPlayerSupportTrialRoleViewModel newPlayerSupportTrialRoleViewModel = new NewPlayerSupportTrialRoleViewModel(ETrialRoleType.ReturnSupportTrial, ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleIcon"), ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleTitle"), 465, selectedGroupId);
		newPlayerSupportTrialRoleViewModel.SetRequestTrialRoleLvUpFunc(new Action<int>(this.RegressTrialRoleLvUpRequest));
		newPlayerSupportTrialRoleViewModel.SetRequestSetCurUseTrialRoleFunc(new Action<int, Action<int>>(this.RegressSetCurUseTrialRoleRequest));
		Dictionary<int, string> trialRoleUnlockDesc = ActivityRegressConfig.Instance.GetTrialRoleUnlockDesc();
		newPlayerSupportTrialRoleViewModel.SetTrialRoleGroupUnlockDesc(trialRoleUnlockDesc);
		UiManager.Instance.OpenView(EUiViewName.ActivityNewPlayerSupportTrialRoleView, newPlayerSupportTrialRoleViewModel, null);
	}

	// Token: 0x06009312 RID: 37650 RVA: 0x001F9C54 File Offset: 0x001F7E54
	public static void RegressStartJumpToActivity(Action callback)
	{
		bool flag = UiManager.Instance.IsViewOpen(EUiViewName.ActivityRegressNewVersionMainView);
		UiManager.Instance.CloseView(flag ? EUiViewName.ActivityRegressNewVersionMainView : EUiViewName.ActivityRegressMainView, delegate(bool _)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.AdventureGuideView))
			{
				UiManager.Instance.CloseView(EUiViewName.AdventureGuideView, null);
			}
			callback();
		});
	}

	// Token: 0x17000CD4 RID: 3284
	// (get) Token: 0x06009313 RID: 37651 RVA: 0x001F9CA3 File Offset: 0x001F7EA3
	public static ActivityRegressController Instance
	{
		get
		{
			return ActivityRegressController._Instance;
		}
	}

	// Token: 0x06009314 RID: 37652 RVA: 0x001F9CAA File Offset: 0x001F7EAA
	public static ActivityRegressController GetOrCreateInstance()
	{
		if (ActivityRegressController._Instance == null)
		{
			ActivityRegressController.CreateInstance();
		}
		return ActivityRegressController._Instance;
	}

	// Token: 0x06009315 RID: 37653 RVA: 0x001F9CBE File Offset: 0x001F7EBE
	public static bool CreateInstance()
	{
		if (ActivityRegressController._Instance != null)
		{
			return true;
		}
		ActivityRegressController._Instance = new ActivityRegressController();
		return true;
	}

	// Token: 0x06009316 RID: 37654 RVA: 0x001F9CD4 File Offset: 0x001F7ED4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009317 RID: 37655 RVA: 0x001F9CD6 File Offset: 0x001F7ED6
	public static void ResetStaticDefaultValue()
	{
		ActivityRegressController._Instance = null;
	}

	// Token: 0x06009318 RID: 37656 RVA: 0x001F9CDE File Offset: 0x001F7EDE
	static ActivityRegressController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRegressController.CreateStaticDefaultValue), new Action(ActivityRegressController.ResetStaticDefaultValue));
	}

	// Token: 0x0600931A RID: 37658 RVA: 0x001F9D10 File Offset: 0x001F7F10
	[NullableContext(2)]
	[CompilerGenerated]
	internal static void <RegressTaskRewardRequest>g__Response|17_0(RegressTaskResponse response, Net.CallbackStatus _)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, EResponseMessageId.RegressTaskResponse, null, true, true);
		}
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x0600931B RID: 37659 RVA: 0x001F9D46 File Offset: 0x001F7F46
	[NullableContext(2)]
	[CompilerGenerated]
	internal static void <RequestClaimAllTaskReward>g__Response|18_0(RegressRepeatedTaskResponse response, Net.CallbackStatus _)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, EResponseMessageId.RegressRepeatedTaskResponse, null, true, true);
		}
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x0600931D RID: 37661 RVA: 0x001F9DCC File Offset: 0x001F7FCC
	[NullableContext(2)]
	[CompilerGenerated]
	internal static void <RegressDisposableRewardRequest>g__Response|39_0(RegressDisposableRewardResponse response, Net.CallbackStatus _)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, EResponseMessageId.RegressDisposableRewardResponse, null, true, true);
			return;
		}
		ActivityRegressModel.Instance.ActivityData.DisposableReward = true;
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x04004107 RID: 16647
	private const int BP_REMINDER_INTERVAL = 5;

	// Token: 0x04004108 RID: 16648
	private readonly Dictionary<ERecallStartCondition, bool> ActivityStartConditionMap = new Dictionary<ERecallStartCondition, bool>();

	// Token: 0x04004109 RID: 16649
	[Nullable(2)]
	private static ActivityRegressController _Instance;
}
