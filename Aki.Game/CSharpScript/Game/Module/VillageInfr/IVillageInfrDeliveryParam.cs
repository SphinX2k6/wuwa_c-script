using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200380C RID: 14348
	[NullableContext(1)]
	public interface IVillageInfrDeliveryParam
	{
		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x060254BB RID: 152763
		// (set) Token: 0x060254BC RID: 152764
		EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x060254BD RID: 152765
		// (set) Token: 0x060254BE RID: 152766
		int SelectId { get; set; }

		// Token: 0x17004CA8 RID: 19624
		// (get) Token: 0x060254BF RID: 152767
		// (set) Token: 0x060254C0 RID: 152768
		string UiCameraName { get; set; }
	}
}
