using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x020046F8 RID: 18168
	[NullableContext(1)]
	public interface IKurotatoPopupUnlockRoleOpenParam
	{
		// Token: 0x17005C24 RID: 23588
		// (get) Token: 0x0602DA83 RID: 187011
		// (set) Token: 0x0602DA84 RID: 187012
		List<int> RoleIds { get; set; }

		// Token: 0x17005C25 RID: 23589
		// (get) Token: 0x0602DA85 RID: 187013
		// (set) Token: 0x0602DA86 RID: 187014
		int Index { get; set; }
	}
}
