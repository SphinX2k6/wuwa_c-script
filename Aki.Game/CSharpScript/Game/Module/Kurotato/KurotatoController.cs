using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046AC RID: 18092
	[Controller(0)]
	public class KurotatoController : UiControllerBase
	{
		// Token: 0x0602D810 RID: 186384 RVA: 0x00CBD8C2 File Offset: 0x00CBBAC2
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602D811 RID: 186385 RVA: 0x00CBD8C8 File Offset: 0x00CBBAC8
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.KurotatoStepUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoStepUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoChestRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoChestRewardNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoUpgradeRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoUpgradeRewardNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoSystemInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoSystemInfoNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoShopRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoShopRewardNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoItemUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoAllItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoAllItemUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoWeaponUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoWeaponUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoSettlementNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoSettlementNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoRoleRecordNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoRoleRecordNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoPropertyUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoPropertyUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoRefineWeaponNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoRefineWeaponNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoDieNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoDieNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoReChallengeCountNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoReChallengeCountNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoNextWaveTypeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoNextWaveTypeNotify));
		}

		// Token: 0x0602D812 RID: 186386 RVA: 0x00CBDA7C File Offset: 0x00CBBC7C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoStepUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoChestRewardNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoUpgradeRewardNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoSystemInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoShopRewardNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoItemUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoAllItemUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoWeaponUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoSettlementNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoRoleRecordNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoPropertyUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoRefineWeaponNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoDieNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoReChallengeCountNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoNextWaveTypeNotify);
		}

		// Token: 0x0602D813 RID: 186387 RVA: 0x00CBDB7C File Offset: 0x00CBBD7C
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0602D814 RID: 186388 RVA: 0x00CBDBDC File Offset: 0x00CBBDDC
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0602D815 RID: 186389 RVA: 0x00CBDC3A File Offset: 0x00CBBE3A
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName == EUiViewName.KurotatoPauseView)
			{
				this.ReconcileStepView();
			}
		}

		// Token: 0x0602D816 RID: 186390 RVA: 0x00CBDC4F File Offset: 0x00CBBE4F
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.LevelUpView, new Func<EUiViewName, object, bool>(this.CheckCanOpenLevelUpView), "KurotatoController.CheckCanOpenLevelUpView");
		}

		// Token: 0x0602D817 RID: 186391 RVA: 0x00CBDC71 File Offset: 0x00CBBE71
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.LevelUpView, new Func<EUiViewName, object, bool>(this.CheckCanOpenLevelUpView));
		}

		// Token: 0x0602D818 RID: 186392 RVA: 0x00CBDC90 File Offset: 0x00CBBE90
		public void RequestEnterInst(int levelId, int roleId, bool isContinue)
		{
			KurotatoCtx kurotatoCtx = new KurotatoCtx
			{
				Continue = isContinue,
				RoleId = roleId,
				LevelId = levelId
			};
			int kurotatoRoleId = roleId;
			if (roleId == 0)
			{
				KurotatoInstInfo archivedData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoLevelData(levelId).ArchivedData;
				kurotatoRoleId = ((archivedData != null) ? archivedData.RoleId : 0);
			}
			int dataId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(kurotatoRoleId).GetDataId();
			InstanceDungeonModel.Instance.InstanceEnterContentText.KurotatoCtx = kurotatoCtx;
			InstanceDungeonController.Instance.PrewarTeamFightRequest(0, new List<int>
			{
				dataId
			}, 0, 0, null, null).Forget<bool>();
		}

		// Token: 0x0602D819 RID: 186393 RVA: 0x00CBDD20 File Offset: 0x00CBBF20
		public UniTask<bool> RequestKurotatoLevelRecordDelete(int levelId)
		{
			KurotatoController.<RequestKurotatoLevelRecordDelete>d__12 <RequestKurotatoLevelRecordDelete>d__;
			<RequestKurotatoLevelRecordDelete>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoLevelRecordDelete>d__.levelId = levelId;
			<RequestKurotatoLevelRecordDelete>d__.<>1__state = -1;
			<RequestKurotatoLevelRecordDelete>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoLevelRecordDelete>d__12>(ref <RequestKurotatoLevelRecordDelete>d__);
			return <RequestKurotatoLevelRecordDelete>d__.<>t__builder.Task;
		}

		// Token: 0x0602D81A RID: 186394 RVA: 0x00CBDD64 File Offset: 0x00CBBF64
		public UniTask<bool> RequestKurotatoChestRewardSelect(bool willSold)
		{
			KurotatoController.<RequestKurotatoChestRewardSelect>d__13 <RequestKurotatoChestRewardSelect>d__;
			<RequestKurotatoChestRewardSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoChestRewardSelect>d__.willSold = willSold;
			<RequestKurotatoChestRewardSelect>d__.<>1__state = -1;
			<RequestKurotatoChestRewardSelect>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoChestRewardSelect>d__13>(ref <RequestKurotatoChestRewardSelect>d__);
			return <RequestKurotatoChestRewardSelect>d__.<>t__builder.Task;
		}

		// Token: 0x0602D81B RID: 186395 RVA: 0x00CBDDA8 File Offset: 0x00CBBFA8
		public UniTask<bool> RequestKurotatoUpgradeRewardSelect(int selectionId)
		{
			KurotatoController.<RequestKurotatoUpgradeRewardSelect>d__14 <RequestKurotatoUpgradeRewardSelect>d__;
			<RequestKurotatoUpgradeRewardSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoUpgradeRewardSelect>d__.selectionId = selectionId;
			<RequestKurotatoUpgradeRewardSelect>d__.<>1__state = -1;
			<RequestKurotatoUpgradeRewardSelect>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoUpgradeRewardSelect>d__14>(ref <RequestKurotatoUpgradeRewardSelect>d__);
			return <RequestKurotatoUpgradeRewardSelect>d__.<>t__builder.Task;
		}

		// Token: 0x0602D81C RID: 186396 RVA: 0x00CBDDEC File Offset: 0x00CBBFEC
		public UniTask<bool> RequestKurotatoUpgradeRewardRefresh()
		{
			KurotatoController.<RequestKurotatoUpgradeRewardRefresh>d__15 <RequestKurotatoUpgradeRewardRefresh>d__;
			<RequestKurotatoUpgradeRewardRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoUpgradeRewardRefresh>d__.<>1__state = -1;
			<RequestKurotatoUpgradeRewardRefresh>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoUpgradeRewardRefresh>d__15>(ref <RequestKurotatoUpgradeRewardRefresh>d__);
			return <RequestKurotatoUpgradeRewardRefresh>d__.<>t__builder.Task;
		}

		// Token: 0x0602D81D RID: 186397 RVA: 0x00CBDE28 File Offset: 0x00CBC028
		public UniTask<bool> RequestKurotatoShopProductSelect(int selectionId)
		{
			KurotatoController.<RequestKurotatoShopProductSelect>d__16 <RequestKurotatoShopProductSelect>d__;
			<RequestKurotatoShopProductSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoShopProductSelect>d__.selectionId = selectionId;
			<RequestKurotatoShopProductSelect>d__.<>1__state = -1;
			<RequestKurotatoShopProductSelect>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoShopProductSelect>d__16>(ref <RequestKurotatoShopProductSelect>d__);
			return <RequestKurotatoShopProductSelect>d__.<>t__builder.Task;
		}

		// Token: 0x0602D81E RID: 186398 RVA: 0x00CBDE6C File Offset: 0x00CBC06C
		public UniTask<bool> RequestKurotatoShopRewardLock(int selectionId)
		{
			KurotatoController.<RequestKurotatoShopRewardLock>d__17 <RequestKurotatoShopRewardLock>d__;
			<RequestKurotatoShopRewardLock>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoShopRewardLock>d__.selectionId = selectionId;
			<RequestKurotatoShopRewardLock>d__.<>1__state = -1;
			<RequestKurotatoShopRewardLock>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoShopRewardLock>d__17>(ref <RequestKurotatoShopRewardLock>d__);
			return <RequestKurotatoShopRewardLock>d__.<>t__builder.Task;
		}

		// Token: 0x0602D81F RID: 186399 RVA: 0x00CBDEB0 File Offset: 0x00CBC0B0
		public UniTask<bool> RequestKurotatoShopRewardRefresh()
		{
			KurotatoController.<RequestKurotatoShopRewardRefresh>d__18 <RequestKurotatoShopRewardRefresh>d__;
			<RequestKurotatoShopRewardRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoShopRewardRefresh>d__.<>1__state = -1;
			<RequestKurotatoShopRewardRefresh>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoShopRewardRefresh>d__18>(ref <RequestKurotatoShopRewardRefresh>d__);
			return <RequestKurotatoShopRewardRefresh>d__.<>t__builder.Task;
		}

		// Token: 0x0602D820 RID: 186400 RVA: 0x00CBDEEC File Offset: 0x00CBC0EC
		public UniTask<bool> RequestKurotatoEndShopStep(bool isEndLess)
		{
			KurotatoController.<RequestKurotatoEndShopStep>d__19 <RequestKurotatoEndShopStep>d__;
			<RequestKurotatoEndShopStep>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoEndShopStep>d__.isEndLess = isEndLess;
			<RequestKurotatoEndShopStep>d__.<>1__state = -1;
			<RequestKurotatoEndShopStep>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoEndShopStep>d__19>(ref <RequestKurotatoEndShopStep>d__);
			return <RequestKurotatoEndShopStep>d__.<>t__builder.Task;
		}

		// Token: 0x0602D821 RID: 186401 RVA: 0x00CBDF30 File Offset: 0x00CBC130
		public UniTask<bool> RequestKurotatoStepAdvance()
		{
			KurotatoController.<RequestKurotatoStepAdvance>d__20 <RequestKurotatoStepAdvance>d__;
			<RequestKurotatoStepAdvance>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoStepAdvance>d__.<>1__state = -1;
			<RequestKurotatoStepAdvance>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoStepAdvance>d__20>(ref <RequestKurotatoStepAdvance>d__);
			return <RequestKurotatoStepAdvance>d__.<>t__builder.Task;
		}

		// Token: 0x0602D822 RID: 186402 RVA: 0x00CBDF6C File Offset: 0x00CBC16C
		public bool CheckInKurotatoInstance()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 51;
		}

		// Token: 0x0602D823 RID: 186403 RVA: 0x00CBDFBD File Offset: 0x00CBC1BD
		[NullableContext(1)]
		private bool CheckCanOpenLevelUpView(EUiViewName viewName, object param)
		{
			return !this.CheckInKurotatoInstance();
		}

		// Token: 0x0602D824 RID: 186404 RVA: 0x00CBDFC8 File Offset: 0x00CBC1C8
		public UniTask<bool> RequestKurotatoRefineWeapon(int weaponIncId)
		{
			KurotatoController.<RequestKurotatoRefineWeapon>d__23 <RequestKurotatoRefineWeapon>d__;
			<RequestKurotatoRefineWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoRefineWeapon>d__.weaponIncId = weaponIncId;
			<RequestKurotatoRefineWeapon>d__.<>1__state = -1;
			<RequestKurotatoRefineWeapon>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoRefineWeapon>d__23>(ref <RequestKurotatoRefineWeapon>d__);
			return <RequestKurotatoRefineWeapon>d__.<>t__builder.Task;
		}

		// Token: 0x0602D825 RID: 186405 RVA: 0x00CBE00C File Offset: 0x00CBC20C
		public UniTask<bool> RequestKurotatoRoleRecord()
		{
			KurotatoController.<RequestKurotatoRoleRecord>d__24 <RequestKurotatoRoleRecord>d__;
			<RequestKurotatoRoleRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoRoleRecord>d__.<>1__state = -1;
			<RequestKurotatoRoleRecord>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoRoleRecord>d__24>(ref <RequestKurotatoRoleRecord>d__);
			return <RequestKurotatoRoleRecord>d__.<>t__builder.Task;
		}

		// Token: 0x0602D826 RID: 186406 RVA: 0x00CBE048 File Offset: 0x00CBC248
		public UniTask<bool> RequestKurotatoSettlement()
		{
			KurotatoController.<RequestKurotatoSettlement>d__25 <RequestKurotatoSettlement>d__;
			<RequestKurotatoSettlement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoSettlement>d__.<>1__state = -1;
			<RequestKurotatoSettlement>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoSettlement>d__25>(ref <RequestKurotatoSettlement>d__);
			return <RequestKurotatoSettlement>d__.<>t__builder.Task;
		}

		// Token: 0x0602D827 RID: 186407 RVA: 0x00CBE084 File Offset: 0x00CBC284
		public UniTask<bool> RequestKurotatoEndSpecialWaveCombat()
		{
			KurotatoController.<RequestKurotatoEndSpecialWaveCombat>d__26 <RequestKurotatoEndSpecialWaveCombat>d__;
			<RequestKurotatoEndSpecialWaveCombat>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoEndSpecialWaveCombat>d__.<>1__state = -1;
			<RequestKurotatoEndSpecialWaveCombat>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoEndSpecialWaveCombat>d__26>(ref <RequestKurotatoEndSpecialWaveCombat>d__);
			return <RequestKurotatoEndSpecialWaveCombat>d__.<>t__builder.Task;
		}

		// Token: 0x0602D828 RID: 186408 RVA: 0x00CBE0C0 File Offset: 0x00CBC2C0
		public UniTask<bool> RequestKurotatoReChallenge(bool isFromCurWave)
		{
			KurotatoController.<RequestKurotatoReChallenge>d__27 <RequestKurotatoReChallenge>d__;
			<RequestKurotatoReChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoReChallenge>d__.isFromCurWave = isFromCurWave;
			<RequestKurotatoReChallenge>d__.<>1__state = -1;
			<RequestKurotatoReChallenge>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoReChallenge>d__27>(ref <RequestKurotatoReChallenge>d__);
			return <RequestKurotatoReChallenge>d__.<>t__builder.Task;
		}

		// Token: 0x0602D829 RID: 186409 RVA: 0x00CBE104 File Offset: 0x00CBC304
		public UniTask<bool> RequestKurotatoGoldAdd(int goldCount)
		{
			KurotatoController.<RequestKurotatoGoldAdd>d__28 <RequestKurotatoGoldAdd>d__;
			<RequestKurotatoGoldAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoGoldAdd>d__.goldCount = goldCount;
			<RequestKurotatoGoldAdd>d__.<>1__state = -1;
			<RequestKurotatoGoldAdd>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoGoldAdd>d__28>(ref <RequestKurotatoGoldAdd>d__);
			return <RequestKurotatoGoldAdd>d__.<>t__builder.Task;
		}

		// Token: 0x0602D82A RID: 186410 RVA: 0x00CBE148 File Offset: 0x00CBC348
		public UniTask<bool> RequestKurotatoSellWeapon(int weaponIncId)
		{
			KurotatoController.<RequestKurotatoSellWeapon>d__29 <RequestKurotatoSellWeapon>d__;
			<RequestKurotatoSellWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoSellWeapon>d__.weaponIncId = weaponIncId;
			<RequestKurotatoSellWeapon>d__.<>1__state = -1;
			<RequestKurotatoSellWeapon>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoSellWeapon>d__29>(ref <RequestKurotatoSellWeapon>d__);
			return <RequestKurotatoSellWeapon>d__.<>t__builder.Task;
		}

		// Token: 0x0602D82B RID: 186411 RVA: 0x00CBE18C File Offset: 0x00CBC38C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<HashSet<int>> RequestKurotatoConditionGroupState(int conditionGroupId)
		{
			KurotatoController.<RequestKurotatoConditionGroupState>d__30 <RequestKurotatoConditionGroupState>d__;
			<RequestKurotatoConditionGroupState>d__.<>t__builder = AsyncUniTaskMethodBuilder<HashSet<int>>.Create();
			<RequestKurotatoConditionGroupState>d__.conditionGroupId = conditionGroupId;
			<RequestKurotatoConditionGroupState>d__.<>1__state = -1;
			<RequestKurotatoConditionGroupState>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoConditionGroupState>d__30>(ref <RequestKurotatoConditionGroupState>d__);
			return <RequestKurotatoConditionGroupState>d__.<>t__builder.Task;
		}

		// Token: 0x0602D82C RID: 186412 RVA: 0x00CBE1D0 File Offset: 0x00CBC3D0
		[NullableContext(2)]
		private void OnKurotatoStepUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoStepUpdateNotify stepData = (KurotatoStepUpdateNotify)msg;
			KurotatoModel.Instance.SetStepData(stepData);
			EKurotatoStep step = KurotatoModel.Instance.GetStep();
			if (step == EKurotatoStep.Combat && !KurotatoModel.Instance.GetBattleMusicStarted())
			{
				KurotatoModel.Instance.SetBattleMusicStarted(true);
				AudioSystem.Instance.PostEvent("play_ui_music_3_5_wuyinweiji");
			}
			EKurotatoStep prevStep = KurotatoModel.Instance.GetPrevStep();
			if (step != EKurotatoStep.End && prevStep == EKurotatoStep.End && KurotatoModel.Instance.GetIsStepStart())
			{
				if (!UiManager.Instance.IsViewOpen(EUiViewName.KurotatoContentView))
				{
					UiManager.Instance.OpenView(EUiViewName.KurotatoContentView, null, null);
				}
			}
			else if (step == EKurotatoStep.Combat && UiManager.Instance.IsViewOpen(EUiViewName.KurotatoContentView))
			{
				UiManager.Instance.CloseView(EUiViewName.KurotatoContentView, null);
			}
			this.ReconcileStepView();
		}

		// Token: 0x0602D82D RID: 186413 RVA: 0x00CBE294 File Offset: 0x00CBC494
		private void ReconcileStepView()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.KurotatoPauseView))
			{
				return;
			}
			KurotatoModel instance = KurotatoModel.Instance;
			EKurotatoStep step = instance.GetStep();
			EUiViewName? euiViewName = null;
			bool isStepStart = instance.GetIsStepStart();
			if (isStepStart && step == EKurotatoStep.ChestReward && instance.GetChestItemId() > 0)
			{
				euiViewName = new EUiViewName?(EUiViewName.KurotatoBoxDropMainView);
			}
			else if (isStepStart && step == EKurotatoStep.UpgradeReward && instance.GetUpgradeRewardData().Count > 0)
			{
				euiViewName = new EUiViewName?(EUiViewName.KurotatoAttrSelectMainView);
			}
			else if (isStepStart && step == EKurotatoStep.Shop)
			{
				euiViewName = new EUiViewName?(EUiViewName.KurotatoShopMainView);
			}
			foreach (EUiViewName euiViewName2 in new EUiViewName[]
			{
				EUiViewName.KurotatoBoxDropMainView,
				EUiViewName.KurotatoAttrSelectMainView,
				EUiViewName.KurotatoShopMainView
			})
			{
				if (euiViewName2 != euiViewName && UiManager.Instance.IsViewOpen(euiViewName2))
				{
					UiManager.Instance.CloseView(euiViewName2, null);
				}
			}
			if (euiViewName != null && !UiManager.Instance.IsViewOpen(euiViewName.Value))
			{
				UiManager.Instance.OpenView(euiViewName.Value, null, null);
			}
		}

		// Token: 0x0602D82E RID: 186414 RVA: 0x00CBE3DC File Offset: 0x00CBC5DC
		[NullableContext(2)]
		private void OnKurotatoChestRewardNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoChestRewardNotify kurotatoChestRewardNotify = (KurotatoChestRewardNotify)msg;
			KurotatoModel.Instance.SetChestRewardData(kurotatoChestRewardNotify.ItemId, kurotatoChestRewardNotify.SoldPrice, kurotatoChestRewardNotify.RewardIndex, kurotatoChestRewardNotify.TotalRewardCount);
			this.ReconcileStepView();
		}

		// Token: 0x0602D82F RID: 186415 RVA: 0x00CBE418 File Offset: 0x00CBC618
		[NullableContext(2)]
		private void OnKurotatoUpgradeRewardNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoUpgradeRewardNotify kurotatoUpgradeRewardNotify = (KurotatoUpgradeRewardNotify)msg;
			KurotatoModel.Instance.SetUpgradeRewardData(kurotatoUpgradeRewardNotify.PanelPbData);
			this.ReconcileStepView();
		}

		// Token: 0x0602D830 RID: 186416 RVA: 0x00CBE444 File Offset: 0x00CBC644
		[NullableContext(2)]
		private void OnKurotatoSystemInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoSystemInfoNotify kurotatoSystemInfoNotify = (KurotatoSystemInfoNotify)msg;
			KurotatoModel.Instance.SetCurLevelId(kurotatoSystemInfoNotify.LevelId);
			KurotatoModel.Instance.SetRoleId(kurotatoSystemInfoNotify.CharacterId);
			KurotatoModel.Instance.SetSystemPropertyValues(kurotatoSystemInfoNotify.PropertyValues, kurotatoSystemInfoNotify.LockedPropertyValues);
			KurotatoModel.Instance.UpdateItemPanel(kurotatoSystemInfoNotify.ItemPanelPbData);
			KurotatoModel.Instance.UpdateWeapon(kurotatoSystemInfoNotify.WeaponPanelPbData);
			KurotatoModel.Instance.BattleData.SetBehaviorTreeVar(kurotatoSystemInfoNotify.VariableKeyNames);
			KscSubControllerBase curSubController = KuroSimpleCombatController.Instance.CurSubController;
			if (curSubController != null)
			{
				curSubController.OnSystemInfoNotify();
			}
			EventSystem.Instance.Emit(EEventName.KurotatoOnSystemInfoUpdate);
		}

		// Token: 0x0602D831 RID: 186417 RVA: 0x00CBE4E8 File Offset: 0x00CBC6E8
		[NullableContext(2)]
		private void OnKurotatoShopRewardNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoShopRewardNotify kurotatoShopRewardNotify = (KurotatoShopRewardNotify)msg;
			KurotatoModel.Instance.SetShopData(kurotatoShopRewardNotify.PanelPbData);
		}

		// Token: 0x0602D832 RID: 186418 RVA: 0x00CBE50C File Offset: 0x00CBC70C
		[NullableContext(2)]
		private void OnKurotatoItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoItemUpdateNotify kurotatoItemUpdateNotify = (KurotatoItemUpdateNotify)msg;
			KurotatoModel.Instance.UpdateItem(new KurotatoItemData
			{
				ItemId = kurotatoItemUpdateNotify.ItemPbData.ItemId,
				Count = kurotatoItemUpdateNotify.ItemPbData.Count
			}, kurotatoItemUpdateNotify.IsAdd);
		}

		// Token: 0x0602D833 RID: 186419 RVA: 0x00CBE558 File Offset: 0x00CBC758
		[NullableContext(2)]
		private void OnKurotatoAllItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoAllItemUpdateNotify kurotatoAllItemUpdateNotify = (KurotatoAllItemUpdateNotify)msg;
			KurotatoModel.Instance.UpdateItemPanel(kurotatoAllItemUpdateNotify.PanelPbData);
		}

		// Token: 0x0602D834 RID: 186420 RVA: 0x00CBE57C File Offset: 0x00CBC77C
		[NullableContext(2)]
		private void OnKurotatoWeaponUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoWeaponUpdateNotify kurotatoWeaponUpdateNotify = (KurotatoWeaponUpdateNotify)msg;
			KurotatoModel.Instance.UpdateWeapon(kurotatoWeaponUpdateNotify.PanelPbData);
		}

		// Token: 0x0602D835 RID: 186421 RVA: 0x00CBE5A0 File Offset: 0x00CBC7A0
		[NullableContext(2)]
		private void OnKurotatoSettlementNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoSettlementNotify settlementData = (KurotatoSettlementNotify)msg;
			this.StopBattleMusic();
			KurotatoModel.Instance.SetSettlementData(settlementData);
			UiManager.Instance.OpenView(EUiViewName.KurotatoSettleView, null, null);
		}

		// Token: 0x0602D836 RID: 186422 RVA: 0x00CBE5D8 File Offset: 0x00CBC7D8
		[NullableContext(2)]
		private void OnKurotatoRoleRecordNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoRoleRecordNotify kurotatoRoleRecordNotify = (KurotatoRoleRecordNotify)msg;
			KurotatoModel.Instance.SetRoleSaveState(kurotatoRoleRecordNotify.KurotatoRoleSaveState);
			KurotatoModel.Instance.SetRoleSaveIsPopView(kurotatoRoleRecordNotify.IsPopView);
			KurotatoModel.Instance.SetRoleSaveInstInfos(new List<KurotatoInstInfo>(kurotatoRoleRecordNotify.InstInfos));
			EventSystem.Instance.Emit(EEventName.KurotatoOnRoleSaveStateUpdate);
			if (kurotatoRoleRecordNotify.IsPopView)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KurotatoSaveNotifyConfirm);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
		}

		// Token: 0x0602D837 RID: 186423 RVA: 0x00CBE650 File Offset: 0x00CBC850
		private void OnWorldDone()
		{
			if (this.IsNeedShowMainViewInternal)
			{
				this.IsNeedShowMainViewInternal = false;
				this.AddMainViewSplashTask();
			}
		}

		// Token: 0x0602D838 RID: 186424 RVA: 0x00CBE668 File Offset: 0x00CBC868
		private void AddMainViewSplashTask()
		{
			KurotatoController.<>c__DisplayClass43_0 CS$<>8__locals1 = new KurotatoController.<>c__DisplayClass43_0();
			KurotatoController.<>c__DisplayClass43_0 CS$<>8__locals2 = CS$<>8__locals1;
			KurotatoActivityController instance = KurotatoActivityController.Instance;
			CS$<>8__locals2.activityData = ((instance != null) ? instance.GetActivityData() : null);
			if (CS$<>8__locals1.activityData == null)
			{
				return;
			}
			SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.KurotatoMainView, CS$<>8__locals1.activityData, null);
			});
			SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
		}

		// Token: 0x0602D839 RID: 186425 RVA: 0x00CBE6BC File Offset: 0x00CBC8BC
		private void OnInstanceChange(int lastInstanceId, int newInstanceId)
		{
			InstanceDungeon? instanceDungeon = (lastInstanceId > 0) ? InstanceDungeonConfig.Instance.GetConfig(lastInstanceId) : null;
			InstanceDungeon? instanceDungeon2 = (newInstanceId > 0) ? InstanceDungeonConfig.Instance.GetConfig(newInstanceId) : null;
			bool flag = instanceDungeon2 != null && instanceDungeon2.GetValueOrDefault().InstSubType == 51;
			if (flag)
			{
				SkillButtonUiController.Instance.AddEventInterface(KurotatoModel.Instance.BattleData);
			}
			else
			{
				SkillButtonUiController.Instance.RemoveEventInterface(KurotatoModel.Instance.BattleData);
			}
			bool flag2 = instanceDungeon != null && instanceDungeon.GetValueOrDefault().InstSubType == 51;
			if (flag2 && !flag)
			{
				this.StopBattleMusic();
			}
			if (flag2)
			{
				KurotatoModel.Instance.ClearInGameData();
			}
		}

		// Token: 0x0602D83A RID: 186426 RVA: 0x00CBE788 File Offset: 0x00CBC988
		[NullableContext(2)]
		private void OnKurotatoPropertyUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoPropertyUpdateNotify kurotatoPropertyUpdateNotify = (KurotatoPropertyUpdateNotify)msg;
			EventSystem.Instance.Emit<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, kurotatoPropertyUpdateNotify.PropertyValues);
			KurotatoModel.Instance.UpdateSystemPropertyValues(kurotatoPropertyUpdateNotify.PropertyValues, kurotatoPropertyUpdateNotify.LockedPropertyValues);
		}

		// Token: 0x0602D83B RID: 186427 RVA: 0x00CBE7C8 File Offset: 0x00CBC9C8
		[NullableContext(2)]
		private void OnKurotatoRefineWeaponNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoRefineWeaponNotify kurotatoRefineWeaponNotify = (KurotatoRefineWeaponNotify)msg;
			ScrollingTipsController.Instance.ShowTipsByTextId("kurotato_weaponcombinsucceed", Array.Empty<object>());
			EventSystem.Instance.Emit<int>(EEventName.KurotatoOnWeaponRefined, kurotatoRefineWeaponNotify.NewWeaponIncId);
		}

		// Token: 0x0602D83C RID: 186428 RVA: 0x00CBE806 File Offset: 0x00CBCA06
		[NullableContext(2)]
		private void OnKurotatoDieNotify(IMessage msg, Net.CallbackStatus status)
		{
			this.StopBattleMusic();
			EventSystem.Instance.Emit(EEventName.KurotatoOnPlayerDie);
		}

		// Token: 0x0602D83D RID: 186429 RVA: 0x00CBE820 File Offset: 0x00CBCA20
		private void StopBattleMusic()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			if (!instance.GetBattleMusicStarted())
			{
				return;
			}
			instance.SetBattleMusicStarted(false);
			AudioSystem.Instance.PostEvent("stop_ui_music_3_5_wuyinweiji");
		}

		// Token: 0x0602D83E RID: 186430 RVA: 0x00CBE854 File Offset: 0x00CBCA54
		[NullableContext(2)]
		private void OnKurotatoReChallengeCountNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoReChallengeCountNotify kurotatoReChallengeCountNotify = (KurotatoReChallengeCountNotify)msg;
			KurotatoModel.Instance.SetReChallengeCount(kurotatoReChallengeCountNotify.MaxReChallengeCount, kurotatoReChallengeCountNotify.UsedReChallengeCount);
		}

		// Token: 0x0602D83F RID: 186431 RVA: 0x00CBE880 File Offset: 0x00CBCA80
		[NullableContext(2)]
		private void OnKurotatoNextWaveTypeNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoNextWaveTypeNotify kurotatoNextWaveTypeNotify = (KurotatoNextWaveTypeNotify)msg;
			KurotatoModel.Instance.SetNextWaveType(kurotatoNextWaveTypeNotify.NextWaveType, kurotatoNextWaveTypeNotify.NextWaveId);
			EventSystem.Instance.Emit(EEventName.KurotatoOnNextWaveTypeUpdate);
		}

		// Token: 0x0602D840 RID: 186432 RVA: 0x00CBE8BC File Offset: 0x00CBCABC
		public void LeaveInstanceDungeon()
		{
			this.StopBattleMusic();
			KurotatoActivityController instance = KurotatoActivityController.Instance;
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData kurotatoActivityData = (instance != null) ? instance.GetActivityData() : null;
			if (kurotatoActivityData != null && !kurotatoActivityData.CheckIfClose())
			{
				this.IsNeedShowMainViewInternal = true;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		}

		// Token: 0x17005B75 RID: 23413
		// (get) Token: 0x0602D841 RID: 186433 RVA: 0x00CBE902 File Offset: 0x00CBCB02
		[Nullable(1)]
		public static KurotatoController Instance
		{
			[NullableContext(1)]
			get
			{
				return KurotatoController._Instance;
			}
		}

		// Token: 0x0602D842 RID: 186434 RVA: 0x00CBE909 File Offset: 0x00CBCB09
		[NullableContext(1)]
		public static KurotatoController GetOrCreateInstance()
		{
			if (KurotatoController._Instance == null)
			{
				KurotatoController.CreateInstance();
			}
			return KurotatoController._Instance;
		}

		// Token: 0x0602D843 RID: 186435 RVA: 0x00CBE91D File Offset: 0x00CBCB1D
		public static bool CreateInstance()
		{
			if (KurotatoController._Instance != null)
			{
				return true;
			}
			KurotatoController._Instance = new KurotatoController();
			return true;
		}

		// Token: 0x0602D844 RID: 186436 RVA: 0x00CBE933 File Offset: 0x00CBCB33
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D845 RID: 186437 RVA: 0x00CBE935 File Offset: 0x00CBCB35
		public static void ResetStaticDefaultValue()
		{
			KurotatoController._Instance = null;
		}

		// Token: 0x0602D846 RID: 186438 RVA: 0x00CBE93D File Offset: 0x00CBCB3D
		static KurotatoController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KurotatoController.CreateStaticDefaultValue), new Action(KurotatoController.ResetStaticDefaultValue));
		}

		// Token: 0x040185BE RID: 99774
		private bool IsNeedShowMainViewInternal;

		// Token: 0x040185BF RID: 99775
		[Nullable(1)]
		private const string KUROTATO_BATTLE_MUSIC_PLAY = "play_ui_music_3_5_wuyinweiji";

		// Token: 0x040185C0 RID: 99776
		[Nullable(1)]
		private const string KUROTATO_BATTLE_MUSIC_STOP = "stop_ui_music_3_5_wuyinweiji";

		// Token: 0x040185C1 RID: 99777
		[Nullable(2)]
		private static KurotatoController _Instance;
	}
}
