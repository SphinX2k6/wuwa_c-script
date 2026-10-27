using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200658C RID: 25996
	public class IDestroyEntityT
	{
		// Token: 0x1700C113 RID: 49427
		// (get) Token: 0x0602D181 RID: 184705 RVA: 0x0062F971 File Offset: 0x0062DB71
		// (set) Token: 0x0602D182 RID: 184706 RVA: 0x0062F979 File Offset: 0x0062DB79
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C114 RID: 49428
		// (get) Token: 0x0602D183 RID: 184707 RVA: 0x0062F982 File Offset: 0x0062DB82
		// (set) Token: 0x0602D184 RID: 184708 RVA: 0x0062F98A File Offset: 0x0062DB8A
		public bool DelayDestroy { get; set; }

		// Token: 0x1700C115 RID: 49429
		// (get) Token: 0x0602D185 RID: 184709 RVA: 0x0062F993 File Offset: 0x0062DB93
		// (set) Token: 0x0602D186 RID: 184710 RVA: 0x0062F99B File Offset: 0x0062DB9B
		public byte NullMask { get; set; }

		// Token: 0x0602D187 RID: 184711 RVA: 0x0062F9A4 File Offset: 0x0062DBA4
		public IDestroyEntityT()
		{
			this.EntityIds = null;
			this.DelayDestroy = false;
			this.NullMask = 0;
		}
	}
}
