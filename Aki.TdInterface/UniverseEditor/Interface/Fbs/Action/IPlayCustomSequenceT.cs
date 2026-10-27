using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDC RID: 27868
	public class IPlayCustomSequenceT
	{
		// Token: 0x1700CF8B RID: 53131
		// (get) Token: 0x0603121C RID: 201244 RVA: 0x006AAB2F File Offset: 0x006A8D2F
		// (set) Token: 0x0603121D RID: 201245 RVA: 0x006AAB37 File Offset: 0x006A8D37
		public int CustomSeqId { get; set; }

		// Token: 0x1700CF8C RID: 53132
		// (get) Token: 0x0603121E RID: 201246 RVA: 0x006AAB40 File Offset: 0x006A8D40
		// (set) Token: 0x0603121F RID: 201247 RVA: 0x006AAB48 File Offset: 0x006A8D48
		public List<int> WhoIds { get; set; }

		// Token: 0x1700CF8D RID: 53133
		// (get) Token: 0x06031220 RID: 201248 RVA: 0x006AAB51 File Offset: 0x006A8D51
		// (set) Token: 0x06031221 RID: 201249 RVA: 0x006AAB59 File Offset: 0x006A8D59
		public bool ResetCamera { get; set; }

		// Token: 0x1700CF8E RID: 53134
		// (get) Token: 0x06031222 RID: 201250 RVA: 0x006AAB62 File Offset: 0x006A8D62
		// (set) Token: 0x06031223 RID: 201251 RVA: 0x006AAB6A File Offset: 0x006A8D6A
		public byte NullMask { get; set; }

		// Token: 0x06031224 RID: 201252 RVA: 0x006AAB73 File Offset: 0x006A8D73
		public IPlayCustomSequenceT()
		{
			this.CustomSeqId = 0;
			this.WhoIds = null;
			this.ResetCamera = false;
			this.NullMask = 0;
		}
	}
}
