using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D65 RID: 23909
	public class IBvbStartAiDataT
	{
		// Token: 0x1700B31B RID: 45851
		// (get) Token: 0x06028E72 RID: 167538 RVA: 0x0059E8BA File Offset: 0x0059CABA
		// (set) Token: 0x06028E73 RID: 167539 RVA: 0x0059E8C2 File Offset: 0x0059CAC2
		public EBvbEventName Type { get; set; }

		// Token: 0x06028E74 RID: 167540 RVA: 0x0059E8CB File Offset: 0x0059CACB
		public IBvbStartAiDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
