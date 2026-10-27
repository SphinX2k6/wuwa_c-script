using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EC2 RID: 24258
	public class QuestRewardViewParam
	{
		// Token: 0x04020333 RID: 131891
		public bool IsShowExpItem;

		// Token: 0x04020334 RID: 131892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public int[][] RewardList;

		// Token: 0x04020335 RID: 131893
		public int AreaId;

		// Token: 0x04020336 RID: 131894
		public int BeforeContributionLevel;

		// Token: 0x04020337 RID: 131895
		public int BeforeContributionValue;
	}
}
