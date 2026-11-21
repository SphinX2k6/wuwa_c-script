using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D5E RID: 15710
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeRoleAffixDetailViewParam : IRoguelikeRoleAffixDetailViewParam
	{
		// Token: 0x17005244 RID: 21060
		// (get) Token: 0x06028372 RID: 164722 RVA: 0x00B436C8 File Offset: 0x00B418C8
		// (set) Token: 0x06028373 RID: 164723 RVA: 0x00B436D0 File Offset: 0x00B418D0
		public int Index { get; set; }

		// Token: 0x17005245 RID: 21061
		// (get) Token: 0x06028374 RID: 164724 RVA: 0x00B436D9 File Offset: 0x00B418D9
		// (set) Token: 0x06028375 RID: 164725 RVA: 0x00B436E1 File Offset: 0x00B418E1
		public List<int> AffixIds { get; set; }
	}
}
