using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057CD RID: 22477
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreScoreBelongHalfArea : IRewardExploreScoreBelongHalfArea
	{
		// Token: 0x170089A9 RID: 35241
		// (get) Token: 0x0603925C RID: 234076 RVA: 0x00D900DF File Offset: 0x00D8E2DF
		// (set) Token: 0x0603925D RID: 234077 RVA: 0x00D900E7 File Offset: 0x00D8E2E7
		public List<IRewardExploreScoreBelongHalfAreaItem> ItemList { get; set; }

		// Token: 0x170089AA RID: 35242
		// (get) Token: 0x0603925E RID: 234078 RVA: 0x00D900F0 File Offset: 0x00D8E2F0
		// (set) Token: 0x0603925F RID: 234079 RVA: 0x00D900F8 File Offset: 0x00D8E2F8
		public int FullScore { get; set; }

		// Token: 0x170089AB RID: 35243
		// (get) Token: 0x06039260 RID: 234080 RVA: 0x00D90101 File Offset: 0x00D8E301
		// (set) Token: 0x06039261 RID: 234081 RVA: 0x00D90109 File Offset: 0x00D8E309
		public bool IfNewRecord { get; set; }
	}
}
