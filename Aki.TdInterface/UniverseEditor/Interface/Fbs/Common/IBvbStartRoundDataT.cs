using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D6B RID: 23915
	public class IBvbStartRoundDataT
	{
		// Token: 0x1700B321 RID: 45857
		// (get) Token: 0x06028E96 RID: 167574 RVA: 0x0059EBAA File Offset: 0x0059CDAA
		// (set) Token: 0x06028E97 RID: 167575 RVA: 0x0059EBB2 File Offset: 0x0059CDB2
		public EBvbEventName Type { get; set; }

		// Token: 0x06028E98 RID: 167576 RVA: 0x0059EBBB File Offset: 0x0059CDBB
		public IBvbStartRoundDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
