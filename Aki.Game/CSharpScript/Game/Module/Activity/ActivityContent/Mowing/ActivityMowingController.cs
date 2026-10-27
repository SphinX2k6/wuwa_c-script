using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Mowing
{
	// Token: 0x020063A2 RID: 25506
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMowingController : ActivityControllerBase
	{
		// Token: 0x0604026A RID: 262762 RVA: 0x00F88410 File Offset: 0x00F86610
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.HarvestActivityPointNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHarvestActivityPointNotify));
			Net.Instance.Register(ENotifyMessageId.HarvestActivityLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHarvestActivityLevelNotify));
			Net.Instance.Register(ENotifyMessageId.HarvestActivityResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHarvestActivityResultNotify));
		}

		// Token: 0x0604026B RID: 262763 RVA: 0x00F88471 File Offset: 0x00F86671
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.HarvestActivityPointNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HarvestActivityLevelNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HarvestActivityResultNotify);
		}

		// Token: 0x0604026C RID: 262764 RVA: 0x00F884A3 File Offset: 0x00F866A3
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
		}

		// Token: 0x0604026D RID: 262765 RVA: 0x00F884DD File Offset: 0x00F866DD
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
		}

		// Token: 0x0604026E RID: 262766 RVA: 0x00F88517 File Offset: 0x00F86717
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMowing";
		}

		// Token: 0x0604026F RID: 262767 RVA: 0x00F88520 File Offset: 0x00F86720
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
		{
			if (this.CurrentActivityId == 0)
			{
				return;
			}
			ActivityMowingData mowingActivityData = this.GetMowingActivityData();
			if (mowingActivityData == null)
			{
				return;
			}
			ActivityMowingData activityMowingData = mowingActivityData;
			int[] array = (activityMowingData.LocalConfig != null) ? activityMowingData.LocalConfig.GetValueOrDefault().PreShowGuideQuest() : null;
			if (array != null && Array.IndexOf<int>(array, questId) >= 0)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, mowingActivityData.Id);
			}
		}

		// Token: 0x06040270 RID: 262768 RVA: 0x00F88584 File Offset: 0x00F86784
		private void OnLeaveInstanceDungeonConfirm()
		{
			if (InstanceDungeonEntranceModel.Instance.IsMowingInstanceDungeon())
			{
				this.RequestExitDungeon();
			}
		}

		// Token: 0x06040271 RID: 262769 RVA: 0x00F88598 File Offset: 0x00F86798
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06040272 RID: 262770 RVA: 0x00F8859A File Offset: 0x00F8679A
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityMowingSubView();
		}

		// Token: 0x06040273 RID: 262771 RVA: 0x00F885A1 File Offset: 0x00F867A1
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.CurrentActivityId = data.Id;
			return new ActivityMowingData();
		}

		// Token: 0x06040274 RID: 262772 RVA: 0x00F885B4 File Offset: 0x00F867B4
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06040275 RID: 262773 RVA: 0x00F885B8 File Offset: 0x00F867B8
		public void RequestGetPointReward(int activityId, int rewardUid)
		{
			HarvestActivityPointRequest harvestActivityPointRequest = HarvestActivityPointRequest.Create();
			harvestActivityPointRequest.ActivityId = activityId;
			harvestActivityPointRequest.Id = rewardUid;
			Net.Instance.Call(ERequestMessageId.HarvestActivityPointRequest, harvestActivityPointRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HarvestActivityPointResponse harvestActivityPointResponse = (HarvestActivityPointResponse)msg;
				if (harvestActivityPointResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(harvestActivityPointResponse.ErrorCode, 22430, null, true, true);
					return;
				}
				ActivityMowingData activityMowingData = ActivityModel.Instance.GetActivityById(activityId) as ActivityMowingData;
				activityMowingData.SetPointRewardState(rewardUid);
				EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, activityId);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
				if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
				{
					EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, activityMowingData.GetRewardViewData());
				}
			}, 0);
		}

		// Token: 0x06040276 RID: 262774 RVA: 0x00F88614 File Offset: 0x00F86814
		public void RequestGetLevelReward(int activityId, int instanceId, int rewardUid)
		{
			HarvestActivityLevelRequest harvestActivityLevelRequest = HarvestActivityLevelRequest.Create();
			harvestActivityLevelRequest.ActivityId = activityId;
			harvestActivityLevelRequest.InstId = instanceId;
			Net.Instance.Call(ERequestMessageId.HarvestActivityLevelRequest, harvestActivityLevelRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HarvestActivityLevelResponse harvestActivityLevelResponse = (HarvestActivityLevelResponse)msg;
				if (harvestActivityLevelResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(harvestActivityLevelResponse.ErrorCode, 15302, null, true, true);
					return;
				}
				ActivityMowingData activityMowingData = ActivityModel.Instance.GetActivityById(activityId) as ActivityMowingData;
				activityMowingData.SetLevelRewardStateToGot(instanceId);
				EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, activityId);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
				if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
				{
					EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, activityMowingData.GetRewardViewData());
				}
			}, 0);
		}

		// Token: 0x06040277 RID: 262775 RVA: 0x00F88670 File Offset: 0x00F86870
		public void RequestSetDifficulty(int activityId, int diff)
		{
			HarvestActivityLevelDiffRequest harvestActivityLevelDiffRequest = HarvestActivityLevelDiffRequest.Create();
			harvestActivityLevelDiffRequest.ActivityId = activityId;
			harvestActivityLevelDiffRequest.Diff = diff;
			Net.Instance.Call(ERequestMessageId.HarvestActivityLevelDiffRequest, harvestActivityLevelDiffRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HarvestActivityLevelDiffResponse harvestActivityLevelDiffResponse = (HarvestActivityLevelDiffResponse)msg;
				if (harvestActivityLevelDiffResponse != null && harvestActivityLevelDiffResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(harvestActivityLevelDiffResponse.ErrorCode, 15960, null, true, true);
				}
				ActivityMowingData activityMowingData = ActivityModel.Instance.GetActivityById(activityId) as ActivityMowingData;
				if (((activityMowingData != null) ? activityMowingData.MowingLevelInfoDict : null) != null)
				{
					foreach (KeyValuePair<int, HarvestLevelReward> keyValuePair in activityMowingData.MowingLevelInfoDict)
					{
						keyValuePair.Value.Diff = diff;
					}
				}
				EventSystem.Instance.Emit(EEventName.OnRefreshInstancedRecommendLevel);
			}, 0);
		}

		// Token: 0x06040278 RID: 262776 RVA: 0x00F886CC File Offset: 0x00F868CC
		public void RequestSetDifficultyAll(int activityId, int diff)
		{
			if (this.GetMowingActivityData() == null)
			{
				return;
			}
			this.RequestSetDifficulty(activityId, diff);
		}

		// Token: 0x06040279 RID: 262777 RVA: 0x00F886E0 File Offset: 0x00F868E0
		[NullableContext(2)]
		private void OnHarvestActivityPointNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			HarvestActivityPointNotify harvestActivityPointNotify = (HarvestActivityPointNotify)msg;
			(ActivityModel.Instance.GetActivityById(harvestActivityPointNotify.ActivityId) as ActivityMowingData).UpdatePointRewards(harvestActivityPointNotify);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, harvestActivityPointNotify.ActivityId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, harvestActivityPointNotify.ActivityId);
		}

		// Token: 0x0604027A RID: 262778 RVA: 0x00F8873C File Offset: 0x00F8693C
		[NullableContext(2)]
		private void OnHarvestActivityLevelNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			HarvestActivityLevelNotify harvestActivityLevelNotify = (HarvestActivityLevelNotify)msg;
			(ActivityModel.Instance.GetActivityById(harvestActivityLevelNotify.ActivityId) as ActivityMowingData).UpdateLevelRewards(harvestActivityLevelNotify);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, harvestActivityLevelNotify.ActivityId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, harvestActivityLevelNotify.ActivityId);
		}

		// Token: 0x0604027B RID: 262779 RVA: 0x00F88798 File Offset: 0x00F86998
		[NullableContext(2)]
		private void OnHarvestActivityResultNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			HarvestActivityResultNotify harvestActivityResultNotify = (HarvestActivityResultNotify)msg;
			bool flag = harvestActivityResultNotify.ErrorCode > Aki.Protocol.ErrorCode.Success;
			if (flag)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(harvestActivityResultNotify.ErrorCode, 28748, null, true, true);
			}
			RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
			rewardExploreConfirmButtonData.ButtonTextId = "ConfirmBox_133_ButtonText_0";
			rewardExploreConfirmButtonData.DescriptionTextId = null;
			rewardExploreConfirmButtonData.IsTimeDownCloseView = false;
			rewardExploreConfirmButtonData.IsClickedCloseView = true;
			rewardExploreConfirmButtonData.OnClickedCallback = delegate(int _)
			{
				ActivityMowingController.<OnHarvestActivityResultNotify>g__OnClickQuit|18_0();
			};
			RewardExploreConfirmButtonData item = rewardExploreConfirmButtonData;
			RewardExploreConfirmButtonData rewardExploreConfirmButtonData2 = new RewardExploreConfirmButtonData();
			rewardExploreConfirmButtonData2.ButtonTextId = "ConfirmBox_133_ButtonText_1";
			rewardExploreConfirmButtonData2.DescriptionTextId = "MowingHighestPoint";
			rewardExploreConfirmButtonData2.DescriptionArgs = new List<object>
			{
				harvestActivityResultNotify.HisPoint.ToString()
			};
			rewardExploreConfirmButtonData2.IsTimeDownCloseView = false;
			rewardExploreConfirmButtonData2.IsClickedCloseView = false;
			rewardExploreConfirmButtonData2.OnClickedCallback = delegate(int _)
			{
				ActivityMowingController.<OnHarvestActivityResultNotify>g__OnClickFight|18_1();
			};
			RewardExploreConfirmButtonData item2 = rewardExploreConfirmButtonData2;
			RewardExploreRecordData rewardExploreRecordData = new RewardExploreRecordData
			{
				TitleTextId = "MowingCurrentPoint",
				Record = harvestActivityResultNotify.CurPoint.ToString(),
				IsNewRecord = (harvestActivityResultNotify.CurPoint > harvestActivityResultNotify.HisPoint)
			};
			ItemRewardController instance = ItemRewardController.Instance;
			int configId = flag ? 3012 : 3013;
			bool isSuccess = !flag && harvestActivityResultNotify.Succ;
			List<RewardItemData> rewardItemDataList = null;
			IRewardExploreRecord exploreRecordInfo = flag ? null : rewardExploreRecordData;
			List<IRewardExploreBar> exploreBarDataList = null;
			List<IRewardExploreConfirmButton> buttonInfoList;
			if (!flag)
			{
				List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
				list.Add(item);
				buttonInfoList = list;
				list.Add(item2);
			}
			else
			{
				(buttonInfoList = new List<IRewardExploreConfirmButton>()).Add(item);
			}
			instance.OpenExploreRewardView(configId, isSuccess, rewardItemDataList, exploreRecordInfo, exploreBarDataList, buttonInfoList, null, null, null, null, null, null, null, null, null, null, null);
		}

		// Token: 0x0604027C RID: 262780 RVA: 0x00F88938 File Offset: 0x00F86B38
		public void RequestExitDungeon()
		{
			HarvestActivityResultRequest message = HarvestActivityResultRequest.Create();
			Net.Instance.Call(ERequestMessageId.HarvestActivityResultRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if ((HarvestActivityResultResponse)msg == null)
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).Forget<bool>();
				}
			}, 0);
		}

		// Token: 0x0604027D RID: 262781 RVA: 0x00F8897B File Offset: 0x00F86B7B
		[NullableContext(2)]
		public ActivityMowingData GetMowingActivityData()
		{
			return ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as ActivityMowingData;
		}

		// Token: 0x0604027E RID: 262782 RVA: 0x00F88994 File Offset: 0x00F86B94
		public override bool GetActivityLevelUnlockState(int levelId)
		{
			ActivityMowingData mowingActivityData = this.GetMowingActivityData();
			return mowingActivityData == null || mowingActivityData.GetActivityLevelUnlockState(levelId);
		}

		// Token: 0x0604027F RID: 262783 RVA: 0x00F889B4 File Offset: 0x00F86BB4
		public bool IsMowingInstanceDungeon(int instanceId)
		{
			if (instanceId == 0)
			{
				return false;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.GetValueOrDefault().InstSubType == 19;
		}

		// Token: 0x06040280 RID: 262784 RVA: 0x00F889F0 File Offset: 0x00F86BF0
		public int GetRecommendLevel(int instanceId, int worldLevel)
		{
			ActivityMowingData mowingActivityData = this.GetMowingActivityData();
			if (mowingActivityData == null)
			{
				return 0;
			}
			return mowingActivityData.GetLevelDiffRecommendLevel(instanceId);
		}

		// Token: 0x06040281 RID: 262785 RVA: 0x00F88A10 File Offset: 0x00F86C10
		public bool CheckIsActivityLevel(int instanceId)
		{
			return this.IsMowingInstanceDungeon(instanceId);
		}

		// Token: 0x1700936C RID: 37740
		// (get) Token: 0x06040282 RID: 262786 RVA: 0x00F88A19 File Offset: 0x00F86C19
		public static ActivityMowingController Instance
		{
			get
			{
				return ActivityMowingController._Instance;
			}
		}

		// Token: 0x06040283 RID: 262787 RVA: 0x00F88A20 File Offset: 0x00F86C20
		public static ActivityMowingController GetOrCreateInstance()
		{
			if (ActivityMowingController._Instance == null)
			{
				ActivityMowingController.CreateInstance();
			}
			return ActivityMowingController._Instance;
		}

		// Token: 0x06040284 RID: 262788 RVA: 0x00F88A34 File Offset: 0x00F86C34
		public static bool CreateInstance()
		{
			if (ActivityMowingController._Instance != null)
			{
				return true;
			}
			ActivityMowingController._Instance = new ActivityMowingController();
			return true;
		}

		// Token: 0x06040285 RID: 262789 RVA: 0x00F88A4A File Offset: 0x00F86C4A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040286 RID: 262790 RVA: 0x00F88A4C File Offset: 0x00F86C4C
		public static void ResetStaticDefaultValue()
		{
			ActivityMowingController._Instance = null;
		}

		// Token: 0x06040287 RID: 262791 RVA: 0x00F88A54 File Offset: 0x00F86C54
		static ActivityMowingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMowingController.CreateStaticDefaultValue), new Action(ActivityMowingController.ResetStaticDefaultValue));
		}

		// Token: 0x06040289 RID: 262793 RVA: 0x00F88A7B File Offset: 0x00F86C7B
		[CompilerGenerated]
		internal static void <OnHarvestActivityResultNotify>g__OnClickQuit|18_0()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x0604028A RID: 262794 RVA: 0x00F88A88 File Offset: 0x00F86C88
		[CompilerGenerated]
		internal static void <OnHarvestActivityResultNotify>g__OnClickFight|18_1()
		{
			InstanceDungeonController.Instance.SingleInstReChallengeRequest();
		}

		// Token: 0x040216BE RID: 136894
		public int CurrentActivityId;

		// Token: 0x040216BF RID: 136895
		[Nullable(2)]
		private static ActivityMowingController _Instance;
	}
}
