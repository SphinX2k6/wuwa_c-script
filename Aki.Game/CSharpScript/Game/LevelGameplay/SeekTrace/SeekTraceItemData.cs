using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace
{
	// Token: 0x02005BBC RID: 23484
	[NullableContext(1)]
	[Nullable(0)]
	public class SeekTraceItemData
	{
		// Token: 0x0401E7BD RID: 124861
		public ESeekTraceItemEffectType ItemType;

		// Token: 0x0401E7BE RID: 124862
		public int[] BasePosition = new int[2];

		// Token: 0x0401E7BF RID: 124863
		public readonly List<int[]> FilledPositionOffsetList = new List<int[]>();

		// Token: 0x0401E7C0 RID: 124864
		public readonly HashSet<int> FilledIndexSet = new HashSet<int>();

		// Token: 0x0401E7C1 RID: 124865
		public bool IsValid = true;
	}
}
