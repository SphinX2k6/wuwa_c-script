using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C99 RID: 23705
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventEntityLookAt : LevelEventBase
	{
		// Token: 0x0603A217 RID: 238103 RVA: 0x01063F5E File Offset: 0x0106215E
		public LevelEventEntityLookAt(int id) : base(id)
		{
		}

		// Token: 0x0603A218 RID: 238104 RVA: 0x01063F67 File Offset: 0x01062167
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.Param = (inParams as EntityLookAt);
			this.CanTick = false;
			base.CreateWaitEntityTask(this.Param.EntityId);
		}

		// Token: 0x0603A219 RID: 238105 RVA: 0x01063F9A File Offset: 0x0106219A
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A21A RID: 238106 RVA: 0x01063FA8 File Offset: 0x010621A8
		protected override void ExecuteWhenEntitiesReady()
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.Param.EntityId);
			if (entityByPbDataId == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "执行转向动作时实体不存在:";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.Param.EntityId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(true, false, true);
				return;
			}
			this.EntityHandle = entityByPbDataId;
			CharacterActorComponent component = entityByPbDataId.Entity.GetComponent<CharacterActorComponent>();
			BaseMoveComponent component2 = entityByPbDataId.Entity.GetComponent<BaseMoveComponent>();
			UCharacterMovementComponent ucharacterMovementComponent = (component2 != null) ? component2.CharacterMovement : null;
			if (!ObjectUtils.IsValid(ucharacterMovementComponent))
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.MovementMode = ucharacterMovementComponent.MovementMode;
			ucharacterMovementComponent.MovementMode = EMovementMode.MOVE_Walking;
			global::Vector vector = global::Vector.Create((double)this.Param.Pos.X.GetValueOrDefault(), (double)this.Param.Pos.Y.GetValueOrDefault(), (double)this.Param.Pos.Z.GetValueOrDefault());
			AiControllerLibrary.TurnToTarget(component, vector, 200f, false, 0f);
			global::Vector vector2 = global::Vector.Create();
			global::Rotator rotator = global::Rotator.Create();
			vector.Subtraction(component.ActorLocationProxy, vector2);
			vector2.ToOrientationRotator(rotator);
			rotator.Pitch = 0f;
			rotator.Roll = 0f;
			EntitySimplyMoveInfoPackagePush entitySimplyMoveInfoPackagePush = EntitySimplyMoveInfoPackagePush.Create();
			EntitySimplyMoveInfo entitySimplyMoveInfo = EntitySimplyMoveInfo.Create();
			entitySimplyMoveInfo.EntityId = entityByPbDataId.CreatureDataId;
			entitySimplyMoveInfo.Location = component.ActorLocationProxy.ToProtocolVector();
			entitySimplyMoveInfo.Rotation = rotator.ToProtocolRotator();
			entitySimplyMoveInfoPackagePush.MoveInfos.Add(entitySimplyMoveInfo);
			Net.Instance.Send(EPushMessageId.EntitySimplyMoveInfoPackagePush, entitySimplyMoveInfoPackagePush);
			if (this.IsAsync)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			this.CanTick = true;
		}

		// Token: 0x0603A21B RID: 238107 RVA: 0x01064180 File Offset: 0x01062380
		protected override void OnTick(float deltaTime)
		{
			if (!this.CanTick)
			{
				return;
			}
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || !entityHandle.IsInit)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			WorldEntity entity = this.EntityHandle.Entity;
			CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
			if (characterActorComponent.InputRotatorProxy.Equals(characterActorComponent.ActorRotationProxy, 10f))
			{
				characterActorComponent.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.MovementMode;
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x0603A21C RID: 238108 RVA: 0x01064210 File Offset: 0x01062410
		protected override void OnReset()
		{
			this.EntityHandle = null;
			this.CanTick = false;
			this.MovementMode = EMovementMode.MOVE_None;
		}

		// Token: 0x0401EB91 RID: 125841
		private const int TURN_SPEED = 200;

		// Token: 0x0401EB92 RID: 125842
		private const int TOLERANCE = 10;

		// Token: 0x0401EB93 RID: 125843
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x0401EB94 RID: 125844
		[Nullable(2)]
		private EntityLookAt Param;

		// Token: 0x0401EB95 RID: 125845
		private bool CanTick;

		// Token: 0x0401EB96 RID: 125846
		private EMovementMode MovementMode;
	}
}
