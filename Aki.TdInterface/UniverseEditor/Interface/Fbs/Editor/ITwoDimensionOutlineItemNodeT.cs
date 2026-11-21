using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D1C RID: 19740
	public class ITwoDimensionOutlineItemNodeT
	{
		// Token: 0x17008D4B RID: 36171
		// (get) Token: 0x0601E917 RID: 125207 RVA: 0x0044765C File Offset: 0x0044585C
		// (set) Token: 0x0601E918 RID: 125208 RVA: 0x00447664 File Offset: 0x00445864
		public ETwoDimensionOutlineNodeType Type { get; set; }

		// Token: 0x17008D4C RID: 36172
		// (get) Token: 0x0601E919 RID: 125209 RVA: 0x0044766D File Offset: 0x0044586D
		// (set) Token: 0x0601E91A RID: 125210 RVA: 0x00447675 File Offset: 0x00445875
		public int Id { get; set; }

		// Token: 0x0601E91B RID: 125211 RVA: 0x0044767E File Offset: 0x0044587E
		public ITwoDimensionOutlineItemNodeT()
		{
			this.Type = ETwoDimensionOutlineNodeType.Folder;
			this.Id = 0;
		}
	}
}
