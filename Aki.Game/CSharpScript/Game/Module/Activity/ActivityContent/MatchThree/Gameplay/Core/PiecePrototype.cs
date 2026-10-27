using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core
{
	// Token: 0x02006528 RID: 25896
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct PiecePrototype
	{
		// Token: 0x06040EFB RID: 265979 RVA: 0x00FBC720 File Offset: 0x00FBA920
		public PiecePrototype(IReadOnlyList<IPieceComponent> components, EPieceCaps caps, int energy, int score)
		{
			this.Components = components;
			this.Caps = caps;
			this.Energy = energy;
			this.Score = score;
		}

		// Token: 0x04021DEF RID: 138735
		public readonly IReadOnlyList<IPieceComponent> Components;

		// Token: 0x04021DF0 RID: 138736
		public readonly EPieceCaps Caps;

		// Token: 0x04021DF1 RID: 138737
		public readonly int Energy;

		// Token: 0x04021DF2 RID: 138738
		public readonly int Score;
	}
}
