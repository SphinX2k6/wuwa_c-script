using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C9A RID: 19610
	[NullableContext(2)]
	public interface IBattleUiCenterPanelOtherMovePanel
	{
		// Token: 0x06030F04 RID: 200452
		void Tick(float delta);

		// Token: 0x06030F05 RID: 200453
		void Destroy(Action callback = null);
	}
}
