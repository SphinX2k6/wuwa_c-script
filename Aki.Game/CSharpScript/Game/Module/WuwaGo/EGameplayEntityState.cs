using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x020046FB RID: 18171
	[EnumExtensions]
	public enum EGameplayEntityState
	{
		// Token: 0x04019AB9 RID: 105145
		[EnumStringMember("关卡.Common.状态.封锁")]
		Locked,
		// Token: 0x04019ABA RID: 105146
		[EnumStringMember("关卡.Common.状态.常态")]
		Normal,
		// Token: 0x04019ABB RID: 105147
		[EnumStringMember("关卡.Common.状态.激活")]
		Activated,
		// Token: 0x04019ABC RID: 105148
		[EnumStringMember("关卡.Common.状态.完成")]
		Completed
	}
}
