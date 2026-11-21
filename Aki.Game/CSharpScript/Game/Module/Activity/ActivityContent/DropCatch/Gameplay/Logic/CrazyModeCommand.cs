using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200566D RID: 22125
	public class CrazyModeCommand : IDropCatchCommand
	{
		// Token: 0x060369E4 RID: 223716 RVA: 0x00F3DEB3 File Offset: 0x00F3C0B3
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			DropCatchGameplayView gameplayView = context.GetLogicContext().GetProxy().GetGameplayView();
			if (gameplayView == null)
			{
				return;
			}
			gameplayView.RefreshCrazyMode(true);
		}
	}
}
