using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02006E4B RID: 28235
	public class FindSunSpiritModifier
	{
		// Token: 0x04023CDB RID: 146651
		public int GridIndex;

		// Token: 0x04023CDC RID: 146652
		public float GridX;

		// Token: 0x04023CDD RID: 146653
		public float GridY;

		// Token: 0x04023CDE RID: 146654
		[Nullable(1)]
		public HashSet<int> ModifyIndexSet = new HashSet<int>();
	}
}
