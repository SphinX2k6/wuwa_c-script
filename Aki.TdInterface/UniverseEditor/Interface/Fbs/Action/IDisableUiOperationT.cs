using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F8 RID: 26104
	public class IDisableUiOperationT
	{
		// Token: 0x1700C1F5 RID: 49653
		// (get) Token: 0x0602D511 RID: 185617 RVA: 0x00635E92 File Offset: 0x00634092
		// (set) Token: 0x0602D512 RID: 185618 RVA: 0x00635E9A File Offset: 0x0063409A
		public EUiOperationType Type { get; set; }

		// Token: 0x0602D513 RID: 185619 RVA: 0x00635EA3 File Offset: 0x006340A3
		public IDisableUiOperationT()
		{
			this.Type = EUiOperationType.Enable;
		}
	}
}
