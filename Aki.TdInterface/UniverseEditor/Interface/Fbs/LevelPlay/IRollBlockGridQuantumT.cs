using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049E4 RID: 18916
	public class IRollBlockGridQuantumT
	{
		// Token: 0x170084A7 RID: 33959
		// (get) Token: 0x0601C5B4 RID: 116148 RVA: 0x00401FDB File Offset: 0x004001DB
		// (set) Token: 0x0601C5B5 RID: 116149 RVA: 0x00401FE3 File Offset: 0x004001E3
		public ERollBlockGridType Type { get; set; }

		// Token: 0x170084A8 RID: 33960
		// (get) Token: 0x0601C5B6 RID: 116150 RVA: 0x00401FEC File Offset: 0x004001EC
		// (set) Token: 0x0601C5B7 RID: 116151 RVA: 0x00401FF4 File Offset: 0x004001F4
		public TRollBlockUnion Block { get; set; }

		// Token: 0x170084A9 RID: 33961
		// (get) Token: 0x0601C5B8 RID: 116152 RVA: 0x00401FFD File Offset: 0x004001FD
		// (set) Token: 0x0601C5B9 RID: 116153 RVA: 0x00402005 File Offset: 0x00400205
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x170084AA RID: 33962
		// (get) Token: 0x0601C5BA RID: 116154 RVA: 0x0040200E File Offset: 0x0040020E
		// (set) Token: 0x0601C5BB RID: 116155 RVA: 0x00402016 File Offset: 0x00400216
		public byte NullMask { get; set; }

		// Token: 0x0601C5BC RID: 116156 RVA: 0x0040201F File Offset: 0x0040021F
		public IRollBlockGridQuantumT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
