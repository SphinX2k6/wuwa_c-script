using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC0 RID: 23488
	internal class CiacconaGalPlayerInitializingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603B641 RID: 243265 RVA: 0x00E2A8D9 File Offset: 0x00E28AD9
		[NullableContext(1)]
		public CiacconaGalPlayerInitializingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B642 RID: 243266 RVA: 0x00E2A8E4 File Offset: 0x00E28AE4
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			ICiacconaGalTextAnimHandler animHandler = this.Owner.AnimHandler;
			if (animHandler == null)
			{
				return;
			}
			animHandler.Stop();
		}
	}
}
