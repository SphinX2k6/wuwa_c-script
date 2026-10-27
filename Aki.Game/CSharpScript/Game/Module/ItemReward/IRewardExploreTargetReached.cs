using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057C8 RID: 22472
	[NullableContext(1)]
	public interface IRewardExploreTargetReached
	{
		// Token: 0x1700899C RID: 35228
		// (get) Token: 0x06039240 RID: 234048
		// (set) Token: 0x06039241 RID: 234049
		List<string> Target { get; set; }

		// Token: 0x1700899D RID: 35229
		// (get) Token: 0x06039242 RID: 234050
		// (set) Token: 0x06039243 RID: 234051
		string DescriptionTextId { get; set; }

		// Token: 0x1700899E RID: 35230
		// (get) Token: 0x06039244 RID: 234052
		// (set) Token: 0x06039245 RID: 234053
		bool IsReached { get; set; }
	}
}
