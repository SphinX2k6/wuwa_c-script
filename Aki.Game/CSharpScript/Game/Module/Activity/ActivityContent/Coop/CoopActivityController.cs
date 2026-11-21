using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005814 RID: 22548
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopActivityController : ActivityControllerBase
	{
		// Token: 0x06037A4A RID: 227914 RVA: 0x00F8E1B6 File Offset: 0x00F8C3B6
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.CoopRoleInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnCoopActivityUpdate));
		}

		// Token: 0x06037A4B RID: 227915 RVA: 0x00F8E1D4 File Offset: 0x00F8C3D4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.CoopRoleInfoUpdateNotify);
		}

		// Token: 0x06037A4C RID: 227916 RVA: 0x00F8E1E8 File Offset: 0x00F8C3E8
		protected override void OnOpenView(ActivityBaseData data)
		{
			CoopActivityData param = data as CoopActivityData;
			UiManager.Instance.OpenView(EUiViewName.CoopEntranceView, param, null);
		}

		// Token: 0x06037A4D RID: 227917 RVA: 0x00F8E20D File Offset: 0x00F8C40D
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.TryShowCoopUpGrateView));
			EventSystem.Instance.Add(EEventName.ShowFloatTips, new Action(this.TryShowCoopUpGrateView));
		}

		// Token: 0x06037A4E RID: 227918 RVA: 0x00F8E247 File Offset: 0x00F8C447
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.TryShowCoopUpGrateView));
			EventSystem.Instance.Remove(EEventName.ShowFloatTips, new Action(this.TryShowCoopUpGrateView));
		}

		// Token: 0x06037A4F RID: 227919 RVA: 0x00F8E281 File Offset: 0x00F8C481
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCoopMain";
		}

		// Token: 0x06037A50 RID: 227920 RVA: 0x00F8E288 File Offset: 0x00F8C488
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new CoopActivityView();
		}

		// Token: 0x06037A51 RID: 227921 RVA: 0x00F8E28F File Offset: 0x00F8C48F
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new CoopActivityData();
		}

		// Token: 0x06037A52 RID: 227922 RVA: 0x00F8E296 File Offset: 0x00F8C496
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06037A53 RID: 227923 RVA: 0x00F8E29C File Offset: 0x00F8C49C
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

		// Token: 0x06037A54 RID: 227924 RVA: 0x00F8E3F8 File Offset: 0x00F8C5F8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(coopRoleRewardResponse.ErrorCode, 25354, null, true, true);
					return;
				}
				data.UpdateCoopRoleReward(roleId);
				EventSystem.Instance.Emit(EEventName.OnCoopLevelUpdate);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			}, 0);
		}

		// Token: 0x06037A55 RID: 227925 RVA: 0x00F8E448 File Offset: 0x00F8C648
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(coopSpRewardResponse.ErrorCode, 19720, null, true, true);
					return;
				}
				data.UpdateCoopSpRewardClaimed(rewardIds);
				EventSystem.Instance.Emit(EEventName.OnCoopSpUpdate);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			}, 0);
		}

		// Token: 0x06037A56 RID: 227926 RVA: 0x00F8E500 File Offset: 0x00F8C700
		private void TryShowCoopUpGrateView()
		{
			if (this.CoopUpGrateViewOpenParam != null)
			{
				UiManager.Instance.OpenView(EUiViewName.CoopUpGrateView, this.CoopUpGrateViewOpenParam, null);
				this.CoopUpGrateViewOpenParam = null;
			}
		}

		// Token: 0x17006B0D RID: 27405
		// (get) Token: 0x06037A57 RID: 227927 RVA: 0x00F8E527 File Offset: 0x00F8C727
		public static CoopActivityController Instance
		{
			get
			{
				return CoopActivityController._Instance;
			}
		}

		// Token: 0x06037A58 RID: 227928 RVA: 0x00F8E52E File Offset: 0x00F8C72E
		public static CoopActivityController GetOrCreateInstance()
		{
			if (CoopActivityController._Instance == null)
			{
				CoopActivityController.CreateInstance();
			}
			return CoopActivityController._Instance;
		}

		// Token: 0x06037A59 RID: 227929 RVA: 0x00F8E542 File Offset: 0x00F8C742
		public static bool CreateInstance()
		{
			if (CoopActivityController._Instance != null)
			{
				return true;
			}
			CoopActivityController._Instance = new CoopActivityController();
			return true;
		}

		// Token: 0x06037A5A RID: 227930 RVA: 0x00F8E558 File Offset: 0x00F8C758
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037A5B RID: 227931 RVA: 0x00F8E55A File Offset: 0x00F8C75A
		public static void ResetStaticDefaultValue()
		{
			CoopActivityController._Instance = null;
		}

		// Token: 0x06037A5C RID: 227932 RVA: 0x00F8E562 File Offset: 0x00F8C762
		static CoopActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CoopActivityController.CreateStaticDefaultValue), new Action(CoopActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D578 RID: 120184
		[Nullable(2)]
		private CoopUpGrateViewParams CoopUpGrateViewOpenParam;

		// Token: 0x0401D579 RID: 120185
		[Nullable(2)]
		private static CoopActivityController _Instance;
	}
}
