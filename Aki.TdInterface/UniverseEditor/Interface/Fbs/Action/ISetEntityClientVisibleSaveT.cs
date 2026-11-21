using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AA RID: 30634
	public class ISetEntityClientVisibleSaveT
	{
		// Token: 0x1700E078 RID: 57464
		// (get) Token: 0x06035C94 RID: 220308 RVA: 0x00734ABF File Offset: 0x00732CBF
		// (set) Token: 0x06035C95 RID: 220309 RVA: 0x00734AC7 File Offset: 0x00732CC7
		public List<int> EntityIds { get; set; }

		// Token: 0x1700E079 RID: 57465
		// (get) Token: 0x06035C96 RID: 220310 RVA: 0x00734AD0 File Offset: 0x00732CD0
		// (set) Token: 0x06035C97 RID: 220311 RVA: 0x00734AD8 File Offset: 0x00732CD8
		public bool Visible { get; set; }

		// Token: 0x06035C98 RID: 220312 RVA: 0x00734AE1 File Offset: 0x00732CE1
		public ISetEntityClientVisibleSaveT()
		{
			this.EntityIds = null;
			this.Visible = false;
		}
	}
}
