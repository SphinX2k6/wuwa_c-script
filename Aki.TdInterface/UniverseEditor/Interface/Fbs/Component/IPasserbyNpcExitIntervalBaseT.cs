using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C67 RID: 23655
	public class IPasserbyNpcExitIntervalBaseT
	{
		// Token: 0x1700ADDD RID: 44509
		// (get) Token: 0x060273F3 RID: 160755 RVA: 0x00560596 File Offset: 0x0055E796
		// (set) Token: 0x060273F4 RID: 160756 RVA: 0x0056059E File Offset: 0x0055E79E
		public EPasserbyNpcExitIntervalType Type { get; set; }

		// Token: 0x060273F5 RID: 160757 RVA: 0x005605A7 File Offset: 0x0055E7A7
		public IPasserbyNpcExitIntervalBaseT()
		{
			this.Type = EPasserbyNpcExitIntervalType.PerNpcRandom;
		}
	}
}
