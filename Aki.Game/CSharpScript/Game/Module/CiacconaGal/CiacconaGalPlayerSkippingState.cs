using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA3 RID: 19363
	internal class CiacconaGalPlayerSkippingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x06030595 RID: 198037 RVA: 0x00D7AC6E File Offset: 0x00D78E6E
		[NullableContext(1)]
		public CiacconaGalPlayerSkippingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06030596 RID: 198038 RVA: 0x00D7AC79 File Offset: 0x00D78E79
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			this.Owner.AnimHandler.Skip();
		}

		// Token: 0x06030597 RID: 198039 RVA: 0x00D7AC92 File Offset: 0x00D78E92
		public override void OnClick(int? id = null)
		{
		}
	}
}
