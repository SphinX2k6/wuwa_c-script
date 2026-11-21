using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005676 RID: 22134
	public class ShowLeftMsgCommand : IDropCatchCommand
	{
		// Token: 0x060369F6 RID: 223734 RVA: 0x00F3E2C4 File Offset: 0x00F3C4C4
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IShowLeftMsgCommandParams showLeftMsgCommandParams = (IShowLeftMsgCommandParams)@params;
			DropCatchGameplayView gameplayView = context.GetLogicContext().GetProxy().GetGameplayView();
			if (gameplayView == null)
			{
				return;
			}
			gameplayView.ShowMsgView(new IDropCatchGameplayLeftMsgParams
			{
				Type = showLeftMsgCommandParams.Type,
				Icon = showLeftMsgCommandParams.Icon,
				TextId = showLeftMsgCommandParams.TextId,
				Duration = showLeftMsgCommandParams.Duration
			});
		}
	}
}
