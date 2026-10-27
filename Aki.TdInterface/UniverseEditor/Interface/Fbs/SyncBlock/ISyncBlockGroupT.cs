using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B85 RID: 15237
	public class ISyncBlockGroupT
	{
		// Token: 0x1700687C RID: 26748
		// (get) Token: 0x06014E0F RID: 85519 RVA: 0x00307D00 File Offset: 0x00305F00
		// (set) Token: 0x06014E10 RID: 85520 RVA: 0x00307D08 File Offset: 0x00305F08
		public string Name { get; set; }

		// Token: 0x1700687D RID: 26749
		// (get) Token: 0x06014E11 RID: 85521 RVA: 0x00307D11 File Offset: 0x00305F11
		// (set) Token: 0x06014E12 RID: 85522 RVA: 0x00307D19 File Offset: 0x00305F19
		public List<ISyncBlockT> SyncBlocks { get; set; }

		// Token: 0x06014E13 RID: 85523 RVA: 0x00307D22 File Offset: 0x00305F22
		public ISyncBlockGroupT()
		{
			this.Name = null;
			this.SyncBlocks = null;
		}
	}
}
