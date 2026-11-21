using System;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CAB RID: 23723
	internal interface ILeaveAreaItem
	{
		// Token: 0x17006E85 RID: 28293
		// (get) Token: 0x0603A27B RID: 238203
		// (set) Token: 0x0603A27C RID: 238204
		int QuestId { get; set; }

		// Token: 0x17006E86 RID: 28294
		// (get) Token: 0x0603A27D RID: 238205
		// (set) Token: 0x0603A27E RID: 238206
		int NodeId { get; set; }

		// Token: 0x17006E87 RID: 28295
		// (get) Token: 0x0603A27F RID: 238207
		// (set) Token: 0x0603A280 RID: 238208
		int LeaveAreaId { get; set; }

		// Token: 0x17006E88 RID: 28296
		// (get) Token: 0x0603A281 RID: 238209
		// (set) Token: 0x0603A282 RID: 238210
		NodeStatus NodeState { get; set; }
	}
}
