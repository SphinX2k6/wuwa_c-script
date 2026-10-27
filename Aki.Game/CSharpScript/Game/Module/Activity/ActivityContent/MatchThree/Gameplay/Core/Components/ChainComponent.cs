using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x0200652E RID: 25902
	public sealed class ChainComponent : IPieceComponent
	{
		// Token: 0x06040F0F RID: 265999 RVA: 0x00FBCB21 File Offset: 0x00FBAD21
		public ChainComponent(int durability)
		{
		}

		// Token: 0x1700952A RID: 38186
		// (get) Token: 0x06040F10 RID: 266000 RVA: 0x00FBCB30 File Offset: 0x00FBAD30
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.Block | EPieceCaps.Chain;
			}
		}

		// Token: 0x06040F11 RID: 266001 RVA: 0x00FBCB37 File Offset: 0x00FBAD37
		public void OnAttach(ref PieceComponentState state)
		{
			state.Val1 = this.<durability>P;
		}

		// Token: 0x04021DFC RID: 138748
		[CompilerGenerated]
		private int <durability>P = durability;
	}
}
