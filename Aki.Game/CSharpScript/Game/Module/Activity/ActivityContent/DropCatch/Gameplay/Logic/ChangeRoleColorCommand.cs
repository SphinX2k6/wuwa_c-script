using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005678 RID: 22136
	public class ChangeRoleColorCommand : IDropCatchCommand
	{
		// Token: 0x060369FA RID: 223738 RVA: 0x00F3E3A8 File Offset: 0x00F3C5A8
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
