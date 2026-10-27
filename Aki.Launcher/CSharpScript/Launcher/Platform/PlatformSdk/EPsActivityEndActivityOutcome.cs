using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200019D RID: 413
	[EnumExtensions]
	public enum EPsActivityEndActivityOutcome
	{
		// Token: 0x04000722 RID: 1826
		[EnumStringMember("completed")]
		Completed,
		// Token: 0x04000723 RID: 1827
		[EnumStringMember("failed")]
		Failed,
		// Token: 0x04000724 RID: 1828
		[EnumStringMember("abandoned")]
		Abandoned
	}
}
