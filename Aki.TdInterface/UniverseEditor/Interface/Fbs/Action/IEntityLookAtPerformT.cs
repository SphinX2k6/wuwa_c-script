using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E2 RID: 26338
	public class IEntityLookAtPerformT
	{
		// Token: 0x1700C3B0 RID: 50096
		// (get) Token: 0x0602DCAB RID: 187563 RVA: 0x0064336D File Offset: 0x0064156D
		// (set) Token: 0x0602DCAC RID: 187564 RVA: 0x00643375 File Offset: 0x00641575
		public int EntityId { get; set; }

		// Token: 0x1700C3B1 RID: 50097
		// (get) Token: 0x0602DCAD RID: 187565 RVA: 0x0064337E File Offset: 0x0064157E
		// (set) Token: 0x0602DCAE RID: 187566 RVA: 0x00643386 File Offset: 0x00641586
		public int FaceExpressionId { get; set; }

		// Token: 0x1700C3B2 RID: 50098
		// (get) Token: 0x0602DCAF RID: 187567 RVA: 0x0064338F File Offset: 0x0064158F
		// (set) Token: 0x0602DCB0 RID: 187568 RVA: 0x00643397 File Offset: 0x00641597
		public int OverlapMontageId { get; set; }

		// Token: 0x1700C3B3 RID: 50099
		// (get) Token: 0x0602DCB1 RID: 187569 RVA: 0x006433A0 File Offset: 0x006415A0
		// (set) Token: 0x0602DCB2 RID: 187570 RVA: 0x006433A8 File Offset: 0x006415A8
		public ILookAtPerformOverlapMontageConfigT OverlapMontageConfig { get; set; }

		// Token: 0x1700C3B4 RID: 50100
		// (get) Token: 0x0602DCB3 RID: 187571 RVA: 0x006433B1 File Offset: 0x006415B1
		// (set) Token: 0x0602DCB4 RID: 187572 RVA: 0x006433B9 File Offset: 0x006415B9
		public byte NullMask { get; set; }

		// Token: 0x0602DCB5 RID: 187573 RVA: 0x006433C2 File Offset: 0x006415C2
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
