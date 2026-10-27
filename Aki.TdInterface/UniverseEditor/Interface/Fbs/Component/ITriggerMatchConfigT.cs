using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AEB RID: 23275
	public class ITriggerMatchConfigT
	{
		// Token: 0x1700AF92 RID: 44946
		// (get) Token: 0x06027BAC RID: 162732 RVA: 0x00577291 File Offset: 0x00575491
		// (set) Token: 0x06027BAD RID: 162733 RVA: 0x00577299 File Offset: 0x00575499
		public TEntityMatchUnion EntityMatch { get; set; }

		// Token: 0x1700AF93 RID: 44947
		// (get) Token: 0x06027BAE RID: 162734 RVA: 0x005772A2 File Offset: 0x005754A2
		// (set) Token: 0x06027BAF RID: 162735 RVA: 0x005772AA File Offset: 0x005754AA
		public int EntityMatchCount { get; set; }

		// Token: 0x1700AF94 RID: 44948
		// (get) Token: 0x06027BB0 RID: 162736 RVA: 0x005772B3 File Offset: 0x005754B3
		// (set) Token: 0x06027BB1 RID: 162737 RVA: 0x005772BB File Offset: 0x005754BB
		public byte NullMask { get; set; }

		// Token: 0x06027BB2 RID: 162738 RVA: 0x005772C4 File Offset: 0x005754C4
		public ITriggerMatchConfigT()
		{
			this.EntityMatch = null;
			this.EntityMatchCount = 0;
			this.NullMask = 0;
		}
	}
}
