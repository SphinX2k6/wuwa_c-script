using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070E0 RID: 28896
	[NullableContext(1)]
	[Nullable(0)]
	internal class FloatingState : FloatingBaseState
	{
		// Token: 0x06046851 RID: 288849 RVA: 0x011B9133 File Offset: 0x011B7333
		public FloatingState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06046852 RID: 288850 RVA: 0x011B913E File Offset: 0x011B733E
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
		}

		// Token: 0x06046853 RID: 288851 RVA: 0x011B915D File Offset: 0x011B735D
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.Floating;
		}

		// Token: 0x06046854 RID: 288852 RVA: 0x011B9161 File Offset: 0x011B7361
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.FloatingMoveModeConfig.MovementTagList;
		}

		// Token: 0x06046855 RID: 288853 RVA: 0x011B9178 File Offset: 0x011B7378
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.FloatingMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x06046856 RID: 288854 RVA: 0x011B918F File Offset: 0x011B738F
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.FloatingMoveModeConfig.MoveTagList;
		}

		// Token: 0x06046857 RID: 288855 RVA: 0x011B91A6 File Offset: 0x011B73A6
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.FloatingMoveModeConfig.StandTagList;
		}

		// Token: 0x06046858 RID: 288856 RVA: 0x011B91BD File Offset: 0x011B73BD
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
