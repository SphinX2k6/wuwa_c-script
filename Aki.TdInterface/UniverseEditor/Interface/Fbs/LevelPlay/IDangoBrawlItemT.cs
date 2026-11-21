using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048C4 RID: 18628
	public class IDangoBrawlItemT
	{
		// Token: 0x170081AA RID: 33194
		// (get) Token: 0x0601B8D3 RID: 112851 RVA: 0x003E58A5 File Offset: 0x003E3AA5
		// (set) Token: 0x0601B8D4 RID: 112852 RVA: 0x003E58AD File Offset: 0x003E3AAD
		public int Id { get; set; }

		// Token: 0x170081AB RID: 33195
		// (get) Token: 0x0601B8D5 RID: 112853 RVA: 0x003E58B6 File Offset: 0x003E3AB6
		// (set) Token: 0x0601B8D6 RID: 112854 RVA: 0x003E58BE File Offset: 0x003E3ABE
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x170081AC RID: 33196
		// (get) Token: 0x0601B8D7 RID: 112855 RVA: 0x003E58C7 File Offset: 0x003E3AC7
		// (set) Token: 0x0601B8D8 RID: 112856 RVA: 0x003E58CF File Offset: 0x003E3ACF
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x170081AD RID: 33197
		// (get) Token: 0x0601B8D9 RID: 112857 RVA: 0x003E58D8 File Offset: 0x003E3AD8
		// (set) Token: 0x0601B8DA RID: 112858 RVA: 0x003E58E0 File Offset: 0x003E3AE0
		public int DataId { get; set; }

		// Token: 0x170081AE RID: 33198
		// (get) Token: 0x0601B8DB RID: 112859 RVA: 0x003E58E9 File Offset: 0x003E3AE9
		// (set) Token: 0x0601B8DC RID: 112860 RVA: 0x003E58F1 File Offset: 0x003E3AF1
		public EDangoBrawlDirection Direction { get; set; }

		// Token: 0x170081AF RID: 33199
		// (get) Token: 0x0601B8DD RID: 112861 RVA: 0x003E58FA File Offset: 0x003E3AFA
		// (set) Token: 0x0601B8DE RID: 112862 RVA: 0x003E5902 File Offset: 0x003E3B02
		public int TemplateId { get; set; }

		// Token: 0x170081B0 RID: 33200
		// (get) Token: 0x0601B8DF RID: 112863 RVA: 0x003E590B File Offset: 0x003E3B0B
		// (set) Token: 0x0601B8E0 RID: 112864 RVA: 0x003E5913 File Offset: 0x003E3B13
		public EDangoBrawlObjectType SubType { get; set; }

		// Token: 0x0601B8E1 RID: 112865 RVA: 0x003E591C File Offset: 0x003E3B1C
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
