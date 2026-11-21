using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CE RID: 462
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroSdkController : IKuroSdkController
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0004DE5D File Offset: 0x0004C05D
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x0004DE65 File Offset: 0x0004C065
		public Func<bool> CanUseSdk { get; set; }
	}
}
