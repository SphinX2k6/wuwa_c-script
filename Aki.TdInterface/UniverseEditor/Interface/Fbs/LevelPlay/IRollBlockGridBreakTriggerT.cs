using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004564 RID: 17764
	public class IRollBlockGridBreakTriggerT
	{
		// Token: 0x17007E0B RID: 32267
		// (get) Token: 0x0601AC39 RID: 109625 RVA: 0x003D14D9 File Offset: 0x003CF6D9
		// (set) Token: 0x0601AC3A RID: 109626 RVA: 0x003D14E1 File Offset: 0x003CF6E1
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E0C RID: 32268
		// (get) Token: 0x0601AC3B RID: 109627 RVA: 0x003D14EA File Offset: 0x003CF6EA
		// (set) Token: 0x0601AC3C RID: 109628 RVA: 0x003D14F2 File Offset: 0x003CF6F2
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E0D RID: 32269
		// (get) Token: 0x0601AC3D RID: 109629 RVA: 0x003D14FB File Offset: 0x003CF6FB
		// (set) Token: 0x0601AC3E RID: 109630 RVA: 0x003D1503 File Offset: 0x003CF703
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E0E RID: 32270
		// (get) Token: 0x0601AC3F RID: 109631 RVA: 0x003D150C File Offset: 0x003CF70C
		// (set) Token: 0x0601AC40 RID: 109632 RVA: 0x003D1514 File Offset: 0x003CF714
		public int Key { get; set; }

		// Token: 0x17007E0F RID: 32271
		// (get) Token: 0x0601AC41 RID: 109633 RVA: 0x003D151D File Offset: 0x003CF71D
		// (set) Token: 0x0601AC42 RID: 109634 RVA: 0x003D1525 File Offset: 0x003CF725
		public byte NullMask { get; set; }

		// Token: 0x0601AC43 RID: 109635 RVA: 0x003D152E File Offset: 0x003CF72E
		public IRollBlockGridBreakTriggerT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.Key = 0;
			this.NullMask = 0;
		}
	}
}
