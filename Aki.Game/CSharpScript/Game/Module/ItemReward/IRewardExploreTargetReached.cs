using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200479F RID: 18335
	[NullableContext(1)]
	public interface IRewardExploreTargetReached
	{
		// Token: 0x17005D64 RID: 23908
		// (get) Token: 0x0602E150 RID: 188752
		// (set) Token: 0x0602E151 RID: 188753
		List<string> Target { get; set; }

		// Token: 0x17005D65 RID: 23909
		// (get) Token: 0x0602E152 RID: 188754
		// (set) Token: 0x0602E153 RID: 188755
		string DescriptionTextId { get; set; }

		// Token: 0x17005D66 RID: 23910
		// (get) Token: 0x0602E154 RID: 188756
		// (set) Token: 0x0602E155 RID: 188757
		bool IsReached { get; set; }
	}
}
