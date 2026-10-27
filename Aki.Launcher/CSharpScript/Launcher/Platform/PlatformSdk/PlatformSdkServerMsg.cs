using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000191 RID: 401
	[EnumExtensions]
	public enum PlatformSdkServerMsg
	{
		// Token: 0x040006CE RID: 1742
		[EnumStringMember("HttpFail")]
		BadHttp,
		// Token: 0x040006CF RID: 1743
		[EnumStringMember("PsnAuthFail")]
		PsnAuthFail
	}
}
