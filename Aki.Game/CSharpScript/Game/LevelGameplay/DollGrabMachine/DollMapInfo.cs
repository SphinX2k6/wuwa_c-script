using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EB7 RID: 28343
	public class DollMapInfo
	{
		// Token: 0x04023F1A RID: 147226
		[Nullable(1)]
		public HashSet<int> CollectItemIdSet = new HashSet<int>();

		// Token: 0x04023F1B RID: 147227
		public int CurrentScore;
	}
}
