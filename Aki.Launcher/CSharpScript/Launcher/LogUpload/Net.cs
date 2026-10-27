using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C7 RID: 455
	[NullableContext(1)]
	[Nullable(0)]
	public class Net : INet
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0004B5FE File Offset: 0x000497FE
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0004B606 File Offset: 0x00049806
		public Func<bool> IsServerConnected { get; set; }
	}
}
