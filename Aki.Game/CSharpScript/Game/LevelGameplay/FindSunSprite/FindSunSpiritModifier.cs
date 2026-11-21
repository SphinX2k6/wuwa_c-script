using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02005FCC RID: 24524
	public class FindSunSpiritModifier
	{
		// Token: 0x0401EF90 RID: 126864
		public int GridIndex;

		// Token: 0x0401EF91 RID: 126865
		public float GridX;

		// Token: 0x0401EF92 RID: 126866
		public float GridY;

		// Token: 0x0401EF93 RID: 126867
		[Nullable(1)]
		public HashSet<int> ModifyIndexSet = new HashSet<int>();
	}
}
