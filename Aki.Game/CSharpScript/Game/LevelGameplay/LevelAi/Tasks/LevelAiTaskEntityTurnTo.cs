using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F3A RID: 24378
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiTaskEntityTurnTo : LevelAiTask
	{
		// Token: 0x0603AA13 RID: 240147 RVA: 0x010913AC File Offset: 0x0108F5AC
		protected override ELevelAiNodeResult ExecuteTask()
		{
			EntityTurnTo entityTurnTo = this.Params as EntityTurnTo;
			if (entityTurnTo == null)
			{
				return ELevelAiNodeResult.Failed;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityTurnTo.EntityId);
			if (entityByPbDataId == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelAi;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "执行转向动作时实体不存在:";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", entityTurnTo.EntityId);
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
			if (!this.GetTurnToPosition(this.TargetPos, entityTurnTo))
			{
				return ELevelAiNodeResult.Failed;
			}
			this.MovementMode = ucharacterMovementComponent.MovementMode;
			ucharacterMovementComponent.MovementMode = EMovementMode.MOVE_Walking;
			AiControllerLibrary.TurnToTarget(this.Character, this.TargetPos, 200f, false, 0f);
			this.NotifyTick = true;
			return ELevelAiNodeResult.InProgress;
		}

		// Token: 0x0603AA14 RID: 240148 RVA: 0x010914A0 File Offset: 0x0108F6A0
		protected override void TickTask(float deltaTime)
		{
			if (this.Character.InputRotatorProxy.Equals(this.Character.ActorRotationProxy, 10f))
			{
				this.Character.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.MovementMode;
				base.FinishLatentTask(ELevelAiNodeResult.Succeeded);
			}
		}

		// Token: 0x0603AA15 RID: 240149 RVA: 0x010914FB File Offset: 0x0108F6FB
		protected override ELevelAiNodeResult AbortTask()
		{
			CharacterActorComponent character = this.Character;
			if (character != null)
			{
				character.ClearInput(false, true);
			}
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x0603AA16 RID: 240150 RVA: 0x01091511 File Offset: 0x0108F711
		protected override void OnTaskFinished(ELevelAiNodeResult result)
		{
			this.Character = null;
			this.MovementMode = EMovementMode.MOVE_None;
		}

		// Token: 0x0603AA17 RID: 240151 RVA: 0x01091524 File Offset: 0x0108F724
		private bool GetTurnToPosition(Vector outPosition, EntityTurnTo @params)
		{
			switch (@params.Target.Type)
			{
			case EActorTurnToMode.Entity:
			{
				CreatureModel instance = CreatureModel.Instance;
				EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(@params.EntityId) : null;
				if (entityHandle == null || !entityHandle.Valid)
				{
					return false;
				}
				BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
				outPosition.DeepCopy(component.ActorLocationProxy);
				break;
			}
			case EActorTurnToMode.Position:
			{
				IActorTurnToPositionData actorTurnToPositionData = @params.Target as IActorTurnToPositionData;
				outPosition.Set((double)actorTurnToPositionData.Pos.X.GetValueOrDefault(), (double)actorTurnToPositionData.Pos.Y.GetValueOrDefault(), (double)actorTurnToPositionData.Pos.Z.GetValueOrDefault());
				break;
			}
			case EActorTurnToMode.Player:
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				if (baseCharacter == null || !baseCharacter.IsValid())
				{
					return false;
				}
				outPosition.DeepCopy(baseCharacter.CharacterActorComponent.ActorLocationProxy);
				break;
			}
			default:
				return false;
			}
			return true;
		}

		// Token: 0x0401ECED RID: 126189
		private const float TURN_SPEED = 200f;

		// Token: 0x0401ECEE RID: 126190
		private const float TOLERANCE = 10f;

		// Token: 0x0401ECEF RID: 126191
		[Nullable(2)]
		private CharacterActorComponent Character;

		// Token: 0x0401ECF0 RID: 126192
		private EMovementMode MovementMode;

		// Token: 0x0401ECF1 RID: 126193
		private readonly Vector TargetPos = Vector.Create();
	}
}
