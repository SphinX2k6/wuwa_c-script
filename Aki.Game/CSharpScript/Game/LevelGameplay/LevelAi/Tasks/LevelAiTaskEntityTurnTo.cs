using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DBB RID: 28091
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiTaskEntityTurnTo : LevelAiTask
	{
		// Token: 0x060448AF RID: 280751 RVA: 0x010E7184 File Offset: 0x010E5384
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

		// Token: 0x060448B0 RID: 280752 RVA: 0x010E7278 File Offset: 0x010E5478
		protected override void TickTask(float deltaTime)
		{
			if (this.Character.InputRotatorProxy.Equals(this.Character.ActorRotationProxy, 10f))
			{
				this.Character.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.MovementMode;
				base.FinishLatentTask(ELevelAiNodeResult.Succeeded);
			}
		}

		// Token: 0x060448B1 RID: 280753 RVA: 0x010E72D3 File Offset: 0x010E54D3
		protected override ELevelAiNodeResult AbortTask()
		{
			CharacterActorComponent character = this.Character;
			if (character != null)
			{
				character.ClearInput(false, true);
			}
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x060448B2 RID: 280754 RVA: 0x010E72E9 File Offset: 0x010E54E9
		protected override void OnTaskFinished(ELevelAiNodeResult result)
		{
			this.Character = null;
			this.MovementMode = EMovementMode.MOVE_None;
		}

		// Token: 0x060448B3 RID: 280755 RVA: 0x010E72FC File Offset: 0x010E54FC
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

		// Token: 0x04023A4B RID: 145995
		private const float TURN_SPEED = 200f;

		// Token: 0x04023A4C RID: 145996
		private const float TOLERANCE = 10f;

		// Token: 0x04023A4D RID: 145997
		[Nullable(2)]
		private CharacterActorComponent Character;

		// Token: 0x04023A4E RID: 145998
		private EMovementMode MovementMode;

		// Token: 0x04023A4F RID: 145999
		private readonly Vector TargetPos = Vector.Create();
	}
}
