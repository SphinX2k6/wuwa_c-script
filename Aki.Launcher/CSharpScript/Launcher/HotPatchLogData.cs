using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x0200004D RID: 77
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchLogData
	{
		// Token: 0x06000268 RID: 616 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		[NullableContext(2)]
		public HotPatchLogData([Nullable(1)] string eventId, string uniqueId = null, string playerId = null)
		{
			this.event_id = eventId;
			this.unique_id = (uniqueId ?? "");
			this.player_id = (playerId ?? "");
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000C54B File Offset: 0x0000A74B
		public void Report()
		{
			HotPatchLogReport.Instance.ReportHotPatchLog(this);
		}

		// Token: 0x0400013B RID: 315
		public string event_id = "";

		// Token: 0x0400013C RID: 316
		public string unique_id = "";

		// Token: 0x0400013D RID: 317
		public string player_id = "";
	}
}
