using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000075 RID: 117
	[EnumExtensions]
	public enum ESpecialValue
	{
		// Token: 0x04000254 RID: 596
		[EnumStringMember("___undefined___")]
		Undefined,
		// Token: 0x04000255 RID: 597
		[EnumStringMember("___NaN___")]
		NaN,
		// Token: 0x04000256 RID: 598
		[EnumStringMember("___Infinity___")]
		Infinity,
		// Token: 0x04000257 RID: 599
		[EnumStringMember("___-Infinity___")]
		InfinityNegative,
		// Token: 0x04000258 RID: 600
		[EnumStringMember("___BI___")]
		BigInt,
		// Token: 0x04000259 RID: 601
		[EnumStringMember("___1B___")]
		BooleanTrue,
		// Token: 0x0400025A RID: 602
		[EnumStringMember("___0B___")]
		BooleanFalse
	}
}
