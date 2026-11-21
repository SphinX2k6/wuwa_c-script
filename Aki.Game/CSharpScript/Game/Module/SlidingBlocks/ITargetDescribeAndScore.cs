using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B26 RID: 15142
	[NullableContext(1)]
	public interface ITargetDescribeAndScore
	{
		// Token: 0x17004FE2 RID: 20450
		// (get) Token: 0x06026ED7 RID: 159447
		// (set) Token: 0x06026ED8 RID: 159448
		string DescribeTextKey { get; set; }

		// Token: 0x17004FE3 RID: 20451
		// (get) Token: 0x06026ED9 RID: 159449
		// (set) Token: 0x06026EDA RID: 159450
		int RewardId { get; set; }

		// Token: 0x17004FE4 RID: 20452
		// (get) Token: 0x06026EDB RID: 159451
		// (set) Token: 0x06026EDC RID: 159452
		int Score { get; set; }
	}
}
