using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005665 RID: 22117
	public interface IDropCatchGameplayAttribute
	{
		// Token: 0x060369C5 RID: 223685
		float GetBaseValue();

		// Token: 0x060369C6 RID: 223686
		float GetFinalValue();

		// Token: 0x060369C7 RID: 223687
		void SetFinalValue(float value);

		// Token: 0x060369C8 RID: 223688
		void Reset();
	}
}
