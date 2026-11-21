using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B19 RID: 31513
	public class ITalkOptionPreOptionT
	{
		// Token: 0x1700EC0E RID: 60430
		// (get) Token: 0x06038BF1 RID: 232433 RVA: 0x007ACDD3 File Offset: 0x007AAFD3
		// (set) Token: 0x06038BF2 RID: 232434 RVA: 0x007ACDDB File Offset: 0x007AAFDB
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x1700EC0F RID: 60431
		// (get) Token: 0x06038BF3 RID: 232435 RVA: 0x007ACDE4 File Offset: 0x007AAFE4
		// (set) Token: 0x06038BF4 RID: 232436 RVA: 0x007ACDEC File Offset: 0x007AAFEC
		public List<int> PreOptions { get; set; }

		// Token: 0x06038BF5 RID: 232437 RVA: 0x007ACDF5 File Offset: 0x007AAFF5
		public ITalkOptionPreOptionT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
			this.PreOptions = null;
		}
	}
}
