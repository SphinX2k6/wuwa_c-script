using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002229 RID: 8745
	[NullableContext(2)]
	[Nullable(0)]
	public class SwitchDataLayers_SetValue
	{
		// Token: 0x04007272 RID: 29298
		[Nullable(1)]
		public List<int> LoadDataLayers;

		// Token: 0x04007273 RID: 29299
		[Nullable(1)]
		public List<int> UnloadDataLayers;

		// Token: 0x04007274 RID: 29300
		public ISwitchDataLayersTransitionWithSequence TransitionOption;

		// Token: 0x04007275 RID: 29301
		public string MaterialDataForLoadedLayers;

		// Token: 0x04007276 RID: 29302
		public string MaterialDataForUnloadLayers;
	}
}
