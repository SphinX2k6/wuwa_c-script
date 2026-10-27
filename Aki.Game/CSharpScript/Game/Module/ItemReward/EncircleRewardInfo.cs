using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057BD RID: 22461
	public class EncircleRewardInfo : RewardInfo, IEncircleRewardInfo, IRewardInfo
	{
		// Token: 0x1700897A RID: 35194
		// (get) Token: 0x060391F6 RID: 233974 RVA: 0x00D8FF07 File Offset: 0x00D8E107
		// (set) Token: 0x060391F7 RID: 233975 RVA: 0x00D8FF0F File Offset: 0x00D8E10F
		public bool IsSuccess { get; set; }

		// Token: 0x1700897B RID: 35195
		// (get) Token: 0x060391F8 RID: 233976 RVA: 0x00D8FF18 File Offset: 0x00D8E118
		// (set) Token: 0x060391F9 RID: 233977 RVA: 0x00D8FF20 File Offset: 0x00D8E120
		public int? Score { get; set; }

		// Token: 0x1700897C RID: 35196
		// (get) Token: 0x060391FA RID: 233978 RVA: 0x00D8FF29 File Offset: 0x00D8E129
		// (set) Token: 0x060391FB RID: 233979 RVA: 0x00D8FF31 File Offset: 0x00D8E131
		public int? RecordScore { get; set; }

		// Token: 0x1700897D RID: 35197
		// (get) Token: 0x060391FC RID: 233980 RVA: 0x00D8FF3A File Offset: 0x00D8E13A
		// (set) Token: 0x060391FD RID: 233981 RVA: 0x00D8FF42 File Offset: 0x00D8E142
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
