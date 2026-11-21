using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E9F RID: 16031
	[NullableContext(1)]
	public interface IRogueBattleEnvironmentInfo
	{
		// Token: 0x170052CF RID: 21199
		// (get) Token: 0x06028B41 RID: 166721
		// (set) Token: 0x06028B42 RID: 166722
		string Icon { get; set; }

		// Token: 0x170052D0 RID: 21200
		// (get) Token: 0x06028B43 RID: 166723
		// (set) Token: 0x06028B44 RID: 166724
		string TextId { get; set; }

		// Token: 0x170052D1 RID: 21201
		// (get) Token: 0x06028B45 RID: 166725
		// (set) Token: 0x06028B46 RID: 166726
		List<string> Param { get; set; }
	}
}
