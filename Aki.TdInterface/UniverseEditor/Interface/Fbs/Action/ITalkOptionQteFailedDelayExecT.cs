using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007347 RID: 29511
	public class ITalkOptionQteFailedDelayExecT
	{
		// Token: 0x1700E019 RID: 57369
		// (get) Token: 0x060358E4 RID: 219364 RVA: 0x0074B55E File Offset: 0x0074975E
		// (set) Token: 0x060358E5 RID: 219365 RVA: 0x0074B566 File Offset: 0x00749766
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x060358E6 RID: 219366 RVA: 0x0074B56F File Offset: 0x0074976F
		public ITalkOptionQteFailedDelayExecT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
