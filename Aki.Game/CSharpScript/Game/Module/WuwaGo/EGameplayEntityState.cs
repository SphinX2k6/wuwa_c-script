using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200362B RID: 13867
	[EnumExtensions]
	public enum EGameplayEntityState
	{
		// Token: 0x04014168 RID: 82280
		[EnumStringMember("关卡.Common.状态.封锁")]
		Locked,
		// Token: 0x04014169 RID: 82281
		[EnumStringMember("关卡.Common.状态.常态")]
		Normal,
		// Token: 0x0401416A RID: 82282
		[EnumStringMember("关卡.Common.状态.激活")]
		Activated,
		// Token: 0x0401416B RID: 82283
		[EnumStringMember("关卡.Common.状态.完成")]
		Completed
	}
}
