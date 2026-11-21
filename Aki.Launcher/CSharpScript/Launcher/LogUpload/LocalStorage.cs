using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CD RID: 461
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorage : ILocalStorage
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0004DE44 File Offset: 0x0004C044
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x0004DE4C File Offset: 0x0004C04C
		public Func<int?> GetRecentlyLoginUid { get; set; }
	}
}
