using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042BC RID: 17084
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityPermanentRogueController : ActivityControllerBase
	{
		// Token: 0x0602B3F2 RID: 177138 RVA: 0x00C2665B File Offset: 0x00C2485B
		[NullableContext(1)]
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0602B3F3 RID: 177139 RVA: 0x00C2665D File Offset: 0x00C2485D
		[NullableContext(1)]
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityRogue23Main";
		}

		// Token: 0x0602B3F4 RID: 177140 RVA: 0x00C26664 File Offset: 0x00C24864
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			ActivityPermanentRogueController.<OnOpenSubView>d__6 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>4__this = this;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<ActivityPermanentRogueController.<OnOpenSubView>d__6>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x0602B3F5 RID: 177141 RVA: 0x00C266A7 File Offset: 0x00C248A7
		[NullableContext(1)]
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewPermanentRogue();
		}

		// Token: 0x0602B3F6 RID: 177142 RVA: 0x00C266AE File Offset: 0x00C248AE
		[NullableContext(1)]
		[PreserveBaseOverrides]
		protected new virtual ActivityPermanentRogueData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			this.ActivityData = new ActivityPermanentRogueData();
			return this.ActivityData;
		}

		// Token: 0x0602B3F7 RID: 177143 RVA: 0x00C266CD File Offset: 0x00C248CD
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0602B3F8 RID: 177144 RVA: 0x00C266D0 File Offset: 0x00C248D0
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RogueResIllustrationUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResIllustrationUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResTaskUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResCurrencyNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResCurrencyNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResEndingUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResEndingUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResCurrencyUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResCurrencyUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResTotalShopItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResTotalShopItemUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResTalentUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResTalentUnlockNotify));
		}

		// Token: 0x0602B3F9 RID: 177145 RVA: 0x00C267A4 File Offset: 0x00C249A4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RogueResIllustrationUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResCurrencyNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResEndingUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResCurrencyUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResTotalShopItemUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResTalentUnlockNotify);
		}

		// Token: 0x0602B3FA RID: 177146 RVA: 0x00C26821 File Offset: 0x00C24A21
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoading));
		}

		// Token: 0x0602B3FB RID: 177147 RVA: 0x00C2683F File Offset: 0x00C24A3F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoading));
		}

		// Token: 0x0602B3FC RID: 177148 RVA: 0x00C26860 File Offset: 0x00C24A60
		[NullableContext(1)]
		public new void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			GenericPromptController.Instance.ShowPromptByItsType(EPromptSubViewType.RogueResOpen, null, null, null, null, null, null);
		}

		// Token: 0x0602B3FD RID: 177149 RVA: 0x00C26888 File Offset: 0x00C24A88
		private void OnCloseLoading()
		{
			if (!this.IsFromRogue)
			{
				return;
			}
			this.IsFromRogue = false;
			RogueResDungeonConfig? config = ConfigRogueResDungeonConfigById.GetConfig(this.DungeonId, true);
			if (config == null)
			{
				return;
			}
			int seasonId = config.Value.SeasonId;
			UiManager.Instance.OpenView(EUiViewName.RogueSeasonEntranceView, seasonId, null);
		}

		// Token: 0x0602B3FE RID: 177150 RVA: 0x00C268E4 File Offset: 0x00C24AE4
		public void SetReturnToWorld(int dungeonId)
		{
			if (ConfigRogueResDungeonConfigById.GetConfig(dungeonId, true) == null)
			{
				return;
			}
			this.DungeonId = dungeonId;
			this.IsFromRogue = true;
		}

		// Token: 0x0602B3FF RID: 177151 RVA: 0x00C26914 File Offset: 0x00C24B14
		public ActivityRogueData GetCurrentActivityData()
		{
			ActivityRogueData activityRogueData = ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityRogueData;
			if (activityRogueData == null)
			{
				return null;
			}
			return activityRogueData;
		}

		// Token: 0x0602B400 RID: 177152 RVA: 0x00C26940 File Offset: 0x00C24B40
		private void OnRogueResIllustrationUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResIllustrationUpdateNotify updateData = (RogueResIllustrationUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.GetActivityData().UpdateIllustrateState(updateData);
		}

		// Token: 0x0602B401 RID: 177153 RVA: 0x00C26964 File Offset: 0x00C24B64
		[NullableContext(1)]
		public void RequestIllustrationAward(int[] configId)
		{
			RogueResIllustrationAwardRequest rogueResIllustrationAwardRequest = RogueResIllustrationAwardRequest.Create();
			rogueResIllustrationAwardRequest.ConfigIds.AddRange(configId);
			Net.Instance.Call(ERequestMessageId.RogueResIllustrationAwardRequest, rogueResIllustrationAwardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResIllustrationAwardResponse rogueResIllustrationAwardResponse = (RogueResIllustrationAwardResponse)msg;
				if (rogueResIllustrationAwardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResIllustrationAwardResponse.ErrorCode, 24417, null, true, true);
					return;
				}
				if (rogueResIllustrationAwardResponse.IsFull)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Text_EchoLimit_Text", Array.Empty<object>());
				}
				this.ActivityData.SetIllustratedRewardGot(configId);
				EventSystem.Instance.Emit(EEventName.PermanentRogueRewardUpdate);
				HashSet<int> hashSet = new HashSet<int>();
				List<int> list = new List<int>();
				foreach (int num in configId)
				{
					RogueResCollection value = ConfigRogueResCollectionByIdKey.GetConfig(num, true).Value;
					if (value.Type == 0)
					{
						list = this.ActivityData.GetTokenInSeason(num);
					}
					else if (value.Type == 1)
					{
						list = this.ActivityData.GetEventNormalInSeason(num);
					}
					else
					{
						list = this.ActivityData.GetEventMapInSeason(num);
					}
					foreach (int item in list)
					{
						hashSet.Add(item);
					}
				}
				foreach (int p in list)
				{
					EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, p);
				}
			}, 0);
		}

		// Token: 0x0602B402 RID: 177154 RVA: 0x00C269BC File Offset: 0x00C24BBC
		public void RequestTaskAward(int configId)
		{
			RogueResTaskAwardRequest rogueResTaskAwardRequest = RogueResTaskAwardRequest.Create();
			rogueResTaskAwardRequest.ConfigId = configId;
			Net.Instance.Call(ERequestMessageId.RogueResTaskAwardRequest, rogueResTaskAwardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResTaskAwardResponse rogueResTaskAwardResponse = (RogueResTaskAwardResponse)msg;
				if (rogueResTaskAwardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResTaskAwardResponse.ErrorCode, 29739, null, true, true);
					return;
				}
				ActivityPermanentRogueModel.Instance.GetActivityData().SetTaskRewardGot(configId);
				EventSystem.Instance.Emit(EEventName.PermanentRogueRewardUpdate);
			}, 0);
		}

		// Token: 0x0602B403 RID: 177155 RVA: 0x00C26A08 File Offset: 0x00C24C08
		public void RequestEnterDungeon(int dungeonId)
		{
			RogueResInstStartRequest rogueResInstStartRequest = RogueResInstStartRequest.Create();
			rogueResInstStartRequest.InstId = dungeonId;
			Net.Instance.Call(ERequestMessageId.RogueResInstStartRequest, rogueResInstStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResInstStartResponse rogueResInstStartResponse = (RogueResInstStartResponse)msg;
				if (rogueResInstStartResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResInstStartResponse.ErrorCode, 29103, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0602B404 RID: 177156 RVA: 0x00C26A54 File Offset: 0x00C24C54
		private void OnRogueResTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResTaskUpdateNotify updateData = (RogueResTaskUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.GetActivityData().UpdateTaskNotify(updateData);
		}

		// Token: 0x0602B405 RID: 177157 RVA: 0x00C26A78 File Offset: 0x00C24C78
		private void OnRogueResCurrencyNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResCurrencyNotify rogueResCurrencyNotify = (RogueResCurrencyNotify)msg;
			ActivityPermanentRogueModel.Instance.InitCurrency(rogueResCurrencyNotify.CurrencyDict);
		}

		// Token: 0x0602B406 RID: 177158 RVA: 0x00C26A9C File Offset: 0x00C24C9C
		private void OnRogueResCurrencyUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResCurrencyUpdateNotify rogueResCurrencyUpdateNotify = (RogueResCurrencyUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.UpdateCurrency(rogueResCurrencyUpdateNotify.CurrencyUpdateDict, new int?(rogueResCurrencyUpdateNotify.EventType));
		}

		// Token: 0x0602B407 RID: 177159 RVA: 0x00C26ACC File Offset: 0x00C24CCC
		private void OnRogueResTotalShopItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResTotalShopItemUpdateNotify rogueResTotalShopItemUpdateNotify = (RogueResTotalShopItemUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.UpdateTotalShopItem(rogueResTotalShopItemUpdateNotify.SeasonId, rogueResTotalShopItemUpdateNotify.TotalShopItem);
		}

		// Token: 0x0602B408 RID: 177160 RVA: 0x00C26AF8 File Offset: 0x00C24CF8
		private void OnRogueResTalentUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResTalentUnlockNotify rogueResTalentUnlockNotify = (RogueResTalentUnlockNotify)msg;
			ActivityPermanentRogueModel.Instance.UpdateSkillTreeUnlockState(rogueResTalentUnlockNotify.SkillId);
		}

		// Token: 0x0602B409 RID: 177161 RVA: 0x00C26B1C File Offset: 0x00C24D1C
		public UniTask RequestRogueResTalentSkillLevel(int skillId)
		{
			ActivityPermanentRogueController.<RequestRogueResTalentSkillLevel>d__27 <RequestRogueResTalentSkillLevel>d__;
			<RequestRogueResTalentSkillLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRogueResTalentSkillLevel>d__.skillId = skillId;
			<RequestRogueResTalentSkillLevel>d__.<>1__state = -1;
			<RequestRogueResTalentSkillLevel>d__.<>t__builder.Start<ActivityPermanentRogueController.<RequestRogueResTalentSkillLevel>d__27>(ref <RequestRogueResTalentSkillLevel>d__);
			return <RequestRogueResTalentSkillLevel>d__.<>t__builder.Task;
		}

		// Token: 0x0602B40A RID: 177162 RVA: 0x00C26B60 File Offset: 0x00C24D60
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<RogueResLastInstInfoResponse> RequestRogueResLastInstInfo()
		{
			ActivityPermanentRogueController.<RequestRogueResLastInstInfo>d__28 <RequestRogueResLastInstInfo>d__;
			<RequestRogueResLastInstInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<RogueResLastInstInfoResponse>.Create();
			<RequestRogueResLastInstInfo>d__.<>1__state = -1;
			<RequestRogueResLastInstInfo>d__.<>t__builder.Start<ActivityPermanentRogueController.<RequestRogueResLastInstInfo>d__28>(ref <RequestRogueResLastInstInfo>d__);
			return <RequestRogueResLastInstInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0602B40B RID: 177163 RVA: 0x00C26B9C File Offset: 0x00C24D9C
		private void OnRogueResEndingUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResEndingUpdateNotify message = (RogueResEndingUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.GetActivityData().UpdateEndingNotify(message);
		}

		// Token: 0x0602B40C RID: 177164 RVA: 0x00C26BC0 File Offset: 0x00C24DC0
		public void RequestRogueResEndingReward(int seasonId, int configId, int index)
		{
			RogueResEndingRewardRequest rogueResEndingRewardRequest = RogueResEndingRewardRequest.Create();
			rogueResEndingRewardRequest.SeasonId = seasonId;
			rogueResEndingRewardRequest.Index = index;
			Net.Instance.Call(ERequestMessageId.RogueResEndingRewardRequest, rogueResEndingRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResEndingRewardResponse rogueResEndingRewardResponse = (RogueResEndingRewardResponse)msg;
				if (rogueResEndingRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResEndingRewardResponse.ErrorCode, 17493, null, true, true);
					return;
				}
				ActivityPermanentRogueModel.Instance.SetEndingAwardData(configId);
				IActivityRewardViewData endingAwardViewData = ActivityPermanentRogueModel.Instance.GetEndingAwardViewData(seasonId);
				EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, endingAwardViewData);
				EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, seasonId);
			}, 0);
		}

		// Token: 0x0602B40D RID: 177165 RVA: 0x00C26C18 File Offset: 0x00C24E18
		[NullableContext(0)]
		public UniTask<bool> OpenSeasonMainView()
		{
			ActivityPermanentRogueController.<OpenSeasonMainView>d__31 <OpenSeasonMainView>d__;
			<OpenSeasonMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenSeasonMainView>d__.<>1__state = -1;
			<OpenSeasonMainView>d__.<>t__builder.Start<ActivityPermanentRogueController.<OpenSeasonMainView>d__31>(ref <OpenSeasonMainView>d__);
			return <OpenSeasonMainView>d__.<>t__builder.Task;
		}

		// Token: 0x170056CE RID: 22222
		// (get) Token: 0x0602B40E RID: 177166 RVA: 0x00C26C53 File Offset: 0x00C24E53
		[Nullable(1)]
		public static ActivityPermanentRogueController Instance
		{
			[NullableContext(1)]
			get
			{
				return ActivityPermanentRogueController._Instance;
			}
		}

		// Token: 0x0602B40F RID: 177167 RVA: 0x00C26C5A File Offset: 0x00C24E5A
		[NullableContext(1)]
		public static ActivityPermanentRogueController GetOrCreateInstance()
		{
			if (ActivityPermanentRogueController._Instance == null)
			{
				ActivityPermanentRogueController.CreateInstance();
			}
			return ActivityPermanentRogueController._Instance;
		}

		// Token: 0x0602B410 RID: 177168 RVA: 0x00C26C6E File Offset: 0x00C24E6E
		public static bool CreateInstance()
		{
			if (ActivityPermanentRogueController._Instance != null)
			{
				return true;
			}
			ActivityPermanentRogueController._Instance = new ActivityPermanentRogueController();
			return true;
		}

		// Token: 0x0602B411 RID: 177169 RVA: 0x00C26C84 File Offset: 0x00C24E84
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B412 RID: 177170 RVA: 0x00C26C86 File Offset: 0x00C24E86
		public static void ResetStaticDefaultValue()
		{
			ActivityPermanentRogueController._Instance = null;
		}

		// Token: 0x0602B413 RID: 177171 RVA: 0x00C26C8E File Offset: 0x00C24E8E
		static ActivityPermanentRogueController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPermanentRogueController.CreateStaticDefaultValue), new Action(ActivityPermanentRogueController.ResetStaticDefaultValue));
		}

		// Token: 0x04017556 RID: 95574
		public int ActivityId;

		// Token: 0x04017557 RID: 95575
		private int DungeonId;

		// Token: 0x04017558 RID: 95576
		private bool IsFromRogue;

		// Token: 0x04017559 RID: 95577
		private ActivityPermanentRogueData ActivityData;

		// Token: 0x0401755A RID: 95578
		private static ActivityPermanentRogueController _Instance;
	}
}
