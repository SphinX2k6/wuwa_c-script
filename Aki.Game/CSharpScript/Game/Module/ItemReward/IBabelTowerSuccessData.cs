using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057DC RID: 22492
	[NullableContext(1)]
	public interface IBabelTowerSuccessData
	{
		// Token: 0x170089E0 RID: 35296
		// (get) Token: 0x060392D2 RID: 234194
		// (set) Token: 0x060392D3 RID: 234195
		List<int> NewBabelBuffIds { get; set; }

		// Token: 0x170089E1 RID: 35297
		// (get) Token: 0x060392D4 RID: 234196
		// (set) Token: 0x060392D5 RID: 234197
		List<int> NewBabelDeTermIds { get; set; }

		// Token: 0x170089E2 RID: 35298
		// (get) Token: 0x060392D6 RID: 234198
		// (set) Token: 0x060392D7 RID: 234199
		TableTextArgNew StarTextParam { get; set; }

		// Token: 0x170089E3 RID: 35299
		// (get) Token: 0x060392D8 RID: 234200
		// (set) Token: 0x060392D9 RID: 234201
		string TipTextId { get; set; }
	}
}
