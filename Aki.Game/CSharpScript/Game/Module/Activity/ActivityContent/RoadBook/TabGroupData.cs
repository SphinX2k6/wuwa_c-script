using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005176 RID: 20854
	[NullableContext(1)]
	[Nullable(0)]
	public class TabGroupData : ITabGroupData
	{
		// Token: 0x1700658E RID: 25998
		// (get) Token: 0x06034142 RID: 213314 RVA: 0x00E91B7B File Offset: 0x00E8FD7B
		// (set) Token: 0x06034143 RID: 213315 RVA: 0x00E91B83 File Offset: 0x00E8FD83
		public List<MotorChallengePlayData> TabDataList { get; set; } = new List<MotorChallengePlayData>();

		// Token: 0x1700658F RID: 25999
		// (get) Token: 0x06034144 RID: 213316 RVA: 0x00E91B8C File Offset: 0x00E8FD8C
		// (set) Token: 0x06034145 RID: 213317 RVA: 0x00E91B94 File Offset: 0x00E8FD94
		[Nullable(2)]
		public string GroupTitleId { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
