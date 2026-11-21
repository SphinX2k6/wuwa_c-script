using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A1 RID: 417
	[EnumExtensions]
	public enum EPsActivityEndActivityOutcome
	{
		// Token: 0x0400075E RID: 1886
		[EnumStringMember("completed")]
		Completed,
		// Token: 0x0400075F RID: 1887
		[EnumStringMember("failed")]
		Failed,
		// Token: 0x04000760 RID: 1888
		[EnumStringMember("abandoned")]
		Abandoned
	}
}
