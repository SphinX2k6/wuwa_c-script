using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061F7 RID: 25079
	[NullableContext(1)]
	public interface ITabGroupData
	{
		// Token: 0x1700922A RID: 37418
		// (get) Token: 0x0603F47D RID: 259197
		// (set) Token: 0x0603F47E RID: 259198
		List<MotorChallengePlayData> TabDataList { get; set; }

		// Token: 0x1700922B RID: 37419
		// (get) Token: 0x0603F47F RID: 259199
		// (set) Token: 0x0603F480 RID: 259200
		[Nullable(2)]
		string GroupTitleId { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
