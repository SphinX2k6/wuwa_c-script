using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02004D75 RID: 19829
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomDeleteInfo : IRoleLangCustomDeleteInfo
	{
		// Token: 0x17007E72 RID: 32370
		// (get) Token: 0x060333E6 RID: 209894 RVA: 0x00BF326E File Offset: 0x00BF146E
		// (set) Token: 0x060333E7 RID: 209895 RVA: 0x00BF3276 File Offset: 0x00BF1476
		public int RoleId { get; set; }

		// Token: 0x17007E73 RID: 32371
		// (get) Token: 0x060333E8 RID: 209896 RVA: 0x00BF327F File Offset: 0x00BF147F
		// (set) Token: 0x060333E9 RID: 209897 RVA: 0x00BF3287 File Offset: 0x00BF1487
		public Action RefreshCallback { get; set; }

		// Token: 0x17007E74 RID: 32372
		// (get) Token: 0x060333EA RID: 209898 RVA: 0x00BF3290 File Offset: 0x00BF1490
		// (set) Token: 0x060333EB RID: 209899 RVA: 0x00BF3298 File Offset: 0x00BF1498
		public Action CloseCallback { get; set; }
	}
}
