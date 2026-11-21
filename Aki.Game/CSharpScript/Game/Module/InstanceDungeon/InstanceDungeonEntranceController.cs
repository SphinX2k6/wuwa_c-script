using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004845 RID: 18501
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonEntranceController : UiControllerBase
	{
		// Token: 0x0602E808 RID: 190472 RVA: 0x00CFA35D File Offset: 0x00CF855D
		protected override bool OnInit()
		{
			this.PowerIconPath = InventoryConfig.Instance.GetItemConfigData(5).IconSmall;
			this.RegisterInstanceSubViewBuilder();
			return true;
		}

		// Token: 0x0602E809 RID: 190473 RVA: 0x00CFA37C File Offset: 0x00CF857C
		protected override bool OnClear()
		{
			this.SettleCache = null;
			this.PowerIconPath = null;
			this.UnRegisterInstanceSubViewBuilder();
			return true;
		}

		// Token: 0x0602E80A RID: 190474 RVA: 0x00CFA393 File Offset: 0x00CF8593
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.OpenViewLimit), "InstanceDungeonEntranceController.OpenViewLimit");
		}

		// Token: 0x0602E80B RID: 190475 RVA: 0x00CFA3B5 File Offset: 0x00CF85B5
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.OpenViewLimit));
		}

		// Token: 0x0602E80C RID: 190476 RVA: 0x00CFA3D4 File Offset: 0x00CF85D4
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
			EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnline));
			EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.TeleportComplete));
		}

		// Token: 0x0602E80D RID: 190477 RVA: 0x00CFA470 File Offset: 0x00CF8670
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
			EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnline));
			EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.TeleportComplete));
		}

		// Token: 0x0602E80E RID: 190478 RVA: 0x00CFA50C File Offset: 0x00CF870C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.InstDataNotify, new Action<IMessage, Net.CallbackStatus>(this.InstDataNotify));
			Net.Instance.Register(ENotifyMessageId.UpdateEnterInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateEnterInfoNotify));
			Net.Instance.Register(ENotifyMessageId.MatchFailNotify, new Action<IMessage, Net.CallbackStatus>(this.MatchFailNotify));
			Net.Instance.Register(ENotifyMessageId.MatchTeamNotify, new Action<IMessage, Net.CallbackStatus>(this.MatchTeamNotify));
			Net.Instance.Register(ENotifyMessageId.MatchingNotify, new Action<IMessage, Net.CallbackStatus>(this.MatchingNotify));
			Net.Instance.Register(ENotifyMessageId.MatchTeamStateNotify, new Action<IMessage, Net.CallbackStatus>(this.MatchTeamStateNotify));
			Net.Instance.Register(ENotifyMessageId.MatchConfirmNotify, new Action<IMessage, Net.CallbackStatus>(this.MatchConfirmNotify));
			Net.Instance.Register(ENotifyMessageId.MatchChangeRoleNotify, new Action<IMessage, Net.CallbackStatus>(this.MatchChangeRoleNotify));
			Net.Instance.Register(ENotifyMessageId.MatchChangeReadyNotify, new Action<IMessage, Net.CallbackStatus>(this.MatchChangeReadyNotify));
			Net.Instance.Register(ENotifyMessageId.LeaveMatchTeamNotify, new Action<IMessage, Net.CallbackStatus>(this.LeaveMatchTeamNotify));
			Net.Instance.Register(ENotifyMessageId.EnterMatchTeamNotify, new Action<IMessage, Net.CallbackStatus>(this.EnterMatchTeamNotify));
			Net.Instance.Register(ENotifyMessageId.TeamMatchFlagNotify, new Action<IMessage, Net.CallbackStatus>(this.TeamMatchFlagNotify));
			Net.Instance.Register(ENotifyMessageId.EntranceStateNotify, new Action<IMessage, Net.CallbackStatus>(this.EntranceStateNotify));
			Net.Instance.Register(ENotifyMessageId.InstSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.InstSettleNotify));
			Net.Instance.Register(ENotifyMessageId.TeamMatchInviteNotify, new Action<IMessage, Net.CallbackStatus>(this.TeamMatchInviteNotify));
			Net.Instance.Register(ENotifyMessageId.StartMatchNotify, new Action<IMessage, Net.CallbackStatus>(this.StartMatchNotify));
			Net.Instance.Register(ENotifyMessageId.CancelMatchNotify, new Action<IMessage, Net.CallbackStatus>(this.CancelMatchNotify));
			Net.Instance.Register(ENotifyMessageId.TeamMatchAcceptInviteNotify, new Action<IMessage, Net.CallbackStatus>(this.TeamMatchAcceptInviteNotify));
			Net.Instance.Register(ENotifyMessageId.TeamMatchInviteRetToHostNotify, new Action<IMessage, Net.CallbackStatus>(this.TeamMatchInviteRetToHostNotify));
		}

		// Token: 0x0602E80F RID: 190479 RVA: 0x00CFA730 File Offset: 0x00CF8930
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.InstDataNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UpdateEnterInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MatchFailNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MatchTeamNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MatchingNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MatchTeamStateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MatchConfirmNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MatchChangeRoleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MatchChangeReadyNotify);
			Net.Instance.UnRegister(ENotifyMessageId.LeaveMatchTeamNotify);
			Net.Instance.UnRegister(ENotifyMessageId.EnterMatchTeamNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeamMatchFlagNotify);
			Net.Instance.UnRegister(ENotifyMessageId.EntranceStateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InstSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeamMatchInviteNotify);
			Net.Instance.UnRegister(ENotifyMessageId.StartMatchNotify);
			Net.Instance.UnRegister(ENotifyMessageId.CancelMatchNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeamMatchInviteRetToHostNotify);
		}

		// Token: 0x0602E810 RID: 190480 RVA: 0x00CFA85D File Offset: 0x00CF8A5D
		private void RegisterInstanceSubViewBuilder()
		{
			this.InstanceSubViewCache.Add(EInstanceEntranceSubViewType.MowingRisk, () => new MowingRiskInstanceView());
		}

		// Token: 0x0602E811 RID: 190481 RVA: 0x00CFA88E File Offset: 0x00CF8A8E
		private void UnRegisterInstanceSubViewBuilder()
		{
			this.InstanceSubViewCache.Clear();
		}

		// Token: 0x0602E812 RID: 190482 RVA: 0x00CFA89B File Offset: 0x00CF8A9B
		private void OnWorldDone()
		{
			this.IsShowSettlePower = false;
			if (this.SettleCache != null)
			{
				this.InstSettleNotify(this.SettleCache, null);
				this.SettleCache = null;
			}
		}

		// Token: 0x0602E813 RID: 190483 RVA: 0x00CFA8C0 File Offset: 0x00CF8AC0
		private void WorldDoneAndCloseLoading()
		{
			if (this.HandleExitMatch)
			{
				this.HandleExitMatch = false;
				this.LeaveMatchTeamRequest();
			}
			if (this.HandleTipsExitMatchId != 0)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InstanceDungeonConfig.Instance.GetConfig(this.HandleTipsExitMatchId).Value.MapName, null);
				ScrollingTipsController instance = ScrollingTipsController.Instance;
				string id = "CancelMatch";
				object[] parameters;
				if (localTextNew == null)
				{
					parameters = Array.Empty<object>();
				}
				else
				{
					(parameters = new object[1])[0] = localTextNew;
				}
				instance.ShowTipsById(id, parameters);
				this.HandleTipsExitMatchId = 0;
			}
		}

		// Token: 0x0602E814 RID: 190484 RVA: 0x00CFA93C File Offset: 0x00CF8B3C
		private void OnPowerChanged()
		{
			if (this.IsShowSettlePower)
			{
				List<IRewardExploreConfirmButton> buttonList = this.InitSettleViewButtonList(this.IsShowSettleSuccess);
				ItemRewardController.Instance.SetButtonList(buttonList);
				int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
				int? instancePowerCost = InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(instanceId);
				if (PowerModel.Instance.IsPowerEnough(instancePowerCost) && UiManager.Instance.IsViewOpen(EUiViewName.ConfirmBoxView))
				{
					UiManager.Instance.CloseView(EUiViewName.ConfirmBoxView, null);
				}
			}
		}

		// Token: 0x0602E815 RID: 190485 RVA: 0x00CFA9AE File Offset: 0x00CF8BAE
		private void TeleportComplete(TeleportContext teleportContext)
		{
			if (this.HandleExitMatch)
			{
				this.HandleExitMatch = false;
				this.LeaveMatchTeamRequest();
			}
		}

		// Token: 0x0602E816 RID: 190486 RVA: 0x00CFA9C6 File Offset: 0x00CF8BC6
		private void OnLeaveOnline()
		{
			InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Default);
			EventSystem.Instance.Emit(EEventName.OnMatchingChange);
		}

		// Token: 0x0602E817 RID: 190487 RVA: 0x00CFA9E4 File Offset: 0x00CF8BE4
		[NullableContext(0)]
		public UniTask<bool> EnterEntrance(int entranceId, int entranceEntityId = 0, [Nullable(2)] Action cb = null)
		{
			InstanceDungeonEntranceController.<EnterEntrance>d__31 <EnterEntrance>d__;
			<EnterEntrance>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterEntrance>d__.<>4__this = this;
			<EnterEntrance>d__.entranceId = entranceId;
			<EnterEntrance>d__.entranceEntityId = entranceEntityId;
			<EnterEntrance>d__.cb = cb;
			<EnterEntrance>d__.<>1__state = -1;
			<EnterEntrance>d__.<>t__builder.Start<InstanceDungeonEntranceController.<EnterEntrance>d__31>(ref <EnterEntrance>d__);
			return <EnterEntrance>d__.<>t__builder.Task;
		}

		// Token: 0x0602E818 RID: 190488 RVA: 0x00CFAA40 File Offset: 0x00CF8C40
		[NullableContext(0)]
		private UniTask<bool> StartEntranceFlow()
		{
			InstanceDungeonEntranceController.<StartEntranceFlow>d__32 <StartEntranceFlow>d__;
			<StartEntranceFlow>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartEntranceFlow>d__.<>4__this = this;
			<StartEntranceFlow>d__.<>1__state = -1;
			<StartEntranceFlow>d__.<>t__builder.Start<InstanceDungeonEntranceController.<StartEntranceFlow>d__32>(ref <StartEntranceFlow>d__);
			return <StartEntranceFlow>d__.<>t__builder.Task;
		}

		// Token: 0x0602E819 RID: 190489 RVA: 0x00CFAA84 File Offset: 0x00CF8C84
		public void ContinueEntranceFlow()
		{
			int entranceId = InstanceDungeonEntranceModel.Instance.EntranceId;
			InstanceDungeonEntranceFlowBase instanceDungeonEntranceFlow = InstanceDungeonEntranceConfig.Instance.GetInstanceDungeonEntranceFlow(entranceId);
			if (instanceDungeonEntranceFlow == null)
			{
				return;
			}
			instanceDungeonEntranceFlow.Flow();
		}

		// Token: 0x0602E81A RID: 190490 RVA: 0x00CFAAB4 File Offset: 0x00CF8CB4
		public void RevertEntranceFlowStep()
		{
			int entranceId = InstanceDungeonEntranceModel.Instance.EntranceId;
			if (entranceId == 0)
			{
				return;
			}
			InstanceDungeonEntranceFlowBase instanceDungeonEntranceFlow = InstanceDungeonEntranceConfig.Instance.GetInstanceDungeonEntranceFlow(entranceId);
			if (instanceDungeonEntranceFlow == null)
			{
				return;
			}
			instanceDungeonEntranceFlow.RevertStep();
		}

		// Token: 0x0602E81B RID: 190491 RVA: 0x00CFAAE8 File Offset: 0x00CF8CE8
		public void RestartEntranceFlow()
		{
			int entranceId = InstanceDungeonEntranceModel.Instance.EntranceId;
			if (entranceId == 0)
			{
				return;
			}
			InstanceDungeonEntranceFlowBase instanceDungeonEntranceFlow = InstanceDungeonEntranceConfig.Instance.GetInstanceDungeonEntranceFlow(entranceId);
			if (instanceDungeonEntranceFlow == null)
			{
				return;
			}
			instanceDungeonEntranceFlow.Start();
		}

		// Token: 0x0602E81C RID: 190492 RVA: 0x00CFAB1A File Offset: 0x00CF8D1A
		public void OnEditBattleViewClose()
		{
			InstanceDungeonEntranceConfig.Instance.OnEditBattleViewClose();
		}

		// Token: 0x0602E81D RID: 190493 RVA: 0x00CFAB28 File Offset: 0x00CF8D28
		[NullableContext(0)]
		public UniTask<bool> EnterInstanceDungeon()
		{
			InstanceDungeonEntranceController.<EnterInstanceDungeon>d__37 <EnterInstanceDungeon>d__;
			<EnterInstanceDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterInstanceDungeon>d__.<>1__state = -1;
			<EnterInstanceDungeon>d__.<>t__builder.Start<InstanceDungeonEntranceController.<EnterInstanceDungeon>d__37>(ref <EnterInstanceDungeon>d__);
			return <EnterInstanceDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x0602E81E RID: 190494 RVA: 0x00CFAB64 File Offset: 0x00CF8D64
		[NullableContext(0)]
		public UniTask<bool> EnterInstanceDungeonByAutoRole()
		{
			InstanceDungeonEntranceController.<EnterInstanceDungeonByAutoRole>d__38 <EnterInstanceDungeonByAutoRole>d__;
			<EnterInstanceDungeonByAutoRole>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterInstanceDungeonByAutoRole>d__.<>1__state = -1;
			<EnterInstanceDungeonByAutoRole>d__.<>t__builder.Start<InstanceDungeonEntranceController.<EnterInstanceDungeonByAutoRole>d__38>(ref <EnterInstanceDungeonByAutoRole>d__);
			return <EnterInstanceDungeonByAutoRole>d__.<>t__builder.Task;
		}

		// Token: 0x0602E81F RID: 190495 RVA: 0x00CFABA0 File Offset: 0x00CF8DA0
		[NullableContext(0)]
		public UniTask<bool> LeaveInstanceDungeon()
		{
			InstanceDungeonEntranceController.<LeaveInstanceDungeon>d__39 <LeaveInstanceDungeon>d__;
			<LeaveInstanceDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LeaveInstanceDungeon>d__.<>4__this = this;
			<LeaveInstanceDungeon>d__.<>1__state = -1;
			<LeaveInstanceDungeon>d__.<>t__builder.Start<InstanceDungeonEntranceController.<LeaveInstanceDungeon>d__39>(ref <LeaveInstanceDungeon>d__);
			return <LeaveInstanceDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x0602E820 RID: 190496 RVA: 0x00CFABE4 File Offset: 0x00CF8DE4
		[NullableContext(0)]
		public UniTask<bool> LeaveInstanceDungeonRequest(LeaveInstWay leaveWay = LeaveInstWay.Default)
		{
			InstanceDungeonEntranceController.<LeaveInstanceDungeonRequest>d__40 <LeaveInstanceDungeonRequest>d__;
			<LeaveInstanceDungeonRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LeaveInstanceDungeonRequest>d__.leaveWay = leaveWay;
			<LeaveInstanceDungeonRequest>d__.<>1__state = -1;
			<LeaveInstanceDungeonRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<LeaveInstanceDungeonRequest>d__40>(ref <LeaveInstanceDungeonRequest>d__);
			return <LeaveInstanceDungeonRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602E821 RID: 190497 RVA: 0x00CFAC28 File Offset: 0x00CF8E28
		[NullableContext(0)]
		public UniTask<bool> RestartInstanceDungeon(bool rechallengeInInst = false)
		{
			InstanceDungeonEntranceController.<RestartInstanceDungeon>d__41 <RestartInstanceDungeon>d__;
			<RestartInstanceDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RestartInstanceDungeon>d__.<>4__this = this;
			<RestartInstanceDungeon>d__.rechallengeInInst = rechallengeInInst;
			<RestartInstanceDungeon>d__.<>1__state = -1;
			<RestartInstanceDungeon>d__.<>t__builder.Start<InstanceDungeonEntranceController.<RestartInstanceDungeon>d__41>(ref <RestartInstanceDungeon>d__);
			return <RestartInstanceDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x0602E822 RID: 190498 RVA: 0x00CFAC73 File Offset: 0x00CF8E73
		private void OnRestartInstanceDungeonSuccess()
		{
			this.IsShowSettlePower = false;
		}

		// Token: 0x0602E823 RID: 190499 RVA: 0x00CFAC7C File Offset: 0x00CF8E7C
		private bool GetRechallengeInInst(int instId)
		{
			instId = 0;
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.InstRechallengeCache, null);
			bool flag;
			return player == null || !player.TryGetValue(instId, out flag) || flag;
		}

		// Token: 0x0602E824 RID: 190500 RVA: 0x00CFACAC File Offset: 0x00CF8EAC
		private void SetRechallengeInInst(int instId, bool rechallengeInInst)
		{
			instId = 0;
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.InstRechallengeCache, null) ?? new Dictionary<int, bool>();
			dictionary[instId] = rechallengeInInst;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.InstRechallengeCache, dictionary);
		}

		// Token: 0x0602E825 RID: 190501 RVA: 0x00CFACE8 File Offset: 0x00CF8EE8
		private bool CanRechallengeInInst(bool isSuccess, int instId)
		{
			InstanceDungeon? instanceDungeon;
			return isSuccess && !GameModeModel.Instance.IsMulti && InstanceDungeonConfig.Instance.GetConfig(instId) != null && instanceDungeon.GetValueOrDefault().CanRechallenge;
		}

		// Token: 0x0602E826 RID: 190502 RVA: 0x00CFAD2C File Offset: 0x00CF8F2C
		internal bool GetCurrentRechallengeInInst()
		{
			bool isSuccess = InstanceDungeonModel.Instance.InstanceFinishSuccess == EInstanceFinishState.Success;
			int instanceId = CreatureModel.Instance.GetInstanceId();
			return this.CanRechallengeInInst(isSuccess, instanceId) && this.GetRechallengeInInst(instanceId);
		}

		// Token: 0x0602E827 RID: 190503 RVA: 0x00CFAD65 File Offset: 0x00CF8F65
		private bool CanSettleRechallengeInInst(bool isSuccess, int settleType, int instId)
		{
			return settleType == 4 && this.CanRechallengeInInst(isSuccess, instId);
		}

		// Token: 0x0602E828 RID: 190504 RVA: 0x00CFAD75 File Offset: 0x00CF8F75
		private bool GetSettleRechallengeInInst(bool isSuccess, int settleType, int instId)
		{
			return this.CanSettleRechallengeInInst(isSuccess, settleType, instId) && this.GetRechallengeInInst(instId);
		}

		// Token: 0x0602E829 RID: 190505 RVA: 0x00CFAD8C File Offset: 0x00CF8F8C
		private IRewardExploreToggle BuildRechallengeToggleData(bool isSuccess, int settleType)
		{
			int instId = InstanceDungeonEntranceModel.Instance.InstanceId;
			if (!this.CanSettleRechallengeInInst(isSuccess, settleType, instId))
			{
				return null;
			}
			return new RewardExploreToggleData
			{
				DescriptionTextId = "Istance_Loadingmode",
				DefaultOn = this.GetRechallengeInInst(instId),
				OnToggleClick = delegate(EToggleState state)
				{
					bool flag = state == EToggleState.ETT_Checked;
					this.SetRechallengeInInst(instId, flag);
					ScrollingTipsController.Instance.ShowTipsByTextId(flag ? "Istance_LoadingmodeOpen_tips" : "Istance_LoadingmodeClose_tips", Array.Empty<object>());
				}
			};
		}

		// Token: 0x0602E82A RID: 190506 RVA: 0x00CFADFC File Offset: 0x00CF8FFC
		[NullableContext(0)]
		public UniTask<bool> InstEntranceDetailRequest(int entranceId)
		{
			InstanceDungeonEntranceController.<InstEntranceDetailRequest>d__50 <InstEntranceDetailRequest>d__;
			<InstEntranceDetailRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<InstEntranceDetailRequest>d__.entranceId = entranceId;
			<InstEntranceDetailRequest>d__.<>1__state = -1;
			<InstEntranceDetailRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<InstEntranceDetailRequest>d__50>(ref <InstEntranceDetailRequest>d__);
			return <InstEntranceDetailRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602E82B RID: 190507 RVA: 0x00CFAE40 File Offset: 0x00CF9040
		[NullableContext(0)]
		public UniTask<bool> MatchChangeRoleRequest([Nullable(1)] List<int> roleId)
		{
			InstanceDungeonEntranceController.<MatchChangeRoleRequest>d__51 <MatchChangeRoleRequest>d__;
			<MatchChangeRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MatchChangeRoleRequest>d__.roleId = roleId;
			<MatchChangeRoleRequest>d__.<>1__state = -1;
			<MatchChangeRoleRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<MatchChangeRoleRequest>d__51>(ref <MatchChangeRoleRequest>d__);
			return <MatchChangeRoleRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602E82C RID: 190508 RVA: 0x00CFAE84 File Offset: 0x00CF9084
		[NullableContext(0)]
		public UniTask<bool> MatchChangeReadyRequest(bool isReady)
		{
			InstanceDungeonEntranceController.<MatchChangeReadyRequest>d__52 <MatchChangeReadyRequest>d__;
			<MatchChangeReadyRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MatchChangeReadyRequest>d__.isReady = isReady;
			<MatchChangeReadyRequest>d__.<>1__state = -1;
			<MatchChangeReadyRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<MatchChangeReadyRequest>d__52>(ref <MatchChangeReadyRequest>d__);
			return <MatchChangeReadyRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602E82D RID: 190509 RVA: 0x00CFAEC8 File Offset: 0x00CF90C8
		[NullableContext(0)]
		public UniTask<bool> LeaveMatchTeamRequest()
		{
			InstanceDungeonEntranceController.<LeaveMatchTeamRequest>d__53 <LeaveMatchTeamRequest>d__;
			<LeaveMatchTeamRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LeaveMatchTeamRequest>d__.<>1__state = -1;
			<LeaveMatchTeamRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<LeaveMatchTeamRequest>d__53>(ref <LeaveMatchTeamRequest>d__);
			return <LeaveMatchTeamRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602E82E RID: 190510 RVA: 0x00CFAF04 File Offset: 0x00CF9104
		[NullableContext(0)]
		public UniTask<bool> KickMatchTeamPlayerRequest(int playerId)
		{
			InstanceDungeonEntranceController.<KickMatchTeamPlayerRequest>d__54 <KickMatchTeamPlayerRequest>d__;
			<KickMatchTeamPlayerRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<KickMatchTeamPlayerRequest>d__.playerId = playerId;
			<KickMatchTeamPlayerRequest>d__.<>1__state = -1;
			<KickMatchTeamPlayerRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<KickMatchTeamPlayerRequest>d__54>(ref <KickMatchTeamPlayerRequest>d__);
			return <KickMatchTeamPlayerRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602E82F RID: 190511 RVA: 0x00CFAF48 File Offset: 0x00CF9148
		[NullableContext(0)]
		public UniTask<bool> SetMatchTeamMatchFlagRequest(bool isMatch)
		{
			InstanceDungeonEntranceController.<SetMatchTeamMatchFlagRequest>d__55 <SetMatchTeamMatchFlagRequest>d__;
			<SetMatchTeamMatchFlagRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SetMatchTeamMatchFlagRequest>d__.isMatch = isMatch;
			<SetMatchTeamMatchFlagRequest>d__.<>1__state = -1;
			<SetMatchTeamMatchFlagRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<SetMatchTeamMatchFlagRequest>d__55>(ref <SetMatchTeamMatchFlagRequest>d__);
			return <SetMatchTeamMatchFlagRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602E830 RID: 190512 RVA: 0x00CFAF8C File Offset: 0x00CF918C
		[NullableContext(0)]
		public UniTask<bool> EnterMatchInstRequest()
		{
			InstanceDungeonEntranceController.<EnterMatchInstRequest>d__56 <EnterMatchInstRequest>d__;
			<EnterMatchInstRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterMatchInstRequest>d__.<>1__state = -1;
			<EnterMatchInstRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<EnterMatchInstRequest>d__56>(ref <EnterMatchInstRequest>d__);
			return <EnterMatchInstRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602E831 RID: 190513 RVA: 0x00CFAFC8 File Offset: 0x00CF91C8
		[NullableContext(1)]
		public bool CheckInstanceShieldView(string viewName)
		{
			if (!this.LimitOpenView)
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			return instanceId != 0 && InstanceDungeonConfig.Instance.CheckViewShield(instanceId, (EUiViewName)viewName);
		}

		// Token: 0x0602E832 RID: 190514 RVA: 0x00CFB000 File Offset: 0x00CF9200
		public void RestoreDungeonEntranceEntity()
		{
			int entranceEntityId = InstanceDungeonEntranceModel.Instance.EntranceEntityId;
			if (entranceEntityId == 0)
			{
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entranceEntityId);
			if (entityById == null || !entityById.IsInit)
			{
				return;
			}
			DungeonEntranceComponent component = entityById.Entity.GetComponent<DungeonEntranceComponent>();
			if (component == null)
			{
				return;
			}
			component.Restore();
		}

		// Token: 0x0602E833 RID: 190515 RVA: 0x00CFB04C File Offset: 0x00CF924C
		[NullableContext(1)]
		public void RegisterDungeonEntranceRestoreCb(Action cb)
		{
			int entranceEntityId = InstanceDungeonEntranceModel.Instance.EntranceEntityId;
			if (entranceEntityId == 0)
			{
				cb();
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entranceEntityId);
			if (entityById == null || !entityById.IsInit)
			{
				cb();
				return;
			}
			DungeonEntranceComponent component = entityById.Entity.GetComponent<DungeonEntranceComponent>();
			if (component != null)
			{
				component.RegisterRestoreCb(cb);
				return;
			}
			cb();
		}

		// Token: 0x0602E834 RID: 190516 RVA: 0x00CFB0AC File Offset: 0x00CF92AC
		[NullableContext(0)]
		private UniTask<bool> StartMatchRequestAsync(int instanceId, bool inviteTeamWorld = false, bool checkSubpack = true)
		{
			InstanceDungeonEntranceController.<StartMatchRequestAsync>d__60 <StartMatchRequestAsync>d__;
			<StartMatchRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartMatchRequestAsync>d__.<>4__this = this;
			<StartMatchRequestAsync>d__.instanceId = instanceId;
			<StartMatchRequestAsync>d__.inviteTeamWorld = inviteTeamWorld;
			<StartMatchRequestAsync>d__.checkSubpack = checkSubpack;
			<StartMatchRequestAsync>d__.<>1__state = -1;
			<StartMatchRequestAsync>d__.<>t__builder.Start<InstanceDungeonEntranceController.<StartMatchRequestAsync>d__60>(ref <StartMatchRequestAsync>d__);
			return <StartMatchRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E835 RID: 190517 RVA: 0x00CFB107 File Offset: 0x00CF9307
		public void StartMatchRequest(int instanceId, bool inviteTeamWorld = false, bool checkSubpack = true)
		{
			this.StartMatchRequestAsync(instanceId, inviteTeamWorld, checkSubpack);
		}

		// Token: 0x0602E836 RID: 190518 RVA: 0x00CFB114 File Offset: 0x00CF9314
		public void CancelMatchRequest()
		{
			CancelMatchRequest message = new CancelMatchRequest();
			Net.Instance.Call(ERequestMessageId.CancelMatchRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				CancelMatchResponse cancelMatchResponse = (CancelMatchResponse)msg;
				if (cancelMatchResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(cancelMatchResponse.ErrorCode, EResponseMessageId.CancelMatchResponse, null, true, true);
					return;
				}
				InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Default);
				EventSystem.Instance.Emit(EEventName.OnMatchingChange);
			}, 0);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InstanceDungeonConfig.Instance.GetConfig(InstanceDungeonEntranceModel.Instance.GetMatchingId()).Value.MapName, null);
			ScrollingTipsController instance = ScrollingTipsController.Instance;
			string id = "CancelMatch";
			object[] parameters;
			if (localTextNew == null)
			{
				parameters = Array.Empty<object>();
			}
			else
			{
				(parameters = new object[1])[0] = localTextNew;
			}
			instance.ShowTipsById(id, parameters);
			InstanceDungeonEntranceModel.Instance.SetMatchingId(0);
		}

		// Token: 0x0602E837 RID: 190519 RVA: 0x00CFB1B0 File Offset: 0x00CF93B0
		public void MatchConfirmRequest(bool isAccept)
		{
			MatchConfirmRequest matchConfirmRequest = new MatchConfirmRequest();
			matchConfirmRequest.IsAccept = isAccept;
			Net.Instance.Call(ERequestMessageId.MatchConfirmRequest, matchConfirmRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MatchConfirmResponse matchConfirmResponse = (MatchConfirmResponse)msg;
				if (matchConfirmResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(matchConfirmResponse.ErrorCode, EResponseMessageId.MatchConfirmResponse, null, true, true);
					InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Default);
					EventSystem.Instance.Emit(EEventName.OnMatchingChange);
					return;
				}
				InstanceDungeonModel.Instance.SetMatchingPlayerConfirmState(CreatureModel.Instance.GetPlayerId(), true);
				if (!isAccept)
				{
					InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Default);
					EventSystem.Instance.Emit(EEventName.OnMatchingChange);
					return;
				}
				InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Waiting);
			}, 0);
		}

		// Token: 0x0602E838 RID: 190520 RVA: 0x00CFB1FC File Offset: 0x00CF93FC
		public void TeamChallengeRequest(int instanceId, bool isInviteTeammate)
		{
			TeamChallengeRequest teamChallengeRequest = new TeamChallengeRequest();
			teamChallengeRequest.InstId = instanceId;
			teamChallengeRequest.InstEnterId = InstanceDungeonEntranceModel.Instance.EntranceId;
			teamChallengeRequest.IsInviteTeammate = isInviteTeammate;
			Net.Instance.Call(ERequestMessageId.TeamChallengeRequest, teamChallengeRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TeamChallengeResponse teamChallengeResponse = (TeamChallengeResponse)msg;
				if (teamChallengeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(teamChallengeResponse.ErrorCode, EResponseMessageId.TeamChallengeResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0602E839 RID: 190521 RVA: 0x00CFB260 File Offset: 0x00CF9460
		public void TeamMatchAcceptInviteRequest(bool isAccept, bool isClickCancel)
		{
			TeamMatchAcceptInviteRequest teamMatchAcceptInviteRequest = new TeamMatchAcceptInviteRequest();
			teamMatchAcceptInviteRequest.InstId = InstanceDungeonModel.Instance.GetInstanceId();
			if (isAccept)
			{
				teamMatchAcceptInviteRequest.AcceptResult = EMatchAcceptInviteResult.Accept;
			}
			else if (isClickCancel)
			{
				teamMatchAcceptInviteRequest.AcceptResult = EMatchAcceptInviteResult.ActiveRefuse;
			}
			else
			{
				teamMatchAcceptInviteRequest.AcceptResult = EMatchAcceptInviteResult.TimeOutRefuse;
			}
			teamMatchAcceptInviteRequest.HostId = OnlineModel.Instance.OwnerId;
			Net.Instance.Call(ERequestMessageId.TeamMatchAcceptInviteRequest, teamMatchAcceptInviteRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TeamMatchAcceptInviteResponse teamMatchAcceptInviteResponse = (TeamMatchAcceptInviteResponse)msg;
				if (teamMatchAcceptInviteResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(teamMatchAcceptInviteResponse.ErrorCode, EResponseMessageId.TeamMatchAcceptInviteResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0602E83A RID: 190522 RVA: 0x00CFB2E4 File Offset: 0x00CF94E4
		public void TeamMatchInviteRequest()
		{
			TeamMatchInviteRequest teamMatchInviteRequest = new TeamMatchInviteRequest();
			teamMatchInviteRequest.InstId = InstanceDungeonModel.Instance.GetInstanceId();
			Net.Instance.Call(ERequestMessageId.TeamMatchInviteRequest, teamMatchInviteRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TeamMatchInviteResponse teamMatchInviteResponse = (TeamMatchInviteResponse)msg;
				if (teamMatchInviteResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(teamMatchInviteResponse.ErrorCode, EResponseMessageId.TeamMatchInviteResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0602E83B RID: 190523 RVA: 0x00CFB338 File Offset: 0x00CF9538
		private void MatchFailNotify(IMessage msg, Net.CallbackStatus status)
		{
			if (((MatchFailNotify)msg).Reason == MatchFailReason.TimeOut)
			{
				ScrollingTipsController.Instance.ShowTipsById("MatchingTimeOut", Array.Empty<object>());
			}
			InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Default);
			EventSystem.Instance.Emit(EEventName.OnMatchingChange);
			InstanceDungeonModel.Instance.ResetData();
		}

		// Token: 0x0602E83C RID: 190524 RVA: 0x00CFB38C File Offset: 0x00CF958C
		public void MatchTeamNotify(IMessage msg, Net.CallbackStatus status)
		{
			MatchTeamNotify matchTeamNotify = (MatchTeamNotify)msg;
			InstanceDungeonModel.Instance.SetMatchTeamInfo(matchTeamNotify.TeamInfo);
			InstanceDungeonModel.Instance.InitMatchingTeamConfirmReadyState(matchTeamNotify.TeamInfo.PlayerInfos);
			KuroSdkModel.Instance.OnMatchTeamNotify(matchTeamNotify.TeamInfo);
			int matchingId = InstanceDungeonEntranceModel.Instance.GetMatchingId();
			if (InstanceDungeonEntranceConfig.Instance.CheckInstanceIdIsTowerDefense(matchingId))
			{
				TowerDefenseController.Instance.SetIsUiFlowOpen(true);
			}
			if (InstanceDungeonModel.Instance.GetMatchingPlayerConfirmStateByPlayerId(PlayerInfoModel.Instance.GetId().Value).GetValueOrDefault())
			{
				InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.ConfirmToReady);
				if (!UiManager.Instance.IsViewShow(EUiViewName.InstanceDungeonEntranceView) && !UiManager.Instance.IsViewShow(EUiViewName.BattleTeam2DView))
				{
					this.OpenEditBattleView();
					int instanceId = InstanceDungeonModel.Instance.GetInstanceId();
					if (InstanceDungeonEntranceConfig.Instance.CheckInstanceIdIsTowerDefense(instanceId))
					{
						TowerDefenseController.Instance.SetIsUiFlowOpen(true);
					}
					return;
				}
			}
			else
			{
				InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.MatchConfirm);
				if (UiManager.Instance.IsViewOpen(EUiViewName.OnlineMatchSuccessView))
				{
					return;
				}
				if (!UiManager.Instance.IsViewShow(EUiViewName.InstanceDungeonEntranceView) && !UiManager.Instance.IsViewShow(EUiViewName.BattleTeam2DView) && !UiManager.Instance.IsViewShow(EUiViewName.DangoAbyssInsSelectView) && !UiManager.Instance.IsViewShow(EUiViewName.MultiMotorChoseLevelView) && !UiManager.Instance.IsViewShow(EUiViewName.TowerDefenseLevelView))
				{
					UiManager.Instance.OpenView(EUiViewName.OnlineMatchSuccessView, null, null);
				}
			}
			EventSystem.Instance.Emit(EEventName.OnMatchingChange);
		}

		// Token: 0x0602E83D RID: 190525 RVA: 0x00CFB510 File Offset: 0x00CF9710
		private void MatchingNotify(IMessage msg, Net.CallbackStatus status)
		{
			InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Matching);
			EventSystem.Instance.Emit(EEventName.OnMatchingChange);
		}

		// Token: 0x0602E83E RID: 190526 RVA: 0x00CFB530 File Offset: 0x00CF9730
		public void MatchTeamStateNotify(IMessage msg, Net.CallbackStatus status)
		{
			MatchTeamStateNotify matchTeamStateNotify = (MatchTeamStateNotify)msg;
			InstanceDungeonModel.Instance.SetMatchTeamState(matchTeamStateNotify.TeamState);
			if (matchTeamStateNotify.TeamState == MatchTeamState.ReadyConfirm)
			{
				InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.ConfirmToReady);
				EventSystem.Instance.Emit(EEventName.OnMatchingChange);
				if (!UiManager.Instance.IsViewOpen(EUiViewName.InstanceDungeonEntranceView))
				{
					this.OpenEditBattleView();
					if (UiManager.Instance.IsViewShow(EUiViewName.OnlineMatchSuccessView))
					{
						UiManager.Instance.CloseView(EUiViewName.OnlineMatchSuccessView, null);
					}
					return;
				}
			}
			else if (matchTeamStateNotify.TeamState == MatchTeamState.WaiteConfirm)
			{
				InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Waiting);
			}
			EventSystem.Instance.Emit(EEventName.OnMatchingChange);
		}

		// Token: 0x0602E83F RID: 190527 RVA: 0x00CFB5D4 File Offset: 0x00CF97D4
		private void MatchConfirmNotify(IMessage msg, Net.CallbackStatus status)
		{
			MatchConfirmNotify matchConfirmNotify = (MatchConfirmNotify)msg;
			InstanceDungeonModel.Instance.SetMatchingPlayerConfirmState(matchConfirmNotify.ConfirmId, true);
			int? id = PlayerInfoModel.Instance.GetId();
			int confirmId = matchConfirmNotify.ConfirmId;
			int? num = id;
			if ((confirmId == num.GetValueOrDefault() & num != null) && InstanceDungeonModel.Instance.GetMatchingTeamReady())
			{
				InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.ConfirmToReady);
				EventSystem.Instance.Emit(EEventName.OnMatchingChange);
				if (!UiManager.Instance.IsViewShow(EUiViewName.InstanceDungeonEntranceView))
				{
					this.OpenEditBattleView();
					if (UiManager.Instance.IsViewOpen(EUiViewName.OnlineMatchSuccessView))
					{
						UiManager.Instance.CloseView(EUiViewName.OnlineMatchSuccessView, null);
					}
				}
			}
		}

		// Token: 0x0602E840 RID: 190528 RVA: 0x00CFB680 File Offset: 0x00CF9880
		private void MatchChangeRoleNotify(IMessage msg, Net.CallbackStatus status)
		{
			MatchChangeRoleNotify matchChangeRoleNotify = (MatchChangeRoleNotify)msg;
			InstanceDungeonModel.Instance.SetMatchTeamInfoPlayerRole(matchChangeRoleNotify.PlayerId, matchChangeRoleNotify.RoleInfo);
		}

		// Token: 0x0602E841 RID: 190529 RVA: 0x00CFB6AC File Offset: 0x00CF98AC
		private void MatchChangeReadyNotify(IMessage msg, Net.CallbackStatus status)
		{
			MatchChangeReadyNotify matchChangeReadyNotify = (MatchChangeReadyNotify)msg;
			InstanceDungeonModel.Instance.SetPrewarPlayerReadyState(matchChangeReadyNotify.PlayerId, matchChangeReadyNotify.IsReady);
			EventSystem.Instance.Emit<int, bool>(EEventName.PrewarReadyChanged, matchChangeReadyNotify.PlayerId, matchChangeReadyNotify.IsReady);
			InstanceDungeonModel.Instance.SetPlayerUiState(matchChangeReadyNotify.PlayerId, matchChangeReadyNotify.IsReady ? EMatchPlayerUiState.Ready : EMatchPlayerUiState.Wait);
		}

		// Token: 0x0602E842 RID: 190530 RVA: 0x00CFB710 File Offset: 0x00CF9910
		private void LeaveMatchTeamNotify(IMessage msg, Net.CallbackStatus status)
		{
			LeaveMatchTeamNotify leaveMatchTeamNotify = (LeaveMatchTeamNotify)msg;
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (leaveMatchTeamNotify.PlayerId == playerId)
			{
				if (!InstanceDungeonModel.Instance.IsMatchTeamHost() && leaveMatchTeamNotify.LeaveReason == MatchPlayerLeaveReason.HostLeave)
				{
					ScrollingTipsController.Instance.ShowTipsById("LeaderExitMatching", Array.Empty<object>());
				}
				if (leaveMatchTeamNotify.LeaveReason == MatchPlayerLeaveReason.BeKick)
				{
					ScrollingTipsController.Instance.ShowTipsById("MatchLeaveTeamByKickOut", Array.Empty<object>());
				}
				InstanceDungeonModel.Instance.ResetData();
				FormationController.Instance.ExitBattleTeam(false);
				InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Default);
				ConfirmBoxController.Instance.CloseConfirmBoxView();
				OnlineModel.Instance.ClearPlayerTeleportState();
				EventSystem.Instance.Emit(EEventName.OnMatchingChange);
				EventSystem.Instance.Emit(EEventName.OnLeaveTeam);
				this.HandleExitMatch = false;
				return;
			}
			string matchTeamName = InstanceDungeonModel.Instance.GetMatchTeamName(leaveMatchTeamNotify.PlayerId);
			ScrollingTipsController instance = ScrollingTipsController.Instance;
			string id = "OthersLeaveMatchTeam";
			object[] parameters;
			if (matchTeamName == null)
			{
				parameters = Array.Empty<object>();
			}
			else
			{
				(parameters = new object[1])[0] = matchTeamName;
			}
			instance.ShowTipsById(id, parameters);
			InstanceDungeonModel.Instance.RemovePrewarFormationDataByPlayer(leaveMatchTeamNotify.PlayerId);
			OnlineModel.Instance.DeletePlayerTeleportState(leaveMatchTeamNotify.PlayerId);
			EventSystem.Instance.Emit(EEventName.PrewarFormationChanged);
		}

		// Token: 0x0602E843 RID: 190531 RVA: 0x00CFB844 File Offset: 0x00CF9A44
		private void EnterMatchTeamNotify(IMessage msg, Net.CallbackStatus status)
		{
			EnterMatchTeamNotify enterMatchTeamNotify = (EnterMatchTeamNotify)msg;
			InstanceDungeonModel.Instance.SetMatchingPlayerConfirmState(enterMatchTeamNotify.PlayerInfo.PlayerId, false);
			InstanceDungeonModel.Instance.SetPrewarPlayerReadyState(enterMatchTeamNotify.PlayerInfo.PlayerId, false);
			InstanceDungeonModel.Instance.AddPrewarFormationDataByPlayerInfo(enterMatchTeamNotify.PlayerInfo, true);
			EventSystem.Instance.Emit(EEventName.PrewarFormationChanged);
		}

		// Token: 0x0602E844 RID: 190532 RVA: 0x00CFB8A8 File Offset: 0x00CF9AA8
		private void TeamMatchFlagNotify(IMessage msg, Net.CallbackStatus status)
		{
			TeamMatchFlagNotify teamMatchFlagNotify = (TeamMatchFlagNotify)msg;
			MatchTeamInfo matchTeamInfo = InstanceDungeonModel.Instance.GetMatchTeamInfo();
			if (matchTeamInfo != null)
			{
				int hostId = matchTeamInfo.HostId;
				InstanceDungeonModel.Instance.SetPlayerUiState(hostId, teamMatchFlagNotify.MatchFlag ? EMatchPlayerUiState.Matching : EMatchPlayerUiState.Wait);
				InstanceDungeonEntranceModel.Instance.SetEditBattleTeamMatching(teamMatchFlagNotify.MatchFlag);
				return;
			}
			if (teamMatchFlagNotify.MatchFlag)
			{
				this.StartMatch(teamMatchFlagNotify.InstId);
				return;
			}
			InstanceDungeonEntranceModel.Instance.CancelMatchingTimer();
			if (!OnlineModel.Instance.GetIsMyTeam())
			{
				ScrollingTipsController.Instance.ShowTipsById("LeaderCancelMatch", Array.Empty<object>());
			}
		}

		// Token: 0x0602E845 RID: 190533 RVA: 0x00CFB938 File Offset: 0x00CF9B38
		private unsafe void InstSettleNotify(IMessage msg, Net.CallbackStatus status)
		{
			InstSettleNotify instSettleNotify = (InstSettleNotify)msg;
			if (this.IsSettleExternalProcess)
			{
				this.IsSettleExternalProcess = false;
				return;
			}
			this.IsShowSettleSuccess = instSettleNotify.IsSuccess;
			if (!GameModeModel.Instance.WorldDone)
			{
				Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.LJQ, "副本结算通知时，世界未加载完成", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.SettleCache = instSettleNotify;
				return;
			}
			if (instSettleNotify.RewardFailTips)
			{
				ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonRewardTimeNotEnough", Array.Empty<object>());
				return;
			}
			InstanceDungeonEntranceModel.Instance.SyncSettleRewardItemList(instSettleNotify.RewardItems);
			if (!instSettleNotify.IsSuccess)
			{
				this.OpenInstanceDungeonFailView();
				return;
			}
			List<IRewardExploreConfirmButton> buttonInfoList = this.InitSettleViewButtonList(instSettleNotify.IsSuccess);
			int settleButtonType = InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()).Value.SettleButtonType;
			if (settleButtonType == 5)
			{
				return;
			}
			List<RewardItemData> list = new List<RewardItemData>();
			MapField<int, RewardItemInfoList> rewardItems = instSettleNotify.RewardItems;
			foreach (int num in rewardItems.Keys)
			{
				RewardItemInfoList rewardItemInfoList = rewardItems[num];
				RepeatedField<RewardItemInfo> repeatedField = (rewardItemInfoList != null) ? rewardItemInfoList.ItemList : null;
				if (repeatedField != null)
				{
					int dropItemType = num;
					foreach (RewardItemInfo rewardItemInfo in repeatedField)
					{
						RewardItemData item = new RewardItemData(rewardItemInfo.ItemId, rewardItemInfo.Count, new int?(rewardItemInfo.IncrId), (EDropItemType)dropItemType);
						list.Add(item);
					}
				}
			}
			bool value = false;
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (instanceId != 0)
			{
				InstanceDungeon? instanceDungeon;
				int num2 = (InstanceDungeonConfig.Instance.GetConfig(instanceId) != null) ? instanceDungeon.GetValueOrDefault().InstSubType : 0;
				IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("MultiRewardLevelInstType");
				if (intArrayConfig != null)
				{
					for (int i = 0; i < intArrayConfig.Count; i++)
					{
						if (intArrayConfig[i] == num2)
						{
							value = true;
							break;
						}
					}
				}
			}
			string tip = null;
			if (instSettleNotify.Magnification > 1)
			{
				DoubleDropFrom from = instSettleNotify.From;
				if (from != DoubleDropFrom.DoubleActivity)
				{
					if (from == DoubleDropFrom.FromRegress)
					{
						if (instanceId != 0)
						{
							ValueTuple<bool, int, int, string, string> regressDoubleDropTuple = ActivityRegressModel.Instance.GetRegressDoubleDropTuple(instanceId);
							bool item2 = regressDoubleDropTuple.Item1;
							int item3 = regressDoubleDropTuple.Item2;
							int item4 = regressDoubleDropTuple.Item3;
							string item5 = regressDoubleDropTuple.Item4;
							string item6 = regressDoubleDropTuple.Item5;
							if (item2)
							{
								string multiText = TextConfig.Instance.GetMultiText(item6, Array.Empty<string>());
								string multiText2 = TextConfig.Instance.GetMultiText(item5, new string[]
								{
									item3.ToString(),
									item4.ToString()
								});
								tip = multiText + multiText2;
							}
						}
					}
				}
				else
				{
					ActivityDoubleRewardController instance = ActivityDoubleRewardController.Instance;
					int num3 = 3;
					List<int> list2 = new List<int>(num3);
					CollectionsMarshal.SetCount<int>(list2, num3);
					Span<int> span = CollectionsMarshal.AsSpan<int>(list2);
					int num4 = 0;
					*span[num4] = 1;
					num4++;
					*span[num4] = 2;
					num4++;
					*span[num4] = 6;
					tip = instance.GetDungeonUpActivityFullTip(list2, true);
				}
			}
			ItemRewardController.Instance.OpenExploreRewardView((list.Count > 0) ? 3004 : 3007, true, list, null, null, buttonInfoList, null, this.BuildRechallengeToggleData(true, settleButtonType), null, tip, null, new bool?(GameModeModel.Instance.IsMulti), null, null, new bool?(value), null, null);
		}

		// Token: 0x0602E846 RID: 190534 RVA: 0x00CFBCB0 File Offset: 0x00CF9EB0
		[NullableContext(0)]
		public UniTask<bool> OpenInstanceDungeonFailView()
		{
			InstanceDungeonEntranceController.<OpenInstanceDungeonFailView>d__78 <OpenInstanceDungeonFailView>d__;
			<OpenInstanceDungeonFailView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenInstanceDungeonFailView>d__.<>4__this = this;
			<OpenInstanceDungeonFailView>d__.<>1__state = -1;
			<OpenInstanceDungeonFailView>d__.<>t__builder.Start<InstanceDungeonEntranceController.<OpenInstanceDungeonFailView>d__78>(ref <OpenInstanceDungeonFailView>d__);
			return <OpenInstanceDungeonFailView>d__.<>t__builder.Task;
		}

		// Token: 0x0602E847 RID: 190535 RVA: 0x00CFBCF4 File Offset: 0x00CF9EF4
		private void EntranceStateNotify(IMessage msg, Net.CallbackStatus status)
		{
			EntranceStateNotify entranceStateNotify = (EntranceStateNotify)msg;
			long id = entranceStateNotify.Id;
			EntityHandle entity = CreatureModel.Instance.GetEntity(id);
			if (entity == null)
			{
				return;
			}
			int? num = null;
			switch (entranceStateNotify.State)
			{
			case EntranceState.NotUnlock:
				num = new int?(GameplayTagDefine.EGameplayTagId["物体.物体阶段.不可解锁"]);
				break;
			case EntranceState.Unlockable:
				num = new int?(GameplayTagDefine.EGameplayTagId["物体.物体阶段.可解锁"]);
				break;
			case EntranceState.Unlocked:
				num = new int?(GameplayTagDefine.EGameplayTagId["物体.物体阶段.已解锁"]);
				break;
			default:
				num = new int?(GameplayTagDefine.EGameplayTagId["物体.物体阶段.不可解锁"]);
				break;
			}
			LockComponent component = entity.Entity.GetComponent<LockComponent>();
			if (component != null)
			{
				component.ChangeLockTag(num.Value);
			}
		}

		// Token: 0x0602E848 RID: 190536 RVA: 0x00CFBDC4 File Offset: 0x00CF9FC4
		private void InstDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			InstDataNotify instDataNotify = (InstDataNotify)msg;
			InstanceDungeonEntranceModel.Instance.InitInstanceDataList(instDataNotify.EnterInfos);
		}

		// Token: 0x0602E849 RID: 190537 RVA: 0x00CFBDE8 File Offset: 0x00CF9FE8
		private void UpdateEnterInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			UpdateEnterInfoNotify updateEnterInfoNotify = (UpdateEnterInfoNotify)msg;
			InstanceDungeonEntranceModel.Instance.InitInstanceDataList(updateEnterInfoNotify.EnterInfos);
		}

		// Token: 0x0602E84A RID: 190538 RVA: 0x00CFBE0C File Offset: 0x00CFA00C
		private void TeamMatchInviteNotify(IMessage msg, Net.CallbackStatus status)
		{
			TeamMatchInviteNotify teamMatchInviteNotify = (TeamMatchInviteNotify)msg;
			InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
			instance.CancelMatchingTimer();
			InstanceDungeonModel.Instance.SetInstanceId(teamMatchInviteNotify.InstId);
			instance.SetMatchingId(teamMatchInviteNotify.InstId);
			if (PlotModel.Instance.IsInPlot)
			{
				return;
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.OnlineChallengeApplyView))
			{
				UiManager.Instance.CloseView(EUiViewName.OnlineChallengeApplyView, null);
			}
			UiManager.Instance.OpenView(EUiViewName.OnlineChallengeApplyView, null, null);
		}

		// Token: 0x0602E84B RID: 190539 RVA: 0x00CFBE88 File Offset: 0x00CFA088
		private void TeamMatchInviteRetToHostNotify(IMessage msg, Net.CallbackStatus status)
		{
			TeamMatchInviteRetToHostNotify teamMatchInviteRetToHostNotify = (TeamMatchInviteRetToHostNotify)msg;
			string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(teamMatchInviteRetToHostNotify.ErrorCode);
			GenericPromptController.Instance.ShowPromptByItsType(EPromptSubViewType.FloatLinePrompt, null, null, new object[]
			{
				textByErrorId
			}, null, null, null);
		}

		// Token: 0x0602E84C RID: 190540 RVA: 0x00CFBED0 File Offset: 0x00CFA0D0
		private void StartMatchNotify(IMessage msg, Net.CallbackStatus status)
		{
			StartMatchNotify startMatchNotify = (StartMatchNotify)msg;
			this.StartMatch(startMatchNotify.InstId);
		}

		// Token: 0x0602E84D RID: 190541 RVA: 0x00CFBEF0 File Offset: 0x00CFA0F0
		private void CancelMatchNotify(IMessage msg, Net.CallbackStatus status)
		{
			InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
			if (!OnlineModel.Instance.GetIsMyTeam() && instance.GetMatchingState() == EInstanceMatchState.Matching)
			{
				ScrollingTipsController.Instance.ShowTipsById("LeaderCancelMatch", Array.Empty<object>());
			}
			if (LoadingModel.Instance.IsLoading)
			{
				int matchingId = instance.GetMatchingId();
				if (matchingId != 0)
				{
					this.HandleTipsExitMatchId = matchingId;
				}
			}
			instance.CancelMatchingTimer();
		}

		// Token: 0x0602E84E RID: 190542 RVA: 0x00CFBF50 File Offset: 0x00CFA150
		private void TeamMatchAcceptInviteNotify(IMessage msg, Net.CallbackStatus status)
		{
			TeamMatchAcceptInviteNotify teamMatchAcceptInviteNotify = (TeamMatchAcceptInviteNotify)msg;
			if (teamMatchAcceptInviteNotify.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				string name = OnlineModel.Instance.GetCurrentTeamListById(teamMatchAcceptInviteNotify.PlayerId).Name;
				ScrollingTipsController.Instance.ShowTipsById("RefuseInviteMatch", new object[]
				{
					name
				});
			}
		}

		// Token: 0x0602E84F RID: 190543 RVA: 0x00CFBF9C File Offset: 0x00CFA19C
		[NullableContext(1)]
		public bool OpenViewLimit(EUiViewName viewName, object arg)
		{
			if (this.CheckInstanceShieldView(viewName))
			{
				if (BaseConfigController.Instance.GetIosAuditFirstDownloadTipWithSkip())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("IOSCannotUseTips", Array.Empty<object>());
				}
				else
				{
					ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonShieldViewCantOpen", Array.Empty<object>());
				}
				return false;
			}
			return true;
		}

		// Token: 0x0602E850 RID: 190544 RVA: 0x00CFBFF0 File Offset: 0x00CFA1F0
		public void OpenEditBattleView()
		{
			int instanceId = InstanceDungeonEntranceModel.Instance.GetMatchingId();
			if (LoadingModel.Instance.IsLoading)
			{
				this.HandleExitMatch = true;
				return;
			}
			MatchTeamInfo matchTeamInfo = InstanceDungeonModel.Instance.GetMatchTeamInfo();
			Aki.Protocol.Vector vector = (matchTeamInfo != null) ? matchTeamInfo.Location : null;
			MatchTeamInfo matchTeamInfo2 = InstanceDungeonModel.Instance.GetMatchTeamInfo();
			Aki.Protocol.Rotator rotator = (matchTeamInfo2 != null) ? matchTeamInfo2.Rotation : null;
			if (vector != null && rotator != null)
			{
				global::Vector vector2 = global::Vector.Create(vector);
				global::Rotator rotator2 = global::Rotator.Create(rotator);
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				CharacterDriveVehicleComponent characterDriveVehicleComponent;
				if (getCurrentEntity == null)
				{
					characterDriveVehicleComponent = null;
				}
				else
				{
					WorldEntity entity = getCurrentEntity.Entity;
					characterDriveVehicleComponent = ((entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null);
				}
				CharacterDriveVehicleComponent characterDriveVehicleComponent2 = characterDriveVehicleComponent;
				if (characterDriveVehicleComponent2 != null)
				{
					Entity vehicleEntity = characterDriveVehicleComponent2.VehicleEntity;
					if (vehicleEntity != null && vehicleEntity.Valid)
					{
						BaseVehiclePerformComponent component = characterDriveVehicleComponent2.VehicleEntity.GetComponent<BaseVehiclePerformComponent>();
						if (component != null)
						{
							component.TryLeaveAtOnce(characterDriveVehicleComponent2.Entity, ELeaveVehicleType.StandUp, "InstanceDungeonEntranceController.OpenEditBattleView", false);
						}
					}
				}
				TeleportController.Instance.TeleportPlayer(new ITeleportContextParam
				{
					ClientReason = "InstanceDungeonEntranceController.OpenEditBattleView",
					TargetPosition = vector2.ToUeVector(false),
					TargetRotation = rotator2.ToUeRotator(),
					TeleportMode = new ETeleportMode?(ETeleportMode.Loading)
				}).ContinueWith(delegate(bool _)
				{
					BattleTeamModel.Instance.Context.SetMultiEntry(true);
					FormationController.Instance.OpenBattleTeamView(instanceId, true, true, false, null);
					EventSystem.Instance.Emit(EEventName.OnEnterTeam);
				});
				return;
			}
			BattleTeamModel.Instance.Context.SetMultiEntry(true);
			FormationController.Instance.OpenBattleTeamView(instanceId, true, true, false, null);
			EventSystem.Instance.Emit(EEventName.OnEnterTeam);
		}

		// Token: 0x0602E851 RID: 190545 RVA: 0x00CFC168 File Offset: 0x00CFA368
		[NullableContext(1)]
		private List<IRewardExploreConfirmButton> InitSettleViewButtonList(bool isSuccess)
		{
			List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId());
			int settleType = config.Value.SettleButtonType;
			bool isMulti = GameModeModel.Instance.IsMulti;
			if (!isSuccess || isMulti || settleType == 3 || settleType == 1 || settleType == 4)
			{
				RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
				{
					ButtonTextId = "Text_ButtonTextExit_Text",
					DescriptionTextId = "GenericPromptTypes_2_GeneralText",
					DescriptionArgs = null,
					TimeDown = new int?(config.Value.AutoLeaveTime * TimeUtil.Instance.InverseMillisecond),
					IsTimeDownCloseView = true,
					OnTimeDownOnCallback = delegate
					{
						this.LeaveInstanceDungeon();
					},
					IsClickedCloseView = false,
					OnClickedCallback = delegate(int index)
					{
						this.LeaveInstanceDungeon().ContinueWith(delegate(bool _)
						{
							if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
							{
								UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
							}
						});
					}
				};
				list.Add(item);
			}
			if (isMulti)
			{
				string buttonTextId = CreatureModel.Instance.IsMyWorld() ? "Text_ContinueChallenge_Text" : "Text_SuggestContinueChallenge_Text";
				List<object> list2 = new List<object>();
				int powerCount = PowerModel.Instance.PowerCount;
				list2.Add(powerCount);
				string item2 = "<texture=" + this.PowerIconPath + "/>";
				list2.Add(item2);
				RewardExploreConfirmButtonData item3 = new RewardExploreConfirmButtonData
				{
					ButtonTextId = buttonTextId,
					DescriptionTextId = "Text_RemainText_Text",
					DescriptionArgs = list2,
					IsTimeDownCloseView = false,
					IsClickedCloseView = false,
					OnClickedCallback = new Action<int>(this.SettleViewButtonSuccessOnMultiCallBack),
					ClickCd = new int?(OnlineModel.Instance.ApplyCd * TimeUtil.Instance.InverseMillisecond)
				};
				list.Add(item3);
				return list;
			}
			if (!isSuccess || settleType == 4)
			{
				this.IsShowSettlePower = true;
				List<object> list3 = new List<object>();
				string text = PowerModel.Instance.PowerCount.ToString();
				int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
				int? instancePowerCost = InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(instanceId);
				if (!PowerModel.Instance.IsPowerEnough(instancePowerCost))
				{
					text = "<color=#c25757>" + text + "</color>";
				}
				list3.Add(text);
				string item4 = "<texture=" + this.PowerIconPath + "/>";
				list3.Add(item4);
				Action <>9__6;
				RewardExploreConfirmButtonData item5 = new RewardExploreConfirmButtonData
				{
					ButtonTextId = "Text_ChallengeAgain_Text",
					DescriptionTextId = (((instancePowerCost ?? 0) != 0) ? "Text_RemainText_Text" : null),
					DescriptionArgs = (((instancePowerCost ?? 0) != 0) ? list3 : null),
					IsTimeDownCloseView = false,
					IsClickedCloseView = false,
					OnClickedCallback = delegate(int index)
					{
						int? instancePowerCost2 = InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(instanceId);
						if (!PowerModel.Instance.IsPowerEnough(instancePowerCost2) && !InstanceDungeonModel.Instance.HidePowerLackConfirmBox)
						{
							ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstancePowerNotEnough);
							confirmBoxDataNew.ShowPowerItem = true;
							confirmBoxDataNew.SetTextArgs(new string[]
							{
								instancePowerCost2.ToString(),
								PowerModel.Instance.PowerCount.ToString()
							});
							confirmBoxDataNew.FunctionMap.Add(1, delegate
							{
							});
							Dictionary<int, Action> functionMap = confirmBoxDataNew.FunctionMap;
							int key = 2;
							Action value;
							if ((value = <>9__6) == null)
							{
								value = (<>9__6 = delegate()
								{
									bool settleRechallengeInInst2 = this.GetSettleRechallengeInInst(isSuccess, settleType, instanceId);
									this.RestartInstanceDungeon(settleRechallengeInInst2).ContinueWith(delegate(bool _)
									{
										if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
										{
											UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
										}
									});
								});
							}
							functionMap.Add(key, value);
							confirmBoxDataNew.HasToggle = true;
							confirmBoxDataNew.ToggleText = TextConfig.Instance.GetTextById("PlotSkipConfirmToggle");
							confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
							{
								InstanceDungeonModel.Instance.HidePowerLackConfirmBox = isSelectOn;
							});
							ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
							return;
						}
						if (!InstanceDungeonEntranceModel.Instance.CheckInstanceCanChallenge(instanceId))
						{
							ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonLackChallengeTimes", Array.Empty<object>());
							return;
						}
						bool settleRechallengeInInst = this.GetSettleRechallengeInInst(isSuccess, settleType, instanceId);
						this.RestartInstanceDungeon(settleRechallengeInInst).ContinueWith(delegate(bool _)
						{
							if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
							{
								UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
							}
						});
					}
				};
				list.Add(item5);
			}
			if (isSuccess && (settleType == 2 || settleType == 3))
			{
				RewardExploreConfirmButtonData item6 = new RewardExploreConfirmButtonData
				{
					ButtonTextId = "Text_KeepOnButton_Text",
					DescriptionTextId = null,
					IsTimeDownCloseView = false,
					IsClickedCloseView = false,
					OnClickedCallback = delegate(int index)
					{
						if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
						{
							UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
							this.IsShowSettlePower = false;
						}
					}
				};
				list.Add(item6);
			}
			return list;
		}

		// Token: 0x0602E852 RID: 190546 RVA: 0x00CFC4CC File Offset: 0x00CFA6CC
		public void SettleViewButtonSuccessOnMultiCallBack(int index)
		{
			if (!OnlineModel.Instance.AllowInitiate)
			{
				ScrollingTipsController.Instance.ShowTipsById("CannotInvite", Array.Empty<object>());
				return;
			}
			bool flag = CreatureModel.Instance.IsMyWorld();
			double nextInitiateLeftTime = OnlineModel.Instance.NextInitiateLeftTime;
			if (nextInitiateLeftTime > 0.0)
			{
				if (flag)
				{
					ScrollingTipsController.Instance.ShowTipsById("NextInviteTime", new object[]
					{
						TimeUtil.Instance.GetCoolDown(nextInitiateLeftTime)
					});
					return;
				}
				ScrollingTipsController.Instance.ShowTipsById("NextSuggestTime", new object[]
				{
					TimeUtil.Instance.GetCoolDown(nextInitiateLeftTime)
				});
				return;
			}
			else
			{
				if (UiManager.Instance.IsViewOpen(EUiViewName.OnlineChallengeApplyView))
				{
					UiManager.Instance.CloseView(EUiViewName.OnlineChallengeApplyView, null);
				}
				if (OnlineModel.Instance.GetContinuingChallengeConfirmState(PlayerInfoModel.Instance.GetId().Value).GetValueOrDefault() == EContinuingChallenge.Pending)
				{
					OnlineController.Instance.ApplyRechallengeRequest(ApplyRechallengeReason.Settle);
					return;
				}
				if (flag)
				{
					OnlineController.Instance.InviteRechallengeRequest();
					return;
				}
				OnlineController.Instance.ApplyRechallengeRequest(ApplyRechallengeReason.Settle);
				return;
			}
		}

		// Token: 0x0602E853 RID: 190547 RVA: 0x00CFC5D4 File Offset: 0x00CFA7D4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IRewardExploreBar> InitBarData()
		{
			List<IRewardExploreBar> list = new List<IRewardExploreBar>();
			IReadOnlyList<TrainingData> trainingDataList = TrainingDegreeModel.Instance.GetTrainingDataList();
			if (trainingDataList == null)
			{
				return null;
			}
			foreach (TrainingData trainingData in trainingDataList)
			{
				RewardExploreBar item = new RewardExploreBar
				{
					TrainingData = trainingData
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0602E854 RID: 190548 RVA: 0x00CFC644 File Offset: 0x00CFA844
		private void StartMatch(int instId)
		{
			InstanceDungeonEntranceController.<>c__DisplayClass94_0 CS$<>8__locals1 = new InstanceDungeonEntranceController.<>c__DisplayClass94_0();
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InstanceDungeonConfig.Instance.GetConfig(instId).Value.MapName, null);
			ScrollingTipsController.Instance.ShowTipsById("TeamLeaderMatch", new object[]
			{
				localTextNew
			});
			CS$<>8__locals1.entranceModel = InstanceDungeonEntranceModel.Instance;
			CS$<>8__locals1.entranceModel.SetMatchingId(instId);
			CS$<>8__locals1.entranceModel.SetMatchingState(EInstanceMatchState.Matching);
			EventSystem.Instance.Emit(EEventName.OnMatchingBegin);
			if (!UiManager.Instance.IsViewOpen(EUiViewName.OnlineWorldHallView) && !UiManager.Instance.IsViewOpen(EUiViewName.InstanceDungeonEntranceView) && !UiManager.Instance.IsViewOpen(EUiViewName.BattleTeam2DView))
			{
				CS$<>8__locals1.entranceModel.MatchingTime = 0;
				CS$<>8__locals1.entranceModel.OnStopTimer = new Func<bool>(CS$<>8__locals1.<StartMatch>g__StopTimer|0);
				this.StartMatchTimer(null);
			}
		}

		// Token: 0x0602E855 RID: 190549 RVA: 0x00CFC724 File Offset: 0x00CFA924
		public void StartMatchTimer(Action handle = null)
		{
			InstanceDungeonEntranceModel entranceModel = InstanceDungeonEntranceModel.Instance;
			if (entranceModel.MatchingTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(entranceModel.MatchingTimer);
			}
			entranceModel.MatchingTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				if (entranceModel.OnStopTimer == null)
				{
					if (entranceModel.MatchingTimer != null)
					{
						TimerSystem.GameplayTimeInstance.Remove(entranceModel.MatchingTimer);
					}
					entranceModel.OnStopTimer = null;
					entranceModel.OnStopHandle = null;
					entranceModel.MatchingTimer = null;
					return;
				}
				if (entranceModel.OnStopTimer())
				{
					if (entranceModel.MatchingTimer != null)
					{
						TimerSystem.GameplayTimeInstance.Remove(entranceModel.MatchingTimer);
					}
					entranceModel.MatchingTimer = null;
					if (entranceModel.OnStopHandle != null)
					{
						entranceModel.OnStopHandle();
					}
					return;
				}
				entranceModel.MatchingTimeIncrease();
				Action handle2 = handle;
				if (handle2 == null)
				{
					return;
				}
				handle2();
			}, 1000f, 1f, null, null, true);
		}

		// Token: 0x0602E856 RID: 190550 RVA: 0x00CFC79C File Offset: 0x00CFA99C
		private UniTask OpenThirdPartyMessageBox(ESdkPrivilege privilege)
		{
			InstanceDungeonEntranceController.<OpenThirdPartyMessageBox>d__96 <OpenThirdPartyMessageBox>d__;
			<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenThirdPartyMessageBox>d__.privilege = privilege;
			<OpenThirdPartyMessageBox>d__.<>1__state = -1;
			<OpenThirdPartyMessageBox>d__.<>t__builder.Start<InstanceDungeonEntranceController.<OpenThirdPartyMessageBox>d__96>(ref <OpenThirdPartyMessageBox>d__);
			return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
		}

		// Token: 0x0602E857 RID: 190551 RVA: 0x00CFC7E0 File Offset: 0x00CFA9E0
		public IInstanceDungeonEntranceAbility CreateInstanceSubViewByType(EInstanceEntranceSubViewType t)
		{
			Func<IInstanceDungeonEntranceAbility> func;
			if (this.InstanceSubViewCache.TryGetValue(t, out func))
			{
				return func();
			}
			return null;
		}

		// Token: 0x0602E858 RID: 190552 RVA: 0x00CFC808 File Offset: 0x00CFAA08
		public string GetInstanceSubtitleTextIdByInstanceId(int id)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id);
			if (config == null)
			{
				return null;
			}
			if (config.Value.InstSubType == 22)
			{
				return MowingRiskModel.Instance.BuildInstanceSubtitleTextIdByInstanceId(id);
			}
			return null;
		}

		// Token: 0x0602E859 RID: 190553 RVA: 0x00CFC84C File Offset: 0x00CFAA4C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceSubtitleArgsByInstanceId(int id)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id);
			if (config == null)
			{
				return null;
			}
			if (config.Value.InstSubType == 22)
			{
				return MowingRiskModel.Instance.BuildInstanceSubtitleTextArgsByInstanceId(id);
			}
			return null;
		}

		// Token: 0x0602E85A RID: 190554 RVA: 0x00CFC890 File Offset: 0x00CFAA90
		public string GetIconRightPathGetter(int instanceId)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config == null)
			{
				return null;
			}
			if (config.Value.InstSubType == 28)
			{
				return SolarSpeedModel.Instance.GetIconPathInInstanceSeriesItemByInstanceId(instanceId);
			}
			return null;
		}

		// Token: 0x0602E85B RID: 190555 RVA: 0x00CFC8D4 File Offset: 0x00CFAAD4
		public bool GetInstanceItemLockStateGetter(int instanceId)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType != 28 && !InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(instanceId);
		}

		// Token: 0x0602E85C RID: 190556 RVA: 0x00CFC91B File Offset: 0x00CFAB1B
		public bool CheckRightTitleAvailableByInstanceId(int instanceId)
		{
			return InstanceDungeonEntranceConfig.Instance.GetEntranceIdByInstanceId(instanceId) != 9000;
		}

		// Token: 0x0602E85D RID: 190557 RVA: 0x00CFC934 File Offset: 0x00CFAB34
		public TPictureItemDataGetter GetPictureItemDataGetter(int instanceId)
		{
			if (InstanceDungeonEntranceConfig.Instance.GetEntranceIdByInstanceId(instanceId) == 9000)
			{
				return () => SolarSpeedModel.Instance.GetInfoPicturePathByInstanceId(instanceId);
			}
			return null;
		}

		// Token: 0x0602E85E RID: 190558 RVA: 0x00CFC974 File Offset: 0x00CFAB74
		public TDescWidelyItemDataGetter GetDescWidelyItemDataGetter(int instanceId)
		{
			if (InstanceDungeonEntranceConfig.Instance.GetEntranceIdByInstanceId(instanceId) != 9000)
			{
				return null;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config == null)
			{
				return null;
			}
			return () => config.Value.DungeonDesc;
		}

		// Token: 0x0602E85F RID: 190559 RVA: 0x00CFC9C8 File Offset: 0x00CFABC8
		public TTitleWidelyItemDataGetter GetTitleWidelyItemDataGetter(int instanceId)
		{
			if (InstanceDungeonEntranceConfig.Instance.GetEntranceIdByInstanceId(instanceId) != 9000)
			{
				return null;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config == null)
			{
				return null;
			}
			return () => config.Value.MapName;
		}

		// Token: 0x0602E860 RID: 190560 RVA: 0x00CFCA1C File Offset: 0x00CFAC1C
		public TScoreListItemDataGetter GetScoreListItemDataGetter(int instanceId)
		{
			if (InstanceDungeonEntranceConfig.Instance.GetEntranceIdByInstanceId(instanceId) == 9000)
			{
				return delegate()
				{
					SolarSpeedModel instance = SolarSpeedModel.Instance;
					int? historyRankByInstanceId = instance.GetHistoryRankByInstanceId(instanceId);
					if (historyRankByInstanceId != null)
					{
						int? num = historyRankByInstanceId;
						int num2 = 0;
						if (!(num.GetValueOrDefault() == num2 & num != null))
						{
							int? historyHighScoreByInstanceId = instance.GetHistoryHighScoreByInstanceId(instanceId);
							int valueOrDefault = instance.GetHistoryLapRecordByInstanceId(instanceId).GetValueOrDefault();
							string medalPathId = (historyRankByInstanceId == null) ? null : instance.GetMedalPathByRank(historyRankByInstanceId.Value);
							return new InstanceDungeonScoreListItemData
							{
								TitleTextId1 = "LianjiPaoku_Top_Rank",
								TitleTextId2 = "LianjiPaoku_Top_Score",
								TitleTextId3 = "LianjiPaoku_Top_Time",
								ScoreText1 = (((historyRankByInstanceId != null) ? historyRankByInstanceId.GetValueOrDefault().ToString() : null) ?? ""),
								ScoreText2 = (((historyHighScoreByInstanceId != null) ? historyHighScoreByInstanceId.GetValueOrDefault().ToString() : null) ?? ""),
								ScoreText3 = ((valueOrDefault == 0) ? (ConfigMultiTextLang.GetLocalTextNew("LianjiPaoku_Top_Time_No_Time", null) ?? "") : TimeUtil.Instance.GetTimeString((double)valueOrDefault)),
								MedalPathId = medalPathId
							};
						}
					}
					return null;
				};
			}
			return null;
		}

		// Token: 0x17005E2C RID: 24108
		// (get) Token: 0x0602E861 RID: 190561 RVA: 0x00CFCA5B File Offset: 0x00CFAC5B
		[Nullable(1)]
		public static InstanceDungeonEntranceController Instance
		{
			[NullableContext(1)]
			get
			{
				return InstanceDungeonEntranceController._Instance;
			}
		}

		// Token: 0x0602E862 RID: 190562 RVA: 0x00CFCA62 File Offset: 0x00CFAC62
		[NullableContext(1)]
		public static InstanceDungeonEntranceController GetOrCreateInstance()
		{
			if (InstanceDungeonEntranceController._Instance == null)
			{
				InstanceDungeonEntranceController.CreateInstance();
			}
			return InstanceDungeonEntranceController._Instance;
		}

		// Token: 0x0602E863 RID: 190563 RVA: 0x00CFCA76 File Offset: 0x00CFAC76
		public static bool CreateInstance()
		{
			if (InstanceDungeonEntranceController._Instance != null)
			{
				return true;
			}
			InstanceDungeonEntranceController._Instance = new InstanceDungeonEntranceController();
			return true;
		}

		// Token: 0x0602E864 RID: 190564 RVA: 0x00CFCA8C File Offset: 0x00CFAC8C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E865 RID: 190565 RVA: 0x00CFCA8E File Offset: 0x00CFAC8E
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonEntranceController._Instance = null;
		}

		// Token: 0x0602E866 RID: 190566 RVA: 0x00CFCA96 File Offset: 0x00CFAC96
		static InstanceDungeonEntranceController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonEntranceController.CreateStaticDefaultValue), new Action(InstanceDungeonEntranceController.ResetStaticDefaultValue));
		}

		// Token: 0x04018C37 RID: 101431
		private const int ONE_SECONDS = 1000;

		// Token: 0x04018C38 RID: 101432
		private const int INSTANCE_SUCCESS = 3004;

		// Token: 0x04018C39 RID: 101433
		private const int INSTANCE_FAIL = 3005;

		// Token: 0x04018C3A RID: 101434
		private const int INSTANCE_SUCCESS_NO_REWARD = 3007;

		// Token: 0x04018C3B RID: 101435
		private const int SETTLE_TYPE_ONETIME = 1;

		// Token: 0x04018C3C RID: 101436
		private const int SETTLE_TYPE_ROLETRIAL = 2;

		// Token: 0x04018C3D RID: 101437
		private const int SETTLE_TYPE_NONE = 3;

		// Token: 0x04018C3E RID: 101438
		public const int SETTLE_TYPE_MATERIALS = 4;

		// Token: 0x04018C3F RID: 101439
		private const int SETTLE_TYPE_CLOSE = 5;

		// Token: 0x04018C40 RID: 101440
		private InstSettleNotify SettleCache;

		// Token: 0x04018C41 RID: 101441
		public bool LimitOpenView = true;

		// Token: 0x04018C42 RID: 101442
		private string PowerIconPath;

		// Token: 0x04018C43 RID: 101443
		private bool IsShowSettlePower;

		// Token: 0x04018C44 RID: 101444
		private bool IsShowSettleSuccess;

		// Token: 0x04018C45 RID: 101445
		public bool IsSettleExternalProcess;

		// Token: 0x04018C46 RID: 101446
		[Nullable(1)]
		private readonly Dictionary<EInstanceEntranceSubViewType, Func<IInstanceDungeonEntranceAbility>> InstanceSubViewCache = new Dictionary<EInstanceEntranceSubViewType, Func<IInstanceDungeonEntranceAbility>>();

		// Token: 0x04018C47 RID: 101447
		public int HandleTipsExitMatchId;

		// Token: 0x04018C48 RID: 101448
		public bool HandleExitMatch;

		// Token: 0x04018C49 RID: 101449
		private static InstanceDungeonEntranceController _Instance;
	}
}
