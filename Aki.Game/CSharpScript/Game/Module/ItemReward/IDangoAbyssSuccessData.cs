using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047B5 RID: 18357
	[NullableContext(1)]
	public interface IDangoAbyssSuccessData
	{
		// Token: 0x17005DB2 RID: 23986
		// (get) Token: 0x0602E1F7 RID: 188919
		// (set) Token: 0x0602E1F8 RID: 188920
		List<RewardItemData> RewardItemData { get; set; }

		// Token: 0x17005DB3 RID: 23987
		// (get) Token: 0x0602E1F9 RID: 188921
		// (set) Token: 0x0602E1FA RID: 188922
		float Progress { get; set; }
	}
}
