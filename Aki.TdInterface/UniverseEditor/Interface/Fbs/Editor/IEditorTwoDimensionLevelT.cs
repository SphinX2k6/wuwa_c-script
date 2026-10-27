using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004875 RID: 18549
	public class IEditorTwoDimensionLevelT
	{
		// Token: 0x1700863C RID: 34364
		// (get) Token: 0x0601CE3C RID: 118332 RVA: 0x00415765 File Offset: 0x00413965
		// (set) Token: 0x0601CE3D RID: 118333 RVA: 0x0041576D File Offset: 0x0041396D
		public int Id { get; set; }

		// Token: 0x1700863D RID: 34365
		// (get) Token: 0x0601CE3E RID: 118334 RVA: 0x00415776 File Offset: 0x00413976
		// (set) Token: 0x0601CE3F RID: 118335 RVA: 0x0041577E File Offset: 0x0041397E
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x1700863E RID: 34366
		// (get) Token: 0x0601CE40 RID: 118336 RVA: 0x00415787 File Offset: 0x00413987
		// (set) Token: 0x0601CE41 RID: 118337 RVA: 0x0041578F File Offset: 0x0041398F
		public List<TTwoDimensionItemUnion> ItemList { get; set; }

		// Token: 0x0601CE42 RID: 118338 RVA: 0x00415798 File Offset: 0x00413998
		public IEditorTwoDimensionLevelT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.ItemList = null;
		}
	}
}
