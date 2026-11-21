using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B25 RID: 31525
	public class ITalkOptionQteSucceedDelayExecT
	{
		// Token: 0x1700EC1B RID: 60443
		// (get) Token: 0x06038C3B RID: 232507 RVA: 0x007AD3D6 File Offset: 0x007AB5D6
		// (set) Token: 0x06038C3C RID: 232508 RVA: 0x007AD3DE File Offset: 0x007AB5DE
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x06038C3D RID: 232509 RVA: 0x007AD3E7 File Offset: 0x007AB5E7
		public ITalkOptionQteSucceedDelayExecT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
