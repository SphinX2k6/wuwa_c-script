using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D5 RID: 18901
	public class IRollBlockGridFloorT
	{
		// Token: 0x1700846B RID: 33899
		// (get) Token: 0x0601C4A6 RID: 115878 RVA: 0x003FF197 File Offset: 0x003FD397
		// (set) Token: 0x0601C4A7 RID: 115879 RVA: 0x003FF19F File Offset: 0x003FD39F
		public ERollBlockGridType Type { get; set; }

		// Token: 0x1700846C RID: 33900
		// (get) Token: 0x0601C4A8 RID: 115880 RVA: 0x003FF1A8 File Offset: 0x003FD3A8
		// (set) Token: 0x0601C4A9 RID: 115881 RVA: 0x003FF1B0 File Offset: 0x003FD3B0
		public TRollBlockUnion Block { get; set; }

		// Token: 0x1700846D RID: 33901
		// (get) Token: 0x0601C4AA RID: 115882 RVA: 0x003FF1B9 File Offset: 0x003FD3B9
		// (set) Token: 0x0601C4AB RID: 115883 RVA: 0x003FF1C1 File Offset: 0x003FD3C1
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x1700846E RID: 33902
		// (get) Token: 0x0601C4AC RID: 115884 RVA: 0x003FF1CA File Offset: 0x003FD3CA
		// (set) Token: 0x0601C4AD RID: 115885 RVA: 0x003FF1D2 File Offset: 0x003FD3D2
		public byte NullMask { get; set; }

		// Token: 0x0601C4AE RID: 115886 RVA: 0x003FF1DB File Offset: 0x003FD3DB
		public IRollBlockGridFloorT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
