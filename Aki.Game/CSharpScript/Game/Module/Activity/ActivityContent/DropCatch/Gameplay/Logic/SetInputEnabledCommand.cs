using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200567B RID: 22139
	public class SetInputEnabledCommand : IDropCatchCommand
	{
		// Token: 0x06036A00 RID: 223744 RVA: 0x00F3E468 File Offset: 0x00F3C668
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			ISetInputEnabledCommandParams setInputEnabledCommandParams = (ISetInputEnabledCommandParams)@params;
			DropCatchGameplayView gameplayView = context.GetLogicContext().GetProxy().GetGameplayView();
			if (gameplayView == null)
			{
				return;
			}
			DropCatchGameplayJoystickView joystickView = gameplayView.GetJoystickView();
			if (joystickView == null)
			{
				return;
			}
			joystickView.SetInputEnabled(setInputEnabledCommandParams.Enabled);
		}
	}
}
