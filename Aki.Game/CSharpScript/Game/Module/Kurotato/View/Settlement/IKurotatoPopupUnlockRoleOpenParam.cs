using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005721 RID: 22305
	[NullableContext(1)]
	public interface IKurotatoPopupUnlockRoleOpenParam
	{
		// Token: 0x1700885C RID: 34908
		// (get) Token: 0x06038B74 RID: 232308
		// (set) Token: 0x06038B75 RID: 232309
		List<int> RoleIds { get; set; }

		// Token: 0x1700885D RID: 34909
		// (get) Token: 0x06038B76 RID: 232310
		// (set) Token: 0x06038B77 RID: 232311
		int Index { get; set; }
	}
}
