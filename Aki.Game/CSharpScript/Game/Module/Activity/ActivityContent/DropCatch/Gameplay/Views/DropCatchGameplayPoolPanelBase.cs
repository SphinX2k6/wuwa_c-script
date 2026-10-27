using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02006701 RID: 26369
	public abstract class DropCatchGameplayPoolPanelBase : UiPanelBase
	{
		// Token: 0x0402250B RID: 140555
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DropCatchGameplayPoolPanelBase> OnRecycle;
	}
}
