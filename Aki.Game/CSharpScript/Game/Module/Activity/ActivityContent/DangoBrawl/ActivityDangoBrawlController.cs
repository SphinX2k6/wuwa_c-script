using System;
using System.Collections.Generic;
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
	// Token: 0x020056A4 RID: 22180
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityDangoBrawlController : ActivityControllerBase
	{
		// Token: 0x170069A5 RID: 27045
		// (get) Token: 0x06036B99 RID: 224153 RVA: 0x00F45248 File Offset: 0x00F43448
		public int MyActivityId
		{
			get
			{
				return this.ActivityId;
			}
		}

		// Token: 0x170069A6 RID: 27046
		// (get) Token: 0x06036B9A RID: 224154 RVA: 0x00F45250 File Offset: 0x00F43450
		[Nullable(2)]
		public ActivityDangoBrawlData MyActivityData
		{
			[NullableContext(2)]
			get
			{
				return this.ActivityData;
			}
		}

		// Token: 0x06036B9B RID: 224155 RVA: 0x00F45258 File Offset: 0x00F43458
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipDangoBrawlView, null, null);
		}

		// Token: 0x06036B9C RID: 224156 RVA: 0x00F4526B File Offset: 0x00F4346B
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06036B9D RID: 224157 RVA: 0x00F4526D File Offset: 0x00F4346D
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityDangoBrawlGuide";
		}

		// Token: 0x06036B9E RID: 224158 RVA: 0x00F45274 File Offset: 0x00F43474
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewDangoBrawl();
		}

		// Token: 0x06036B9F RID: 224159 RVA: 0x00F4527B File Offset: 0x00F4347B
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			this.ActivityData = new ActivityDangoBrawlData();
			this.ActivityData.Init(data);
			return this.ActivityData;
		}

		// Token: 0x06036BA0 RID: 224160 RVA: 0x00F452A8 File Offset: 0x00F434A8
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

		// Token: 0x06036BA1 RID: 224161 RVA: 0x00F45354 File Offset: 0x00F43554
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

		// Token: 0x06036BA2 RID: 224162 RVA: 0x00F45398 File Offset: 0x00F43598
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnSetGameModeDataDone, new Action(this.OnGameModeDataChange));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopStateTipsClosed, new Action(this.OnDangoBrawlShopStateTipsClosed));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlThreeChooseClosed, new Action(this.OnDangoBrawlThreeChooseClosed));
		}

		// Token: 0x06036BA3 RID: 224163 RVA: 0x00F45418 File Offset: 0x00F43618
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.OnSetGameModeDataDone, new Action(this.OnGameModeDataChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopStateTipsClosed, new Action(this.OnDangoBrawlShopStateTipsClosed));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlThreeChooseClosed, new Action(this.OnDangoBrawlThreeChooseClosed));
		}

		// Token: 0x06036BA4 RID: 224164 RVA: 0x00F45495 File Offset: 0x00F43695
		private void OnGameModeDataChange()
		{
			this.TryInitMap();
		}

		// Token: 0x06036BA5 RID: 224165 RVA: 0x00F454A0 File Offset: 0x00F436A0
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

		// Token: 0x06036BA6 RID: 224166 RVA: 0x00F45533 File Offset: 0x00F43733
		private void OnWorldDone()
		{
			this.AddShowViewSplashTask();
		}

		// Token: 0x06036BA7 RID: 224167 RVA: 0x00F4553C File Offset: 0x00F4373C
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

		// Token: 0x06036BA8 RID: 224168 RVA: 0x00F45580 File Offset: 0x00F43780
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

		// Token: 0x06036BA9 RID: 224169 RVA: 0x00F457A4 File Offset: 0x00F439A4
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

		// Token: 0x06036BAA RID: 224170 RVA: 0x00F458E1 File Offset: 0x00F43AE1
		private void OnDangoBrawlTaskUpdateNotify(DangoBrawlTaskUpdateNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData != null) ? activityData.GetOutGameData() : null;
			if (dangoBrawlOutGameData == null)
			{
				return;
			}
			dangoBrawlOutGameData.UpdateTaskDataList(resp.Tasks);
		}

		// Token: 0x06036BAB RID: 224171 RVA: 0x00F45908 File Offset: 0x00F43B08
		private void OnDangoBrawlRoleUnlockNotify(DangoBrawlRoleUnlockNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.EnsureUnlockReadInitialized();
			}
			ActivityDangoBrawlData activityData2 = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData2 != null) ? activityData2.GetOutGameData() : null;
			List<int> list = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.UpdateRoleDataList(resp.RoleIds, true) : null;
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

		// Token: 0x06036BAC RID: 224172 RVA: 0x00F45990 File Offset: 0x00F43B90
		private void OnDangoBrawlItemUnlockNotify(DangoBrawlItemUnlockNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.EnsureUnlockReadInitialized();
			}
			ActivityDangoBrawlData activityData2 = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData2 != null) ? activityData2.GetOutGameData() : null;
			List<int> list = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.UpdateItemDataList(resp.ItemIds, true) : null;
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

		// Token: 0x06036BAD RID: 224173 RVA: 0x00F45A18 File Offset: 0x00F43C18
		private void OnDangoBrawlChallengeUnlockNotify(DangoBrawlChallengeUnlockNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.EnsureUnlockReadInitialized();
			}
			ActivityDangoBrawlData activityData2 = this.ActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityData2 != null) ? activityData2.GetOutGameData() : null;
			List<int> list = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.UpdateLevelDataList(resp.ChallengeInfos) : null;
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

		// Token: 0x06036BAE RID: 224174 RVA: 0x00F45A9C File Offset: 0x00F43C9C
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

		// Token: 0x06036BAF RID: 224175 RVA: 0x00F45AC0 File Offset: 0x00F43CC0
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

		// Token: 0x06036BB0 RID: 224176 RVA: 0x00F45B14 File Offset: 0x00F43D14
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

		// Token: 0x06036BB1 RID: 224177 RVA: 0x00F45BB4 File Offset: 0x00F43DB4
		private void OnDangoBrawlInstPrepareNotify(DangoBrawlInstPrepareNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.ProtoInstPrepareNotify(resp);
		}

		// Token: 0x06036BB2 RID: 224178 RVA: 0x00F45BC7 File Offset: 0x00F43DC7
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

		// Token: 0x06036BB3 RID: 224179 RVA: 0x00F45BF0 File Offset: 0x00F43DF0
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

		// Token: 0x06036BB4 RID: 224180 RVA: 0x00F45C3F File Offset: 0x00F43E3F
		private void OnDangoBrawlCoinUpdateNotify(DangoBrawlCoinUpdateNotify resp)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.ProtoCoinUpdateNotify(resp);
			}
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlCoinUpdated);
		}

		// Token: 0x06036BB5 RID: 224181 RVA: 0x00F45C64 File Offset: 0x00F43E64
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

		// Token: 0x06036BB6 RID: 224182 RVA: 0x00F45CB4 File Offset: 0x00F43EB4
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

		// Token: 0x06036BB7 RID: 224183 RVA: 0x00F45D7E File Offset: 0x00F43F7E
		private void OnDangoBrawlFightActionNotify(DangoBrawlFightActionNotify message)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.OnReceiveBattleReport(message);
		}

		// Token: 0x06036BB8 RID: 224184 RVA: 0x00F45D96 File Offset: 0x00F43F96
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

		// Token: 0x06036BB9 RID: 224185 RVA: 0x00F45DCA File Offset: 0x00F43FCA
		private void OnDangoBrawlFighterAttrChangeNotify(DangoBrawlFighterAttrChangeNotify message)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.OnDangoBrawlFighterAttrChange(message);
			}
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlFighterAttrChanged);
		}

		// Token: 0x06036BBA RID: 224186 RVA: 0x00F45DEE File Offset: 0x00F43FEE
		private void OnDangoBrawlLoseCountUpdateNotify(DangoBrawlLoseCountUpdateNotify message)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.OnDangoBrawlLoseCountChange(message);
			}
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlLoseCountChanged);
		}

		// Token: 0x06036BBB RID: 224187 RVA: 0x00F45E12 File Offset: 0x00F44012
		private void OnDangoBrawlItemGiveCoinNotify(DangoBrawlItemGiveCoinNotify message)
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.OnDangoBrawlItemGiveCoinNotify(message);
			}
			EventSystem.Instance.Emit<DangoBrawlItemGiveCoinNotify>(EEventName.OnDangoBrawlItemGiveCoinNotify, message);
		}

		// Token: 0x06036BBC RID: 224188 RVA: 0x00F45E37 File Offset: 0x00F44037
		private void OnDangoBrawlItemEffectShowNotify(DangoBrawlItemEffectShowNotify message)
		{
			EventSystem.Instance.Emit<DangoBrawlItemEffectShowNotify>(EEventName.OnDangoBrawlItemEffectShowNotify, message);
		}

		// Token: 0x06036BBD RID: 224189 RVA: 0x00F45E4C File Offset: 0x00F4404C
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

		// Token: 0x06036BBE RID: 224190 RVA: 0x00F45E90 File Offset: 0x00F44090
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

		// Token: 0x06036BBF RID: 224191 RVA: 0x00F45EE4 File Offset: 0x00F440E4
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

		// Token: 0x06036BC0 RID: 224192 RVA: 0x00F45F54 File Offset: 0x00F44154
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

		// Token: 0x06036BC1 RID: 224193 RVA: 0x00F45FB8 File Offset: 0x00F441B8
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

		// Token: 0x06036BC2 RID: 224194 RVA: 0x00F46038 File Offset: 0x00F44238
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

		// Token: 0x06036BC3 RID: 224195 RVA: 0x00F46084 File Offset: 0x00F44284
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

		// Token: 0x06036BC4 RID: 224196 RVA: 0x00F460D0 File Offset: 0x00F442D0
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

		// Token: 0x06036BC5 RID: 224197 RVA: 0x00F4611C File Offset: 0x00F4431C
		[NullableContext(0)]
		public UniTask<bool> RequestStartFight()
		{
			ActivityDangoBrawlController.<RequestStartFight>d__49 <RequestStartFight>d__;
			<RequestStartFight>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestStartFight>d__.<>1__state = -1;
			<RequestStartFight>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestStartFight>d__49>(ref <RequestStartFight>d__);
			return <RequestStartFight>d__.<>t__builder.Task;
		}

		// Token: 0x06036BC6 RID: 224198 RVA: 0x00F46158 File Offset: 0x00F44358
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

		// Token: 0x06036BC7 RID: 224199 RVA: 0x00F4619C File Offset: 0x00F4439C
		[NullableContext(0)]
		public UniTask<bool> RequestSettle()
		{
			ActivityDangoBrawlController.<RequestSettle>d__51 <RequestSettle>d__;
			<RequestSettle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestSettle>d__.<>1__state = -1;
			<RequestSettle>d__.<>t__builder.Start<ActivityDangoBrawlController.<RequestSettle>d__51>(ref <RequestSettle>d__);
			return <RequestSettle>d__.<>t__builder.Task;
		}

		// Token: 0x06036BC8 RID: 224200 RVA: 0x00F461D8 File Offset: 0x00F443D8
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

		// Token: 0x06036BC9 RID: 224201 RVA: 0x00F4622C File Offset: 0x00F4442C
		public bool TryLeaveIfActivityClosed()
		{
			if (this.ActivityData != null && !this.ActivityData.CheckIfClose())
			{
				return false;
			}
			this.RequestLeaveInstanceDungeon(default(AfterLeaveInstanceDungeonOpenViewParam)).Forget<bool>();
			return true;
		}

		// Token: 0x06036BCA RID: 224202 RVA: 0x00F46268 File Offset: 0x00F44468
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

		// Token: 0x06036BCB RID: 224203 RVA: 0x00F462B4 File Offset: 0x00F444B4
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

		// Token: 0x06036BCC RID: 224204 RVA: 0x00F46300 File Offset: 0x00F44500
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

		// Token: 0x06036BCD RID: 224205 RVA: 0x00F46368 File Offset: 0x00F44568
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

		// Token: 0x170069A7 RID: 27047
		// (get) Token: 0x06036BCE RID: 224206 RVA: 0x00F4640D File Offset: 0x00F4460D
		public bool ConsumeComposeFirstUnlock
		{
			get
			{
				bool lastComposeIsFirstUnlock = this.LastComposeIsFirstUnlock;
				this.LastComposeIsFirstUnlock = false;
				return lastComposeIsFirstUnlock;
			}
		}

		// Token: 0x06036BCF RID: 224207 RVA: 0x00F4641C File Offset: 0x00F4461C
		private void ResetRoundGates()
		{
			this.ThreeChooseGate = ActivityDangoBrawlController.EThreeChooseGate.None;
			this.RoundStartGate = ActivityDangoBrawlController.ERoundStartGate.None;
			this.ThreeChooseResolved = !this.HasThreeChoose;
		}

		// Token: 0x06036BD0 RID: 224208 RVA: 0x00F4643B File Offset: 0x00F4463B
		private void TryOpenThreeChoose()
		{
			if ((this.ThreeChooseGate & (ActivityDangoBrawlController.EThreeChooseGate.TipsClosed | ActivityDangoBrawlController.EThreeChooseGate.EventArrived)) != (ActivityDangoBrawlController.EThreeChooseGate.TipsClosed | ActivityDangoBrawlController.EThreeChooseGate.EventArrived))
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlChooseCardView, null, null);
		}

		// Token: 0x06036BD1 RID: 224209 RVA: 0x00F4645C File Offset: 0x00F4465C
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

		// Token: 0x06036BD2 RID: 224210 RVA: 0x00F464A7 File Offset: 0x00F446A7
		private void OnDangoBrawlShopStateTipsClosed()
		{
			this.ThreeChooseGate |= ActivityDangoBrawlController.EThreeChooseGate.TipsClosed;
			this.TryOpenThreeChoose();
			this.RoundStartGate |= ActivityDangoBrawlController.ERoundStartGate.TipsClosed;
			this.TryFireRoundStartEffects();
		}

		// Token: 0x06036BD3 RID: 224211 RVA: 0x00F464D1 File Offset: 0x00F446D1
		private void OnDangoBrawlThreeChooseClosed()
		{
			this.RoundStartGate |= ActivityDangoBrawlController.ERoundStartGate.ThreeChosen;
			this.TryFireRoundStartEffects();
		}

		// Token: 0x06036BD4 RID: 224212 RVA: 0x00F464E7 File Offset: 0x00F446E7
		public bool IsThreeChooseBlocking()
		{
			return this.HasThreeChoose && !this.ThreeChooseResolved;
		}

		// Token: 0x06036BD5 RID: 224213 RVA: 0x00F464FC File Offset: 0x00F446FC
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

		// Token: 0x06036BD6 RID: 224214 RVA: 0x00F46588 File Offset: 0x00F44788
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

		// Token: 0x06036BD7 RID: 224215 RVA: 0x00F466CC File Offset: 0x00F448CC
		private void OnSettleSequenceStarted()
		{
			EventSystem.Instance.Remove(EEventName.PlotSequenceStarted, new Action(this.OnSettleSequenceStarted));
			BlackScreenController.Instance.RemoveBlackScreen("Close", "DangoBrawlSettle", "Default");
		}

		// Token: 0x06036BD8 RID: 224216 RVA: 0x00F46704 File Offset: 0x00F44904
		private UniTask FinishSettlePlotBeforeLeaveDungeon()
		{
			ActivityDangoBrawlController.<FinishSettlePlotBeforeLeaveDungeon>d__83 <FinishSettlePlotBeforeLeaveDungeon>d__;
			<FinishSettlePlotBeforeLeaveDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FinishSettlePlotBeforeLeaveDungeon>d__.<>1__state = -1;
			<FinishSettlePlotBeforeLeaveDungeon>d__.<>t__builder.Start<ActivityDangoBrawlController.<FinishSettlePlotBeforeLeaveDungeon>d__83>(ref <FinishSettlePlotBeforeLeaveDungeon>d__);
			return <FinishSettlePlotBeforeLeaveDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x06036BD9 RID: 224217 RVA: 0x00F4673F File Offset: 0x00F4493F
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

		// Token: 0x06036BDA RID: 224218 RVA: 0x00F46774 File Offset: 0x00F44974
		public void UnRegisterTermHyperlink(UUIText uiText)
		{
			if (!TermExplanationController.Instance.IsUiTextRegistered(uiText))
			{
				return;
			}
			TermExplanationController.Instance.UnRegisterTextHyperlink(uiText);
		}

		// Token: 0x06036BDB RID: 224219 RVA: 0x00F46790 File Offset: 0x00F44990
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

		// Token: 0x06036BDC RID: 224220 RVA: 0x00F467D6 File Offset: 0x00F449D6
		private void ClearAllReqInFlight()
		{
			this.ReqInFlight.Clear();
		}

		// Token: 0x06036BDD RID: 224221 RVA: 0x00F467E3 File Offset: 0x00F449E3
		private void ClearBagOperatePending()
		{
			this.ReqInFlight.Remove(ERequestMessageId.DangoBrawlBagOperateRequest);
		}

		// Token: 0x170069A8 RID: 27048
		// (get) Token: 0x06036BDE RID: 224222 RVA: 0x00F467F6 File Offset: 0x00F449F6
		public bool IsBagOperatePending
		{
			get
			{
				return this.ReqInFlight.Contains(ERequestMessageId.DangoBrawlBagOperateRequest);
			}
		}

		// Token: 0x170069A9 RID: 27049
		// (get) Token: 0x06036BDF RID: 224223 RVA: 0x00F46808 File Offset: 0x00F44A08
		public static ActivityDangoBrawlController Instance
		{
			get
			{
				return ActivityDangoBrawlController._Instance;
			}
		}

		// Token: 0x06036BE0 RID: 224224 RVA: 0x00F4680F File Offset: 0x00F44A0F
		public static ActivityDangoBrawlController GetOrCreateInstance()
		{
			if (ActivityDangoBrawlController._Instance == null)
			{
				ActivityDangoBrawlController.CreateInstance();
			}
			return ActivityDangoBrawlController._Instance;
		}

		// Token: 0x06036BE1 RID: 224225 RVA: 0x00F46823 File Offset: 0x00F44A23
		public static bool CreateInstance()
		{
			if (ActivityDangoBrawlController._Instance != null)
			{
				return true;
			}
			ActivityDangoBrawlController._Instance = new ActivityDangoBrawlController();
			return true;
		}

		// Token: 0x06036BE2 RID: 224226 RVA: 0x00F46839 File Offset: 0x00F44A39
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036BE3 RID: 224227 RVA: 0x00F4683B File Offset: 0x00F44A3B
		public static void ResetStaticDefaultValue()
		{
			ActivityDangoBrawlController._Instance = null;
		}

		// Token: 0x06036BE4 RID: 224228 RVA: 0x00F46843 File Offset: 0x00F44A43
		static ActivityDangoBrawlController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityDangoBrawlController.CreateStaticDefaultValue), new Action(ActivityDangoBrawlController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE8B RID: 118411
		private int ActivityId;

		// Token: 0x0401CE8C RID: 118412
		[Nullable(2)]
		private ActivityDangoBrawlData ActivityData;

		// Token: 0x0401CE8D RID: 118413
		private AfterLeaveInstanceDungeonOpenViewParam OpenViewParam;

		// Token: 0x0401CE8E RID: 118414
		private bool LastComposeIsFirstUnlock;

		// Token: 0x0401CE8F RID: 118415
		private bool HasThreeChoose;

		// Token: 0x0401CE90 RID: 118416
		private bool ThreeChooseResolved = true;

		// Token: 0x0401CE91 RID: 118417
		private ActivityDangoBrawlController.EThreeChooseGate ThreeChooseGate;

		// Token: 0x0401CE92 RID: 118418
		private ActivityDangoBrawlController.ERoundStartGate RoundStartGate;

		// Token: 0x0401CE93 RID: 118419
		private bool IsRoleUnlockShowing;

		// Token: 0x0401CE94 RID: 118420
		private const string SettleSequenceBlackScreenTag = "DangoBrawlSettle";

		// Token: 0x0401CE95 RID: 118421
		private const string LeaveSettleMaskContext = "DangoBrawlLeaveSettle";

		// Token: 0x0401CE96 RID: 118422
		private const float LeaveSettleMaskFadeInTime = 0.3f;

		// Token: 0x0401CE97 RID: 118423
		private const float LeaveSettleMaskKeepTime = 3000f;

		// Token: 0x0401CE98 RID: 118424
		private const float LeaveSettleMaskOpenTimeout = 1500f;

		// Token: 0x0401CE99 RID: 118425
		private const float LeaveSettlePlotEndTimeoutSeconds = 5f;

		// Token: 0x0401CE9A RID: 118426
		private readonly HashSet<ERequestMessageId> ReqInFlight = new HashSet<ERequestMessageId>();

		// Token: 0x0401CE9B RID: 118427
		[Nullable(2)]
		private static ActivityDangoBrawlController _Instance;

		// Token: 0x0200B29C RID: 45724
		[NullableContext(0)]
		[Flags]
		private enum ERoundStartGate
		{
			// Token: 0x040372F4 RID: 226036
			None = 0,
			// Token: 0x040372F5 RID: 226037
			TipsClosed = 1,
			// Token: 0x040372F6 RID: 226038
			ThreeChosen = 2
		}

		// Token: 0x0200B29D RID: 45725
		[NullableContext(0)]
		[Flags]
		private enum EThreeChooseGate
		{
			// Token: 0x040372F8 RID: 226040
			None = 0,
			// Token: 0x040372F9 RID: 226041
			TipsClosed = 1,
			// Token: 0x040372FA RID: 226042
			EventArrived = 2
		}
	}
}
