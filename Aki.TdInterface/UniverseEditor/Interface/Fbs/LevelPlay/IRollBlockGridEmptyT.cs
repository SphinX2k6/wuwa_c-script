using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049CF RID: 18895
	public class IRollBlockGridEmptyT
	{
		// Token: 0x17008457 RID: 33879
		// (get) Token: 0x0601C442 RID: 115778 RVA: 0x003FE047 File Offset: 0x003FC247
		// (set) Token: 0x0601C443 RID: 115779 RVA: 0x003FE04F File Offset: 0x003FC24F
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17008458 RID: 33880
		// (get) Token: 0x0601C444 RID: 115780 RVA: 0x003FE058 File Offset: 0x003FC258
		// (set) Token: 0x0601C445 RID: 115781 RVA: 0x003FE060 File Offset: 0x003FC260
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17008459 RID: 33881
		// (get) Token: 0x0601C446 RID: 115782 RVA: 0x003FE069 File Offset: 0x003FC269
		// (set) Token: 0x0601C447 RID: 115783 RVA: 0x003FE071 File Offset: 0x003FC271
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x1700845A RID: 33882
		// (get) Token: 0x0601C448 RID: 115784 RVA: 0x003FE07A File Offset: 0x003FC27A
		// (set) Token: 0x0601C449 RID: 115785 RVA: 0x003FE082 File Offset: 0x003FC282
		public byte NullMask { get; set; }

		// Token: 0x0601C44A RID: 115786 RVA: 0x003FE08B File Offset: 0x003FC28B
		public IRollBlockGridEmptyT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
