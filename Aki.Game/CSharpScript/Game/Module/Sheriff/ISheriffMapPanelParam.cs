using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BEA RID: 15338
	[NullableContext(2)]
	public interface ISheriffMapPanelParam
	{
		// Token: 0x1700504A RID: 20554
		// (get) Token: 0x06027561 RID: 161121
		// (set) Token: 0x06027562 RID: 161122
		ESheriffMainTabType? TabType { get; set; }

		// Token: 0x1700504B RID: 20555
		// (get) Token: 0x06027563 RID: 161123
		// (set) Token: 0x06027564 RID: 161124
		int? TargetMarkId { get; set; }

		// Token: 0x1700504C RID: 20556
		// (get) Token: 0x06027565 RID: 161125
		// (set) Token: 0x06027566 RID: 161126
		bool? IsError { get; set; }

		// Token: 0x1700504D RID: 20557
		// (get) Token: 0x06027567 RID: 161127
		// (set) Token: 0x06027568 RID: 161128
		Action OnPanelOpened { get; set; }
	}
}
