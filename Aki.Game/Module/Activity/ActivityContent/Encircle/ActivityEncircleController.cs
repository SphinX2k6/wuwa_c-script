using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02002FFC RID: 12284
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEncircleController : ActivityControllerBase
	{
		// Token: 0x0601D293 RID: 119443 RVA: 0x008E8665 File Offset: 0x008E6865
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0601D294 RID: 119444 RVA: 0x008E8667 File Offset: 0x008E6867
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.EncircleChallengeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEncircleChallengeUpdateNotify));
		}

		// Token: 0x0601D295 RID: 119445 RVA: 0x008E8685 File Offset: 0x008E6885
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.EncircleChallengeUpdateNotify);
		}

		// Token: 0x0601D296 RID: 119446 RVA: 0x008E8697 File Offset: 0x008E6897
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityEncircleMain";
		}

		// Token: 0x0601D297 RID: 119447 RVA: 0x008E869E File Offset: 0x008E689E
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityEncircleSubView();
		}

		// Token: 0x0601D298 RID: 119448 RVA: 0x008E86A5 File Offset: 0x008E68A5
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityEncircleData();
		}

		// Token: 0x0601D299 RID: 119449 RVA: 0x008E86B8 File Offset: 0x008E68B8
		[NullableContext(2)]
		public ActivityEncircleData GetEncircleData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.Encircle);
			ActivityEncircleData result = null;
			if (currentActivitiesByType.Count != 0)
			{
				result = (currentActivitiesByType[0] as ActivityEncircleData);
			}
			return result;
		}

		// Token: 0x0601D29A RID: 119450 RVA: 0x008E86EC File Offset: 0x008E68EC
		public RewardData<IEncircleRewardInfo> BuildRewardData(List<RewardItemData> rewardItemDataList)
		{
			int currentChallengeId = EncirclePlayLevelController.Instance.GetCurrentChallengeId();
			ActivityEncircleData encircleData = this.GetEncircleData();
			return new RewardData<IEncircleRewardInfo>(new EncircleRewardInfo
			{
				IsSuccess = true,
				Score = new int?(EncirclePlayLevelController.Instance.GetTotalRound()),
				RecordScore = new int?((encircleData != null) ? encircleData.GetChallengeRecord(currentChallengeId) : 0),
				CommonItems = rewardItemDataList,
				Type = ERewardInfoType.Explore,
				ViewName = EUiViewName.EncircleResultView
			}, null);
		}

		// Token: 0x0601D29B RID: 119451 RVA: 0x008E8764 File Offset: 0x008E6964
		public bool GetRedPointShow()
		{
			int activityId = this.ActivityId;
			IReadOnlyList<EncircleChallengeGroup> encircleGroups = ActivityEncircleConfig.Instance.GetEncircleGroups(activityId);
			if (encircleGroups == null)
			{
				return false;
			}
			ActivityEncircleData encircleData = this.GetEncircleData();
			if (encircleData == null)
			{
				return false;
			}
			foreach (EncircleChallengeGroup encircleChallengeGroup in encircleGroups)
			{
				if (encircleData.CheckGroupRedPointShow(encircleChallengeGroup.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0601D29C RID: 119452 RVA: 0x008E87E4 File Offset: 0x008E69E4
		public void SendCompleteRequest(EncircleChallengeCompleteRequest request, Action callback)
		{
			Net.Instance.Call(ERequestMessageId.EncircleChallengeCompleteRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EncircleChallengeCompleteResponse encircleChallengeCompleteResponse = (EncircleChallengeCompleteResponse)msg;
				if (encircleChallengeCompleteResponse == null)
				{
					return;
				}
				if (encircleChallengeCompleteResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(encircleChallengeCompleteResponse.ErrorCode, 28305, null, true, true);
				}
				callback();
			}, 0);
		}

		// Token: 0x0601D29D RID: 119453 RVA: 0x008E881C File Offset: 0x008E6A1C
		public static void SendEnterRequest(EncircleChallengeStartRequest request, Action callback)
		{
			Net.Instance.Call(ERequestMessageId.EncircleChallengeStartRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EncircleChallengeStartResponse encircleChallengeStartResponse = (EncircleChallengeStartResponse)msg;
				if (encircleChallengeStartResponse == null)
				{
					return;
				}
				if (encircleChallengeStartResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(encircleChallengeStartResponse.ErrorCode, 28305, null, true, true);
				}
				callback();
			}, 0);
		}

		// Token: 0x0601D29E RID: 119454 RVA: 0x008E8853 File Offset: 0x008E6A53
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0601D29F RID: 119455 RVA: 0x008E8858 File Offset: 0x008E6A58
		[NullableContext(2)]
		private void OnEncircleChallengeUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (EncircleChallengePb challengeInfo in ((EncircleChallengeUpdateNotify)msg).Challenges)
			{
				this.GetEncircleData().UpdateChallengeInfo(challengeInfo);
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0601D2A0 RID: 119456 RVA: 0x008E88B0 File Offset: 0x008E6AB0
		public static ActivityEncircleController Instance
		{
			get
			{
				return ActivityEncircleController._Instance;
			}
		}

		// Token: 0x0601D2A1 RID: 119457 RVA: 0x008E88B7 File Offset: 0x008E6AB7
		public static ActivityEncircleController GetOrCreateInstance()
		{
			if (ActivityEncircleController._Instance == null)
			{
				ActivityEncircleController.CreateInstance();
			}
			return ActivityEncircleController._Instance;
		}

		// Token: 0x0601D2A2 RID: 119458 RVA: 0x008E88CB File Offset: 0x008E6ACB
		public static bool CreateInstance()
		{
			if (ActivityEncircleController._Instance != null)
			{
				return true;
			}
			ActivityEncircleController._Instance = new ActivityEncircleController();
			return true;
		}

		// Token: 0x0601D2A3 RID: 119459 RVA: 0x008E88E1 File Offset: 0x008E6AE1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601D2A4 RID: 119460 RVA: 0x008E88E3 File Offset: 0x008E6AE3
		public static void ResetStaticDefaultValue()
		{
			ActivityEncircleController._Instance = null;
		}

		// Token: 0x0601D2A5 RID: 119461 RVA: 0x008E88EB File Offset: 0x008E6AEB
		static ActivityEncircleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityEncircleController.CreateStaticDefaultValue), new Action(ActivityEncircleController.ResetStaticDefaultValue));
		}

		// Token: 0x0400F596 RID: 62870
		public int ActivityId;

		// Token: 0x0400F597 RID: 62871
		[Nullable(2)]
		private static ActivityEncircleController _Instance;
	}
}
