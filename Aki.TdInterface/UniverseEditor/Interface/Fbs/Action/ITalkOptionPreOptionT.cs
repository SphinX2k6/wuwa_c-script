using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007341 RID: 29505
	public class ITalkOptionPreOptionT
	{
		// Token: 0x1700E012 RID: 57362
		// (get) Token: 0x060358BE RID: 219326 RVA: 0x0074B24B File Offset: 0x0074944B
		// (set) Token: 0x060358BF RID: 219327 RVA: 0x0074B253 File Offset: 0x00749453
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x1700E013 RID: 57363
		// (get) Token: 0x060358C0 RID: 219328 RVA: 0x0074B25C File Offset: 0x0074945C
		// (set) Token: 0x060358C1 RID: 219329 RVA: 0x0074B264 File Offset: 0x00749464
		public List<int> PreOptions { get; set; }

		// Token: 0x060358C2 RID: 219330 RVA: 0x0074B26D File Offset: 0x0074946D
		public ITalkOptionPreOptionT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
			this.PreOptions = null;
		}
	}
}
