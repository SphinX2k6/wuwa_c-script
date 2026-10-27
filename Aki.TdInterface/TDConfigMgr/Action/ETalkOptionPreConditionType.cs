using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016CA RID: 5834
	[EnumExtensions]
	public enum ETalkOptionPreConditionType
	{
		// Token: 0x04004ED4 RID: 20180
		PreOption,
		// Token: 0x04004ED5 RID: 20181
		Condition,
		// Token: 0x04004ED6 RID: 20182
		[EnumStringMember("FirstAppear")]
		FirstSelect,
		// Token: 0x04004ED7 RID: 20183
		SystemCondition
	}
}
