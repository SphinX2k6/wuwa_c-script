using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005722 RID: 22306
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupUnlockRoleOpenParam : IKurotatoPopupUnlockRoleOpenParam
	{
		// Token: 0x1700885E RID: 34910
		// (get) Token: 0x06038B78 RID: 232312 RVA: 0x00D75714 File Offset: 0x00D73914
		// (set) Token: 0x06038B79 RID: 232313 RVA: 0x00D7571C File Offset: 0x00D7391C
		public List<int> RoleIds { get; set; } = new List<int>();

		// Token: 0x1700885F RID: 34911
		// (get) Token: 0x06038B7A RID: 232314 RVA: 0x00D75725 File Offset: 0x00D73925
		// (set) Token: 0x06038B7B RID: 232315 RVA: 0x00D7572D File Offset: 0x00D7392D
		public int Index { get; set; }
	}
}
