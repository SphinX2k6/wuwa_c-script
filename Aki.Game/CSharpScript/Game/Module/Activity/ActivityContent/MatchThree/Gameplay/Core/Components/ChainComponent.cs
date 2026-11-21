using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054AC RID: 21676
	public sealed class ChainComponent : IPieceComponent
	{
		// Token: 0x06035BD4 RID: 220116 RVA: 0x00F03B65 File Offset: 0x00F01D65
		public ChainComponent(int durability)
		{
		}

		// Token: 0x1700688C RID: 26764
		// (get) Token: 0x06035BD5 RID: 220117 RVA: 0x00F03B74 File Offset: 0x00F01D74
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.Block | EPieceCaps.Chain;
			}
		}

		// Token: 0x06035BD6 RID: 220118 RVA: 0x00F03B7B File Offset: 0x00F01D7B
		public void OnAttach(ref PieceComponentState state)
		{
			state.Val1 = this.<durability>P;
		}

		// Token: 0x0401C72D RID: 116525
		[CompilerGenerated]
		private int <durability>P = durability;
	}
}
