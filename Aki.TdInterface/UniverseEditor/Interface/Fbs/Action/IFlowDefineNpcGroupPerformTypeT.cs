using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E82 RID: 28290
	public class IFlowDefineNpcGroupPerformTypeT
	{
		// Token: 0x1700CF56 RID: 53078
		// (get) Token: 0x06030E20 RID: 200224 RVA: 0x006A18FE File Offset: 0x0069FAFE
		// (set) Token: 0x06030E21 RID: 200225 RVA: 0x006A1906 File Offset: 0x0069FB06
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x06030E22 RID: 200226 RVA: 0x006A190F File Offset: 0x0069FB0F
		public IFlowDefineNpcGroupPerformTypeT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
		}
	}
}
