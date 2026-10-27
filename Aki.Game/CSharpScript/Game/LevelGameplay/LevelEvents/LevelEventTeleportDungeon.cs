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
	// Token: 0x02006BA2 RID: 27554
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventTeleportDungeon : LevelEventBase
	{
		// Token: 0x060442F3 RID: 279283 RVA: 0x010CDF2F File Offset: 0x010CC12F
		public LevelEventTeleportDungeon(int id) : base(id)
		{
		}

		// Token: 0x060442F4 RID: 279284 RVA: 0x010CDF38 File Offset: 0x010CC138
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			global::Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.WLJ, "[LevelEventTeleportDungeon]ExecuteInGm", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060442F5 RID: 279285 RVA: 0x010CDF6C File Offset: 0x010CC16C
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
					int dungeonId2 = @params.DungeonId;
					InstanceDungeonEntranceModel.Instance.InstanceId = dungeonId2;
				};
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
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

		// Token: 0x060442F6 RID: 279286 RVA: 0x010CE168 File Offset: 0x010CC368
		private void TeleportDungeon(TeleportDungeon @params)
		{
			int dungeonId = @params.DungeonId;
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			TransitionOptionPb transitionOption = this.ParseTransitionOptionParamToPb(@params);
			InstanceDungeonEntranceModel.Instance.TransitionOption = transitionOption;
			InstanceDungeonEntranceModel.Instance.InstanceId = dungeonId;
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

		// Token: 0x060442F7 RID: 279287 RVA: 0x010CE224 File Offset: 0x010CC424
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

		// Token: 0x060442F8 RID: 279288 RVA: 0x010CE26E File Offset: 0x010CC46E
		private void RequestFinish()
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060442F9 RID: 279289 RVA: 0x010CE279 File Offset: 0x010CC479
		protected override void OnReset()
		{
			if (EventSystem.Instance.Has(EEventName.EnterInstanceDungeon, new Action(this.RequestFinish)))
			{
				EventSystem.Instance.Remove(EEventName.EnterInstanceDungeon, new Action(this.RequestFinish));
			}
		}

		// Token: 0x060442FA RID: 279290 RVA: 0x010CE2B4 File Offset: 0x010CC4B4
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
