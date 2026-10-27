using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006383 RID: 25475
	public class IClearEntityVisibleTagT
	{
		// Token: 0x1700BDF2 RID: 48626
		// (get) Token: 0x0602C109 RID: 180489 RVA: 0x0060D86D File Offset: 0x0060BA6D
		// (set) Token: 0x0602C10A RID: 180490 RVA: 0x0060D875 File Offset: 0x0060BA75
		public List<int> EntityIds { get; set; }

		// Token: 0x0602C10B RID: 180491 RVA: 0x0060D87E File Offset: 0x0060BA7E
		public IClearEntityVisibleTagT()
		{
			this.EntityIds = null;
		}
	}
}
