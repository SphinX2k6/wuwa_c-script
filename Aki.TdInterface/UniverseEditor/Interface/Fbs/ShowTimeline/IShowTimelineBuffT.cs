using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB6 RID: 16310
	public class IShowTimelineBuffT
	{
		// Token: 0x17006E58 RID: 28248
		// (get) Token: 0x060163FB RID: 91131 RVA: 0x0033025C File Offset: 0x0032E45C
		// (set) Token: 0x060163FC RID: 91132 RVA: 0x00330264 File Offset: 0x0032E464
		public EShowTimelineType Type { get; set; }

		// Token: 0x17006E59 RID: 28249
		// (get) Token: 0x060163FD RID: 91133 RVA: 0x0033026D File Offset: 0x0032E46D
		// (set) Token: 0x060163FE RID: 91134 RVA: 0x00330275 File Offset: 0x0032E475
		public List<long> BuffIds { get; set; }

		// Token: 0x17006E5A RID: 28250
		// (get) Token: 0x060163FF RID: 91135 RVA: 0x0033027E File Offset: 0x0032E47E
		// (set) Token: 0x06016400 RID: 91136 RVA: 0x00330286 File Offset: 0x0032E486
		public List<IShowTimelineRoleBuffT> RoleBuffs { get; set; }

		// Token: 0x17006E5B RID: 28251
		// (get) Token: 0x06016401 RID: 91137 RVA: 0x0033028F File Offset: 0x0032E48F
		// (set) Token: 0x06016402 RID: 91138 RVA: 0x00330297 File Offset: 0x0032E497
		public byte NullMask { get; set; }

		// Token: 0x06016403 RID: 91139 RVA: 0x003302A0 File Offset: 0x0032E4A0
		public IShowTimelineBuffT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.BuffIds = null;
			this.RoleBuffs = null;
			this.NullMask = 0;
		}
	}
}
