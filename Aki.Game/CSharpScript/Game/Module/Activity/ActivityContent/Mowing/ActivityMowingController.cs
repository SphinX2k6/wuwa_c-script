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
	// Token: 0x02005320 RID: 21280
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMowingController : ActivityControllerBase
	{
		// Token: 0x06034F2B RID: 216875 RVA: 0x00ECF348 File Offset: 0x00ECD548
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.HarvestActivityPointNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHarvestActivityPointNotify));
			Net.Instance.Register(ENotifyMessageId.HarvestActivityLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHarvestActivityLevelNotify));
			Net.Instance.Register(ENotifyMessageId.HarvestActivityResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHarvestActivityResultNotify));
		}

		// Token: 0x06034F2C RID: 216876 RVA: 0x00ECF3A9 File Offset: 0x00ECD5A9
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.HarvestActivityPointNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HarvestActivityLevelNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HarvestActivityResultNotify);
		}

		// Token: 0x06034F2D RID: 216877 RVA: 0x00ECF3DB File Offset: 0x00ECD5DB
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
		}

		// Token: 0x06034F2E RID: 216878 RVA: 0x00ECF415 File Offset: 0x00ECD615
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
		}

		// Token: 0x06034F2F RID: 216879 RVA: 0x00ECF44F File Offset: 0x00ECD64F
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMowing";
		}

		// Token: 0x06034F30 RID: 216880 RVA: 0x00ECF458 File Offset: 0x00ECD658
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

		// Token: 0x06034F31 RID: 216881 RVA: 0x00ECF4BC File Offset: 0x00ECD6BC
		private void OnLeaveInstanceDungeonConfirm()
		{
			if (InstanceDungeonEntranceModel.Instance.IsMowingInstanceDungeon())
			{
				this.RequestExitDungeon();
			}
		}

		// Token: 0x06034F32 RID: 216882 RVA: 0x00ECF4D0 File Offset: 0x00ECD6D0
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06034F33 RID: 216883 RVA: 0x00ECF4D2 File Offset: 0x00ECD6D2
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityMowingSubView();
		}

		// Token: 0x06034F34 RID: 216884 RVA: 0x00ECF4D9 File Offset: 0x00ECD6D9
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.CurrentActivityId = data.Id;
			return new ActivityMowingData();
		}

		// Token: 0x06034F35 RID: 216885 RVA: 0x00ECF4EC File Offset: 0x00ECD6EC
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06034F36 RID: 216886 RVA: 0x00ECF4F0 File Offset: 0x00ECD6F0
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(harvestActivityPointResponse.ErrorCode, 26658, null, true, true);
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

		// Token: 0x06034F37 RID: 216887 RVA: 0x00ECF54C File Offset: 0x00ECD74C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(harvestActivityLevelResponse.ErrorCode, 23959, null, true, true);
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

		// Token: 0x06034F38 RID: 216888 RVA: 0x00ECF5A8 File Offset: 0x00ECD7A8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(harvestActivityLevelDiffResponse.ErrorCode, 28299, null, true, true);
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

		// Token: 0x06034F39 RID: 216889 RVA: 0x00ECF604 File Offset: 0x00ECD804
		public void RequestSetDifficultyAll(int activityId, int diff)
		{
			if (this.GetMowingActivityData() == null)
			{
				return;
			}
			this.RequestSetDifficulty(activityId, diff);
		}

		// Token: 0x06034F3A RID: 216890 RVA: 0x00ECF618 File Offset: 0x00ECD818
		[NullableContext(2)]
		private void OnHarvestActivityPointNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			HarvestActivityPointNotify harvestActivityPointNotify = (HarvestActivityPointNotify)msg;
			(ActivityModel.Instance.GetActivityById(harvestActivityPointNotify.ActivityId) as ActivityMowingData).UpdatePointRewards(harvestActivityPointNotify);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, harvestActivityPointNotify.ActivityId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, harvestActivityPointNotify.ActivityId);
		}

		// Token: 0x06034F3B RID: 216891 RVA: 0x00ECF674 File Offset: 0x00ECD874
		[NullableContext(2)]
		private void OnHarvestActivityLevelNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			HarvestActivityLevelNotify harvestActivityLevelNotify = (HarvestActivityLevelNotify)msg;
			(ActivityModel.Instance.GetActivityById(harvestActivityLevelNotify.ActivityId) as ActivityMowingData).UpdateLevelRewards(harvestActivityLevelNotify);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, harvestActivityLevelNotify.ActivityId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, harvestActivityLevelNotify.ActivityId);
		}

		// Token: 0x06034F3C RID: 216892 RVA: 0x00ECF6D0 File Offset: 0x00ECD8D0
		[NullableContext(2)]
		private void OnHarvestActivityResultNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			HarvestActivityResultNotify harvestActivityResultNotify = (HarvestActivityResultNotify)msg;
			bool flag = harvestActivityResultNotify.ErrorCode > Aki.Protocol.ErrorCode.Success;
			if (flag)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(harvestActivityResultNotify.ErrorCode, 22031, null, true, true);
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

		// Token: 0x06034F3D RID: 216893 RVA: 0x00ECF870 File Offset: 0x00ECDA70
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

		// Token: 0x06034F3E RID: 216894 RVA: 0x00ECF8B3 File Offset: 0x00ECDAB3
		[NullableContext(2)]
		public ActivityMowingData GetMowingActivityData()
		{
			return ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as ActivityMowingData;
		}

		// Token: 0x06034F3F RID: 216895 RVA: 0x00ECF8CC File Offset: 0x00ECDACC
		public override bool GetActivityLevelUnlockState(int levelId)
		{
			ActivityMowingData mowingActivityData = this.GetMowingActivityData();
			return mowingActivityData == null || mowingActivityData.GetActivityLevelUnlockState(levelId);
		}

		// Token: 0x06034F40 RID: 216896 RVA: 0x00ECF8EC File Offset: 0x00ECDAEC
		public bool IsMowingInstanceDungeon(int instanceId)
		{
			if (instanceId == 0)
			{
				return false;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.GetValueOrDefault().InstSubType == 19;
		}

		// Token: 0x06034F41 RID: 216897 RVA: 0x00ECF928 File Offset: 0x00ECDB28
		public int GetRecommendLevel(int instanceId, int worldLevel)
		{
			ActivityMowingData mowingActivityData = this.GetMowingActivityData();
			if (mowingActivityData == null)
			{
				return 0;
			}
			return mowingActivityData.GetLevelDiffRecommendLevel(instanceId);
		}

		// Token: 0x06034F42 RID: 216898 RVA: 0x00ECF948 File Offset: 0x00ECDB48
		public bool CheckIsActivityLevel(int instanceId)
		{
			return this.IsMowingInstanceDungeon(instanceId);
		}

		// Token: 0x170066CE RID: 26318
		// (get) Token: 0x06034F43 RID: 216899 RVA: 0x00ECF951 File Offset: 0x00ECDB51
		public static ActivityMowingController Instance
		{
			get
			{
				return ActivityMowingController._Instance;
			}
		}

		// Token: 0x06034F44 RID: 216900 RVA: 0x00ECF958 File Offset: 0x00ECDB58
		public static ActivityMowingController GetOrCreateInstance()
		{
			if (ActivityMowingController._Instance == null)
			{
				ActivityMowingController.CreateInstance();
			}
			return ActivityMowingController._Instance;
		}

		// Token: 0x06034F45 RID: 216901 RVA: 0x00ECF96C File Offset: 0x00ECDB6C
		public static bool CreateInstance()
		{
			if (ActivityMowingController._Instance != null)
			{
				return true;
			}
			ActivityMowingController._Instance = new ActivityMowingController();
			return true;
		}

		// Token: 0x06034F46 RID: 216902 RVA: 0x00ECF982 File Offset: 0x00ECDB82
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034F47 RID: 216903 RVA: 0x00ECF984 File Offset: 0x00ECDB84
		public static void ResetStaticDefaultValue()
		{
			ActivityMowingController._Instance = null;
		}

		// Token: 0x06034F48 RID: 216904 RVA: 0x00ECF98C File Offset: 0x00ECDB8C
		static ActivityMowingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMowingController.CreateStaticDefaultValue), new Action(ActivityMowingController.ResetStaticDefaultValue));
		}

		// Token: 0x06034F4A RID: 216906 RVA: 0x00ECF9B3 File Offset: 0x00ECDBB3
		[CompilerGenerated]
		internal static void <OnHarvestActivityResultNotify>g__OnClickQuit|18_0()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x06034F4B RID: 216907 RVA: 0x00ECF9C0 File Offset: 0x00ECDBC0
		[CompilerGenerated]
		internal static void <OnHarvestActivityResultNotify>g__OnClickFight|18_1()
		{
			InstanceDungeonController.Instance.SingleInstReChallengeRequest(false);
		}

		// Token: 0x0401BFED RID: 114669
		public int CurrentActivityId;

		// Token: 0x0401BFEE RID: 114670
		[Nullable(2)]
		private static ActivityMowingController _Instance;
	}
}
