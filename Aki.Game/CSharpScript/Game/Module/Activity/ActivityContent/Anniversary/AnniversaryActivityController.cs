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
	// Token: 0x02005861 RID: 22625
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class AnniversaryActivityController : ActivityControllerBase
	{
		// Token: 0x06037C82 RID: 228482 RVA: 0x00F98CF6 File Offset: 0x00F96EF6
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06037C83 RID: 228483 RVA: 0x00F98CF8 File Offset: 0x00F96EF8
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_AnniversaryCelebrationMain";
		}

		// Token: 0x06037C84 RID: 228484 RVA: 0x00F98CFF File Offset: 0x00F96EFF
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new AnniversaryActivitySubView();
		}

		// Token: 0x06037C85 RID: 228485 RVA: 0x00F98D06 File Offset: 0x00F96F06
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			this.CheckOpenActivity(false);
			return new AnniversaryActivityData();
		}

		// Token: 0x06037C86 RID: 228486 RVA: 0x00F98D20 File Offset: 0x00F96F20
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06037C87 RID: 228487 RVA: 0x00F98D24 File Offset: 0x00F96F24
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityOpenEvent));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06037C88 RID: 228488 RVA: 0x00F98D88 File Offset: 0x00F96F88
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
			EventSystem.Instance.Remove(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityOpenEvent));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06037C89 RID: 228489 RVA: 0x00F98DEC File Offset: 0x00F96FEC
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

		// Token: 0x06037C8A RID: 228490 RVA: 0x00F98E9C File Offset: 0x00F9709C
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

		// Token: 0x06037C8B RID: 228491 RVA: 0x00F98F4C File Offset: 0x00F9714C
		private void WorldDone()
		{
			this.WorldDoneOnce = true;
			this.CheckOpenActivity(false);
		}

		// Token: 0x06037C8C RID: 228492 RVA: 0x00F98F5C File Offset: 0x00F9715C
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

		// Token: 0x06037C8D RID: 228493 RVA: 0x00F98FCC File Offset: 0x00F971CC
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

		// Token: 0x06037C8E RID: 228494 RVA: 0x00F99040 File Offset: 0x00F97240
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

		// Token: 0x06037C8F RID: 228495 RVA: 0x00F990A6 File Offset: 0x00F972A6
		public void SetCheckedOpenActivity(bool value)
		{
			this.HadCheckedOpenActivity = value;
		}

		// Token: 0x06037C90 RID: 228496 RVA: 0x00F990B0 File Offset: 0x00F972B0
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

		// Token: 0x17006B28 RID: 27432
		// (get) Token: 0x06037C91 RID: 228497 RVA: 0x00F991A4 File Offset: 0x00F973A4
		public static AnniversaryActivityController Instance
		{
			get
			{
				return AnniversaryActivityController._Instance;
			}
		}

		// Token: 0x06037C92 RID: 228498 RVA: 0x00F991AB File Offset: 0x00F973AB
		public static AnniversaryActivityController GetOrCreateInstance()
		{
			if (AnniversaryActivityController._Instance == null)
			{
				AnniversaryActivityController.CreateInstance();
			}
			return AnniversaryActivityController._Instance;
		}

		// Token: 0x06037C93 RID: 228499 RVA: 0x00F991BF File Offset: 0x00F973BF
		public static bool CreateInstance()
		{
			if (AnniversaryActivityController._Instance != null)
			{
				return true;
			}
			AnniversaryActivityController._Instance = new AnniversaryActivityController();
			return true;
		}

		// Token: 0x06037C94 RID: 228500 RVA: 0x00F991D5 File Offset: 0x00F973D5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037C95 RID: 228501 RVA: 0x00F991D7 File Offset: 0x00F973D7
		public static void ResetStaticDefaultValue()
		{
			AnniversaryActivityController._Instance = null;
		}

		// Token: 0x06037C96 RID: 228502 RVA: 0x00F991DF File Offset: 0x00F973DF
		static AnniversaryActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnniversaryActivityController.CreateStaticDefaultValue), new Action(AnniversaryActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D6EE RID: 120558
		private int ActivityId;

		// Token: 0x0401D6EF RID: 120559
		private bool WorldDoneOnce;

		// Token: 0x0401D6F0 RID: 120560
		private readonly HashSet<int> SubActivityIds = new HashSet<int>();

		// Token: 0x0401D6F1 RID: 120561
		private bool HadCheckedOpenActivity;

		// Token: 0x0401D6F2 RID: 120562
		[Nullable(2)]
		private static AnniversaryActivityController _Instance;
	}
}
