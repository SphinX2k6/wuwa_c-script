using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C9 RID: 457
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorage : ILocalStorage
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0004B630 File Offset: 0x00049830
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x0004B638 File Offset: 0x00049838
		public Func<int?> GetRecentlyLoginUid { get; set; }
	}
}
