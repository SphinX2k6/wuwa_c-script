using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CB RID: 459
	[NullableContext(1)]
	[Nullable(0)]
	public class Net : INet
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0004DE12 File Offset: 0x0004C012
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0004DE1A File Offset: 0x0004C01A
		public Func<bool> IsServerConnected { get; set; }
	}
}
