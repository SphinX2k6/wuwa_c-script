using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200484B RID: 18507
	public class IDangoBrawlLevelT
	{
		// Token: 0x170084DD RID: 34013
		// (get) Token: 0x0601CA1E RID: 117278 RVA: 0x0040C3AD File Offset: 0x0040A5AD
		// (set) Token: 0x0601CA1F RID: 117279 RVA: 0x0040C3B5 File Offset: 0x0040A5B5
		public int Id { get; set; }

		// Token: 0x170084DE RID: 34014
		// (get) Token: 0x0601CA20 RID: 117280 RVA: 0x0040C3BE File Offset: 0x0040A5BE
		// (set) Token: 0x0601CA21 RID: 117281 RVA: 0x0040C3C6 File Offset: 0x0040A5C6
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x170084DF RID: 34015
		// (get) Token: 0x0601CA22 RID: 117282 RVA: 0x0040C3CF File Offset: 0x0040A5CF
		// (set) Token: 0x0601CA23 RID: 117283 RVA: 0x0040C3D7 File Offset: 0x0040A5D7
		public List<TTwoDimensionItemUnion> ItemList { get; set; }

		// Token: 0x0601CA24 RID: 117284 RVA: 0x0040C3E0 File Offset: 0x0040A5E0
		public IDangoBrawlLevelT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.ItemList = null;
		}
	}
}
