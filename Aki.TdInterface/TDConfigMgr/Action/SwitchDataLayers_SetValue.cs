using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002494 RID: 9364
	public class SwitchDataLayers_SetValue
	{
		// Token: 0x040078BC RID: 30908
		public List<int> LoadDataLayers;

		// Token: 0x040078BD RID: 30909
		public List<int> UnloadDataLayers;

		// Token: 0x040078BE RID: 30910
		[Nullable(2)]
		public ISwitchDataLayersTransitionWithSequence TransitionOption;

		// Token: 0x040078BF RID: 30911
		[Nullable(2)]
		public string MaterialDataForLoadedLayers;

		// Token: 0x040078C0 RID: 30912
		[Nullable(2)]
		public string MaterialDataForUnloadLayers;
	}
}
