using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044AA RID: 17578
	public class IEnrichmentItemT
	{
		// Token: 0x17007C0E RID: 31758
		// (get) Token: 0x0601A40C RID: 107532 RVA: 0x003C020B File Offset: 0x003BE40B
		// (set) Token: 0x0601A40D RID: 107533 RVA: 0x003C0213 File Offset: 0x003BE413
		public int ItemId { get; set; }

		// Token: 0x17007C0F RID: 31759
		// (get) Token: 0x0601A40E RID: 107534 RVA: 0x003C021C File Offset: 0x003BE41C
		// (set) Token: 0x0601A40F RID: 107535 RVA: 0x003C0224 File Offset: 0x003BE424
		public EEnrichmentAreaType EnrichmentAreaType { get; set; }

		// Token: 0x17007C10 RID: 31760
		// (get) Token: 0x0601A410 RID: 107536 RVA: 0x003C022D File Offset: 0x003BE42D
		// (set) Token: 0x0601A411 RID: 107537 RVA: 0x003C0235 File Offset: 0x003BE435
		public int LevelId { get; set; }

		// Token: 0x17007C11 RID: 31761
		// (get) Token: 0x0601A412 RID: 107538 RVA: 0x003C023E File Offset: 0x003BE43E
		// (set) Token: 0x0601A413 RID: 107539 RVA: 0x003C0246 File Offset: 0x003BE446
		public int EnrichmentId { get; set; }

		// Token: 0x17007C12 RID: 31762
		// (get) Token: 0x0601A414 RID: 107540 RVA: 0x003C024F File Offset: 0x003BE44F
		// (set) Token: 0x0601A415 RID: 107541 RVA: 0x003C0257 File Offset: 0x003BE457
		public List<int> EntityIds { get; set; }

		// Token: 0x17007C13 RID: 31763
		// (get) Token: 0x0601A416 RID: 107542 RVA: 0x003C0260 File Offset: 0x003BE460
		// (set) Token: 0x0601A417 RID: 107543 RVA: 0x003C0268 File Offset: 0x003BE468
		public byte NullMask { get; set; }

		// Token: 0x0601A418 RID: 107544 RVA: 0x003C0271 File Offset: 0x003BE471
		public IEnrichmentItemT()
		{
			this.ItemId = 0;
			this.EnrichmentAreaType = EEnrichmentAreaType.BigWorld;
			this.LevelId = 0;
			this.EnrichmentId = 0;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}
