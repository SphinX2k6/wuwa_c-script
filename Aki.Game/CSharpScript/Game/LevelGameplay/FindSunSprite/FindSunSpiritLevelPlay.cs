using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02005FCD RID: 24525
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritLevelPlay
	{
		// Token: 0x0401EF94 RID: 126868
		public int CurrentStep;

		// Token: 0x0401EF95 RID: 126869
		public int SelectedModifierIndex;

		// Token: 0x0401EF96 RID: 126870
		public List<FindSunSpiritGrid> GridList = new List<FindSunSpiritGrid>();

		// Token: 0x0401EF97 RID: 126871
		public HashSet<int> SunSpiritIndexSet = new HashSet<int>();

		// Token: 0x0401EF98 RID: 126872
		public int SunSpiritNum;
	}
}
