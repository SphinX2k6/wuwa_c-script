using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200671D RID: 26397
	public class CrazyModeCommand : IDropCatchCommand
	{
		// Token: 0x06041E98 RID: 269976 RVA: 0x00FFCAE7 File Offset: 0x00FFACE7
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
