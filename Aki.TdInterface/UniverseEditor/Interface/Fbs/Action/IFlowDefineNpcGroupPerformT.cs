using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FF RID: 26623
	public class IFlowDefineNpcGroupPerformT
	{
		// Token: 0x1700C59D RID: 50589
		// (get) Token: 0x0602E5C8 RID: 189896 RVA: 0x0065400D File Offset: 0x0065220D
		// (set) Token: 0x0602E5C9 RID: 189897 RVA: 0x00654015 File Offset: 0x00652215
		public TFlowDefineNpcGroupPerformTypeUnion PerformType { get; set; }

		// Token: 0x0602E5CA RID: 189898 RVA: 0x0065401E File Offset: 0x0065221E
		public IFlowDefineNpcGroupPerformT()
		{
			this.PerformType = null;
		}
	}
}
