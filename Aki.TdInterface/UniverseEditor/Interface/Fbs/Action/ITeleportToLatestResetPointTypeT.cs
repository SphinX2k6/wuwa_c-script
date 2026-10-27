using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007392 RID: 29586
	public class ITeleportToLatestResetPointTypeT
	{
		// Token: 0x1700E097 RID: 57495
		// (get) Token: 0x06035B3F RID: 219967 RVA: 0x0074FA82 File Offset: 0x0074DC82
		// (set) Token: 0x06035B40 RID: 219968 RVA: 0x0074FA8A File Offset: 0x0074DC8A
		public ETeleportToLatestResetPointType Type { get; set; }

		// Token: 0x06035B41 RID: 219969 RVA: 0x0074FA93 File Offset: 0x0074DC93
		public ITeleportToLatestResetPointTypeT()
		{
			this.Type = ETeleportToLatestResetPointType.Directly;
		}
	}
}
