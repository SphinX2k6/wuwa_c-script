using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BF7 RID: 15351
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffQuestState : ISheriffQuestState
	{
		// Token: 0x17005066 RID: 20582
		// (get) Token: 0x0602759D RID: 161181 RVA: 0x00B07F3F File Offset: 0x00B0613F
		// (set) Token: 0x0602759E RID: 161182 RVA: 0x00B07F47 File Offset: 0x00B06147
		public List<int> UnFinishList { get; set; } = new List<int>();

		// Token: 0x17005067 RID: 20583
		// (get) Token: 0x0602759F RID: 161183 RVA: 0x00B07F50 File Offset: 0x00B06150
		// (set) Token: 0x060275A0 RID: 161184 RVA: 0x00B07F58 File Offset: 0x00B06158
		public List<int> TotalList { get; set; } = new List<int>();
	}
}
