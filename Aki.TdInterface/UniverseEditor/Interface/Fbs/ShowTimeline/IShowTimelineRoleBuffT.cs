using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD1 RID: 16337
	public class IShowTimelineRoleBuffT
	{
		// Token: 0x17006EA6 RID: 28326
		// (get) Token: 0x0601654D RID: 91469 RVA: 0x00332F4F File Offset: 0x0033114F
		// (set) Token: 0x0601654E RID: 91470 RVA: 0x00332F57 File Offset: 0x00331157
		public int RoleId { get; set; }

		// Token: 0x17006EA7 RID: 28327
		// (get) Token: 0x0601654F RID: 91471 RVA: 0x00332F60 File Offset: 0x00331160
		// (set) Token: 0x06016550 RID: 91472 RVA: 0x00332F68 File Offset: 0x00331168
		public List<long> BuffIds { get; set; }

		// Token: 0x06016551 RID: 91473 RVA: 0x00332F71 File Offset: 0x00331171
		public IShowTimelineRoleBuffT()
		{
			this.RoleId = 0;
			this.BuffIds = null;
		}
	}
}
