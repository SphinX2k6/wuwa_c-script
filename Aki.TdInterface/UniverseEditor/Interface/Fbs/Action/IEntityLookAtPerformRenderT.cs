using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E5 RID: 26341
	public class IEntityLookAtPerformRenderT
	{
		// Token: 0x1700C3BB RID: 50107
		// (get) Token: 0x0602DCCD RID: 187597 RVA: 0x00643801 File Offset: 0x00641A01
		// (set) Token: 0x0602DCCE RID: 187598 RVA: 0x00643809 File Offset: 0x00641A09
		public int EntityId { get; set; }

		// Token: 0x1700C3BC RID: 50108
		// (get) Token: 0x0602DCCF RID: 187599 RVA: 0x00643812 File Offset: 0x00641A12
		// (set) Token: 0x0602DCD0 RID: 187600 RVA: 0x0064381A File Offset: 0x00641A1A
		public int FaceExpressionId { get; set; }

		// Token: 0x1700C3BD RID: 50109
		// (get) Token: 0x0602DCD1 RID: 187601 RVA: 0x00643823 File Offset: 0x00641A23
		// (set) Token: 0x0602DCD2 RID: 187602 RVA: 0x0064382B File Offset: 0x00641A2B
		public IMontageIdT OverlapMontageId { get; set; }

		// Token: 0x1700C3BE RID: 50110
		// (get) Token: 0x0602DCD3 RID: 187603 RVA: 0x00643834 File Offset: 0x00641A34
		// (set) Token: 0x0602DCD4 RID: 187604 RVA: 0x0064383C File Offset: 0x00641A3C
		public ILookAtPerformOverlapMontageConfigT OverlapMontageConfig { get; set; }

		// Token: 0x1700C3BF RID: 50111
		// (get) Token: 0x0602DCD5 RID: 187605 RVA: 0x00643845 File Offset: 0x00641A45
		// (set) Token: 0x0602DCD6 RID: 187606 RVA: 0x0064384D File Offset: 0x00641A4D
		public byte NullMask { get; set; }

		// Token: 0x0602DCD7 RID: 187607 RVA: 0x00643856 File Offset: 0x00641A56
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
