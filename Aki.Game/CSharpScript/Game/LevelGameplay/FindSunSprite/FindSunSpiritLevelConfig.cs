using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02005FCE RID: 24526
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritLevelConfig
	{
		// Token: 0x0401EF99 RID: 126873
		public int CurrentLevelId;

		// Token: 0x0401EF9A RID: 126874
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public FindSunSpiritGrid[] GridList;

		// Token: 0x0401EF9B RID: 126875
		public int LevelWidth;

		// Token: 0x0401EF9C RID: 126876
		public int LevelHeight;

		// Token: 0x0401EF9D RID: 126877
		public List<int> SunSpiritStartGridIndices = new List<int>();

		// Token: 0x0401EF9E RID: 126878
		public int SunSpiritEndIndex = -1;

		// Token: 0x0401EF9F RID: 126879
		public int MaxJumpHeight = 1;

		// Token: 0x0401EFA0 RID: 126880
		public int MaxDropHeight = -1;

		// Token: 0x0401EFA1 RID: 126881
		public int MaxStep = -1;

		// Token: 0x0401EFA2 RID: 126882
		public List<FindSunSpiritModifier> ModifierList = new List<FindSunSpiritModifier>();
	}
}
