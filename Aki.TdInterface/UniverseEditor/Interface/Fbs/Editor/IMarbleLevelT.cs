using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CEF RID: 19695
	public class IMarbleLevelT
	{
		// Token: 0x17008CF6 RID: 36086
		// (get) Token: 0x0601E781 RID: 124801 RVA: 0x00444A45 File Offset: 0x00442C45
		// (set) Token: 0x0601E782 RID: 124802 RVA: 0x00444A4D File Offset: 0x00442C4D
		public int Id { get; set; }

		// Token: 0x17008CF7 RID: 36087
		// (get) Token: 0x0601E783 RID: 124803 RVA: 0x00444A56 File Offset: 0x00442C56
		// (set) Token: 0x0601E784 RID: 124804 RVA: 0x00444A5E File Offset: 0x00442C5E
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17008CF8 RID: 36088
		// (get) Token: 0x0601E785 RID: 124805 RVA: 0x00444A67 File Offset: 0x00442C67
		// (set) Token: 0x0601E786 RID: 124806 RVA: 0x00444A6F File Offset: 0x00442C6F
		public List<TTwoDimensionItemUnion> ItemList { get; set; }

		// Token: 0x0601E787 RID: 124807 RVA: 0x00444A78 File Offset: 0x00442C78
		public IMarbleLevelT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.ItemList = null;
		}
	}
}
