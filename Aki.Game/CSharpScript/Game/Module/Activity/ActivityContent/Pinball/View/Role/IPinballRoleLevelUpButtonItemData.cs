using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005290 RID: 21136
	[NullableContext(1)]
	public interface IPinballRoleLevelUpButtonItemData
	{
		// Token: 0x17006640 RID: 26176
		// (get) Token: 0x060349B3 RID: 215475
		// (set) Token: 0x060349B4 RID: 215476
		int Times { get; set; }

		// Token: 0x17006641 RID: 26177
		// (get) Token: 0x060349B5 RID: 215477
		// (set) Token: 0x060349B6 RID: 215478
		bool IsToMaxLevel { get; set; }

		// Token: 0x17006642 RID: 26178
		// (get) Token: 0x060349B7 RID: 215479
		// (set) Token: 0x060349B8 RID: 215480
		Action<int> ConfirmDelegate { get; set; }

		// Token: 0x17006643 RID: 26179
		// (get) Token: 0x060349B9 RID: 215481
		// (set) Token: 0x060349BA RID: 215482
		ICostData CostItemData { get; set; }
	}
}
