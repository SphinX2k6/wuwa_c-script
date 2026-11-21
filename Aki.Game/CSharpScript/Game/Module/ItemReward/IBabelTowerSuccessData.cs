using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047B3 RID: 18355
	[NullableContext(1)]
	public interface IBabelTowerSuccessData
	{
		// Token: 0x17005DAA RID: 23978
		// (get) Token: 0x0602E1E6 RID: 188902
		// (set) Token: 0x0602E1E7 RID: 188903
		List<int> NewBabelBuffIds { get; set; }

		// Token: 0x17005DAB RID: 23979
		// (get) Token: 0x0602E1E8 RID: 188904
		// (set) Token: 0x0602E1E9 RID: 188905
		List<int> NewBabelDeTermIds { get; set; }

		// Token: 0x17005DAC RID: 23980
		// (get) Token: 0x0602E1EA RID: 188906
		// (set) Token: 0x0602E1EB RID: 188907
		TableTextArgNew StarTextParam { get; set; }

		// Token: 0x17005DAD RID: 23981
		// (get) Token: 0x0602E1EC RID: 188908
		// (set) Token: 0x0602E1ED RID: 188909
		string TipTextId { get; set; }
	}
}
