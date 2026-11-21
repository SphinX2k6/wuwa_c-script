using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D62 RID: 28002
	public class IEntityLookAtPerformT
	{
		// Token: 0x1700CD66 RID: 52582
		// (get) Token: 0x060304E8 RID: 197864 RVA: 0x006908E1 File Offset: 0x0068EAE1
		// (set) Token: 0x060304E9 RID: 197865 RVA: 0x006908E9 File Offset: 0x0068EAE9
		public int EntityId { get; set; }

		// Token: 0x1700CD67 RID: 52583
		// (get) Token: 0x060304EA RID: 197866 RVA: 0x006908F2 File Offset: 0x0068EAF2
		// (set) Token: 0x060304EB RID: 197867 RVA: 0x006908FA File Offset: 0x0068EAFA
		public int FaceExpressionId { get; set; }

		// Token: 0x1700CD68 RID: 52584
		// (get) Token: 0x060304EC RID: 197868 RVA: 0x00690903 File Offset: 0x0068EB03
		// (set) Token: 0x060304ED RID: 197869 RVA: 0x0069090B File Offset: 0x0068EB0B
		public int OverlapMontageId { get; set; }

		// Token: 0x1700CD69 RID: 52585
		// (get) Token: 0x060304EE RID: 197870 RVA: 0x00690914 File Offset: 0x0068EB14
		// (set) Token: 0x060304EF RID: 197871 RVA: 0x0069091C File Offset: 0x0068EB1C
		public ILookAtPerformOverlapMontageConfigT OverlapMontageConfig { get; set; }

		// Token: 0x1700CD6A RID: 52586
		// (get) Token: 0x060304F0 RID: 197872 RVA: 0x00690925 File Offset: 0x0068EB25
		// (set) Token: 0x060304F1 RID: 197873 RVA: 0x0069092D File Offset: 0x0068EB2D
		public byte NullMask { get; set; }

		// Token: 0x060304F2 RID: 197874 RVA: 0x00690936 File Offset: 0x0068EB36
		public IEntityLookAtPerformT()
		{
			this.EntityId = 0;
			this.FaceExpressionId = 0;
			this.OverlapMontageId = 0;
			this.OverlapMontageConfig = null;
			this.NullMask = 0;
		}
	}
}
