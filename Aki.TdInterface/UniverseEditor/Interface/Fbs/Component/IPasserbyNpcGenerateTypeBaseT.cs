using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C7F RID: 23679
	public class IPasserbyNpcGenerateTypeBaseT
	{
		// Token: 0x1700ADFE RID: 44542
		// (get) Token: 0x06027489 RID: 160905 RVA: 0x005613C2 File Offset: 0x0055F5C2
		// (set) Token: 0x0602748A RID: 160906 RVA: 0x005613CA File Offset: 0x0055F5CA
		public EPasserbyNpcGenerateType Type { get; set; }

		// Token: 0x0602748B RID: 160907 RVA: 0x005613D3 File Offset: 0x0055F5D3
		public IPasserbyNpcGenerateTypeBaseT()
		{
			this.Type = EPasserbyNpcGenerateType.RandomStand;
		}
	}
}
