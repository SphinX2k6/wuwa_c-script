using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070E1 RID: 28897
	[NullableContext(1)]
	[Nullable(0)]
	internal class RiseState : FloatingBaseState
	{
		// Token: 0x06046859 RID: 288857 RVA: 0x011B91E2 File Offset: 0x011B73E2
		public RiseState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0604685A RID: 288858 RVA: 0x011B91ED File Offset: 0x011B73ED
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.CheckGround();
		}

		// Token: 0x0604685B RID: 288859 RVA: 0x011B9200 File Offset: 0x011B7400
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.Rise;
		}

		// Token: 0x0604685C RID: 288860 RVA: 0x011B9204 File Offset: 0x011B7404
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.RiseMoveModeConfig.MovementTagList;
		}

		// Token: 0x0604685D RID: 288861 RVA: 0x011B921B File Offset: 0x011B741B
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.RiseMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x0604685E RID: 288862 RVA: 0x011B9232 File Offset: 0x011B7432
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.RiseMoveModeConfig.MoveTagList;
		}

		// Token: 0x0604685F RID: 288863 RVA: 0x011B9249 File Offset: 0x011B7449
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.RiseMoveModeConfig.StandTagList;
		}

		// Token: 0x06046860 RID: 288864 RVA: 0x011B9260 File Offset: 0x011B7460
		protected override void OnUpdate(float deltaSeconds)
		{
			if (!this.CanContinueState())
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.StateMachine.Switch(EFloatingMovementType.Drop);
				return;
			}
			base.OnUpdate(deltaSeconds);
		}

		// Token: 0x06046861 RID: 288865 RVA: 0x011B9288 File Offset: 0x011B7488
		protected override void UpdateActorLocation(float deltaSeconds)
		{
			this.Owner.UpdateMove(deltaSeconds, this.Owner.MoveDelta);
			this.Owner.TempVector2.DeepCopy(this.Owner.MoveComp.GravityUp);
			this.Owner.TempVector2.MultiplyEqual((double)(this.Owner.Config.RiseSpeed * deltaSeconds));
			this.Owner.MoveDelta.AdditionEqual(this.Owner.TempVector2);
			if (!this.Owner.MoveDelta.IsNearlyZero(9.999999747378752E-05))
			{
				this.Owner.MoveComp.MoveCharacter(this.Owner.MoveDelta, deltaSeconds * 1000f, "CharacterFloatingComponent.Move");
			}
		}

		// Token: 0x06046862 RID: 288866 RVA: 0x011B934E File Offset: 0x011B754E
		protected override void PostUpdate()
		{
			if (this.Owner.DetectCeiling() != null)
			{
				bool debug = CharacterFloatingComponent.Debug;
				if (this.StateMachine.Switch(EFloatingMovementType.Floating))
				{
					bool debug2 = CharacterFloatingComponent.Debug;
					this.StateMachine.Switch(EFloatingMovementType.Drop);
				}
			}
		}
	}
}
