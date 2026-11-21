using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D5B RID: 15707
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeCharacterSelectOpenParam : IRoguelikeCharacterSelectOpenParam
	{
		// Token: 0x17005240 RID: 21056
		// (get) Token: 0x06028368 RID: 164712 RVA: 0x00B4367A File Offset: 0x00B4187A
		// (set) Token: 0x06028369 RID: 164713 RVA: 0x00B43682 File Offset: 0x00B41882
		public int Index { get; set; }

		// Token: 0x17005241 RID: 21057
		// (get) Token: 0x0602836A RID: 164714 RVA: 0x00B4368B File Offset: 0x00B4188B
		// (set) Token: 0x0602836B RID: 164715 RVA: 0x00B43693 File Offset: 0x00B41893
		public List<int> RoomIdList { get; set; }
	}
}
