using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004525 RID: 17701
	public class IMarbleItemLevelBaseT
	{
		// Token: 0x17007D88 RID: 32136
		// (get) Token: 0x0601A9CF RID: 109007 RVA: 0x003CC91B File Offset: 0x003CAB1B
		// (set) Token: 0x0601A9D0 RID: 109008 RVA: 0x003CC923 File Offset: 0x003CAB23
		public int Id { get; set; }

		// Token: 0x17007D89 RID: 32137
		// (get) Token: 0x0601A9D1 RID: 109009 RVA: 0x003CC92C File Offset: 0x003CAB2C
		// (set) Token: 0x0601A9D2 RID: 109010 RVA: 0x003CC934 File Offset: 0x003CAB34
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17007D8A RID: 32138
		// (get) Token: 0x0601A9D3 RID: 109011 RVA: 0x003CC93D File Offset: 0x003CAB3D
		// (set) Token: 0x0601A9D4 RID: 109012 RVA: 0x003CC945 File Offset: 0x003CAB45
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x17007D8B RID: 32139
		// (get) Token: 0x0601A9D5 RID: 109013 RVA: 0x003CC94E File Offset: 0x003CAB4E
		// (set) Token: 0x0601A9D6 RID: 109014 RVA: 0x003CC956 File Offset: 0x003CAB56
		public EMarbleItemType SubType { get; set; }

		// Token: 0x0601A9D7 RID: 109015 RVA: 0x003CC95F File Offset: 0x003CAB5F
		public IMarbleItemLevelBaseT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
			this.SubType = EMarbleItemType.CommonItem;
		}
	}
}
