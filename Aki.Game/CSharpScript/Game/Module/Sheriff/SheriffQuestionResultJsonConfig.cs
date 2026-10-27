using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C37 RID: 19511
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffQuestionResultJsonConfig : ISheriffQuestionResultJsonConfig
	{
		// Token: 0x17007C9A RID: 31898
		// (get) Token: 0x0603279E RID: 206750 RVA: 0x00BC30C7 File Offset: 0x00BC12C7
		// (set) Token: 0x0603279F RID: 206751 RVA: 0x00BC30CF File Offset: 0x00BC12CF
		public List<int> ClueCombination { get; set; } = new List<int>();

		// Token: 0x17007C9B RID: 31899
		// (get) Token: 0x060327A0 RID: 206752 RVA: 0x00BC30D8 File Offset: 0x00BC12D8
		// (set) Token: 0x060327A1 RID: 206753 RVA: 0x00BC30E0 File Offset: 0x00BC12E0
		public List<string> ReasoningStateId { get; set; } = new List<string>();

		// Token: 0x17007C9C RID: 31900
		// (get) Token: 0x060327A2 RID: 206754 RVA: 0x00BC30E9 File Offset: 0x00BC12E9
		// (set) Token: 0x060327A3 RID: 206755 RVA: 0x00BC30F1 File Offset: 0x00BC12F1
		public List<string> ResultDesc { get; set; } = new List<string>();

		// Token: 0x17007C9D RID: 31901
		// (get) Token: 0x060327A4 RID: 206756 RVA: 0x00BC30FA File Offset: 0x00BC12FA
		// (set) Token: 0x060327A5 RID: 206757 RVA: 0x00BC3102 File Offset: 0x00BC1302
		public int? NextQuestionId { get; set; }

		// Token: 0x17007C9E RID: 31902
		// (get) Token: 0x060327A6 RID: 206758 RVA: 0x00BC310B File Offset: 0x00BC130B
		// (set) Token: 0x060327A7 RID: 206759 RVA: 0x00BC3113 File Offset: 0x00BC1313
		public int? CaseProgressId { get; set; }

		// Token: 0x17007C9F RID: 31903
		// (get) Token: 0x060327A8 RID: 206760 RVA: 0x00BC311C File Offset: 0x00BC131C
		// (set) Token: 0x060327A9 RID: 206761 RVA: 0x00BC3124 File Offset: 0x00BC1324
		public int? EndingId { get; set; }
	}
}
