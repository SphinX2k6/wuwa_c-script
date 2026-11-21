using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x02006391 RID: 25489
	[NullableContext(1)]
	[Nullable(0)]
	internal class RiseState : FloatingBaseState
	{
		// Token: 0x0603DC46 RID: 252998 RVA: 0x011E88B7 File Offset: 0x011E6AB7
		public RiseState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603DC47 RID: 252999 RVA: 0x011E88C2 File Offset: 0x011E6AC2
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.CheckGround();
		}

		// Token: 0x0603DC48 RID: 253000 RVA: 0x011E88D5 File Offset: 0x011E6AD5
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.Rise;
		}

		// Token: 0x0603DC49 RID: 253001 RVA: 0x011E88D9 File Offset: 0x011E6AD9
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.RiseMoveModeConfig.MovementTagList;
		}

		// Token: 0x0603DC4A RID: 253002 RVA: 0x011E88F0 File Offset: 0x011E6AF0
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.RiseMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x0603DC4B RID: 253003 RVA: 0x011E8907 File Offset: 0x011E6B07
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.RiseMoveModeConfig.MoveTagList;
		}

		// Token: 0x0603DC4C RID: 253004 RVA: 0x011E891E File Offset: 0x011E6B1E
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.RiseMoveModeConfig.StandTagList;
		}

		// Token: 0x0603DC4D RID: 253005 RVA: 0x011E8935 File Offset: 0x011E6B35
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

		// Token: 0x0603DC4E RID: 253006 RVA: 0x011E895C File Offset: 0x011E6B5C
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

		// Token: 0x0603DC4F RID: 253007 RVA: 0x011E8A22 File Offset: 0x011E6C22
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
