using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x02006392 RID: 25490
	[NullableContext(1)]
	[Nullable(0)]
	internal class DropState : FloatingBaseState
	{
		// Token: 0x0603DC50 RID: 253008 RVA: 0x011E8A58 File Offset: 0x011E6C58
		public DropState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603DC51 RID: 253009 RVA: 0x011E8A63 File Offset: 0x011E6C63
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
		}

		// Token: 0x0603DC52 RID: 253010 RVA: 0x011E8A82 File Offset: 0x011E6C82
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.Drop;
		}

		// Token: 0x0603DC53 RID: 253011 RVA: 0x011E8A88 File Offset: 0x011E6C88
		protected override bool CanContinueState()
		{
			if (!base.CanContinueState())
			{
				return false;
			}
			CharacterFloatingComponent owner = this.Owner;
			return owner != null && !owner.IsOnGround && !owner.IsOnWater;
		}

		// Token: 0x0603DC54 RID: 253012 RVA: 0x011E8ABC File Offset: 0x011E6CBC
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.DropMoveModeConfig.MovementTagList;
		}

		// Token: 0x0603DC55 RID: 253013 RVA: 0x011E8AD3 File Offset: 0x011E6CD3
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.DropMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x0603DC56 RID: 253014 RVA: 0x011E8AEA File Offset: 0x011E6CEA
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.DropMoveModeConfig.MoveTagList;
		}

		// Token: 0x0603DC57 RID: 253015 RVA: 0x011E8B01 File Offset: 0x011E6D01
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.DropMoveModeConfig.StandTagList;
		}

		// Token: 0x0603DC58 RID: 253016 RVA: 0x011E8B18 File Offset: 0x011E6D18
		protected override void OnUpdate(float deltaSeconds)
		{
			if (!this.CanContinueState())
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.StateMachine.Switch(EFloatingMovementType.Walk);
				return;
			}
			base.OnUpdate(deltaSeconds);
		}

		// Token: 0x0603DC59 RID: 253017 RVA: 0x011E8B40 File Offset: 0x011E6D40
		protected override void UpdateActorLocation(float deltaSeconds)
		{
			this.Owner.UpdateMove(deltaSeconds, this.Owner.MoveDelta);
			this.Owner.TempVector2.DeepCopy(this.Owner.MoveComp.GravityDirect);
			this.Owner.TempVector2.MultiplyEqual((double)(this.Owner.Config.DropSpeed * deltaSeconds));
			this.Owner.MoveDelta.AdditionEqual(this.Owner.TempVector2);
			if (!this.Owner.MoveDelta.IsNearlyZero(9.999999747378752E-05))
			{
				this.Owner.MoveComp.MoveCharacter(this.Owner.MoveDelta, deltaSeconds * 1000f, "CharacterFloatingComponent.Move");
			}
		}

		// Token: 0x0603DC5A RID: 253018 RVA: 0x011E8C08 File Offset: 0x011E6E08
		protected override void PostUpdate()
		{
			if (this.Owner.IsOnGround || this.Owner.IsOnWater)
			{
				bool debug = CharacterFloatingComponent.Debug;
				if (!this.StateMachine.Switch(EFloatingMovementType.Floating))
				{
					bool debug2 = CharacterFloatingComponent.Debug;
					this.StateMachine.Switch(EFloatingMovementType.Walk);
				}
			}
		}
	}
}
