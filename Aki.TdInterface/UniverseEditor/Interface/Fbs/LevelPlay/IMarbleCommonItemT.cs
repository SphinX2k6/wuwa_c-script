using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004522 RID: 17698
	public class IMarbleCommonItemT
	{
		// Token: 0x17007D7C RID: 32124
		// (get) Token: 0x0601A9AB RID: 108971 RVA: 0x003CC4FD File Offset: 0x003CA6FD
		// (set) Token: 0x0601A9AC RID: 108972 RVA: 0x003CC505 File Offset: 0x003CA705
		public int Id { get; set; }

		// Token: 0x17007D7D RID: 32125
		// (get) Token: 0x0601A9AD RID: 108973 RVA: 0x003CC50E File Offset: 0x003CA70E
		// (set) Token: 0x0601A9AE RID: 108974 RVA: 0x003CC516 File Offset: 0x003CA716
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17007D7E RID: 32126
		// (get) Token: 0x0601A9AF RID: 108975 RVA: 0x003CC51F File Offset: 0x003CA71F
		// (set) Token: 0x0601A9B0 RID: 108976 RVA: 0x003CC527 File Offset: 0x003CA727
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x17007D7F RID: 32127
		// (get) Token: 0x0601A9B1 RID: 108977 RVA: 0x003CC530 File Offset: 0x003CA730
		// (set) Token: 0x0601A9B2 RID: 108978 RVA: 0x003CC538 File Offset: 0x003CA738
		public EMarbleItemType SubType { get; set; }

		// Token: 0x17007D80 RID: 32128
		// (get) Token: 0x0601A9B3 RID: 108979 RVA: 0x003CC541 File Offset: 0x003CA741
		// (set) Token: 0x0601A9B4 RID: 108980 RVA: 0x003CC549 File Offset: 0x003CA749
		public int DataId { get; set; }

		// Token: 0x17007D81 RID: 32129
		// (get) Token: 0x0601A9B5 RID: 108981 RVA: 0x003CC552 File Offset: 0x003CA752
		// (set) Token: 0x0601A9B6 RID: 108982 RVA: 0x003CC55A File Offset: 0x003CA75A
		public int AwakenWave { get; set; }

		// Token: 0x17007D82 RID: 32130
		// (get) Token: 0x0601A9B7 RID: 108983 RVA: 0x003CC563 File Offset: 0x003CA763
		// (set) Token: 0x0601A9B8 RID: 108984 RVA: 0x003CC56B File Offset: 0x003CA76B
		public int DestroyWave { get; set; }

		// Token: 0x0601A9B9 RID: 108985 RVA: 0x003CC574 File Offset: 0x003CA774
		public IMarbleCommonItemT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
			this.SubType = EMarbleItemType.CommonItem;
			this.DataId = 0;
			this.AwakenWave = 0;
			this.DestroyWave = 0;
		}
	}
}
