using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057DE RID: 22494
	[NullableContext(1)]
	public interface IDangoAbyssSuccessData
	{
		// Token: 0x170089E8 RID: 35304
		// (get) Token: 0x060392E3 RID: 234211
		// (set) Token: 0x060392E4 RID: 234212
		List<RewardItemData> RewardItemData { get; set; }

		// Token: 0x170089E9 RID: 35305
		// (get) Token: 0x060392E5 RID: 234213
		// (set) Token: 0x060392E6 RID: 234214
		float Progress { get; set; }
	}
}
