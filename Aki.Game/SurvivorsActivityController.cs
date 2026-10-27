using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002AB6 RID: 10934
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SurvivorsActivityController : ActivityControllerBase
{
	// Token: 0x06016C34 RID: 93236 RVA: 0x005C7484 File Offset: 0x005C5684
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06016C35 RID: 93237 RVA: 0x005C7486 File Offset: 0x005C5686
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_SurvivorsActivity";
	}

	// Token: 0x06016C36 RID: 93238 RVA: 0x005C748D File Offset: 0x005C568D
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new SurvivorsActivitySubView();
	}

	// Token: 0x06016C37 RID: 93239 RVA: 0x005C7494 File Offset: 0x005C5694
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new global::SurvivorsActivityData();
	}

	// Token: 0x06016C38 RID: 93240 RVA: 0x005C749C File Offset: 0x005C569C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SurvivorsHandBooskUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsHandBookUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsTaskDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsChallengeInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsChallengeInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsTalentUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsTalentUnlockNotify));
	}

	// Token: 0x06016C39 RID: 93241 RVA: 0x005C751C File Offset: 0x005C571C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsHandBooskUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsTaskDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsChallengeInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsTalentUnlockNotify);
	}

	// Token: 0x06016C3A RID: 93242 RVA: 0x005C7569 File Offset: 0x005C5769
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Add(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x06016C3B RID: 93243 RVA: 0x005C75A3 File Offset: 0x005C57A3
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x06016C3C RID: 93244 RVA: 0x005C75E0 File Offset: 0x005C57E0
	[NullableContext(2)]
	private void OnSurvivorsHandBookUnlockNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsHandBooskUnlockNotify survivorsHandBooskUnlockNotify = (SurvivorsHandBooskUnlockNotify)msg;
		global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		foreach (int key in survivorsHandBooskUnlockNotify.UnlockRoleHandBooks)
		{
			activityData.RoleMap[key] = true;
		}
		foreach (int key2 in survivorsHandBooskUnlockNotify.UnlockWeaponHandBooks)
		{
			activityData.WeaponMap[key2] = true;
		}
		foreach (int key3 in survivorsHandBooskUnlockNotify.UnlockItemHandBooks)
		{
			activityData.ItemMap[key3] = true;
		}
	}

	// Token: 0x06016C3D RID: 93245 RVA: 0x005C76D4 File Offset: 0x005C58D4
	[NullableContext(2)]
	private void OnSurvivorsTaskDataUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsTaskDataUpdateNotify survivorsTaskDataUpdateNotify = (SurvivorsTaskDataUpdateNotify)msg;
		global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		if (survivorsTaskDataUpdateNotify.ActivityTaskData != null)
		{
			foreach (ActivityTask task in survivorsTaskDataUpdateNotify.ActivityTaskData.ActivityTasks)
			{
				activityData.RefreshRewardTaskData(task);
			}
		}
		if (activityData.GetRewardRedDotState())
		{
			activityData.RefreshActivityRedDot();
		}
	}

	// Token: 0x06016C3E RID: 93246 RVA: 0x005C7754 File Offset: 0x005C5954
	[NullableContext(2)]
	private void OnSurvivorsChallengeInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsChallengeInfoUpdateNotify survivorsChallengeInfoUpdateNotify = (SurvivorsChallengeInfoUpdateNotify)msg;
		global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		foreach (SurvivorsChallengeInfo survivorsChallengeInfo in survivorsChallengeInfoUpdateNotify.SurvivorsChallengeInfos)
		{
			activityData.LevelMap[survivorsChallengeInfo.LevelId] = survivorsChallengeInfo;
		}
		activityData.RefreshActivityRedDot();
	}

	// Token: 0x06016C3F RID: 93247 RVA: 0x005C77C8 File Offset: 0x005C59C8
	[NullableContext(2)]
	private void OnSurvivorsTalentUnlockNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsTalentUnlockNotify survivorsTalentUnlockNotify = (SurvivorsTalentUnlockNotify)msg;
		global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.RefreshTalentTreeNode(survivorsTalentUnlockNotify.SkillId, 0);
		EventSystem.Instance.Emit<int>(EEventName.SurvivorsRogueTalentNodeUpdate, survivorsTalentUnlockNotify.SkillId);
	}

	// Token: 0x06016C40 RID: 93248 RVA: 0x005C7810 File Offset: 0x005C5A10
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.OnQuestStateChange(questId, state);
	}

	// Token: 0x06016C41 RID: 93249 RVA: 0x005C7834 File Offset: 0x005C5A34
	public void RequestGetRewardTask(int[] taskIdList)
	{
		SurvivorsNormalAwardRequest survivorsNormalAwardRequest = SurvivorsNormalAwardRequest.Create();
		survivorsNormalAwardRequest.Configs.Add(taskIdList);
		Net.Instance.Call(ERequestMessageId.SurvivorsNormalAwardRequest, survivorsNormalAwardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			SurvivorsNormalAwardResponse survivorsNormalAwardResponse = (SurvivorsNormalAwardResponse)msg;
			if (survivorsNormalAwardResponse == null)
			{
				return;
			}
			if (survivorsNormalAwardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsNormalAwardResponse.ErrorCode, EResponseMessageId.SurvivorsNormalAwardResponse, null, true, true);
				return;
			}
			global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			foreach (int rewardTaskDataDone in taskIdList)
			{
				activityData.SetRewardTaskDataDone(rewardTaskDataDone);
			}
			activityData.RefreshActivityRedDot();
		}, 0);
	}

	// Token: 0x06016C42 RID: 93250 RVA: 0x005C7884 File Offset: 0x005C5A84
	public void RequestGetRewardScore(int[] scoreIdList)
	{
		SurvivorsScoreAwardRequest survivorsScoreAwardRequest = SurvivorsScoreAwardRequest.Create();
		survivorsScoreAwardRequest.Configs.Add(scoreIdList);
		Net.Instance.Call(ERequestMessageId.SurvivorsScoreAwardRequest, survivorsScoreAwardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			SurvivorsScoreAwardResponse survivorsScoreAwardResponse = (SurvivorsScoreAwardResponse)msg;
			if (survivorsScoreAwardResponse == null)
			{
				return;
			}
			if (survivorsScoreAwardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsScoreAwardResponse.ErrorCode, EResponseMessageId.SurvivorsScoreAwardResponse, null, true, true);
				return;
			}
			global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			foreach (int milestoneRewardId in scoreIdList)
			{
				activityData.RefreshGotMilestoneReward(milestoneRewardId);
			}
			activityData.RefreshActivityRedDot();
		}, 0);
	}

	// Token: 0x06016C43 RID: 93251 RVA: 0x005C78D4 File Offset: 0x005C5AD4
	public void SurvivorsTalentLevelUpRequest(int nodeId, Action callback)
	{
		SurvivorsTalentLevelUpRequest survivorsTalentLevelUpRequest = Aki.Protocol.SurvivorsTalentLevelUpRequest.Create();
		survivorsTalentLevelUpRequest.SkillId = nodeId;
		Net.Instance.Call(ERequestMessageId.SurvivorsTalentLevelUpRequest, survivorsTalentLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			SurvivorsTalentLevelUpResponse survivorsTalentLevelUpResponse = (SurvivorsTalentLevelUpResponse)msg;
			if (survivorsTalentLevelUpResponse == null)
			{
				return;
			}
			if (survivorsTalentLevelUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsTalentLevelUpResponse.ErrorCode, EResponseMessageId.SurvivorsTalentLevelUpResponse, null, true, true);
				return;
			}
			global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.RefreshTalentTreeNode(nodeId, survivorsTalentLevelUpResponse.Level);
			EventSystem.Instance.Emit<int>(EEventName.SurvivorsRogueTalentNodeUpdate, nodeId);
			callback();
		}, 0);
	}

	// Token: 0x06016C44 RID: 93252 RVA: 0x005C7924 File Offset: 0x005C5B24
	public void CheckIsActivityClose()
	{
		global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		if (activityData.CheckIfClose())
		{
			ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
		}
	}

	// Token: 0x06016C45 RID: 93253 RVA: 0x005C7954 File Offset: 0x005C5B54
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		SurvivorsActivityConfig? rogueActivityConfig = SurvivorsRogueModel.Instance.GetRogueActivityConfig();
		if (rogueActivityConfig == null)
		{
			return;
		}
		if (configId != rogueActivityConfig.Value.ScoreItemId)
		{
			return;
		}
		SurvivorsRogueModel.Instance.ActivityData.RefreshActivityRedDot();
	}

	// Token: 0x06016C46 RID: 93254 RVA: 0x005C7998 File Offset: 0x005C5B98
	[NullableContext(0)]
	protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		SurvivorsActivityController.<OnOpenSubView>d__18 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.viewName = viewName;
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<SurvivorsActivityController.<OnOpenSubView>d__18>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06016C47 RID: 93255 RVA: 0x005C79DC File Offset: 0x005C5BDC
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		if (SurvivorsRogueModel.Instance.ActivityData == null)
		{
			return false;
		}
		foreach (EUiViewName viewName in new EUiViewName[]
		{
			EUiViewName.SurvivorsRogueMainView,
			EUiViewName.SurvivorsTeamEditView,
			EUiViewName.SurvivorsRogueSettleExternalView,
			EUiViewName.SurvivorsTalentTreeView,
			EUiViewName.SurvivorsHandbookView
		})
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06016C48 RID: 93256 RVA: 0x005C7A60 File Offset: 0x005C5C60
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueActivityUnlockView, null, null);
	}

	// Token: 0x17001E4C RID: 7756
	// (get) Token: 0x06016C49 RID: 93257 RVA: 0x005C7A73 File Offset: 0x005C5C73
	public static SurvivorsActivityController Instance
	{
		get
		{
			return SurvivorsActivityController._Instance;
		}
	}

	// Token: 0x06016C4A RID: 93258 RVA: 0x005C7A7A File Offset: 0x005C5C7A
	public static SurvivorsActivityController GetOrCreateInstance()
	{
		if (SurvivorsActivityController._Instance == null)
		{
			SurvivorsActivityController.CreateInstance();
		}
		return SurvivorsActivityController._Instance;
	}

	// Token: 0x06016C4B RID: 93259 RVA: 0x005C7A8E File Offset: 0x005C5C8E
	public static bool CreateInstance()
	{
		if (SurvivorsActivityController._Instance != null)
		{
			return true;
		}
		SurvivorsActivityController._Instance = new SurvivorsActivityController();
		return true;
	}

	// Token: 0x06016C4C RID: 93260 RVA: 0x005C7AA4 File Offset: 0x005C5CA4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016C4D RID: 93261 RVA: 0x005C7AA6 File Offset: 0x005C5CA6
	public static void ResetStaticDefaultValue()
	{
		SurvivorsActivityController._Instance = null;
	}

	// Token: 0x06016C4E RID: 93262 RVA: 0x005C7AAE File Offset: 0x005C5CAE
	static SurvivorsActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsActivityController.CreateStaticDefaultValue), new Action(SurvivorsActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A90B RID: 43275
	[Nullable(2)]
	private static SurvivorsActivityController _Instance;
}
