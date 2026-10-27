using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B40 RID: 6976
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentQteConfig_SetValue
	{
		// Token: 0x04005B5F RID: 23391
		public int Id;

		// Token: 0x04005B60 RID: 23392
		public EInstrumentType InstrumentType;

		// Token: 0x04005B61 RID: 23393
		public string Description;

		// Token: 0x04005B62 RID: 23394
		public List<List<int>> QteSequence;

		// Token: 0x04005B63 RID: 23395
		public string PreludeAsset;
	}
}
