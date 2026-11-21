using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F12 RID: 20242
	[NullableContext(1)]
	public interface IWheelTowerBossAttrData
	{
		// Token: 0x170062EA RID: 25322
		// (get) Token: 0x06032DEA RID: 208362
		// (set) Token: 0x06032DEB RID: 208363
		string AttrName { get; set; }

		// Token: 0x170062EB RID: 25323
		// (get) Token: 0x06032DEC RID: 208364
		// (set) Token: 0x06032DED RID: 208365
		int AttrLevel { get; set; }

		// Token: 0x170062EC RID: 25324
		// (get) Token: 0x06032DEE RID: 208366
		// (set) Token: 0x06032DEF RID: 208367
		int ElementId { get; set; }

		// Token: 0x170062ED RID: 25325
		// (get) Token: 0x06032DF0 RID: 208368
		// (set) Token: 0x06032DF1 RID: 208369
		List<int> TagIdList { get; set; }
	}
}
