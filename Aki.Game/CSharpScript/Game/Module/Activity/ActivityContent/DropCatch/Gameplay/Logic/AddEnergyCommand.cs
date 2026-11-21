using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200566A RID: 22122
	public class AddEnergyCommand : IDropCatchCommand
	{
		// Token: 0x060369DE RID: 223710 RVA: 0x00F3DE18 File Offset: 0x00F3C018
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IAddEnergyCommandParams addEnergyCommandParams = (IAddEnergyCommandParams)@params;
			IRoleInstance role = context.GetLogicContext().GetGameplayRoleMgr().GetRole();
			if (role == null)
			{
				return;
			}
			role.AddEnergy(addEnergyCommandParams.Energy, addEnergyCommandParams.IsCalRate);
		}
	}
}
