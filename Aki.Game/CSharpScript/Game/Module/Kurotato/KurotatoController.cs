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
	// Token: 0x020056D5 RID: 22229
	[Controller(0)]
	public class KurotatoController : UiControllerBase
	{
		// Token: 0x06038900 RID: 231680 RVA: 0x00D6F2DA File Offset: 0x00D6D4DA
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06038901 RID: 231681 RVA: 0x00D6F2E0 File Offset: 0x00D6D4E0
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

		// Token: 0x06038902 RID: 231682 RVA: 0x00D6F494 File Offset: 0x00D6D694
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

		// Token: 0x06038903 RID: 231683 RVA: 0x00D6F594 File Offset: 0x00D6D794
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x06038904 RID: 231684 RVA: 0x00D6F5F4 File Offset: 0x00D6D7F4
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x06038905 RID: 231685 RVA: 0x00D6F652 File Offset: 0x00D6D852
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName == EUiViewName.KurotatoPauseView)
			{
				this.ReconcileStepView();
			}
		}

		// Token: 0x06038906 RID: 231686 RVA: 0x00D6F667 File Offset: 0x00D6D867
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.LevelUpView, new Func<EUiViewName, object, bool>(this.CheckCanOpenLevelUpView), "KurotatoController.CheckCanOpenLevelUpView");
		}

		// Token: 0x06038907 RID: 231687 RVA: 0x00D6F689 File Offset: 0x00D6D889
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.LevelUpView, new Func<EUiViewName, object, bool>(this.CheckCanOpenLevelUpView));
		}

		// Token: 0x06038908 RID: 231688 RVA: 0x00D6F6A8 File Offset: 0x00D6D8A8
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

		// Token: 0x06038909 RID: 231689 RVA: 0x00D6F738 File Offset: 0x00D6D938
		public UniTask<bool> RequestKurotatoLevelRecordDelete(int levelId)
		{
			KurotatoController.<RequestKurotatoLevelRecordDelete>d__12 <RequestKurotatoLevelRecordDelete>d__;
			<RequestKurotatoLevelRecordDelete>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoLevelRecordDelete>d__.levelId = levelId;
			<RequestKurotatoLevelRecordDelete>d__.<>1__state = -1;
			<RequestKurotatoLevelRecordDelete>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoLevelRecordDelete>d__12>(ref <RequestKurotatoLevelRecordDelete>d__);
			return <RequestKurotatoLevelRecordDelete>d__.<>t__builder.Task;
		}

		// Token: 0x0603890A RID: 231690 RVA: 0x00D6F77C File Offset: 0x00D6D97C
		public UniTask<bool> RequestKurotatoChestRewardSelect(bool willSold)
		{
			KurotatoController.<RequestKurotatoChestRewardSelect>d__13 <RequestKurotatoChestRewardSelect>d__;
			<RequestKurotatoChestRewardSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoChestRewardSelect>d__.willSold = willSold;
			<RequestKurotatoChestRewardSelect>d__.<>1__state = -1;
			<RequestKurotatoChestRewardSelect>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoChestRewardSelect>d__13>(ref <RequestKurotatoChestRewardSelect>d__);
			return <RequestKurotatoChestRewardSelect>d__.<>t__builder.Task;
		}

		// Token: 0x0603890B RID: 231691 RVA: 0x00D6F7C0 File Offset: 0x00D6D9C0
		public UniTask<bool> RequestKurotatoUpgradeRewardSelect(int selectionId)
		{
			KurotatoController.<RequestKurotatoUpgradeRewardSelect>d__14 <RequestKurotatoUpgradeRewardSelect>d__;
			<RequestKurotatoUpgradeRewardSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoUpgradeRewardSelect>d__.selectionId = selectionId;
			<RequestKurotatoUpgradeRewardSelect>d__.<>1__state = -1;
			<RequestKurotatoUpgradeRewardSelect>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoUpgradeRewardSelect>d__14>(ref <RequestKurotatoUpgradeRewardSelect>d__);
			return <RequestKurotatoUpgradeRewardSelect>d__.<>t__builder.Task;
		}

		// Token: 0x0603890C RID: 231692 RVA: 0x00D6F804 File Offset: 0x00D6DA04
		public UniTask<bool> RequestKurotatoUpgradeRewardRefresh()
		{
			KurotatoController.<RequestKurotatoUpgradeRewardRefresh>d__15 <RequestKurotatoUpgradeRewardRefresh>d__;
			<RequestKurotatoUpgradeRewardRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoUpgradeRewardRefresh>d__.<>1__state = -1;
			<RequestKurotatoUpgradeRewardRefresh>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoUpgradeRewardRefresh>d__15>(ref <RequestKurotatoUpgradeRewardRefresh>d__);
			return <RequestKurotatoUpgradeRewardRefresh>d__.<>t__builder.Task;
		}

		// Token: 0x0603890D RID: 231693 RVA: 0x00D6F840 File Offset: 0x00D6DA40
		public UniTask<bool> RequestKurotatoShopProductSelect(int selectionId)
		{
			KurotatoController.<RequestKurotatoShopProductSelect>d__16 <RequestKurotatoShopProductSelect>d__;
			<RequestKurotatoShopProductSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoShopProductSelect>d__.selectionId = selectionId;
			<RequestKurotatoShopProductSelect>d__.<>1__state = -1;
			<RequestKurotatoShopProductSelect>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoShopProductSelect>d__16>(ref <RequestKurotatoShopProductSelect>d__);
			return <RequestKurotatoShopProductSelect>d__.<>t__builder.Task;
		}

		// Token: 0x0603890E RID: 231694 RVA: 0x00D6F884 File Offset: 0x00D6DA84
		public UniTask<bool> RequestKurotatoShopRewardLock(int selectionId)
		{
			KurotatoController.<RequestKurotatoShopRewardLock>d__17 <RequestKurotatoShopRewardLock>d__;
			<RequestKurotatoShopRewardLock>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoShopRewardLock>d__.selectionId = selectionId;
			<RequestKurotatoShopRewardLock>d__.<>1__state = -1;
			<RequestKurotatoShopRewardLock>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoShopRewardLock>d__17>(ref <RequestKurotatoShopRewardLock>d__);
			return <RequestKurotatoShopRewardLock>d__.<>t__builder.Task;
		}

		// Token: 0x0603890F RID: 231695 RVA: 0x00D6F8C8 File Offset: 0x00D6DAC8
		public UniTask<bool> RequestKurotatoShopRewardRefresh()
		{
			KurotatoController.<RequestKurotatoShopRewardRefresh>d__18 <RequestKurotatoShopRewardRefresh>d__;
			<RequestKurotatoShopRewardRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoShopRewardRefresh>d__.<>1__state = -1;
			<RequestKurotatoShopRewardRefresh>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoShopRewardRefresh>d__18>(ref <RequestKurotatoShopRewardRefresh>d__);
			return <RequestKurotatoShopRewardRefresh>d__.<>t__builder.Task;
		}

		// Token: 0x06038910 RID: 231696 RVA: 0x00D6F904 File Offset: 0x00D6DB04
		public UniTask<bool> RequestKurotatoEndShopStep(bool isEndLess)
		{
			KurotatoController.<RequestKurotatoEndShopStep>d__19 <RequestKurotatoEndShopStep>d__;
			<RequestKurotatoEndShopStep>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoEndShopStep>d__.isEndLess = isEndLess;
			<RequestKurotatoEndShopStep>d__.<>1__state = -1;
			<RequestKurotatoEndShopStep>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoEndShopStep>d__19>(ref <RequestKurotatoEndShopStep>d__);
			return <RequestKurotatoEndShopStep>d__.<>t__builder.Task;
		}

		// Token: 0x06038911 RID: 231697 RVA: 0x00D6F948 File Offset: 0x00D6DB48
		public UniTask<bool> RequestKurotatoStepAdvance()
		{
			KurotatoController.<RequestKurotatoStepAdvance>d__20 <RequestKurotatoStepAdvance>d__;
			<RequestKurotatoStepAdvance>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoStepAdvance>d__.<>1__state = -1;
			<RequestKurotatoStepAdvance>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoStepAdvance>d__20>(ref <RequestKurotatoStepAdvance>d__);
			return <RequestKurotatoStepAdvance>d__.<>t__builder.Task;
		}

		// Token: 0x06038912 RID: 231698 RVA: 0x00D6F984 File Offset: 0x00D6DB84
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

		// Token: 0x06038913 RID: 231699 RVA: 0x00D6F9D5 File Offset: 0x00D6DBD5
		[NullableContext(1)]
		private bool CheckCanOpenLevelUpView(EUiViewName viewName, object param)
		{
			return !this.CheckInKurotatoInstance();
		}

		// Token: 0x06038914 RID: 231700 RVA: 0x00D6F9E0 File Offset: 0x00D6DBE0
		public UniTask<bool> RequestKurotatoRefineWeapon(int weaponIncId)
		{
			KurotatoController.<RequestKurotatoRefineWeapon>d__23 <RequestKurotatoRefineWeapon>d__;
			<RequestKurotatoRefineWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoRefineWeapon>d__.weaponIncId = weaponIncId;
			<RequestKurotatoRefineWeapon>d__.<>1__state = -1;
			<RequestKurotatoRefineWeapon>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoRefineWeapon>d__23>(ref <RequestKurotatoRefineWeapon>d__);
			return <RequestKurotatoRefineWeapon>d__.<>t__builder.Task;
		}

		// Token: 0x06038915 RID: 231701 RVA: 0x00D6FA24 File Offset: 0x00D6DC24
		public UniTask<bool> RequestKurotatoRoleRecord()
		{
			KurotatoController.<RequestKurotatoRoleRecord>d__24 <RequestKurotatoRoleRecord>d__;
			<RequestKurotatoRoleRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoRoleRecord>d__.<>1__state = -1;
			<RequestKurotatoRoleRecord>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoRoleRecord>d__24>(ref <RequestKurotatoRoleRecord>d__);
			return <RequestKurotatoRoleRecord>d__.<>t__builder.Task;
		}

		// Token: 0x06038916 RID: 231702 RVA: 0x00D6FA60 File Offset: 0x00D6DC60
		public UniTask<bool> RequestKurotatoSettlement()
		{
			KurotatoController.<RequestKurotatoSettlement>d__25 <RequestKurotatoSettlement>d__;
			<RequestKurotatoSettlement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoSettlement>d__.<>1__state = -1;
			<RequestKurotatoSettlement>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoSettlement>d__25>(ref <RequestKurotatoSettlement>d__);
			return <RequestKurotatoSettlement>d__.<>t__builder.Task;
		}

		// Token: 0x06038917 RID: 231703 RVA: 0x00D6FA9C File Offset: 0x00D6DC9C
		public UniTask<bool> RequestKurotatoEndSpecialWaveCombat()
		{
			KurotatoController.<RequestKurotatoEndSpecialWaveCombat>d__26 <RequestKurotatoEndSpecialWaveCombat>d__;
			<RequestKurotatoEndSpecialWaveCombat>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoEndSpecialWaveCombat>d__.<>1__state = -1;
			<RequestKurotatoEndSpecialWaveCombat>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoEndSpecialWaveCombat>d__26>(ref <RequestKurotatoEndSpecialWaveCombat>d__);
			return <RequestKurotatoEndSpecialWaveCombat>d__.<>t__builder.Task;
		}

		// Token: 0x06038918 RID: 231704 RVA: 0x00D6FAD8 File Offset: 0x00D6DCD8
		public UniTask<bool> RequestKurotatoReChallenge(bool isFromCurWave)
		{
			KurotatoController.<RequestKurotatoReChallenge>d__27 <RequestKurotatoReChallenge>d__;
			<RequestKurotatoReChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoReChallenge>d__.isFromCurWave = isFromCurWave;
			<RequestKurotatoReChallenge>d__.<>1__state = -1;
			<RequestKurotatoReChallenge>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoReChallenge>d__27>(ref <RequestKurotatoReChallenge>d__);
			return <RequestKurotatoReChallenge>d__.<>t__builder.Task;
		}

		// Token: 0x06038919 RID: 231705 RVA: 0x00D6FB1C File Offset: 0x00D6DD1C
		public UniTask<bool> RequestKurotatoGoldAdd(int goldCount)
		{
			KurotatoController.<RequestKurotatoGoldAdd>d__28 <RequestKurotatoGoldAdd>d__;
			<RequestKurotatoGoldAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoGoldAdd>d__.goldCount = goldCount;
			<RequestKurotatoGoldAdd>d__.<>1__state = -1;
			<RequestKurotatoGoldAdd>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoGoldAdd>d__28>(ref <RequestKurotatoGoldAdd>d__);
			return <RequestKurotatoGoldAdd>d__.<>t__builder.Task;
		}

		// Token: 0x0603891A RID: 231706 RVA: 0x00D6FB60 File Offset: 0x00D6DD60
		public UniTask<bool> RequestKurotatoSellWeapon(int weaponIncId)
		{
			KurotatoController.<RequestKurotatoSellWeapon>d__29 <RequestKurotatoSellWeapon>d__;
			<RequestKurotatoSellWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestKurotatoSellWeapon>d__.weaponIncId = weaponIncId;
			<RequestKurotatoSellWeapon>d__.<>1__state = -1;
			<RequestKurotatoSellWeapon>d__.<>t__builder.Start<KurotatoController.<RequestKurotatoSellWeapon>d__29>(ref <RequestKurotatoSellWeapon>d__);
			return <RequestKurotatoSellWeapon>d__.<>t__builder.Task;
		}

		// Token: 0x0603891B RID: 231707 RVA: 0x00D6FBA4 File Offset: 0x00D6DDA4
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

		// Token: 0x0603891C RID: 231708 RVA: 0x00D6FBE8 File Offset: 0x00D6DDE8
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

		// Token: 0x0603891D RID: 231709 RVA: 0x00D6FCAC File Offset: 0x00D6DEAC
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

		// Token: 0x0603891E RID: 231710 RVA: 0x00D6FDF4 File Offset: 0x00D6DFF4
		[NullableContext(2)]
		private void OnKurotatoChestRewardNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoChestRewardNotify kurotatoChestRewardNotify = (KurotatoChestRewardNotify)msg;
			KurotatoModel.Instance.SetChestRewardData(kurotatoChestRewardNotify.ItemId, kurotatoChestRewardNotify.SoldPrice, kurotatoChestRewardNotify.RewardIndex, kurotatoChestRewardNotify.TotalRewardCount);
			this.ReconcileStepView();
		}

		// Token: 0x0603891F RID: 231711 RVA: 0x00D6FE30 File Offset: 0x00D6E030
		[NullableContext(2)]
		private void OnKurotatoUpgradeRewardNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoUpgradeRewardNotify kurotatoUpgradeRewardNotify = (KurotatoUpgradeRewardNotify)msg;
			KurotatoModel.Instance.SetUpgradeRewardData(kurotatoUpgradeRewardNotify.PanelPbData);
			this.ReconcileStepView();
		}

		// Token: 0x06038920 RID: 231712 RVA: 0x00D6FE5C File Offset: 0x00D6E05C
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

		// Token: 0x06038921 RID: 231713 RVA: 0x00D6FF00 File Offset: 0x00D6E100
		[NullableContext(2)]
		private void OnKurotatoShopRewardNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoShopRewardNotify kurotatoShopRewardNotify = (KurotatoShopRewardNotify)msg;
			KurotatoModel.Instance.SetShopData(kurotatoShopRewardNotify.PanelPbData);
		}

		// Token: 0x06038922 RID: 231714 RVA: 0x00D6FF24 File Offset: 0x00D6E124
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

		// Token: 0x06038923 RID: 231715 RVA: 0x00D6FF70 File Offset: 0x00D6E170
		[NullableContext(2)]
		private void OnKurotatoAllItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoAllItemUpdateNotify kurotatoAllItemUpdateNotify = (KurotatoAllItemUpdateNotify)msg;
			KurotatoModel.Instance.UpdateItemPanel(kurotatoAllItemUpdateNotify.PanelPbData);
		}

		// Token: 0x06038924 RID: 231716 RVA: 0x00D6FF94 File Offset: 0x00D6E194
		[NullableContext(2)]
		private void OnKurotatoWeaponUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoWeaponUpdateNotify kurotatoWeaponUpdateNotify = (KurotatoWeaponUpdateNotify)msg;
			KurotatoModel.Instance.UpdateWeapon(kurotatoWeaponUpdateNotify.PanelPbData);
		}

		// Token: 0x06038925 RID: 231717 RVA: 0x00D6FFB8 File Offset: 0x00D6E1B8
		[NullableContext(2)]
		private void OnKurotatoSettlementNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoSettlementNotify settlementData = (KurotatoSettlementNotify)msg;
			this.StopBattleMusic();
			KurotatoModel.Instance.SetSettlementData(settlementData);
			UiManager.Instance.OpenView(EUiViewName.KurotatoSettleView, null, null);
		}

		// Token: 0x06038926 RID: 231718 RVA: 0x00D6FFF0 File Offset: 0x00D6E1F0
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

		// Token: 0x06038927 RID: 231719 RVA: 0x00D70068 File Offset: 0x00D6E268
		private void OnWorldDone()
		{
			if (this.IsNeedShowMainViewInternal)
			{
				this.IsNeedShowMainViewInternal = false;
				this.AddMainViewSplashTask();
			}
		}

		// Token: 0x06038928 RID: 231720 RVA: 0x00D70080 File Offset: 0x00D6E280
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

		// Token: 0x06038929 RID: 231721 RVA: 0x00D700D4 File Offset: 0x00D6E2D4
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

		// Token: 0x0603892A RID: 231722 RVA: 0x00D701A0 File Offset: 0x00D6E3A0
		[NullableContext(2)]
		private void OnKurotatoPropertyUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoPropertyUpdateNotify kurotatoPropertyUpdateNotify = (KurotatoPropertyUpdateNotify)msg;
			EventSystem.Instance.Emit<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, kurotatoPropertyUpdateNotify.PropertyValues);
			KurotatoModel.Instance.UpdateSystemPropertyValues(kurotatoPropertyUpdateNotify.PropertyValues, kurotatoPropertyUpdateNotify.LockedPropertyValues);
		}

		// Token: 0x0603892B RID: 231723 RVA: 0x00D701E0 File Offset: 0x00D6E3E0
		[NullableContext(2)]
		private void OnKurotatoRefineWeaponNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoRefineWeaponNotify kurotatoRefineWeaponNotify = (KurotatoRefineWeaponNotify)msg;
			ScrollingTipsController.Instance.ShowTipsByTextId("kurotato_weaponcombinsucceed", Array.Empty<object>());
			EventSystem.Instance.Emit<int>(EEventName.KurotatoOnWeaponRefined, kurotatoRefineWeaponNotify.NewWeaponIncId);
		}

		// Token: 0x0603892C RID: 231724 RVA: 0x00D7021E File Offset: 0x00D6E41E
		[NullableContext(2)]
		private void OnKurotatoDieNotify(IMessage msg, Net.CallbackStatus status)
		{
			this.StopBattleMusic();
			EventSystem.Instance.Emit(EEventName.KurotatoOnPlayerDie);
		}

		// Token: 0x0603892D RID: 231725 RVA: 0x00D70238 File Offset: 0x00D6E438
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

		// Token: 0x0603892E RID: 231726 RVA: 0x00D7026C File Offset: 0x00D6E46C
		[NullableContext(2)]
		private void OnKurotatoReChallengeCountNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoReChallengeCountNotify kurotatoReChallengeCountNotify = (KurotatoReChallengeCountNotify)msg;
			KurotatoModel.Instance.SetReChallengeCount(kurotatoReChallengeCountNotify.MaxReChallengeCount, kurotatoReChallengeCountNotify.UsedReChallengeCount);
		}

		// Token: 0x0603892F RID: 231727 RVA: 0x00D70298 File Offset: 0x00D6E498
		[NullableContext(2)]
		private void OnKurotatoNextWaveTypeNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoNextWaveTypeNotify kurotatoNextWaveTypeNotify = (KurotatoNextWaveTypeNotify)msg;
			KurotatoModel.Instance.SetNextWaveType(kurotatoNextWaveTypeNotify.NextWaveType, kurotatoNextWaveTypeNotify.NextWaveId);
			EventSystem.Instance.Emit(EEventName.KurotatoOnNextWaveTypeUpdate);
		}

		// Token: 0x06038930 RID: 231728 RVA: 0x00D702D4 File Offset: 0x00D6E4D4
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

		// Token: 0x170087AD RID: 34733
		// (get) Token: 0x06038931 RID: 231729 RVA: 0x00D7031A File Offset: 0x00D6E51A
		[Nullable(1)]
		public static KurotatoController Instance
		{
			[NullableContext(1)]
			get
			{
				return KurotatoController._Instance;
			}
		}

		// Token: 0x06038932 RID: 231730 RVA: 0x00D70321 File Offset: 0x00D6E521
		[NullableContext(1)]
		public static KurotatoController GetOrCreateInstance()
		{
			if (KurotatoController._Instance == null)
			{
				KurotatoController.CreateInstance();
			}
			return KurotatoController._Instance;
		}

		// Token: 0x06038933 RID: 231731 RVA: 0x00D70335 File Offset: 0x00D6E535
		public static bool CreateInstance()
		{
			if (KurotatoController._Instance != null)
			{
				return true;
			}
			KurotatoController._Instance = new KurotatoController();
			return true;
		}

		// Token: 0x06038934 RID: 231732 RVA: 0x00D7034B File Offset: 0x00D6E54B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038935 RID: 231733 RVA: 0x00D7034D File Offset: 0x00D6E54D
		public static void ResetStaticDefaultValue()
		{
			KurotatoController._Instance = null;
		}

		// Token: 0x06038936 RID: 231734 RVA: 0x00D70355 File Offset: 0x00D6E555
		static KurotatoController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KurotatoController.CreateStaticDefaultValue), new Action(KurotatoController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DB28 RID: 121640
		private bool IsNeedShowMainViewInternal;

		// Token: 0x0401DB29 RID: 121641
		[Nullable(1)]
		private const string KUROTATO_BATTLE_MUSIC_PLAY = "play_ui_music_3_5_wuyinweiji";

		// Token: 0x0401DB2A RID: 121642
		[Nullable(1)]
		private const string KUROTATO_BATTLE_MUSIC_STOP = "stop_ui_music_3_5_wuyinweiji";

		// Token: 0x0401DB2B RID: 121643
		[Nullable(2)]
		private static KurotatoController _Instance;
	}
}
