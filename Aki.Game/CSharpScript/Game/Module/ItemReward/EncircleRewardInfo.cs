using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004794 RID: 18324
	public class EncircleRewardInfo : RewardInfo, IEncircleRewardInfo, IRewardInfo
	{
		// Token: 0x17005D42 RID: 23874
		// (get) Token: 0x0602E106 RID: 188678 RVA: 0x00CDED3F File Offset: 0x00CDCF3F
		// (set) Token: 0x0602E107 RID: 188679 RVA: 0x00CDED47 File Offset: 0x00CDCF47
		public bool IsSuccess { get; set; }

		// Token: 0x17005D43 RID: 23875
		// (get) Token: 0x0602E108 RID: 188680 RVA: 0x00CDED50 File Offset: 0x00CDCF50
		// (set) Token: 0x0602E109 RID: 188681 RVA: 0x00CDED58 File Offset: 0x00CDCF58
		public int? Score { get; set; }

		// Token: 0x17005D44 RID: 23876
		// (get) Token: 0x0602E10A RID: 188682 RVA: 0x00CDED61 File Offset: 0x00CDCF61
		// (set) Token: 0x0602E10B RID: 188683 RVA: 0x00CDED69 File Offset: 0x00CDCF69
		public int? RecordScore { get; set; }

		// Token: 0x17005D45 RID: 23877
		// (get) Token: 0x0602E10C RID: 188684 RVA: 0x00CDED72 File Offset: 0x00CDCF72
		// (set) Token: 0x0602E10D RID: 188685 RVA: 0x00CDED7A File Offset: 0x00CDCF7A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RewardItemData> CommonItems { [return: Nullable(new byte[]
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
