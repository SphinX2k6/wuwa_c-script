using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F46 RID: 24390
	public class LevelAiTaskTurnAndPlayMontage : LevelAiTask
	{
		// Token: 0x0603AA4D RID: 240205 RVA: 0x0109298F File Offset: 0x01090B8F
		protected override ELevelAiNodeResult ExecuteTask()
		{
			this.Phase = LevelAiTaskTurnAndPlayMontage.ETaskPhase.ExecuteTurnTo;
			this.NotifyTick = true;
			return ELevelAiNodeResult.InProgress;
		}

		// Token: 0x0603AA4E RID: 240206 RVA: 0x010929A0 File Offset: 0x01090BA0
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

		// Token: 0x0603AA4F RID: 240207 RVA: 0x01092A5F File Offset: 0x01090C5F
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

		// Token: 0x0603AA50 RID: 240208 RVA: 0x01092A9D File Offset: 0x01090C9D
		protected override void OnTaskFinished(ELevelAiNodeResult result)
		{
			this.Character = null;
			this.MovementMode = EMovementMode.MOVE_None;
		}

		// Token: 0x0603AA51 RID: 240209 RVA: 0x01092AB0 File Offset: 0x01090CB0
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

		// Token: 0x0603AA52 RID: 240210 RVA: 0x01092BC0 File Offset: 0x01090DC0
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

		// Token: 0x0401ED11 RID: 126225
		private const float TURN_SPEED = 200f;

		// Token: 0x0401ED12 RID: 126226
		private const float TOLERANCE = 10f;

		// Token: 0x0401ED13 RID: 126227
		[Nullable(2)]
		private CharacterActorComponent Character;

		// Token: 0x0401ED14 RID: 126228
		private EMovementMode MovementMode;

		// Token: 0x0401ED15 RID: 126229
		private int PlayingMontageId;

		// Token: 0x0401ED16 RID: 126230
		private float LoopDuration;

		// Token: 0x0401ED17 RID: 126231
		private int RepeatTimes;

		// Token: 0x0401ED18 RID: 126232
		private LevelAiTaskTurnAndPlayMontage.ETaskPhase Phase;

		// Token: 0x0200B89B RID: 47259
		private enum ETaskPhase
		{
			// Token: 0x04038FC6 RID: 233414
			None,
			// Token: 0x04038FC7 RID: 233415
			ExecuteTurnTo,
			// Token: 0x04038FC8 RID: 233416
			TickTurnTo,
			// Token: 0x04038FC9 RID: 233417
			ExecutePlayMontage,
			// Token: 0x04038FCA RID: 233418
			Finish
		}
	}
}
