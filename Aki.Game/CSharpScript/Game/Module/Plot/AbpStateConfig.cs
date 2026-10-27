using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FF9 RID: 20473
	[NullableContext(1)]
	[Nullable(0)]
	public class AbpStateConfig : IAbpStateConfig
	{
		// Token: 0x17007FDC RID: 32732
		// (get) Token: 0x060345EC RID: 214508 RVA: 0x00C4EA59 File Offset: 0x00C4CC59
		// (set) Token: 0x060345ED RID: 214509 RVA: 0x00C4EA61 File Offset: 0x00C4CC61
		public string Abp { get; set; }

		// Token: 0x17007FDD RID: 32733
		// (get) Token: 0x060345EE RID: 214510 RVA: 0x00C4EA6A File Offset: 0x00C4CC6A
		// (set) Token: 0x060345EF RID: 214511 RVA: 0x00C4EA72 File Offset: 0x00C4CC72
		public string State1 { get; set; }

		// Token: 0x17007FDE RID: 32734
		// (get) Token: 0x060345F0 RID: 214512 RVA: 0x00C4EA7B File Offset: 0x00C4CC7B
		// (set) Token: 0x060345F1 RID: 214513 RVA: 0x00C4EA83 File Offset: 0x00C4CC83
		public string State2 { get; set; }
	}
}
