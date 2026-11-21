using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048DF RID: 18655
	[NullableContext(1)]
	[Nullable(0)]
	public class IInfrArchiveMenuItemData
	{
		// Token: 0x17005EA2 RID: 24226
		// (get) Token: 0x0602ED26 RID: 191782 RVA: 0x00D0E210 File Offset: 0x00D0C410
		// (set) Token: 0x0602ED27 RID: 191783 RVA: 0x00D0E218 File Offset: 0x00D0C418
		public InfrastructureDefine.EInfrArchiveTabType CardType { get; set; }

		// Token: 0x17005EA3 RID: 24227
		// (get) Token: 0x0602ED28 RID: 191784 RVA: 0x00D0E221 File Offset: 0x00D0C421
		// (set) Token: 0x0602ED29 RID: 191785 RVA: 0x00D0E229 File Offset: 0x00D0C429
		public string DesText { get; set; }
	}
}
