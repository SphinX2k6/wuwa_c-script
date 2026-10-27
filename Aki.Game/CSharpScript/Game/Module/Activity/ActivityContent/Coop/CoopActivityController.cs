using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068C4 RID: 26820
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopActivityController : ActivityControllerBase
	{
		// Token: 0x06042EF2 RID: 274162 RVA: 0x0104CB8E File Offset: 0x0104AD8E
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.CoopRoleInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnCoopActivityUpdate));
		}

		// Token: 0x06042EF3 RID: 274163 RVA: 0x0104CBAC File Offset: 0x0104ADAC
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.CoopRoleInfoUpdateNotify);
		}

		// Token: 0x06042EF4 RID: 274164 RVA: 0x0104CBC0 File Offset: 0x0104ADC0
		protected override void OnOpenView(ActivityBaseData data)
		{
			CoopActivityData param = data as CoopActivityData;
			UiManager.Instance.OpenView(EUiViewName.CoopEntranceView, param, null);
		}

		// Token: 0x06042EF5 RID: 274165 RVA: 0x0104CBE5 File Offset: 0x0104ADE5
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.TryShowCoopUpGrateView));
			EventSystem.Instance.Add(EEventName.ShowFloatTips, new Action(this.TryShowCoopUpGrateView));
		}

		// Token: 0x06042EF6 RID: 274166 RVA: 0x0104CC1F File Offset: 0x0104AE1F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.TryShowCoopUpGrateView));
			EventSystem.Instance.Remove(EEventName.ShowFloatTips, new Action(this.TryShowCoopUpGrateView));
		}

		// Token: 0x06042EF7 RID: 274167 RVA: 0x0104CC59 File Offset: 0x0104AE59
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCoopMain";
		}

		// Token: 0x06042EF8 RID: 274168 RVA: 0x0104CC60 File Offset: 0x0104AE60
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new CoopActivityView();
		}

		// Token: 0x06042EF9 RID: 274169 RVA: 0x0104CC67 File Offset: 0x0104AE67
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new CoopActivityData();
		}

		// Token: 0x06042EFA RID: 274170 RVA: 0x0104CC6E File Offset: 0x0104AE6E
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06042EFB RID: 274171 RVA: 0x0104CC74 File Offset: 0x0104AE74
		[NullableContext(2)]
		private void OnCoopActivityUpdate(IMessage msg, Net.CallbackStatus status)
		{
			CoopRoleInfoUpdateNotify coopRoleInfoUpdateNotify = (CoopRoleInfoUpdateNotify)msg;
			ActivityModel instance = ActivityModel.Instance;
			CoopActivityData coopActivityData = ((instance != null) ? instance.GetActivityById(coopRoleInfoUpdateNotify.ActivityId) : null) as CoopActivityData;
			if (coopRoleInfoUpdateNotify.CoopRoleInfo != null && ((coopActivityData != null) ? new bool?(coopActivityData.UpdateOneRoleData(coopRoleInfoUpdateNotify.CoopRoleInfo)) : null).GetValueOrDefault() && !UiManager.Instance.IsViewOpen(EUiViewName.CoopUpGrateView))
			{
				int coopRoleId = coopRoleInfoUpdateNotify.CoopRoleInfo.CoopRoleId;
				int roleCurCoopLevel = coopActivityData.GetRoleCurCoopLevel(coopRoleId);
				CoopUpGrateViewParams coopUpGrateViewParams = new CoopUpGrateViewParams
				{
					ActivityData = coopActivityData,
					RoleId = coopRoleId,
					PreLevel = roleCurCoopLevel - 1,
					NextLevel = roleCurCoopLevel,
					IsMaxLevel = coopActivityData.IsRoleCurCoopLevelMax(coopRoleId),
					IsNew = (roleCurCoopLevel == 1)
				};
				if (UiModel.Instance.IsInMainView)
				{
					UiManager.Instance.OpenView(EUiViewName.CoopUpGrateView, coopUpGrateViewParams, null);
				}
				else
				{
					this.CoopUpGrateViewOpenParam = coopUpGrateViewParams;
				}
			}
			if (coopRoleInfoUpdateNotify.CoopTaskCompleteInfo != null && coopActivityData != null)
			{
				coopActivityData.UpdateOneRoleLevelSubConditionData(coopRoleInfoUpdateNotify.CoopTaskCompleteInfo);
			}
			if (coopRoleInfoUpdateNotify.PreCompleteId != 0 && coopActivityData != null)
			{
				coopActivityData.UpdatePreCompleteLevelIdSet(new List<int>
				{
					coopRoleInfoUpdateNotify.PreCompleteId
				});
			}
			EventSystem.Instance.Emit(EEventName.OnCoopLevelUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, coopActivityData.Id);
		}

		// Token: 0x06042EFC RID: 274172 RVA: 0x0104CDD0 File Offset: 0x0104AFD0
		public void RequestCoopRoleReward(CoopActivityData data, int roleId)
		{
			CoopRoleRewardRequest coopRoleRewardRequest = CoopRoleRewardRequest.Create();
			coopRoleRewardRequest.CoopId = roleId;
			Net.Instance.Call(ERequestMessageId.CoopRoleRewardRequest, coopRoleRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				CoopRoleRewardResponse coopRoleRewardResponse = (CoopRoleRewardResponse)msg;
				if (coopRoleRewardResponse == null)
				{
					return;
				}
				if (coopRoleRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(coopRoleRewardResponse.ErrorCode, 17866, null, true, true);
					return;
				}
				data.UpdateCoopRoleReward(roleId);
				EventSystem.Instance.Emit(EEventName.OnCoopLevelUpdate);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			}, 0);
		}

		// Token: 0x06042EFD RID: 274173 RVA: 0x0104CE20 File Offset: 0x0104B020
		public void RequestCoopSpReward(CoopActivityData data)
		{
			CoopSpRewardRequest coopSpRewardRequest = CoopSpRewardRequest.Create();
			List<int> rewardIds = new List<int>();
			foreach (CoopSpRewardData coopSpRewardData in data.CoopSpRewardDataList)
			{
				if (coopSpRewardData.State == ECoopSpRewardState.Reward)
				{
					rewardIds.Add(coopSpRewardData.Id);
				}
			}
			coopSpRewardRequest.RewardIds.AddRange(rewardIds);
			Net.Instance.Call(ERequestMessageId.CoopSpRewardRequest, coopSpRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				CoopSpRewardResponse coopSpRewardResponse = (CoopSpRewardResponse)msg;
				if (coopSpRewardResponse == null)
				{
					return;
				}
				if (coopSpRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(coopSpRewardResponse.ErrorCode, 16957, null, true, true);
					return;
				}
				data.UpdateCoopSpRewardClaimed(rewardIds);
				EventSystem.Instance.Emit(EEventName.OnCoopSpUpdate);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			}, 0);
		}

		// Token: 0x06042EFE RID: 274174 RVA: 0x0104CED8 File Offset: 0x0104B0D8
		private void TryShowCoopUpGrateView()
		{
			if (this.CoopUpGrateViewOpenParam != null)
			{
				UiManager.Instance.OpenView(EUiViewName.CoopUpGrateView, this.CoopUpGrateViewOpenParam, null);
				this.CoopUpGrateViewOpenParam = null;
			}
		}

		// Token: 0x170097CD RID: 38861
		// (get) Token: 0x06042EFF RID: 274175 RVA: 0x0104CEFF File Offset: 0x0104B0FF
		public static CoopActivityController Instance
		{
			get
			{
				return CoopActivityController._Instance;
			}
		}

		// Token: 0x06042F00 RID: 274176 RVA: 0x0104CF06 File Offset: 0x0104B106
		public static CoopActivityController GetOrCreateInstance()
		{
			if (CoopActivityController._Instance == null)
			{
				CoopActivityController.CreateInstance();
			}
			return CoopActivityController._Instance;
		}

		// Token: 0x06042F01 RID: 274177 RVA: 0x0104CF1A File Offset: 0x0104B11A
		public static bool CreateInstance()
		{
			if (CoopActivityController._Instance != null)
			{
				return true;
			}
			CoopActivityController._Instance = new CoopActivityController();
			return true;
		}

		// Token: 0x06042F02 RID: 274178 RVA: 0x0104CF30 File Offset: 0x0104B130
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06042F03 RID: 274179 RVA: 0x0104CF32 File Offset: 0x0104B132
		public static void ResetStaticDefaultValue()
		{
			CoopActivityController._Instance = null;
		}

		// Token: 0x06042F04 RID: 274180 RVA: 0x0104CF3A File Offset: 0x0104B13A
		static CoopActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CoopActivityController.CreateStaticDefaultValue), new Action(CoopActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04022D1C RID: 142620
		[Nullable(2)]
		private CoopUpGrateViewParams CoopUpGrateViewOpenParam;

		// Token: 0x04022D1D RID: 142621
		[Nullable(2)]
		private static CoopActivityController _Instance;
	}
}
