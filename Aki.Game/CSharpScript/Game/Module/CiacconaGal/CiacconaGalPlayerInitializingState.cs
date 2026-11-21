using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA0 RID: 19360
	internal class CiacconaGalPlayerInitializingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603058D RID: 198029 RVA: 0x00D7ABCE File Offset: 0x00D78DCE
		[NullableContext(1)]
		public CiacconaGalPlayerInitializingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603058E RID: 198030 RVA: 0x00D7ABD9 File Offset: 0x00D78DD9
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
