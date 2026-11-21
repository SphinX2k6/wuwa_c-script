using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004215 RID: 16917
	public class IDisableUroT
	{
		// Token: 0x17007338 RID: 29496
		// (get) Token: 0x060177F6 RID: 96246 RVA: 0x0035AE0F File Offset: 0x0035900F
		// (set) Token: 0x060177F7 RID: 96247 RVA: 0x0035AE17 File Offset: 0x00359017
		public ELogicProgramSpecialProcess Type { get; set; }

		// Token: 0x17007339 RID: 29497
		// (get) Token: 0x060177F8 RID: 96248 RVA: 0x0035AE20 File Offset: 0x00359020
		// (set) Token: 0x060177F9 RID: 96249 RVA: 0x0035AE28 File Offset: 0x00359028
		public List<int> EntityIds { get; set; }

		// Token: 0x060177FA RID: 96250 RVA: 0x0035AE31 File Offset: 0x00359031
		public IDisableUroT()
		{
			this.Type = ELogicProgramSpecialProcess.DisableURO;
			this.EntityIds = null;
		}
	}
}
