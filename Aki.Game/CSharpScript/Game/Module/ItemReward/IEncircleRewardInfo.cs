using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004793 RID: 18323
	public interface IEncircleRewardInfo : IRewardInfo
	{
		// Token: 0x17005D3E RID: 23870
		// (get) Token: 0x0602E0FE RID: 188670
		// (set) Token: 0x0602E0FF RID: 188671
		bool IsSuccess { get; set; }

		// Token: 0x17005D3F RID: 23871
		// (get) Token: 0x0602E100 RID: 188672
		// (set) Token: 0x0602E101 RID: 188673
		int? Score { get; set; }

		// Token: 0x17005D40 RID: 23872
		// (get) Token: 0x0602E102 RID: 188674
		// (set) Token: 0x0602E103 RID: 188675
		int? RecordScore { get; set; }

		// Token: 0x17005D41 RID: 23873
		// (get) Token: 0x0602E104 RID: 188676
		// (set) Token: 0x0602E105 RID: 188677
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
