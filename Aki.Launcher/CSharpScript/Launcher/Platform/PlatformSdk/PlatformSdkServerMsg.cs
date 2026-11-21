using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000195 RID: 405
	[EnumExtensions]
	public enum PlatformSdkServerMsg
	{
		// Token: 0x04000709 RID: 1801
		[EnumStringMember("HttpFail")]
		BadHttp,
		// Token: 0x0400070A RID: 1802
		[EnumStringMember("PsnAuthFail")]
		PsnAuthFail
	}
}
