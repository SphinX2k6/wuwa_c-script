using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DC6 RID: 19910
	public class SpecialEnergyBarKanTeLeiLaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06032104 RID: 205060 RVA: 0x00E05004 File Offset: 0x00E03204
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

		// Token: 0x0401A82D RID: 108589
		public bool FullEffectForceDisable;
	}
}
