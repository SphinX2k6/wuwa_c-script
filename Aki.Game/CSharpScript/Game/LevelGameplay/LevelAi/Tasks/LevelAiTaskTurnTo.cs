using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F47 RID: 24391
	public class LevelAiTaskTurnTo : LevelAiTask
	{
		// Token: 0x0603AA55 RID: 240213 RVA: 0x01092CA0 File Offset: 0x01090EA0
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

		// Token: 0x0603AA56 RID: 240214 RVA: 0x01092DC4 File Offset: 0x01090FC4
		protected override void TickTask(float deltaTime)
		{
			if (this.Character.InputRotatorProxy.Equals(this.Character.ActorRotationProxy, 10f))
			{
				this.Character.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.MovementMode;
				base.FinishLatentTask(ELevelAiNodeResult.Succeeded);
			}
		}

		// Token: 0x0603AA57 RID: 240215 RVA: 0x01092E1F File Offset: 0x0109101F
		protected override ELevelAiNodeResult AbortTask()
		{
			CharacterActorComponent character = this.Character;
			if (character != null)
			{
				character.ClearInput(false, true);
			}
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x0603AA58 RID: 240216 RVA: 0x01092E35 File Offset: 0x01091035
		protected override void OnTaskFinished(ELevelAiNodeResult result)
		{
			this.Character = null;
			this.MovementMode = EMovementMode.MOVE_None;
		}

		// Token: 0x0401ED19 RID: 126233
		private const float TURN_SPEED = 200f;

		// Token: 0x0401ED1A RID: 126234
		private const float TOLERANCE = 10f;

		// Token: 0x0401ED1B RID: 126235
		[Nullable(2)]
		private CharacterActorComponent Character;

		// Token: 0x0401ED1C RID: 126236
		private EMovementMode MovementMode;
	}
}
