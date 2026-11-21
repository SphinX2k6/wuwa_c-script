using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF5 RID: 24053
	public class IRandomNpcRuleT
	{
		// Token: 0x1700B146 RID: 45382
		// (get) Token: 0x06028268 RID: 164456 RVA: 0x0057DC43 File Offset: 0x0057BE43
		// (set) Token: 0x06028269 RID: 164457 RVA: 0x0057DC4B File Offset: 0x0057BE4B
		public ERefreshRule Type { get; set; }

		// Token: 0x1700B147 RID: 45383
		// (get) Token: 0x0602826A RID: 164458 RVA: 0x0057DC54 File Offset: 0x0057BE54
		// (set) Token: 0x0602826B RID: 164459 RVA: 0x0057DC5C File Offset: 0x0057BE5C
		public List<IFixedDateTimeT> DateTimeList { get; set; }

		// Token: 0x1700B148 RID: 45384
		// (get) Token: 0x0602826C RID: 164460 RVA: 0x0057DC65 File Offset: 0x0057BE65
		// (set) Token: 0x0602826D RID: 164461 RVA: 0x0057DC6D File Offset: 0x0057BE6D
		public IProbabilityRefreshGroupT ProbabilityRefreshGroup { get; set; }

		// Token: 0x0602826E RID: 164462 RVA: 0x0057DC76 File Offset: 0x0057BE76
		public IRandomNpcRuleT()
		{
			this.Type = ERefreshRule.CD;
			this.DateTimeList = null;
			this.ProbabilityRefreshGroup = null;
		}
	}
}
