using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200671B RID: 26395
	public class FullEnergyCommand : IDropCatchCommand
	{
		// Token: 0x06041E94 RID: 269972 RVA: 0x00FFCA8E File Offset: 0x00FFAC8E
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IRoleInstance role = context.GetLogicContext().GetGameplayRoleMgr().GetRole();
			if (role == null)
			{
				return;
			}
			role.FullEnergy();
		}
	}
}
