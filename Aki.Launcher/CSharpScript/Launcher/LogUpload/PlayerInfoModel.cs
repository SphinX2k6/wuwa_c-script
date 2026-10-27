using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C8 RID: 456
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerInfoModel : IPlayerInfoModel
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0004B617 File Offset: 0x00049817
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x0004B61F File Offset: 0x0004981F
		public Func<int?> GetId { get; set; }
	}
}
