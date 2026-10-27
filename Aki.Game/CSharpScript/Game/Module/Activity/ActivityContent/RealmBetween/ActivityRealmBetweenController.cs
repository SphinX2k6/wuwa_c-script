using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006260 RID: 25184
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityRealmBetweenController : ActivityControllerBase
	{
		// Token: 0x0603F6C2 RID: 259778 RVA: 0x00F55132 File Offset: 0x00F53332
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603F6C3 RID: 259779 RVA: 0x00F55134 File Offset: 0x00F53334
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RealmBetweenInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRealmBetweenInfoUpdateNotify));
		}

		// Token: 0x0603F6C4 RID: 259780 RVA: 0x00F55152 File Offset: 0x00F53352
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RealmBetweenInfoUpdateNotify);
		}

		// Token: 0x0603F6C5 RID: 259781 RVA: 0x00F55164 File Offset: 0x00F53364
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x0603F6C6 RID: 259782 RVA: 0x00F55182 File Offset: 0x00F53382
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x0603F6C7 RID: 259783 RVA: 0x00F551A0 File Offset: 0x00F533A0
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_MapThemeHall35";
		}

		// Token: 0x0603F6C8 RID: 259784 RVA: 0x00F551A8 File Offset: 0x00F533A8
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

		// Token: 0x0603F6C9 RID: 259785 RVA: 0x00F551F7 File Offset: 0x00F533F7
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewRealmBetween();
		}

		// Token: 0x0603F6CA RID: 259786 RVA: 0x00F551FE File Offset: 0x00F533FE
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new ActivityRealmBetweenData();
		}

		// Token: 0x0603F6CB RID: 259787 RVA: 0x00F55205 File Offset: 0x00F53405
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603F6CC RID: 259788 RVA: 0x00F55208 File Offset: 0x00F53408
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

		// Token: 0x0603F6CD RID: 259789 RVA: 0x00F55240 File Offset: 0x00F53440
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

		// Token: 0x0603F6CE RID: 259790 RVA: 0x00F552D8 File Offset: 0x00F534D8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(realmBetweenLevelUpResponse.ErrorCode, 15881, null, true, true);
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

		// Token: 0x0603F6CF RID: 259791 RVA: 0x00F5531C File Offset: 0x00F5351C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(realmBetweenTaskRewardResponse.ErrorCode, 27072, null, true, true);
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

		// Token: 0x0603F6D0 RID: 259792 RVA: 0x00F55384 File Offset: 0x00F53584
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(realmBetweenFullRewardResponse.ErrorCode, 17101, null, true, true);
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

		// Token: 0x0603F6D1 RID: 259793 RVA: 0x00F553B4 File Offset: 0x00F535B4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(realmBetweenMotorRewardResponse.ErrorCode, 16795, null, true, true);
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

		// Token: 0x0603F6D2 RID: 259794 RVA: 0x00F5541B File Offset: 0x00F5361B
		private void TryOpenLevelTipsView(ActivityRealmBetweenData data)
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.RealmBetweenLevelTipsView))
			{
				UiManager.Instance.OpenView(EUiViewName.RealmBetweenLevelTipsView, data, null);
			}
		}

		// Token: 0x0603F6D3 RID: 259795 RVA: 0x00F5543F File Offset: 0x00F5363F
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipRealmBetweenView, null, null);
		}

		// Token: 0x1700925C RID: 37468
		// (get) Token: 0x0603F6D4 RID: 259796 RVA: 0x00F55452 File Offset: 0x00F53652
		public static ActivityRealmBetweenController Instance
		{
			get
			{
				return ActivityRealmBetweenController._Instance;
			}
		}

		// Token: 0x0603F6D5 RID: 259797 RVA: 0x00F55459 File Offset: 0x00F53659
		public static ActivityRealmBetweenController GetOrCreateInstance()
		{
			if (ActivityRealmBetweenController._Instance == null)
			{
				ActivityRealmBetweenController.CreateInstance();
			}
			return ActivityRealmBetweenController._Instance;
		}

		// Token: 0x0603F6D6 RID: 259798 RVA: 0x00F5546D File Offset: 0x00F5366D
		public static bool CreateInstance()
		{
			if (ActivityRealmBetweenController._Instance != null)
			{
				return true;
			}
			ActivityRealmBetweenController._Instance = new ActivityRealmBetweenController();
			return true;
		}

		// Token: 0x0603F6D7 RID: 259799 RVA: 0x00F55483 File Offset: 0x00F53683
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F6D8 RID: 259800 RVA: 0x00F55485 File Offset: 0x00F53685
		public static void ResetStaticDefaultValue()
		{
			ActivityRealmBetweenController._Instance = null;
		}

		// Token: 0x0603F6D9 RID: 259801 RVA: 0x00F5548D File Offset: 0x00F5368D
		static ActivityRealmBetweenController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRealmBetweenController.CreateStaticDefaultValue), new Action(ActivityRealmBetweenController.ResetStaticDefaultValue));
		}

		// Token: 0x04021215 RID: 135701
		[Nullable(2)]
		private static ActivityRealmBetweenController _Instance;
	}
}
