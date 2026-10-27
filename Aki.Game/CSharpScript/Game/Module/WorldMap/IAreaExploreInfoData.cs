using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020047A5 RID: 18341
	[NullableContext(1)]
	public interface IAreaExploreInfoData
	{
		// Token: 0x17007828 RID: 30760
		// (get) Token: 0x0602FFA7 RID: 196519
		// (set) Token: 0x0602FFA8 RID: 196520
		int AreaId { get; set; }

		// Token: 0x17007829 RID: 30761
		// (get) Token: 0x0602FFA9 RID: 196521
		// (set) Token: 0x0602FFAA RID: 196522
		List<IOneExploreItemData> ExploreProgress { get; set; }

		// Token: 0x1700782A RID: 30762
		// (get) Token: 0x0602FFAB RID: 196523
		// (set) Token: 0x0602FFAC RID: 196524
		float ExplorePercent { get; set; }
	}
}
