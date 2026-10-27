using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D5 RID: 22485
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreFriendData : IRewardExploreFriendData
	{
		// Token: 0x170089D4 RID: 35284
		// (get) Token: 0x060392B6 RID: 234166 RVA: 0x00D90242 File Offset: 0x00D8E442
		// (set) Token: 0x060392B7 RID: 234167 RVA: 0x00D9024A File Offset: 0x00D8E44A
		public string PlayerDesc { get; set; }

		// Token: 0x170089D5 RID: 35285
		// (get) Token: 0x060392B8 RID: 234168 RVA: 0x00D90253 File Offset: 0x00D8E453
		// (set) Token: 0x060392B9 RID: 234169 RVA: 0x00D9025B File Offset: 0x00D8E45B
		public string PlayerName { get; set; }

		// Token: 0x170089D6 RID: 35286
		// (get) Token: 0x060392BA RID: 234170 RVA: 0x00D90264 File Offset: 0x00D8E464
		// (set) Token: 0x060392BB RID: 234171 RVA: 0x00D9026C File Offset: 0x00D8E46C
		public string PlayerIndexPath { get; set; }

		// Token: 0x170089D7 RID: 35287
		// (get) Token: 0x060392BC RID: 234172 RVA: 0x00D90275 File Offset: 0x00D8E475
		// (set) Token: 0x060392BD RID: 234173 RVA: 0x00D9027D File Offset: 0x00D8E47D
		public string PlayerIconPath { get; set; }

		// Token: 0x170089D8 RID: 35288
		// (get) Token: 0x060392BE RID: 234174 RVA: 0x00D90286 File Offset: 0x00D8E486
		// (set) Token: 0x060392BF RID: 234175 RVA: 0x00D9028E File Offset: 0x00D8E48E
		public int PlayerId { get; set; }

		// Token: 0x170089D9 RID: 35289
		// (get) Token: 0x060392C0 RID: 234176 RVA: 0x00D90297 File Offset: 0x00D8E497
		// (set) Token: 0x060392C1 RID: 234177 RVA: 0x00D9029F File Offset: 0x00D8E49F
		public int PlayerLevel { get; set; }

		// Token: 0x170089DA RID: 35290
		// (get) Token: 0x060392C2 RID: 234178 RVA: 0x00D902A8 File Offset: 0x00D8E4A8
		// (set) Token: 0x060392C3 RID: 234179 RVA: 0x00D902B0 File Offset: 0x00D8E4B0
		public bool IsMyFriend { get; set; }

		// Token: 0x170089DB RID: 35291
		// (get) Token: 0x060392C4 RID: 234180 RVA: 0x00D902B9 File Offset: 0x00D8E4B9
		// (set) Token: 0x060392C5 RID: 234181 RVA: 0x00D902C1 File Offset: 0x00D8E4C1
		public Action<int> OnClickCallback { get; set; }
	}
}
