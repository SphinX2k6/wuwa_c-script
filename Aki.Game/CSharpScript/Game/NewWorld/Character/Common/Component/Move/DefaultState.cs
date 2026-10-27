using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070DF RID: 28895
	[NullableContext(1)]
	[Nullable(0)]
	internal class DefaultState : FloatingBaseState
	{
		// Token: 0x06046848 RID: 288840 RVA: 0x011B9050 File Offset: 0x011B7250
		public DefaultState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06046849 RID: 288841 RVA: 0x011B905B File Offset: 0x011B725B
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
		}

		// Token: 0x0604684A RID: 288842 RVA: 0x011B907A File Offset: 0x011B727A
		protected override void SetMoveState()
		{
			if (CharacterFloatingComponent.BeHitMoveStateList.Contains(this.Owner.StateComp.MoveState))
			{
				return;
			}
			this.Owner.StateComp.SetMoveState(this.GetMoveState());
		}

		// Token: 0x0604684B RID: 288843 RVA: 0x011B90AF File Offset: 0x011B72AF
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.Other;
		}

		// Token: 0x0604684C RID: 288844 RVA: 0x011B90B2 File Offset: 0x011B72B2
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.DefaultMoveModeConfig.MovementTagList;
		}

		// Token: 0x0604684D RID: 288845 RVA: 0x011B90C9 File Offset: 0x011B72C9
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.DefaultMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x0604684E RID: 288846 RVA: 0x011B90E0 File Offset: 0x011B72E0
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.DefaultMoveModeConfig.MoveTagList;
		}

		// Token: 0x0604684F RID: 288847 RVA: 0x011B90F7 File Offset: 0x011B72F7
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.DefaultMoveModeConfig.StandTagList;
		}

		// Token: 0x06046850 RID: 288848 RVA: 0x011B910E File Offset: 0x011B730E
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
