using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D1A RID: 23834
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventTeleportDungeon : LevelEventBase
	{
		// Token: 0x0603A447 RID: 238663 RVA: 0x01077D67 File Offset: 0x01075F67
		public LevelEventTeleportDungeon(int id) : base(id)
		{
		}

		// Token: 0x0603A448 RID: 238664 RVA: 0x01077D70 File Offset: 0x01075F70
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			global::Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.WLJ, "[LevelEventTeleportDungeon]ExecuteInGm", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A449 RID: 238665 RVA: 0x01077DA4 File Offset: 0x01075FA4
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SundryModel instance = SundryModel.Instance;
			if (instance != null && instance.IsBlockTpDungeon())
			{
				ScrollingTipsController.Instance.ShowTipsByText("TeleportDungeon被GM屏蔽，跳过执行");
				base.FinishExecute(true, false, true);
				return;
			}
			LoadingModel instance2 = LoadingModel.Instance;
			if (instance2 != null && instance2.IsLoading)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			TeleportDungeon @params = inParams as TeleportDungeon;
			if (@params == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			int dungeonId = @params.DungeonId;
			if (InstanceDungeonController.Instance.IsForbidDungeon(dungeonId))
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
				base.FinishExecute(false, false, true);
				return;
			}
			if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
			{
				base.FinishExecute(true, false, true);
				return;
			}
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			int instType = config.Value.InstType;
			if (@params.IsNeedSecondaryConfirmation.GetValueOrDefault())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TeleportDungeonConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					InstanceDungeonEntranceModel.Instance.InstanceId = @params.DungeonId;
					this.SetBanMapSound(@params);
				};
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					InstanceDungeonEntranceModel.Instance.IsBanMapSound = false;
					ConfirmBoxController.Instance.CloseConfirmBoxView();
					this.RequestFinish();
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			ITeleportTransitionType transitionOption = @params.TransitionOption;
			if (transitionOption != null && transitionOption.Type == ETeleportTransitionType.Seamless)
			{
				List<EKeepMovementState> keepMovementStates = (@params.TransitionOption as ITeleportTransitionInSeamlessType).KeepMovementStates;
				if (keepMovementStates != null && keepMovementStates.Contains(EKeepMovementState.Kite))
				{
					SeamlessTravelContext seamlessTravelContext = new SeamlessTravelContext();
					seamlessTravelContext.ParseParamsByProto(TeleportTransitionHelper.ParseTeleportTransitionOptionToPb(@params.TransitionOption).TransitionInSeamless);
					SeamlessTravelController.Instance.EnableSeamlessTravel(seamlessTravelContext, true).ContinueWith(delegate(bool task)
					{
						this.TeleportDungeon(@params);
					});
					return;
				}
			}
			this.TeleportDungeon(@params);
		}

		// Token: 0x0603A44A RID: 238666 RVA: 0x01077FA0 File Offset: 0x010761A0
		private void TeleportDungeon(TeleportDungeon @params)
		{
			int dungeonId = @params.DungeonId;
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			this.PrepareTeleport(@params);
			bool flag = InstanceDungeonConfig.Instance.GetConfig(dungeonId).Value.InstType == 1;
			if (config.Value.InstType == 1)
			{
				if (flag)
				{
					this.RequestFinish();
					return;
				}
				this.EnterDungeon(@params.IsRegroup, dungeonId, @params.LocationEntityId);
				return;
			}
			else
			{
				if (flag)
				{
					this.RequestFinish();
					return;
				}
				this.EnterDungeon(@params.IsRegroup, dungeonId, @params.LocationEntityId);
				return;
			}
		}

		// Token: 0x0603A44B RID: 238667 RVA: 0x01078044 File Offset: 0x01076244
		private void SetBanMapSound(TeleportDungeon @params)
		{
			InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
			bool isBanMapSound;
			if (@params.IsBanMapSound.GetValueOrDefault())
			{
				ITeleportTransitionType transitionOption = @params.TransitionOption;
				isBanMapSound = (transitionOption != null && transitionOption.Type == ETeleportTransitionType.FadeInScreen);
			}
			else
			{
				isBanMapSound = false;
			}
			instance.IsBanMapSound = isBanMapSound;
		}

		// Token: 0x0603A44C RID: 238668 RVA: 0x01078083 File Offset: 0x01076283
		private void PrepareTeleport(TeleportDungeon @params)
		{
			InstanceDungeonEntranceModel.Instance.TransitionOption = this.ParseTransitionOptionParamToPb(@params);
			this.SetBanMapSound(@params);
			InstanceDungeonEntranceModel.Instance.InstanceId = @params.DungeonId;
		}

		// Token: 0x0603A44D RID: 238669 RVA: 0x010780B0 File Offset: 0x010762B0
		private void EnterDungeon(bool isRegroup, int dungeonId, int? posEntityId = null)
		{
			if (isRegroup)
			{
				EventSystem.Instance.Add(EEventName.EnterInstanceDungeon, new Action(this.RequestFinish));
				FormationController.Instance.OpenBattleTeamView(dungeonId, false, false, false, null);
				return;
			}
			this.RequestFinish();
		}

		// Token: 0x0603A44E RID: 238670 RVA: 0x010780FA File Offset: 0x010762FA
		private void RequestFinish()
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A44F RID: 238671 RVA: 0x01078105 File Offset: 0x01076305
		protected override void OnReset()
		{
			if (EventSystem.Instance.Has(EEventName.EnterInstanceDungeon, new Action(this.RequestFinish)))
			{
				EventSystem.Instance.Remove(EEventName.EnterInstanceDungeon, new Action(this.RequestFinish));
			}
		}

		// Token: 0x0603A450 RID: 238672 RVA: 0x01078140 File Offset: 0x01076340
		[NullableContext(2)]
		private TransitionOptionPb ParseTransitionOptionParamToPb(TeleportDungeon @params)
		{
			ITeleportTransitionType transitionOption = @params.TransitionOption;
			TransitionOptionPb result = TeleportTransitionHelper.ParseTeleportTransitionOptionToPb(transitionOption);
			if (transitionOption != null && transitionOption.Type == ETeleportTransitionType.PlayMp4 && (transitionOption as ITeleportTransitionWithMp4).IsFadeInScreenAfterTeleport.GetValueOrDefault())
			{
				LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.Common, ELoadingPerform.CameraFade, "FadeInScreenAfterTeleport", null, new object[]
				{
					1f
				});
			}
			return result;
		}
	}
}
