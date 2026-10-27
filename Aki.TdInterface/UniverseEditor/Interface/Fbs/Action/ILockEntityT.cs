using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A33 RID: 27187
	public class ILockEntityT
	{
		// Token: 0x1700C9A8 RID: 51624
		// (get) Token: 0x0602F94C RID: 194892 RVA: 0x0067A011 File Offset: 0x00678211
		// (set) Token: 0x0602F94D RID: 194893 RVA: 0x0067A019 File Offset: 0x00678219
		public List<int> EntityIds { get; set; }

		// Token: 0x0602F94E RID: 194894 RVA: 0x0067A022 File Offset: 0x00678222
		public ILockEntityT()
		{
			this.EntityIds = null;
		}
	}
}
