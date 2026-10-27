using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02006E4C RID: 28236
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritLevelPlay
	{
		// Token: 0x04023CDF RID: 146655
		public int CurrentStep;

		// Token: 0x04023CE0 RID: 146656
		public int SelectedModifierIndex;

		// Token: 0x04023CE1 RID: 146657
		public List<FindSunSpiritGrid> GridList = new List<FindSunSpiritGrid>();

		// Token: 0x04023CE2 RID: 146658
		public HashSet<int> SunSpiritIndexSet = new HashSet<int>();

		// Token: 0x04023CE3 RID: 146659
		public int SunSpiritNum;
	}
}
