using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C46 RID: 19526
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffQuestState : ISheriffQuestState
	{
		// Token: 0x17007CBC RID: 31932
		// (get) Token: 0x060327EA RID: 206826 RVA: 0x00BC3327 File Offset: 0x00BC1527
		// (set) Token: 0x060327EB RID: 206827 RVA: 0x00BC332F File Offset: 0x00BC152F
		public List<int> UnFinishList { get; set; } = new List<int>();

		// Token: 0x17007CBD RID: 31933
		// (get) Token: 0x060327EC RID: 206828 RVA: 0x00BC3338 File Offset: 0x00BC1538
		// (set) Token: 0x060327ED RID: 206829 RVA: 0x00BC3340 File Offset: 0x00BC1540
		public List<int> TotalList { get; set; } = new List<int>();
	}
}
