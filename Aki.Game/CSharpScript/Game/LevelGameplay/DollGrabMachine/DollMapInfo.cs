using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006037 RID: 24631
	public class DollMapInfo
	{
		// Token: 0x0401F1CD RID: 127437
		[Nullable(1)]
		public HashSet<int> CollectItemIdSet = new HashSet<int>();

		// Token: 0x0401F1CE RID: 127438
		public int CurrentScore;
	}
}
