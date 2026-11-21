using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D8 RID: 18904
	public class IRollBlockGridGoalT
	{
		// Token: 0x17008475 RID: 33909
		// (get) Token: 0x0601C4D8 RID: 115928 RVA: 0x003FFA3F File Offset: 0x003FDC3F
		// (set) Token: 0x0601C4D9 RID: 115929 RVA: 0x003FFA47 File Offset: 0x003FDC47
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17008476 RID: 33910
		// (get) Token: 0x0601C4DA RID: 115930 RVA: 0x003FFA50 File Offset: 0x003FDC50
		// (set) Token: 0x0601C4DB RID: 115931 RVA: 0x003FFA58 File Offset: 0x003FDC58
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17008477 RID: 33911
		// (get) Token: 0x0601C4DC RID: 115932 RVA: 0x003FFA61 File Offset: 0x003FDC61
		// (set) Token: 0x0601C4DD RID: 115933 RVA: 0x003FFA69 File Offset: 0x003FDC69
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17008478 RID: 33912
		// (get) Token: 0x0601C4DE RID: 115934 RVA: 0x003FFA72 File Offset: 0x003FDC72
		// (set) Token: 0x0601C4DF RID: 115935 RVA: 0x003FFA7A File Offset: 0x003FDC7A
		public byte NullMask { get; set; }

		// Token: 0x0601C4E0 RID: 115936 RVA: 0x003FFA83 File Offset: 0x003FDC83
		public IRollBlockGridGoalT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
