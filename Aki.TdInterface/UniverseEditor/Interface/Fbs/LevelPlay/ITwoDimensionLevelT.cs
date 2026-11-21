using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A4A RID: 19018
	public class ITwoDimensionLevelT
	{
		// Token: 0x17008572 RID: 34162
		// (get) Token: 0x0601C938 RID: 117048 RVA: 0x00408609 File Offset: 0x00406809
		// (set) Token: 0x0601C939 RID: 117049 RVA: 0x00408611 File Offset: 0x00406811
		public int Id { get; set; }

		// Token: 0x17008573 RID: 34163
		// (get) Token: 0x0601C93A RID: 117050 RVA: 0x0040861A File Offset: 0x0040681A
		// (set) Token: 0x0601C93B RID: 117051 RVA: 0x00408622 File Offset: 0x00406822
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17008574 RID: 34164
		// (get) Token: 0x0601C93C RID: 117052 RVA: 0x0040862B File Offset: 0x0040682B
		// (set) Token: 0x0601C93D RID: 117053 RVA: 0x00408633 File Offset: 0x00406833
		public List<TTwoDimensionItemUnion> ItemList { get; set; }

		// Token: 0x0601C93E RID: 117054 RVA: 0x0040863C File Offset: 0x0040683C
		public ITwoDimensionLevelT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.ItemList = null;
		}
	}
}
