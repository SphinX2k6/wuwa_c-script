using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004854 RID: 18516
	public class IDisableEntitiesT
	{
		// Token: 0x170084FB RID: 34043
		// (get) Token: 0x0601CAA0 RID: 117408 RVA: 0x0040D5F7 File Offset: 0x0040B7F7
		// (set) Token: 0x0601CAA1 RID: 117409 RVA: 0x0040D5FF File Offset: 0x0040B7FF
		public bool IsDisabled { get; set; }

		// Token: 0x170084FC RID: 34044
		// (get) Token: 0x0601CAA2 RID: 117410 RVA: 0x0040D608 File Offset: 0x0040B808
		// (set) Token: 0x0601CAA3 RID: 117411 RVA: 0x0040D610 File Offset: 0x0040B810
		public List<int> EntityIds { get; set; }

		// Token: 0x0601CAA4 RID: 117412 RVA: 0x0040D619 File Offset: 0x0040B819
		public IDisableEntitiesT()
		{
			this.IsDisabled = false;
			this.EntityIds = null;
		}
	}
}
