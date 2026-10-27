using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004664 RID: 18020
	public interface IPanelTickInterface
	{
		// Token: 0x0602E83D RID: 190525
		void Tick(float deltaTime);

		// Token: 0x0602E83E RID: 190526
		void AfterTick(float deltaTime);
	}
}
