using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048EC RID: 18668
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureMissionItemData
	{
		// Token: 0x17005EA7 RID: 24231
		// (get) Token: 0x0602EDB6 RID: 191926 RVA: 0x00D112BA File Offset: 0x00D0F4BA
		// (set) Token: 0x0602EDB7 RID: 191927 RVA: 0x00D112C2 File Offset: 0x00D0F4C2
		public string DesText { get; set; }

		// Token: 0x17005EA8 RID: 24232
		// (get) Token: 0x0602EDB8 RID: 191928 RVA: 0x00D112CB File Offset: 0x00D0F4CB
		// (set) Token: 0x0602EDB9 RID: 191929 RVA: 0x00D112D3 File Offset: 0x00D0F4D3
		public int MaxCount { get; set; }

		// Token: 0x17005EA9 RID: 24233
		// (get) Token: 0x0602EDBA RID: 191930 RVA: 0x00D112DC File Offset: 0x00D0F4DC
		// (set) Token: 0x0602EDBB RID: 191931 RVA: 0x00D112E4 File Offset: 0x00D0F4E4
		public int CurrentCount { get; set; }
	}
}
