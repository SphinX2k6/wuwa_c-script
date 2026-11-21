using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BE8 RID: 15336
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffQuestionResultJsonConfig : ISheriffQuestionResultJsonConfig
	{
		// Token: 0x17005044 RID: 20548
		// (get) Token: 0x06027551 RID: 161105 RVA: 0x00B07CDF File Offset: 0x00B05EDF
		// (set) Token: 0x06027552 RID: 161106 RVA: 0x00B07CE7 File Offset: 0x00B05EE7
		public List<int> ClueCombination { get; set; } = new List<int>();

		// Token: 0x17005045 RID: 20549
		// (get) Token: 0x06027553 RID: 161107 RVA: 0x00B07CF0 File Offset: 0x00B05EF0
		// (set) Token: 0x06027554 RID: 161108 RVA: 0x00B07CF8 File Offset: 0x00B05EF8
		public List<string> ReasoningStateId { get; set; } = new List<string>();

		// Token: 0x17005046 RID: 20550
		// (get) Token: 0x06027555 RID: 161109 RVA: 0x00B07D01 File Offset: 0x00B05F01
		// (set) Token: 0x06027556 RID: 161110 RVA: 0x00B07D09 File Offset: 0x00B05F09
		public List<string> ResultDesc { get; set; } = new List<string>();

		// Token: 0x17005047 RID: 20551
		// (get) Token: 0x06027557 RID: 161111 RVA: 0x00B07D12 File Offset: 0x00B05F12
		// (set) Token: 0x06027558 RID: 161112 RVA: 0x00B07D1A File Offset: 0x00B05F1A
		public int? NextQuestionId { get; set; }

		// Token: 0x17005048 RID: 20552
		// (get) Token: 0x06027559 RID: 161113 RVA: 0x00B07D23 File Offset: 0x00B05F23
		// (set) Token: 0x0602755A RID: 161114 RVA: 0x00B07D2B File Offset: 0x00B05F2B
		public int? CaseProgressId { get; set; }

		// Token: 0x17005049 RID: 20553
		// (get) Token: 0x0602755B RID: 161115 RVA: 0x00B07D34 File Offset: 0x00B05F34
		// (set) Token: 0x0602755C RID: 161116 RVA: 0x00B07D3C File Offset: 0x00B05F3C
		public int? EndingId { get; set; }
	}
}
