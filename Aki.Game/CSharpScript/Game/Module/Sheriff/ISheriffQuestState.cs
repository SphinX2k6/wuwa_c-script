using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C45 RID: 19525
	[NullableContext(1)]
	public interface ISheriffQuestState
	{
		// Token: 0x17007CBA RID: 31930
		// (get) Token: 0x060327E6 RID: 206822
		// (set) Token: 0x060327E7 RID: 206823
		List<int> UnFinishList { get; set; }

		// Token: 0x17007CBB RID: 31931
		// (get) Token: 0x060327E8 RID: 206824
		// (set) Token: 0x060327E9 RID: 206825
		List<int> TotalList { get; set; }
	}
}
