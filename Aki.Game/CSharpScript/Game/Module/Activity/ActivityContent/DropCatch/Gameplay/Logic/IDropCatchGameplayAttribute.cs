using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006715 RID: 26389
	public interface IDropCatchGameplayAttribute
	{
		// Token: 0x06041E79 RID: 269945
		float GetBaseValue();

		// Token: 0x06041E7A RID: 269946
		float GetFinalValue();

		// Token: 0x06041E7B RID: 269947
		void SetFinalValue(float value);

		// Token: 0x06041E7C RID: 269948
		void Reset();
	}
}
