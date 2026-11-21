using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200638F RID: 25487
	[NullableContext(1)]
	[Nullable(0)]
	internal class DefaultState : FloatingBaseState
	{
		// Token: 0x0603DC35 RID: 252981 RVA: 0x011E8724 File Offset: 0x011E6924
		public DefaultState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603DC36 RID: 252982 RVA: 0x011E872F File Offset: 0x011E692F
		protected override void OnEnterInternal()
		{
			base.OnEnterInternal();
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
		}

		// Token: 0x0603DC37 RID: 252983 RVA: 0x011E874E File Offset: 0x011E694E
		protected override void SetMoveState()
		{
			if (Array.IndexOf<ECharMoveState>(CharacterFloatingComponent.BeHitMoveStateList, this.Owner.StateComp.MoveState) >= 0)
			{
				return;
			}
			this.Owner.StateComp.SetMoveState(this.GetMoveState());
		}

		// Token: 0x0603DC38 RID: 252984 RVA: 0x011E8784 File Offset: 0x011E6984
		protected override ECharMoveState GetMoveState()
		{
			return ECharMoveState.Other;
		}

		// Token: 0x0603DC39 RID: 252985 RVA: 0x011E8787 File Offset: 0x011E6987
		protected override List<int> GetInStateConfigTagList()
		{
			return this.Owner.Config.DefaultMoveModeConfig.MovementTagList;
		}

		// Token: 0x0603DC3A RID: 252986 RVA: 0x011E879E File Offset: 0x011E699E
		protected override List<int> GetBannedStateConfigTagList()
		{
			return this.Owner.Config.DefaultMoveModeConfig.BannedMovementTagList;
		}

		// Token: 0x0603DC3B RID: 252987 RVA: 0x011E87B5 File Offset: 0x011E69B5
		protected override List<int> GetMoveConfigTagList()
		{
			return this.Owner.Config.DefaultMoveModeConfig.MoveTagList;
		}

		// Token: 0x0603DC3C RID: 252988 RVA: 0x011E87CC File Offset: 0x011E69CC
		protected override List<int> GetStandConfigTagList()
		{
			return this.Owner.Config.DefaultMoveModeConfig.StandTagList;
		}

		// Token: 0x0603DC3D RID: 252989 RVA: 0x011E87E3 File Offset: 0x011E69E3
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
