using System;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B33 RID: 27443
	internal interface ILeaveAreaItem
	{
		// Token: 0x17009982 RID: 39298
		// (get) Token: 0x06044129 RID: 278825
		// (set) Token: 0x0604412A RID: 278826
		int QuestId { get; set; }

		// Token: 0x17009983 RID: 39299
		// (get) Token: 0x0604412B RID: 278827
		// (set) Token: 0x0604412C RID: 278828
		int NodeId { get; set; }

		// Token: 0x17009984 RID: 39300
		// (get) Token: 0x0604412D RID: 278829
		// (set) Token: 0x0604412E RID: 278830
		int LeaveAreaId { get; set; }

		// Token: 0x17009985 RID: 39301
		// (get) Token: 0x0604412F RID: 278831
		// (set) Token: 0x06044130 RID: 278832
		NodeStatus NodeState { get; set; }
	}
}
