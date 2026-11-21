using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CBC RID: 19644
	public class IDisableEntitiesT
	{
		// Token: 0x17008B46 RID: 35654
		// (get) Token: 0x0601E29D RID: 123549 RVA: 0x00439F47 File Offset: 0x00438147
		// (set) Token: 0x0601E29E RID: 123550 RVA: 0x00439F4F File Offset: 0x0043814F
		public bool IsDisabled { get; set; }

		// Token: 0x17008B47 RID: 35655
		// (get) Token: 0x0601E29F RID: 123551 RVA: 0x00439F58 File Offset: 0x00438158
		// (set) Token: 0x0601E2A0 RID: 123552 RVA: 0x00439F60 File Offset: 0x00438160
		public List<int> EntityIds { get; set; }

		// Token: 0x0601E2A1 RID: 123553 RVA: 0x00439F69 File Offset: 0x00438169
		public IDisableEntitiesT()
		{
			this.IsDisabled = false;
			this.EntityIds = null;
		}
	}
}
