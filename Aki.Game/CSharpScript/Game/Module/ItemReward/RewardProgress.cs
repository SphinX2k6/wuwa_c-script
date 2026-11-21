using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200479C RID: 18332
	public class RewardProgress : IRewardProgress
	{
		// Token: 0x17005D5F RID: 23903
		// (get) Token: 0x0602E144 RID: 188740 RVA: 0x00CDEE5E File Offset: 0x00CDD05E
		// (set) Token: 0x0602E145 RID: 188741 RVA: 0x00CDEE66 File Offset: 0x00CDD066
		public int FromProgress { get; set; }

		// Token: 0x17005D60 RID: 23904
		// (get) Token: 0x0602E146 RID: 188742 RVA: 0x00CDEE6F File Offset: 0x00CDD06F
		// (set) Token: 0x0602E147 RID: 188743 RVA: 0x00CDEE77 File Offset: 0x00CDD077
		public int ToProgress { get; set; }

		// Token: 0x17005D61 RID: 23905
		// (get) Token: 0x0602E148 RID: 188744 RVA: 0x00CDEE80 File Offset: 0x00CDD080
		// (set) Token: 0x0602E149 RID: 188745 RVA: 0x00CDEE88 File Offset: 0x00CDD088
		public int MaxProgress { get; set; }
	}
}
