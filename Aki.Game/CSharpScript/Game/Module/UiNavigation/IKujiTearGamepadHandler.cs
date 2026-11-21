using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F9 RID: 14585
	public interface IKujiTearGamepadHandler
	{
		// Token: 0x06025C0A RID: 154634
		bool GetGamepadCanPress();

		// Token: 0x06025C0B RID: 154635
		void OnGamepadPress();

		// Token: 0x06025C0C RID: 154636
		void OnGamepadRelease();

		// Token: 0x06025C0D RID: 154637
		void OnGamepadHold(float percent);
	}
}
