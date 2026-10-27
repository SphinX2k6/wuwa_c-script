using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EE RID: 22510
	public class IRandomNpcRuleT
	{
		// Token: 0x1700A822 RID: 43042
		// (get) Token: 0x06025D48 RID: 154952 RVA: 0x00537AB7 File Offset: 0x00535CB7
		// (set) Token: 0x06025D49 RID: 154953 RVA: 0x00537ABF File Offset: 0x00535CBF
		public ERefreshRule Type { get; set; }

		// Token: 0x1700A823 RID: 43043
		// (get) Token: 0x06025D4A RID: 154954 RVA: 0x00537AC8 File Offset: 0x00535CC8
		// (set) Token: 0x06025D4B RID: 154955 RVA: 0x00537AD0 File Offset: 0x00535CD0
		public List<IFixedDateTimeT> DateTimeList { get; set; }

		// Token: 0x1700A824 RID: 43044
		// (get) Token: 0x06025D4C RID: 154956 RVA: 0x00537AD9 File Offset: 0x00535CD9
		// (set) Token: 0x06025D4D RID: 154957 RVA: 0x00537AE1 File Offset: 0x00535CE1
		public IProbabilityRefreshGroupT ProbabilityRefreshGroup { get; set; }

		// Token: 0x06025D4E RID: 154958 RVA: 0x00537AEA File Offset: 0x00535CEA
		public IRandomNpcRuleT()
		{
			this.Type = ERefreshRule.CD;
			this.DateTimeList = null;
			this.ProbabilityRefreshGroup = null;
		}
	}
}
