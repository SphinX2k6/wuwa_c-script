using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005675 RID: 22133
	public class ModifyEnergyGetRateCommand : IDropCatchCommand
	{
		// Token: 0x060369F4 RID: 223732 RVA: 0x00F3E278 File Offset: 0x00F3C478
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IModifyEnergyGetRateCommandParams modifyEnergyGetRateCommandParams = (IModifyEnergyGetRateCommandParams)@params;
			DropCatchGameplayAttribute energyGetRateAttr = context.GetLogicContext().GetEnergyGetRateAttr();
			context.GetLogicContext().GetGameplayModifierMgr().AddModifierToAttr(energyGetRateAttr, modifyEnergyGetRateCommandParams.Type, modifyEnergyGetRateCommandParams.Value, modifyEnergyGetRateCommandParams.Duration);
		}
	}
}
