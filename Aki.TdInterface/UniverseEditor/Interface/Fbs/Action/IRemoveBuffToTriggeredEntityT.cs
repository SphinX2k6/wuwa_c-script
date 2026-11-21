using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BF RID: 30143
	public class IRemoveBuffToTriggeredEntityT
	{
		// Token: 0x1700DDA0 RID: 56736
		// (get) Token: 0x06034E28 RID: 216616 RVA: 0x0071B9B1 File Offset: 0x00719BB1
		// (set) Token: 0x06034E29 RID: 216617 RVA: 0x0071B9B9 File Offset: 0x00719BB9
		public List<long> BuffIds { get; set; }

		// Token: 0x06034E2A RID: 216618 RVA: 0x0071B9C2 File Offset: 0x00719BC2
		public IRemoveBuffToTriggeredEntityT()
		{
			this.BuffIds = null;
		}
	}
}
