using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C1 RID: 449
	[NullableContext(1)]
	public interface INet
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000C14 RID: 3092
		// (set) Token: 0x06000C15 RID: 3093
		Func<bool> IsServerConnected { get; set; }
	}
}
