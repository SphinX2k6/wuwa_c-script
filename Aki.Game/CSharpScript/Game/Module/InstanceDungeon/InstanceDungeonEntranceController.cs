using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
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

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200586D RID: 22637
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonEntranceController : UiControllerBase
	{
		// Token: 0x060398EB RID: 235755 RVA: 0x00DAB60D File Offset: 0x00DA980D
		protected override bool OnInit()
		{
			this.PowerIconPath = InventoryConfig.Instance.GetItemConfigData(5).IconSmall;
			this.RegisterInstanceSubViewBuilder();
			return true;
		}

		// Token: 0x060398EC RID: 235756 RVA: 0x00DAB62C File Offset: 0x00DA982C
		protected override bool OnClear()
		{
			this.SettleCache = null;
			this.PowerIconPath = null;
			this.UnRegisterInstanceSubViewBuilder();
			return true;
		}

		// Token: 0x060398ED RID: 235757 RVA: 0x00DAB643 File Offset: 0x00DA9843
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.OpenViewLimit), "InstanceDungeonEntranceController.OpenViewLimit");
		}

		// Token: 0x060398EE RID: 235758 RVA: 0x00DAB665 File Offset: 0x00DA9865
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.OpenViewLimit));
		}

		// Token: 0x060398EF RID: 235759 RVA: 0x00DAB684 File Offset: 0x00DA9884
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
			EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnline));
			EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.TeleportComplete));
		}

		// Token: 0x060398F0 RID: 235760 RVA: 0x00DAB720 File Offset: 0x00DA9920
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
			EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnline));
			EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.TeleportComplete));
		}

		// Token: 0x060398F1 RID: 235761 RVA: 0x00DAB7BC File Offset: 0x00DA99BC
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

		// Token: 0x060398F2 RID: 235762 RVA: 0x00DAB9E0 File Offset: 0x00DA9BE0
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

		// Token: 0x060398F3 RID: 235763 RVA: 0x00DABB0D File Offset: 0x00DA9D0D
		private void RegisterInstanceSubViewBuilder()
		{
			this.InstanceSubViewCache.Add(EInstanceEntranceSubViewType.MowingRisk, () => new MowingRiskInstanceView());
		}

		// Token: 0x060398F4 RID: 235764 RVA: 0x00DABB3E File Offset: 0x00DA9D3E
		private void UnRegisterInstanceSubViewBuilder()
		{
			this.InstanceSubViewCache.Clear();
		}

		// Token: 0x060398F5 RID: 235765 RVA: 0x00DABB4B File Offset: 0x00DA9D4B
		private void OnWorldDone()
		{
			this.IsShowSettlePower = false;
			if (this.SettleCache != null)
			{
				this.InstSettleNotify(this.SettleCache, null);
				this.SettleCache = null;
			}
		}

		// Token: 0x060398F6 RID: 235766 RVA: 0x00DABB70 File Offset: 0x00DA9D70
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

		// Token: 0x060398F7 RID: 235767 RVA: 0x00DABBEC File Offset: 0x00DA9DEC
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

		// Token: 0x060398F8 RID: 235768 RVA: 0x00DABC5E File Offset: 0x00DA9E5E
		private void TeleportComplete(TeleportContext teleportContext)
		{
			if (this.HandleExitMatch)
			{
				this.HandleExitMatch = false;
				this.LeaveMatchTeamRequest();
			}
		}

		// Token: 0x060398F9 RID: 235769 RVA: 0x00DABC76 File Offset: 0x00DA9E76
		private void OnLeaveOnline()
		{
			InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Default);
			EventSystem.Instance.Emit(EEventName.OnMatchingChange);
		}

		// Token: 0x060398FA RID: 235770 RVA: 0x00DABC94 File Offset: 0x00DA9E94
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

		// Token: 0x060398FB RID: 235771 RVA: 0x00DABCF0 File Offset: 0x00DA9EF0
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

		// Token: 0x060398FC RID: 235772 RVA: 0x00DABD34 File Offset: 0x00DA9F34
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

		// Token: 0x060398FD RID: 235773 RVA: 0x00DABD64 File Offset: 0x00DA9F64
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

		// Token: 0x060398FE RID: 235774 RVA: 0x00DABD98 File Offset: 0x00DA9F98
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

		// Token: 0x060398FF RID: 235775 RVA: 0x00DABDCA File Offset: 0x00DA9FCA
		public void OnEditBattleViewClose()
		{
			InstanceDungeonEntranceConfig.Instance.OnEditBattleViewClose();
		}

		// Token: 0x06039900 RID: 235776 RVA: 0x00DABDD8 File Offset: 0x00DA9FD8
		[NullableContext(0)]
		public UniTask<bool> EnterInstanceDungeon()
		{
			InstanceDungeonEntranceController.<EnterInstanceDungeon>d__37 <EnterInstanceDungeon>d__;
			<EnterInstanceDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterInstanceDungeon>d__.<>1__state = -1;
			<EnterInstanceDungeon>d__.<>t__builder.Start<InstanceDungeonEntranceController.<EnterInstanceDungeon>d__37>(ref <EnterInstanceDungeon>d__);
			return <EnterInstanceDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x06039901 RID: 235777 RVA: 0x00DABE14 File Offset: 0x00DAA014
		[NullableContext(0)]
		public UniTask<bool> EnterInstanceDungeonByAutoRole()
		{
			InstanceDungeonEntranceController.<EnterInstanceDungeonByAutoRole>d__38 <EnterInstanceDungeonByAutoRole>d__;
			<EnterInstanceDungeonByAutoRole>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterInstanceDungeonByAutoRole>d__.<>1__state = -1;
			<EnterInstanceDungeonByAutoRole>d__.<>t__builder.Start<InstanceDungeonEntranceController.<EnterInstanceDungeonByAutoRole>d__38>(ref <EnterInstanceDungeonByAutoRole>d__);
			return <EnterInstanceDungeonByAutoRole>d__.<>t__builder.Task;
		}

		// Token: 0x06039902 RID: 235778 RVA: 0x00DABE50 File Offset: 0x00DAA050
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

		// Token: 0x06039903 RID: 235779 RVA: 0x00DABE94 File Offset: 0x00DAA094
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

		// Token: 0x06039904 RID: 235780 RVA: 0x00DABED8 File Offset: 0x00DAA0D8
		[NullableContext(0)]
		public UniTask<bool> RestartInstanceDungeon()
		{
			InstanceDungeonEntranceController.<RestartInstanceDungeon>d__41 <RestartInstanceDungeon>d__;
			<RestartInstanceDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RestartInstanceDungeon>d__.<>1__state = -1;
			<RestartInstanceDungeon>d__.<>t__builder.Start<InstanceDungeonEntranceController.<RestartInstanceDungeon>d__41>(ref <RestartInstanceDungeon>d__);
			return <RestartInstanceDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x06039905 RID: 235781 RVA: 0x00DABF14 File Offset: 0x00DAA114
		[NullableContext(0)]
		public UniTask<bool> InstEntranceDetailRequest(int entranceId)
		{
			InstanceDungeonEntranceController.<InstEntranceDetailRequest>d__42 <InstEntranceDetailRequest>d__;
			<InstEntranceDetailRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<InstEntranceDetailRequest>d__.entranceId = entranceId;
			<InstEntranceDetailRequest>d__.<>1__state = -1;
			<InstEntranceDetailRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<InstEntranceDetailRequest>d__42>(ref <InstEntranceDetailRequest>d__);
			return <InstEntranceDetailRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06039906 RID: 235782 RVA: 0x00DABF58 File Offset: 0x00DAA158
		[NullableContext(0)]
		public UniTask<bool> MatchChangeRoleRequest([Nullable(1)] List<int> roleId)
		{
			InstanceDungeonEntranceController.<MatchChangeRoleRequest>d__43 <MatchChangeRoleRequest>d__;
			<MatchChangeRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MatchChangeRoleRequest>d__.roleId = roleId;
			<MatchChangeRoleRequest>d__.<>1__state = -1;
			<MatchChangeRoleRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<MatchChangeRoleRequest>d__43>(ref <MatchChangeRoleRequest>d__);
			return <MatchChangeRoleRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06039907 RID: 235783 RVA: 0x00DABF9C File Offset: 0x00DAA19C
		[NullableContext(0)]
		public UniTask<bool> MatchChangeReadyRequest(bool isReady)
		{
			InstanceDungeonEntranceController.<MatchChangeReadyRequest>d__44 <MatchChangeReadyRequest>d__;
			<MatchChangeReadyRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MatchChangeReadyRequest>d__.isReady = isReady;
			<MatchChangeReadyRequest>d__.<>1__state = -1;
			<MatchChangeReadyRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<MatchChangeReadyRequest>d__44>(ref <MatchChangeReadyRequest>d__);
			return <MatchChangeReadyRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06039908 RID: 235784 RVA: 0x00DABFE0 File Offset: 0x00DAA1E0
		[NullableContext(0)]
		public UniTask<bool> LeaveMatchTeamRequest()
		{
			InstanceDungeonEntranceController.<LeaveMatchTeamRequest>d__45 <LeaveMatchTeamRequest>d__;
			<LeaveMatchTeamRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LeaveMatchTeamRequest>d__.<>1__state = -1;
			<LeaveMatchTeamRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<LeaveMatchTeamRequest>d__45>(ref <LeaveMatchTeamRequest>d__);
			return <LeaveMatchTeamRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06039909 RID: 235785 RVA: 0x00DAC01C File Offset: 0x00DAA21C
		[NullableContext(0)]
		public UniTask<bool> KickMatchTeamPlayerRequest(int playerId)
		{
			InstanceDungeonEntranceController.<KickMatchTeamPlayerRequest>d__46 <KickMatchTeamPlayerRequest>d__;
			<KickMatchTeamPlayerRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<KickMatchTeamPlayerRequest>d__.playerId = playerId;
			<KickMatchTeamPlayerRequest>d__.<>1__state = -1;
			<KickMatchTeamPlayerRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<KickMatchTeamPlayerRequest>d__46>(ref <KickMatchTeamPlayerRequest>d__);
			return <KickMatchTeamPlayerRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603990A RID: 235786 RVA: 0x00DAC060 File Offset: 0x00DAA260
		[NullableContext(0)]
		public UniTask<bool> SetMatchTeamMatchFlagRequest(bool isMatch)
		{
			InstanceDungeonEntranceController.<SetMatchTeamMatchFlagRequest>d__47 <SetMatchTeamMatchFlagRequest>d__;
			<SetMatchTeamMatchFlagRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SetMatchTeamMatchFlagRequest>d__.isMatch = isMatch;
			<SetMatchTeamMatchFlagRequest>d__.<>1__state = -1;
			<SetMatchTeamMatchFlagRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<SetMatchTeamMatchFlagRequest>d__47>(ref <SetMatchTeamMatchFlagRequest>d__);
			return <SetMatchTeamMatchFlagRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603990B RID: 235787 RVA: 0x00DAC0A4 File Offset: 0x00DAA2A4
		[NullableContext(0)]
		public UniTask<bool> EnterMatchInstRequest()
		{
			InstanceDungeonEntranceController.<EnterMatchInstRequest>d__48 <EnterMatchInstRequest>d__;
			<EnterMatchInstRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterMatchInstRequest>d__.<>1__state = -1;
			<EnterMatchInstRequest>d__.<>t__builder.Start<InstanceDungeonEntranceController.<EnterMatchInstRequest>d__48>(ref <EnterMatchInstRequest>d__);
			return <EnterMatchInstRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603990C RID: 235788 RVA: 0x00DAC0E0 File Offset: 0x00DAA2E0
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

		// Token: 0x0603990D RID: 235789 RVA: 0x00DAC118 File Offset: 0x00DAA318
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

		// Token: 0x0603990E RID: 235790 RVA: 0x00DAC164 File Offset: 0x00DAA364
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

		// Token: 0x0603990F RID: 235791 RVA: 0x00DAC1C4 File Offset: 0x00DAA3C4
		[NullableContext(0)]
		private UniTask<bool> StartMatchRequestAsync(int instanceId, bool inviteTeamWorld = false, bool checkSubpack = true)
		{
			InstanceDungeonEntranceController.<StartMatchRequestAsync>d__52 <StartMatchRequestAsync>d__;
			<StartMatchRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartMatchRequestAsync>d__.<>4__this = this;
			<StartMatchRequestAsync>d__.instanceId = instanceId;
			<StartMatchRequestAsync>d__.inviteTeamWorld = inviteTeamWorld;
			<StartMatchRequestAsync>d__.checkSubpack = checkSubpack;
			<StartMatchRequestAsync>d__.<>1__state = -1;
			<StartMatchRequestAsync>d__.<>t__builder.Start<InstanceDungeonEntranceController.<StartMatchRequestAsync>d__52>(ref <StartMatchRequestAsync>d__);
			return <StartMatchRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039910 RID: 235792 RVA: 0x00DAC21F File Offset: 0x00DAA41F
		public void StartMatchRequest(int instanceId, bool inviteTeamWorld = false, bool checkSubpack = true)
		{
			this.StartMatchRequestAsync(instanceId, inviteTeamWorld, checkSubpack);
		}

		// Token: 0x06039911 RID: 235793 RVA: 0x00DAC22C File Offset: 0x00DAA42C
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

		// Token: 0x06039912 RID: 235794 RVA: 0x00DAC2C8 File Offset: 0x00DAA4C8
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

		// Token: 0x06039913 RID: 235795 RVA: 0x00DAC314 File Offset: 0x00DAA514
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

		// Token: 0x06039914 RID: 235796 RVA: 0x00DAC378 File Offset: 0x00DAA578
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

		// Token: 0x06039915 RID: 235797 RVA: 0x00DAC3FC File Offset: 0x00DAA5FC
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

		// Token: 0x06039916 RID: 235798 RVA: 0x00DAC450 File Offset: 0x00DAA650
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

		// Token: 0x06039917 RID: 235799 RVA: 0x00DAC4A4 File Offset: 0x00DAA6A4
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

		// Token: 0x06039918 RID: 235800 RVA: 0x00DAC628 File Offset: 0x00DAA828
		private void MatchingNotify(IMessage msg, Net.CallbackStatus status)
		{
			InstanceDungeonEntranceModel.Instance.SetMatchingState(EInstanceMatchState.Matching);
			EventSystem.Instance.Emit(EEventName.OnMatchingChange);
		}

		// Token: 0x06039919 RID: 235801 RVA: 0x00DAC648 File Offset: 0x00DAA848
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

		// Token: 0x0603991A RID: 235802 RVA: 0x00DAC6EC File Offset: 0x00DAA8EC
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

		// Token: 0x0603991B RID: 235803 RVA: 0x00DAC798 File Offset: 0x00DAA998
		private void MatchChangeRoleNotify(IMessage msg, Net.CallbackStatus status)
		{
			MatchChangeRoleNotify matchChangeRoleNotify = (MatchChangeRoleNotify)msg;
			InstanceDungeonModel.Instance.SetMatchTeamInfoPlayerRole(matchChangeRoleNotify.PlayerId, matchChangeRoleNotify.RoleInfo);
		}

		// Token: 0x0603991C RID: 235804 RVA: 0x00DAC7C4 File Offset: 0x00DAA9C4
		private void MatchChangeReadyNotify(IMessage msg, Net.CallbackStatus status)
		{
			MatchChangeReadyNotify matchChangeReadyNotify = (MatchChangeReadyNotify)msg;
			InstanceDungeonModel.Instance.SetPrewarPlayerReadyState(matchChangeReadyNotify.PlayerId, matchChangeReadyNotify.IsReady);
			EventSystem.Instance.Emit<int, bool>(EEventName.PrewarReadyChanged, matchChangeReadyNotify.PlayerId, matchChangeReadyNotify.IsReady);
			InstanceDungeonModel.Instance.SetPlayerUiState(matchChangeReadyNotify.PlayerId, matchChangeReadyNotify.IsReady ? EMatchPlayerUiState.Ready : EMatchPlayerUiState.Wait);
		}

		// Token: 0x0603991D RID: 235805 RVA: 0x00DAC828 File Offset: 0x00DAAA28
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

		// Token: 0x0603991E RID: 235806 RVA: 0x00DAC95C File Offset: 0x00DAAB5C
		private void EnterMatchTeamNotify(IMessage msg, Net.CallbackStatus status)
		{
			EnterMatchTeamNotify enterMatchTeamNotify = (EnterMatchTeamNotify)msg;
			InstanceDungeonModel.Instance.SetMatchingPlayerConfirmState(enterMatchTeamNotify.PlayerInfo.PlayerId, false);
			InstanceDungeonModel.Instance.SetPrewarPlayerReadyState(enterMatchTeamNotify.PlayerInfo.PlayerId, false);
			InstanceDungeonModel.Instance.AddPrewarFormationDataByPlayerInfo(enterMatchTeamNotify.PlayerInfo, true);
			EventSystem.Instance.Emit(EEventName.PrewarFormationChanged);
		}

		// Token: 0x0603991F RID: 235807 RVA: 0x00DAC9C0 File Offset: 0x00DAABC0
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

		// Token: 0x06039920 RID: 235808 RVA: 0x00DACA50 File Offset: 0x00DAAC50
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
			if (InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()).Value.SettleButtonType == 5)
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
				int value2 = (InstanceDungeonConfig.Instance.GetConfig(instanceId) != null) ? instanceDungeon.GetValueOrDefault().InstSubType : 0;
				IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("MultiRewardLevelInstType");
				value = (intArrayConfig != null && intArrayConfig.Contains(value2));
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
					int num2 = 3;
					List<int> list2 = new List<int>(num2);
					CollectionsMarshal.SetCount<int>(list2, num2);
					Span<int> span = CollectionsMarshal.AsSpan<int>(list2);
					int num3 = 0;
					*span[num3] = 1;
					num3++;
					*span[num3] = 2;
					num3++;
					*span[num3] = 6;
					tip = instance.GetDungeonUpActivityFullTip(list2, true);
				}
			}
			ItemRewardController.Instance.OpenExploreRewardView((list.Count > 0) ? 3004 : 3007, true, list, null, null, buttonInfoList, null, null, null, tip, null, new bool?(GameModeModel.Instance.IsMulti), null, null, new bool?(value), null, null);
		}

		// Token: 0x06039921 RID: 235809 RVA: 0x00DACD9C File Offset: 0x00DAAF9C
		[NullableContext(0)]
		public UniTask<bool> OpenInstanceDungeonFailView()
		{
			InstanceDungeonEntranceController.<OpenInstanceDungeonFailView>d__70 <OpenInstanceDungeonFailView>d__;
			<OpenInstanceDungeonFailView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenInstanceDungeonFailView>d__.<>4__this = this;
			<OpenInstanceDungeonFailView>d__.<>1__state = -1;
			<OpenInstanceDungeonFailView>d__.<>t__builder.Start<InstanceDungeonEntranceController.<OpenInstanceDungeonFailView>d__70>(ref <OpenInstanceDungeonFailView>d__);
			return <OpenInstanceDungeonFailView>d__.<>t__builder.Task;
		}

		// Token: 0x06039922 RID: 235810 RVA: 0x00DACDE0 File Offset: 0x00DAAFE0
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

		// Token: 0x06039923 RID: 235811 RVA: 0x00DACEB0 File Offset: 0x00DAB0B0
		private void InstDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			InstDataNotify instDataNotify = (InstDataNotify)msg;
			InstanceDungeonEntranceModel.Instance.InitInstanceDataList(instDataNotify.EnterInfos);
		}

		// Token: 0x06039924 RID: 235812 RVA: 0x00DACED4 File Offset: 0x00DAB0D4
		private void UpdateEnterInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			UpdateEnterInfoNotify updateEnterInfoNotify = (UpdateEnterInfoNotify)msg;
			InstanceDungeonEntranceModel.Instance.InitInstanceDataList(updateEnterInfoNotify.EnterInfos);
		}

		// Token: 0x06039925 RID: 235813 RVA: 0x00DACEF8 File Offset: 0x00DAB0F8
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

		// Token: 0x06039926 RID: 235814 RVA: 0x00DACF74 File Offset: 0x00DAB174
		private void TeamMatchInviteRetToHostNotify(IMessage msg, Net.CallbackStatus status)
		{
			TeamMatchInviteRetToHostNotify teamMatchInviteRetToHostNotify = (TeamMatchInviteRetToHostNotify)msg;
			string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(teamMatchInviteRetToHostNotify.ErrorCode);
			GenericPromptController.Instance.ShowPromptByItsType(EPromptSubViewType.FloatLinePrompt, null, null, new object[]
			{
				textByErrorId
			}, null, null, null);
		}

		// Token: 0x06039927 RID: 235815 RVA: 0x00DACFBC File Offset: 0x00DAB1BC
		private void StartMatchNotify(IMessage msg, Net.CallbackStatus status)
		{
			StartMatchNotify startMatchNotify = (StartMatchNotify)msg;
			this.StartMatch(startMatchNotify.InstId);
		}

		// Token: 0x06039928 RID: 235816 RVA: 0x00DACFDC File Offset: 0x00DAB1DC
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

		// Token: 0x06039929 RID: 235817 RVA: 0x00DAD03C File Offset: 0x00DAB23C
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

		// Token: 0x0603992A RID: 235818 RVA: 0x00DAD088 File Offset: 0x00DAB288
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

		// Token: 0x0603992B RID: 235819 RVA: 0x00DAD0DC File Offset: 0x00DAB2DC
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

		// Token: 0x0603992C RID: 235820 RVA: 0x00DAD254 File Offset: 0x00DAB454
		[NullableContext(1)]
		private List<IRewardExploreConfirmButton> InitSettleViewButtonList(bool isSuccess)
		{
			List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId());
			int settleButtonType = config.Value.SettleButtonType;
			bool isMulti = GameModeModel.Instance.IsMulti;
			if (!isSuccess || isMulti || settleButtonType == 3 || settleButtonType == 1 || settleButtonType == 4)
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
			if (!isSuccess || settleButtonType == 4)
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
							confirmBoxDataNew.FunctionMap.Add(2, delegate
							{
								this.RestartInstanceDungeon().ContinueWith(delegate(bool _)
								{
									if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
									{
										UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
									}
								});
							});
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
						this.RestartInstanceDungeon().ContinueWith(delegate(bool _)
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
			if (isSuccess && (settleButtonType == 2 || settleButtonType == 3))
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

		// Token: 0x0603992D RID: 235821 RVA: 0x00DAD570 File Offset: 0x00DAB770
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

		// Token: 0x0603992E RID: 235822 RVA: 0x00DAD678 File Offset: 0x00DAB878
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

		// Token: 0x0603992F RID: 235823 RVA: 0x00DAD6E8 File Offset: 0x00DAB8E8
		private void StartMatch(int instId)
		{
			InstanceDungeonEntranceController.<>c__DisplayClass86_0 CS$<>8__locals1 = new InstanceDungeonEntranceController.<>c__DisplayClass86_0();
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

		// Token: 0x06039930 RID: 235824 RVA: 0x00DAD7C8 File Offset: 0x00DAB9C8
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

		// Token: 0x06039931 RID: 235825 RVA: 0x00DAD840 File Offset: 0x00DABA40
		private UniTask OpenThirdPartyMessageBox(ESdkPrivilege privilege)
		{
			InstanceDungeonEntranceController.<OpenThirdPartyMessageBox>d__88 <OpenThirdPartyMessageBox>d__;
			<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenThirdPartyMessageBox>d__.privilege = privilege;
			<OpenThirdPartyMessageBox>d__.<>1__state = -1;
			<OpenThirdPartyMessageBox>d__.<>t__builder.Start<InstanceDungeonEntranceController.<OpenThirdPartyMessageBox>d__88>(ref <OpenThirdPartyMessageBox>d__);
			return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
		}

		// Token: 0x06039932 RID: 235826 RVA: 0x00DAD884 File Offset: 0x00DABA84
		public IInstanceDungeonEntranceAbility CreateInstanceSubViewByType(EInstanceEntranceSubViewType t)
		{
			Func<IInstanceDungeonEntranceAbility> func;
			if (this.InstanceSubViewCache.TryGetValue(t, out func))
			{
				return func();
			}
			return null;
		}

		// Token: 0x06039933 RID: 235827 RVA: 0x00DAD8AC File Offset: 0x00DABAAC
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

		// Token: 0x06039934 RID: 235828 RVA: 0x00DAD8F0 File Offset: 0x00DABAF0
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

		// Token: 0x06039935 RID: 235829 RVA: 0x00DAD934 File Offset: 0x00DABB34
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

		// Token: 0x06039936 RID: 235830 RVA: 0x00DAD978 File Offset: 0x00DABB78
		public bool GetInstanceItemLockStateGetter(int instanceId)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType != 28 && !InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(instanceId);
		}

		// Token: 0x06039937 RID: 235831 RVA: 0x00DAD9BF File Offset: 0x00DABBBF
		public bool CheckRightTitleAvailableByInstanceId(int instanceId)
		{
			return InstanceDungeonEntranceConfig.Instance.GetEntranceIdByInstanceId(instanceId) != 9000;
		}

		// Token: 0x06039938 RID: 235832 RVA: 0x00DAD9D8 File Offset: 0x00DABBD8
		public TPictureItemDataGetter GetPictureItemDataGetter(int instanceId)
		{
			if (InstanceDungeonEntranceConfig.Instance.GetEntranceIdByInstanceId(instanceId) == 9000)
			{
				return () => SolarSpeedModel.Instance.GetInfoPicturePathByInstanceId(instanceId);
			}
			return null;
		}

		// Token: 0x06039939 RID: 235833 RVA: 0x00DADA18 File Offset: 0x00DABC18
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

		// Token: 0x0603993A RID: 235834 RVA: 0x00DADA6C File Offset: 0x00DABC6C
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

		// Token: 0x0603993B RID: 235835 RVA: 0x00DADAC0 File Offset: 0x00DABCC0
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

		// Token: 0x17008A60 RID: 35424
		// (get) Token: 0x0603993C RID: 235836 RVA: 0x00DADAFF File Offset: 0x00DABCFF
		[Nullable(1)]
		public static InstanceDungeonEntranceController Instance
		{
			[NullableContext(1)]
			get
			{
				return InstanceDungeonEntranceController._Instance;
			}
		}

		// Token: 0x0603993D RID: 235837 RVA: 0x00DADB06 File Offset: 0x00DABD06
		[NullableContext(1)]
		public static InstanceDungeonEntranceController GetOrCreateInstance()
		{
			if (InstanceDungeonEntranceController._Instance == null)
			{
				InstanceDungeonEntranceController.CreateInstance();
			}
			return InstanceDungeonEntranceController._Instance;
		}

		// Token: 0x0603993E RID: 235838 RVA: 0x00DADB1A File Offset: 0x00DABD1A
		public static bool CreateInstance()
		{
			if (InstanceDungeonEntranceController._Instance != null)
			{
				return true;
			}
			InstanceDungeonEntranceController._Instance = new InstanceDungeonEntranceController();
			return true;
		}

		// Token: 0x0603993F RID: 235839 RVA: 0x00DADB30 File Offset: 0x00DABD30
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039940 RID: 235840 RVA: 0x00DADB32 File Offset: 0x00DABD32
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonEntranceController._Instance = null;
		}

		// Token: 0x06039941 RID: 235841 RVA: 0x00DADB3A File Offset: 0x00DABD3A
		static InstanceDungeonEntranceController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonEntranceController.CreateStaticDefaultValue), new Action(InstanceDungeonEntranceController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E19A RID: 123290
		private const int ONE_SECONDS = 1000;

		// Token: 0x0401E19B RID: 123291
		private const int INSTANCE_SUCCESS = 3004;

		// Token: 0x0401E19C RID: 123292
		private const int INSTANCE_FAIL = 3005;

		// Token: 0x0401E19D RID: 123293
		private const int INSTANCE_SUCCESS_NO_REWARD = 3007;

		// Token: 0x0401E19E RID: 123294
		private const int SETTLE_TYPE_ONETIME = 1;

		// Token: 0x0401E19F RID: 123295
		private const int SETTLE_TYPE_ROLETRIAL = 2;

		// Token: 0x0401E1A0 RID: 123296
		private const int SETTLE_TYPE_NONE = 3;

		// Token: 0x0401E1A1 RID: 123297
		public const int SETTLE_TYPE_MATERIALS = 4;

		// Token: 0x0401E1A2 RID: 123298
		private const int SETTLE_TYPE_CLOSE = 5;

		// Token: 0x0401E1A3 RID: 123299
		private InstSettleNotify SettleCache;

		// Token: 0x0401E1A4 RID: 123300
		public bool LimitOpenView = true;

		// Token: 0x0401E1A5 RID: 123301
		private string PowerIconPath;

		// Token: 0x0401E1A6 RID: 123302
		private bool IsShowSettlePower;

		// Token: 0x0401E1A7 RID: 123303
		private bool IsShowSettleSuccess;

		// Token: 0x0401E1A8 RID: 123304
		public bool IsSettleExternalProcess;

		// Token: 0x0401E1A9 RID: 123305
		[Nullable(1)]
		private readonly Dictionary<EInstanceEntranceSubViewType, Func<IInstanceDungeonEntranceAbility>> InstanceSubViewCache = new Dictionary<EInstanceEntranceSubViewType, Func<IInstanceDungeonEntranceAbility>>();

		// Token: 0x0401E1AA RID: 123306
		public int HandleTipsExitMatchId;

		// Token: 0x0401E1AB RID: 123307
		public bool HandleExitMatch;

		// Token: 0x0401E1AC RID: 123308
		private static InstanceDungeonEntranceController _Instance;
	}
}
