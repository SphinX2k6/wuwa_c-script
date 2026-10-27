using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006608 RID: 26120
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingDockQuestChildItemData : IFishingDockQuestChildItemData
	{
		// Token: 0x170095FD RID: 38397
		// (get) Token: 0x06041762 RID: 268130 RVA: 0x00FDA359 File Offset: 0x00FD8559
		// (set) Token: 0x06041763 RID: 268131 RVA: 0x00FDA361 File Offset: 0x00FD8561
		public string DesText { get; set; }

		// Token: 0x170095FE RID: 38398
		// (get) Token: 0x06041764 RID: 268132 RVA: 0x00FDA36A File Offset: 0x00FD856A
		// (set) Token: 0x06041765 RID: 268133 RVA: 0x00FDA372 File Offset: 0x00FD8572
		public int MaxCount { get; set; }

		// Token: 0x170095FF RID: 38399
		// (get) Token: 0x06041766 RID: 268134 RVA: 0x00FDA37B File Offset: 0x00FD857B
		// (set) Token: 0x06041767 RID: 268135 RVA: 0x00FDA383 File Offset: 0x00FD8583
		public int CurrentCount { get; set; }
	}
}
