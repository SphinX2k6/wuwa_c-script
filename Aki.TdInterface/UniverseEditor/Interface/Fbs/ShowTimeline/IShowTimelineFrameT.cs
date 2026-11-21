using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FC2 RID: 16322
	public class IShowTimelineFrameT
	{
		// Token: 0x17006E83 RID: 28291
		// (get) Token: 0x060164A5 RID: 91301 RVA: 0x00331C3B File Offset: 0x0032FE3B
		// (set) Token: 0x060164A6 RID: 91302 RVA: 0x00331C43 File Offset: 0x0032FE43
		public int Frame { get; set; }

		// Token: 0x17006E84 RID: 28292
		// (get) Token: 0x060164A7 RID: 91303 RVA: 0x00331C4C File Offset: 0x0032FE4C
		// (set) Token: 0x060164A8 RID: 91304 RVA: 0x00331C54 File Offset: 0x0032FE54
		public int FrameInterval { get; set; }

		// Token: 0x17006E85 RID: 28293
		// (get) Token: 0x060164A9 RID: 91305 RVA: 0x00331C5D File Offset: 0x0032FE5D
		// (set) Token: 0x060164AA RID: 91306 RVA: 0x00331C65 File Offset: 0x0032FE65
		public List<TShowTimelineUnion> Entries { get; set; }

		// Token: 0x17006E86 RID: 28294
		// (get) Token: 0x060164AB RID: 91307 RVA: 0x00331C6E File Offset: 0x0032FE6E
		// (set) Token: 0x060164AC RID: 91308 RVA: 0x00331C76 File Offset: 0x0032FE76
		public byte NullMask { get; set; }

		// Token: 0x060164AD RID: 91309 RVA: 0x00331C7F File Offset: 0x0032FE7F
		public IShowTimelineFrameT()
		{
			this.Frame = 0;
			this.FrameInterval = 0;
			this.Entries = null;
			this.NullMask = 0;
		}
	}
}
