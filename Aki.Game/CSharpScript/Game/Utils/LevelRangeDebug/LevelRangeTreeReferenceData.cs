using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.LevelRangeDebug
{
	// Token: 0x02004566 RID: 17766
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelRangeTreeReferenceData
	{
		// Token: 0x04018823 RID: 100387
		public HashSet<int> LevelPlayIds = new HashSet<int>();

		// Token: 0x04018824 RID: 100388
		public HashSet<int> PbDataIds = new HashSet<int>();
	}
}
