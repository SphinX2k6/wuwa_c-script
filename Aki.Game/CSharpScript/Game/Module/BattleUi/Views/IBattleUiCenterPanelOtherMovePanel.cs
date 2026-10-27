using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB8 RID: 23736
	[NullableContext(2)]
	public interface IBattleUiCenterPanelOtherMovePanel
	{
		// Token: 0x0603BFB1 RID: 245681
		void Tick(float delta);

		// Token: 0x0603BFB2 RID: 245682
		void Destroy(Action callback = null);
	}
}
