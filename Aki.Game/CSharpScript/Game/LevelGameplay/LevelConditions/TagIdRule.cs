using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C5D RID: 27741
	[NullableContext(1)]
	[Nullable(0)]
	public class TagIdRule
	{
		// Token: 0x040239AD RID: 145837
		public List<int> RequireTags = new List<int>();

		// Token: 0x040239AE RID: 145838
		public List<int> BanTags = new List<int>();

		// Token: 0x040239AF RID: 145839
		public bool LastReached;
	}
}
