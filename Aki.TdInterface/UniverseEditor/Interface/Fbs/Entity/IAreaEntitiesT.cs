using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BE1 RID: 19425
	public class IAreaEntitiesT
	{
		// Token: 0x17008973 RID: 35187
		// (get) Token: 0x0601DA72 RID: 121458 RVA: 0x004295E9 File Offset: 0x004277E9
		// (set) Token: 0x0601DA73 RID: 121459 RVA: 0x004295F1 File Offset: 0x004277F1
		public int LevelId { get; set; }

		// Token: 0x17008974 RID: 35188
		// (get) Token: 0x0601DA74 RID: 121460 RVA: 0x004295FA File Offset: 0x004277FA
		// (set) Token: 0x0601DA75 RID: 121461 RVA: 0x00429602 File Offset: 0x00427802
		public int AreaId { get; set; }

		// Token: 0x17008975 RID: 35189
		// (get) Token: 0x0601DA76 RID: 121462 RVA: 0x0042960B File Offset: 0x0042780B
		// (set) Token: 0x0601DA77 RID: 121463 RVA: 0x00429613 File Offset: 0x00427813
		public List<int> EntityIds { get; set; }

		// Token: 0x0601DA78 RID: 121464 RVA: 0x0042961C File Offset: 0x0042781C
		public IAreaEntitiesT()
		{
			this.LevelId = 0;
			this.AreaId = 0;
			this.EntityIds = null;
		}
	}
}
