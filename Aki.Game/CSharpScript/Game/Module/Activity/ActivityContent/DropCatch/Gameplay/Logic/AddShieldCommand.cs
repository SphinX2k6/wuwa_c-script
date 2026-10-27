using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200671F RID: 26399
	public class AddShieldCommand : IDropCatchCommand
	{
		// Token: 0x06041E9C RID: 269980 RVA: 0x00FFCB40 File Offset: 0x00FFAD40
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
