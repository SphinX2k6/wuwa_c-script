using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D2 RID: 20690
	[NullableContext(1)]
	public interface IRoverlikeGameShopGroupData
	{
		// Token: 0x1700650E RID: 25870
		// (get) Token: 0x06033C74 RID: 212084
		// (set) Token: 0x06033C75 RID: 212085
		ERoverlikeGameShopItemType GroupType { get; set; }

		// Token: 0x1700650F RID: 25871
		// (get) Token: 0x06033C76 RID: 212086
		// (set) Token: 0x06033C77 RID: 212087
		string TitleTextKey { get; set; }

		// Token: 0x17006510 RID: 25872
		// (get) Token: 0x06033C78 RID: 212088
		// (set) Token: 0x06033C79 RID: 212089
		List<IRoverlikeGameShopGridData> Grids { get; set; }
	}
}
