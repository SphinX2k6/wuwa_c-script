using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051DE RID: 20958
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityRealmBetweenController : ActivityControllerBase
	{
		// Token: 0x06034383 RID: 213891 RVA: 0x00E9C08E File Offset: 0x00E9A28E
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06034384 RID: 213892 RVA: 0x00E9C090 File Offset: 0x00E9A290
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RealmBetweenInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRealmBetweenInfoUpdateNotify));
		}

		// Token: 0x06034385 RID: 213893 RVA: 0x00E9C0AE File Offset: 0x00E9A2AE
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RealmBetweenInfoUpdateNotify);
		}

		// Token: 0x06034386 RID: 213894 RVA: 0x00E9C0C0 File Offset: 0x00E9A2C0
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06034387 RID: 213895 RVA: 0x00E9C0DE File Offset: 0x00E9A2DE
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06034388 RID: 213896 RVA: 0x00E9C0FC File Offset: 0x00E9A2FC
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_MapThemeHall35";
		}

		// Token: 0x06034389 RID: 213897 RVA: 0x00E9C104 File Offset: 0x00E9A304
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			ActivityRealmBetweenData realmBetweenData = this.GetRealmBetweenData();
			if (realmBetweenData == null)
			{
				return;
			}
			if (realmBetweenData.GetActivityConfig().ExpItemId != configId)
			{
				return;
			}
			if (realmBetweenData.CanTravelLevelUp())
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, realmBetweenData.Id);
			}
			this.TryOpenLevelTipsView(realmBetweenData);
		}

		// Token: 0x0603438A RID: 213898 RVA: 0x00E9C153 File Offset: 0x00E9A353
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewRealmBetween();
		}

		// Token: 0x0603438B RID: 213899 RVA: 0x00E9C15A File Offset: 0x00E9A35A
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new ActivityRealmBetweenData();
		}

		// Token: 0x0603438C RID: 213900 RVA: 0x00E9C161 File Offset: 0x00E9A361
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603438D RID: 213901 RVA: 0x00E9C164 File Offset: 0x00E9A364
		[NullableContext(2)]
		public ActivityRealmBetweenData GetRealmBetweenData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.RealmBetween);
			ActivityRealmBetweenData result = null;
			if (currentActivitiesByType != null && currentActivitiesByType.Count > 0)
			{
				result = (currentActivitiesByType[0] as ActivityRealmBetweenData);
			}
			return result;
		}

		// Token: 0x0603438E RID: 213902 RVA: 0x00E9C19C File Offset: 0x00E9A39C
		[NullableContext(2)]
		private void OnRealmBetweenInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RealmBetweenInfoUpdateNotify realmBetweenInfoUpdateNotify = (RealmBetweenInfoUpdateNotify)msg;
			ActivityRealmBetweenData realmBetweenData = this.GetRealmBetweenData();
			if (realmBetweenData == null)
			{
				return;
			}
			if (realmBetweenInfoUpdateNotify.ActivityTask != null)
			{
				realmBetweenData.RefreshTravelTaskData(realmBetweenInfoUpdateNotify.ActivityTask);
			}
			if (realmBetweenInfoUpdateNotify.MotorcycleLevel != null)
			{
				realmBetweenData.RefreshMotorChallengePlayData(realmBetweenInfoUpdateNotify.MotorcycleLevel);
			}
			if (realmBetweenInfoUpdateNotify.HasUnLockArea)
			{
				realmBetweenData.OnNewAreaUnlocked(realmBetweenInfoUpdateNotify.UnLockArea);
				EventSystem.Instance.Emit(EEventName.RealmBetweenTaskRefresh);
			}
			if (realmBetweenInfoUpdateNotify.HasUnLockMonsterId)
			{
				realmBetweenData.UnlockPhantom(realmBetweenInfoUpdateNotify.UnLockMonsterId);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, realmBetweenData.Id);
		}

		// Token: 0x0603438F RID: 213903 RVA: 0x00E9C234 File Offset: 0x00E9A434
		[NullableContext(2)]
		public void RequestRealmBetweenLevelUp(Action<bool> callback = null)
		{
			RealmBetweenLevelUpRequest message = RealmBetweenLevelUpRequest.Create();
			Net.Instance.Call(ERequestMessageId.RealmBetweenLevelUpRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RealmBetweenLevelUpResponse realmBetweenLevelUpResponse = (RealmBetweenLevelUpResponse)msg;
				if (realmBetweenLevelUpResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else if (realmBetweenLevelUpResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(realmBetweenLevelUpResponse.ErrorCode, 27232, null, true, true);
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
					ActivityRealmBetweenData realmBetweenData = this.GetRealmBetweenData();
					if (realmBetweenData != null)
					{
						realmBetweenData.TravelLevel++;
						Action<bool> callback4 = callback;
						if (callback4 != null)
						{
							callback4(true);
						}
						realmBetweenData.RefreshActivityRedDotState();
						this.TryOpenLevelTipsView(realmBetweenData);
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

		// Token: 0x06034390 RID: 213904 RVA: 0x00E9C278 File Offset: 0x00E9A478
		public void RequestMultiRealmBetweenTaskReward(int[] ids)
		{
			if (ids == null || ids.Length == 0)
			{
				return;
			}
			RealmBetweenTaskRewardRequest realmBetweenTaskRewardRequest = RealmBetweenTaskRewardRequest.Create();
			realmBetweenTaskRewardRequest.TaskIds.AddRange(ids);
			Net.Instance.Call(ERequestMessageId.RealmBetweenTaskRewardRequest, realmBetweenTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RealmBetweenTaskRewardResponse realmBetweenTaskRewardResponse = (RealmBetweenTaskRewardResponse)msg;
				if (realmBetweenTaskRewardResponse == null)
				{
					return;
				}
				if (realmBetweenTaskRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(realmBetweenTaskRewardResponse.ErrorCode, 26868, null, true, true);
					return;
				}
				ActivityRealmBetweenData realmBetweenData = this.GetRealmBetweenData();
				if (realmBetweenData == null)
				{
					return;
				}
				foreach (int travelTaskDataDone in ids)
				{
					realmBetweenData.SetTravelTaskDataDone(travelTaskDataDone);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, realmBetweenData.Id);
				EventSystem.Instance.Emit(EEventName.RealmBetweenTaskRefresh);
			}, 0);
		}

		// Token: 0x06034391 RID: 213905 RVA: 0x00E9C2E0 File Offset: 0x00E9A4E0
		public void RequestTakeTaskFinalReward()
		{
			RealmBetweenFullRewardRequest message = RealmBetweenFullRewardRequest.Create();
			Net.Instance.Call(ERequestMessageId.RealmBetweenFullRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RealmBetweenFullRewardResponse realmBetweenFullRewardResponse = (RealmBetweenFullRewardResponse)msg;
				if (realmBetweenFullRewardResponse == null)
				{
					return;
				}
				if (realmBetweenFullRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(realmBetweenFullRewardResponse.ErrorCode, 18737, null, true, true);
					return;
				}
				ActivityRealmBetweenData realmBetweenData = this.GetRealmBetweenData();
				if (realmBetweenData == null)
				{
					return;
				}
				realmBetweenData.TaskFinalRewardData.IsReceived = true;
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, realmBetweenData.Id);
				EventSystem.Instance.Emit(EEventName.RealmBetweenTaskRefresh);
			}, 0);
		}

		// Token: 0x06034392 RID: 213906 RVA: 0x00E9C310 File Offset: 0x00E9A510
		public void RequestMultiMotorChallengeReward(int[] ids)
		{
			if (ids == null || ids.Length == 0)
			{
				return;
			}
			RealmBetweenMotorRewardRequest realmBetweenMotorRewardRequest = RealmBetweenMotorRewardRequest.Create();
			realmBetweenMotorRewardRequest.TaskIds.AddRange(ids);
			Net.Instance.Call(ERequestMessageId.RealmBetweenMotorRewardRequest, realmBetweenMotorRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RealmBetweenMotorRewardResponse realmBetweenMotorRewardResponse = (RealmBetweenMotorRewardResponse)msg;
				if (realmBetweenMotorRewardResponse == null)
				{
					return;
				}
				if (realmBetweenMotorRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(realmBetweenMotorRewardResponse.ErrorCode, 20454, null, true, true);
					return;
				}
				ActivityRealmBetweenData realmBetweenData = this.GetRealmBetweenData();
				if (realmBetweenData == null)
				{
					return;
				}
				foreach (int motorChallengeRewardDone in ids)
				{
					realmBetweenData.SetMotorChallengeRewardDone(motorChallengeRewardDone);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, realmBetweenData.Id);
				EventSystem.Instance.Emit(EEventName.RealmBetweenMotorRefresh);
			}, 0);
		}

		// Token: 0x06034393 RID: 213907 RVA: 0x00E9C377 File Offset: 0x00E9A577
		private void TryOpenLevelTipsView(ActivityRealmBetweenData data)
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.RealmBetweenLevelTipsView))
			{
				UiManager.Instance.OpenView(EUiViewName.RealmBetweenLevelTipsView, data, null);
			}
		}

		// Token: 0x06034394 RID: 213908 RVA: 0x00E9C39B File Offset: 0x00E9A59B
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipRealmBetweenView, null, null);
		}

		// Token: 0x170065BE RID: 26046
		// (get) Token: 0x06034395 RID: 213909 RVA: 0x00E9C3AE File Offset: 0x00E9A5AE
		public static ActivityRealmBetweenController Instance
		{
			get
			{
				return ActivityRealmBetweenController._Instance;
			}
		}

		// Token: 0x06034396 RID: 213910 RVA: 0x00E9C3B5 File Offset: 0x00E9A5B5
		public static ActivityRealmBetweenController GetOrCreateInstance()
		{
			if (ActivityRealmBetweenController._Instance == null)
			{
				ActivityRealmBetweenController.CreateInstance();
			}
			return ActivityRealmBetweenController._Instance;
		}

		// Token: 0x06034397 RID: 213911 RVA: 0x00E9C3C9 File Offset: 0x00E9A5C9
		public static bool CreateInstance()
		{
			if (ActivityRealmBetweenController._Instance != null)
			{
				return true;
			}
			ActivityRealmBetweenController._Instance = new ActivityRealmBetweenController();
			return true;
		}

		// Token: 0x06034398 RID: 213912 RVA: 0x00E9C3DF File Offset: 0x00E9A5DF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034399 RID: 213913 RVA: 0x00E9C3E1 File Offset: 0x00E9A5E1
		public static void ResetStaticDefaultValue()
		{
			ActivityRealmBetweenController._Instance = null;
		}

		// Token: 0x0603439A RID: 213914 RVA: 0x00E9C3E9 File Offset: 0x00E9A5E9
		static ActivityRealmBetweenController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRealmBetweenController.CreateStaticDefaultValue), new Action(ActivityRealmBetweenController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BB44 RID: 113476
		[Nullable(2)]
		private static ActivityRealmBetweenController _Instance;
	}
}
