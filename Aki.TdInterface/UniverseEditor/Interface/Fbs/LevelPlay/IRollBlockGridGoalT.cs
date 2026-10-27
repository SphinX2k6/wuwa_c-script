using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004570 RID: 17776
	public class IRollBlockGridGoalT
	{
		// Token: 0x17007E34 RID: 32308
		// (get) Token: 0x0601AD03 RID: 109827 RVA: 0x003D37A3 File Offset: 0x003D19A3
		// (set) Token: 0x0601AD04 RID: 109828 RVA: 0x003D37AB File Offset: 0x003D19AB
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E35 RID: 32309
		// (get) Token: 0x0601AD05 RID: 109829 RVA: 0x003D37B4 File Offset: 0x003D19B4
		// (set) Token: 0x0601AD06 RID: 109830 RVA: 0x003D37BC File Offset: 0x003D19BC
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E36 RID: 32310
		// (get) Token: 0x0601AD07 RID: 109831 RVA: 0x003D37C5 File Offset: 0x003D19C5
		// (set) Token: 0x0601AD08 RID: 109832 RVA: 0x003D37CD File Offset: 0x003D19CD
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E37 RID: 32311
		// (get) Token: 0x0601AD09 RID: 109833 RVA: 0x003D37D6 File Offset: 0x003D19D6
		// (set) Token: 0x0601AD0A RID: 109834 RVA: 0x003D37DE File Offset: 0x003D19DE
		public byte NullMask { get; set; }

		// Token: 0x0601AD0B RID: 109835 RVA: 0x003D37E7 File Offset: 0x003D19E7
		public IRollBlockGridGoalT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
