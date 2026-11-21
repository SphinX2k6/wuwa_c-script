using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047AD RID: 18349
	public class ReachTargetData
	{
		// Token: 0x0401891E RID: 100638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRewardExploreTargetReached> TargetReached;

		// Token: 0x0401891F RID: 100639
		public int FullScore;

		// Token: 0x04018920 RID: 100640
		public bool IfNewRecord;

		// Token: 0x04018921 RID: 100641
		[Nullable(1)]
		public string RecordTextId = "";
	}
}
