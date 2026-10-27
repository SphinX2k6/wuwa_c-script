using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC3 RID: 23491
	internal class CiacconaGalPlayerSkippingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603B649 RID: 243273 RVA: 0x00E2A97A File Offset: 0x00E28B7A
		[NullableContext(1)]
		public CiacconaGalPlayerSkippingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B64A RID: 243274 RVA: 0x00E2A985 File Offset: 0x00E28B85
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			this.Owner.AnimHandler.Skip();
		}

		// Token: 0x0603B64B RID: 243275 RVA: 0x00E2A99E File Offset: 0x00E28B9E
		public override void OnClick(int? id = null)
		{
		}
	}
}
