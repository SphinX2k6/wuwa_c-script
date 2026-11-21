using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005677 RID: 22135
	public class ShowFloatEffCommand : IDropCatchCommand
	{
		// Token: 0x060369F8 RID: 223736 RVA: 0x00F3E330 File Offset: 0x00F3C530
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IShowFloatEffCommandParams showFloatEffCommandParams = (IShowFloatEffCommandParams)@params;
			DropCatchGameplayView gameplayView = context.GetLogicContext().GetProxy().GetGameplayView();
			if (gameplayView == null)
			{
				return;
			}
			gameplayView.CreateFloatEffView(showFloatEffCommandParams.Icon, (showFloatEffCommandParams.Score != null) ? new float?(showFloatEffCommandParams.Score.Value * context.GetLogicContext().GetAddScoreRateAttr().GetFinalValue()) : null);
		}
	}
}
