using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070E3 RID: 28899
	[NullableContext(1)]
	[Nullable(0)]
	internal class WalkState : FloatingBaseState
	{
		// Token: 0x0604686E RID: 288878 RVA: 0x011B9582 File Offset: 0x011B7782
		public WalkState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0604686F RID: 288879 RVA: 0x011B958D File Offset: 0x011B778D
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
		}

		// Token: 0x06046870 RID: 288880 RVA: 0x011B95AC File Offset: 0x011B77AC
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.FloatingGround;
		}

		// Token: 0x06046871 RID: 288881 RVA: 0x011B95B0 File Offset: 0x011B77B0
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.WalkMoveModeConfig.MovementTagList;
		}

		// Token: 0x06046872 RID: 288882 RVA: 0x011B95C7 File Offset: 0x011B77C7
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.WalkMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x06046873 RID: 288883 RVA: 0x011B95DE File Offset: 0x011B77DE
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.WalkMoveModeConfig.MoveTagList;
		}

		// Token: 0x06046874 RID: 288884 RVA: 0x011B95F5 File Offset: 0x011B77F5
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.WalkMoveModeConfig.StandTagList;
		}

		// Token: 0x06046875 RID: 288885 RVA: 0x011B960C File Offset: 0x011B780C
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

		// Token: 0x06046876 RID: 288886 RVA: 0x011B9634 File Offset: 0x011B7834
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
