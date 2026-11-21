using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045CC RID: 17868
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueTipsData : IRogueTipsData
	{
		// Token: 0x17005AD8 RID: 23256
		// (get) Token: 0x0602CF72 RID: 184178 RVA: 0x00C92DD6 File Offset: 0x00C90FD6
		// (set) Token: 0x0602CF73 RID: 184179 RVA: 0x00C92DDE File Offset: 0x00C90FDE
		public string TextId { get; set; }

		// Token: 0x17005AD9 RID: 23257
		// (get) Token: 0x0602CF74 RID: 184180 RVA: 0x00C92DE7 File Offset: 0x00C90FE7
		// (set) Token: 0x0602CF75 RID: 184181 RVA: 0x00C92DEF File Offset: 0x00C90FEF
		public string[] TextParam { get; set; }

		// Token: 0x17005ADA RID: 23258
		// (get) Token: 0x0602CF76 RID: 184182 RVA: 0x00C92DF8 File Offset: 0x00C90FF8
		// (set) Token: 0x0602CF77 RID: 184183 RVA: 0x00C92E00 File Offset: 0x00C91000
		[Nullable(2)]
		public Action FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
