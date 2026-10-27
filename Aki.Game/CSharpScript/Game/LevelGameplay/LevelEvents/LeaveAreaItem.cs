using System;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B34 RID: 27444
	internal class LeaveAreaItem : ILeaveAreaItem
	{
		// Token: 0x17009986 RID: 39302
		// (get) Token: 0x06044131 RID: 278833 RVA: 0x010BCFEB File Offset: 0x010BB1EB
		// (set) Token: 0x06044132 RID: 278834 RVA: 0x010BCFF3 File Offset: 0x010BB1F3
		public int QuestId { get; set; }

		// Token: 0x17009987 RID: 39303
		// (get) Token: 0x06044133 RID: 278835 RVA: 0x010BCFFC File Offset: 0x010BB1FC
		// (set) Token: 0x06044134 RID: 278836 RVA: 0x010BD004 File Offset: 0x010BB204
		public int NodeId { get; set; }

		// Token: 0x17009988 RID: 39304
		// (get) Token: 0x06044135 RID: 278837 RVA: 0x010BD00D File Offset: 0x010BB20D
		// (set) Token: 0x06044136 RID: 278838 RVA: 0x010BD015 File Offset: 0x010BB215
		public int LeaveAreaId { get; set; }

		// Token: 0x17009989 RID: 39305
		// (get) Token: 0x06044137 RID: 278839 RVA: 0x010BD01E File Offset: 0x010BB21E
		// (set) Token: 0x06044138 RID: 278840 RVA: 0x010BD026 File Offset: 0x010BB226
		public NodeStatus NodeState { get; set; }
	}
}
