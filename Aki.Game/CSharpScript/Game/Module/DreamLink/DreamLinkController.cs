using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A91 RID: 23185
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class DreamLinkController : ActivityControllerBase
	{
		// Token: 0x0603AB9B RID: 240539 RVA: 0x00DFCCBC File Offset: 0x00DFAEBC
		protected override void OnOpenView(ActivityBaseData data)
		{
			DreamLinkData dreamLinkData = data as DreamLinkData;
			if (!dreamLinkData.IsDreamLinkFunctionUnlock(0))
			{
				int unFinishPreGuideQuestId = dreamLinkData.GetUnFinishPreGuideQuestId();
				dreamLinkData.SaveQuestRedDotState();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			dreamLinkData.GetActivityConfig();
			UiManager.Instance.OpenView(EUiViewName.DreamLinkMainView, 1, null);
		}

		// Token: 0x0603AB9C RID: 240540 RVA: 0x00DFCD1A File Offset: 0x00DFAF1A
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_DreamLandActivity";
		}

		// Token: 0x0603AB9D RID: 240541 RVA: 0x00DFCD21 File Offset: 0x00DFAF21
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new DreamLinkActivitySubView();
		}

		// Token: 0x0603AB9E RID: 240542 RVA: 0x00DFCD28 File Offset: 0x00DFAF28
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new DreamLinkData();
		}

		// Token: 0x0603AB9F RID: 240543 RVA: 0x00DFCD2F File Offset: 0x00DFAF2F
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603ABA0 RID: 240544 RVA: 0x00DFCD34 File Offset: 0x00DFAF34
		[NullableContext(2)]
		public DreamLinkData GetCurrentActivityData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.RogueWhiteCat);
			DreamLinkData result = null;
			foreach (ActivityBaseData activityBaseData in currentActivitiesByType)
			{
				result = (activityBaseData as DreamLinkData);
			}
			return result;
		}

		// Token: 0x0603ABA1 RID: 240545 RVA: 0x00DFCD90 File Offset: 0x00DFAF90
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.DreamLinkDungeonView, new Func<EUiViewName, object, bool>(this.OpenViewCheck), "DreamLinkDungeonView.Check");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.DreamLinkWhiteCatView, new Func<EUiViewName, object, bool>(this.OpenViewCheck), "DreamLinkWhiteCatView.Check");
		}

		// Token: 0x0603ABA2 RID: 240546 RVA: 0x00DFCDFC File Offset: 0x00DFAFFC
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.DreamLinkDungeonView, new Func<EUiViewName, object, bool>(this.OpenViewCheck));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.DreamLinkWhiteCatView, new Func<EUiViewName, object, bool>(this.OpenViewCheck));
		}

		// Token: 0x0603ABA3 RID: 240547 RVA: 0x00DFCE5B File Offset: 0x00DFB05B
		private bool OpenViewCheck(EUiViewName viewName, object openParam)
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("DreamLink_MultiModeNotSupport", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0603ABA4 RID: 240548 RVA: 0x00DFCE80 File Offset: 0x00DFB080
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RogueWhiteCatDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWhiteCatDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueWhiteCatLimitedUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWhiteCatLimitedUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueLevelPlayNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueLevelPlayNotify));
			Net.Instance.Register(ENotifyMessageId.RogueBossLinkSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueBossLinkSettleNotify));
		}

		// Token: 0x0603ABA5 RID: 240549 RVA: 0x00DFCF00 File Offset: 0x00DFB100
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RogueWhiteCatDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueWhiteCatLimitedUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueLevelPlayNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueBossLinkSettleNotify);
		}

		// Token: 0x0603ABA6 RID: 240550 RVA: 0x00DFCF50 File Offset: 0x00DFB150
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason arg3)
		{
			DreamLinkData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			if (currentActivityData.LocalConfig.Value.PreShowGuideQuest().Contains(questId))
			{
				currentActivityData.RefreshActivityRedDotState();
			}
		}

		// Token: 0x0603ABA7 RID: 240551 RVA: 0x00DFCF8C File Offset: 0x00DFB18C
		[NullableContext(2)]
		private void OnRogueBossLinkSettleNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueBossLinkSettleNotify param = (RogueBossLinkSettleNotify)msg;
			UiManager.Instance.OpenView(EUiViewName.DreamLinkWhiteCatSettleView, param, null);
		}

		// Token: 0x0603ABA8 RID: 240552 RVA: 0x00DFCFB4 File Offset: 0x00DFB1B4
		[NullableContext(2)]
		private void OnRogueWhiteCatDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueWhiteCatDataUpdateNotify data = (RogueWhiteCatDataUpdateNotify)msg;
			DreamLinkData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.UpdateData(data);
		}

		// Token: 0x0603ABA9 RID: 240553 RVA: 0x00DFCFDC File Offset: 0x00DFB1DC
		[NullableContext(2)]
		private void OnRogueWhiteCatLimitedUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueWhiteCatLimitedUpdateNotify rogueWhiteCatLimitedUpdateNotify = (RogueWhiteCatLimitedUpdateNotify)msg;
			DreamLinkData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.RefreshAllLimitTimeReward(rogueWhiteCatLimitedUpdateNotify.RogueLimitedAwards.ToList<RogueLimitedAward>());
			currentActivityData.RefreshLimitRewardPerformance();
		}

		// Token: 0x0603ABAA RID: 240554 RVA: 0x00DFD014 File Offset: 0x00DFB214
		[NullableContext(2)]
		private unsafe void OnRogueLevelPlayNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueLevelPlayNotify rogueLevelPlayNotify = (RogueLevelPlayNotify)msg;
			if (this.GetCurrentActivityData() == null)
			{
				return;
			}
			RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_45_ButtonText_1",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true
			};
			RewardExploreRecordData rewardExploreRecordData = new RewardExploreRecordData
			{
				TitleTextId = "WorldRun_Settlement",
				Record = TimeUtil.Instance.GetTimeString((double)Math.Max(rogueLevelPlayNotify.UseTime, 0)),
				IsNewRecord = rogueLevelPlayNotify.IsNewRecord
			};
			ItemRewardController instance = ItemRewardController.Instance;
			int configId = 3020;
			bool isSuccess = rogueLevelPlayNotify.IsSuccess;
			List<RewardItemData> rewardItemDataList = null;
			IRewardExploreRecord exploreRecordInfo = rewardExploreRecordData;
			List<IRewardExploreBar> exploreBarDataList = null;
			int num = 1;
			List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>(num);
			CollectionsMarshal.SetCount<IRewardExploreConfirmButton>(list, num);
			Span<IRewardExploreConfirmButton> span = CollectionsMarshal.AsSpan<IRewardExploreConfirmButton>(list);
			int index = 0;
			*span[index] = rewardExploreConfirmButtonData;
			instance.OpenExploreRewardView(configId, isSuccess, rewardItemDataList, exploreRecordInfo, exploreBarDataList, list, null, null, null, null, null, null, null, null, null, null, null);
		}

		// Token: 0x0603ABAB RID: 240555 RVA: 0x00DFD0EC File Offset: 0x00DFB2EC
		public override bool GetActivityMapMarkState(int markId)
		{
			DreamLinkData currentActivityData = this.GetCurrentActivityData();
			return currentActivityData != null && currentActivityData.IsDreamLinkRunMarkShow(markId);
		}

		// Token: 0x0603ABAC RID: 240556 RVA: 0x00DFD10C File Offset: 0x00DFB30C
		public void RoguelikeSetDungeonProgressRequest(int progress)
		{
			RogueWhiteCatRecordRequest rogueWhiteCatRecordRequest = RogueWhiteCatRecordRequest.Create();
			rogueWhiteCatRecordRequest.Value = progress;
			rogueWhiteCatRecordRequest.ActivityId = this.GetCurrentActivityData().Id;
			Net.Instance.Call(ERequestMessageId.RogueWhiteCatRecordRequest, rogueWhiteCatRecordRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueWhiteCatRecordResponse rogueWhiteCatRecordResponse = (RogueWhiteCatRecordResponse)msg;
				if (rogueWhiteCatRecordResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWhiteCatRecordResponse.ErrorCode, 23656, null, true, true);
					return;
				}
				this.GetCurrentActivityData().DungeonProgressRecord = progress;
			}, 0);
		}

		// Token: 0x0603ABAD RID: 240557 RVA: 0x00DFD170 File Offset: 0x00DFB370
		public void RoguelikeRoleInstStartRequest(int dungeonIndex)
		{
			if (RoleController.Instance.IsInRoleTrial())
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return;
			}
			if (SceneTeamModel.Instance.IsPhantomTeam)
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
				return;
			}
			DreamLinkData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			RoguelikeRoleInstStartRequest roguelikeRoleInstStartRequest = Aki.Protocol.RoguelikeRoleInstStartRequest.Create();
			roguelikeRoleInstStartRequest.Index = dungeonIndex;
			roguelikeRoleInstStartRequest.ActivityId = currentActivityData.Id;
			Net.Instance.Call(ERequestMessageId.RoguelikeRoleInstStartRequest, roguelikeRoleInstStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoguelikeRoleInstStartResponse roguelikeRoleInstStartResponse = (RoguelikeRoleInstStartResponse)msg;
				if (roguelikeRoleInstStartResponse == null)
				{
					Log.Instance.Error(ELogModule.DreamLink, ELogAuthor.LPH, "RoleInstStartRequest response is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				if (roguelikeRoleInstStartResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeRoleInstStartResponse.ErrorCode, 17317, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0603ABAE RID: 240558 RVA: 0x00DFD214 File Offset: 0x00DFB414
		public void RunTaskRewardRequest(int id)
		{
			DreamLinkData dreamLinkData = this.GetCurrentActivityData();
			if (dreamLinkData == null)
			{
				return;
			}
			RoguelikeWriteCatLevelPlayRewardRequest roguelikeWriteCatLevelPlayRewardRequest = RoguelikeWriteCatLevelPlayRewardRequest.Create();
			roguelikeWriteCatLevelPlayRewardRequest.Index = id;
			roguelikeWriteCatLevelPlayRewardRequest.ActivityId = dreamLinkData.Id;
			Net.Instance.Call(ERequestMessageId.RoguelikeWriteCatLevelPlayRewardRequest, roguelikeWriteCatLevelPlayRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoguelikeWriteCatLevelPlayRewardResponse roguelikeWriteCatLevelPlayRewardResponse = (RoguelikeWriteCatLevelPlayRewardResponse)msg;
				if (roguelikeWriteCatLevelPlayRewardResponse == null)
				{
					return;
				}
				if (roguelikeWriteCatLevelPlayRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeWriteCatLevelPlayRewardResponse.ErrorCode, 24513, null, true, true);
					return;
				}
				dreamLinkData.SetRunTaskDone(id);
				dreamLinkData.RefreshRewardPerformance();
			}, 0);
		}

		// Token: 0x0603ABAF RID: 240559 RVA: 0x00DFD284 File Offset: 0x00DFB484
		public void MultiEnergyRewardRequest(int[] ids)
		{
			DreamLinkData dreamLinkData = this.GetCurrentActivityData();
			if (dreamLinkData == null)
			{
				return;
			}
			MulRoguelikeWriteCatRewardRequest mulRoguelikeWriteCatRewardRequest = MulRoguelikeWriteCatRewardRequest.Create();
			mulRoguelikeWriteCatRewardRequest.Index.AddRange(ids);
			mulRoguelikeWriteCatRewardRequest.ActivityId = dreamLinkData.Id;
			Net.Instance.Call(ERequestMessageId.MulRoguelikeWriteCatRewardRequest, mulRoguelikeWriteCatRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MulRoguelikeWriteCatRewardResponse mulRoguelikeWriteCatRewardResponse = (MulRoguelikeWriteCatRewardResponse)msg;
				if (mulRoguelikeWriteCatRewardResponse == null)
				{
					return;
				}
				if (mulRoguelikeWriteCatRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(mulRoguelikeWriteCatRewardResponse.ErrorCode, 27734, null, true, true);
					return;
				}
				foreach (int id in ids)
				{
					dreamLinkData.RefreshEnergyRewardData(id, EActivityTaskState.FinishedAndClaimed);
				}
				dreamLinkData.RefreshRewardPerformance();
			}, 0);
		}

		// Token: 0x0603ABB0 RID: 240560 RVA: 0x00DFD2F8 File Offset: 0x00DFB4F8
		public void LimitTimeRewardRequest(int id)
		{
			DreamLinkData dreamLinkData = this.GetCurrentActivityData();
			if (dreamLinkData == null)
			{
				return;
			}
			RogueWhiteCatLimitedRewardRequest rogueWhiteCatLimitedRewardRequest = RogueWhiteCatLimitedRewardRequest.Create();
			rogueWhiteCatLimitedRewardRequest.Index = id;
			Net.Instance.Call(ERequestMessageId.RogueWhiteCatLimitedRewardRequest, rogueWhiteCatLimitedRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueWhiteCatLimitedRewardResponse rogueWhiteCatLimitedRewardResponse = (RogueWhiteCatLimitedRewardResponse)msg;
				if (rogueWhiteCatLimitedRewardResponse == null)
				{
					return;
				}
				if (rogueWhiteCatLimitedRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWhiteCatLimitedRewardResponse.ErrorCode, 18506, null, true, true);
					return;
				}
				dreamLinkData.RefreshLimitTimeRewardData(id, EActivityTaskState.FinishedAndClaimed, null, null);
				dreamLinkData.RefreshLimitRewardPerformance();
			}, 0);
		}

		// Token: 0x0603ABB1 RID: 240561 RVA: 0x00DFD358 File Offset: 0x00DFB558
		public void BossRewardRequest(int id)
		{
			DreamLinkData dreamLinkData = this.GetCurrentActivityData();
			if (dreamLinkData == null)
			{
				return;
			}
			RoguelikeWriteCatBossRewardRequest roguelikeWriteCatBossRewardRequest = RoguelikeWriteCatBossRewardRequest.Create();
			roguelikeWriteCatBossRewardRequest.Index = id;
			roguelikeWriteCatBossRewardRequest.ActivityId = dreamLinkData.Id;
			Net.Instance.Call(ERequestMessageId.RoguelikeWriteCatBossRewardRequest, roguelikeWriteCatBossRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoguelikeWriteCatBossRewardResponse roguelikeWriteCatBossRewardResponse = (RoguelikeWriteCatBossRewardResponse)msg;
				if (roguelikeWriteCatBossRewardResponse == null)
				{
					return;
				}
				if (roguelikeWriteCatBossRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeWriteCatBossRewardResponse.ErrorCode, 25187, null, true, true);
					return;
				}
				dreamLinkData.RefreshBossRewardData(id, EActivityTaskState.FinishedAndClaimed);
				dreamLinkData.RefreshRewardPerformance();
			}, 0);
		}

		// Token: 0x0603ABB2 RID: 240562 RVA: 0x00DFD3C7 File Offset: 0x00DFB5C7
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipDreamLinkView, null, null);
		}

		// Token: 0x17008C01 RID: 35841
		// (get) Token: 0x0603ABB3 RID: 240563 RVA: 0x00DFD3DA File Offset: 0x00DFB5DA
		public static DreamLinkController Instance
		{
			get
			{
				return DreamLinkController._Instance;
			}
		}

		// Token: 0x0603ABB4 RID: 240564 RVA: 0x00DFD3E1 File Offset: 0x00DFB5E1
		public static DreamLinkController GetOrCreateInstance()
		{
			if (DreamLinkController._Instance == null)
			{
				DreamLinkController.CreateInstance();
			}
			return DreamLinkController._Instance;
		}

		// Token: 0x0603ABB5 RID: 240565 RVA: 0x00DFD3F5 File Offset: 0x00DFB5F5
		public static bool CreateInstance()
		{
			if (DreamLinkController._Instance != null)
			{
				return true;
			}
			DreamLinkController._Instance = new DreamLinkController();
			return true;
		}

		// Token: 0x0603ABB6 RID: 240566 RVA: 0x00DFD40B File Offset: 0x00DFB60B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603ABB7 RID: 240567 RVA: 0x00DFD40D File Offset: 0x00DFB60D
		public static void ResetStaticDefaultValue()
		{
			DreamLinkController._Instance = null;
		}

		// Token: 0x0603ABB8 RID: 240568 RVA: 0x00DFD415 File Offset: 0x00DFB615
		static DreamLinkController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DreamLinkController.CreateStaticDefaultValue), new Action(DreamLinkController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EA68 RID: 125544
		[Nullable(2)]
		private static DreamLinkController _Instance;
	}
}
