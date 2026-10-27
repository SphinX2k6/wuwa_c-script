using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200455E RID: 17758
	public class IRollBlockGridBaseT
	{
		// Token: 0x17007DFE RID: 32254
		// (get) Token: 0x0601ABE9 RID: 109545 RVA: 0x003D08A7 File Offset: 0x003CEAA7
		// (set) Token: 0x0601ABEA RID: 109546 RVA: 0x003D08AF File Offset: 0x003CEAAF
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007DFF RID: 32255
		// (get) Token: 0x0601ABEB RID: 109547 RVA: 0x003D08B8 File Offset: 0x003CEAB8
		// (set) Token: 0x0601ABEC RID: 109548 RVA: 0x003D08C0 File Offset: 0x003CEAC0
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E00 RID: 32256
		// (get) Token: 0x0601ABED RID: 109549 RVA: 0x003D08C9 File Offset: 0x003CEAC9
		// (set) Token: 0x0601ABEE RID: 109550 RVA: 0x003D08D1 File Offset: 0x003CEAD1
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E01 RID: 32257
		// (get) Token: 0x0601ABEF RID: 109551 RVA: 0x003D08DA File Offset: 0x003CEADA
		// (set) Token: 0x0601ABF0 RID: 109552 RVA: 0x003D08E2 File Offset: 0x003CEAE2
		public byte NullMask { get; set; }

		// Token: 0x0601ABF1 RID: 109553 RVA: 0x003D08EB File Offset: 0x003CEAEB
		public IRollBlockGridBaseT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
