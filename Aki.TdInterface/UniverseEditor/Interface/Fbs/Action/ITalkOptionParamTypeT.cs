using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007332 RID: 29490
	public class ITalkOptionParamTypeT
	{
		// Token: 0x1700E000 RID: 57344
		// (get) Token: 0x0603584C RID: 219212 RVA: 0x0074A6E2 File Offset: 0x007488E2
		// (set) Token: 0x0603584D RID: 219213 RVA: 0x0074A6EA File Offset: 0x007488EA
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x0603584E RID: 219214 RVA: 0x0074A6F3 File Offset: 0x007488F3
		public ITalkOptionParamTypeT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
