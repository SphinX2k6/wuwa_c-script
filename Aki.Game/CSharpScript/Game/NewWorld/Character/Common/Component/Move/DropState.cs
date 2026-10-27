using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070E2 RID: 28898
	[NullableContext(1)]
	[Nullable(0)]
	internal class DropState : FloatingBaseState
	{
		// Token: 0x06046863 RID: 288867 RVA: 0x011B9384 File Offset: 0x011B7584
		public DropState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06046864 RID: 288868 RVA: 0x011B938F File Offset: 0x011B758F
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
		}

		// Token: 0x06046865 RID: 288869 RVA: 0x011B93AE File Offset: 0x011B75AE
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.Drop;
		}

		// Token: 0x06046866 RID: 288870 RVA: 0x011B93B4 File Offset: 0x011B75B4
		protected override bool CanContinueState()
		{
			if (!base.CanContinueState())
			{
				return false;
			}
			CharacterFloatingComponent owner = this.Owner;
			return owner != null && !owner.IsOnGround && !owner.IsOnWater;
		}

		// Token: 0x06046867 RID: 288871 RVA: 0x011B93E8 File Offset: 0x011B75E8
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.DropMoveModeConfig.MovementTagList;
		}

		// Token: 0x06046868 RID: 288872 RVA: 0x011B93FF File Offset: 0x011B75FF
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.DropMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x06046869 RID: 288873 RVA: 0x011B9416 File Offset: 0x011B7616
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.DropMoveModeConfig.MoveTagList;
		}

		// Token: 0x0604686A RID: 288874 RVA: 0x011B942D File Offset: 0x011B762D
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.DropMoveModeConfig.StandTagList;
		}

		// Token: 0x0604686B RID: 288875 RVA: 0x011B9444 File Offset: 0x011B7644
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

		// Token: 0x0604686C RID: 288876 RVA: 0x011B946C File Offset: 0x011B766C
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

		// Token: 0x0604686D RID: 288877 RVA: 0x011B9534 File Offset: 0x011B7734
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
