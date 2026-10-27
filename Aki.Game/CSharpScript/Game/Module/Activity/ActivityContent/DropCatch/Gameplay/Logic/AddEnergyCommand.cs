using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200671A RID: 26394
	public class AddEnergyCommand : IDropCatchCommand
	{
		// Token: 0x06041E92 RID: 269970 RVA: 0x00FFCA4C File Offset: 0x00FFAC4C
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
