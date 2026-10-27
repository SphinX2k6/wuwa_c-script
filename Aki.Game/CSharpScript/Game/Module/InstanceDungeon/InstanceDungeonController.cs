using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200586A RID: 22634
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonController : UiControllerBase
	{
		// Token: 0x060398AC RID: 235692 RVA: 0x00DA9EB4 File Offset: 0x00DA80B4
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.GeneralLogicTreeWakeUp, new Action(this.OnBehaviorTreeWakedUp));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
			EventSystem.Instance.Add<string>(EEventName.InputDistribute, new Action<string>(this.OnInputDistribute));
			EventSystem.Instance.Add<InstResultNotify>(EEventName.OnInstResultNotify, new Action<InstResultNotify>(this.EventInstResultNotify));
			EventSystem.Instance.Add(EEventName.LoadingViewOnAfterShow, new Action(this.HandleLoadingViewOnAfterShow));
		}

		// Token: 0x060398AD RID: 235693 RVA: 0x00DA9F50 File Offset: 0x00DA8150
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeWakeUp, new Action(this.OnBehaviorTreeWakedUp));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
			EventSystem.Instance.Remove<string>(EEventName.InputDistribute, new Action<string>(this.OnInputDistribute));
			EventSystem.Instance.Remove<InstResultNotify>(EEventName.OnInstResultNotify, new Action<InstResultNotify>(this.EventInstResultNotify));
			EventSystem.Instance.Remove(EEventName.LoadingViewOnAfterShow, new Action(this.HandleLoadingViewOnAfterShow));
		}

		// Token: 0x060398AE RID: 235694 RVA: 0x00DA9FEC File Offset: 0x00DA81EC
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.InstPlayDataNotify, new Action<IMessage, Net.CallbackStatus>(this.InstPlayDataNotify));
			Net.Instance.Register(ENotifyMessageId.InstResultNotify, new Action<IMessage, Net.CallbackStatus>(this.InstResultNotify));
			Net.Instance.Register(ENotifyMessageId.TeleportDungeonActionNotify, new Action<IMessage, Net.CallbackStatus>(this.TeleportDungeonActionNotify));
			Net.Instance.Register(ENotifyMessageId.TeleportDungeonForbidNotify, new Action<IMessage, Net.CallbackStatus>(this.TeleportDungeonForbidNotify));
			Net.Instance.Register(ENotifyMessageId.InstSaveDataNotify, new Action<IMessage, Net.CallbackStatus>(this.InstSaveDataNotify));
		}

		// Token: 0x060398AF RID: 235695 RVA: 0x00DAA088 File Offset: 0x00DA8288
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.InstPlayDataNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InstResultNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeleportDungeonActionNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeleportDungeonForbidNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InstSaveDataNotify);
		}

		// Token: 0x060398B0 RID: 235696 RVA: 0x00DAA0E5 File Offset: 0x00DA82E5
		public double GetBeInviteOverdueTime(InstanceBeInviteData info)
		{
			if (info == null)
			{
				return 0.0;
			}
			return ((double)info.GetLimitTimestamp() - TimeUtil.Instance.GetServerTimeStamp()) / 1000.0;
		}

		// Token: 0x060398B1 RID: 235697 RVA: 0x00DAA110 File Offset: 0x00DA8310
		public void GetInstExchangeRewardRequest(int exchangeCount)
		{
			GetInstExchangeRewardRequest getInstExchangeRewardRequest = new GetInstExchangeRewardRequest();
			getInstExchangeRewardRequest.ExchangeCount = exchangeCount;
			Net.Instance.Call(ERequestMessageId.GetInstExchangeRewardRequest, getInstExchangeRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				GetInstExchangeRewardResponse getInstExchangeRewardResponse = (GetInstExchangeRewardResponse)msg;
				if (getInstExchangeRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeScrollingTipsView(getInstExchangeRewardResponse.ErrorCode, Array.Empty<string>());
				}
			}, 0);
		}

		// Token: 0x060398B2 RID: 235698 RVA: 0x00DAA15C File Offset: 0x00DA835C
		[NullableContext(1)]
		private void OnInputDistribute(string input)
		{
			if (GameModeController.Instance.IsInInstance() && input == "功能菜单" && !RecallQuestModel.Instance.IsInRecallInstance() && !LevelEventLockInputState.Instance.InputLimitEsc && !ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
			{
				this.OnClickInstanceDungeonExitButton(null, null, true);
			}
		}

		// Token: 0x060398B3 RID: 235699 RVA: 0x00DAA1B0 File Offset: 0x00DA83B0
		public void OnClickInstanceDungeonExitButton(Action confirmBack = null, Action cancelBack = null, bool isButton = true)
		{
			InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			InstanceDungeonExitHandlerBase instanceDungeonExitHandlerBase;
			if (DungeonExitHandlerDefine.DungeonExitHandlerMap.TryGetValue((EDungeonSubType)instanceDungeon.Value.InstSubType, out instanceDungeonExitHandlerBase) && instanceDungeonExitHandlerBase.Checker())
			{
				InstanceDungeonExitHandlerData instanceDungeonExitHandlerData = new InstanceDungeonExitHandlerData();
				instanceDungeonExitHandlerData.IsButton = isButton;
				instanceDungeonExitHandlerData.ConfirmBack = confirmBack;
				instanceDungeonExitHandlerData.CancelBack = cancelBack;
				instanceDungeonExitHandlerBase.HandleExit(instanceDungeonExitHandlerData);
				return;
			}
			int exitConfirmBoxConfigId = this.GetExitConfirmBoxConfigId();
			this.OpenNormalInstanceDungeonExitConfirmBox(exitConfirmBoxConfigId, confirmBack, cancelBack, isButton);
		}

		// Token: 0x060398B4 RID: 235700 RVA: 0x00DAA228 File Offset: 0x00DA8428
		public void OpenNormalInstanceDungeonExitConfirmBox(int id, Action confirmBack, Action cancelBack, bool isButton)
		{
			InstanceDungeonController.<>c__DisplayClass11_0 CS$<>8__locals1 = new InstanceDungeonController.<>c__DisplayClass11_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.confirmBack = confirmBack;
			CS$<>8__locals1.cancelBack = cancelBack;
			CS$<>8__locals1.needOpenReChallengeConfirmBox = this.NeedOpenReChallengeConfirmBox();
			InstanceDungeonModel instance = InstanceDungeonModel.Instance;
			EInstanceFinishState? einstanceFinishState = (instance != null) ? new EInstanceFinishState?(instance.InstanceFinishSuccess) : null;
			InstanceDungeonModel instance2 = InstanceDungeonModel.Instance;
			object obj;
			if (instance2 == null)
			{
				obj = null;
			}
			else
			{
				InstanceDungeonInfo instanceDungeonInfo = instance2.GetInstanceDungeonInfo();
				obj = ((instanceDungeonInfo != null) ? instanceDungeonInfo.FinishEscAction : null);
			}
			if (obj != null && isButton && einstanceFinishState.GetValueOrDefault() == EInstanceFinishState.Success)
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Esc);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)id);
			Action value = delegate()
			{
				if (CS$<>8__locals1.needOpenReChallengeConfirmBox)
				{
					if (!CS$<>8__locals1.<>4__this.CheckIfExitByOtherModule())
					{
						InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
					}
					EventSystem.Instance.Emit(EEventName.LeaveInstanceDungeonConfirm);
				}
				EventSystem.Instance.Emit(EEventName.LeaveInstanceExternalCancel);
				Action cancelBack2 = CS$<>8__locals1.cancelBack;
				if (cancelBack2 == null)
				{
					return;
				}
				cancelBack2();
			};
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[0] = CS$<>8__locals1.cancelBack;
			confirmBoxDataNew.FunctionMap[1] = value;
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<OpenNormalInstanceDungeonExitConfirmBox>g__ConfirmCallback|0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060398B5 RID: 235701 RVA: 0x00DAA318 File Offset: 0x00DA8518
		public bool NeedOpenReChallengeConfirmBox()
		{
			int instSubType = InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()).Value.InstSubType;
			return (instSubType == 4 || instSubType == 43) && !GameModeModel.Instance.IsMulti;
		}

		// Token: 0x060398B6 RID: 235702 RVA: 0x00DAA364 File Offset: 0x00DA8564
		public int GetExitConfirmBoxConfigId()
		{
			int? currentDungeonExitConfirmId = InstanceDungeonModel.Instance.GetCurrentDungeonExitConfirmId();
			if (currentDungeonExitConfirmId != null)
			{
				int? num = currentDungeonExitConfirmId;
				int num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					return currentDungeonExitConfirmId.Value;
				}
			}
			int result;
			if (this.NeedOpenReChallengeConfirmBox())
			{
				result = 219;
			}
			else
			{
				result = (BaseConfigController.Instance.GetIosAuditFirstDownloadTipWithSkip() ? 296 : 4);
			}
			return result;
		}

		// Token: 0x060398B7 RID: 235703 RVA: 0x00DAA3D0 File Offset: 0x00DA85D0
		private bool CheckIfExitByOtherModule()
		{
			int id = InstanceDungeonEntranceModel.Instance.SelectInstanceId;
			if (GameModeController.Instance.IsInInstance())
			{
				id = CreatureModel.Instance.GetInstanceId();
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id);
			return (config != null && config.GetValueOrDefault().InstSubType == 19) || (config != null && config.GetValueOrDefault().InstSubType == 20) || (config != null && config.GetValueOrDefault().InstSubType == 24) || (config != null && config.GetValueOrDefault().InstSubType == 21) || (config != null && config.GetValueOrDefault().InstSubType == 22) || (config != null && config.GetValueOrDefault().InstSubType == 25) || (config != null && config.GetValueOrDefault().InstSubType == 33) || (config != null && config.GetValueOrDefault().InstSubType == 42);
		}

		// Token: 0x060398B8 RID: 235704 RVA: 0x00DAA520 File Offset: 0x00DA8720
		[return: Nullable(0)]
		public UniTask<bool> PrewarTeamFightRequest(int instanceId, [Nullable(1)] List<int> roleIds, int entranceId = 0, int posEntityId = 0, TransitionOptionPb transitionOption = null, List<int> towerDefencePhantomId = null)
		{
			InstanceDungeonController.<PrewarTeamFightRequest>d__15 <PrewarTeamFightRequest>d__;
			<PrewarTeamFightRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrewarTeamFightRequest>d__.<>4__this = this;
			<PrewarTeamFightRequest>d__.instanceId = instanceId;
			<PrewarTeamFightRequest>d__.roleIds = roleIds;
			<PrewarTeamFightRequest>d__.entranceId = entranceId;
			<PrewarTeamFightRequest>d__.posEntityId = posEntityId;
			<PrewarTeamFightRequest>d__.transitionOption = transitionOption;
			<PrewarTeamFightRequest>d__.towerDefencePhantomId = towerDefencePhantomId;
			<PrewarTeamFightRequest>d__.<>1__state = -1;
			<PrewarTeamFightRequest>d__.<>t__builder.Start<InstanceDungeonController.<PrewarTeamFightRequest>d__15>(ref <PrewarTeamFightRequest>d__);
			return <PrewarTeamFightRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060398B9 RID: 235705 RVA: 0x00DAA598 File Offset: 0x00DA8798
		[NullableContext(0)]
		public UniTask<bool> SingleInstReChallengeRequest()
		{
			InstanceDungeonController.<SingleInstReChallengeRequest>d__16 <SingleInstReChallengeRequest>d__;
			<SingleInstReChallengeRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SingleInstReChallengeRequest>d__.<>1__state = -1;
			<SingleInstReChallengeRequest>d__.<>t__builder.Start<InstanceDungeonController.<SingleInstReChallengeRequest>d__16>(ref <SingleInstReChallengeRequest>d__);
			return <SingleInstReChallengeRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060398BA RID: 235706 RVA: 0x00DAA5D3 File Offset: 0x00DA87D3
		private void OnBehaviorTreeWakedUp()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
				if (instanceDungeonInfo == null)
				{
					return;
				}
				instanceDungeonInfo.SetTrack(true, ESetTrackReason.None);
			}
		}

		// Token: 0x060398BB RID: 235707 RVA: 0x00DAA5FC File Offset: 0x00DA87FC
		private void WorldDone()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				InstanceDungeonModel.Instance.ConstructCurrentDungeonAreaName();
				if (!string.IsNullOrEmpty(InstanceDungeonModel.Instance.GetInstanceDungeonName()))
				{
					UiManager.Instance.OpenView(EUiViewName.InstanceDungeonAreaView, null, null);
				}
				InstanceDungeonModel instance = InstanceDungeonModel.Instance;
				ExchangeRewardModel instance2 = ExchangeRewardModel.Instance;
				instance.CurrentInstanceIsFinish = ((instance2 != null) ? new bool?(instance2.IsFinishInstance(InstanceDungeonEntranceModel.Instance.InstanceId)) : null);
				this.ApplyInstanceEnterBuff();
			}
			if (this.TeleportDungeonActionDungeonIdHandle != 0)
			{
				FormationController.Instance.OpenBattleTeamView(this.TeleportDungeonActionDungeonIdHandle, false, false, false, null);
				this.TeleportDungeonActionDungeonIdHandle = 0;
			}
		}

		// Token: 0x060398BC RID: 235708 RVA: 0x00DAA6A4 File Offset: 0x00DA88A4
		private void ApplyInstanceEnterBuff()
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config == null || config.Value.EnterBuff == 0)
			{
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			if (worldEntity == null)
			{
				return;
			}
			BaseBuffComponent component = worldEntity.GetComponent<BaseBuffComponent>();
			if (component == null)
			{
				return;
			}
			CreatureDataComponent component2 = worldEntity.GetComponent<CreatureDataComponent>();
			long instigatorId = (component2 != null) ? component2.GetCreatureDataId() : 0L;
			component.AddBuffLocal((long)config.Value.EnterBuff, new AddBuffParam
			{
				InstigatorId = instigatorId,
				Reason = "InstanceDungeonEnterBuff"
			});
		}

		// Token: 0x060398BD RID: 235709 RVA: 0x00DAA750 File Offset: 0x00DA8950
		private void InstPlayDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			InstPlayDataNotify instPlayDataNotify = (InstPlayDataNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "副本信息通知";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("副本玩法Id:", instPlayDataNotify.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			InstanceDungeonModel.Instance.CreateInstanceInfo(instPlayDataNotify.Id);
		}

		// Token: 0x060398BE RID: 235710 RVA: 0x00DAA7A5 File Offset: 0x00DA89A5
		[NullableContext(1)]
		private void EventInstResultNotify(InstResultNotify data)
		{
			this.InstResultNotify(data, null);
		}

		// Token: 0x060398BF RID: 235711 RVA: 0x00DAA7B0 File Offset: 0x00DA89B0
		private void InstResultNotify(IMessage msg, Net.CallbackStatus status)
		{
			InstResultNotify instResultNotify = (InstResultNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "副本结束通知";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("副本Id:", instResultNotify.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (instResultNotify.Id != CreatureModel.Instance.GetInstanceId())
			{
				return;
			}
			InstanceDungeonModel.Instance.InstanceFinishSuccess = (instResultNotify.Succ ? EInstanceFinishState.Success : EInstanceFinishState.Fail);
			if (InstanceDungeonModel.Instance.InstanceFinishSuccess == EInstanceFinishState.Success && !string.IsNullOrEmpty(OnlineController.Instance.HandleTips))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("OnlineSomeOneLeaveInstance", Array.Empty<object>());
				OnlineController.Instance.HandleTips = "";
			}
			InstanceDungeonModel.Instance.InstanceRewardHaveTake = instResultNotify.IsRecReward;
			EventSystem.Instance.Emit(EEventName.OnDungeonFinish);
		}

		// Token: 0x060398C0 RID: 235712 RVA: 0x00DAA87E File Offset: 0x00DA8A7E
		private void HandleLoadingViewOnAfterShow()
		{
			if (this.IsBlackScreenAdded)
			{
				BlackScreenController.Instance.RemoveBlackScreen("None", "PreWarLeaveScene", "Default");
				this.IsBlackScreenAdded = false;
			}
		}

		// Token: 0x060398C1 RID: 235713 RVA: 0x00DAA8A8 File Offset: 0x00DA8AA8
		private void TeleportDungeonActionNotify(IMessage msg, Net.CallbackStatus status)
		{
			TeleportDungeonActionNotify teleportDungeonActionNotify = (TeleportDungeonActionNotify)msg;
			int dungeonId = teleportDungeonActionNotify.DungeonId;
			this.TeleportDungeonActionHostIdHandle = teleportDungeonActionNotify.HostPlayerId;
			this.TeleportDungeonActionIncIdHandle = teleportDungeonActionNotify.IncId;
			SundryModel instance = SundryModel.Instance;
			if (instance != null && instance.IsBlockTpDungeon())
			{
				ScrollingTipsController.Instance.ShowTipsByText("TeleportDungeon被GM屏蔽，跳过执行");
				this.TeleportDungeonRequest(new List<int>(), false);
				return;
			}
			if (this.IsForbidDungeon(dungeonId))
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
				this.TeleportDungeonRequest(new List<int>(), false);
				return;
			}
			if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
			{
				this.TeleportDungeonRequest(new List<int>(), false);
				return;
			}
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config == null || config.Value.InstType == 0)
			{
				this.TeleportDungeonRequest(new List<int>(), false);
				return;
			}
			this.TeleportDungeonContinueLastInst = teleportDungeonActionNotify.ContinueLastInst;
			if (teleportDungeonActionNotify.IsNeedSecondaryConfirmation)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TeleportDungeonConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					InstanceDungeonEntranceModel.Instance.InstanceId = dungeonId;
					this.TeleportDungeonRequest(InstanceDungeonModel.Instance.LastEnterRoleList ?? new List<int>(), true);
				};
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					this.TeleportDungeonRequest(new List<int>(), false);
					ConfirmBoxController.Instance.CloseConfirmBoxView();
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (!teleportDungeonActionNotify.IsRegroup)
			{
				TransitionOptionPb transitionOption = teleportDungeonActionNotify.TransitionOption;
				if (transitionOption != null && transitionOption.TransitionType == TransitionType.Seamless)
				{
					TransitionInSeamlessPb transitionInSeamless = teleportDungeonActionNotify.TransitionOption.TransitionInSeamless;
					if (transitionInSeamless != null && transitionInSeamless.KeepStates.Contains(KeepMovementState.Kite))
					{
						SeamlessTravelContext seamlessTravelContext = new SeamlessTravelContext();
						seamlessTravelContext.ParseParamsByProto(teleportDungeonActionNotify.TransitionOption.TransitionInSeamless);
						SeamlessTravelController.Instance.EnableSeamlessTravel(seamlessTravelContext, true).ContinueWith(delegate(bool result)
						{
							this.TeleportDungeonRequest(new List<int>(), true);
						});
						return;
					}
				}
				this.TeleportDungeonRequest(InstanceDungeonModel.Instance.LastEnterRoleList ?? new List<int>(), true);
				return;
			}
			BattleTeamModel.Instance.IsFormTeleportAction = true;
			LoadingModel instance2 = LoadingModel.Instance;
			if (instance2 == null || !instance2.IsLoading)
			{
				FormationController.Instance.OpenBattleTeamView(dungeonId, false, false, false, null);
				return;
			}
			this.TeleportDungeonActionDungeonIdHandle = dungeonId;
		}

		// Token: 0x060398C2 RID: 235714 RVA: 0x00DAAAE0 File Offset: 0x00DA8CE0
		[NullableContext(1)]
		public void TeleportDungeonRequest(List<int> roleIds, bool isConfirm = true)
		{
			TeleportDungeonActionRequest teleportDungeonActionRequest = new TeleportDungeonActionRequest();
			teleportDungeonActionRequest.IncId = this.TeleportDungeonActionIncIdHandle;
			teleportDungeonActionRequest.HostPlayerId = this.TeleportDungeonActionHostIdHandle;
			teleportDungeonActionRequest.RoleIds.Add(roleIds);
			teleportDungeonActionRequest.IsConfirm = isConfirm;
			teleportDungeonActionRequest.ContinueLastInst = this.TeleportDungeonContinueLastInst;
			Net.Instance.Call(ERequestMessageId.TeleportDungeonActionRequest, teleportDungeonActionRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TeleportDungeonActionResponse teleportDungeonActionResponse = (TeleportDungeonActionResponse)msg;
				if (teleportDungeonActionResponse.Code != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(teleportDungeonActionResponse.Code, EResponseMessageId.EnterInstResponse, null, true, true);
				}
			}, 0);
			InstanceDungeonModel.Instance.LastEnterRoleList = roleIds;
			this.TeleportDungeonContinueLastInst = false;
			this.TeleportDungeonActionHostIdHandle = 0;
			this.TeleportDungeonActionIncIdHandle = 0;
		}

		// Token: 0x060398C3 RID: 235715 RVA: 0x00DAAB7A File Offset: 0x00DA8D7A
		public bool IsForbidDungeon(int instanceId)
		{
			if (!this.IsEnableTeleport)
			{
				if (this.PermitList == null)
				{
					return true;
				}
				if (!this.PermitList.Contains(instanceId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060398C4 RID: 235716 RVA: 0x00DAAB9F File Offset: 0x00DA8D9F
		public void UpdateForbidDungeon(bool isEnableTeleport, IList<int> permitList)
		{
			this.IsEnableTeleport = isEnableTeleport;
			this.PermitList = permitList;
		}

		// Token: 0x060398C5 RID: 235717 RVA: 0x00DAABB0 File Offset: 0x00DA8DB0
		private void TeleportDungeonForbidNotify(IMessage msg, Net.CallbackStatus callbackStatus = null)
		{
			int dungeonId = ((TeleportDungeonForbidNotify)msg).DungeonId;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(dungeonId);
			string promptId = (config != null && config.Value.InstType == 1) ? "TrialRoleTransmitLimit" : "TrialRoleDungeonsLimit";
			GenericPromptController.Instance.ShowPromptByCode(promptId, Array.Empty<object>());
		}

		// Token: 0x060398C6 RID: 235718 RVA: 0x00DAAC14 File Offset: 0x00DA8E14
		private void InstSaveDataNotify(IMessage msg, Net.CallbackStatus callbackStatus = null)
		{
			InstSaveDataNotify instSaveDataNotify = (InstSaveDataNotify)msg;
			InstanceDungeonModel instance = InstanceDungeonModel.Instance;
			if (instance != null)
			{
				instance.ClearInstanceIdsWithSaveData();
			}
			foreach (long num in instSaveDataNotify.Ids)
			{
				int num2 = (int)num;
				InstanceDungeonModel instance2 = InstanceDungeonModel.Instance;
				if (instance2 != null)
				{
					instance2.AddInstanceIdsWithSaveData(new int[]
					{
						num2
					});
				}
			}
		}

		// Token: 0x060398C7 RID: 235719 RVA: 0x00DAAC8C File Offset: 0x00DA8E8C
		[NullableContext(1)]
		public void UpdateTrialRoleDungeonWhiteList(int[] canEnterDungeonList)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "更新试用角色副本白名单";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DungeonList", canEnterDungeonList);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			List<int> trialRoleDungeonWhiteList = InstanceDungeonModel.Instance.TrialRoleDungeonWhiteList;
			trialRoleDungeonWhiteList.Clear();
			trialRoleDungeonWhiteList.AddRange(canEnterDungeonList);
		}

		// Token: 0x060398C8 RID: 235720 RVA: 0x00DAACD8 File Offset: 0x00DA8ED8
		public bool SkipTrailRoleCheckEnterDungeon()
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (instanceId <= 0)
			{
				return false;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return InstanceDungeonDefine.TrialRoleSkipCheckInstanceType.Contains((EDungeonSubType)config.Value.InstSubType);
		}

		// Token: 0x060398C9 RID: 235721 RVA: 0x00DAAD20 File Offset: 0x00DA8F20
		public bool CanTrialRoleEnterDungeon(int entranceId, int dungeonId)
		{
			if (entranceId <= 0 || dungeonId <= 0)
			{
				return false;
			}
			if (!InstanceDungeonModel.Instance.TrialRoleDungeonWhiteList.Contains(dungeonId))
			{
				return false;
			}
			bool flag = true;
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (instanceId > 0)
			{
				InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
				if (config != null && config.GetValueOrDefault().InstSubType == 12 && (config != null && config.GetValueOrDefault().WorldDungeonSubType > 0))
				{
					flag = false;
				}
			}
			InstanceDungeonEntrance? config2 = InstanceDungeonEntranceConfig.Instance.GetConfig(entranceId);
			return !flag || (config2 != null && config2.Value.FlowId == 2);
		}

		// Token: 0x060398CA RID: 235722 RVA: 0x00DAADDB File Offset: 0x00DA8FDB
		private bool OverrideErrorCodeStateGetter(Aki.Protocol.ErrorCode errorCode)
		{
			return errorCode != Aki.Protocol.ErrorCode.TeamParkMemberErr;
		}

		// Token: 0x060398CB RID: 235723 RVA: 0x00DAADE8 File Offset: 0x00DA8FE8
		public void CheckAndShowDungeonArchiveExpireTips(int dungeonId)
		{
			if (!InstanceDungeonEntranceModel.Instance.IsDungeonArchiveActivate(dungeonId))
			{
				return;
			}
			if (dungeonId <= 0)
			{
				return;
			}
			if (InstanceDungeonEntranceModel.Instance.IsDungeonArchiveExpire(dungeonId) && !InstanceDungeonEntranceModel.Instance.IsDungeonArchiveExpireTipsShow(dungeonId))
			{
				string dungeonArchiveExpireLocalTips = InstanceDungeonEntranceModel.Instance.GetDungeonArchiveExpireLocalTips(dungeonId);
				if (!string.IsNullOrEmpty(dungeonArchiveExpireLocalTips))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId(dungeonArchiveExpireLocalTips, Array.Empty<object>());
				}
				InstanceDungeonEntranceModel.Instance.SetDungeonArchiveExpireTipsShow(dungeonId);
			}
		}

		// Token: 0x17008A5D RID: 35421
		// (get) Token: 0x060398CC RID: 235724 RVA: 0x00DAAE51 File Offset: 0x00DA9051
		[Nullable(1)]
		public static InstanceDungeonController Instance
		{
			[NullableContext(1)]
			get
			{
				return InstanceDungeonController._Instance;
			}
		}

		// Token: 0x060398CD RID: 235725 RVA: 0x00DAAE58 File Offset: 0x00DA9058
		[NullableContext(1)]
		public static InstanceDungeonController GetOrCreateInstance()
		{
			if (InstanceDungeonController._Instance == null)
			{
				InstanceDungeonController.CreateInstance();
			}
			return InstanceDungeonController._Instance;
		}

		// Token: 0x060398CE RID: 235726 RVA: 0x00DAAE6C File Offset: 0x00DA906C
		public static bool CreateInstance()
		{
			if (InstanceDungeonController._Instance != null)
			{
				return true;
			}
			InstanceDungeonController._Instance = new InstanceDungeonController();
			return true;
		}

		// Token: 0x060398CF RID: 235727 RVA: 0x00DAAE82 File Offset: 0x00DA9082
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060398D0 RID: 235728 RVA: 0x00DAAE84 File Offset: 0x00DA9084
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonController._Instance = null;
		}

		// Token: 0x060398D1 RID: 235729 RVA: 0x00DAAE8C File Offset: 0x00DA908C
		static InstanceDungeonController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonController.CreateStaticDefaultValue), new Action(InstanceDungeonController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E178 RID: 123256
		private bool IsEnableTeleport = true;

		// Token: 0x0401E179 RID: 123257
		private bool IsBlackScreenAdded;

		// Token: 0x0401E17A RID: 123258
		private IList<int> PermitList = new List<int>();

		// Token: 0x0401E17B RID: 123259
		public int TeleportDungeonActionHostIdHandle;

		// Token: 0x0401E17C RID: 123260
		public int TeleportDungeonActionIncIdHandle;

		// Token: 0x0401E17D RID: 123261
		public int TeleportDungeonActionDungeonIdHandle;

		// Token: 0x0401E17E RID: 123262
		public bool TeleportDungeonContinueLastInst;

		// Token: 0x0401E17F RID: 123263
		private static InstanceDungeonController _Instance;
	}
}
