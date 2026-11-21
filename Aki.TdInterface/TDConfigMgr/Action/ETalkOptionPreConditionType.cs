using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001844 RID: 6212
	[EnumExtensions]
	public enum ETalkOptionPreConditionType
	{
		// Token: 0x040052FA RID: 21242
		PreOption,
		// Token: 0x040052FB RID: 21243
		Condition,
		// Token: 0x040052FC RID: 21244
		[EnumStringMember("FirstAppear")]
		FirstSelect,
		// Token: 0x040052FD RID: 21245
		SystemCondition
	}
}
