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
	// Token: 0x020060A7 RID: 24743
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivitySolarSpeedController : ActivityControllerBase
	{
		// Token: 0x0603E8BD RID: 256189 RVA: 0x00F1E20E File Offset: 0x00F1C40E
		protected override void OnOpenView(ActivityBaseData data)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
		}

		// Token: 0x0603E8BE RID: 256190 RVA: 0x00F1E226 File Offset: 0x00F1C426
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_GongduolaOnlineGuide";
		}

		// Token: 0x0603E8BF RID: 256191 RVA: 0x00F1E22D File Offset: 0x00F1C42D
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySolarSpeedSubView();
		}

		// Token: 0x0603E8C0 RID: 256192 RVA: 0x00F1E234 File Offset: 0x00F1C434
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return SolarSpeedModel.Instance.ActivityData;
		}

		// Token: 0x0603E8C1 RID: 256193 RVA: 0x00F1E240 File Offset: 0x00F1C440
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603E8C2 RID: 256194 RVA: 0x00F1E243 File Offset: 0x00F1C443
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.TeamParkourTaskNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleTeamParkourTaskNotify));
			Net.Instance.Register(ENotifyMessageId.TeamParkourSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleTeamParkourSettleNotify));
		}

		// Token: 0x0603E8C3 RID: 256195 RVA: 0x00F1E27D File Offset: 0x00F1C47D
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.TeamParkourTaskNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeamParkourSettleNotify);
		}

		// Token: 0x0603E8C4 RID: 256196 RVA: 0x00F1E29F File Offset: 0x00F1C49F
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.OnSelectInstanceIdChallenge, new Action<int>(this.HandleOnSelectInstanceIdChallenge));
			EventSystem.Instance.Add<int>(EEventName.CloseInstanceEntrancePositively, new Action<int>(this.HandleCloseInstanceEntrancePositively));
		}

		// Token: 0x0603E8C5 RID: 256197 RVA: 0x00F1E2D9 File Offset: 0x00F1C4D9
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnSelectInstanceIdChallenge, new Action<int>(this.HandleOnSelectInstanceIdChallenge));
			EventSystem.Instance.Remove(EEventName.CloseInstanceEntrancePositively, new Action<int>(this.HandleCloseInstanceEntrancePositively));
		}

		// Token: 0x0603E8C6 RID: 256198 RVA: 0x00F1E314 File Offset: 0x00F1C514
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

		// Token: 0x0603E8C7 RID: 256199 RVA: 0x00F1E368 File Offset: 0x00F1C568
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

		// Token: 0x0603E8C8 RID: 256200 RVA: 0x00F1E3AB File Offset: 0x00F1C5AB
		public void SyncCurrentChosenLevelId(int id)
		{
			SolarSpeedModel.Instance.SetCurrentChosenTabInRewardView(id);
		}

		// Token: 0x0603E8C9 RID: 256201 RVA: 0x00F1E3B8 File Offset: 0x00F1C5B8
		public void HandleConfirmClickInActivitySubView()
		{
			InstanceDungeonEntranceController.Instance.EnterEntrance(9000, 0, null);
		}

		// Token: 0x0603E8CA RID: 256202 RVA: 0x00F1E3CC File Offset: 0x00F1C5CC
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

		// Token: 0x0603E8CB RID: 256203 RVA: 0x00F1E41D File Offset: 0x00F1C61D
		public void HandleClickPlayerInResultView(int playerId)
		{
			FriendController.Instance.RequestFriendApplyAddSend(playerId, FriendApplyWay.RecentlyTeam);
		}

		// Token: 0x0603E8CC RID: 256204 RVA: 0x00F1E42C File Offset: 0x00F1C62C
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

		// Token: 0x0603E8CD RID: 256205 RVA: 0x00F1E4B7 File Offset: 0x00F1C6B7
		[NullableContext(2)]
		public string GetInstanceSubtitleTextIdByInstanceId(int instanceId)
		{
			return SolarSpeedModel.Instance.GetInstanceSubtitleTextIdByInstanceId(instanceId);
		}

		// Token: 0x0603E8CE RID: 256206 RVA: 0x00F1E4C4 File Offset: 0x00F1C6C4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceSubtitleArgsByInstanceId(int instanceId)
		{
			return SolarSpeedModel.Instance.GetInstanceSubtitleArgsByInstanceId(instanceId);
		}

		// Token: 0x0603E8CF RID: 256207 RVA: 0x00F1E4D4 File Offset: 0x00F1C6D4
		[NullableContext(2)]
		private void HandleTeamParkourTaskNotify(IMessage __msg, Net.CallbackStatus _)
		{
			TeamParkourTaskNotify msg = (TeamParkourTaskNotify)__msg;
			SolarSpeedModel.Instance.SyncTeamParkourTaskNotify(msg);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, SolarSpeedModel.Instance.CurrentActivityId);
		}

		// Token: 0x0603E8D0 RID: 256208 RVA: 0x00F1E510 File Offset: 0x00F1C710
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

		// Token: 0x0603E8D1 RID: 256209 RVA: 0x00F1E598 File Offset: 0x00F1C798
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

		// Token: 0x0603E8D2 RID: 256210 RVA: 0x00F1E5EC File Offset: 0x00F1C7EC
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

		// Token: 0x1700909C RID: 37020
		// (get) Token: 0x0603E8D3 RID: 256211 RVA: 0x00F1E657 File Offset: 0x00F1C857
		public static ActivitySolarSpeedController Instance
		{
			get
			{
				return ActivitySolarSpeedController._Instance;
			}
		}

		// Token: 0x0603E8D4 RID: 256212 RVA: 0x00F1E65E File Offset: 0x00F1C85E
		public static ActivitySolarSpeedController GetOrCreateInstance()
		{
			if (ActivitySolarSpeedController._Instance == null)
			{
				ActivitySolarSpeedController.CreateInstance();
			}
			return ActivitySolarSpeedController._Instance;
		}

		// Token: 0x0603E8D5 RID: 256213 RVA: 0x00F1E672 File Offset: 0x00F1C872
		public static bool CreateInstance()
		{
			if (ActivitySolarSpeedController._Instance != null)
			{
				return true;
			}
			ActivitySolarSpeedController._Instance = new ActivitySolarSpeedController();
			return true;
		}

		// Token: 0x0603E8D6 RID: 256214 RVA: 0x00F1E688 File Offset: 0x00F1C888
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E8D7 RID: 256215 RVA: 0x00F1E68A File Offset: 0x00F1C88A
		public static void ResetStaticDefaultValue()
		{
			ActivitySolarSpeedController._Instance = null;
		}

		// Token: 0x0603E8D8 RID: 256216 RVA: 0x00F1E692 File Offset: 0x00F1C892
		static ActivitySolarSpeedController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivitySolarSpeedController.CreateStaticDefaultValue), new Action(ActivitySolarSpeedController.ResetStaticDefaultValue));
		}

		// Token: 0x0603E8DA RID: 256218 RVA: 0x00F1E6B9 File Offset: 0x00F1C8B9
		[CompilerGenerated]
		internal static void <HandleClickNextInResultView>g__OnClickQuit|15_0(int _)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x04020B86 RID: 134022
		[Nullable(2)]
		private static ActivitySolarSpeedController _Instance;
	}
}
