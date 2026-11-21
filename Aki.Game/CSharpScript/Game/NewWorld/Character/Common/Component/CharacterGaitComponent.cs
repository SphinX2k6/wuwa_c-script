using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006328 RID: 25384
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterGaitComponent : EntityComponent
	{
		// Token: 0x0603D755 RID: 251733 RVA: 0x011C7840 File Offset: 0x011C5A40
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			this.UnifiedStateComponent = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
			return this.ActorComp != null && this.MoveComp != null && this.UnifiedStateComponent != null;
		}

		// Token: 0x0603D756 RID: 251734 RVA: 0x011C789C File Offset: 0x011C5A9C
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

		// Token: 0x0603D757 RID: 251735 RVA: 0x011C78E4 File Offset: 0x011C5AE4
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

		// Token: 0x0603D758 RID: 251736 RVA: 0x011C794C File Offset: 0x011C5B4C
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

		// Token: 0x0603D759 RID: 251737 RVA: 0x011C79E4 File Offset: 0x011C5BE4
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterGaitComponent characterGaitComponent = (CharacterGaitComponent)componentTemplate;
			if (characterGaitComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterGaitComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (characterGaitComponent.UnifiedStateComponent == null)
			{
				this.UnifiedStateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComponent), "UnifiedStateComponent"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007491 RID: 29841
		// (get) Token: 0x0603D75A RID: 251738 RVA: 0x011C7A85 File Offset: 0x011C5C85
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007492 RID: 29842
		// (get) Token: 0x0603D75B RID: 251739 RVA: 0x011C7A88 File Offset: 0x011C5C88
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020984 RID: 133508
		private const int STOP_SPEED = 5;

		// Token: 0x04020985 RID: 133509
		private CharacterActorComponent ActorComp;

		// Token: 0x04020986 RID: 133510
		private CharacterMoveComponent MoveComp;

		// Token: 0x04020987 RID: 133511
		private CharacterUnifiedStateComponent UnifiedStateComponent;
	}
}
