using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005175 RID: 20853
	[NullableContext(1)]
	public interface ITabGroupData
	{
		// Token: 0x1700658C RID: 25996
		// (get) Token: 0x0603413E RID: 213310
		// (set) Token: 0x0603413F RID: 213311
		List<MotorChallengePlayData> TabDataList { get; set; }

		// Token: 0x1700658D RID: 25997
		// (get) Token: 0x06034140 RID: 213312
		// (set) Token: 0x06034141 RID: 213313
		[Nullable(2)]
		string GroupTitleId { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
