using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007089 RID: 28809
	public class ISetTeleControlT
	{
		// Token: 0x1700D617 RID: 54807
		// (get) Token: 0x0603303D RID: 208957 RVA: 0x006E1AED File Offset: 0x006DFCED
		// (set) Token: 0x0603303E RID: 208958 RVA: 0x006E1AF5 File Offset: 0x006DFCF5
		public TSetTeleControlConfigUnion Config { get; set; }

		// Token: 0x0603303F RID: 208959 RVA: 0x006E1AFE File Offset: 0x006DFCFE
		public ISetTeleControlT()
		{
			this.Config = null;
		}
	}
}
