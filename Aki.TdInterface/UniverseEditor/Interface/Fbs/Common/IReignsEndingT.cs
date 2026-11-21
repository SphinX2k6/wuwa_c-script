using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006492 RID: 25746
	public class IReignsEndingT
	{
		// Token: 0x1700BDF8 RID: 48632
		// (get) Token: 0x0602BC33 RID: 179251 RVA: 0x005F42F4 File Offset: 0x005F24F4
		// (set) Token: 0x0602BC34 RID: 179252 RVA: 0x005F42FC File Offset: 0x005F24FC
		public bool IsSuccess { get; set; }

		// Token: 0x1700BDF9 RID: 48633
		// (get) Token: 0x0602BC35 RID: 179253 RVA: 0x005F4305 File Offset: 0x005F2505
		// (set) Token: 0x0602BC36 RID: 179254 RVA: 0x005F430D File Offset: 0x005F250D
		public IReignsEndingConditionT Conditions { get; set; }

		// Token: 0x1700BDFA RID: 48634
		// (get) Token: 0x0602BC37 RID: 179255 RVA: 0x005F4316 File Offset: 0x005F2516
		// (set) Token: 0x0602BC38 RID: 179256 RVA: 0x005F431E File Offset: 0x005F251E
		public int CardId { get; set; }

		// Token: 0x1700BDFB RID: 48635
		// (get) Token: 0x0602BC39 RID: 179257 RVA: 0x005F4327 File Offset: 0x005F2527
		// (set) Token: 0x0602BC3A RID: 179258 RVA: 0x005F432F File Offset: 0x005F252F
		public List<int> CardIds { get; set; }

		// Token: 0x0602BC3B RID: 179259 RVA: 0x005F4338 File Offset: 0x005F2538
		public IReignsEndingT()
		{
			this.IsSuccess = false;
			this.Conditions = null;
			this.CardId = 0;
			this.CardIds = null;
		}
	}
}
