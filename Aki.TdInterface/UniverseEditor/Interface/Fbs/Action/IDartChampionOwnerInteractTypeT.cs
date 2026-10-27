using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006538 RID: 25912
	public class IDartChampionOwnerInteractTypeT
	{
		// Token: 0x1700C09E RID: 49310
		// (get) Token: 0x0602CF3D RID: 184125 RVA: 0x0062C078 File Offset: 0x0062A278
		// (set) Token: 0x0602CF3E RID: 184126 RVA: 0x0062C080 File Offset: 0x0062A280
		public EDartInteractType Type { get; set; }

		// Token: 0x1700C09F RID: 49311
		// (get) Token: 0x0602CF3F RID: 184127 RVA: 0x0062C089 File Offset: 0x0062A289
		// (set) Token: 0x0602CF40 RID: 184128 RVA: 0x0062C091 File Offset: 0x0062A291
		public int CompetitorId { get; set; }

		// Token: 0x0602CF41 RID: 184129 RVA: 0x0062C09A File Offset: 0x0062A29A
		public IDartChampionOwnerInteractTypeT()
		{
			this.Type = EDartInteractType.Machine;
			this.CompetitorId = 0;
		}
	}
}
