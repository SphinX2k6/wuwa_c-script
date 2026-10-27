using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056F9 RID: 22265
	[NullableContext(1)]
	public interface IKurotatoPopupItemDetailOpenParam
	{
		// Token: 0x17008814 RID: 34836
		// (get) Token: 0x06038A0F RID: 231951
		// (set) Token: 0x06038A10 RID: 231952
		int Index { get; set; }

		// Token: 0x17008815 RID: 34837
		// (get) Token: 0x06038A11 RID: 231953
		// (set) Token: 0x06038A12 RID: 231954
		List<KurotatoCardTip> CardData { get; set; }

		// Token: 0x17008816 RID: 34838
		// (get) Token: 0x06038A13 RID: 231955
		// (set) Token: 0x06038A14 RID: 231956
		bool? IsOutSide { get; set; }

		// Token: 0x17008817 RID: 34839
		// (get) Token: 0x06038A15 RID: 231957
		// (set) Token: 0x06038A16 RID: 231958
		[Nullable(2)]
		List<int> Price { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
