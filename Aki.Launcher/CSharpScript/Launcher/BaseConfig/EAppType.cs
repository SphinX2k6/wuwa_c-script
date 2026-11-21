using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000275 RID: 629
	[EnumExtensions]
	public enum EAppType
	{
		// Token: 0x04000A59 RID: 2649
		[EnumStringMember("Development")]
		DEVELOPMENT,
		// Token: 0x04000A5A RID: 2650
		[EnumStringMember("Prerelease")]
		PREREKEASE,
		// Token: 0x04000A5B RID: 2651
		[EnumStringMember("Product")]
		PRODUCT
	}
}
