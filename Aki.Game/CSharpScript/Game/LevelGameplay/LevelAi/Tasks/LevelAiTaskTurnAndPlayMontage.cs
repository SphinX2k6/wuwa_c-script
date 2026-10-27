using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DC7 RID: 28103
	public class LevelAiTaskTurnAndPlayMontage : LevelAiTask
	{
		// Token: 0x060448E9 RID: 280809 RVA: 0x010E873F File Offset: 0x010E693F
		protected override ELevelAiNodeResult ExecuteTask()
		{
			this.Phase = LevelAiTaskTurnAndPlayMontage.ETaskPhase.ExecuteTurnTo;
			this.NotifyTick = true;
			return ELevelAiNodeResult.InProgress;
		}

		// Token: 0x060448EA RID: 280810 RVA: 0x010E8750 File Offset: 0x010E6950
		protected override void TickTask(float deltaTime)
		{
			switch (this.Phase)
			{
			case LevelAiTaskTurnAndPlayMontage.ETaskPhase.ExecuteTurnTo:
				this.ExecuteTurnTo();
				this.Phase = LevelAiTaskTurnAndPlayMontage.ETaskPhase.TickTurnTo;
				return;
			case LevelAiTaskTurnAndPlayMontage.ETaskPhase.TickTurnTo:
				if (GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.Character) < 10f)
				{
					this.Character.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.MovementMode;
					this.Phase = LevelAiTaskTurnAndPlayMontage.ETaskPhase.ExecutePlayMontage;
					return;
				}
				break;
			case LevelAiTaskTurnAndPlayMontage.ETaskPhase.ExecutePlayMontage:
				this.ExecutePlayMontage();
				this.Phase = LevelAiTaskTurnAndPlayMontage.ETaskPhase.Finish;
				return;
			case LevelAiTaskTurnAndPlayMontage.ETaskPhase.Finish:
				break;
			default:
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelAi;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[TurnToAndPlayMontage] 阶段切换出错";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurPhase", this.Phase);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				break;
			}
			}
		}

		// Token: 0x060448EB RID: 280811 RVA: 0x010E880F File Offset: 0x010E6A0F
		protected override ELevelAiNodeResult AbortTask()
		{
			if (this.Phase < LevelAiTaskTurnAndPlayMontage.ETaskPhase.ExecutePlayMontage)
			{
				CharacterActorComponent character = this.Character;
				if (character != null)
				{
					character.ClearInput(false, true);
				}
			}
			else
			{
				base.CreatureDataComponent.Entity.GetComponent<BasePerformComponent>().VolatileMontageStopByLoad(EPerformMode.Ecology, this.PlayingMontageId, EStopMethod.BlendOut);
			}
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x060448EC RID: 280812 RVA: 0x010E884D File Offset: 0x010E6A4D
		protected override void OnTaskFinished(ELevelAiNodeResult result)
		{
			this.Character = null;
			this.MovementMode = EMovementMode.MOVE_None;
		}

		// Token: 0x060448ED RID: 280813 RVA: 0x010E8860 File Offset: 0x010E6A60
		private void ExecuteTurnTo()
		{
			TurnAndPlayMontageParam turnAndPlayMontageParam = this.Params as TurnAndPlayMontageParam;
			if (turnAndPlayMontageParam == null)
			{
				base.FinishLatentTask(ELevelAiNodeResult.Failed);
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(turnAndPlayMontageParam.EntityId);
			if (entityByPbDataId == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelAi;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "执行转向动作时实体不存在:";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", turnAndPlayMontageParam.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishLatentTask(ELevelAiNodeResult.Failed);
				return;
			}
			this.Character = entityByPbDataId.Entity.GetComponent<CharacterActorComponent>();
			BaseMoveComponent component = entityByPbDataId.Entity.GetComponent<BaseMoveComponent>();
			UCharacterMovementComponent ucharacterMovementComponent = (component != null) ? component.CharacterMovement : null;
			if (ucharacterMovementComponent == null || !ucharacterMovementComponent.IsValid())
			{
				base.FinishLatentTask(ELevelAiNodeResult.Failed);
				return;
			}
			this.MovementMode = ucharacterMovementComponent.MovementMode;
			ucharacterMovementComponent.MovementMode = EMovementMode.MOVE_Walking;
			Vector targetLocation = Vector.Create(turnAndPlayMontageParam.Pos.X, turnAndPlayMontageParam.Pos.Y, turnAndPlayMontageParam.Pos.Z);
			AiControllerLibrary.TurnToTarget(this.Character, targetLocation, 200f, false, 0f);
		}

		// Token: 0x060448EE RID: 280814 RVA: 0x010E8970 File Offset: 0x010E6B70
		private void ExecutePlayMontage()
		{
			TurnAndPlayMontageParam turnAndPlayMontageParam = this.Params as TurnAndPlayMontageParam;
			if (turnAndPlayMontageParam == null)
			{
				base.FinishLatentTask(ELevelAiNodeResult.Failed);
				return;
			}
			this.LoopDuration = turnAndPlayMontageParam.LoopDuration;
			this.RepeatTimes = turnAndPlayMontageParam.RepeatTimes;
			BasePerformComponent component = base.CreatureDataComponent.Entity.GetComponent<BasePerformComponent>();
			IMontageId montage2 = new IMontageId
			{
				IsAbp = turnAndPlayMontageParam.IsAbpMontage,
				MontageId = turnAndPlayMontageParam.MontageId
			};
			IAnimStateParam montageStateParam = component.GetMontageStateParam(montage2);
			string montagePath = component.GetMontagePath(montage2);
			if (montagePath == null)
			{
				base.FinishLatentTask(ELevelAiNodeResult.Succeeded);
				return;
			}
			this.PlayingMontageId = component.VolatileMontagePlayByLoad(EPerformMode.Ecology, montagePath, montageStateParam, null, delegate(UAnimMontage montage, bool _)
			{
				base.FinishLatentTask(ELevelAiNodeResult.Succeeded);
			}, new float?(this.LoopDuration), new float?((float)this.RepeatTimes), new bool?(false), new bool?(false), new bool?(false));
		}

		// Token: 0x04023A6F RID: 146031
		private const float TURN_SPEED = 200f;

		// Token: 0x04023A70 RID: 146032
		private const float TOLERANCE = 10f;

		// Token: 0x04023A71 RID: 146033
		[Nullable(2)]
		private CharacterActorComponent Character;

		// Token: 0x04023A72 RID: 146034
		private EMovementMode MovementMode;

		// Token: 0x04023A73 RID: 146035
		private int PlayingMontageId;

		// Token: 0x04023A74 RID: 146036
		private float LoopDuration;

		// Token: 0x04023A75 RID: 146037
		private int RepeatTimes;

		// Token: 0x04023A76 RID: 146038
		private LevelAiTaskTurnAndPlayMontage.ETaskPhase Phase;

		// Token: 0x0200CCAB RID: 52395
		private enum ETaskPhase
		{
			// Token: 0x0403DBA4 RID: 252836
			None,
			// Token: 0x0403DBA5 RID: 252837
			ExecuteTurnTo,
			// Token: 0x0403DBA6 RID: 252838
			TickTurnTo,
			// Token: 0x0403DBA7 RID: 252839
			ExecutePlayMontage,
			// Token: 0x0403DBA8 RID: 252840
			Finish
		}
	}
}
