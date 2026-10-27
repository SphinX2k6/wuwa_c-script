using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200457C RID: 17788
	public class IRollBlockGridQuantumT
	{
		// Token: 0x17007E66 RID: 32358
		// (get) Token: 0x0601ADDF RID: 110047 RVA: 0x003D5D3F File Offset: 0x003D3F3F
		// (set) Token: 0x0601ADE0 RID: 110048 RVA: 0x003D5D47 File Offset: 0x003D3F47
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E67 RID: 32359
		// (get) Token: 0x0601ADE1 RID: 110049 RVA: 0x003D5D50 File Offset: 0x003D3F50
		// (set) Token: 0x0601ADE2 RID: 110050 RVA: 0x003D5D58 File Offset: 0x003D3F58
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E68 RID: 32360
		// (get) Token: 0x0601ADE3 RID: 110051 RVA: 0x003D5D61 File Offset: 0x003D3F61
		// (set) Token: 0x0601ADE4 RID: 110052 RVA: 0x003D5D69 File Offset: 0x003D3F69
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E69 RID: 32361
		// (get) Token: 0x0601ADE5 RID: 110053 RVA: 0x003D5D72 File Offset: 0x003D3F72
		// (set) Token: 0x0601ADE6 RID: 110054 RVA: 0x003D5D7A File Offset: 0x003D3F7A
		public byte NullMask { get; set; }

		// Token: 0x0601ADE7 RID: 110055 RVA: 0x003D5D83 File Offset: 0x003D3F83
		public IRollBlockGridQuantumT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
