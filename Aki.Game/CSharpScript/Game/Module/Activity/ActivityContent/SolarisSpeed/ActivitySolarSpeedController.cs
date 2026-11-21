using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005025 RID: 20517
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivitySolarSpeedController : ActivityControllerBase
	{
		// Token: 0x06033581 RID: 210305 RVA: 0x00E64FD2 File Offset: 0x00E631D2
		protected override void OnOpenView(ActivityBaseData data)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
		}

		// Token: 0x06033582 RID: 210306 RVA: 0x00E64FEA File Offset: 0x00E631EA
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_GongduolaOnlineGuide";
		}

		// Token: 0x06033583 RID: 210307 RVA: 0x00E64FF1 File Offset: 0x00E631F1
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySolarSpeedSubView();
		}

		// Token: 0x06033584 RID: 210308 RVA: 0x00E64FF8 File Offset: 0x00E631F8
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return SolarSpeedModel.Instance.ActivityData;
		}

		// Token: 0x06033585 RID: 210309 RVA: 0x00E65004 File Offset: 0x00E63204
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06033586 RID: 210310 RVA: 0x00E65007 File Offset: 0x00E63207
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.TeamParkourTaskNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleTeamParkourTaskNotify));
			Net.Instance.Register(ENotifyMessageId.TeamParkourSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleTeamParkourSettleNotify));
		}

		// Token: 0x06033587 RID: 210311 RVA: 0x00E65041 File Offset: 0x00E63241
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.TeamParkourTaskNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeamParkourSettleNotify);
		}

		// Token: 0x06033588 RID: 210312 RVA: 0x00E65063 File Offset: 0x00E63263
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.OnSelectInstanceIdChallenge, new Action<int>(this.HandleOnSelectInstanceIdChallenge));
			EventSystem.Instance.Add<int>(EEventName.CloseInstanceEntrancePositively, new Action<int>(this.HandleCloseInstanceEntrancePositively));
		}

		// Token: 0x06033589 RID: 210313 RVA: 0x00E6509D File Offset: 0x00E6329D
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnSelectInstanceIdChallenge, new Action<int>(this.HandleOnSelectInstanceIdChallenge));
			EventSystem.Instance.Remove(EEventName.CloseInstanceEntrancePositively, new Action<int>(this.HandleCloseInstanceEntrancePositively));
		}

		// Token: 0x0603358A RID: 210314 RVA: 0x00E650D8 File Offset: 0x00E632D8
		public override bool GetActivityLevelUnlockState(int instanceId)
		{
			bool flag;
			if (GameModeModel.Instance.IsMulti)
			{
				int? id = PlayerInfoModel.Instance.GetId();
				int ownerId = OnlineModel.Instance.OwnerId;
				flag = (id.GetValueOrDefault() == ownerId & id != null);
			}
			else
			{
				flag = true;
			}
			bool flag2 = flag;
			return SolarSpeedModel.Instance.IsUnlockByInstanceId(instanceId) && flag2;
		}

		// Token: 0x0603358B RID: 210315 RVA: 0x00E6512C File Offset: 0x00E6332C
		[NullableContext(0)]
		public UniTask<bool> RequestTeamParkourRewardRequest(int uid)
		{
			ActivitySolarSpeedController.<RequestTeamParkourRewardRequest>d__10 <RequestTeamParkourRewardRequest>d__;
			<RequestTeamParkourRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestTeamParkourRewardRequest>d__.uid = uid;
			<RequestTeamParkourRewardRequest>d__.<>1__state = -1;
			<RequestTeamParkourRewardRequest>d__.<>t__builder.Start<ActivitySolarSpeedController.<RequestTeamParkourRewardRequest>d__10>(ref <RequestTeamParkourRewardRequest>d__);
			return <RequestTeamParkourRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603358C RID: 210316 RVA: 0x00E6516F File Offset: 0x00E6336F
		public void SyncCurrentChosenLevelId(int id)
		{
			SolarSpeedModel.Instance.SetCurrentChosenTabInRewardView(id);
		}

		// Token: 0x0603358D RID: 210317 RVA: 0x00E6517C File Offset: 0x00E6337C
		public void HandleConfirmClickInActivitySubView()
		{
			InstanceDungeonEntranceController.Instance.EnterEntrance(9000, 0, null);
		}

		// Token: 0x0603358E RID: 210318 RVA: 0x00E65190 File Offset: 0x00E63390
		public void HandleOnClickRewardInActivitySubView()
		{
			SolarSpeedModel instance = SolarSpeedModel.Instance;
			if (instance.ActivityData.IsUnLock())
			{
				UiManager.Instance.OpenView(EUiViewName.SolarSpeedRewardView, instance.BuildSolarSpeedRewardViewDataById(instance.DefaultLevelIdInRewardView), null);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("LianjiPaoku_Reward_Cannot_Open_Tips", Array.Empty<object>());
		}

		// Token: 0x0603358F RID: 210319 RVA: 0x00E651E1 File Offset: 0x00E633E1
		public void HandleClickPlayerInResultView(int playerId)
		{
			FriendController.Instance.RequestFriendApplyAddSend(playerId, FriendApplyWay.RecentlyTeam);
		}

		// Token: 0x06033590 RID: 210320 RVA: 0x00E651F0 File Offset: 0x00E633F0
		public void HandleClickNextInResultView()
		{
			SolarSpeedModel instance = SolarSpeedModel.Instance;
			RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "LianjiPaoku_End_Leave",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = new Action<int>(ActivitySolarSpeedController.<HandleClickNextInResultView>g__OnClickQuit|15_0)
			};
			ItemRewardController.Instance.OpenExploreRewardView(3024, true, null, null, null, new List<IRewardExploreConfirmButton>
			{
				item
			}, null, null, null, null, null, null, null, instance.BuildSettleReachTargetData(), null, null, null);
		}

		// Token: 0x06033591 RID: 210321 RVA: 0x00E6527B File Offset: 0x00E6347B
		[NullableContext(2)]
		public string GetInstanceSubtitleTextIdByInstanceId(int instanceId)
		{
			return SolarSpeedModel.Instance.GetInstanceSubtitleTextIdByInstanceId(instanceId);
		}

		// Token: 0x06033592 RID: 210322 RVA: 0x00E65288 File Offset: 0x00E63488
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceSubtitleArgsByInstanceId(int instanceId)
		{
			return SolarSpeedModel.Instance.GetInstanceSubtitleArgsByInstanceId(instanceId);
		}

		// Token: 0x06033593 RID: 210323 RVA: 0x00E65298 File Offset: 0x00E63498
		[NullableContext(2)]
		private void HandleTeamParkourTaskNotify(IMessage __msg, Net.CallbackStatus _)
		{
			TeamParkourTaskNotify msg = (TeamParkourTaskNotify)__msg;
			SolarSpeedModel.Instance.SyncTeamParkourTaskNotify(msg);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, SolarSpeedModel.Instance.CurrentActivityId);
		}

		// Token: 0x06033594 RID: 210324 RVA: 0x00E652D4 File Offset: 0x00E634D4
		[NullableContext(2)]
		private void HandleTeamParkourSettleNotify(IMessage __msg, Net.CallbackStatus _)
		{
			TeamParkourSettleNotify teamParkourSettleNotify = (TeamParkourSettleNotify)__msg;
			foreach (PlayerSettleInfo playerSettleInfo in teamParkourSettleNotify.PlayerSettleInfos)
			{
			}
			SolarSpeedModel instance = SolarSpeedModel.Instance;
			instance.SyncTeamParkourSettleNotify(teamParkourSettleNotify);
			UiManager.Instance.OpenView(EUiViewName.SolarSpeedResultView, instance.BuildSolarSpeedResultViewData(), null);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, instance.CurrentActivityId);
		}

		// Token: 0x06033595 RID: 210325 RVA: 0x00E6535C File Offset: 0x00E6355C
		private void HandleOnSelectInstanceIdChallenge(int instanceId)
		{
			if (InstanceDungeonEntranceConfig.Instance.GetEntranceIdByInstanceId(instanceId) != 9000)
			{
				return;
			}
			SolarSpeedModel instance = SolarSpeedModel.Instance;
			instance.SyncInstanceClicked(instanceId);
			EventSystem.Instance.Emit<int>(EEventName.OnChallengeInstanceRedDot, instanceId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, instance.CurrentActivityId);
		}

		// Token: 0x06033596 RID: 210326 RVA: 0x00E653B0 File Offset: 0x00E635B0
		private void HandleCloseInstanceEntrancePositively(int entranceId)
		{
			if (entranceId != 9000)
			{
				return;
			}
			BlackScreenController.Instance.AddBlackScreen("Start", "SolarSpeed", "Black", "Default");
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				BlackScreenController.Instance.RemoveBlackScreen("Close", "SolarSpeed", "Default");
			}, 300f, null, null, true, 1f);
		}

		// Token: 0x170063FE RID: 25598
		// (get) Token: 0x06033597 RID: 210327 RVA: 0x00E6541B File Offset: 0x00E6361B
		public static ActivitySolarSpeedController Instance
		{
			get
			{
				return ActivitySolarSpeedController._Instance;
			}
		}

		// Token: 0x06033598 RID: 210328 RVA: 0x00E65422 File Offset: 0x00E63622
		public static ActivitySolarSpeedController GetOrCreateInstance()
		{
			if (ActivitySolarSpeedController._Instance == null)
			{
				ActivitySolarSpeedController.CreateInstance();
			}
			return ActivitySolarSpeedController._Instance;
		}

		// Token: 0x06033599 RID: 210329 RVA: 0x00E65436 File Offset: 0x00E63636
		public static bool CreateInstance()
		{
			if (ActivitySolarSpeedController._Instance != null)
			{
				return true;
			}
			ActivitySolarSpeedController._Instance = new ActivitySolarSpeedController();
			return true;
		}

		// Token: 0x0603359A RID: 210330 RVA: 0x00E6544C File Offset: 0x00E6364C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603359B RID: 210331 RVA: 0x00E6544E File Offset: 0x00E6364E
		public static void ResetStaticDefaultValue()
		{
			ActivitySolarSpeedController._Instance = null;
		}

		// Token: 0x0603359C RID: 210332 RVA: 0x00E65456 File Offset: 0x00E63656
		static ActivitySolarSpeedController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivitySolarSpeedController.CreateStaticDefaultValue), new Action(ActivitySolarSpeedController.ResetStaticDefaultValue));
		}

		// Token: 0x0603359E RID: 210334 RVA: 0x00E6547D File Offset: 0x00E6367D
		[CompilerGenerated]
		internal static void <HandleClickNextInResultView>g__OnClickQuit|15_0(int _)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x0401B4B3 RID: 111795
		[Nullable(2)]
		private static ActivitySolarSpeedController _Instance;
	}
}
