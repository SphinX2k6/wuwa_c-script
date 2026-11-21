using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CEF RID: 7407
	public class IInstrumentQteConfig_SetValue
	{
		// Token: 0x04005FFD RID: 24573
		public int Id;

		// Token: 0x04005FFE RID: 24574
		public EInstrumentType InstrumentType;

		// Token: 0x04005FFF RID: 24575
		public string Description;

		// Token: 0x04006000 RID: 24576
		public List<List<int>> QteSequence;

		// Token: 0x04006001 RID: 24577
		public string PreludeAsset;
	}
}
