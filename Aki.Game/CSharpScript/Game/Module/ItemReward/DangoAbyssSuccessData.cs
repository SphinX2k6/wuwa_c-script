using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057DF RID: 22495
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoAbyssSuccessData : IDangoAbyssSuccessData
	{
		// Token: 0x170089EA RID: 35306
		// (get) Token: 0x060392E7 RID: 234215 RVA: 0x00D90363 File Offset: 0x00D8E563
		// (set) Token: 0x060392E8 RID: 234216 RVA: 0x00D9036B File Offset: 0x00D8E56B
		public List<RewardItemData> RewardItemData { get; set; }

		// Token: 0x170089EB RID: 35307
		// (get) Token: 0x060392E9 RID: 234217 RVA: 0x00D90374 File Offset: 0x00D8E574
		// (set) Token: 0x060392EA RID: 234218 RVA: 0x00D9037C File Offset: 0x00D8E57C
		public float Progress { get; set; }
	}
}
