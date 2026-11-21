using System;
using System.Collections.Generic;
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
	// Token: 0x02004A6D RID: 19053
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class DreamLinkController : ActivityControllerBase
	{
		// Token: 0x0602FAE4 RID: 195300 RVA: 0x00D4D250 File Offset: 0x00D4B450
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

		// Token: 0x0602FAE5 RID: 195301 RVA: 0x00D4D2AE File Offset: 0x00D4B4AE
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_DreamLandActivity";
		}

		// Token: 0x0602FAE6 RID: 195302 RVA: 0x00D4D2B5 File Offset: 0x00D4B4B5
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new DreamLinkActivitySubView();
		}

		// Token: 0x0602FAE7 RID: 195303 RVA: 0x00D4D2BC File Offset: 0x00D4B4BC
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new DreamLinkData();
		}

		// Token: 0x0602FAE8 RID: 195304 RVA: 0x00D4D2C3 File Offset: 0x00D4B4C3
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0602FAE9 RID: 195305 RVA: 0x00D4D2C8 File Offset: 0x00D4B4C8
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

		// Token: 0x0602FAEA RID: 195306 RVA: 0x00D4D324 File Offset: 0x00D4B524
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.DreamLinkDungeonView, new Func<EUiViewName, object, bool>(this.OpenViewCheck), "DreamLinkDungeonView.Check");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.DreamLinkWhiteCatView, new Func<EUiViewName, object, bool>(this.OpenViewCheck), "DreamLinkWhiteCatView.Check");
		}

		// Token: 0x0602FAEB RID: 195307 RVA: 0x00D4D390 File Offset: 0x00D4B590
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.DreamLinkDungeonView, new Func<EUiViewName, object, bool>(this.OpenViewCheck));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.DreamLinkWhiteCatView, new Func<EUiViewName, object, bool>(this.OpenViewCheck));
		}

		// Token: 0x0602FAEC RID: 195308 RVA: 0x00D4D3EF File Offset: 0x00D4B5EF
		private bool OpenViewCheck(EUiViewName viewName, object openParam)
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("DreamLink_MultiModeNotSupport", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0602FAED RID: 195309 RVA: 0x00D4D414 File Offset: 0x00D4B614
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RogueWhiteCatDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWhiteCatDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueWhiteCatLimitedUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWhiteCatLimitedUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueLevelPlayNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueLevelPlayNotify));
			Net.Instance.Register(ENotifyMessageId.RogueBossLinkSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueBossLinkSettleNotify));
		}

		// Token: 0x0602FAEE RID: 195310 RVA: 0x00D4D494 File Offset: 0x00D4B694
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RogueWhiteCatDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueWhiteCatLimitedUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueLevelPlayNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueBossLinkSettleNotify);
		}

		// Token: 0x0602FAEF RID: 195311 RVA: 0x00D4D4E4 File Offset: 0x00D4B6E4
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason arg3)
		{
			DreamLinkData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			if (Array.IndexOf<int>(currentActivityData.LocalConfig.Value.PreShowGuideQuest(), questId) >= 0)
			{
				currentActivityData.RefreshActivityRedDotState();
			}
		}

		// Token: 0x0602FAF0 RID: 195312 RVA: 0x00D4D520 File Offset: 0x00D4B720
		[NullableContext(2)]
		private void OnRogueBossLinkSettleNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueBossLinkSettleNotify param = (RogueBossLinkSettleNotify)msg;
			UiManager.Instance.OpenView(EUiViewName.DreamLinkWhiteCatSettleView, param, null);
		}

		// Token: 0x0602FAF1 RID: 195313 RVA: 0x00D4D548 File Offset: 0x00D4B748
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

		// Token: 0x0602FAF2 RID: 195314 RVA: 0x00D4D570 File Offset: 0x00D4B770
		[NullableContext(2)]
		private void OnRogueWhiteCatLimitedUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueWhiteCatLimitedUpdateNotify rogueWhiteCatLimitedUpdateNotify = (RogueWhiteCatLimitedUpdateNotify)msg;
			DreamLinkData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.RefreshAllLimitTimeReward(rogueWhiteCatLimitedUpdateNotify.RogueLimitedAwards);
			currentActivityData.RefreshLimitRewardPerformance();
		}

		// Token: 0x0602FAF3 RID: 195315 RVA: 0x00D4D5A4 File Offset: 0x00D4B7A4
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

		// Token: 0x0602FAF4 RID: 195316 RVA: 0x00D4D67C File Offset: 0x00D4B87C
		public override bool GetActivityMapMarkState(int markId)
		{
			DreamLinkData currentActivityData = this.GetCurrentActivityData();
			return currentActivityData != null && currentActivityData.IsDreamLinkRunMarkShow(markId);
		}

		// Token: 0x0602FAF5 RID: 195317 RVA: 0x00D4D69C File Offset: 0x00D4B89C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWhiteCatRecordResponse.ErrorCode, 23990, null, true, true);
					return;
				}
				this.GetCurrentActivityData().DungeonProgressRecord = progress;
			}, 0);
		}

		// Token: 0x0602FAF6 RID: 195318 RVA: 0x00D4D700 File Offset: 0x00D4B900
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeRoleInstStartResponse.ErrorCode, 27659, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0602FAF7 RID: 195319 RVA: 0x00D4D7A4 File Offset: 0x00D4B9A4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeWriteCatLevelPlayRewardResponse.ErrorCode, 25589, null, true, true);
					return;
				}
				dreamLinkData.SetRunTaskDone(id);
				dreamLinkData.RefreshRewardPerformance();
			}, 0);
		}

		// Token: 0x0602FAF8 RID: 195320 RVA: 0x00D4D814 File Offset: 0x00D4BA14
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(mulRoguelikeWriteCatRewardResponse.ErrorCode, 24493, null, true, true);
					return;
				}
				foreach (int id in ids)
				{
					dreamLinkData.RefreshEnergyRewardData(id, EActivityTaskState.FinishedAndClaimed);
				}
				dreamLinkData.RefreshRewardPerformance();
			}, 0);
		}

		// Token: 0x0602FAF9 RID: 195321 RVA: 0x00D4D888 File Offset: 0x00D4BA88
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWhiteCatLimitedRewardResponse.ErrorCode, 29426, null, true, true);
					return;
				}
				dreamLinkData.RefreshLimitTimeRewardData(id, EActivityTaskState.FinishedAndClaimed, null, null);
				dreamLinkData.RefreshLimitRewardPerformance();
			}, 0);
		}

		// Token: 0x0602FAFA RID: 195322 RVA: 0x00D4D8E8 File Offset: 0x00D4BAE8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeWriteCatBossRewardResponse.ErrorCode, 19415, null, true, true);
					return;
				}
				dreamLinkData.RefreshBossRewardData(id, EActivityTaskState.FinishedAndClaimed);
				dreamLinkData.RefreshRewardPerformance();
			}, 0);
		}

		// Token: 0x0602FAFB RID: 195323 RVA: 0x00D4D957 File Offset: 0x00D4BB57
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipDreamLinkView, null, null);
		}

		// Token: 0x17005FCF RID: 24527
		// (get) Token: 0x0602FAFC RID: 195324 RVA: 0x00D4D96A File Offset: 0x00D4BB6A
		public static DreamLinkController Instance
		{
			get
			{
				return DreamLinkController._Instance;
			}
		}

		// Token: 0x0602FAFD RID: 195325 RVA: 0x00D4D971 File Offset: 0x00D4BB71
		public static DreamLinkController GetOrCreateInstance()
		{
			if (DreamLinkController._Instance == null)
			{
				DreamLinkController.CreateInstance();
			}
			return DreamLinkController._Instance;
		}

		// Token: 0x0602FAFE RID: 195326 RVA: 0x00D4D985 File Offset: 0x00D4BB85
		public static bool CreateInstance()
		{
			if (DreamLinkController._Instance != null)
			{
				return true;
			}
			DreamLinkController._Instance = new DreamLinkController();
			return true;
		}

		// Token: 0x0602FAFF RID: 195327 RVA: 0x00D4D99B File Offset: 0x00D4BB9B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FB00 RID: 195328 RVA: 0x00D4D99D File Offset: 0x00D4BB9D
		public static void ResetStaticDefaultValue()
		{
			DreamLinkController._Instance = null;
		}

		// Token: 0x0602FB01 RID: 195329 RVA: 0x00D4D9A5 File Offset: 0x00D4BBA5
		static DreamLinkController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DreamLinkController.CreateStaticDefaultValue), new Action(DreamLinkController.ResetStaticDefaultValue));
		}

		// Token: 0x0401950F RID: 103695
		[Nullable(2)]
		private static DreamLinkController _Instance;
	}
}
