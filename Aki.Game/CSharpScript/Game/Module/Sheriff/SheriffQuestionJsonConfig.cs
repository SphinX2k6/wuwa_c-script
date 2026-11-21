using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BE5 RID: 15333
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffQuestionJsonConfig : ISheriffQuestionJsonConfig
	{
		// Token: 0x1700503C RID: 20540
		// (get) Token: 0x0602753D RID: 161085 RVA: 0x00B07C8A File Offset: 0x00B05E8A
		// (set) Token: 0x0602753E RID: 161086 RVA: 0x00B07C92 File Offset: 0x00B05E92
		public int QuestionId { get; set; }

		// Token: 0x1700503D RID: 20541
		// (get) Token: 0x0602753F RID: 161087 RVA: 0x00B07C9B File Offset: 0x00B05E9B
		// (set) Token: 0x06027540 RID: 161088 RVA: 0x00B07CA3 File Offset: 0x00B05EA3
		public List<ISheriffQuestionResultJsonConfig> ResultConfigs { get; set; } = new List<ISheriffQuestionResultJsonConfig>();
	}
}
