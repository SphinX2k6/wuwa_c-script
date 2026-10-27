using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8B RID: 28555
	public class IServerForceEnableLevelPlayT
	{
		// Token: 0x1700D419 RID: 54297
		// (get) Token: 0x0603276C RID: 206700 RVA: 0x006CFDB9 File Offset: 0x006CDFB9
		// (set) Token: 0x0603276D RID: 206701 RVA: 0x006CFDC1 File Offset: 0x006CDFC1
		public List<IEnableLevelPlayConfigT> Configs { get; set; }

		// Token: 0x0603276E RID: 206702 RVA: 0x006CFDCA File Offset: 0x006CDFCA
		public IServerForceEnableLevelPlayT()
		{
			this.Configs = null;
		}
	}
}
