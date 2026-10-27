using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DC8 RID: 28104
	public class LevelAiTaskTurnTo : LevelAiTask
	{
		// Token: 0x060448F1 RID: 280817 RVA: 0x010E8A50 File Offset: 0x010E6C50
		protected override ELevelAiNodeResult ExecuteTask()
		{
			EntityLookAt entityLookAt = this.Params as EntityLookAt;
			if (entityLookAt == null)
			{
				return ELevelAiNodeResult.Failed;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityLookAt.EntityId);
			if (entityByPbDataId == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelAi;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "执行转向动作时实体不存在:";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", entityLookAt.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return ELevelAiNodeResult.Failed;
			}
			this.Character = entityByPbDataId.Entity.GetComponent<CharacterActorComponent>();
			BaseMoveComponent component = entityByPbDataId.Entity.GetComponent<BaseMoveComponent>();
			UCharacterMovementComponent ucharacterMovementComponent = (component != null) ? component.CharacterMovement : null;
			if (ucharacterMovementComponent == null || !ucharacterMovementComponent.IsValid())
			{
				return ELevelAiNodeResult.Failed;
			}
			this.MovementMode = ucharacterMovementComponent.MovementMode;
			ucharacterMovementComponent.MovementMode = EMovementMode.MOVE_Walking;
			Vector targetLocation = Vector.Create((double)entityLookAt.Pos.X.GetValueOrDefault(), (double)entityLookAt.Pos.Y.GetValueOrDefault(), (double)entityLookAt.Pos.Z.GetValueOrDefault());
			AiControllerLibrary.TurnToTarget(this.Character, targetLocation, 200f, false, 0f);
			this.NotifyTick = true;
			return ELevelAiNodeResult.InProgress;
		}

		// Token: 0x060448F2 RID: 280818 RVA: 0x010E8B74 File Offset: 0x010E6D74
		protected override void TickTask(float deltaTime)
		{
			if (this.Character.InputRotatorProxy.Equals(this.Character.ActorRotationProxy, 10f))
			{
				this.Character.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.MovementMode;
				base.FinishLatentTask(ELevelAiNodeResult.Succeeded);
			}
		}

		// Token: 0x060448F3 RID: 280819 RVA: 0x010E8BCF File Offset: 0x010E6DCF
		protected override ELevelAiNodeResult AbortTask()
		{
			CharacterActorComponent character = this.Character;
			if (character != null)
			{
				character.ClearInput(false, true);
			}
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x060448F4 RID: 280820 RVA: 0x010E8BE5 File Offset: 0x010E6DE5
		protected override void OnTaskFinished(ELevelAiNodeResult result)
		{
			this.Character = null;
			this.MovementMode = EMovementMode.MOVE_None;
		}

		// Token: 0x04023A77 RID: 146039
		private const float TURN_SPEED = 200f;

		// Token: 0x04023A78 RID: 146040
		private const float TOLERANCE = 10f;

		// Token: 0x04023A79 RID: 146041
		[Nullable(2)]
		private CharacterActorComponent Character;

		// Token: 0x04023A7A RID: 146042
		private EMovementMode MovementMode;
	}
}
