using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003595 RID: 13717
	public interface IPanelTickInterface
	{
		// Token: 0x06022F87 RID: 143239
		void Tick(float deltaTime);

		// Token: 0x06022F88 RID: 143240
		void AfterTick(float deltaTime);
	}
}
