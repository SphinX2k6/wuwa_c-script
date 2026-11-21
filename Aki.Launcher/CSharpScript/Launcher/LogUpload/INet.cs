using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C5 RID: 453
	[NullableContext(1)]
	public interface INet
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000C4B RID: 3147
		// (set) Token: 0x06000C4C RID: 3148
		Func<bool> IsServerConnected { get; set; }
	}
}
