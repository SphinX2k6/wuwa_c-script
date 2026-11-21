using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B1C RID: 31516
	public class ITalkOptionQteFailedT
	{
		// Token: 0x1700EC12 RID: 60434
		// (get) Token: 0x06038C05 RID: 232453 RVA: 0x007ACF6E File Offset: 0x007AB16E
		// (set) Token: 0x06038C06 RID: 232454 RVA: 0x007ACF76 File Offset: 0x007AB176
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x06038C07 RID: 232455 RVA: 0x007ACF7F File Offset: 0x007AB17F
		public ITalkOptionQteFailedT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
