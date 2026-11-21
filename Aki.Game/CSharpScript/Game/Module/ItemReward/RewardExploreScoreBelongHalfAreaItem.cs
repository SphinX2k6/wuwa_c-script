using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A6 RID: 18342
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreScoreBelongHalfAreaItem : IRewardExploreScoreBelongHalfAreaItem
	{
		// Token: 0x17005D79 RID: 23929
		// (get) Token: 0x0602E17D RID: 188797 RVA: 0x00CDEF63 File Offset: 0x00CDD163
		// (set) Token: 0x0602E17E RID: 188798 RVA: 0x00CDEF6B File Offset: 0x00CDD16B
		public string Target { get; set; }

		// Token: 0x17005D7A RID: 23930
		// (get) Token: 0x0602E17F RID: 188799 RVA: 0x00CDEF74 File Offset: 0x00CDD174
		// (set) Token: 0x0602E180 RID: 188800 RVA: 0x00CDEF7C File Offset: 0x00CDD17C
		public string DescriptionTextId { get; set; }

		// Token: 0x17005D7B RID: 23931
		// (get) Token: 0x0602E181 RID: 188801 RVA: 0x00CDEF85 File Offset: 0x00CDD185
		// (set) Token: 0x0602E182 RID: 188802 RVA: 0x00CDEF8D File Offset: 0x00CDD18D
		public ETeamBelong Belong { get; set; }
	}
}
