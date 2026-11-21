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

// Token: 0x02000902 RID: 2306
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRegressController : ActivityControllerBase
{
	// Token: 0x0600667B RID: 26235 RVA: 0x0020130E File Offset: 0x001FF50E
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600667C RID: 26236 RVA: 0x00201311 File Offset: 0x001FF511
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600667D RID: 26237 RVA: 0x00201314 File Offset: 0x001FF514
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600667E RID: 26238 RVA: 0x00201394 File Offset: 0x001FF594
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Remove<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600667F RID: 26239 RVA: 0x00201411 File Offset: 0x001FF611
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RegressActivityTrialRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RegressActivityTrialRoleUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RegressTrialRoleUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.RegressTrialRoleUnlockNotify));
	}

	// Token: 0x06006680 RID: 26240 RVA: 0x0020144B File Offset: 0x001FF64B
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RegressActivityTrialRoleUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RegressTrialRoleUnlockNotify);
	}

	// Token: 0x06006681 RID: 26241 RVA: 0x0020146D File Offset: 0x001FF66D
	protected override bool OnClear()
	{
		this.ActivityStartConditionMap.Clear();
		return true;
	}

	// Token: 0x06006682 RID: 26242 RVA: 0x0020147B File Offset: 0x001FF67B
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_CircumfluenceMain30";
	}

	// Token: 0x06006683 RID: 26243 RVA: 0x00201482 File Offset: 0x001FF682
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		ActivityRegressModel.Instance.ActivityId = data.Id;
		return new ActivityRegressData();
	}

	// Token: 0x06006684 RID: 26244 RVA: 0x00201499 File Offset: 0x001FF699
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityRegress30MainView();
	}

	// Token: 0x06006685 RID: 26245 RVA: 0x002014A0 File Offset: 0x001FF6A0
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

	// Token: 0x06006686 RID: 26246 RVA: 0x002014E6 File Offset: 0x001FF6E6
	public void RequestClaimSignReward(int rewardId)
	{
		this.RegressTaskRewardRequest(rewardId, RegressTaskTypeEnum.SignReward);
	}

	// Token: 0x06006687 RID: 26247 RVA: 0x002014F0 File Offset: 0x001FF6F0
	public void RequestClaimQuestionnaireReward(ERegressQuestionnaireType type)
	{
		RegressInvestigation? regressQuestionnaireConfig = ActivityRegressConfig.Instance.GetRegressQuestionnaireConfig(type);
		if (regressQuestionnaireConfig == null)
		{
			return;
		}
		this.RegressTaskRewardRequest(regressQuestionnaireConfig.Value.Id, RegressTaskTypeEnum.Questionnaire);
	}

	// Token: 0x06006688 RID: 26248 RVA: 0x0020152C File Offset: 0x001FF72C
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

	// Token: 0x06006689 RID: 26249 RVA: 0x0020158C File Offset: 0x001FF78C
	public void RequestClaimTaskReward(int taskId)
	{
		this.RegressTaskRewardRequest(taskId, RegressTaskTypeEnum.TaskReward);
	}

	// Token: 0x0600668A RID: 26250 RVA: 0x00201598 File Offset: 0x001FF798
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

	// Token: 0x0600668B RID: 26251 RVA: 0x002015FC File Offset: 0x001FF7FC
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

	// Token: 0x0600668C RID: 26252 RVA: 0x00201708 File Offset: 0x001FF908
	public UniTask RequestGachaInfo()
	{
		ActivityRegressController.<RequestGachaInfo>d__19 <RequestGachaInfo>d__;
		<RequestGachaInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestGachaInfo>d__.<>1__state = -1;
		<RequestGachaInfo>d__.<>t__builder.Start<ActivityRegressController.<RequestGachaInfo>d__19>(ref <RequestGachaInfo>d__);
		return <RequestGachaInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600668D RID: 26253 RVA: 0x00201744 File Offset: 0x001FF944
	public void RegressSetCurUseTrialRoleRequest(int roleId, Action<int> callback)
	{
		RegressSetCurUseTrialRoleRequest regressSetCurUseTrialRoleRequest = Aki.Protocol.RegressSetCurUseTrialRoleRequest.Create();
		regressSetCurUseTrialRoleRequest.TrialRoleId = roleId;
		Net.Instance.Call(ERequestMessageId.RegressSetCurUseTrialRoleRequest, regressSetCurUseTrialRoleRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			base.<RegressSetCurUseTrialRoleRequest>g__Response|0((RegressSetCurUseTrialRoleResponse)msg, status);
		}, 0);
	}

	// Token: 0x0600668E RID: 26254 RVA: 0x00201788 File Offset: 0x001FF988
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

	// Token: 0x0600668F RID: 26255 RVA: 0x002017FC File Offset: 0x001FF9FC
	[NullableContext(2)]
	private void RegressTrialRoleUnlockNotify(IMessage msg, Net.CallbackStatus _)
	{
		foreach (int roleId in ((RegressTrialRoleUnlockNotify)msg).RoleId)
		{
			this.UpdateActivatedTrialRoleInternal(roleId, null);
		}
	}

	// Token: 0x06006690 RID: 26256 RVA: 0x00201850 File Offset: 0x001FFA50
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

	// Token: 0x06006691 RID: 26257 RVA: 0x002018B4 File Offset: 0x001FFAB4
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

	// Token: 0x06006692 RID: 26258 RVA: 0x002018EB File Offset: 0x001FFAEB
	private void OnWorldDone()
	{
		this.ActivityStartConditionMap[ERecallStartCondition.WorldDone] = true;
		this.CheckIsStart(false);
	}

	// Token: 0x06006693 RID: 26259 RVA: 0x00201904 File Offset: 0x001FFB04
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

	// Token: 0x06006694 RID: 26260 RVA: 0x0020197C File Offset: 0x001FFB7C
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

	// Token: 0x06006695 RID: 26261 RVA: 0x00201A48 File Offset: 0x001FFC48
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

	// Token: 0x06006696 RID: 26262 RVA: 0x00201B80 File Offset: 0x001FFD80
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

	// Token: 0x06006697 RID: 26263 RVA: 0x00201BF8 File Offset: 0x001FFDF8
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

	// Token: 0x06006698 RID: 26264 RVA: 0x00201C64 File Offset: 0x001FFE64
	public UniTask NewTrialRoleGetNightmarePhantomInstInfoRequest()
	{
		ActivityRegressController.<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__31 <NewTrialRoleGetNightmarePhantomInstInfoRequest>d__;
		<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__.<>1__state = -1;
		<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__.<>t__builder.Start<ActivityRegressController.<NewTrialRoleGetNightmarePhantomInstInfoRequest>d__31>(ref <NewTrialRoleGetNightmarePhantomInstInfoRequest>d__);
		return <NewTrialRoleGetNightmarePhantomInstInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06006699 RID: 26265 RVA: 0x00201CA0 File Offset: 0x001FFEA0
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

	// Token: 0x0600669A RID: 26266 RVA: 0x00201DDC File Offset: 0x001FFFDC
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

	// Token: 0x0600669B RID: 26267 RVA: 0x00201E8C File Offset: 0x0020008C
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
				AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.DailyActivityTabView), null, null, null);
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

	// Token: 0x0600669C RID: 26268 RVA: 0x00201FC0 File Offset: 0x002001C0
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

	// Token: 0x0600669D RID: 26269 RVA: 0x00202014 File Offset: 0x00200214
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

	// Token: 0x0600669E RID: 26270 RVA: 0x00202064 File Offset: 0x00200264
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

	// Token: 0x0600669F RID: 26271 RVA: 0x0020210C File Offset: 0x0020030C
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

	// Token: 0x060066A0 RID: 26272 RVA: 0x00202354 File Offset: 0x00200554
	public void RegressDisposableRewardRequest()
	{
		RegressDisposableRewardRequest message = Aki.Protocol.RegressDisposableRewardRequest.Create();
		Net.Instance.Call(ERequestMessageId.RegressDisposableRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ActivityRegressController.<RegressDisposableRewardRequest>g__Response|39_0((RegressDisposableRewardResponse)msg, status);
		}, 0);
	}

	// Token: 0x060066A1 RID: 26273 RVA: 0x00202397 File Offset: 0x00200597
	public bool IsNeedExtraRewardView()
	{
		return ActivityRegressModel.Instance.NeedShowExtraRewardView;
	}

	// Token: 0x060066A2 RID: 26274 RVA: 0x002023A4 File Offset: 0x002005A4
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

	// Token: 0x060066A3 RID: 26275 RVA: 0x002025F0 File Offset: 0x002007F0
	public void RequestBuyBattlePassLevel(int level)
	{
		RegressBuyBonusLvRequest regressBuyBonusLvRequest = RegressBuyBonusLvRequest.Create();
		regressBuyBonusLvRequest.BuyLv = level;
		Net.Instance.Call(ERequestMessageId.RegressBuyBonusLvRequest, regressBuyBonusLvRequest, delegate(IMessage _, Net.CallbackStatus __)
		{
			EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		}, 0);
	}

	// Token: 0x060066A4 RID: 26276 RVA: 0x0020263A File Offset: 0x0020083A
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		if (notify.PayItemId == 46)
		{
			ActivityRegressModel.Instance.ActivityData.SetPayRewardUnlock(true);
			EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
			UiManager.Instance.OpenView(EUiViewName.RegressBpLevelUpTipsView, null, null);
		}
	}

	// Token: 0x060066A5 RID: 26277 RVA: 0x00202678 File Offset: 0x00200878
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

	// Token: 0x060066A6 RID: 26278 RVA: 0x00202724 File Offset: 0x00200924
	public void OpenTrialRoleView(int? selectedGroupId = null)
	{
		NewPlayerSupportTrialRoleViewModel newPlayerSupportTrialRoleViewModel = new NewPlayerSupportTrialRoleViewModel(ETrialRoleType.ReturnSupportTrial, ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleIcon"), ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleTitle"), 465, selectedGroupId);
		newPlayerSupportTrialRoleViewModel.SetRequestTrialRoleLvUpFunc(new Action<int>(this.RegressTrialRoleLvUpRequest));
		newPlayerSupportTrialRoleViewModel.SetRequestSetCurUseTrialRoleFunc(new Action<int, Action<int>>(this.RegressSetCurUseTrialRoleRequest));
		Dictionary<int, string> trialRoleUnlockDesc = ActivityRegressConfig.Instance.GetTrialRoleUnlockDesc();
		newPlayerSupportTrialRoleViewModel.SetTrialRoleGroupUnlockDesc(trialRoleUnlockDesc);
		UiManager.Instance.OpenView(EUiViewName.ActivityNewPlayerSupportTrialRoleView, newPlayerSupportTrialRoleViewModel, null);
	}

	// Token: 0x060066A7 RID: 26279 RVA: 0x0020279C File Offset: 0x0020099C
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

	// Token: 0x17000CF4 RID: 3316
	// (get) Token: 0x060066A8 RID: 26280 RVA: 0x002027EB File Offset: 0x002009EB
	public static ActivityRegressController Instance
	{
		get
		{
			return ActivityRegressController._Instance;
		}
	}

	// Token: 0x060066A9 RID: 26281 RVA: 0x002027F2 File Offset: 0x002009F2
	public static ActivityRegressController GetOrCreateInstance()
	{
		if (ActivityRegressController._Instance == null)
		{
			ActivityRegressController.CreateInstance();
		}
		return ActivityRegressController._Instance;
	}

	// Token: 0x060066AA RID: 26282 RVA: 0x00202806 File Offset: 0x00200A06
	public static bool CreateInstance()
	{
		if (ActivityRegressController._Instance != null)
		{
			return true;
		}
		ActivityRegressController._Instance = new ActivityRegressController();
		return true;
	}

	// Token: 0x060066AB RID: 26283 RVA: 0x0020281C File Offset: 0x00200A1C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060066AC RID: 26284 RVA: 0x0020281E File Offset: 0x00200A1E
	public static void ResetStaticDefaultValue()
	{
		ActivityRegressController._Instance = null;
	}

	// Token: 0x060066AD RID: 26285 RVA: 0x00202826 File Offset: 0x00200A26
	static ActivityRegressController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRegressController.CreateStaticDefaultValue), new Action(ActivityRegressController.ResetStaticDefaultValue));
	}

	// Token: 0x060066AF RID: 26287 RVA: 0x00202858 File Offset: 0x00200A58
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

	// Token: 0x060066B0 RID: 26288 RVA: 0x0020288E File Offset: 0x00200A8E
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

	// Token: 0x060066B2 RID: 26290 RVA: 0x00202914 File Offset: 0x00200B14
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

	// Token: 0x0400419F RID: 16799
	private const int BP_REMINDER_INTERVAL = 5;

	// Token: 0x040041A0 RID: 16800
	private readonly Dictionary<ERecallStartCondition, bool> ActivityStartConditionMap = new Dictionary<ERecallStartCondition, bool>();

	// Token: 0x040041A1 RID: 16801
	[Nullable(2)]
	private static ActivityRegressController _Instance;
}
