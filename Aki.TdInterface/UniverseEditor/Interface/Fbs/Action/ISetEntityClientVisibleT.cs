using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A7 RID: 30631
	public class ISetEntityClientVisibleT
	{
		// Token: 0x1700E073 RID: 57459
		// (get) Token: 0x06035C76 RID: 220278 RVA: 0x0073478F File Offset: 0x0073298F
		// (set) Token: 0x06035C77 RID: 220279 RVA: 0x00734797 File Offset: 0x00732997
		public List<int> EntityIds { get; set; }

		// Token: 0x1700E074 RID: 57460
		// (get) Token: 0x06035C78 RID: 220280 RVA: 0x007347A0 File Offset: 0x007329A0
		// (set) Token: 0x06035C79 RID: 220281 RVA: 0x007347A8 File Offset: 0x007329A8
		public bool Visible { get; set; }

		// Token: 0x06035C7A RID: 220282 RVA: 0x007347B1 File Offset: 0x007329B1
		public ISetEntityClientVisibleT()
		{
			this.EntityIds = null;
			this.Visible = false;
		}
	}
}
