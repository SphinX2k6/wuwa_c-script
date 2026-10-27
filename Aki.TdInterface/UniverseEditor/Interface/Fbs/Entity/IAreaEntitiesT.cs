using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004779 RID: 18297
	public class IAreaEntitiesT
	{
		// Token: 0x17008332 RID: 33586
		// (get) Token: 0x0601C29D RID: 115357 RVA: 0x003FD34D File Offset: 0x003FB54D
		// (set) Token: 0x0601C29E RID: 115358 RVA: 0x003FD355 File Offset: 0x003FB555
		public int LevelId { get; set; }

		// Token: 0x17008333 RID: 33587
		// (get) Token: 0x0601C29F RID: 115359 RVA: 0x003FD35E File Offset: 0x003FB55E
		// (set) Token: 0x0601C2A0 RID: 115360 RVA: 0x003FD366 File Offset: 0x003FB566
		public int AreaId { get; set; }

		// Token: 0x17008334 RID: 33588
		// (get) Token: 0x0601C2A1 RID: 115361 RVA: 0x003FD36F File Offset: 0x003FB56F
		// (set) Token: 0x0601C2A2 RID: 115362 RVA: 0x003FD377 File Offset: 0x003FB577
		public List<int> EntityIds { get; set; }

		// Token: 0x0601C2A3 RID: 115363 RVA: 0x003FD380 File Offset: 0x003FB580
		public IAreaEntitiesT()
		{
			this.LevelId = 0;
			this.AreaId = 0;
			this.EntityIds = null;
		}
	}
}
