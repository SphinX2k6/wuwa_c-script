using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core
{
	// Token: 0x020054A6 RID: 21670
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct PiecePrototype
	{
		// Token: 0x06035BC0 RID: 220096 RVA: 0x00F03764 File Offset: 0x00F01964
		public PiecePrototype(IReadOnlyList<IPieceComponent> components, EPieceCaps caps, int energy, int score)
		{
			this.Components = components;
			this.Caps = caps;
			this.Energy = energy;
			this.Score = score;
		}

		// Token: 0x0401C720 RID: 116512
		public readonly IReadOnlyList<IPieceComponent> Components;

		// Token: 0x0401C721 RID: 116513
		public readonly EPieceCaps Caps;

		// Token: 0x0401C722 RID: 116514
		public readonly int Energy;

		// Token: 0x0401C723 RID: 116515
		public readonly int Score;
	}
}
