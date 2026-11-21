using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CDA RID: 19674
	public class IEditorTwoDimensionLevelT
	{
		// Token: 0x17008C84 RID: 35972
		// (get) Token: 0x0601E629 RID: 124457 RVA: 0x00441F01 File Offset: 0x00440101
		// (set) Token: 0x0601E62A RID: 124458 RVA: 0x00441F09 File Offset: 0x00440109
		public int Id { get; set; }

		// Token: 0x17008C85 RID: 35973
		// (get) Token: 0x0601E62B RID: 124459 RVA: 0x00441F12 File Offset: 0x00440112
		// (set) Token: 0x0601E62C RID: 124460 RVA: 0x00441F1A File Offset: 0x0044011A
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17008C86 RID: 35974
		// (get) Token: 0x0601E62D RID: 124461 RVA: 0x00441F23 File Offset: 0x00440123
		// (set) Token: 0x0601E62E RID: 124462 RVA: 0x00441F2B File Offset: 0x0044012B
		public List<TTwoDimensionItemUnion> ItemList { get; set; }

		// Token: 0x0601E62F RID: 124463 RVA: 0x00441F34 File Offset: 0x00440134
		public IEditorTwoDimensionLevelT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.ItemList = null;
		}
	}
}
