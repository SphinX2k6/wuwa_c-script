using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D5A RID: 15706
	[NullableContext(1)]
	public interface IRoguelikeCharacterSelectOpenParam
	{
		// Token: 0x1700523E RID: 21054
		// (get) Token: 0x06028364 RID: 164708
		// (set) Token: 0x06028365 RID: 164709
		int Index { get; set; }

		// Token: 0x1700523F RID: 21055
		// (get) Token: 0x06028366 RID: 164710
		// (set) Token: 0x06028367 RID: 164711
		List<int> RoomIdList { get; set; }
	}
}
