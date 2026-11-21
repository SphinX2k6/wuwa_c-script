using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004912 RID: 18706
	public class IEnrichmentItemT
	{
		// Token: 0x1700824D RID: 33357
		// (get) Token: 0x0601BBDD RID: 113629 RVA: 0x003EC417 File Offset: 0x003EA617
		// (set) Token: 0x0601BBDE RID: 113630 RVA: 0x003EC41F File Offset: 0x003EA61F
		public int ItemId { get; set; }

		// Token: 0x1700824E RID: 33358
		// (get) Token: 0x0601BBDF RID: 113631 RVA: 0x003EC428 File Offset: 0x003EA628
		// (set) Token: 0x0601BBE0 RID: 113632 RVA: 0x003EC430 File Offset: 0x003EA630
		public EEnrichmentAreaType EnrichmentAreaType { get; set; }

		// Token: 0x1700824F RID: 33359
		// (get) Token: 0x0601BBE1 RID: 113633 RVA: 0x003EC439 File Offset: 0x003EA639
		// (set) Token: 0x0601BBE2 RID: 113634 RVA: 0x003EC441 File Offset: 0x003EA641
		public int LevelId { get; set; }

		// Token: 0x17008250 RID: 33360
		// (get) Token: 0x0601BBE3 RID: 113635 RVA: 0x003EC44A File Offset: 0x003EA64A
		// (set) Token: 0x0601BBE4 RID: 113636 RVA: 0x003EC452 File Offset: 0x003EA652
		public int EnrichmentId { get; set; }

		// Token: 0x17008251 RID: 33361
		// (get) Token: 0x0601BBE5 RID: 113637 RVA: 0x003EC45B File Offset: 0x003EA65B
		// (set) Token: 0x0601BBE6 RID: 113638 RVA: 0x003EC463 File Offset: 0x003EA663
		public List<int> EntityIds { get; set; }

		// Token: 0x17008252 RID: 33362
		// (get) Token: 0x0601BBE7 RID: 113639 RVA: 0x003EC46C File Offset: 0x003EA66C
		// (set) Token: 0x0601BBE8 RID: 113640 RVA: 0x003EC474 File Offset: 0x003EA674
		public byte NullMask { get; set; }

		// Token: 0x0601BBE9 RID: 113641 RVA: 0x003EC47D File Offset: 0x003EA67D
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
