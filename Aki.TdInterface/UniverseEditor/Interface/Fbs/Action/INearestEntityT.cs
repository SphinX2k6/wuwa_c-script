using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DB RID: 29403
	public class INearestEntityT
	{
		// Token: 0x1700D799 RID: 55193
		// (get) Token: 0x06033441 RID: 209985 RVA: 0x006EA663 File Offset: 0x006E8863
		// (set) Token: 0x06033442 RID: 209986 RVA: 0x006EA66B File Offset: 0x006E886B
		public ETeleportType Type { get; set; }

		// Token: 0x1700D79A RID: 55194
		// (get) Token: 0x06033443 RID: 209987 RVA: 0x006EA674 File Offset: 0x006E8874
		// (set) Token: 0x06033444 RID: 209988 RVA: 0x006EA67C File Offset: 0x006E887C
		public List<int> EntityIds { get; set; }

		// Token: 0x06033445 RID: 209989 RVA: 0x006EA685 File Offset: 0x006E8885
		public INearestEntityT()
		{
			this.Type = ETeleportType.FixedPos;
			this.EntityIds = null;
		}
	}
}
