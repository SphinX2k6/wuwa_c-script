using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BF6 RID: 15350
	[NullableContext(1)]
	public interface ISheriffQuestState
	{
		// Token: 0x17005064 RID: 20580
		// (get) Token: 0x06027599 RID: 161177
		// (set) Token: 0x0602759A RID: 161178
		List<int> UnFinishList { get; set; }

		// Token: 0x17005065 RID: 20581
		// (get) Token: 0x0602759B RID: 161179
		// (set) Token: 0x0602759C RID: 161180
		List<int> TotalList { get; set; }
	}
}
