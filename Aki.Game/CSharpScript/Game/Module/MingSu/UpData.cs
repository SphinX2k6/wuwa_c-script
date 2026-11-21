using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043B6 RID: 17334
	[NullableContext(1)]
	[Nullable(0)]
	public class UpData : IUpData
	{
		// Token: 0x17005794 RID: 22420
		// (get) Token: 0x0602BCA8 RID: 179368 RVA: 0x00C4BB11 File Offset: 0x00C49D11
		// (set) Token: 0x0602BCA9 RID: 179369 RVA: 0x00C4BB19 File Offset: 0x00C49D19
		public int UseCoreCount { get; set; }

		// Token: 0x17005795 RID: 22421
		// (get) Token: 0x0602BCAA RID: 179370 RVA: 0x00C4BB22 File Offset: 0x00C49D22
		// (set) Token: 0x0602BCAB RID: 179371 RVA: 0x00C4BB2A File Offset: 0x00C49D2A
		public string CoreName { get; set; } = "";
	}
}
