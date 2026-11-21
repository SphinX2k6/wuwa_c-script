using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DD7 RID: 24023
	[NullableContext(1)]
	[Nullable(0)]
	public class TagIdRule
	{
		// Token: 0x0401EC4F RID: 126031
		public List<int> RequireTags = new List<int>();

		// Token: 0x0401EC50 RID: 126032
		public List<int> BanTags = new List<int>();

		// Token: 0x0401EC51 RID: 126033
		public bool LastReached;
	}
}
