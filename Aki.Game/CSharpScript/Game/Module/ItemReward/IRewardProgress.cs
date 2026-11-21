using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200479B RID: 18331
	public interface IRewardProgress
	{
		// Token: 0x17005D5C RID: 23900
		// (get) Token: 0x0602E13E RID: 188734
		// (set) Token: 0x0602E13F RID: 188735
		int FromProgress { get; set; }

		// Token: 0x17005D5D RID: 23901
		// (get) Token: 0x0602E140 RID: 188736
		// (set) Token: 0x0602E141 RID: 188737
		int ToProgress { get; set; }

		// Token: 0x17005D5E RID: 23902
		// (get) Token: 0x0602E142 RID: 188738
		// (set) Token: 0x0602E143 RID: 188739
		int MaxProgress { get; set; }
	}
}
