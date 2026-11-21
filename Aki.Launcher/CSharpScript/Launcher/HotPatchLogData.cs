using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x0200004D RID: 77
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchLogData
	{
		// Token: 0x06000268 RID: 616 RVA: 0x0000C560 File Offset: 0x0000A760
		[NullableContext(2)]
		public HotPatchLogData([Nullable(1)] string eventId, string uniqueId = null, string playerId = null)
		{
			this.event_id = eventId;
			this.unique_id = (uniqueId ?? "");
			this.player_id = (playerId ?? "");
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000C5BB File Offset: 0x0000A7BB
		public void Report()
		{
			HotPatchLogReport.Instance.ReportHotPatchLog(this);
		}

		// Token: 0x04000142 RID: 322
		public string event_id = "";

		// Token: 0x04000143 RID: 323
		public string unique_id = "";

		// Token: 0x04000144 RID: 324
		public string player_id = "";
	}
}
