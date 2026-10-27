using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B2 RID: 18354
	public class IEntityModelT
	{
		// Token: 0x170083D4 RID: 33748
		// (get) Token: 0x0601C547 RID: 116039 RVA: 0x0040292E File Offset: 0x00400B2E
		// (set) Token: 0x0601C548 RID: 116040 RVA: 0x00402936 File Offset: 0x00400B36
		public string BluePrintId { get; set; }

		// Token: 0x170083D5 RID: 33749
		// (get) Token: 0x0601C549 RID: 116041 RVA: 0x0040293F File Offset: 0x00400B3F
		// (set) Token: 0x0601C54A RID: 116042 RVA: 0x00402947 File Offset: 0x00400B47
		public string BluePrintClass { get; set; }

		// Token: 0x170083D6 RID: 33750
		// (get) Token: 0x0601C54B RID: 116043 RVA: 0x00402950 File Offset: 0x00400B50
		// (set) Token: 0x0601C54C RID: 116044 RVA: 0x00402958 File Offset: 0x00400B58
		public string MeshPath { get; set; }

		// Token: 0x170083D7 RID: 33751
		// (get) Token: 0x0601C54D RID: 116045 RVA: 0x00402961 File Offset: 0x00400B61
		// (set) Token: 0x0601C54E RID: 116046 RVA: 0x00402969 File Offset: 0x00400B69
		public string AnimPath { get; set; }

		// Token: 0x170083D8 RID: 33752
		// (get) Token: 0x0601C54F RID: 116047 RVA: 0x00402972 File Offset: 0x00400B72
		// (set) Token: 0x0601C550 RID: 116048 RVA: 0x0040297A File Offset: 0x00400B7A
		public List<string> Materials { get; set; }

		// Token: 0x0601C551 RID: 116049 RVA: 0x00402983 File Offset: 0x00400B83
		public IEntityModelT()
		{
			this.BluePrintId = null;
			this.BluePrintClass = null;
			this.MeshPath = null;
			this.AnimPath = null;
			this.Materials = null;
		}
	}
}
