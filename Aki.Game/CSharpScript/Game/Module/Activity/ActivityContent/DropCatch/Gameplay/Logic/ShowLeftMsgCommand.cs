using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006726 RID: 26406
	public class ShowLeftMsgCommand : IDropCatchCommand
	{
		// Token: 0x06041EAA RID: 269994 RVA: 0x00FFCEF8 File Offset: 0x00FFB0F8
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
