using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200566F RID: 22127
	public class AddShieldCommand : IDropCatchCommand
	{
		// Token: 0x060369E8 RID: 223720 RVA: 0x00F3DF0C File Offset: 0x00F3C10C
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IAddShieldCommandParams addShieldCommandParams = (IAddShieldCommandParams)@params;
			IRoleInstance role = context.GetLogicContext().GetGameplayRoleMgr().GetRole();
			if (role == null)
			{
				return;
			}
			role.AddShield(addShieldCommandParams.Time);
		}
	}
}
