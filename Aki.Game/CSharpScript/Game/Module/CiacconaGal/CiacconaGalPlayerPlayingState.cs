using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC2 RID: 23490
	internal class CiacconaGalPlayerPlayingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603B646 RID: 243270 RVA: 0x00E2A958 File Offset: 0x00E28B58
		[NullableContext(1)]
		public CiacconaGalPlayerPlayingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B647 RID: 243271 RVA: 0x00E2A963 File Offset: 0x00E28B63
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
		}

		// Token: 0x0603B648 RID: 243272 RVA: 0x00E2A96C File Offset: 0x00E28B6C
		public override void OnClick(int? id = null)
		{
			this.Owner.TrySwitchToState(ECiacconaGalPlayerState.Skipping);
		}
	}
}
