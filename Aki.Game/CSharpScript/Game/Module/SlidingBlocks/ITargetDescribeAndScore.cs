using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B7C RID: 19324
	[NullableContext(1)]
	public interface ITargetDescribeAndScore
	{
		// Token: 0x17007C38 RID: 31800
		// (get) Token: 0x06032146 RID: 205126
		// (set) Token: 0x06032147 RID: 205127
		string DescribeTextKey { get; set; }

		// Token: 0x17007C39 RID: 31801
		// (get) Token: 0x06032148 RID: 205128
		// (set) Token: 0x06032149 RID: 205129
		int RewardId { get; set; }

		// Token: 0x17007C3A RID: 31802
		// (get) Token: 0x0603214A RID: 205130
		// (set) Token: 0x0603214B RID: 205131
		int Score { get; set; }
	}
}
