using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200445F RID: 17503
	public class IDangoBrawlObjectBaseT
	{
		// Token: 0x17007B7A RID: 31610
		// (get) Token: 0x0601A12C RID: 106796 RVA: 0x003B9BF5 File Offset: 0x003B7DF5
		// (set) Token: 0x0601A12D RID: 106797 RVA: 0x003B9BFD File Offset: 0x003B7DFD
		public int Id { get; set; }

		// Token: 0x17007B7B RID: 31611
		// (get) Token: 0x0601A12E RID: 106798 RVA: 0x003B9C06 File Offset: 0x003B7E06
		// (set) Token: 0x0601A12F RID: 106799 RVA: 0x003B9C0E File Offset: 0x003B7E0E
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17007B7C RID: 31612
		// (get) Token: 0x0601A130 RID: 106800 RVA: 0x003B9C17 File Offset: 0x003B7E17
		// (set) Token: 0x0601A131 RID: 106801 RVA: 0x003B9C1F File Offset: 0x003B7E1F
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x17007B7D RID: 31613
		// (get) Token: 0x0601A132 RID: 106802 RVA: 0x003B9C28 File Offset: 0x003B7E28
		// (set) Token: 0x0601A133 RID: 106803 RVA: 0x003B9C30 File Offset: 0x003B7E30
		public EDangoBrawlObjectType SubType { get; set; }

		// Token: 0x17007B7E RID: 31614
		// (get) Token: 0x0601A134 RID: 106804 RVA: 0x003B9C39 File Offset: 0x003B7E39
		// (set) Token: 0x0601A135 RID: 106805 RVA: 0x003B9C41 File Offset: 0x003B7E41
		public int DataId { get; set; }

		// Token: 0x17007B7F RID: 31615
		// (get) Token: 0x0601A136 RID: 106806 RVA: 0x003B9C4A File Offset: 0x003B7E4A
		// (set) Token: 0x0601A137 RID: 106807 RVA: 0x003B9C52 File Offset: 0x003B7E52
		public EDangoBrawlDirection Direction { get; set; }

		// Token: 0x17007B80 RID: 31616
		// (get) Token: 0x0601A138 RID: 106808 RVA: 0x003B9C5B File Offset: 0x003B7E5B
		// (set) Token: 0x0601A139 RID: 106809 RVA: 0x003B9C63 File Offset: 0x003B7E63
		public int TemplateId { get; set; }

		// Token: 0x0601A13A RID: 106810 RVA: 0x003B9C6C File Offset: 0x003B7E6C
		public IDangoBrawlObjectBaseT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
			this.SubType = EDangoBrawlObjectType.Bag;
			this.DataId = 0;
			this.Direction = EDangoBrawlDirection.Up;
			this.TemplateId = 0;
		}
	}
}
