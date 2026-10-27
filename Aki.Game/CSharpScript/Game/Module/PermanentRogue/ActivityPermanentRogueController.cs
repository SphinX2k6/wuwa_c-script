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
	// Token: 0x020052EC RID: 21228
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityPermanentRogueController : ActivityControllerBase
	{
		// Token: 0x060364F7 RID: 222455 RVA: 0x00CD8E9B File Offset: 0x00CD709B
		[NullableContext(1)]
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060364F8 RID: 222456 RVA: 0x00CD8E9D File Offset: 0x00CD709D
		[NullableContext(1)]
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityRogue23Main";
		}

		// Token: 0x060364F9 RID: 222457 RVA: 0x00CD8EA4 File Offset: 0x00CD70A4
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

		// Token: 0x060364FA RID: 222458 RVA: 0x00CD8EE7 File Offset: 0x00CD70E7
		[NullableContext(1)]
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewPermanentRogue();
		}

		// Token: 0x060364FB RID: 222459 RVA: 0x00CD8EEE File Offset: 0x00CD70EE
		[NullableContext(1)]
		[PreserveBaseOverrides]
		protected new virtual ActivityPermanentRogueData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			this.ActivityData = new ActivityPermanentRogueData();
			return this.ActivityData;
		}

		// Token: 0x060364FC RID: 222460 RVA: 0x00CD8F0D File Offset: 0x00CD710D
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060364FD RID: 222461 RVA: 0x00CD8F10 File Offset: 0x00CD7110
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

		// Token: 0x060364FE RID: 222462 RVA: 0x00CD8FE4 File Offset: 0x00CD71E4
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

		// Token: 0x060364FF RID: 222463 RVA: 0x00CD9061 File Offset: 0x00CD7261
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoading));
		}

		// Token: 0x06036500 RID: 222464 RVA: 0x00CD907F File Offset: 0x00CD727F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoading));
		}

		// Token: 0x06036501 RID: 222465 RVA: 0x00CD90A0 File Offset: 0x00CD72A0
		[NullableContext(1)]
		public new void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			GenericPromptController.Instance.ShowPromptByItsType(EPromptSubViewType.RogueResOpen, null, null, null, null, null, null);
		}

		// Token: 0x06036502 RID: 222466 RVA: 0x00CD90C8 File Offset: 0x00CD72C8
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

		// Token: 0x06036503 RID: 222467 RVA: 0x00CD9124 File Offset: 0x00CD7324
		public void SetReturnToWorld(int dungeonId)
		{
			if (ConfigRogueResDungeonConfigById.GetConfig(dungeonId, true) == null)
			{
				return;
			}
			this.DungeonId = dungeonId;
			this.IsFromRogue = true;
		}

		// Token: 0x06036504 RID: 222468 RVA: 0x00CD9154 File Offset: 0x00CD7354
		public ActivityRogueData GetCurrentActivityData()
		{
			ActivityRogueData activityRogueData = ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityRogueData;
			if (activityRogueData == null)
			{
				return null;
			}
			return activityRogueData;
		}

		// Token: 0x06036505 RID: 222469 RVA: 0x00CD9180 File Offset: 0x00CD7380
		private void OnRogueResIllustrationUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResIllustrationUpdateNotify updateData = (RogueResIllustrationUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.GetActivityData().UpdateIllustrateState(updateData);
		}

		// Token: 0x06036506 RID: 222470 RVA: 0x00CD91A4 File Offset: 0x00CD73A4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResIllustrationAwardResponse.ErrorCode, 23918, null, true, true);
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

		// Token: 0x06036507 RID: 222471 RVA: 0x00CD91FC File Offset: 0x00CD73FC
		public void RequestTaskAward(int configId)
		{
			RogueResTaskAwardRequest rogueResTaskAwardRequest = RogueResTaskAwardRequest.Create();
			rogueResTaskAwardRequest.ConfigId = configId;
			Net.Instance.Call(ERequestMessageId.RogueResTaskAwardRequest, rogueResTaskAwardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResTaskAwardResponse rogueResTaskAwardResponse = (RogueResTaskAwardResponse)msg;
				if (rogueResTaskAwardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResTaskAwardResponse.ErrorCode, 24954, null, true, true);
					return;
				}
				ActivityPermanentRogueModel.Instance.GetActivityData().SetTaskRewardGot(configId);
				EventSystem.Instance.Emit(EEventName.PermanentRogueRewardUpdate);
			}, 0);
		}

		// Token: 0x06036508 RID: 222472 RVA: 0x00CD9248 File Offset: 0x00CD7448
		public void RequestEnterDungeon(int dungeonId)
		{
			RogueResInstStartRequest rogueResInstStartRequest = RogueResInstStartRequest.Create();
			rogueResInstStartRequest.InstId = dungeonId;
			Net.Instance.Call(ERequestMessageId.RogueResInstStartRequest, rogueResInstStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueResInstStartResponse rogueResInstStartResponse = (RogueResInstStartResponse)msg;
				if (rogueResInstStartResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResInstStartResponse.ErrorCode, 15616, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06036509 RID: 222473 RVA: 0x00CD9294 File Offset: 0x00CD7494
		private void OnRogueResTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResTaskUpdateNotify updateData = (RogueResTaskUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.GetActivityData().UpdateTaskNotify(updateData);
		}

		// Token: 0x0603650A RID: 222474 RVA: 0x00CD92B8 File Offset: 0x00CD74B8
		private void OnRogueResCurrencyNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResCurrencyNotify rogueResCurrencyNotify = (RogueResCurrencyNotify)msg;
			ActivityPermanentRogueModel.Instance.InitCurrency(rogueResCurrencyNotify.CurrencyDict);
		}

		// Token: 0x0603650B RID: 222475 RVA: 0x00CD92DC File Offset: 0x00CD74DC
		private void OnRogueResCurrencyUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResCurrencyUpdateNotify rogueResCurrencyUpdateNotify = (RogueResCurrencyUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.UpdateCurrency(rogueResCurrencyUpdateNotify.CurrencyUpdateDict, new int?(rogueResCurrencyUpdateNotify.EventType));
		}

		// Token: 0x0603650C RID: 222476 RVA: 0x00CD930C File Offset: 0x00CD750C
		private void OnRogueResTotalShopItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResTotalShopItemUpdateNotify rogueResTotalShopItemUpdateNotify = (RogueResTotalShopItemUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.UpdateTotalShopItem(rogueResTotalShopItemUpdateNotify.SeasonId, rogueResTotalShopItemUpdateNotify.TotalShopItem);
		}

		// Token: 0x0603650D RID: 222477 RVA: 0x00CD9338 File Offset: 0x00CD7538
		private void OnRogueResTalentUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResTalentUnlockNotify rogueResTalentUnlockNotify = (RogueResTalentUnlockNotify)msg;
			ActivityPermanentRogueModel.Instance.UpdateSkillTreeUnlockState(rogueResTalentUnlockNotify.SkillId);
		}

		// Token: 0x0603650E RID: 222478 RVA: 0x00CD935C File Offset: 0x00CD755C
		public UniTask RequestRogueResTalentSkillLevel(int skillId)
		{
			ActivityPermanentRogueController.<RequestRogueResTalentSkillLevel>d__27 <RequestRogueResTalentSkillLevel>d__;
			<RequestRogueResTalentSkillLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRogueResTalentSkillLevel>d__.skillId = skillId;
			<RequestRogueResTalentSkillLevel>d__.<>1__state = -1;
			<RequestRogueResTalentSkillLevel>d__.<>t__builder.Start<ActivityPermanentRogueController.<RequestRogueResTalentSkillLevel>d__27>(ref <RequestRogueResTalentSkillLevel>d__);
			return <RequestRogueResTalentSkillLevel>d__.<>t__builder.Task;
		}

		// Token: 0x0603650F RID: 222479 RVA: 0x00CD93A0 File Offset: 0x00CD75A0
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

		// Token: 0x06036510 RID: 222480 RVA: 0x00CD93DC File Offset: 0x00CD75DC
		private void OnRogueResEndingUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueResEndingUpdateNotify message = (RogueResEndingUpdateNotify)msg;
			ActivityPermanentRogueModel.Instance.GetActivityData().UpdateEndingNotify(message);
		}

		// Token: 0x06036511 RID: 222481 RVA: 0x00CD9400 File Offset: 0x00CD7600
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueResEndingRewardResponse.ErrorCode, 24880, null, true, true);
					return;
				}
				ActivityPermanentRogueModel.Instance.SetEndingAwardData(configId);
				IActivityRewardViewData endingAwardViewData = ActivityPermanentRogueModel.Instance.GetEndingAwardViewData(seasonId);
				EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, endingAwardViewData);
				EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, seasonId);
			}, 0);
		}

		// Token: 0x06036512 RID: 222482 RVA: 0x00CD9458 File Offset: 0x00CD7658
		[NullableContext(0)]
		public UniTask<bool> OpenSeasonMainView()
		{
			ActivityPermanentRogueController.<OpenSeasonMainView>d__31 <OpenSeasonMainView>d__;
			<OpenSeasonMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenSeasonMainView>d__.<>1__state = -1;
			<OpenSeasonMainView>d__.<>t__builder.Start<ActivityPermanentRogueController.<OpenSeasonMainView>d__31>(ref <OpenSeasonMainView>d__);
			return <OpenSeasonMainView>d__.<>t__builder.Task;
		}

		// Token: 0x1700830E RID: 33550
		// (get) Token: 0x06036513 RID: 222483 RVA: 0x00CD9493 File Offset: 0x00CD7693
		[Nullable(1)]
		public static ActivityPermanentRogueController Instance
		{
			[NullableContext(1)]
			get
			{
				return ActivityPermanentRogueController._Instance;
			}
		}

		// Token: 0x06036514 RID: 222484 RVA: 0x00CD949A File Offset: 0x00CD769A
		[NullableContext(1)]
		public static ActivityPermanentRogueController GetOrCreateInstance()
		{
			if (ActivityPermanentRogueController._Instance == null)
			{
				ActivityPermanentRogueController.CreateInstance();
			}
			return ActivityPermanentRogueController._Instance;
		}

		// Token: 0x06036515 RID: 222485 RVA: 0x00CD94AE File Offset: 0x00CD76AE
		public static bool CreateInstance()
		{
			if (ActivityPermanentRogueController._Instance != null)
			{
				return true;
			}
			ActivityPermanentRogueController._Instance = new ActivityPermanentRogueController();
			return true;
		}

		// Token: 0x06036516 RID: 222486 RVA: 0x00CD94C4 File Offset: 0x00CD76C4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036517 RID: 222487 RVA: 0x00CD94C6 File Offset: 0x00CD76C6
		public static void ResetStaticDefaultValue()
		{
			ActivityPermanentRogueController._Instance = null;
		}

		// Token: 0x06036518 RID: 222488 RVA: 0x00CD94CE File Offset: 0x00CD76CE
		static ActivityPermanentRogueController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPermanentRogueController.CreateStaticDefaultValue), new Action(ActivityPermanentRogueController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CB21 RID: 117537
		public int ActivityId;

		// Token: 0x0401CB22 RID: 117538
		private int DungeonId;

		// Token: 0x0401CB23 RID: 117539
		private bool IsFromRogue;

		// Token: 0x0401CB24 RID: 117540
		private ActivityPermanentRogueData ActivityData;

		// Token: 0x0401CB25 RID: 117541
		private static ActivityPermanentRogueController _Instance;
	}
}
