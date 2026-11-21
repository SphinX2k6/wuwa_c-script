using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D0 RID: 18128
	[NullableContext(1)]
	public interface IKurotatoPopupItemDetailOpenParam
	{
		// Token: 0x17005BDC RID: 23516
		// (get) Token: 0x0602D91F RID: 186655
		// (set) Token: 0x0602D920 RID: 186656
		int Index { get; set; }

		// Token: 0x17005BDD RID: 23517
		// (get) Token: 0x0602D921 RID: 186657
		// (set) Token: 0x0602D922 RID: 186658
		List<KurotatoCardTip> CardData { get; set; }

		// Token: 0x17005BDE RID: 23518
		// (get) Token: 0x0602D923 RID: 186659
		// (set) Token: 0x0602D924 RID: 186660
		bool? IsOutSide { get; set; }

		// Token: 0x17005BDF RID: 23519
		// (get) Token: 0x0602D925 RID: 186661
		// (set) Token: 0x0602D926 RID: 186662
		[Nullable(2)]
		List<int> Price { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
