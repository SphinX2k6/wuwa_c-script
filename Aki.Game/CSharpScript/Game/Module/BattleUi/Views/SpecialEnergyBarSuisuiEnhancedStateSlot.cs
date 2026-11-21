using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DE6 RID: 19942
	public class SpecialEnergyBarSuisuiEnhancedStateSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06032296 RID: 205462 RVA: 0x00E0E99C File Offset: 0x00E0CB9C
		protected override void OnStart()
		{
			base.OnStart();
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetFullEffectPercent(1f);
			}
		}
	}
}
