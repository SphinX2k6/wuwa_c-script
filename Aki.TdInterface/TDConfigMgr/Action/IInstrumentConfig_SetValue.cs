using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3A RID: 6970
	public class IInstrumentConfig_SetValue
	{
		// Token: 0x04005B4B RID: 23371
		public int Id;

		// Token: 0x04005B4C RID: 23372
		public EInstrumentType InstrumentType;

		// Token: 0x04005B4D RID: 23373
		[Nullable(1)]
		public IInstrumentKeyConfigs KeyConfigs;
	}
}
