using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048C1 RID: 18625
	public class IDangoBrawlBagT
	{
		// Token: 0x1700819B RID: 33179
		// (get) Token: 0x0601B8A9 RID: 112809 RVA: 0x003E5349 File Offset: 0x003E3549
		// (set) Token: 0x0601B8AA RID: 112810 RVA: 0x003E5351 File Offset: 0x003E3551
		public int Id { get; set; }

		// Token: 0x1700819C RID: 33180
		// (get) Token: 0x0601B8AB RID: 112811 RVA: 0x003E535A File Offset: 0x003E355A
		// (set) Token: 0x0601B8AC RID: 112812 RVA: 0x003E5362 File Offset: 0x003E3562
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x1700819D RID: 33181
		// (get) Token: 0x0601B8AD RID: 112813 RVA: 0x003E536B File Offset: 0x003E356B
		// (set) Token: 0x0601B8AE RID: 112814 RVA: 0x003E5373 File Offset: 0x003E3573
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x1700819E RID: 33182
		// (get) Token: 0x0601B8AF RID: 112815 RVA: 0x003E537C File Offset: 0x003E357C
		// (set) Token: 0x0601B8B0 RID: 112816 RVA: 0x003E5384 File Offset: 0x003E3584
		public int DataId { get; set; }

		// Token: 0x1700819F RID: 33183
		// (get) Token: 0x0601B8B1 RID: 112817 RVA: 0x003E538D File Offset: 0x003E358D
		// (set) Token: 0x0601B8B2 RID: 112818 RVA: 0x003E5395 File Offset: 0x003E3595
		public EDangoBrawlDirection Direction { get; set; }

		// Token: 0x170081A0 RID: 33184
		// (get) Token: 0x0601B8B3 RID: 112819 RVA: 0x003E539E File Offset: 0x003E359E
		// (set) Token: 0x0601B8B4 RID: 112820 RVA: 0x003E53A6 File Offset: 0x003E35A6
		public int TemplateId { get; set; }

		// Token: 0x170081A1 RID: 33185
		// (get) Token: 0x0601B8B5 RID: 112821 RVA: 0x003E53AF File Offset: 0x003E35AF
		// (set) Token: 0x0601B8B6 RID: 112822 RVA: 0x003E53B7 File Offset: 0x003E35B7
		public EDangoBrawlObjectType SubType { get; set; }

		// Token: 0x0601B8B7 RID: 112823 RVA: 0x003E53C0 File Offset: 0x003E35C0
		public IDangoBrawlBagT()
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
