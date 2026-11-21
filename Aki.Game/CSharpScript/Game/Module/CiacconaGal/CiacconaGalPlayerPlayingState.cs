using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA2 RID: 19362
	internal class CiacconaGalPlayerPlayingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x06030592 RID: 198034 RVA: 0x00D7AC4C File Offset: 0x00D78E4C
		[NullableContext(1)]
		public CiacconaGalPlayerPlayingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06030593 RID: 198035 RVA: 0x00D7AC57 File Offset: 0x00D78E57
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
		}

		// Token: 0x06030594 RID: 198036 RVA: 0x00D7AC60 File Offset: 0x00D78E60
		public override void OnClick(int? id = null)
		{
			this.Owner.TrySwitchToState(ECiacconaGalPlayerState.Skipping);
		}
	}
}
