using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047AC RID: 18348
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreFriendData : IRewardExploreFriendData
	{
		// Token: 0x17005D9E RID: 23966
		// (get) Token: 0x0602E1CA RID: 188874 RVA: 0x00CDF08B File Offset: 0x00CDD28B
		// (set) Token: 0x0602E1CB RID: 188875 RVA: 0x00CDF093 File Offset: 0x00CDD293
		public string PlayerDesc { get; set; }

		// Token: 0x17005D9F RID: 23967
		// (get) Token: 0x0602E1CC RID: 188876 RVA: 0x00CDF09C File Offset: 0x00CDD29C
		// (set) Token: 0x0602E1CD RID: 188877 RVA: 0x00CDF0A4 File Offset: 0x00CDD2A4
		public string PlayerName { get; set; }

		// Token: 0x17005DA0 RID: 23968
		// (get) Token: 0x0602E1CE RID: 188878 RVA: 0x00CDF0AD File Offset: 0x00CDD2AD
		// (set) Token: 0x0602E1CF RID: 188879 RVA: 0x00CDF0B5 File Offset: 0x00CDD2B5
		public string PlayerIndexPath { get; set; }

		// Token: 0x17005DA1 RID: 23969
		// (get) Token: 0x0602E1D0 RID: 188880 RVA: 0x00CDF0BE File Offset: 0x00CDD2BE
		// (set) Token: 0x0602E1D1 RID: 188881 RVA: 0x00CDF0C6 File Offset: 0x00CDD2C6
		public string PlayerIconPath { get; set; }

		// Token: 0x17005DA2 RID: 23970
		// (get) Token: 0x0602E1D2 RID: 188882 RVA: 0x00CDF0CF File Offset: 0x00CDD2CF
		// (set) Token: 0x0602E1D3 RID: 188883 RVA: 0x00CDF0D7 File Offset: 0x00CDD2D7
		public int PlayerId { get; set; }

		// Token: 0x17005DA3 RID: 23971
		// (get) Token: 0x0602E1D4 RID: 188884 RVA: 0x00CDF0E0 File Offset: 0x00CDD2E0
		// (set) Token: 0x0602E1D5 RID: 188885 RVA: 0x00CDF0E8 File Offset: 0x00CDD2E8
		public int PlayerLevel { get; set; }

		// Token: 0x17005DA4 RID: 23972
		// (get) Token: 0x0602E1D6 RID: 188886 RVA: 0x00CDF0F1 File Offset: 0x00CDD2F1
		// (set) Token: 0x0602E1D7 RID: 188887 RVA: 0x00CDF0F9 File Offset: 0x00CDD2F9
		public bool IsMyFriend { get; set; }

		// Token: 0x17005DA5 RID: 23973
		// (get) Token: 0x0602E1D8 RID: 188888 RVA: 0x00CDF102 File Offset: 0x00CDD302
		// (set) Token: 0x0602E1D9 RID: 188889 RVA: 0x00CDF10A File Offset: 0x00CDD30A
		public Action<int> OnClickCallback { get; set; }
	}
}
