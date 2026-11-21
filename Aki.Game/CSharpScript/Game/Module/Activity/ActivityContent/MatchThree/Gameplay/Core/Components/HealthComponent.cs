using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B1 RID: 21681
	public sealed class HealthComponent : IPieceComponent
	{
		// Token: 0x06035BDF RID: 220127 RVA: 0x00F03C64 File Offset: 0x00F01E64
		public HealthComponent(int count)
		{
		}

		// Token: 0x1700688F RID: 26767
		// (get) Token: 0x06035BE0 RID: 220128 RVA: 0x00F03C73 File Offset: 0x00F01E73
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.Health;
			}
		}

		// Token: 0x06035BE1 RID: 220129 RVA: 0x00F03C7A File Offset: 0x00F01E7A
		public void OnAttach(ref PieceComponentState state)
		{
			state.Val1 = this.<count>P;
		}

		// Token: 0x0401C72F RID: 116527
		[CompilerGenerated]
		private int <count>P = count;
	}
}
