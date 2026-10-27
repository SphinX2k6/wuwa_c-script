using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734D RID: 29517
	public class ITalkOptionQteSucceedDelayExecT
	{
		// Token: 0x1700E01F RID: 57375
		// (get) Token: 0x06035908 RID: 219400 RVA: 0x0074B84E File Offset: 0x00749A4E
		// (set) Token: 0x06035909 RID: 219401 RVA: 0x0074B856 File Offset: 0x00749A56
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x0603590A RID: 219402 RVA: 0x0074B85F File Offset: 0x00749A5F
		public ITalkOptionQteSucceedDelayExecT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
