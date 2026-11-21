using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EA7 RID: 20135
	public class QuestRewardViewParam
	{
		// Token: 0x0401ADFA RID: 110074
		public bool IsShowExpItem;

		// Token: 0x0401ADFB RID: 110075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public int[][] RewardList;

		// Token: 0x0401ADFC RID: 110076
		public int AreaId;

		// Token: 0x0401ADFD RID: 110077
		public int BeforeContributionLevel;

		// Token: 0x0401ADFE RID: 110078
		public int BeforeContributionValue;
	}
}
