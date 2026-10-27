using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D6 RID: 22486
	public class ReachTargetData
	{
		// Token: 0x0401DE87 RID: 122503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRewardExploreTargetReached> TargetReached;

		// Token: 0x0401DE88 RID: 122504
		public int FullScore;

		// Token: 0x0401DE89 RID: 122505
		public bool IfNewRecord;

		// Token: 0x0401DE8A RID: 122506
		[Nullable(1)]
		public string RecordTextId = "";
	}
}
