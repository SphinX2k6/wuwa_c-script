using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace
{
	// Token: 0x02006A5F RID: 27231
	[NullableContext(1)]
	[Nullable(0)]
	public class SeekTraceItemData
	{
		// Token: 0x040235CB RID: 144843
		public ESeekTraceItemEffectType ItemType;

		// Token: 0x040235CC RID: 144844
		public int[] BasePosition = new int[2];

		// Token: 0x040235CD RID: 144845
		public readonly List<int[]> FilledPositionOffsetList = new List<int[]>();

		// Token: 0x040235CE RID: 144846
		public readonly HashSet<int> FilledIndexSet = new HashSet<int>();

		// Token: 0x040235CF RID: 144847
		public bool IsValid = true;
	}
}
