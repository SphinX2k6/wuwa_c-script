using System;
using System.Collections.Generic;
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
	// Token: 0x020054F8 RID: 21752
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityFishingController : ActivityControllerBase
	{
		// Token: 0x06035E7D RID: 220797 RVA: 0x00F0E82E File Offset: 0x00F0CA2E
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06035E7E RID: 220798 RVA: 0x00F0E834 File Offset: 0x00F0CA34
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

		// Token: 0x06035E7F RID: 220799 RVA: 0x00F0E8BD File Offset: 0x00F0CABD
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_FishingActivity";
		}

		// Token: 0x06035E80 RID: 220800 RVA: 0x00F0E8C4 File Offset: 0x00F0CAC4
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityFishingSubView();
		}

		// Token: 0x06035E81 RID: 220801 RVA: 0x00F0E8CB File Offset: 0x00F0CACB
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new ActivityFishingData();
		}

		// Token: 0x06035E82 RID: 220802 RVA: 0x00F0E8D2 File Offset: 0x00F0CAD2
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.FishingActivityUnlockView, null, null);
		}

		// Token: 0x06035E83 RID: 220803 RVA: 0x00F0E8E8 File Offset: 0x00F0CAE8
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

		// Token: 0x06035E84 RID: 220804 RVA: 0x00F0E94C File Offset: 0x00F0CB4C
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

		// Token: 0x06035E85 RID: 220805 RVA: 0x00F0E9B0 File Offset: 0x00F0CBB0
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

		// Token: 0x06035E86 RID: 220806 RVA: 0x00F0EA3E File Offset: 0x00F0CC3E
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FishingActivityLimitTaskNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingActivityMileStoneNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingActivityMilestoneItemNumNotify);
		}

		// Token: 0x06035E87 RID: 220807 RVA: 0x00F0EA70 File Offset: 0x00F0CC70
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

		// Token: 0x06035E88 RID: 220808 RVA: 0x00F0EAD0 File Offset: 0x00F0CCD0
		[NullableContext(2)]
		private static void OnFishingActivityLimitTaskNotify(IMessage msg, Net.CallbackStatus _)
		{
			FishingActivityLimitTaskNotify fishingActivityLimitTaskNotify = (FishingActivityLimitTaskNotify)msg;
			ActivityFishingData currentActivityData = ActivityFishingController.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.RefreshLimitTimeTaskDataList(fishingActivityLimitTaskNotify.ActivityTasks, true);
			currentActivityData.RefreshActivityRedDotState();
		}

		// Token: 0x06035E89 RID: 220809 RVA: 0x00F0EB04 File Offset: 0x00F0CD04
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

		// Token: 0x06035E8A RID: 220810 RVA: 0x00F0EB38 File Offset: 0x00F0CD38
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

		// Token: 0x06035E8B RID: 220811 RVA: 0x00F0EB62 File Offset: 0x00F0CD62
		private static void OnUnlockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
		{
			if (payShopMap.ContainsKey(209))
			{
				ActivityFishingController.OnRefreshRedDot();
			}
		}

		// Token: 0x06035E8C RID: 220812 RVA: 0x00F0EB78 File Offset: 0x00F0CD78
		private static void OnRefreshRedDot()
		{
			ActivityFishingData currentActivityData = ActivityFishingController.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.RefreshActivityRedDotState();
		}

		// Token: 0x06035E8D RID: 220813 RVA: 0x00F0EB98 File Offset: 0x00F0CD98
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingActivityLimitRewardResponse.ErrorCode, 23099, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06035E8E RID: 220814 RVA: 0x00F0EBE4 File Offset: 0x00F0CDE4
		public static void FishingActivityMilestoneRewardRequest(IEnumerable<int> ids)
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingActivityMilestoneRewardResponse.ErrorCode, 21498, null, true, true);
				}
			}, 0);
		}

		// Token: 0x170068AE RID: 26798
		// (get) Token: 0x06035E8F RID: 220815 RVA: 0x00F0EC49 File Offset: 0x00F0CE49
		public static ActivityFishingController Instance
		{
			get
			{
				return ActivityFishingController._Instance;
			}
		}

		// Token: 0x06035E90 RID: 220816 RVA: 0x00F0EC50 File Offset: 0x00F0CE50
		public static ActivityFishingController GetOrCreateInstance()
		{
			if (ActivityFishingController._Instance == null)
			{
				ActivityFishingController.CreateInstance();
			}
			return ActivityFishingController._Instance;
		}

		// Token: 0x06035E91 RID: 220817 RVA: 0x00F0EC64 File Offset: 0x00F0CE64
		public static bool CreateInstance()
		{
			if (ActivityFishingController._Instance != null)
			{
				return true;
			}
			ActivityFishingController._Instance = new ActivityFishingController();
			return true;
		}

		// Token: 0x06035E92 RID: 220818 RVA: 0x00F0EC7A File Offset: 0x00F0CE7A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035E93 RID: 220819 RVA: 0x00F0EC7C File Offset: 0x00F0CE7C
		public static void ResetStaticDefaultValue()
		{
			ActivityFishingController._Instance = null;
		}

		// Token: 0x06035E94 RID: 220820 RVA: 0x00F0EC84 File Offset: 0x00F0CE84
		static ActivityFishingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFishingController.CreateStaticDefaultValue), new Action(ActivityFishingController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C7F1 RID: 116721
		[Nullable(2)]
		private static ActivityFishingController _Instance;

		// Token: 0x0200B158 RID: 45400
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04036D7D RID: 224637
			[Nullable(0)]
			public static Action <0>__OnRefreshRedDot;

			// Token: 0x04036D7E RID: 224638
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<IReadOnlyDictionary<int, HashSet<int>>> <1>__OnUnlockGoods;

			// Token: 0x04036D7F RID: 224639
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <2>__OnFishingActivityLimitTaskNotify;

			// Token: 0x04036D80 RID: 224640
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <3>__OnFishingActivityMileStoneNotify;

			// Token: 0x04036D81 RID: 224641
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
