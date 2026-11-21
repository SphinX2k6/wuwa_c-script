using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C6 RID: 18886
	public class IRollBlockGridBaseT
	{
		// Token: 0x1700843F RID: 33855
		// (get) Token: 0x0601C3BE RID: 115646 RVA: 0x003FCB43 File Offset: 0x003FAD43
		// (set) Token: 0x0601C3BF RID: 115647 RVA: 0x003FCB4B File Offset: 0x003FAD4B
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17008440 RID: 33856
		// (get) Token: 0x0601C3C0 RID: 115648 RVA: 0x003FCB54 File Offset: 0x003FAD54
		// (set) Token: 0x0601C3C1 RID: 115649 RVA: 0x003FCB5C File Offset: 0x003FAD5C
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17008441 RID: 33857
		// (get) Token: 0x0601C3C2 RID: 115650 RVA: 0x003FCB65 File Offset: 0x003FAD65
		// (set) Token: 0x0601C3C3 RID: 115651 RVA: 0x003FCB6D File Offset: 0x003FAD6D
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17008442 RID: 33858
		// (get) Token: 0x0601C3C4 RID: 115652 RVA: 0x003FCB76 File Offset: 0x003FAD76
		// (set) Token: 0x0601C3C5 RID: 115653 RVA: 0x003FCB7E File Offset: 0x003FAD7E
		public byte NullMask { get; set; }

		// Token: 0x0601C3C6 RID: 115654 RVA: 0x003FCB87 File Offset: 0x003FAD87
		public IRollBlockGridBaseT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
