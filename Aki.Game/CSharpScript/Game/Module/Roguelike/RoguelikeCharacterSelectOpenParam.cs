using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D92 RID: 19858
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeCharacterSelectOpenParam : IRoguelikeCharacterSelectOpenParam
	{
		// Token: 0x17007E90 RID: 32400
		// (get) Token: 0x060334FB RID: 210171 RVA: 0x00BFA07E File Offset: 0x00BF827E
		// (set) Token: 0x060334FC RID: 210172 RVA: 0x00BFA086 File Offset: 0x00BF8286
		public int Index { get; set; }

		// Token: 0x17007E91 RID: 32401
		// (get) Token: 0x060334FD RID: 210173 RVA: 0x00BFA08F File Offset: 0x00BF828F
		// (set) Token: 0x060334FE RID: 210174 RVA: 0x00BFA097 File Offset: 0x00BF8297
		public List<int> RoomIdList { get; set; }
	}
}
