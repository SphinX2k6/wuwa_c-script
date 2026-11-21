using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB7 RID: 19895
	public class SpecialEnergyBarDaniyaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06032023 RID: 204835 RVA: 0x00DFF95A File Offset: 0x00DFDB5A
		protected override bool GetKeyEnable()
		{
			return this.IsKeyEnable;
		}

		// Token: 0x06032024 RID: 204836 RVA: 0x00DFF962 File Offset: 0x00DFDB62
		public void RefreshSlotKeyEnable(bool enable, bool bForce = false)
		{
			if (enable != this.IsKeyEnable || bForce)
			{
				this.IsKeyEnable = enable;
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.RefreshKeyEnable(enable, bForce);
			}
		}

		// Token: 0x06032025 RID: 204837 RVA: 0x00DFF990 File Offset: 0x00DFDB90
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[i];
				float num = curPercent * (float)this.SlotNum - (float)i;
				if (this.StateA)
				{
					specialEnergyBarSlotItem.UpdatePercent(num, curPercent >= 1f, false);
					specialEnergyBarSlotItem.SetBarPercent(num);
				}
				else
				{
					specialEnergyBarSlotItem.UpdatePercentWithFullEffect(num, num % 1.001f * 0.41f, false);
					specialEnergyBarSlotItem.UpdatePercent(num, false, false);
				}
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0401A794 RID: 108436
		public bool StateA;

		// Token: 0x0401A795 RID: 108437
		private bool IsKeyEnable;
	}
}
