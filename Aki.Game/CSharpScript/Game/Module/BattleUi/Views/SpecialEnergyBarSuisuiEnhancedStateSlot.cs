using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E01 RID: 24065
	public class SpecialEnergyBarSuisuiEnhancedStateSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D307 RID: 250631 RVA: 0x00EBD43C File Offset: 0x00EBB63C
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
