using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C80 RID: 23680
	[NullableContext(1)]
	public interface IBattleUiHoverTipsDescInfoC
	{
		// Token: 0x17008DDF RID: 36319
		// (get) Token: 0x0603BD4D RID: 245069
		// (set) Token: 0x0603BD4E RID: 245070
		[Nullable(2)]
		string TitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008DE0 RID: 36320
		// (get) Token: 0x0603BD4F RID: 245071
		// (set) Token: 0x0603BD50 RID: 245072
		string DescKey { get; set; }
	}
}
