using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FE9 RID: 20457
	[NullableContext(2)]
	[Nullable(0)]
	public class SummaryData
	{
		// Token: 0x17007FCF RID: 32719
		// (get) Token: 0x060345B2 RID: 214450 RVA: 0x00C4D88A File Offset: 0x00C4BA8A
		// (set) Token: 0x060345B3 RID: 214451 RVA: 0x00C4D892 File Offset: 0x00C4BA92
		[Nullable(1)]
		public string Text { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007FD0 RID: 32720
		// (get) Token: 0x060345B4 RID: 214452 RVA: 0x00C4D89B File Offset: 0x00C4BA9B
		// (set) Token: 0x060345B5 RID: 214453 RVA: 0x00C4D8A3 File Offset: 0x00C4BAA3
		public Action ConfirmFunc { get; set; }

		// Token: 0x17007FD1 RID: 32721
		// (get) Token: 0x060345B6 RID: 214454 RVA: 0x00C4D8AC File Offset: 0x00C4BAAC
		// (set) Token: 0x060345B7 RID: 214455 RVA: 0x00C4D8B4 File Offset: 0x00C4BAB4
		public Action CancelFunc { get; set; }
	}
}
