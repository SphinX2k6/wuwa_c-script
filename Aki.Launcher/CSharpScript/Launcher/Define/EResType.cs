using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000242 RID: 578
	[EnumExtensions]
	public enum EResType
	{
		// Token: 0x04000982 RID: 2434
		Launcher,
		// Token: 0x04000983 RID: 2435
		Resource,
		// Token: 0x04000984 RID: 2436
		Lang,
		// Token: 0x04000985 RID: 2437
		Video,
		// Token: 0x04000986 RID: 2438
		[EnumStringMember("Option")]
		Optional
	}
}
