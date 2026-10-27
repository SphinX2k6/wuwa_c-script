using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200664F RID: 26191
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEncircleController : ActivityControllerBase
	{
		// Token: 0x06041A75 RID: 268917 RVA: 0x00FECC21 File Offset: 0x00FEAE21
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06041A76 RID: 268918 RVA: 0x00FECC23 File Offset: 0x00FEAE23
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.EncircleChallengeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEncircleChallengeUpdateNotify));
		}

		// Token: 0x06041A77 RID: 268919 RVA: 0x00FECC41 File Offset: 0x00FEAE41
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.EncircleChallengeUpdateNotify);
		}

		// Token: 0x06041A78 RID: 268920 RVA: 0x00FECC53 File Offset: 0x00FEAE53
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityEncircleMain";
		}

		// Token: 0x06041A79 RID: 268921 RVA: 0x00FECC5A File Offset: 0x00FEAE5A
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityEncircleSubView();
		}

		// Token: 0x06041A7A RID: 268922 RVA: 0x00FECC61 File Offset: 0x00FEAE61
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityEncircleData();
		}

		// Token: 0x06041A7B RID: 268923 RVA: 0x00FECC74 File Offset: 0x00FEAE74
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

		// Token: 0x06041A7C RID: 268924 RVA: 0x00FECCA8 File Offset: 0x00FEAEA8
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

		// Token: 0x06041A7D RID: 268925 RVA: 0x00FECD20 File Offset: 0x00FEAF20
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

		// Token: 0x06041A7E RID: 268926 RVA: 0x00FECDA0 File Offset: 0x00FEAFA0
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(encircleChallengeCompleteResponse.ErrorCode, 25865, null, true, true);
				}
				callback();
			}, 0);
		}

		// Token: 0x06041A7F RID: 268927 RVA: 0x00FECDD8 File Offset: 0x00FEAFD8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(encircleChallengeStartResponse.ErrorCode, 25865, null, true, true);
				}
				callback();
			}, 0);
		}

		// Token: 0x06041A80 RID: 268928 RVA: 0x00FECE0F File Offset: 0x00FEB00F
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06041A81 RID: 268929 RVA: 0x00FECE14 File Offset: 0x00FEB014
		[NullableContext(2)]
		private void OnEncircleChallengeUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (EncircleChallengePb challengeInfo in ((EncircleChallengeUpdateNotify)msg).Challenges)
			{
				this.GetEncircleData().UpdateChallengeInfo(challengeInfo);
			}
		}

		// Token: 0x17009619 RID: 38425
		// (get) Token: 0x06041A82 RID: 268930 RVA: 0x00FECE6C File Offset: 0x00FEB06C
		public static ActivityEncircleController Instance
		{
			get
			{
				return ActivityEncircleController._Instance;
			}
		}

		// Token: 0x06041A83 RID: 268931 RVA: 0x00FECE73 File Offset: 0x00FEB073
		public static ActivityEncircleController GetOrCreateInstance()
		{
			if (ActivityEncircleController._Instance == null)
			{
				ActivityEncircleController.CreateInstance();
			}
			return ActivityEncircleController._Instance;
		}

		// Token: 0x06041A84 RID: 268932 RVA: 0x00FECE87 File Offset: 0x00FEB087
		public static bool CreateInstance()
		{
			if (ActivityEncircleController._Instance != null)
			{
				return true;
			}
			ActivityEncircleController._Instance = new ActivityEncircleController();
			return true;
		}

		// Token: 0x06041A85 RID: 268933 RVA: 0x00FECE9D File Offset: 0x00FEB09D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041A86 RID: 268934 RVA: 0x00FECE9F File Offset: 0x00FEB09F
		public static void ResetStaticDefaultValue()
		{
			ActivityEncircleController._Instance = null;
		}

		// Token: 0x06041A87 RID: 268935 RVA: 0x00FECEA7 File Offset: 0x00FEB0A7
		static ActivityEncircleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityEncircleController.CreateStaticDefaultValue), new Action(ActivityEncircleController.ResetStaticDefaultValue));
		}

		// Token: 0x0402228C RID: 139916
		public int ActivityId;

		// Token: 0x0402228D RID: 139917
		[Nullable(2)]
		private static ActivityEncircleController _Instance;
	}
}
