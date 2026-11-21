using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CC RID: 460
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerInfoModel : IPlayerInfoModel
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0004DE2B File Offset: 0x0004C02B
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x0004DE33 File Offset: 0x0004C033
		public Func<int?> GetId { get; set; }
	}
}
