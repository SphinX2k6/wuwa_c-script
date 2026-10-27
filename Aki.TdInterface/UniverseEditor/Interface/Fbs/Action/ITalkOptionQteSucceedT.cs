using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734A RID: 29514
	public class ITalkOptionQteSucceedT
	{
		// Token: 0x1700E01C RID: 57372
		// (get) Token: 0x060358F6 RID: 219382 RVA: 0x0074B6D6 File Offset: 0x007498D6
		// (set) Token: 0x060358F7 RID: 219383 RVA: 0x0074B6DE File Offset: 0x007498DE
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x060358F8 RID: 219384 RVA: 0x0074B6E7 File Offset: 0x007498E7
		public ITalkOptionQteSucceedT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
