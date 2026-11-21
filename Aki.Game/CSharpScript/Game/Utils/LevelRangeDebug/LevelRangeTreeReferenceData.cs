using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.LevelRangeDebug
{
	// Token: 0x0200348E RID: 13454
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelRangeTreeReferenceData
	{
		// Token: 0x04012E5D RID: 77405
		public HashSet<int> LevelPlayIds = new HashSet<int>();

		// Token: 0x04012E5E RID: 77406
		public HashSet<int> PbDataIds = new HashSet<int>();
	}
}
