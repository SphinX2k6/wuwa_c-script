using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7F RID: 28287
	public class IFlowDefineNpcGroupPerformT
	{
		// Token: 0x1700CF53 RID: 53075
		// (get) Token: 0x06030E0E RID: 200206 RVA: 0x006A1751 File Offset: 0x0069F951
		// (set) Token: 0x06030E0F RID: 200207 RVA: 0x006A1759 File Offset: 0x0069F959
		public TFlowDefineNpcGroupPerformTypeUnion PerformType { get; set; }

		// Token: 0x06030E10 RID: 200208 RVA: 0x006A1762 File Offset: 0x0069F962
		public IFlowDefineNpcGroupPerformT()
		{
			this.PerformType = null;
		}
	}
}
