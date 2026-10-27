using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006725 RID: 26405
	public class ModifyEnergyGetRateCommand : IDropCatchCommand
	{
		// Token: 0x06041EA8 RID: 269992 RVA: 0x00FFCEAC File Offset: 0x00FFB0AC
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IModifyEnergyGetRateCommandParams modifyEnergyGetRateCommandParams = (IModifyEnergyGetRateCommandParams)@params;
			DropCatchGameplayAttribute energyGetRateAttr = context.GetLogicContext().GetEnergyGetRateAttr();
			context.GetLogicContext().GetGameplayModifierMgr().AddModifierToAttr(energyGetRateAttr, modifyEnergyGetRateCommandParams.Type, modifyEnergyGetRateCommandParams.Value, modifyEnergyGetRateCommandParams.Duration);
		}
	}
}
