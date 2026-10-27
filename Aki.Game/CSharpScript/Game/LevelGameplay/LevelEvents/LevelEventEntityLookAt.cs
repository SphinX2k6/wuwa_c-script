using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B21 RID: 27425
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventEntityLookAt : LevelEventBase
	{
		// Token: 0x060440C5 RID: 278725 RVA: 0x010BA6D2 File Offset: 0x010B88D2
		public LevelEventEntityLookAt(int id) : base(id)
		{
		}

		// Token: 0x060440C6 RID: 278726 RVA: 0x010BA6DB File Offset: 0x010B88DB
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

		// Token: 0x060440C7 RID: 278727 RVA: 0x010BA70E File Offset: 0x010B890E
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060440C8 RID: 278728 RVA: 0x010BA71C File Offset: 0x010B891C
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

		// Token: 0x060440C9 RID: 278729 RVA: 0x010BA8F4 File Offset: 0x010B8AF4
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

		// Token: 0x060440CA RID: 278730 RVA: 0x010BA984 File Offset: 0x010B8B84
		protected override void OnReset()
		{
			this.EntityHandle = null;
			this.CanTick = false;
			this.MovementMode = EMovementMode.MOVE_None;
		}

		// Token: 0x040238EF RID: 145647
		private const int TURN_SPEED = 200;

		// Token: 0x040238F0 RID: 145648
		private const int TOLERANCE = 10;

		// Token: 0x040238F1 RID: 145649
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x040238F2 RID: 145650
		[Nullable(2)]
		private EntityLookAt Param;

		// Token: 0x040238F3 RID: 145651
		private bool CanTick;

		// Token: 0x040238F4 RID: 145652
		private EMovementMode MovementMode;
	}
}
