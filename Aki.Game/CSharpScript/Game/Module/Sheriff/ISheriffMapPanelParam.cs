using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C39 RID: 19513
	[NullableContext(2)]
	public interface ISheriffMapPanelParam
	{
		// Token: 0x17007CA0 RID: 31904
		// (get) Token: 0x060327AE RID: 206766
		// (set) Token: 0x060327AF RID: 206767
		ESheriffMainTabType? TabType { get; set; }

		// Token: 0x17007CA1 RID: 31905
		// (get) Token: 0x060327B0 RID: 206768
		// (set) Token: 0x060327B1 RID: 206769
		int? TargetMarkId { get; set; }

		// Token: 0x17007CA2 RID: 31906
		// (get) Token: 0x060327B2 RID: 206770
		// (set) Token: 0x060327B3 RID: 206771
		bool? IsError { get; set; }

		// Token: 0x17007CA3 RID: 31907
		// (get) Token: 0x060327B4 RID: 206772
		// (set) Token: 0x060327B5 RID: 206773
		Action OnPanelOpened { get; set; }
	}
}
