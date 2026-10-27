using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200456A RID: 17770
	public class IRollBlockGridFallFloorT
	{
		// Token: 0x17007E20 RID: 32288
		// (get) Token: 0x0601AC9F RID: 109727 RVA: 0x003D2653 File Offset: 0x003D0853
		// (set) Token: 0x0601ACA0 RID: 109728 RVA: 0x003D265B File Offset: 0x003D085B
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E21 RID: 32289
		// (get) Token: 0x0601ACA1 RID: 109729 RVA: 0x003D2664 File Offset: 0x003D0864
		// (set) Token: 0x0601ACA2 RID: 109730 RVA: 0x003D266C File Offset: 0x003D086C
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E22 RID: 32290
		// (get) Token: 0x0601ACA3 RID: 109731 RVA: 0x003D2675 File Offset: 0x003D0875
		// (set) Token: 0x0601ACA4 RID: 109732 RVA: 0x003D267D File Offset: 0x003D087D
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E23 RID: 32291
		// (get) Token: 0x0601ACA5 RID: 109733 RVA: 0x003D2686 File Offset: 0x003D0886
		// (set) Token: 0x0601ACA6 RID: 109734 RVA: 0x003D268E File Offset: 0x003D088E
		public byte NullMask { get; set; }

		// Token: 0x0601ACA7 RID: 109735 RVA: 0x003D2697 File Offset: 0x003D0897
		public IRollBlockGridFallFloorT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
