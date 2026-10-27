using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061BE RID: 25022
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityRoadBookController : ActivityControllerBase
	{
		// Token: 0x0603F34C RID: 258892 RVA: 0x00F45A96 File Offset: 0x00F43C96
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603F34D RID: 258893 RVA: 0x00F45A98 File Offset: 0x00F43C98
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RoadBookInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoadBookInfoUpdateNotify));
		}

		// Token: 0x0603F34E RID: 258894 RVA: 0x00F45AB6 File Offset: 0x00F43CB6
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RoadBookInfoUpdateNotify);
		}

		// Token: 0x0603F34F RID: 258895 RVA: 0x00F45AC8 File Offset: 0x00F43CC8
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x0603F350 RID: 258896 RVA: 0x00F45AE6 File Offset: 0x00F43CE6
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x0603F351 RID: 258897 RVA: 0x00F45B04 File Offset: 0x00F43D04
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_MapThemeHall30";
		}

		// Token: 0x0603F352 RID: 258898 RVA: 0x00F45B0C File Offset: 0x00F43D0C
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

		// Token: 0x0603F353 RID: 258899 RVA: 0x00F45B5B File Offset: 0x00F43D5B
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewRoadBook();
		}

		// Token: 0x0603F354 RID: 258900 RVA: 0x00F45B62 File Offset: 0x00F43D62
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new ActivityRoadBookData();
		}

		// Token: 0x0603F355 RID: 258901 RVA: 0x00F45B69 File Offset: 0x00F43D69
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603F356 RID: 258902 RVA: 0x00F45B6C File Offset: 0x00F43D6C
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

		// Token: 0x0603F357 RID: 258903 RVA: 0x00F45BA4 File Offset: 0x00F43DA4
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

		// Token: 0x0603F358 RID: 258904 RVA: 0x00F45C2C File Offset: 0x00F43E2C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roadBookLevelUpResponse.ErrorCode, 16518, null, true, true);
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

		// Token: 0x0603F359 RID: 258905 RVA: 0x00F45C70 File Offset: 0x00F43E70
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roadBookTaskRewardResponse.ErrorCode, 27039, null, true, true);
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

		// Token: 0x0603F35A RID: 258906 RVA: 0x00F45CD8 File Offset: 0x00F43ED8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roadBookFullRewardResponse.ErrorCode, 25470, null, true, true);
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

		// Token: 0x0603F35B RID: 258907 RVA: 0x00F45D08 File Offset: 0x00F43F08
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roadBookMotorRewardResponse.ErrorCode, 15914, null, true, true);
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

		// Token: 0x0603F35C RID: 258908 RVA: 0x00F45D6F File Offset: 0x00F43F6F
		private void TryOpenLevelTipsView(ActivityRoadBookData data)
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.RoadBookLevelTipsView))
			{
				UiManager.Instance.OpenView(EUiViewName.RoadBookLevelTipsView, data, null);
			}
		}

		// Token: 0x0603F35D RID: 258909 RVA: 0x00F45D93 File Offset: 0x00F43F93
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipRoadBookView, null, null);
		}

		// Token: 0x17009219 RID: 37401
		// (get) Token: 0x0603F35E RID: 258910 RVA: 0x00F45DA6 File Offset: 0x00F43FA6
		public static ActivityRoadBookController Instance
		{
			get
			{
				return ActivityRoadBookController._Instance;
			}
		}

		// Token: 0x0603F35F RID: 258911 RVA: 0x00F45DAD File Offset: 0x00F43FAD
		public static ActivityRoadBookController GetOrCreateInstance()
		{
			if (ActivityRoadBookController._Instance == null)
			{
				ActivityRoadBookController.CreateInstance();
			}
			return ActivityRoadBookController._Instance;
		}

		// Token: 0x0603F360 RID: 258912 RVA: 0x00F45DC1 File Offset: 0x00F43FC1
		public static bool CreateInstance()
		{
			if (ActivityRoadBookController._Instance != null)
			{
				return true;
			}
			ActivityRoadBookController._Instance = new ActivityRoadBookController();
			return true;
		}

		// Token: 0x0603F361 RID: 258913 RVA: 0x00F45DD7 File Offset: 0x00F43FD7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F362 RID: 258914 RVA: 0x00F45DD9 File Offset: 0x00F43FD9
		public static void ResetStaticDefaultValue()
		{
			ActivityRoadBookController._Instance = null;
		}

		// Token: 0x0603F363 RID: 258915 RVA: 0x00F45DE1 File Offset: 0x00F43FE1
		static ActivityRoadBookController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoadBookController.CreateStaticDefaultValue), new Action(ActivityRoadBookController.ResetStaticDefaultValue));
		}

		// Token: 0x04020F0B RID: 134923
		[Nullable(2)]
		private static ActivityRoadBookController _Instance;
	}
}
