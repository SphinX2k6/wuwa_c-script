using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D65 RID: 28005
	public class IEntityLookAtPerformRenderT
	{
		// Token: 0x1700CD71 RID: 52593
		// (get) Token: 0x0603050A RID: 197898 RVA: 0x00690D75 File Offset: 0x0068EF75
		// (set) Token: 0x0603050B RID: 197899 RVA: 0x00690D7D File Offset: 0x0068EF7D
		public int EntityId { get; set; }

		// Token: 0x1700CD72 RID: 52594
		// (get) Token: 0x0603050C RID: 197900 RVA: 0x00690D86 File Offset: 0x0068EF86
		// (set) Token: 0x0603050D RID: 197901 RVA: 0x00690D8E File Offset: 0x0068EF8E
		public int FaceExpressionId { get; set; }

		// Token: 0x1700CD73 RID: 52595
		// (get) Token: 0x0603050E RID: 197902 RVA: 0x00690D97 File Offset: 0x0068EF97
		// (set) Token: 0x0603050F RID: 197903 RVA: 0x00690D9F File Offset: 0x0068EF9F
		public IMontageIdT OverlapMontageId { get; set; }

		// Token: 0x1700CD74 RID: 52596
		// (get) Token: 0x06030510 RID: 197904 RVA: 0x00690DA8 File Offset: 0x0068EFA8
		// (set) Token: 0x06030511 RID: 197905 RVA: 0x00690DB0 File Offset: 0x0068EFB0
		public ILookAtPerformOverlapMontageConfigT OverlapMontageConfig { get; set; }

		// Token: 0x1700CD75 RID: 52597
		// (get) Token: 0x06030512 RID: 197906 RVA: 0x00690DB9 File Offset: 0x0068EFB9
		// (set) Token: 0x06030513 RID: 197907 RVA: 0x00690DC1 File Offset: 0x0068EFC1
		public byte NullMask { get; set; }

		// Token: 0x06030514 RID: 197908 RVA: 0x00690DCA File Offset: 0x0068EFCA
		public IEntityLookAtPerformRenderT()
		{
			this.EntityId = 0;
			this.FaceExpressionId = 0;
			this.OverlapMontageId = null;
			this.OverlapMontageConfig = null;
			this.NullMask = 0;
		}
	}
}
