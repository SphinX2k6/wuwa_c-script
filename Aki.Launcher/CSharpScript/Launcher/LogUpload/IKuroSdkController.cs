using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C4 RID: 452
	[NullableContext(1)]
	public interface IKuroSdkController
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000C1A RID: 3098
		// (set) Token: 0x06000C1B RID: 3099
		Func<bool> CanUseSdk { get; set; }
	}
}
