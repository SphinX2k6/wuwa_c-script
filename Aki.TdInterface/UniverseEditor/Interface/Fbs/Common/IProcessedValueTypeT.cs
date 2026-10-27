using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E46 RID: 24134
	public class IProcessedValueTypeT
	{
		// Token: 0x1700B473 RID: 46195
		// (get) Token: 0x0602950F RID: 169231 RVA: 0x005AA29A File Offset: 0x005A849A
		// (set) Token: 0x06029510 RID: 169232 RVA: 0x005AA2A2 File Offset: 0x005A84A2
		public EProcessedValueType Type { get; set; }

		// Token: 0x06029511 RID: 169233 RVA: 0x005AA2AB File Offset: 0x005A84AB
		public IProcessedValueTypeT()
		{
			this.Type = EProcessedValueType.Constant;
		}
	}
}
