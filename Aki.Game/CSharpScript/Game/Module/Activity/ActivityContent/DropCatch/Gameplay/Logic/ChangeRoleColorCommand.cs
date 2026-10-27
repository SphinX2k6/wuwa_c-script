using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006728 RID: 26408
	public class ChangeRoleColorCommand : IDropCatchCommand
	{
		// Token: 0x06041EAE RID: 269998 RVA: 0x00FFCFDC File Offset: 0x00FFB1DC
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IChangeRoleColorCommandParams changeRoleColorCommandParams = (IChangeRoleColorCommandParams)@params;
			DropCatchGameplayView gameplayView = context.GetLogicContext().GetProxy().GetGameplayView();
			if (gameplayView == null)
			{
				return;
			}
			DropCatchGameplayRoleView roleView = gameplayView.GetRoleView();
			if (roleView == null)
			{
				return;
			}
			roleView.SetChangeColor(changeRoleColorCommandParams.UseChangeColor, changeRoleColorCommandParams.HexColor, changeRoleColorCommandParams.Duration);
		}
	}
}
