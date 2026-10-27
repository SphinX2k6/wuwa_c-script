using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200445C RID: 17500
	public class IDangoBrawlItemT
	{
		// Token: 0x17007B6B RID: 31595
		// (get) Token: 0x0601A102 RID: 106754 RVA: 0x003B9699 File Offset: 0x003B7899
		// (set) Token: 0x0601A103 RID: 106755 RVA: 0x003B96A1 File Offset: 0x003B78A1
		public int Id { get; set; }

		// Token: 0x17007B6C RID: 31596
		// (get) Token: 0x0601A104 RID: 106756 RVA: 0x003B96AA File Offset: 0x003B78AA
		// (set) Token: 0x0601A105 RID: 106757 RVA: 0x003B96B2 File Offset: 0x003B78B2
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17007B6D RID: 31597
		// (get) Token: 0x0601A106 RID: 106758 RVA: 0x003B96BB File Offset: 0x003B78BB
		// (set) Token: 0x0601A107 RID: 106759 RVA: 0x003B96C3 File Offset: 0x003B78C3
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x17007B6E RID: 31598
		// (get) Token: 0x0601A108 RID: 106760 RVA: 0x003B96CC File Offset: 0x003B78CC
		// (set) Token: 0x0601A109 RID: 106761 RVA: 0x003B96D4 File Offset: 0x003B78D4
		public int DataId { get; set; }

		// Token: 0x17007B6F RID: 31599
		// (get) Token: 0x0601A10A RID: 106762 RVA: 0x003B96DD File Offset: 0x003B78DD
		// (set) Token: 0x0601A10B RID: 106763 RVA: 0x003B96E5 File Offset: 0x003B78E5
		public EDangoBrawlDirection Direction { get; set; }

		// Token: 0x17007B70 RID: 31600
		// (get) Token: 0x0601A10C RID: 106764 RVA: 0x003B96EE File Offset: 0x003B78EE
		// (set) Token: 0x0601A10D RID: 106765 RVA: 0x003B96F6 File Offset: 0x003B78F6
		public int TemplateId { get; set; }

		// Token: 0x17007B71 RID: 31601
		// (get) Token: 0x0601A10E RID: 106766 RVA: 0x003B96FF File Offset: 0x003B78FF
		// (set) Token: 0x0601A10F RID: 106767 RVA: 0x003B9707 File Offset: 0x003B7907
		public EDangoBrawlObjectType SubType { get; set; }

		// Token: 0x0601A110 RID: 106768 RVA: 0x003B9710 File Offset: 0x003B7910
		public IDangoBrawlItemT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
			this.DataId = 0;
			this.Direction = EDangoBrawlDirection.Up;
			this.TemplateId = 0;
			this.SubType = EDangoBrawlObjectType.Bag;
		}
	}
}
