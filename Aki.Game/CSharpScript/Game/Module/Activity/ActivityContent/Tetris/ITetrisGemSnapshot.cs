using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FEE RID: 24558
	[NullableContext(1)]
	public interface ITetrisGemSnapshot
	{
		// Token: 0x17009052 RID: 36946
		// (get) Token: 0x0603E393 RID: 254867
		// (set) Token: 0x0603E394 RID: 254868
		Dictionary<EGemType, int> CollectedGems { get; set; }

		// Token: 0x17009053 RID: 36947
		// (get) Token: 0x0603E395 RID: 254869
		// (set) Token: 0x0603E396 RID: 254870
		List<EGemType> CurrentGemBag { get; set; }

		// Token: 0x17009054 RID: 36948
		// (get) Token: 0x0603E397 RID: 254871
		// (set) Token: 0x0603E398 RID: 254872
		Dictionary<EGemType, int> SpawnCounts { get; set; }
	}
}
