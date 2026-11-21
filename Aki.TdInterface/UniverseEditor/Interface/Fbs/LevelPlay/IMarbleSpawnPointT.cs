using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004990 RID: 18832
	public class IMarbleSpawnPointT
	{
		// Token: 0x170083D2 RID: 33746
		// (get) Token: 0x0601C1C2 RID: 115138 RVA: 0x003F8F57 File Offset: 0x003F7157
		// (set) Token: 0x0601C1C3 RID: 115139 RVA: 0x003F8F5F File Offset: 0x003F715F
		public int Id { get; set; }

		// Token: 0x170083D3 RID: 33747
		// (get) Token: 0x0601C1C4 RID: 115140 RVA: 0x003F8F68 File Offset: 0x003F7168
		// (set) Token: 0x0601C1C5 RID: 115141 RVA: 0x003F8F70 File Offset: 0x003F7170
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x170083D4 RID: 33748
		// (get) Token: 0x0601C1C6 RID: 115142 RVA: 0x003F8F79 File Offset: 0x003F7179
		// (set) Token: 0x0601C1C7 RID: 115143 RVA: 0x003F8F81 File Offset: 0x003F7181
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x170083D5 RID: 33749
		// (get) Token: 0x0601C1C8 RID: 115144 RVA: 0x003F8F8A File Offset: 0x003F718A
		// (set) Token: 0x0601C1C9 RID: 115145 RVA: 0x003F8F92 File Offset: 0x003F7192
		public EMarbleItemType SubType { get; set; }

		// Token: 0x0601C1CA RID: 115146 RVA: 0x003F8F9B File Offset: 0x003F719B
		public IMarbleSpawnPointT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
			this.SubType = EMarbleItemType.CommonItem;
		}
	}
}
