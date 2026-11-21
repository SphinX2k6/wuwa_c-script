using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000161 RID: 353
	[EnumExtensions]
	public enum ETeleControlLockingPerform
	{
		// Token: 0x040006B3 RID: 1715
		[EnumStringMember("关卡.Common.表现.被控物.匹配正确")]
		RightMatch,
		// Token: 0x040006B4 RID: 1716
		[EnumStringMember("关卡.Common.表现.被控物.匹配错误")]
		WrongMatch
	}
}
