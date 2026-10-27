using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200014E RID: 334
	[EnumExtensions]
	public enum ETeleControlLockingPerform
	{
		// Token: 0x0400066E RID: 1646
		[EnumStringMember("关卡.Common.表现.被控物.匹配正确")]
		RightMatch,
		// Token: 0x0400066F RID: 1647
		[EnumStringMember("关卡.Common.表现.被控物.匹配错误")]
		WrongMatch
	}
}
