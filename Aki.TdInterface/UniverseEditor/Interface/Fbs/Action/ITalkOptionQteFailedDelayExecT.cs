using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B1F RID: 31519
	public class ITalkOptionQteFailedDelayExecT
	{
		// Token: 0x1700EC15 RID: 60437
		// (get) Token: 0x06038C17 RID: 232471 RVA: 0x007AD0E6 File Offset: 0x007AB2E6
		// (set) Token: 0x06038C18 RID: 232472 RVA: 0x007AD0EE File Offset: 0x007AB2EE
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x06038C19 RID: 232473 RVA: 0x007AD0F7 File Offset: 0x007AB2F7
		public ITalkOptionQteFailedDelayExecT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
