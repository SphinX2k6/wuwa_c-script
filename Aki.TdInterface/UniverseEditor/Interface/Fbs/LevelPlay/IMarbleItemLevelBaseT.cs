using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200498D RID: 18829
	public class IMarbleItemLevelBaseT
	{
		// Token: 0x170083C9 RID: 33737
		// (get) Token: 0x0601C1A4 RID: 115108 RVA: 0x003F8BB7 File Offset: 0x003F6DB7
		// (set) Token: 0x0601C1A5 RID: 115109 RVA: 0x003F8BBF File Offset: 0x003F6DBF
		public int Id { get; set; }

		// Token: 0x170083CA RID: 33738
		// (get) Token: 0x0601C1A6 RID: 115110 RVA: 0x003F8BC8 File Offset: 0x003F6DC8
		// (set) Token: 0x0601C1A7 RID: 115111 RVA: 0x003F8BD0 File Offset: 0x003F6DD0
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x170083CB RID: 33739
		// (get) Token: 0x0601C1A8 RID: 115112 RVA: 0x003F8BD9 File Offset: 0x003F6DD9
		// (set) Token: 0x0601C1A9 RID: 115113 RVA: 0x003F8BE1 File Offset: 0x003F6DE1
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x170083CC RID: 33740
		// (get) Token: 0x0601C1AA RID: 115114 RVA: 0x003F8BEA File Offset: 0x003F6DEA
		// (set) Token: 0x0601C1AB RID: 115115 RVA: 0x003F8BF2 File Offset: 0x003F6DF2
		public EMarbleItemType SubType { get; set; }

		// Token: 0x0601C1AC RID: 115116 RVA: 0x003F8BFB File Offset: 0x003F6DFB
		public IMarbleItemLevelBaseT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
			this.SubType = EMarbleItemType.CommonItem;
		}
	}
}
