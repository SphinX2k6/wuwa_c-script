using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200488A RID: 18570
	public class IMarbleLevelT
	{
		// Token: 0x170086AE RID: 34478
		// (get) Token: 0x0601CF94 RID: 118676 RVA: 0x004182A9 File Offset: 0x004164A9
		// (set) Token: 0x0601CF95 RID: 118677 RVA: 0x004182B1 File Offset: 0x004164B1
		public int Id { get; set; }

		// Token: 0x170086AF RID: 34479
		// (get) Token: 0x0601CF96 RID: 118678 RVA: 0x004182BA File Offset: 0x004164BA
		// (set) Token: 0x0601CF97 RID: 118679 RVA: 0x004182C2 File Offset: 0x004164C2
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x170086B0 RID: 34480
		// (get) Token: 0x0601CF98 RID: 118680 RVA: 0x004182CB File Offset: 0x004164CB
		// (set) Token: 0x0601CF99 RID: 118681 RVA: 0x004182D3 File Offset: 0x004164D3
		public List<TTwoDimensionItemUnion> ItemList { get; set; }

		// Token: 0x0601CF9A RID: 118682 RVA: 0x004182DC File Offset: 0x004164DC
		public IMarbleLevelT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.ItemList = null;
		}
	}
}
