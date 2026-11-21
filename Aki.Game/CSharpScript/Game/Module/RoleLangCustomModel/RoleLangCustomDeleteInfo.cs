using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02003D3E RID: 15678
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomDeleteInfo : IRoleLangCustomDeleteInfo
	{
		// Token: 0x17005222 RID: 21026
		// (get) Token: 0x06028254 RID: 164436 RVA: 0x00B3C492 File Offset: 0x00B3A692
		// (set) Token: 0x06028255 RID: 164437 RVA: 0x00B3C49A File Offset: 0x00B3A69A
		public int RoleId { get; set; }

		// Token: 0x17005223 RID: 21027
		// (get) Token: 0x06028256 RID: 164438 RVA: 0x00B3C4A3 File Offset: 0x00B3A6A3
		// (set) Token: 0x06028257 RID: 164439 RVA: 0x00B3C4AB File Offset: 0x00B3A6AB
		public Action RefreshCallback { get; set; }

		// Token: 0x17005224 RID: 21028
		// (get) Token: 0x06028258 RID: 164440 RVA: 0x00B3C4B4 File Offset: 0x00B3A6B4
		// (set) Token: 0x06028259 RID: 164441 RVA: 0x00B3C4BC File Offset: 0x00B3A6BC
		public Action CloseCallback { get; set; }
	}
}
