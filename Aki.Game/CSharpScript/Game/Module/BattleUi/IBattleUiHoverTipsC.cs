using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C7E RID: 23678
	[NullableContext(1)]
	public interface IBattleUiHoverTipsC
	{
		// Token: 0x17008DDB RID: 36315
		// (get) Token: 0x0603BD44 RID: 245060
		// (set) Token: 0x0603BD45 RID: 245061
		string TitleKey { get; set; }

		// Token: 0x17008DDC RID: 36316
		// (get) Token: 0x0603BD46 RID: 245062
		// (set) Token: 0x0603BD47 RID: 245063
		List<IBattleUiHoverTipsDescInfoC> DescInfoList { get; set; }
	}
}
