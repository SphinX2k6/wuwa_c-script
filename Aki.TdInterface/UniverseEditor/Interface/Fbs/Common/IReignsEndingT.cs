using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E52 RID: 24146
	public class IReignsEndingT
	{
		// Token: 0x1700B48F RID: 46223
		// (get) Token: 0x06029597 RID: 169367 RVA: 0x005AB44C File Offset: 0x005A964C
		// (set) Token: 0x06029598 RID: 169368 RVA: 0x005AB454 File Offset: 0x005A9654
		public bool IsSuccess { get; set; }

		// Token: 0x1700B490 RID: 46224
		// (get) Token: 0x06029599 RID: 169369 RVA: 0x005AB45D File Offset: 0x005A965D
		// (set) Token: 0x0602959A RID: 169370 RVA: 0x005AB465 File Offset: 0x005A9665
		public IReignsEndingConditionT Conditions { get; set; }

		// Token: 0x1700B491 RID: 46225
		// (get) Token: 0x0602959B RID: 169371 RVA: 0x005AB46E File Offset: 0x005A966E
		// (set) Token: 0x0602959C RID: 169372 RVA: 0x005AB476 File Offset: 0x005A9676
		public int CardId { get; set; }

		// Token: 0x1700B492 RID: 46226
		// (get) Token: 0x0602959D RID: 169373 RVA: 0x005AB47F File Offset: 0x005A967F
		// (set) Token: 0x0602959E RID: 169374 RVA: 0x005AB487 File Offset: 0x005A9687
		public List<int> CardIds { get; set; }

		// Token: 0x0602959F RID: 169375 RVA: 0x005AB490 File Offset: 0x005A9690
		public IReignsEndingT()
		{
			this.IsSuccess = false;
			this.Conditions = null;
			this.CardId = 0;
			this.CardIds = null;
		}
	}
}
