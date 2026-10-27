using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000072 RID: 114
	[EnumExtensions]
	public enum ESpecialValue
	{
		// Token: 0x04000228 RID: 552
		[EnumStringMember("___undefined___")]
		Undefined,
		// Token: 0x04000229 RID: 553
		[EnumStringMember("___NaN___")]
		NaN,
		// Token: 0x0400022A RID: 554
		[EnumStringMember("___Infinity___")]
		Infinity,
		// Token: 0x0400022B RID: 555
		[EnumStringMember("___-Infinity___")]
		InfinityNegative,
		// Token: 0x0400022C RID: 556
		[EnumStringMember("___BI___")]
		BigInt,
		// Token: 0x0400022D RID: 557
		[EnumStringMember("___1B___")]
		BooleanTrue,
		// Token: 0x0400022E RID: 558
		[EnumStringMember("___0B___")]
		BooleanFalse
	}
}
