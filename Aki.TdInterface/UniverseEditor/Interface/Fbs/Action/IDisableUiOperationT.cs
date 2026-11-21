using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C69 RID: 27753
	public class IDisableUiOperationT
	{
		// Token: 0x1700CB93 RID: 52115
		// (get) Token: 0x0602FCE2 RID: 195810 RVA: 0x006829FA File Offset: 0x00680BFA
		// (set) Token: 0x0602FCE3 RID: 195811 RVA: 0x00682A02 File Offset: 0x00680C02
		public EUiOperationType Type { get; set; }

		// Token: 0x0602FCE4 RID: 195812 RVA: 0x00682A0B File Offset: 0x00680C0B
		public IDisableUiOperationT()
		{
			this.Type = EUiOperationType.Enable;
		}
	}
}
