using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005651 RID: 22097
	public abstract class DropCatchGameplayPoolPanelBase : UiPanelBase
	{
		// Token: 0x0401CD64 RID: 118116
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DropCatchGameplayPoolPanelBase> OnRecycle;
	}
}
