using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006607 RID: 26119
	[NullableContext(1)]
	public interface IFishingDockQuestChildItemData
	{
		// Token: 0x170095FA RID: 38394
		// (get) Token: 0x0604175C RID: 268124
		// (set) Token: 0x0604175D RID: 268125
		string DesText { get; set; }

		// Token: 0x170095FB RID: 38395
		// (get) Token: 0x0604175E RID: 268126
		// (set) Token: 0x0604175F RID: 268127
		int MaxCount { get; set; }

		// Token: 0x170095FC RID: 38396
		// (get) Token: 0x06041760 RID: 268128
		// (set) Token: 0x06041761 RID: 268129
		int CurrentCount { get; set; }
	}
}
