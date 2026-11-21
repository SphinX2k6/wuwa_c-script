using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x02006390 RID: 25488
	[NullableContext(1)]
	[Nullable(0)]
	internal class FloatingState : FloatingBaseState
	{
		// Token: 0x0603DC3E RID: 252990 RVA: 0x011E8808 File Offset: 0x011E6A08
		public FloatingState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603DC3F RID: 252991 RVA: 0x011E8813 File Offset: 0x011E6A13
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
		}

		// Token: 0x0603DC40 RID: 252992 RVA: 0x011E8832 File Offset: 0x011E6A32
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.Floating;
		}

		// Token: 0x0603DC41 RID: 252993 RVA: 0x011E8836 File Offset: 0x011E6A36
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.FloatingMoveModeConfig.MovementTagList;
		}

		// Token: 0x0603DC42 RID: 252994 RVA: 0x011E884D File Offset: 0x011E6A4D
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.FloatingMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x0603DC43 RID: 252995 RVA: 0x011E8864 File Offset: 0x011E6A64
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.FloatingMoveModeConfig.MoveTagList;
		}

		// Token: 0x0603DC44 RID: 252996 RVA: 0x011E887B File Offset: 0x011E6A7B
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.FloatingMoveModeConfig.StandTagList;
		}

		// Token: 0x0603DC45 RID: 252997 RVA: 0x011E8892 File Offset: 0x011E6A92
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
	}
}
