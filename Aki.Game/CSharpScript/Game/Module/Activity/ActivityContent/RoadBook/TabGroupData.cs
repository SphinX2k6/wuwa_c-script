using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061F8 RID: 25080
	[NullableContext(1)]
	[Nullable(0)]
	public class TabGroupData : ITabGroupData
	{
		// Token: 0x1700922C RID: 37420
		// (get) Token: 0x0603F481 RID: 259201 RVA: 0x00F4AC23 File Offset: 0x00F48E23
		// (set) Token: 0x0603F482 RID: 259202 RVA: 0x00F4AC2B File Offset: 0x00F48E2B
		public List<MotorChallengePlayData> TabDataList { get; set; } = new List<MotorChallengePlayData>();

		// Token: 0x1700922D RID: 37421
		// (get) Token: 0x0603F483 RID: 259203 RVA: 0x00F4AC34 File Offset: 0x00F48E34
		// (set) Token: 0x0603F484 RID: 259204 RVA: 0x00F4AC3C File Offset: 0x00F48E3C
		[Nullable(2)]
		public string GroupTitleId { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
