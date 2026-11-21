using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x020046F9 RID: 18169
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupUnlockRoleOpenParam : IKurotatoPopupUnlockRoleOpenParam
	{
		// Token: 0x17005C26 RID: 23590
		// (get) Token: 0x0602DA87 RID: 187015 RVA: 0x00CC3D48 File Offset: 0x00CC1F48
		// (set) Token: 0x0602DA88 RID: 187016 RVA: 0x00CC3D50 File Offset: 0x00CC1F50
		public List<int> RoleIds { get; set; } = new List<int>();

		// Token: 0x17005C27 RID: 23591
		// (get) Token: 0x0602DA89 RID: 187017 RVA: 0x00CC3D59 File Offset: 0x00CC1F59
		// (set) Token: 0x0602DA8A RID: 187018 RVA: 0x00CC3D61 File Offset: 0x00CC1F61
		public int Index { get; set; }
	}
}
