using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007344 RID: 29508
	public class ITalkOptionQteFailedT
	{
		// Token: 0x1700E016 RID: 57366
		// (get) Token: 0x060358D2 RID: 219346 RVA: 0x0074B3E6 File Offset: 0x007495E6
		// (set) Token: 0x060358D3 RID: 219347 RVA: 0x0074B3EE File Offset: 0x007495EE
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x060358D4 RID: 219348 RVA: 0x0074B3F7 File Offset: 0x007495F7
		public ITalkOptionQteFailedT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
