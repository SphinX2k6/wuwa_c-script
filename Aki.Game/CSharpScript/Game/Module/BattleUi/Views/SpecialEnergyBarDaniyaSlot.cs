using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD3 RID: 24019
	public class SpecialEnergyBarDaniyaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D0AC RID: 250028 RVA: 0x00EAEA66 File Offset: 0x00EACC66
		protected override bool GetKeyEnable()
		{
			return this.IsKeyEnable;
		}

		// Token: 0x0603D0AD RID: 250029 RVA: 0x00EAEA6E File Offset: 0x00EACC6E
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

		// Token: 0x0603D0AE RID: 250030 RVA: 0x00EAEA9C File Offset: 0x00EACC9C
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

		// Token: 0x0401FCD7 RID: 130263
		public bool StateA;

		// Token: 0x0401FCD8 RID: 130264
		private bool IsKeyEnable;
	}
}
