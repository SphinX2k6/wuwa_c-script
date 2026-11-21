using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x02006393 RID: 25491
	[NullableContext(1)]
	[Nullable(0)]
	internal class WalkState : FloatingBaseState
	{
		// Token: 0x0603DC5B RID: 253019 RVA: 0x011E8C56 File Offset: 0x011E6E56
		public WalkState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603DC5C RID: 253020 RVA: 0x011E8C61 File Offset: 0x011E6E61
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
		}

		// Token: 0x0603DC5D RID: 253021 RVA: 0x011E8C80 File Offset: 0x011E6E80
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.FloatingGround;
		}

		// Token: 0x0603DC5E RID: 253022 RVA: 0x011E8C84 File Offset: 0x011E6E84
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.WalkMoveModeConfig.MovementTagList;
		}

		// Token: 0x0603DC5F RID: 253023 RVA: 0x011E8C9B File Offset: 0x011E6E9B
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.WalkMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x0603DC60 RID: 253024 RVA: 0x011E8CB2 File Offset: 0x011E6EB2
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.WalkMoveModeConfig.MoveTagList;
		}

		// Token: 0x0603DC61 RID: 253025 RVA: 0x011E8CC9 File Offset: 0x011E6EC9
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.WalkMoveModeConfig.StandTagList;
		}

		// Token: 0x0603DC62 RID: 253026 RVA: 0x011E8CE0 File Offset: 0x011E6EE0
		protected override void OnUpdate(float deltaSeconds)
		{
			if (!this.CanContinueState())
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.StateMachine.Switch(EFloatingMovementType.Floating);
				return;
			}
			base.OnUpdate(deltaSeconds);
		}

		// Token: 0x0603DC63 RID: 253027 RVA: 0x011E8D08 File Offset: 0x011E6F08
		protected override void PostUpdate()
		{
			CharacterFloatingComponent owner = this.Owner;
			if (owner != null && !owner.IsOnGround && !owner.IsOnWater)
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.StateMachine.Switch(EFloatingMovementType.Drop);
			}
		}
	}
}
