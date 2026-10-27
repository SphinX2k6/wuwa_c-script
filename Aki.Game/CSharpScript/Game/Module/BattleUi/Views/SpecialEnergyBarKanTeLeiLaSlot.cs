using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DE2 RID: 24034
	public class SpecialEnergyBarKanTeLeiLaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D18D RID: 250253 RVA: 0x00EB4104 File Offset: 0x00EB2304
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			bool fullEffectEnable = !this.FullEffectForceDisable && keyEnable;
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SlotItemList[i].UpdatePercent(curPercent * (float)this.SlotNum - (float)i, fullEffectEnable, false);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0401FD70 RID: 130416
		public bool FullEffectForceDisable;
	}
}
