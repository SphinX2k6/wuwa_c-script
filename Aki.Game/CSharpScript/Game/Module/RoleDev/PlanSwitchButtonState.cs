using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CD1 RID: 19665
	[NullableContext(1)]
	[Nullable(0)]
	public class PlanSwitchButtonState : IPlanSwitchButtonState
	{
		// Token: 0x17007D7A RID: 32122
		// (get) Token: 0x06032C40 RID: 207936 RVA: 0x00BD5436 File Offset: 0x00BD3636
		// (set) Token: 0x06032C41 RID: 207937 RVA: 0x00BD543E File Offset: 0x00BD363E
		public bool IsShow { get; set; }

		// Token: 0x17007D7B RID: 32123
		// (get) Token: 0x06032C42 RID: 207938 RVA: 0x00BD5447 File Offset: 0x00BD3647
		// (set) Token: 0x06032C43 RID: 207939 RVA: 0x00BD544F File Offset: 0x00BD364F
		public string Text { get; set; }

		// Token: 0x17007D7C RID: 32124
		// (get) Token: 0x06032C44 RID: 207940 RVA: 0x00BD5458 File Offset: 0x00BD3658
		// (set) Token: 0x06032C45 RID: 207941 RVA: 0x00BD5460 File Offset: 0x00BD3660
		public bool IsHighlight { get; set; }
	}
}
