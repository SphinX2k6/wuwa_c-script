using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C5E RID: 19550
	[NullableContext(1)]
	public interface IBattleUiHoverTipsC
	{
		// Token: 0x170061AD RID: 25005
		// (get) Token: 0x06030C92 RID: 199826
		// (set) Token: 0x06030C93 RID: 199827
		string TitleKey { get; set; }

		// Token: 0x170061AE RID: 25006
		// (get) Token: 0x06030C94 RID: 199828
		// (set) Token: 0x06030C95 RID: 199829
		List<IBattleUiHoverTipsDescInfoC> DescInfoList { get; set; }
	}
}
