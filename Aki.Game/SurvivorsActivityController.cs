using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002032 RID: 8242
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SurvivorsActivityController : ActivityControllerBase
{
	// Token: 0x06014665 RID: 83557 RVA: 0x005F3FD8 File Offset: 0x005F21D8
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06014666 RID: 83558 RVA: 0x005F3FDA File Offset: 0x005F21DA
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_SurvivorsActivity";
	}

	// Token: 0x06014667 RID: 83559 RVA: 0x005F3FE1 File Offset: 0x005F21E1
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new SurvivorsActivitySubView();
	}

	// Token: 0x06014668 RID: 83560 RVA: 0x005F3FE8 File Offset: 0x005F21E8
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new global::SurvivorsActivityData();
	}

	// Token: 0x06014669 RID: 83561 RVA: 0x005F3FF0 File Offset: 0x005F21F0
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SurvivorsHandBooskUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsHandBookUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsTaskDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsChallengeInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsChallengeInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsTalentUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsTalentUnlockNotify));
	}

	// Token: 0x0601466A RID: 83562 RVA: 0x005F4070 File Offset: 0x005F2270
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsHandBooskUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsTaskDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsChallengeInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsTalentUnlockNotify);
	}

	// Token: 0x0601466B RID: 83563 RVA: 0x005F40BD File Offset: 0x005F22BD
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Add(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x0601466C RID: 83564 RVA: 0x005F40F7 File Offset: 0x005F22F7
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x0601466D RID: 83565 RVA: 0x005F4134 File Offset: 0x005F2334
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

	// Token: 0x0601466E RID: 83566 RVA: 0x005F4228 File Offset: 0x005F2428
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

	// Token: 0x0601466F RID: 83567 RVA: 0x005F42A8 File Offset: 0x005F24A8
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

	// Token: 0x06014670 RID: 83568 RVA: 0x005F431C File Offset: 0x005F251C
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

	// Token: 0x06014671 RID: 83569 RVA: 0x005F4364 File Offset: 0x005F2564
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		global::SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.OnQuestStateChange(questId, state);
	}

	// Token: 0x06014672 RID: 83570 RVA: 0x005F4388 File Offset: 0x005F2588
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

	// Token: 0x06014673 RID: 83571 RVA: 0x005F43D8 File Offset: 0x005F25D8
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

	// Token: 0x06014674 RID: 83572 RVA: 0x005F4428 File Offset: 0x005F2628
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

	// Token: 0x06014675 RID: 83573 RVA: 0x005F4478 File Offset: 0x005F2678
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

	// Token: 0x06014676 RID: 83574 RVA: 0x005F44A8 File Offset: 0x005F26A8
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

	// Token: 0x06014677 RID: 83575 RVA: 0x005F44EC File Offset: 0x005F26EC
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

	// Token: 0x06014678 RID: 83576 RVA: 0x005F4530 File Offset: 0x005F2730
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

	// Token: 0x06014679 RID: 83577 RVA: 0x005F45B4 File Offset: 0x005F27B4
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueActivityUnlockView, null, null);
	}

	// Token: 0x17001EA4 RID: 7844
	// (get) Token: 0x0601467A RID: 83578 RVA: 0x005F45C7 File Offset: 0x005F27C7
	public static SurvivorsActivityController Instance
	{
		get
		{
			return SurvivorsActivityController._Instance;
		}
	}

	// Token: 0x0601467B RID: 83579 RVA: 0x005F45CE File Offset: 0x005F27CE
	public static SurvivorsActivityController GetOrCreateInstance()
	{
		if (SurvivorsActivityController._Instance == null)
		{
			SurvivorsActivityController.CreateInstance();
		}
		return SurvivorsActivityController._Instance;
	}

	// Token: 0x0601467C RID: 83580 RVA: 0x005F45E2 File Offset: 0x005F27E2
	public static bool CreateInstance()
	{
		if (SurvivorsActivityController._Instance != null)
		{
			return true;
		}
		SurvivorsActivityController._Instance = new SurvivorsActivityController();
		return true;
	}

	// Token: 0x0601467D RID: 83581 RVA: 0x005F45F8 File Offset: 0x005F27F8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601467E RID: 83582 RVA: 0x005F45FA File Offset: 0x005F27FA
	public static void ResetStaticDefaultValue()
	{
		SurvivorsActivityController._Instance = null;
	}

	// Token: 0x0601467F RID: 83583 RVA: 0x005F4602 File Offset: 0x005F2802
	static SurvivorsActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsActivityController.CreateStaticDefaultValue), new Action(SurvivorsActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AD11 RID: 44305
	[Nullable(2)]
	private static SurvivorsActivityController _Instance;
}
