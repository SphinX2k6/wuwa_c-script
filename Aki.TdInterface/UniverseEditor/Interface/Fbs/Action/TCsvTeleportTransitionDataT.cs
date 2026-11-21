using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EA7 RID: 32423
	public class TCsvTeleportTransitionDataT
	{
		// Token: 0x1700F23D RID: 62013
		// (get) Token: 0x0603A8AF RID: 239791 RVA: 0x007E1123 File Offset: 0x007DF323
		// (set) Token: 0x0603A8B0 RID: 239792 RVA: 0x007E112B File Offset: 0x007DF32B
		public int Id { get; set; }

		// Token: 0x1700F23E RID: 62014
		// (get) Token: 0x0603A8B1 RID: 239793 RVA: 0x007E1134 File Offset: 0x007DF334
		// (set) Token: 0x0603A8B2 RID: 239794 RVA: 0x007E113C File Offset: 0x007DF33C
		public ITeleportTransitionType_UnionUnion Data { get; set; }

		// Token: 0x0603A8B3 RID: 239795 RVA: 0x007E1145 File Offset: 0x007DF345
		public TCsvTeleportTransitionDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
