using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C8 RID: 456
	[NullableContext(1)]
	public interface IKuroSdkController
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000C51 RID: 3153
		// (set) Token: 0x06000C52 RID: 3154
		Func<bool> CanUseSdk { get; set; }
	}
}
