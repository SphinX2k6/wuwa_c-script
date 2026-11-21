using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200513C RID: 20796
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityRoadBookController : ActivityControllerBase
	{
		// Token: 0x0603400D RID: 213005 RVA: 0x00E8C9EE File Offset: 0x00E8ABEE
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603400E RID: 213006 RVA: 0x00E8C9F0 File Offset: 0x00E8ABF0
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RoadBookInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoadBookInfoUpdateNotify));
		}

		// Token: 0x0603400F RID: 213007 RVA: 0x00E8CA0E File Offset: 0x00E8AC0E
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RoadBookInfoUpdateNotify);
		}

		// Token: 0x06034010 RID: 213008 RVA: 0x00E8CA20 File Offset: 0x00E8AC20
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06034011 RID: 213009 RVA: 0x00E8CA3E File Offset: 0x00E8AC3E
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06034012 RID: 213010 RVA: 0x00E8CA5C File Offset: 0x00E8AC5C
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_MapThemeHall30";
		}

		// Token: 0x06034013 RID: 213011 RVA: 0x00E8CA64 File Offset: 0x00E8AC64
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			ActivityRoadBookData roadBookData = this.GetRoadBookData();
			if (roadBookData == null)
			{
				return;
			}
			if (roadBookData.GetActivityConfig().ExpItemId != configId)
			{
				return;
			}
			if (roadBookData.CanTravelLevelUp())
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, roadBookData.Id);
			}
			this.TryOpenLevelTipsView(roadBookData);
		}

		// Token: 0x06034014 RID: 213012 RVA: 0x00E8CAB3 File Offset: 0x00E8ACB3
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewRoadBook();
		}

		// Token: 0x06034015 RID: 213013 RVA: 0x00E8CABA File Offset: 0x00E8ACBA
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new ActivityRoadBookData();
		}

		// Token: 0x06034016 RID: 213014 RVA: 0x00E8CAC1 File Offset: 0x00E8ACC1
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06034017 RID: 213015 RVA: 0x00E8CAC4 File Offset: 0x00E8ACC4
		[NullableContext(2)]
		public ActivityRoadBookData GetRoadBookData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.RoadBookActivity);
			ActivityRoadBookData result = null;
			if (currentActivitiesByType != null && currentActivitiesByType.Count > 0)
			{
				result = (currentActivitiesByType[0] as ActivityRoadBookData);
			}
			return result;
		}

		// Token: 0x06034018 RID: 213016 RVA: 0x00E8CAFC File Offset: 0x00E8ACFC
		[NullableContext(2)]
		private void OnRoadBookInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoadBookInfoUpdateNotify roadBookInfoUpdateNotify = (RoadBookInfoUpdateNotify)msg;
			ActivityRoadBookData roadBookData = this.GetRoadBookData();
			if (roadBookData == null)
			{
				return;
			}
			if (roadBookInfoUpdateNotify.ActivityTask != null)
			{
				roadBookData.RefreshTravelTaskData(roadBookInfoUpdateNotify.ActivityTask);
			}
			if (roadBookInfoUpdateNotify.MotorcycleLevel != null)
			{
				roadBookData.RefreshMotorChallengePlayData(roadBookInfoUpdateNotify.MotorcycleLevel);
			}
			if (roadBookInfoUpdateNotify.HasUnLockArea)
			{
				roadBookData.UnlockAreaData(roadBookInfoUpdateNotify.UnLockArea);
			}
			if (roadBookInfoUpdateNotify.HasUnLockMonsterId)
			{
				roadBookData.UnlockPhantom(roadBookInfoUpdateNotify.UnLockMonsterId);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, roadBookData.Id);
		}

		// Token: 0x06034019 RID: 213017 RVA: 0x00E8CB84 File Offset: 0x00E8AD84
		[NullableContext(2)]
		public void RequestRoadBookLevelUp(Action<bool> callback = null)
		{
			RoadBookLevelUpRequest message = RoadBookLevelUpRequest.Create();
			Net.Instance.Call(ERequestMessageId.RoadBookLevelUpRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoadBookLevelUpResponse roadBookLevelUpResponse = (RoadBookLevelUpResponse)msg;
				if (roadBookLevelUpResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else if (roadBookLevelUpResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roadBookLevelUpResponse.ErrorCode, 19714, null, true, true);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(false);
					return;
				}
				else
				{
					ActivityRoadBookData roadBookData = this.GetRoadBookData();
					if (roadBookData != null)
					{
						roadBookData.TravelLevel++;
						Action<bool> callback4 = callback;
						if (callback4 != null)
						{
							callback4(true);
						}
						roadBookData.RefreshActivityRedDotState();
						this.TryOpenLevelTipsView(roadBookData);
						return;
					}
					Action<bool> callback5 = callback;
					if (callback5 == null)
					{
						return;
					}
					callback5(false);
					return;
				}
			}, 0);
		}

		// Token: 0x0603401A RID: 213018 RVA: 0x00E8CBC8 File Offset: 0x00E8ADC8
		public void RequestMultiRoadBookTaskReward(int[] ids)
		{
			if (ids == null || ids.Length == 0)
			{
				return;
			}
			RoadBookTaskRewardRequest roadBookTaskRewardRequest = RoadBookTaskRewardRequest.Create();
			roadBookTaskRewardRequest.TaskIds.AddRange(ids);
			Net.Instance.Call(ERequestMessageId.RoadBookTaskRewardRequest, roadBookTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoadBookTaskRewardResponse roadBookTaskRewardResponse = (RoadBookTaskRewardResponse)msg;
				if (roadBookTaskRewardResponse == null)
				{
					return;
				}
				if (roadBookTaskRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roadBookTaskRewardResponse.ErrorCode, 24523, null, true, true);
					return;
				}
				ActivityRoadBookData roadBookData = this.GetRoadBookData();
				if (roadBookData == null)
				{
					return;
				}
				foreach (int travelTaskDataDone in ids)
				{
					roadBookData.SetTravelTaskDataDone(travelTaskDataDone);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, roadBookData.Id);
				EventSystem.Instance.Emit(EEventName.RoadBookTaskRefresh);
			}, 0);
		}

		// Token: 0x0603401B RID: 213019 RVA: 0x00E8CC30 File Offset: 0x00E8AE30
		public void RequestTakeTaskFinalReward()
		{
			RoadBookFullRewardRequest message = RoadBookFullRewardRequest.Create();
			Net.Instance.Call(ERequestMessageId.RoadBookFullRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoadBookFullRewardResponse roadBookFullRewardResponse = (RoadBookFullRewardResponse)msg;
				if (roadBookFullRewardResponse == null)
				{
					return;
				}
				if (roadBookFullRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roadBookFullRewardResponse.ErrorCode, 26687, null, true, true);
					return;
				}
				ActivityRoadBookData roadBookData = this.GetRoadBookData();
				if (roadBookData == null)
				{
					return;
				}
				roadBookData.TaskFinalRewardData.IsReceived = true;
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, roadBookData.Id);
				EventSystem.Instance.Emit(EEventName.RoadBookTaskRefresh);
			}, 0);
		}

		// Token: 0x0603401C RID: 213020 RVA: 0x00E8CC60 File Offset: 0x00E8AE60
		public void RequestMultiTakeMotorChallengeReward(int[] rewardIds)
		{
			if (rewardIds == null || rewardIds.Length == 0)
			{
				return;
			}
			RoadBookMotorRewardRequest roadBookMotorRewardRequest = RoadBookMotorRewardRequest.Create();
			roadBookMotorRewardRequest.TaskIds.AddRange(rewardIds);
			Net.Instance.Call(ERequestMessageId.RoadBookMotorRewardRequest, roadBookMotorRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoadBookMotorRewardResponse roadBookMotorRewardResponse = (RoadBookMotorRewardResponse)msg;
				if (roadBookMotorRewardResponse == null)
				{
					return;
				}
				if (roadBookMotorRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roadBookMotorRewardResponse.ErrorCode, 23361, null, true, true);
					return;
				}
				ActivityRoadBookData roadBookData = this.GetRoadBookData();
				if (roadBookData == null)
				{
					return;
				}
				foreach (int motorChallengeRewardDone in rewardIds)
				{
					roadBookData.SetMotorChallengeRewardDone(motorChallengeRewardDone);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, roadBookData.Id);
				EventSystem.Instance.Emit(EEventName.RoadBookMotorRefresh);
			}, 0);
		}

		// Token: 0x0603401D RID: 213021 RVA: 0x00E8CCC7 File Offset: 0x00E8AEC7
		private void TryOpenLevelTipsView(ActivityRoadBookData data)
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.RoadBookLevelTipsView))
			{
				UiManager.Instance.OpenView(EUiViewName.RoadBookLevelTipsView, data, null);
			}
		}

		// Token: 0x0603401E RID: 213022 RVA: 0x00E8CCEB File Offset: 0x00E8AEEB
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipRoadBookView, null, null);
		}

		// Token: 0x1700657B RID: 25979
		// (get) Token: 0x0603401F RID: 213023 RVA: 0x00E8CCFE File Offset: 0x00E8AEFE
		public static ActivityRoadBookController Instance
		{
			get
			{
				return ActivityRoadBookController._Instance;
			}
		}

		// Token: 0x06034020 RID: 213024 RVA: 0x00E8CD05 File Offset: 0x00E8AF05
		public static ActivityRoadBookController GetOrCreateInstance()
		{
			if (ActivityRoadBookController._Instance == null)
			{
				ActivityRoadBookController.CreateInstance();
			}
			return ActivityRoadBookController._Instance;
		}

		// Token: 0x06034021 RID: 213025 RVA: 0x00E8CD19 File Offset: 0x00E8AF19
		public static bool CreateInstance()
		{
			if (ActivityRoadBookController._Instance != null)
			{
				return true;
			}
			ActivityRoadBookController._Instance = new ActivityRoadBookController();
			return true;
		}

		// Token: 0x06034022 RID: 213026 RVA: 0x00E8CD2F File Offset: 0x00E8AF2F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034023 RID: 213027 RVA: 0x00E8CD31 File Offset: 0x00E8AF31
		public static void ResetStaticDefaultValue()
		{
			ActivityRoadBookController._Instance = null;
		}

		// Token: 0x06034024 RID: 213028 RVA: 0x00E8CD39 File Offset: 0x00E8AF39
		static ActivityRoadBookController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoadBookController.CreateStaticDefaultValue), new Action(ActivityRoadBookController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B83A RID: 112698
		[Nullable(2)]
		private static ActivityRoadBookController _Instance;
	}
}
