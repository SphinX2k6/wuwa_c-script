using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI
{
	// Token: 0x02005E5A RID: 24154
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleViewDynamicUIConfig
	{
		// Token: 0x040200C2 RID: 131266
		public string ResourceId = string.Empty;

		// Token: 0x040200C3 RID: 131267
		public EBattleViewChildType ChildType;

		// Token: 0x040200C4 RID: 131268
		public Func<BattleViewDynamicUiBase> CreateUi;
	}
}
