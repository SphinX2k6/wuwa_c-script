using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036D6 RID: 14038
	[NullableContext(1)]
	public interface IAreaExploreInfoData
	{
		// Token: 0x17004AE4 RID: 19172
		// (get) Token: 0x06024774 RID: 149364
		// (set) Token: 0x06024775 RID: 149365
		int AreaId { get; set; }

		// Token: 0x17004AE5 RID: 19173
		// (get) Token: 0x06024776 RID: 149366
		// (set) Token: 0x06024777 RID: 149367
		List<IOneExploreItemData> ExploreProgress { get; set; }

		// Token: 0x17004AE6 RID: 19174
		// (get) Token: 0x06024778 RID: 149368
		// (set) Token: 0x06024779 RID: 149369
		float ExplorePercent { get; set; }
	}
}
