using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BC RID: 30140
	public class IRemoveBuffFromPlayerT
	{
		// Token: 0x1700DD9D RID: 56733
		// (get) Token: 0x06034E0E RID: 216590 RVA: 0x0071B70D File Offset: 0x0071990D
		// (set) Token: 0x06034E0F RID: 216591 RVA: 0x0071B715 File Offset: 0x00719915
		public List<long> BuffIds { get; set; }

		// Token: 0x06034E10 RID: 216592 RVA: 0x0071B71E File Offset: 0x0071991E
		public IRemoveBuffFromPlayerT()
		{
			this.BuffIds = null;
		}
	}
}
