using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200672B RID: 26411
	public class SetInputEnabledCommand : IDropCatchCommand
	{
		// Token: 0x06041EB4 RID: 270004 RVA: 0x00FFD09C File Offset: 0x00FFB29C
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
