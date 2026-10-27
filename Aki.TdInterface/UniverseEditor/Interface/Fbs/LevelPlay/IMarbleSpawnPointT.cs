using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004528 RID: 17704
	public class IMarbleSpawnPointT
	{
		// Token: 0x17007D91 RID: 32145
		// (get) Token: 0x0601A9ED RID: 109037 RVA: 0x003CCCBB File Offset: 0x003CAEBB
		// (set) Token: 0x0601A9EE RID: 109038 RVA: 0x003CCCC3 File Offset: 0x003CAEC3
		public int Id { get; set; }

		// Token: 0x17007D92 RID: 32146
		// (get) Token: 0x0601A9EF RID: 109039 RVA: 0x003CCCCC File Offset: 0x003CAECC
		// (set) Token: 0x0601A9F0 RID: 109040 RVA: 0x003CCCD4 File Offset: 0x003CAED4
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17007D93 RID: 32147
		// (get) Token: 0x0601A9F1 RID: 109041 RVA: 0x003CCCDD File Offset: 0x003CAEDD
		// (set) Token: 0x0601A9F2 RID: 109042 RVA: 0x003CCCE5 File Offset: 0x003CAEE5
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x17007D94 RID: 32148
		// (get) Token: 0x0601A9F3 RID: 109043 RVA: 0x003CCCEE File Offset: 0x003CAEEE
		// (set) Token: 0x0601A9F4 RID: 109044 RVA: 0x003CCCF6 File Offset: 0x003CAEF6
		public EMarbleItemType SubType { get; set; }

		// Token: 0x0601A9F5 RID: 109045 RVA: 0x003CCCFF File Offset: 0x003CAEFF
		public IMarbleSpawnPointT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
			this.SubType = EMarbleItemType.CommonItem;
		}
	}
}
