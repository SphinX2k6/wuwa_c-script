using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D91 RID: 19857
	[NullableContext(1)]
	public interface IRoguelikeCharacterSelectOpenParam
	{
		// Token: 0x17007E8E RID: 32398
		// (get) Token: 0x060334F7 RID: 210167
		// (set) Token: 0x060334F8 RID: 210168
		int Index { get; set; }

		// Token: 0x17007E8F RID: 32399
		// (get) Token: 0x060334F9 RID: 210169
		// (set) Token: 0x060334FA RID: 210170
		List<int> RoomIdList { get; set; }
	}
}
