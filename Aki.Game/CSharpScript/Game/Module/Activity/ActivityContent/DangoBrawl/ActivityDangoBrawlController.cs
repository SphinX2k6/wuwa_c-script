using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006754 RID: 26452
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityDangoBrawlController : ActivityControllerBase
	{
		// Token: 0x17009666 RID: 38502
		// (get) Token: 0x06042047 RID: 270407 RVA: 0x01003E0C File Offset: 0x0100200C
		public int MyActivityId
		{
			get
			{
				return this.ActivityId;
			}
		}

		// Token: 0x17009667 RID: 38503
		// (get) Token: 0x06042048 RID: 270408 RVA: 0x01003E14 File Offset: 0x01002014
		[Nullable(2)]
		public ActivityDangoBrawlData MyActivityData
		{
			[NullableContext(2)]
			get
			{
				return this.ActivityData;
			}
		}

		// Token: 0x06042049 RID: 270409 RVA: 0x01003E1C File Offset: 0x0100201C
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipDangoBrawlView, null, null);
		}

		// Token: 0x0604204A RID: 270410 RVA: 0x01003E2F File Offset: 0x0100202F
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0604204B RID: 270411 RVA: 0x01003E31 File Offset: 0x01002031
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityDangoBrawlGuide";
		}

		// Token: 0x0604204C RID: 270412 RVA: 0x01003E38 File Offset: 0x01002038
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewDangoBrawl();
		}

		// Token: 0x0604204D RID: 270413 RVA: 0x01003E3F File Offset: 0x0100203F
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			this.ActivityData = new ActivityDangoBrawlData();
			this.ActivityData.Init(data);
			return this.ActivityData;
		}

		// Token: 0x0604204E RID: 270414 RVA: 0x01003E6C File Offset: 0x0100206C
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			foreach (EUiViewName viewName in new List<EUiViewName>
			{
				EUiViewName.DangoBrawlMainView,
				EUiViewName.DangoBrawlRewardsView,
				EUiViewName.DangoBrawlLevelView,
				EUiViewName.DangoBrawlRoleView,
				EUiViewName.DangoBrawlRoleHandBookView,
				EUiViewName.DangoBrawlHandBookView,
				EUiViewName.DangoBrawlShopView
			})
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604204F RID: 270415 RVA: 0x01003F18 File Offset: 0x01002118
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			ActivityDangoBrawlController.<OnOpenSubView>d__12 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<ActivityDangoBrawlController.<OnOpenSubView>d__12>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x06042050 RID: 270416 RVA: 0x01003F5C File Offset: 0x0100215C
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnSetGameModeDataDone, new Action(this.OnGameModeDataChange));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopStateTipsClosed, new Action(this.OnDangoBrawlShopStateTipsClosed));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlThreeChooseClosed, new Action(this.OnDangoBrawlThreeChooseClosed));
		}

		// Token: 0x06042051 RID: 270417 RVA: 0x01003FDC File Offset: 0x010021DC
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.OnSetGameModeDataDone, new Action(this.OnGameModeDataChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopStateTipsClosed, new Action(this.OnDangoBrawlShopStateTipsClosed));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlThreeChooseClosed, new Action(this.OnDangoBrawlThreeChooseClosed));
		}

		// Token: 0x06042052 RID: 270418 RVA: 0x01004059 File Offset: 0x01002259
		private void OnGameModeDataChange()
		{
			this.TryInitMap();
		}

		// Token: 0x06042053 RID: 270419 RVA: 0x01004064 File Offset: 0x01002264
		private void TryInitMap()
		{
			GameModeModel instance = GameModeModel.Instance;
			InstanceDungeon? instanceDungeon;
			int? num = (instance != null) ? ((instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().InstSubType) : null) : null;
			if (!GameModeController.Instance.IsInInstance() || num == null)
			{
				return;
			}
			if (num.Value != 58)
			{
				return;
			}
			FDamageConfig fdamageConfig = new FDamageConfig();
			fdamageConfig.EnableCompactNumberFormat = true;
			fdamageConfig.DamageFormatType = EDamageFormatType.DangoBrawl;
			DamageUiController.Instance.SetUeDamageConfig(fdamageConfig, false);
		}

		// Token: 0x06042054 RID: 270420 RVA: 0x010040F7 File Offset: 0x010022F7
		private void OnWorldDone()
		{
			this.AddShowViewSplashTask();
		}

		// Token: 0x06042055 RID: 270421 RVA: 0x01004100 File Offset: 0x01002300
		private void AddShowViewSplashTask()
		{
			if (this.ActivityData == null || this.OpenViewParam.OpenViewName == EDangoBrawlViewName.Null)
			{
				return;
			}
			SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
			{
				switch (this.OpenViewParam.OpenViewName)
				{
				case EDangoBrawlViewName.MainView:
					UiManager.Instance.OpenView(EUiViewName.DangoBrawlMainView, null, null);
					break;
				case EDangoBrawlViewName.LevelView:
					UiManager.Instance.OpenView(EUiViewName.DangoBrawlLevelView, new DangoBrawlLevelViewOpenData
					{
						LevelId = new int?(this.OpenViewParam.LevelId),
						IsNormalMode = new bool?(this.OpenViewParam.IsNormalMode),
						IfReturnToMainView = true
					}, null);
					break;
				case EDangoBrawlViewName.RoleSelectView:
					UiManager.Instance.OpenView(EUiViewName.DangoBrawlRoleView, new DangoBrawlRoleViewOpenData
					{
						LevelId = new int?(this.OpenViewParam.LevelId),
						IfReturnToLevelView = true
					}, null);
					break;
				}
				this.OpenViewParam.OpenViewName = EDangoBrawlViewName.Null;
			});
			SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
		}

		// Token: 0x06042056 RID: 270422 RVA: 0x01004144 File Offset: 0x01002344
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.DangoBrawlTaskUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlTaskUpdateNotify resp = (DangoBrawlTaskUpdateNotify)msg;
				this.OnDangoBrawlTaskUpdateNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlRoleUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlRoleUnlockNotify resp = (DangoBrawlRoleUnlockNotify)msg;
				this.OnDangoBrawlRoleUnlockNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlItemUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlItemUnlockNotify resp = (DangoBrawlItemUnlockNotify)msg;
				this.OnDangoBrawlItemUnlockNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlChallengeUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlChallengeUnlockNotify resp = (DangoBrawlChallengeUnlockNotify)msg;
				this.OnDangoBrawlChallengeUnlockNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlSaveMatchBriefNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlSaveMatchBriefNotify resp = (DangoBrawlSaveMatchBriefNotify)msg;
				this.OnDangoBrawlSaveMatchBriefNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlActivityLimitCoinUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlActivityLimitCoinUpdateNotify resp = (DangoBrawlActivityLimitCoinUpdateNotify)msg;
				this.OnDangoBrawlLimitCoinUpdateNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlInstBaseNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlInstBaseNotify resp = (DangoBrawlInstBaseNotify)msg;
				this.OnDangoBrawlInstBaseNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlInstPrepareNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlInstPrepareNotify resp = (DangoBrawlInstPrepareNotify)msg;
				this.OnDangoBrawlInstPrepareNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlInstEventSelectNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlInstEventSelectNotify resp = (DangoBrawlInstEventSelectNotify)msg;
				this.OnDangoBrawlInstEventSelectNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlRoundSwitchNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlRoundSwitchNotify resp = (DangoBrawlRoundSwitchNotify)msg;
				this.OnDangoBrawlRoundSwitchNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlCoinUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlCoinUpdateNotify resp = (DangoBrawlCoinUpdateNotify)msg;
				this.OnDangoBrawlCoinUpdateNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlBagUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlBagUpdateNotify resp = (DangoBrawlBagUpdateNotify)msg;
				this.OnDangoBrawlBagUpdateNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlSettleNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlSettleNotify resp = (DangoBrawlSettleNotify)msg;
				this.OnDangoBrawlSettleNotify(resp);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlFightActionNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlFightActionNotify message = (DangoBrawlFightActionNotify)msg;
				this.OnDangoBrawlFightActionNotify(message);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlStartFightNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlStartFightNotify message = (DangoBrawlStartFightNotify)msg;
				this.OnDangoBrawlStartFightNotify(message);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlFighterAttrChangeNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlFighterAttrChangeNotify message = (DangoBrawlFighterAttrChangeNotify)msg;
				this.OnDangoBrawlFighterAttrChangeNotify(message);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlLoseCountUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlLoseCountUpdateNotify message = (DangoBrawlLoseCountUpdateNotify)msg;
				this.OnDangoBrawlLoseCountUpdateNotify(message);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlItemGiveCoinNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlItemGiveCoinNotify message = (DangoBrawlItemGiveCoinNotify)msg;
				this.OnDangoBrawlItemGiveCoinNotify(message);
			});
			Net.Instance.Register(ENotifyMessageId.DangoBrawlItemEffectShowNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlItemEffectShowNotify message = (DangoBrawlItemEffectShowNotify)msg;
				this.OnDangoBrawlItemEffectShowNotify(message);
			});
		}

		// Token: 0x06042057 RID: 270423 RVA: 0x01004368 File Offset: 0x01002568
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlRoleUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlItemUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlChallengeUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlSaveMatchBriefNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlActivityLimitCoinUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlInstBaseNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlInstPrepareNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlInstEventSelectNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlRoundSwitchNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlCoinUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlBagUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlFightActionNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlStartFightNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlFighterAttrChangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlLoseCountUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlItemGiveCoinNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DangoBrawlItemEffectShowNotify);
		}

		// Token: 0x06042058 RID: 270424 RVA: 0x010044A5 File Offset: 0x010026A5
		private void OnDangoBrawlTaskUpdateNotify(DangoBrawlTaskUpdateNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData != null) ? activityData.GetOutGameData() : null;
			if (dangoBrawlOutGameData == null)
			{
				return;
			}
			dangoBrawlOutGameData.UpdateTaskDataList(resp.Tasks.ToArray<ConditionTask>());
		}

		// Token: 0x06042059 RID: 270425 RVA: 0x010044D0 File Offset: 0x010026D0
		private void OnDangoBrawlRoleUnlockNotify(DangoBrawlRoleUnlockNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.EnsureUnlockReadInitialized();
			}
			ActivityDangoBrawlData activityData2 = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData2 != null) ? activityData2.GetOutGameData() : null;
			List<int> list = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.UpdateRoleDataList(resp.RoleIds.ToArray<int>(), true) : null;
			if (list != null && list.Count > 0)
			{
				ActivityDangoBrawlData activityData3 = this.ActivityData;
				if (activityData3 != null)
				{
					activityData3.OnNewRolesUnlocked(list);
				}
			}
			if (this.ActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
			}
		}

		// Token: 0x0604205A RID: 270426 RVA: 0x0100455C File Offset: 0x0100275C
		private void OnDangoBrawlItemUnlockNotify(DangoBrawlItemUnlockNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.EnsureUnlockReadInitialized();
			}
			ActivityDangoBrawlData activityData2 = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData2 != null) ? activityData2.GetOutGameData() : null;
			List<int> list = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.UpdateItemDataList(resp.ItemIds.ToArray<int>(), true) : null;
			if (list != null && list.Count > 0)
			{
				ActivityDangoBrawlData activityData3 = this.ActivityData;
				if (activityData3 != null)
				{
					activityData3.OnNewItemsUnlocked(list);
				}
			}
			if (this.ActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
			}
		}

		// Token: 0x0604205B RID: 270427 RVA: 0x010045E8 File Offset: 0x010027E8
		private void OnDangoBrawlChallengeUnlockNotify(DangoBrawlChallengeUnlockNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.EnsureUnlockReadInitialized();
			}
			ActivityDangoBrawlData activityData2 = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData2 != null) ? activityData2.GetOutGameData() : null;
			List<int> list = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.UpdateLevelDataList(resp.ChallengeInfos.ToArray<DangoBrawlChallengeInfo>()) : null;
			if (list != null && list.Count > 0)
			{
				ActivityDangoBrawlData activityData3 = this.ActivityData;
				if (activityData3 != null)
				{
					activityData3.OnNewLevelsUnlocked(list);
				}
			}
			if (this.ActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
			}
		}

		// Token: 0x0604205C RID: 270428 RVA: 0x01004671 File Offset: 0x01002871
		private void OnDangoBrawlSaveMatchBriefNotify(DangoBrawlSaveMatchBriefNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData != null) ? activityData.GetOutGameData() : null;
			if (dangoBrawlOutGameData == null)
			{
				return;
			}
			dangoBrawlOutGameData.UpdateSaveData(resp.SaveMatchBrief);
		}

		// Token: 0x0604205D RID: 270429 RVA: 0x01004698 File Offset: 0x01002898
		private void OnDangoBrawlLimitCoinUpdateNotify(DangoBrawlActivityLimitCoinUpdateNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData != null) ? activityData.GetOutGameData() : null;
			if (dangoBrawlOutGameData != null)
			{
				dangoBrawlOutGameData.UpdateShopCoinCost(resp.LimitCoinCost);
			}
			if (this.ActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
			}
		}

		// Token: 0x0604205E RID: 270430 RVA: 0x010046EC File Offset: 0x010028EC
		private void OnDangoBrawlInstBaseNotify(DangoBrawlInstBaseNotify resp)
		{
			GameModeController.Instance.AddWorldDoneBlocker(delegate
			{
				ActivityDangoBrawlController.<>c.<<OnDangoBrawlInstBaseNotify>b__28_0>d <<OnDangoBrawlInstBaseNotify>b__28_0>d;
				<<OnDangoBrawlInstBaseNotify>b__28_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnDangoBrawlInstBaseNotify>b__28_0>d.<>1__state = -1;
				<<OnDangoBrawlInstBaseNotify>b__28_0>d.<>t__builder.Start<ActivityDangoBrawlController.<>c.<<OnDangoBrawlInstBaseNotify>b__28_0>d>(ref <<OnDangoBrawlInstBaseNotify>b__28_0>d);
				return <<OnDangoBrawlInstBaseNotify>b__28_0>d.<>t__builder.Task;
			}, 60000);
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.ProtoInstBaseNotify(resp);
			}
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			if (instance != null)
			{
				DangoBrawlRollbackController rollbackController = instance.GetRollbackController();
				if (rollbackController != null)
				{
					rollbackController.RebuildFromServerData();
				}
			}
			this.ClearAllReqInFlight();
			this.HasThreeChoose = (resp.Phase == DangoBrawlPhase.EventSelect && resp.Event != null && resp.Event.Slots.Count > 0);
			this.ResetRoundGates();
		}

		// Token: 0x0604205F RID: 270431 RVA: 0x0100478C File Offset: 0x0100298C
		private void OnDangoBrawlInstPrepareNotify(DangoBrawlInstPrepareNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.ProtoInstPrepareNotify(resp);
		}

		// Token: 0x06042060 RID: 270432 RVA: 0x0100479F File Offset: 0x0100299F
		private void OnDangoBrawlInstEventSelectNotify(DangoBrawlInstEventSelectNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.ProtoInstEventSelectNotify(resp);
			}
			this.ThreeChooseGate |= ActivityDangoBrawlController.EThreeChooseGate.EventArrived;
			this.TryOpenThreeChoose();
		}

		// Token: 0x06042061 RID: 270433 RVA: 0x010047C8 File Offset: 0x010029C8
		private void OnDangoBrawlRoundSwitchNotify(DangoBrawlRoundSwitchNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.ProtoRoundSwitchNotify(resp);
			}
			this.ClearAllReqInFlight();
			this.HasThreeChoose = (resp.Event != null && resp.Event.Slots.Count > 0);
			this.ResetRoundGates();
		}

		// Token: 0x06042062 RID: 270434 RVA: 0x01004817 File Offset: 0x01002A17
		private void OnDangoBrawlCoinUpdateNotify(DangoBrawlCoinUpdateNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.ProtoCoinUpdateNotify(resp);
			}
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlCoinUpdated);
		}

		// Token: 0x06042063 RID: 270435 RVA: 0x0100483C File Offset: 0x01002A3C
		private void OnDangoBrawlBagUpdateNotify(DangoBrawlBagUpdateNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.ProtoBagUpdateNotify(resp);
			}
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			if (instance != null)
			{
				DangoBrawlRollbackController rollbackController = instance.GetRollbackController();
				if (rollbackController != null)
				{
					rollbackController.RebuildFromServerData();
				}
			}
			this.ClearBagOperatePending();
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlBagUpdated);
		}

		// Token: 0x06042064 RID: 270436 RVA: 0x0100488C File Offset: 0x01002A8C
		private void OnDangoBrawlSettleNotify(DangoBrawlSettleNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.ProtoSettleNotify(resp);
			}
			ActivityDangoBrawlData activityData2 = this.ActivityData;
			if (activityData2 != null)
			{
				DangoBrawlOutGameData outGameData = activityData2.GetOutGameData();
				if (outGameData != null)
				{
					outGameData.ClearSaveData();
				}
			}
			ActivityDangoBrawlData activityData3 = this.ActivityData;
			if (activityData3 != null)
			{
				DangoBrawlOutGameData outGameData2 = activityData3.GetOutGameData();
				if (outGameData2 != null)
				{
					outGameData2.SetIsEnterSave(false);
				}
			}
			ActivityDangoBrawlData activityData4 = this.ActivityData;
			int? num;
			if (activityData4 == null)
			{
				num = null;
			}
			else
			{
				DangoBrawlInstBaseNotify instBase = activityData4.InstBase;
				num = ((instBase != null) ? new int?(instBase.RoleId) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			if (valueOrDefault == 0)
			{
				return;
			}
			this.PlaySettleLevelSequence(valueOrDefault, resp.IsWin);
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
			if (battleFsm == null)
			{
				return;
			}
			battleFsm.ChangeState(EDangoBrawlFsmState.FinalSettle).Forget();
		}

		// Token: 0x06042065 RID: 270437 RVA: 0x01004956 File Offset: 0x01002B56
		private void OnDangoBrawlFightActionNotify(DangoBrawlFightActionNotify message)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.OnReceiveBattleReport(message);
		}

		// Token: 0x06042066 RID: 270438 RVA: 0x0100496E File Offset: 0x01002B6E
		private void OnDangoBrawlStartFightNotify(DangoBrawlStartFightNotify message)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.OnStartFightFighters(message.Fighters);
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.InitDango(message.Fighters);
		}

		// Token: 0x06042067 RID: 270439 RVA: 0x010049A2 File Offset: 0x01002BA2
		private void OnDangoBrawlFighterAttrChangeNotify(DangoBrawlFighterAttrChangeNotify message)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.OnDangoBrawlFighterAttrChange(message);
			}
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlFighterAttrChanged);
		}

		// Token: 0x06042068 RID: 270440 RVA: 0x010049C6 File Offset: 0x01002BC6
		private void OnDangoBrawlLoseCountUpdateNotify(DangoBrawlLoseCountUpdateNotify message)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.OnDangoBrawlLoseCountChange(message);
			}
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlLoseCountChanged);
		}

		// Token: 0x06042069 RID: 270441 RVA: 0x010049EA File Offset: 0x01002BEA
		private void OnDangoBrawlItemGiveCoinNotify(DangoBrawlItemGiveCoinNotify message)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.OnDangoBrawlItemGiveCoinNotify(message);
			}
			EventSystem.Instance.Emit<DangoBrawlItemGiveCoinNotify>(EEventName.OnDangoBrawlItemGiveCoinNotify, message);
		}

		// Token: 0x0604206A RID: 270442 RVA: 0x01004A0F File Offset: 0x01002C0F
		private void OnDangoBrawlItemEffectShowNotify(DangoBrawlItemEffectShowNotify message)
		{
			EventSystem.Instance.Emit<DangoBrawlItemEffectShowNotify>(EEventName.OnDangoBrawlItemEffectShowNotify, message);
		}

		// Token: 0x0604206B RID: 270443 RVA: 0x01004A24 File Offset: 0x01002C24
		[NullableContext(0)]
		public UniTask<bool> RequestShopRefresh()
		{
			ActivityDangoBrawlController.<RequestShopRefresh>d__41 <RequestShopRefresh>d__;
			<RequestShopRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestShopRefresh>d__.<>4__this = this;
			<RequestShopRefresh>d__.<>1__state = -1;
			<RequestShopRefresh>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestShopRefresh>d__41>(ref <RequestShopRefresh>d__);
			return <RequestShopRefresh>d__.<>t__builder.Task;
		}

		// Token: 0x0604206C RID: 270444 RVA: 0x01004A68 File Offset: 0x01002C68
		[NullableContext(0)]
		public UniTask<bool> RequestShopLock(int slotUid, bool locked)
		{
			ActivityDangoBrawlController.<RequestShopLock>d__42 <RequestShopLock>d__;
			<RequestShopLock>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestShopLock>d__.<>4__this = this;
			<RequestShopLock>d__.slotUid = slotUid;
			<RequestShopLock>d__.locked = locked;
			<RequestShopLock>d__.<>1__state = -1;
			<RequestShopLock>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestShopLock>d__42>(ref <RequestShopLock>d__);
			return <RequestShopLock>d__.<>t__builder.Task;
		}

		// Token: 0x0604206D RID: 270445 RVA: 0x01004ABC File Offset: 0x01002CBC
		[NullableContext(2)]
		[return: Nullable(0)]
		public UniTask<bool> RequestShopBuy(int slotUid, int configId, bool toBench, DangoBrawlBagSlotInfo bagSlot = null, int[] toBenchUids = null)
		{
			ActivityDangoBrawlController.<RequestShopBuy>d__43 <RequestShopBuy>d__;
			<RequestShopBuy>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestShopBuy>d__.<>4__this = this;
			<RequestShopBuy>d__.slotUid = slotUid;
			<RequestShopBuy>d__.configId = configId;
			<RequestShopBuy>d__.toBench = toBench;
			<RequestShopBuy>d__.bagSlot = bagSlot;
			<RequestShopBuy>d__.toBenchUids = toBenchUids;
			<RequestShopBuy>d__.<>1__state = -1;
			<RequestShopBuy>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestShopBuy>d__43>(ref <RequestShopBuy>d__);
			return <RequestShopBuy>d__.<>t__builder.Task;
		}

		// Token: 0x0604206E RID: 270446 RVA: 0x01004B2C File Offset: 0x01002D2C
		[NullableContext(0)]
		public UniTask<bool> RequestShopSell(int itemUid, bool fromBench = false, [Nullable(2)] int[] toBenchUids = null, bool deferSoldEvent = false)
		{
			ActivityDangoBrawlController.<RequestShopSell>d__44 <RequestShopSell>d__;
			<RequestShopSell>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestShopSell>d__.<>4__this = this;
			<RequestShopSell>d__.itemUid = itemUid;
			<RequestShopSell>d__.fromBench = fromBench;
			<RequestShopSell>d__.toBenchUids = toBenchUids;
			<RequestShopSell>d__.deferSoldEvent = deferSoldEvent;
			<RequestShopSell>d__.<>1__state = -1;
			<RequestShopSell>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestShopSell>d__44>(ref <RequestShopSell>d__);
			return <RequestShopSell>d__.<>t__builder.Task;
		}

		// Token: 0x0604206F RID: 270447 RVA: 0x01004B90 File Offset: 0x01002D90
		[return: Nullable(0)]
		public UniTask<bool> RequestShopCompose(int mainUid, int[] itemUids, EDragSourceKind[] sourceKinds, int composeId, int resultItemId, bool toBench, [Nullable(2)] DangoBrawlBagSlotInfo slot = null)
		{
			ActivityDangoBrawlController.<RequestShopCompose>d__45 <RequestShopCompose>d__;
			<RequestShopCompose>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestShopCompose>d__.<>4__this = this;
			<RequestShopCompose>d__.mainUid = mainUid;
			<RequestShopCompose>d__.itemUids = itemUids;
			<RequestShopCompose>d__.sourceKinds = sourceKinds;
			<RequestShopCompose>d__.composeId = composeId;
			<RequestShopCompose>d__.resultItemId = resultItemId;
			<RequestShopCompose>d__.toBench = toBench;
			<RequestShopCompose>d__.slot = slot;
			<RequestShopCompose>d__.<>1__state = -1;
			<RequestShopCompose>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestShopCompose>d__45>(ref <RequestShopCompose>d__);
			return <RequestShopCompose>d__.<>t__builder.Task;
		}

		// Token: 0x06042070 RID: 270448 RVA: 0x01004C10 File Offset: 0x01002E10
		[NullableContext(0)]
		public UniTask<bool> RequestBagOperate([Nullable(1)] DangoBrawlBagOpInfo[] ops)
		{
			ActivityDangoBrawlController.<RequestBagOperate>d__46 <RequestBagOperate>d__;
			<RequestBagOperate>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestBagOperate>d__.<>4__this = this;
			<RequestBagOperate>d__.ops = ops;
			<RequestBagOperate>d__.<>1__state = -1;
			<RequestBagOperate>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestBagOperate>d__46>(ref <RequestBagOperate>d__);
			return <RequestBagOperate>d__.<>t__builder.Task;
		}

		// Token: 0x06042071 RID: 270449 RVA: 0x01004C5C File Offset: 0x01002E5C
		[NullableContext(0)]
		public UniTask<bool> RequestEventRefresh(int slotIndex)
		{
			ActivityDangoBrawlController.<RequestEventRefresh>d__47 <RequestEventRefresh>d__;
			<RequestEventRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestEventRefresh>d__.<>4__this = this;
			<RequestEventRefresh>d__.slotIndex = slotIndex;
			<RequestEventRefresh>d__.<>1__state = -1;
			<RequestEventRefresh>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestEventRefresh>d__47>(ref <RequestEventRefresh>d__);
			return <RequestEventRefresh>d__.<>t__builder.Task;
		}

		// Token: 0x06042072 RID: 270450 RVA: 0x01004CA8 File Offset: 0x01002EA8
		[NullableContext(0)]
		public UniTask<bool> RequestEventSelect(int slotIndex)
		{
			ActivityDangoBrawlController.<RequestEventSelect>d__48 <RequestEventSelect>d__;
			<RequestEventSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestEventSelect>d__.<>4__this = this;
			<RequestEventSelect>d__.slotIndex = slotIndex;
			<RequestEventSelect>d__.<>1__state = -1;
			<RequestEventSelect>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestEventSelect>d__48>(ref <RequestEventSelect>d__);
			return <RequestEventSelect>d__.<>t__builder.Task;
		}

		// Token: 0x06042073 RID: 270451 RVA: 0x01004CF4 File Offset: 0x01002EF4
		[NullableContext(0)]
		public UniTask<bool> RequestStartFight()
		{
			ActivityDangoBrawlController.<RequestStartFight>d__49 <RequestStartFight>d__;
			<RequestStartFight>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestStartFight>d__.<>1__state = -1;
			<RequestStartFight>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestStartFight>d__49>(ref <RequestStartFight>d__);
			return <RequestStartFight>d__.<>t__builder.Task;
		}

		// Token: 0x06042074 RID: 270452 RVA: 0x01004D30 File Offset: 0x01002F30
		[NullableContext(0)]
		public UniTask<bool> RequestFightOver(bool isAdditionalRound = false)
		{
			ActivityDangoBrawlController.<RequestFightOver>d__50 <RequestFightOver>d__;
			<RequestFightOver>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestFightOver>d__.isAdditionalRound = isAdditionalRound;
			<RequestFightOver>d__.<>1__state = -1;
			<RequestFightOver>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestFightOver>d__50>(ref <RequestFightOver>d__);
			return <RequestFightOver>d__.<>t__builder.Task;
		}

		// Token: 0x06042075 RID: 270453 RVA: 0x01004D74 File Offset: 0x01002F74
		[NullableContext(0)]
		public UniTask<bool> RequestSettle()
		{
			ActivityDangoBrawlController.<RequestSettle>d__51 <RequestSettle>d__;
			<RequestSettle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestSettle>d__.<>1__state = -1;
			<RequestSettle>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestSettle>d__51>(ref <RequestSettle>d__);
			return <RequestSettle>d__.<>t__builder.Task;
		}

		// Token: 0x06042076 RID: 270454 RVA: 0x01004DB0 File Offset: 0x01002FB0
		[NullableContext(0)]
		public UniTask<bool> RequestEnterInstanceDungeon(int levelId, bool isSave, int roleId = 0)
		{
			ActivityDangoBrawlController.<RequestEnterInstanceDungeon>d__52 <RequestEnterInstanceDungeon>d__;
			<RequestEnterInstanceDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestEnterInstanceDungeon>d__.levelId = levelId;
			<RequestEnterInstanceDungeon>d__.isSave = isSave;
			<RequestEnterInstanceDungeon>d__.roleId = roleId;
			<RequestEnterInstanceDungeon>d__.<>1__state = -1;
			<RequestEnterInstanceDungeon>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestEnterInstanceDungeon>d__52>(ref <RequestEnterInstanceDungeon>d__);
			return <RequestEnterInstanceDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x06042077 RID: 270455 RVA: 0x01004E04 File Offset: 0x01003004
		public bool TryLeaveIfActivityClosed()
		{
			if (this.ActivityData != null && !this.ActivityData.CheckIfClose())
			{
				return false;
			}
			this.RequestLeaveInstanceDungeon(default(AfterLeaveInstanceDungeonOpenViewParam)).Forget<bool>();
			return true;
		}

		// Token: 0x06042078 RID: 270456 RVA: 0x01004E40 File Offset: 0x01003040
		[NullableContext(0)]
		public UniTask<bool> RequestLeaveInstanceDungeon(AfterLeaveInstanceDungeonOpenViewParam openParam = default(AfterLeaveInstanceDungeonOpenViewParam))
		{
			ActivityDangoBrawlController.<RequestLeaveInstanceDungeon>d__54 <RequestLeaveInstanceDungeon>d__;
			<RequestLeaveInstanceDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestLeaveInstanceDungeon>d__.<>4__this = this;
			<RequestLeaveInstanceDungeon>d__.openParam = openParam;
			<RequestLeaveInstanceDungeon>d__.<>1__state = -1;
			<RequestLeaveInstanceDungeon>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestLeaveInstanceDungeon>d__54>(ref <RequestLeaveInstanceDungeon>d__);
			return <RequestLeaveInstanceDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x06042079 RID: 270457 RVA: 0x01004E8C File Offset: 0x0100308C
		public UniTask RestartInstanceDungeon(bool isInDungeon = false)
		{
			ActivityDangoBrawlController.<RestartInstanceDungeon>d__55 <RestartInstanceDungeon>d__;
			<RestartInstanceDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RestartInstanceDungeon>d__.<>4__this = this;
			<RestartInstanceDungeon>d__.isInDungeon = isInDungeon;
			<RestartInstanceDungeon>d__.<>1__state = -1;
			<RestartInstanceDungeon>d__.<>t__builder.Start<ActivityDangoBrawlController.<RestartInstanceDungeon>d__55>(ref <RestartInstanceDungeon>d__);
			return <RestartInstanceDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x0604207A RID: 270458 RVA: 0x01004ED8 File Offset: 0x010030D8
		public void RequestTaskReward(List<int> taskIds, [Nullable(2)] Action finishCallback)
		{
			DangoBrawlTaskRewardRequest dangoBrawlTaskRewardRequest = DangoBrawlTaskRewardRequest.Create();
			dangoBrawlTaskRewardRequest.ActivityId = this.ActivityId;
			dangoBrawlTaskRewardRequest.TaskIds.AddRange(taskIds);
			Net.Instance.Call(ERequestMessageId.DangoBrawlTaskRewardRequest, dangoBrawlTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if ((DangoBrawlTaskRewardResponse)msg == null)
				{
					return;
				}
				ActivityDangoBrawlData activityData = this.ActivityData;
				if (activityData != null)
				{
					DangoBrawlOutGameData outGameData = activityData.GetOutGameData();
					if (outGameData != null)
					{
						outGameData.SetTaskRewardReceived(taskIds);
					}
				}
				Action finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2();
			}, 0);
		}

		// Token: 0x0604207B RID: 270459 RVA: 0x01004F40 File Offset: 0x01003140
		[NullableContext(2)]
		public void RequestDangoBrawlScoreReward(Action finishCallback)
		{
			ActivityDangoBrawlController.<>c__DisplayClass57_0 CS$<>8__locals1 = new ActivityDangoBrawlController.<>c__DisplayClass57_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.finishCallback = finishCallback;
			ActivityDangoBrawlController.<>c__DisplayClass57_0 CS$<>8__locals2 = CS$<>8__locals1;
			ActivityDangoBrawlData activityData = this.ActivityData;
			List<int> list;
			if (activityData == null)
			{
				list = null;
			}
			else
			{
				DangoBrawlOutGameData outGameData = activityData.GetOutGameData();
				list = ((outGameData != null) ? outGameData.GetCanClaimedScoreRewardList() : null);
			}
			CS$<>8__locals2.scoreIds = (list ?? new List<int>());
			if (this.ActivityData == null || CS$<>8__locals1.scoreIds.Count <= 0)
			{
				return;
			}
			DangoBrawlScoreRewardRequest dangoBrawlScoreRewardRequest = DangoBrawlScoreRewardRequest.Create();
			dangoBrawlScoreRewardRequest.ActivityId = this.ActivityId;
			dangoBrawlScoreRewardRequest.ScoreIds.AddRange(CS$<>8__locals1.scoreIds);
			Net.Instance.Call(ERequestMessageId.DangoBrawlScoreRewardRequest, dangoBrawlScoreRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DangoBrawlScoreRewardResponse dangoBrawlScoreRewardResponse = (DangoBrawlScoreRewardResponse)msg;
				if (dangoBrawlScoreRewardResponse == null)
				{
					return;
				}
				if (dangoBrawlScoreRewardResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(dangoBrawlScoreRewardResponse.ErrCode, EResponseMessageId.DangoBrawlScoreRewardResponse, null, true, true);
					return;
				}
				CS$<>8__locals1.<>4__this.ActivityData.GetOutGameData().SetScoreRewardReceived(CS$<>8__locals1.scoreIds);
				Action finishCallback2 = CS$<>8__locals1.finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2();
			}, 0);
		}

		// Token: 0x17009668 RID: 38504
		// (get) Token: 0x0604207C RID: 270460 RVA: 0x01004FE5 File Offset: 0x010031E5
		public bool ConsumeComposeFirstUnlock
		{
			get
			{
				bool lastComposeIsFirstUnlock = this.LastComposeIsFirstUnlock;
				this.LastComposeIsFirstUnlock = false;
				return lastComposeIsFirstUnlock;
			}
		}

		// Token: 0x0604207D RID: 270461 RVA: 0x01004FF4 File Offset: 0x010031F4
		private void ResetRoundGates()
		{
			this.ThreeChooseGate = ActivityDangoBrawlController.EThreeChooseGate.None;
			this.RoundStartGate = ActivityDangoBrawlController.ERoundStartGate.None;
			this.ThreeChooseResolved = !this.HasThreeChoose;
		}

		// Token: 0x0604207E RID: 270462 RVA: 0x01005013 File Offset: 0x01003213
		private void TryOpenThreeChoose()
		{
			if ((this.ThreeChooseGate & (ActivityDangoBrawlController.EThreeChooseGate.TipsClosed | ActivityDangoBrawlController.EThreeChooseGate.EventArrived)) != (ActivityDangoBrawlController.EThreeChooseGate.TipsClosed | ActivityDangoBrawlController.EThreeChooseGate.EventArrived))
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlChooseCardView, null, null);
		}

		// Token: 0x0604207F RID: 270463 RVA: 0x01005034 File Offset: 0x01003234
		private void TryFireRoundStartEffects()
		{
			ActivityDangoBrawlController.ERoundStartGate eroundStartGate = this.HasThreeChoose ? (ActivityDangoBrawlController.ERoundStartGate.TipsClosed | ActivityDangoBrawlController.ERoundStartGate.ThreeChosen) : ActivityDangoBrawlController.ERoundStartGate.TipsClosed;
			if ((this.RoundStartGate & eroundStartGate) != eroundStartGate)
			{
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlRoundStartEffectsReady);
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "DangoBrawlRoundStartAnimDone");
		}

		// Token: 0x06042080 RID: 270464 RVA: 0x0100507F File Offset: 0x0100327F
		private void OnDangoBrawlShopStateTipsClosed()
		{
			this.ThreeChooseGate |= ActivityDangoBrawlController.EThreeChooseGate.TipsClosed;
			this.TryOpenThreeChoose();
			this.RoundStartGate |= ActivityDangoBrawlController.ERoundStartGate.TipsClosed;
			this.TryFireRoundStartEffects();
		}

		// Token: 0x06042081 RID: 270465 RVA: 0x010050A9 File Offset: 0x010032A9
		private void OnDangoBrawlThreeChooseClosed()
		{
			this.RoundStartGate |= ActivityDangoBrawlController.ERoundStartGate.ThreeChosen;
			this.TryFireRoundStartEffects();
		}

		// Token: 0x06042082 RID: 270466 RVA: 0x010050BF File Offset: 0x010032BF
		public bool IsThreeChooseBlocking()
		{
			return this.HasThreeChoose && !this.ThreeChooseResolved;
		}

		// Token: 0x06042083 RID: 270467 RVA: 0x010050D4 File Offset: 0x010032D4
		public void TryPlayRoleUnlockQueue()
		{
			if (this.IsRoleUnlockShowing)
			{
				return;
			}
			ActivityDangoBrawlData activityData = this.ActivityData;
			int? num;
			if (activityData == null)
			{
				num = null;
			}
			else
			{
				DangoBrawlOutGameData outGameData = activityData.GetOutGameData();
				num = ((outGameData != null) ? outGameData.DequeueUnlockNotifyRole() : null);
			}
			int? num2 = num;
			if (num2 == null)
			{
				return;
			}
			this.IsRoleUnlockShowing = true;
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRoleUnlockView, new DangoBrawlRoleUnlockViewOpenData
			{
				RoleId = num2.Value,
				OnCloseCallback = delegate()
				{
					this.IsRoleUnlockShowing = false;
					this.TryPlayRoleUnlockQueue();
				}
			}, null);
		}

		// Token: 0x06042084 RID: 270468 RVA: 0x01005160 File Offset: 0x01003360
		public void PlaySettleLevelSequence(int roleId, bool isWin)
		{
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(roleId);
			if (roleConfigById == null)
			{
				return;
			}
			DangoBrawlRole value = roleConfigById.Value;
			if (!isWin)
			{
				DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
				DangoBrawlMontageComponent dangoBrawlMontageComponent;
				if (battleManager == null)
				{
					dangoBrawlMontageComponent = null;
				}
				else
				{
					ActivityGameplayEntity entity = battleManager.GetEntity(true);
					dangoBrawlMontageComponent = ((entity != null) ? entity.GetComponent<DangoBrawlMontageComponent>() : null);
				}
				DangoBrawlMontageComponent dangoBrawlMontageComponent2 = dangoBrawlMontageComponent;
				if (dangoBrawlMontageComponent2 != null && !dangoBrawlMontageComponent2.IsPlayingDefeat())
				{
					dangoBrawlMontageComponent2.ResetTerminalState();
					dangoBrawlMontageComponent2.PlayDefeat();
				}
			}
			string flowListName = isWin ? value.WinFlowListName : value.LoseFlowListName;
			int flowId = isWin ? value.WinFlowId : value.LoseFlowId;
			int stateId = isWin ? value.WinStateId : value.LoseStateId;
			BlackScreenController.Instance.AddBlackScreen("Start", "DangoBrawlSettle", "Black", "Default");
			EventSystem.Instance.Add(EEventName.PlotSequenceStarted, new Action(this.OnSettleSequenceStarted));
			FlowController.Instance.StartFlow(flowListName, flowId, stateId, null, 0L, false, false, false, null);
			if (UiManager.Instance.GetViewByName(EUiViewName.DangoBrawlPauseView) != null)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					UiManager.Instance.CloseView(EUiViewName.DangoBrawlPauseView, null);
				}, 200f, null, null, true, 1f);
			}
		}

		// Token: 0x06042085 RID: 270469 RVA: 0x010052A4 File Offset: 0x010034A4
		private void OnSettleSequenceStarted()
		{
			EventSystem.Instance.Remove(EEventName.PlotSequenceStarted, new Action(this.OnSettleSequenceStarted));
			BlackScreenController.Instance.RemoveBlackScreen("Close", "DangoBrawlSettle", "Default");
		}

		// Token: 0x06042086 RID: 270470 RVA: 0x010052DC File Offset: 0x010034DC
		private UniTask FinishSettlePlotBeforeLeaveDungeon()
		{
			ActivityDangoBrawlController.<FinishSettlePlotBeforeLeaveDungeon>d__83 <FinishSettlePlotBeforeLeaveDungeon>d__;
			<FinishSettlePlotBeforeLeaveDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FinishSettlePlotBeforeLeaveDungeon>d__.<>1__state = -1;
			<FinishSettlePlotBeforeLeaveDungeon>d__.<>t__builder.Start<ActivityDangoBrawlController.<FinishSettlePlotBeforeLeaveDungeon>d__83>(ref <FinishSettlePlotBeforeLeaveDungeon>d__);
			return <FinishSettlePlotBeforeLeaveDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x06042087 RID: 270471 RVA: 0x01005317 File Offset: 0x01003517
		public int RegisterTermHyperlink(UUIText uiText)
		{
			if (TermExplanationController.Instance.IsUiTextRegistered(uiText))
			{
				return 0;
			}
			return TermExplanationController.Instance.RegisterTextHyperlinkByParam(new TermExplanationRegistryParam
			{
				UiText = uiText,
				ViewType = ETermExplanationViewType.Center,
				ReportType = ETermExplanationReportType.Team
			});
		}

		// Token: 0x06042088 RID: 270472 RVA: 0x0100534C File Offset: 0x0100354C
		public void UnRegisterTermHyperlink(UUIText uiText)
		{
			if (!TermExplanationController.Instance.IsUiTextRegistered(uiText))
			{
				return;
			}
			TermExplanationController.Instance.UnRegisterTextHyperlink(uiText);
		}

		// Token: 0x06042089 RID: 270473 RVA: 0x01005368 File Offset: 0x01003568
		private bool TryLockRequest(ERequestMessageId msgId, string busyHint)
		{
			if (this.ReqInFlight.Contains(msgId))
			{
				Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, busyHint, default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.ReqInFlight.Add(msgId);
			return true;
		}

		// Token: 0x0604208A RID: 270474 RVA: 0x010053AE File Offset: 0x010035AE
		private void ClearAllReqInFlight()
		{
			this.ReqInFlight.Clear();
		}

		// Token: 0x0604208B RID: 270475 RVA: 0x010053BB File Offset: 0x010035BB
		private void ClearBagOperatePending()
		{
			this.ReqInFlight.Remove(ERequestMessageId.DangoBrawlBagOperateRequest);
		}

		// Token: 0x17009669 RID: 38505
		// (get) Token: 0x0604208C RID: 270476 RVA: 0x010053CE File Offset: 0x010035CE
		public bool IsBagOperatePending
		{
			get
			{
				return this.ReqInFlight.Contains(ERequestMessageId.DangoBrawlBagOperateRequest);
			}
		}

		// Token: 0x1700966A RID: 38506
		// (get) Token: 0x0604208D RID: 270477 RVA: 0x010053E0 File Offset: 0x010035E0
		public static ActivityDangoBrawlController Instance
		{
			get
			{
				return ActivityDangoBrawlController._Instance;
			}
		}

		// Token: 0x0604208E RID: 270478 RVA: 0x010053E7 File Offset: 0x010035E7
		public static ActivityDangoBrawlController GetOrCreateInstance()
		{
			if (ActivityDangoBrawlController._Instance == null)
			{
				ActivityDangoBrawlController.CreateInstance();
			}
			return ActivityDangoBrawlController._Instance;
		}

		// Token: 0x0604208F RID: 270479 RVA: 0x010053FB File Offset: 0x010035FB
		public static bool CreateInstance()
		{
			if (ActivityDangoBrawlController._Instance != null)
			{
				return true;
			}
			ActivityDangoBrawlController._Instance = new ActivityDangoBrawlController();
			return true;
		}

		// Token: 0x06042090 RID: 270480 RVA: 0x01005411 File Offset: 0x01003611
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06042091 RID: 270481 RVA: 0x01005413 File Offset: 0x01003613
		public static void ResetStaticDefaultValue()
		{
			ActivityDangoBrawlController._Instance = null;
		}

		// Token: 0x06042092 RID: 270482 RVA: 0x0100541B File Offset: 0x0100361B
		static ActivityDangoBrawlController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityDangoBrawlController.CreateStaticDefaultValue), new Action(ActivityDangoBrawlController.ResetStaticDefaultValue));
		}

		// Token: 0x04022632 RID: 140850
		private int ActivityId;

		// Token: 0x04022633 RID: 140851
		[Nullable(2)]
		private ActivityDangoBrawlData ActivityData;

		// Token: 0x04022634 RID: 140852
		private AfterLeaveInstanceDungeonOpenViewParam OpenViewParam;

		// Token: 0x04022635 RID: 140853
		private bool LastComposeIsFirstUnlock;

		// Token: 0x04022636 RID: 140854
		private bool HasThreeChoose;

		// Token: 0x04022637 RID: 140855
		private bool ThreeChooseResolved = true;

		// Token: 0x04022638 RID: 140856
		private ActivityDangoBrawlController.EThreeChooseGate ThreeChooseGate;

		// Token: 0x04022639 RID: 140857
		private ActivityDangoBrawlController.ERoundStartGate RoundStartGate;

		// Token: 0x0402263A RID: 140858
		private bool IsRoleUnlockShowing;

		// Token: 0x0402263B RID: 140859
		private const string SettleSequenceBlackScreenTag = "DangoBrawlSettle";

		// Token: 0x0402263C RID: 140860
		private const string LeaveSettleMaskContext = "DangoBrawlLeaveSettle";

		// Token: 0x0402263D RID: 140861
		private const float LeaveSettleMaskFadeInTime = 0.3f;

		// Token: 0x0402263E RID: 140862
		private const float LeaveSettleMaskKeepTime = 3000f;

		// Token: 0x0402263F RID: 140863
		private const float LeaveSettleMaskOpenTimeout = 1500f;

		// Token: 0x04022640 RID: 140864
		private const float LeaveSettlePlotEndTimeoutSeconds = 5f;

		// Token: 0x04022641 RID: 140865
		private readonly HashSet<ERequestMessageId> ReqInFlight = new HashSet<ERequestMessageId>();

		// Token: 0x04022642 RID: 140866
		[Nullable(2)]
		private static ActivityDangoBrawlController _Instance;

		// Token: 0x0200C8CD RID: 51405
		[NullableContext(0)]
		[Flags]
		private enum ERoundStartGate
		{
			// Token: 0x0403C9FA RID: 248314
			None = 0,
			// Token: 0x0403C9FB RID: 248315
			TipsClosed = 1,
			// Token: 0x0403C9FC RID: 248316
			ThreeChosen = 2
		}

		// Token: 0x0200C8CE RID: 51406
		[NullableContext(0)]
		[Flags]
		private enum EThreeChooseGate
		{
			// Token: 0x0403C9FE RID: 248318
			None = 0,
			// Token: 0x0403C9FF RID: 248319
			TipsClosed = 1,
			// Token: 0x0403CA00 RID: 248320
			EventArrived = 2
		}
	}
}
