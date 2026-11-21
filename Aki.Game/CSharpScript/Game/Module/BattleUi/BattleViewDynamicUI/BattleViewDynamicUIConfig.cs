using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI
{
	// Token: 0x02004E3F RID: 20031
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleViewDynamicUIConfig
	{
		// Token: 0x0401AB89 RID: 109449
		public string ResourceId = string.Empty;

		// Token: 0x0401AB8A RID: 109450
		public EBattleViewChildType ChildType;

		// Token: 0x0401AB8B RID: 109451
		public Func<BattleViewDynamicUiBase> CreateUi;
	}
}
