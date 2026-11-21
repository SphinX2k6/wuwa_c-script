using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BE7 RID: 19431
	public class IBlueprintItemT
	{
		// Token: 0x17008983 RID: 35203
		// (get) Token: 0x0601DAB8 RID: 121528 RVA: 0x00429EE3 File Offset: 0x004280E3
		// (set) Token: 0x0601DAB9 RID: 121529 RVA: 0x00429EEB File Offset: 0x004280EB
		public EEntity EntityType { get; set; }

		// Token: 0x17008984 RID: 35204
		// (get) Token: 0x0601DABA RID: 121530 RVA: 0x00429EF4 File Offset: 0x004280F4
		// (set) Token: 0x0601DABB RID: 121531 RVA: 0x00429EFC File Offset: 0x004280FC
		public string Name { get; set; }

		// Token: 0x17008985 RID: 35205
		// (get) Token: 0x0601DABC RID: 121532 RVA: 0x00429F05 File Offset: 0x00428105
		// (set) Token: 0x0601DABD RID: 121533 RVA: 0x00429F0D File Offset: 0x0042810D
		public EEntityLogic EntityLogic { get; set; }

		// Token: 0x17008986 RID: 35206
		// (get) Token: 0x0601DABE RID: 121534 RVA: 0x00429F16 File Offset: 0x00428116
		// (set) Token: 0x0601DABF RID: 121535 RVA: 0x00429F1E File Offset: 0x0042811E
		public int ModelId { get; set; }

		// Token: 0x17008987 RID: 35207
		// (get) Token: 0x0601DAC0 RID: 121536 RVA: 0x00429F27 File Offset: 0x00428127
		// (set) Token: 0x0601DAC1 RID: 121537 RVA: 0x00429F2F File Offset: 0x0042812F
		public int HalfHeight { get; set; }

		// Token: 0x17008988 RID: 35208
		// (get) Token: 0x0601DAC2 RID: 121538 RVA: 0x00429F38 File Offset: 0x00428138
		// (set) Token: 0x0601DAC3 RID: 121539 RVA: 0x00429F40 File Offset: 0x00428140
		public string MainType { get; set; }

		// Token: 0x17008989 RID: 35209
		// (get) Token: 0x0601DAC4 RID: 121540 RVA: 0x00429F49 File Offset: 0x00428149
		// (set) Token: 0x0601DAC5 RID: 121541 RVA: 0x00429F51 File Offset: 0x00428151
		public string SubType { get; set; }

		// Token: 0x1700898A RID: 35210
		// (get) Token: 0x0601DAC6 RID: 121542 RVA: 0x00429F5A File Offset: 0x0042815A
		// (set) Token: 0x0601DAC7 RID: 121543 RVA: 0x00429F62 File Offset: 0x00428162
		public string Tags { get; set; }

		// Token: 0x1700898B RID: 35211
		// (get) Token: 0x0601DAC8 RID: 121544 RVA: 0x00429F6B File Offset: 0x0042816B
		// (set) Token: 0x0601DAC9 RID: 121545 RVA: 0x00429F73 File Offset: 0x00428173
		public int TrackHeight { get; set; }

		// Token: 0x0601DACA RID: 121546 RVA: 0x00429F7C File Offset: 0x0042817C
		public IBlueprintItemT()
		{
			this.EntityType = EEntity.CharacterEntity;
			this.Name = null;
			this.EntityLogic = EEntityLogic.Item;
			this.ModelId = 0;
			this.HalfHeight = 0;
			this.MainType = null;
			this.SubType = null;
			this.Tags = null;
			this.TrackHeight = 0;
		}
	}
}
