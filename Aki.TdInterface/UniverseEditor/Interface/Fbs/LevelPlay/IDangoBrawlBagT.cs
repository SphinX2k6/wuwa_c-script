using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004459 RID: 17497
	public class IDangoBrawlBagT
	{
		// Token: 0x17007B5C RID: 31580
		// (get) Token: 0x0601A0D8 RID: 106712 RVA: 0x003B913D File Offset: 0x003B733D
		// (set) Token: 0x0601A0D9 RID: 106713 RVA: 0x003B9145 File Offset: 0x003B7345
		public int Id { get; set; }

		// Token: 0x17007B5D RID: 31581
		// (get) Token: 0x0601A0DA RID: 106714 RVA: 0x003B914E File Offset: 0x003B734E
		// (set) Token: 0x0601A0DB RID: 106715 RVA: 0x003B9156 File Offset: 0x003B7356
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17007B5E RID: 31582
		// (get) Token: 0x0601A0DC RID: 106716 RVA: 0x003B915F File Offset: 0x003B735F
		// (set) Token: 0x0601A0DD RID: 106717 RVA: 0x003B9167 File Offset: 0x003B7367
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x17007B5F RID: 31583
		// (get) Token: 0x0601A0DE RID: 106718 RVA: 0x003B9170 File Offset: 0x003B7370
		// (set) Token: 0x0601A0DF RID: 106719 RVA: 0x003B9178 File Offset: 0x003B7378
		public int DataId { get; set; }

		// Token: 0x17007B60 RID: 31584
		// (get) Token: 0x0601A0E0 RID: 106720 RVA: 0x003B9181 File Offset: 0x003B7381
		// (set) Token: 0x0601A0E1 RID: 106721 RVA: 0x003B9189 File Offset: 0x003B7389
		public EDangoBrawlDirection Direction { get; set; }

		// Token: 0x17007B61 RID: 31585
		// (get) Token: 0x0601A0E2 RID: 106722 RVA: 0x003B9192 File Offset: 0x003B7392
		// (set) Token: 0x0601A0E3 RID: 106723 RVA: 0x003B919A File Offset: 0x003B739A
		public int TemplateId { get; set; }

		// Token: 0x17007B62 RID: 31586
		// (get) Token: 0x0601A0E4 RID: 106724 RVA: 0x003B91A3 File Offset: 0x003B73A3
		// (set) Token: 0x0601A0E5 RID: 106725 RVA: 0x003B91AB File Offset: 0x003B73AB
		public EDangoBrawlObjectType SubType { get; set; }

		// Token: 0x0601A0E6 RID: 106726 RVA: 0x003B91B4 File Offset: 0x003B73B4
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
