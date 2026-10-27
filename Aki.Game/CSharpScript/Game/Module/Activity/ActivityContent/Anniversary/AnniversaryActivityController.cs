using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006911 RID: 26897
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class AnniversaryActivityController : ActivityControllerBase
	{
		// Token: 0x0604312A RID: 274730 RVA: 0x010576CA File Offset: 0x010558CA
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0604312B RID: 274731 RVA: 0x010576CC File Offset: 0x010558CC
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_AnniversaryCelebrationMain";
		}

		// Token: 0x0604312C RID: 274732 RVA: 0x010576D3 File Offset: 0x010558D3
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new AnniversaryActivitySubView();
		}

		// Token: 0x0604312D RID: 274733 RVA: 0x010576DA File Offset: 0x010558DA
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			this.CheckOpenActivity(false);
			return new AnniversaryActivityData();
		}

		// Token: 0x0604312E RID: 274734 RVA: 0x010576F4 File Offset: 0x010558F4
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0604312F RID: 274735 RVA: 0x010576F8 File Offset: 0x010558F8
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityOpenEvent));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06043130 RID: 274736 RVA: 0x0105775C File Offset: 0x0105595C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
			EventSystem.Instance.Remove(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityOpenEvent));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06043131 RID: 274737 RVA: 0x010577C0 File Offset: 0x010559C0
		public void RequestThemePersonalScore(AnniversaryActivityData data)
		{
			List<int> rewardIds = data.GetPersonalCanReceiveRewardIds();
			if (rewardIds == null || rewardIds.Count == 0)
			{
				return;
			}
			ThemePersonalScoreRequest themePersonalScoreRequest = ThemePersonalScoreRequest.Create();
			foreach (int item in rewardIds)
			{
				themePersonalScoreRequest.Ids.Add(item);
			}
			Net.Instance.Call(ERequestMessageId.ThemePersonalScoreRequest, themePersonalScoreRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ThemePersonalScoreResponse themePersonalScoreResponse = (ThemePersonalScoreResponse)msg;
				if (themePersonalScoreResponse == null)
				{
					return;
				}
				if (themePersonalScoreResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(themePersonalScoreResponse.ErrorCode, EResponseMessageId.ThemePersonalScoreResponse, null, true, true);
					return;
				}
				data.UpdatePersonalRewardIds(rewardIds);
				EventSystem.Instance.Emit(EEventName.OnAnniversaryActivityRewardUpdate);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			}, 0);
		}

		// Token: 0x06043132 RID: 274738 RVA: 0x01057870 File Offset: 0x01055A70
		public void RequestThemeWorldScore(AnniversaryActivityData data)
		{
			List<int> rewardIds = data.GetWorldCanReceiveRewardIds();
			if (rewardIds == null || rewardIds.Count == 0)
			{
				return;
			}
			ThemeWorldScoreRequest themeWorldScoreRequest = ThemeWorldScoreRequest.Create();
			foreach (int item in rewardIds)
			{
				themeWorldScoreRequest.Ids.Add(item);
			}
			Net.Instance.Call(ERequestMessageId.ThemeWorldScoreRequest, themeWorldScoreRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ThemeWorldScoreResponse themeWorldScoreResponse = (ThemeWorldScoreResponse)msg;
				if (themeWorldScoreResponse == null)
				{
					return;
				}
				if (themeWorldScoreResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(themeWorldScoreResponse.ErrorCode, EResponseMessageId.ThemeWorldScoreResponse, null, true, true);
					return;
				}
				data.UpdateWorldRewardIds(rewardIds);
				EventSystem.Instance.Emit(EEventName.OnAnniversaryActivityRewardUpdate);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			}, 0);
		}

		// Token: 0x06043133 RID: 274739 RVA: 0x01057920 File Offset: 0x01055B20
		private void WorldDone()
		{
			this.WorldDoneOnce = true;
			this.CheckOpenActivity(false);
		}

		// Token: 0x06043134 RID: 274740 RVA: 0x01057930 File Offset: 0x01055B30
		private void CacheSubActivityIds()
		{
			this.SubActivityIds.Clear();
			IReadOnlyList<AnniversaryEntrance> anniversaryEntranceAll = AnniversaryActivityConfig.Instance.GetAnniversaryEntranceAll();
			if (anniversaryEntranceAll == null)
			{
				return;
			}
			foreach (AnniversaryEntrance anniversaryEntrance in anniversaryEntranceAll)
			{
				this.SubActivityIds.Add(anniversaryEntrance.ActivityId);
			}
		}

		// Token: 0x06043135 RID: 274741 RVA: 0x010579A0 File Offset: 0x01055BA0
		private void OnActivityOpenEvent(IReadOnlySet<int> openActivities)
		{
			if (this.ActivityId == 0)
			{
				return;
			}
			if (this.SubActivityIds.Count == 0)
			{
				this.CacheSubActivityIds();
			}
			foreach (int item in openActivities)
			{
				if (this.SubActivityIds.Contains(item))
				{
					this.CheckOpenActivity(true);
					break;
				}
			}
		}

		// Token: 0x06043136 RID: 274742 RVA: 0x01057A14 File Offset: 0x01055C14
		private void OnRefreshCommonActivityRedDot(int uid)
		{
			if (this.ActivityId == 0 || uid == this.ActivityId)
			{
				return;
			}
			AnniversaryActivityData anniversaryActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as AnniversaryActivityData;
			if (anniversaryActivityData == null || !anniversaryActivityData.IsRelativeActivityId(uid))
			{
				return;
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}, 20f, null, null, true, 1f);
		}

		// Token: 0x06043137 RID: 274743 RVA: 0x01057A7A File Offset: 0x01055C7A
		public void SetCheckedOpenActivity(bool value)
		{
			this.HadCheckedOpenActivity = value;
		}

		// Token: 0x06043138 RID: 274744 RVA: 0x01057A84 File Offset: 0x01055C84
		public void CheckOpenActivity(bool isInstantly = false)
		{
			if (PublicUtil.Instance.GetIsSilentLogin())
			{
				return;
			}
			if (this.ActivityId == 0 || !this.WorldDoneOnce || GameModeController.Instance.IsInInstance())
			{
				return;
			}
			if (this.HadCheckedOpenActivity)
			{
				return;
			}
			IReadOnlyList<AnniversaryEntrance> anniversaryEntranceAll = AnniversaryActivityConfig.Instance.GetAnniversaryEntranceAll();
			if (anniversaryEntranceAll == null)
			{
				return;
			}
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AnniversaryActivityFirstClick) as ServerStorageSet;
			bool flag = false;
			foreach (AnniversaryEntrance anniversaryEntrance in anniversaryEntranceAll)
			{
				if (ActivityModel.Instance.GetActivityById(anniversaryEntrance.ActivityId) != null && (serverStorageSet == null || !serverStorageSet.Has(anniversaryEntrance.ActivityId)))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
			this.HadCheckedOpenActivity = true;
			SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.AnniversaryActivity, ESplashScreenType.Config, delegate()
			{
				this.HadCheckedOpenActivity = false;
				TimerSystem.Instance.Delay(delegate(float _)
				{
					ActivityController.Instance.OpenActivityById(this.ActivityId, EActivityViewOpenType.Other, null, null);
				}, 100f, null, null, true, 1f);
			});
			SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
		}

		// Token: 0x170097E8 RID: 38888
		// (get) Token: 0x06043139 RID: 274745 RVA: 0x01057B78 File Offset: 0x01055D78
		public static AnniversaryActivityController Instance
		{
			get
			{
				return AnniversaryActivityController._Instance;
			}
		}

		// Token: 0x0604313A RID: 274746 RVA: 0x01057B7F File Offset: 0x01055D7F
		public static AnniversaryActivityController GetOrCreateInstance()
		{
			if (AnniversaryActivityController._Instance == null)
			{
				AnniversaryActivityController.CreateInstance();
			}
			return AnniversaryActivityController._Instance;
		}

		// Token: 0x0604313B RID: 274747 RVA: 0x01057B93 File Offset: 0x01055D93
		public static bool CreateInstance()
		{
			if (AnniversaryActivityController._Instance != null)
			{
				return true;
			}
			AnniversaryActivityController._Instance = new AnniversaryActivityController();
			return true;
		}

		// Token: 0x0604313C RID: 274748 RVA: 0x01057BA9 File Offset: 0x01055DA9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604313D RID: 274749 RVA: 0x01057BAB File Offset: 0x01055DAB
		public static void ResetStaticDefaultValue()
		{
			AnniversaryActivityController._Instance = null;
		}

		// Token: 0x0604313E RID: 274750 RVA: 0x01057BB3 File Offset: 0x01055DB3
		static AnniversaryActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnniversaryActivityController.CreateStaticDefaultValue), new Action(AnniversaryActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04022E92 RID: 142994
		private int ActivityId;

		// Token: 0x04022E93 RID: 142995
		private bool WorldDoneOnce;

		// Token: 0x04022E94 RID: 142996
		private readonly HashSet<int> SubActivityIds = new HashSet<int>();

		// Token: 0x04022E95 RID: 142997
		private bool HadCheckedOpenActivity;

		// Token: 0x04022E96 RID: 142998
		[Nullable(2)]
		private static AnniversaryActivityController _Instance;
	}
}
