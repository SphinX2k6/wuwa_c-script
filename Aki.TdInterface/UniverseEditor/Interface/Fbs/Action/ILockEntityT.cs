using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007155 RID: 29013
	public class ILockEntityT
	{
		// Token: 0x1700D453 RID: 54355
		// (get) Token: 0x06032672 RID: 206450 RVA: 0x006D00D1 File Offset: 0x006CE2D1
		// (set) Token: 0x06032673 RID: 206451 RVA: 0x006D00D9 File Offset: 0x006CE2D9
		public List<int> EntityIds { get; set; }

		// Token: 0x06032674 RID: 206452 RVA: 0x006D00E2 File Offset: 0x006CE2E2
		public ILockEntityT()
		{
			this.EntityIds = null;
		}
	}
}
