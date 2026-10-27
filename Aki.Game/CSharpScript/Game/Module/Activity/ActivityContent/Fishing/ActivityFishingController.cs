using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200657A RID: 25978
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityFishingController : ActivityControllerBase
	{
		// Token: 0x060411B8 RID: 266680 RVA: 0x00FC784A File Offset: 0x00FC5A4A
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060411B9 RID: 266681 RVA: 0x00FC7850 File Offset: 0x00FC5A50
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("CantUseInMultiplayerMode", Array.Empty<object>());
				return;
			}
			if (!data.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = data.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			int num = FishingModel.Instance.GetShipData().GetLastPortId();
			if (num <= 0)
			{
				num = 1;
			}
			FishingPort fishingPortConfig = FishingConfig.Instance.GetFishingPortConfig(num);
			WorldMapController.Instance.FocalMarkItem(EMarkType.FishingDock, fishingPortConfig.MarkId);
		}

		// Token: 0x060411BA RID: 266682 RVA: 0x00FC78D9 File Offset: 0x00FC5AD9
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_FishingActivity";
		}

		// Token: 0x060411BB RID: 266683 RVA: 0x00FC78E0 File Offset: 0x00FC5AE0
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityFishingSubView();
		}

		// Token: 0x060411BC RID: 266684 RVA: 0x00FC78E7 File Offset: 0x00FC5AE7
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new ActivityFishingData();
		}

		// Token: 0x060411BD RID: 266685 RVA: 0x00FC78EE File Offset: 0x00FC5AEE
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.FishingActivityUnlockView, null, null);
		}

		// Token: 0x060411BE RID: 266686 RVA: 0x00FC7904 File Offset: 0x00FC5B04
		protected override void OnAddEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.FishingRefreshHandBookRewardView;
			Action handle;
			if ((handle = ActivityFishingController.<>O.<0>__OnRefreshRedDot) == null)
			{
				handle = (ActivityFishingController.<>O.<0>__OnRefreshRedDot = new Action(ActivityFishingController.OnRefreshRedDot));
			}
			instance.Add(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.UnLockGoods;
			Action<IReadOnlyDictionary<int, HashSet<int>>> handle2;
			if ((handle2 = ActivityFishingController.<>O.<1>__OnUnlockGoods) == null)
			{
				handle2 = (ActivityFishingController.<>O.<1>__OnUnlockGoods = new Action<IReadOnlyDictionary<int, HashSet<int>>>(ActivityFishingController.OnUnlockGoods));
			}
			instance2.Add<IReadOnlyDictionary<int, HashSet<int>>>(name2, handle2);
		}

		// Token: 0x060411BF RID: 266687 RVA: 0x00FC7968 File Offset: 0x00FC5B68
		protected override void OnRemoveEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.FishingRefreshHandBookRewardView;
			Action handle;
			if ((handle = ActivityFishingController.<>O.<0>__OnRefreshRedDot) == null)
			{
				handle = (ActivityFishingController.<>O.<0>__OnRefreshRedDot = new Action(ActivityFishingController.OnRefreshRedDot));
			}
			instance.Remove(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.UnLockGoods;
			Action<IReadOnlyDictionary<int, HashSet<int>>> handle2;
			if ((handle2 = ActivityFishingController.<>O.<1>__OnUnlockGoods) == null)
			{
				handle2 = (ActivityFishingController.<>O.<1>__OnUnlockGoods = new Action<IReadOnlyDictionary<int, HashSet<int>>>(ActivityFishingController.OnUnlockGoods));
			}
			instance2.Remove(name2, handle2);
		}

		// Token: 0x060411C0 RID: 266688 RVA: 0x00FC79CC File Offset: 0x00FC5BCC
		protected override void OnRegisterNetEvent()
		{
			Net instance = Net.Instance;
			ENotifyMessageId id = ENotifyMessageId.FishingActivityLimitTaskNotify;
			Action<IMessage, Net.CallbackStatus> callback;
			if ((callback = ActivityFishingController.<>O.<2>__OnFishingActivityLimitTaskNotify) == null)
			{
				callback = (ActivityFishingController.<>O.<2>__OnFishingActivityLimitTaskNotify = new Action<IMessage, Net.CallbackStatus>(ActivityFishingController.OnFishingActivityLimitTaskNotify));
			}
			instance.Register(id, callback);
			Net instance2 = Net.Instance;
			ENotifyMessageId id2 = ENotifyMessageId.FishingActivityMileStoneNotify;
			Action<IMessage, Net.CallbackStatus> callback2;
			if ((callback2 = ActivityFishingController.<>O.<3>__OnFishingActivityMileStoneNotify) == null)
			{
				callback2 = (ActivityFishingController.<>O.<3>__OnFishingActivityMileStoneNotify = new Action<IMessage, Net.CallbackStatus>(ActivityFishingController.OnFishingActivityMileStoneNotify));
			}
			instance2.Register(id2, callback2);
			Net instance3 = Net.Instance;
			ENotifyMessageId id3 = ENotifyMessageId.FishingActivityMilestoneItemNumNotify;
			Action<IMessage, Net.CallbackStatus> callback3;
			if ((callback3 = ActivityFishingController.<>O.<4>__OnFishingActivityMilestoneItemNumNotify) == null)
			{
				callback3 = (ActivityFishingController.<>O.<4>__OnFishingActivityMilestoneItemNumNotify = new Action<IMessage, Net.CallbackStatus>(ActivityFishingController.OnFishingActivityMilestoneItemNumNotify));
			}
			instance3.Register(id3, callback3);
		}

		// Token: 0x060411C1 RID: 266689 RVA: 0x00FC7A5A File Offset: 0x00FC5C5A
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FishingActivityLimitTaskNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingActivityMileStoneNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingActivityMilestoneItemNumNotify);
		}

		// Token: 0x060411C2 RID: 266690 RVA: 0x00FC7A8C File Offset: 0x00FC5C8C
		public static ActivityFishingData GetCurrentActivityData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.FishingActivity);
			ActivityFishingData result = null;
			if (currentActivitiesByType != null)
			{
				foreach (ActivityBaseData activityBaseData in currentActivitiesByType)
				{
					result = (activityBaseData as ActivityFishingData);
				}
			}
			return result;
		}

		// Token: 0x060411C3 RID: 266691 RVA: 0x00FC7AEC File Offset: 0x00FC5CEC
		[NullableContext(2)]
		private static void OnFishingActivityLimitTaskNotify(IMessage msg, Net.CallbackStatus _)
		{
			FishingActivityLimitTaskNotify fishingActivityLimitTaskNotify = (FishingActivityLimitTaskNotify)msg;
			ActivityFishingData currentActivityData = ActivityFishingController.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.RefreshLimitTimeTaskDataList(fishingActivityLimitTaskNotify.ActivityTasks.ToList<ActivityTask>(), true);
			currentActivityData.RefreshActivityRedDotState();
		}

		// Token: 0x060411C4 RID: 266692 RVA: 0x00FC7B24 File Offset: 0x00FC5D24
		[NullableContext(2)]
		private static void OnFishingActivityMileStoneNotify(IMessage msg, Net.CallbackStatus _)
		{
			FishingActivityMileStoneNotify fishingActivityMileStoneNotify = (FishingActivityMileStoneNotify)msg;
			ActivityFishingData currentActivityData = ActivityFishingController.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.RefreshMilestoneReward(fishingActivityMileStoneNotify.MilestoneRewarded, true);
			currentActivityData.RefreshActivityRedDotState();
		}

		// Token: 0x060411C5 RID: 266693 RVA: 0x00FC7B58 File Offset: 0x00FC5D58
		[NullableContext(2)]
		private static void OnFishingActivityMilestoneItemNumNotify(IMessage msg, Net.CallbackStatus _)
		{
			FishingActivityMilestoneItemNumNotify fishingActivityMilestoneItemNumNotify = (FishingActivityMilestoneItemNumNotify)msg;
			ActivityFishingData currentActivityData = ActivityFishingController.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.MilestoneRewardItemAccumulate = fishingActivityMilestoneItemNumNotify.MilestoneItemNum;
		}

		// Token: 0x060411C6 RID: 266694 RVA: 0x00FC7B82 File Offset: 0x00FC5D82
		private static void OnUnlockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
		{
			if (payShopMap.ContainsKey(209))
			{
				ActivityFishingController.OnRefreshRedDot();
			}
		}

		// Token: 0x060411C7 RID: 266695 RVA: 0x00FC7B98 File Offset: 0x00FC5D98
		private static void OnRefreshRedDot()
		{
			ActivityFishingData currentActivityData = ActivityFishingController.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.RefreshActivityRedDotState();
		}

		// Token: 0x060411C8 RID: 266696 RVA: 0x00FC7BB8 File Offset: 0x00FC5DB8
		public static void FishingActivityLimitRewardRequest(int taskId)
		{
			FishingActivityLimitRewardRequest fishingActivityLimitRewardRequest = Aki.Protocol.FishingActivityLimitRewardRequest.Create();
			fishingActivityLimitRewardRequest.TaskId = taskId;
			Net.Instance.Call(ERequestMessageId.FishingActivityLimitRewardRequest, fishingActivityLimitRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingActivityLimitRewardResponse fishingActivityLimitRewardResponse = (FishingActivityLimitRewardResponse)msg;
				if (fishingActivityLimitRewardResponse == null)
				{
					return;
				}
				if (fishingActivityLimitRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingActivityLimitRewardResponse.ErrorCode, 18435, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060411C9 RID: 266697 RVA: 0x00FC7C04 File Offset: 0x00FC5E04
		public static void FishingActivityMilestoneRewardRequest(List<int> ids)
		{
			FishingActivityMilestoneRewardRequest fishingActivityMilestoneRewardRequest = Aki.Protocol.FishingActivityMilestoneRewardRequest.Create();
			ActivityFishingData currentActivityData = ActivityFishingController.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			fishingActivityMilestoneRewardRequest.ActivityId = currentActivityData.Id;
			fishingActivityMilestoneRewardRequest.MilestoneId.AddRange(ids);
			Net.Instance.Call(ERequestMessageId.FishingActivityMilestoneRewardRequest, fishingActivityMilestoneRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingActivityMilestoneRewardResponse fishingActivityMilestoneRewardResponse = (FishingActivityMilestoneRewardResponse)msg;
				if (fishingActivityMilestoneRewardResponse == null)
				{
					return;
				}
				if (fishingActivityMilestoneRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingActivityMilestoneRewardResponse.ErrorCode, 27837, null, true, true);
				}
			}, 0);
		}

		// Token: 0x1700954C RID: 38220
		// (get) Token: 0x060411CA RID: 266698 RVA: 0x00FC7C69 File Offset: 0x00FC5E69
		public static ActivityFishingController Instance
		{
			get
			{
				return ActivityFishingController._Instance;
			}
		}

		// Token: 0x060411CB RID: 266699 RVA: 0x00FC7C70 File Offset: 0x00FC5E70
		public static ActivityFishingController GetOrCreateInstance()
		{
			if (ActivityFishingController._Instance == null)
			{
				ActivityFishingController.CreateInstance();
			}
			return ActivityFishingController._Instance;
		}

		// Token: 0x060411CC RID: 266700 RVA: 0x00FC7C84 File Offset: 0x00FC5E84
		public static bool CreateInstance()
		{
			if (ActivityFishingController._Instance != null)
			{
				return true;
			}
			ActivityFishingController._Instance = new ActivityFishingController();
			return true;
		}

		// Token: 0x060411CD RID: 266701 RVA: 0x00FC7C9A File Offset: 0x00FC5E9A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060411CE RID: 266702 RVA: 0x00FC7C9C File Offset: 0x00FC5E9C
		public static void ResetStaticDefaultValue()
		{
			ActivityFishingController._Instance = null;
		}

		// Token: 0x060411CF RID: 266703 RVA: 0x00FC7CA4 File Offset: 0x00FC5EA4
		static ActivityFishingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFishingController.CreateStaticDefaultValue), new Action(ActivityFishingController.ResetStaticDefaultValue));
		}

		// Token: 0x04021EC0 RID: 138944
		[Nullable(2)]
		private static ActivityFishingController _Instance;

		// Token: 0x0200C773 RID: 51059
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403C42B RID: 246827
			[Nullable(0)]
			public static Action <0>__OnRefreshRedDot;

			// Token: 0x0403C42C RID: 246828
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<IReadOnlyDictionary<int, HashSet<int>>> <1>__OnUnlockGoods;

			// Token: 0x0403C42D RID: 246829
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <2>__OnFishingActivityLimitTaskNotify;

			// Token: 0x0403C42E RID: 246830
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <3>__OnFishingActivityMileStoneNotify;

			// Token: 0x0403C42F RID: 246831
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <4>__OnFishingActivityMilestoneItemNumNotify;
		}
	}
}
