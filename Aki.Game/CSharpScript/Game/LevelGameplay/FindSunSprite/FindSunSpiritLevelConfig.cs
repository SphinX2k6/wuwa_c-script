using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02006E4D RID: 28237
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritLevelConfig
	{
		// Token: 0x04023CE4 RID: 146660
		public int CurrentLevelId;

		// Token: 0x04023CE5 RID: 146661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public FindSunSpiritGrid[] GridList;

		// Token: 0x04023CE6 RID: 146662
		public int LevelWidth;

		// Token: 0x04023CE7 RID: 146663
		public int LevelHeight;

		// Token: 0x04023CE8 RID: 146664
		public List<int> SunSpiritStartGridIndices = new List<int>();

		// Token: 0x04023CE9 RID: 146665
		public int SunSpiritEndIndex = -1;

		// Token: 0x04023CEA RID: 146666
		public int MaxJumpHeight = 1;

		// Token: 0x04023CEB RID: 146667
		public int MaxDropHeight = -1;

		// Token: 0x04023CEC RID: 146668
		public int MaxStep = -1;

		// Token: 0x04023CED RID: 146669
		public List<FindSunSpiritModifier> ModifierList = new List<FindSunSpiritModifier>();
	}
}
