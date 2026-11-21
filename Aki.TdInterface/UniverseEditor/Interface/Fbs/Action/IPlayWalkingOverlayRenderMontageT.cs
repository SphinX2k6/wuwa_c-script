using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C6 RID: 29894
	public class IPlayWalkingOverlayRenderMontageT
	{
		// Token: 0x1700DBF9 RID: 56313
		// (get) Token: 0x06034679 RID: 214649 RVA: 0x0070EA15 File Offset: 0x0070CC15
		// (set) Token: 0x0603467A RID: 214650 RVA: 0x0070EA1D File Offset: 0x0070CC1D
		public int EntityId { get; set; }

		// Token: 0x1700DBFA RID: 56314
		// (get) Token: 0x0603467B RID: 214651 RVA: 0x0070EA26 File Offset: 0x0070CC26
		// (set) Token: 0x0603467C RID: 214652 RVA: 0x0070EA2E File Offset: 0x0070CC2E
		public IMontageIdT OverlapMontageId { get; set; }

		// Token: 0x1700DBFB RID: 56315
		// (get) Token: 0x0603467D RID: 214653 RVA: 0x0070EA37 File Offset: 0x0070CC37
		// (set) Token: 0x0603467E RID: 214654 RVA: 0x0070EA3F File Offset: 0x0070CC3F
		public float LoopDuration { get; set; }

		// Token: 0x1700DBFC RID: 56316
		// (get) Token: 0x0603467F RID: 214655 RVA: 0x0070EA48 File Offset: 0x0070CC48
		// (set) Token: 0x06034680 RID: 214656 RVA: 0x0070EA50 File Offset: 0x0070CC50
		public int RepeatTimes { get; set; }

		// Token: 0x1700DBFD RID: 56317
		// (get) Token: 0x06034681 RID: 214657 RVA: 0x0070EA59 File Offset: 0x0070CC59
		// (set) Token: 0x06034682 RID: 214658 RVA: 0x0070EA61 File Offset: 0x0070CC61
		public byte NullMask { get; set; }

		// Token: 0x06034683 RID: 214659 RVA: 0x0070EA6A File Offset: 0x0070CC6A
		public IPlayWalkingOverlayRenderMontageT()
		{
			this.EntityId = 0;
			this.OverlapMontageId = null;
			this.LoopDuration = 0f;
			this.RepeatTimes = 0;
			this.NullMask = 0;
		}
	}
}
