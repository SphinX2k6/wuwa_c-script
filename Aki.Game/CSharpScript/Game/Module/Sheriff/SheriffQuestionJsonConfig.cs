using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C34 RID: 19508
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffQuestionJsonConfig : ISheriffQuestionJsonConfig
	{
		// Token: 0x17007C92 RID: 31890
		// (get) Token: 0x0603278A RID: 206730 RVA: 0x00BC3072 File Offset: 0x00BC1272
		// (set) Token: 0x0603278B RID: 206731 RVA: 0x00BC307A File Offset: 0x00BC127A
		public int QuestionId { get; set; }

		// Token: 0x17007C93 RID: 31891
		// (get) Token: 0x0603278C RID: 206732 RVA: 0x00BC3083 File Offset: 0x00BC1283
		// (set) Token: 0x0603278D RID: 206733 RVA: 0x00BC308B File Offset: 0x00BC128B
		public List<ISheriffQuestionResultJsonConfig> ResultConfigs { get; set; } = new List<ISheriffQuestionResultJsonConfig>();
	}
}
