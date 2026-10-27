using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D95 RID: 19861
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeRoleAffixDetailViewParam : IRoguelikeRoleAffixDetailViewParam
	{
		// Token: 0x17007E94 RID: 32404
		// (get) Token: 0x06033505 RID: 210181 RVA: 0x00BFA0CC File Offset: 0x00BF82CC
		// (set) Token: 0x06033506 RID: 210182 RVA: 0x00BFA0D4 File Offset: 0x00BF82D4
		public int Index { get; set; }

		// Token: 0x17007E95 RID: 32405
		// (get) Token: 0x06033507 RID: 210183 RVA: 0x00BFA0DD File Offset: 0x00BF82DD
		// (set) Token: 0x06033508 RID: 210184 RVA: 0x00BFA0E5 File Offset: 0x00BF82E5
		public List<int> AffixIds { get; set; }
	}
}
