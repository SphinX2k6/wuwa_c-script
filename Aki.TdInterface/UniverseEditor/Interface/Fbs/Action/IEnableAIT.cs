using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006640 RID: 26176
	public class IEnableAIT
	{
		// Token: 0x1700C27D RID: 49789
		// (get) Token: 0x0602D775 RID: 186229 RVA: 0x0063A477 File Offset: 0x00638677
		// (set) Token: 0x0602D776 RID: 186230 RVA: 0x0063A47F File Offset: 0x0063867F
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C27E RID: 49790
		// (get) Token: 0x0602D777 RID: 186231 RVA: 0x0063A488 File Offset: 0x00638688
		// (set) Token: 0x0602D778 RID: 186232 RVA: 0x0063A490 File Offset: 0x00638690
		public bool IsEnable { get; set; }

		// Token: 0x0602D779 RID: 186233 RVA: 0x0063A499 File Offset: 0x00638699
		public IEnableAIT()
		{
			this.EntityIds = null;
			this.IsEnable = false;
		}
	}
}
