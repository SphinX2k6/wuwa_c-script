using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070C4 RID: 28868
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterGaitComponent : EntityComponent
	{
		// Token: 0x06046671 RID: 288369 RVA: 0x011A81BC File Offset: 0x011A63BC
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			this.UnifiedStateComponent = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
			return this.ActorComp != null && this.MoveComp != null && this.UnifiedStateComponent != null;
		}

		// Token: 0x06046672 RID: 288370 RVA: 0x011A8218 File Offset: 0x011A6418
		protected override void OnTick(float delta)
		{
			if (!this.ActorComp.IsAutonomousProxy)
			{
				return;
			}
			ECharMoveState moveState = this.UnifiedStateComponent.MoveState;
			ECharPositionState positionState = this.UnifiedStateComponent.PositionState;
			if (!this.MoveComp.HasMoveInput)
			{
				this.UpdateMoveReleasing(positionState, moveState);
			}
		}

		// Token: 0x06046673 RID: 288371 RVA: 0x011A8260 File Offset: 0x011A6460
		protected void UpdateMoveReleasing(ECharPositionState positionState, ECharMoveState moveState)
		{
			if (positionState == ECharPositionState.Ground)
			{
				switch (moveState)
				{
				case ECharMoveState.WalkStop:
				case ECharMoveState.RunStop:
				case ECharMoveState.SprintStop:
					if (this.MoveComp.Speed < 5f)
					{
						this.UnifiedStateComponent.SetMoveState(ECharMoveState.Other);
						return;
					}
					return;
				}
				if (this.MoveComp.Speed > 5f)
				{
					this.SetRunStop();
				}
			}
		}

		// Token: 0x06046674 RID: 288372 RVA: 0x011A82C8 File Offset: 0x011A64C8
		protected void SetRunStop()
		{
			switch (this.UnifiedStateComponent.MoveState)
			{
			case ECharMoveState.Walk:
				this.UnifiedStateComponent.SetMoveState(ECharMoveState.WalkStop);
				return;
			case ECharMoveState.WalkStop:
			case ECharMoveState.RunStop:
			case ECharMoveState.SprintStop:
				break;
			case ECharMoveState.Run:
			case ECharMoveState.Sprint:
			case ECharMoveState.Dodge:
			case ECharMoveState.LandRoll:
				if (this.MoveComp.Speed < this.MoveComp.MovementData.FaceDirection.Standing.SprintSpeed - 150f)
				{
					this.UnifiedStateComponent.SetMoveState(ECharMoveState.RunStop);
					return;
				}
				this.UnifiedStateComponent.SetMoveState(ECharMoveState.SprintStop);
				break;
			default:
				return;
			}
		}

		// Token: 0x06046675 RID: 288373 RVA: 0x011A8360 File Offset: 0x011A6560
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterGaitComponent characterGaitComponent = (CharacterGaitComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterGaitComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (characterGaitComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("UnifiedStateComponent"))
			{
				if (characterGaitComponent.UnifiedStateComponent == null)
				{
					this.UnifiedStateComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComponent), "UnifiedStateComponent"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024E46 RID: 151110
		private const int STOP_SPEED = 5;

		// Token: 0x04024E47 RID: 151111
		private CharacterActorComponent ActorComp;

		// Token: 0x04024E48 RID: 151112
		private CharacterMoveComponent MoveComp;

		// Token: 0x04024E49 RID: 151113
		private CharacterUnifiedStateComponent UnifiedStateComponent;
	}
}
