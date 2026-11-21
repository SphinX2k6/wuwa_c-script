using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200498A RID: 18826
	public class IMarbleCommonItemT
	{
		// Token: 0x170083BD RID: 33725
		// (get) Token: 0x0601C180 RID: 115072 RVA: 0x003F8799 File Offset: 0x003F6999
		// (set) Token: 0x0601C181 RID: 115073 RVA: 0x003F87A1 File Offset: 0x003F69A1
		public int Id { get; set; }

		// Token: 0x170083BE RID: 33726
		// (get) Token: 0x0601C182 RID: 115074 RVA: 0x003F87AA File Offset: 0x003F69AA
		// (set) Token: 0x0601C183 RID: 115075 RVA: 0x003F87B2 File Offset: 0x003F69B2
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x170083BF RID: 33727
		// (get) Token: 0x0601C184 RID: 115076 RVA: 0x003F87BB File Offset: 0x003F69BB
		// (set) Token: 0x0601C185 RID: 115077 RVA: 0x003F87C3 File Offset: 0x003F69C3
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x170083C0 RID: 33728
		// (get) Token: 0x0601C186 RID: 115078 RVA: 0x003F87CC File Offset: 0x003F69CC
		// (set) Token: 0x0601C187 RID: 115079 RVA: 0x003F87D4 File Offset: 0x003F69D4
		public EMarbleItemType SubType { get; set; }

		// Token: 0x170083C1 RID: 33729
		// (get) Token: 0x0601C188 RID: 115080 RVA: 0x003F87DD File Offset: 0x003F69DD
		// (set) Token: 0x0601C189 RID: 115081 RVA: 0x003F87E5 File Offset: 0x003F69E5
		public int DataId { get; set; }

		// Token: 0x170083C2 RID: 33730
		// (get) Token: 0x0601C18A RID: 115082 RVA: 0x003F87EE File Offset: 0x003F69EE
		// (set) Token: 0x0601C18B RID: 115083 RVA: 0x003F87F6 File Offset: 0x003F69F6
		public int AwakenWave { get; set; }

		// Token: 0x170083C3 RID: 33731
		// (get) Token: 0x0601C18C RID: 115084 RVA: 0x003F87FF File Offset: 0x003F69FF
		// (set) Token: 0x0601C18D RID: 115085 RVA: 0x003F8807 File Offset: 0x003F6A07
		public int DestroyWave { get; set; }

		// Token: 0x0601C18E RID: 115086 RVA: 0x003F8810 File Offset: 0x003F6A10
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
