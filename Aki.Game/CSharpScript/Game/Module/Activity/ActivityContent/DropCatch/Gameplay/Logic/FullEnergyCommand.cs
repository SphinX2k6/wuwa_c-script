using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200566B RID: 22123
	public class FullEnergyCommand : IDropCatchCommand
	{
		// Token: 0x060369E0 RID: 223712 RVA: 0x00F3DE5A File Offset: 0x00F3C05A
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
