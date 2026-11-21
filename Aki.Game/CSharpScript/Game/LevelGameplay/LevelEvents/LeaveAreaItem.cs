using System;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CAC RID: 23724
	internal class LeaveAreaItem : ILeaveAreaItem
	{
		// Token: 0x17006E89 RID: 28297
		// (get) Token: 0x0603A283 RID: 238211 RVA: 0x01066877 File Offset: 0x01064A77
		// (set) Token: 0x0603A284 RID: 238212 RVA: 0x0106687F File Offset: 0x01064A7F
		public int QuestId { get; set; }

		// Token: 0x17006E8A RID: 28298
		// (get) Token: 0x0603A285 RID: 238213 RVA: 0x01066888 File Offset: 0x01064A88
		// (set) Token: 0x0603A286 RID: 238214 RVA: 0x01066890 File Offset: 0x01064A90
		public int NodeId { get; set; }

		// Token: 0x17006E8B RID: 28299
		// (get) Token: 0x0603A287 RID: 238215 RVA: 0x01066899 File Offset: 0x01064A99
		// (set) Token: 0x0603A288 RID: 238216 RVA: 0x010668A1 File Offset: 0x01064AA1
		public int LeaveAreaId { get; set; }

		// Token: 0x17006E8C RID: 28300
		// (get) Token: 0x0603A289 RID: 238217 RVA: 0x010668AA File Offset: 0x01064AAA
		// (set) Token: 0x0603A28A RID: 238218 RVA: 0x010668B2 File Offset: 0x01064AB2
		public NodeStatus NodeState { get; set; }
	}
}
