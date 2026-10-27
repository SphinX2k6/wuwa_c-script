using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E41 RID: 28225
	public class IRemoveBuffToTriggeredEntityT
	{
		// Token: 0x1700D251 RID: 53841
		// (get) Token: 0x06031E12 RID: 204306 RVA: 0x006C0029 File Offset: 0x006BE229
		// (set) Token: 0x06031E13 RID: 204307 RVA: 0x006C0031 File Offset: 0x006BE231
		public List<long> BuffIds { get; set; }

		// Token: 0x06031E14 RID: 204308 RVA: 0x006C003A File Offset: 0x006BE23A
		public IRemoveBuffToTriggeredEntityT()
		{
			this.BuffIds = null;
		}
	}
}
