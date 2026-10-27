using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057BC RID: 22460
	public interface IEncircleRewardInfo : IRewardInfo
	{
		// Token: 0x17008976 RID: 35190
		// (get) Token: 0x060391EE RID: 233966
		// (set) Token: 0x060391EF RID: 233967
		bool IsSuccess { get; set; }

		// Token: 0x17008977 RID: 35191
		// (get) Token: 0x060391F0 RID: 233968
		// (set) Token: 0x060391F1 RID: 233969
		int? Score { get; set; }

		// Token: 0x17008978 RID: 35192
		// (get) Token: 0x060391F2 RID: 233970
		// (set) Token: 0x060391F3 RID: 233971
		int? RecordScore { get; set; }

		// Token: 0x17008979 RID: 35193
		// (get) Token: 0x060391F4 RID: 233972
		// (set) Token: 0x060391F5 RID: 233973
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<RewardItemData> CommonItems { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
