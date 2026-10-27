using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF3 RID: 24051
	public class SpecialEnergyBarLuPaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D239 RID: 250425 RVA: 0x00EB89DD File Offset: 0x00EB6BDD
		public void SetTagCount(int tagCount)
		{
			this.TagCount = tagCount;
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D23A RID: 250426 RVA: 0x00EB89F0 File Offset: 0x00EB6BF0
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[i];
				if (i < this.TagCount)
				{
					specialEnergyBarSlotItem.UpdatePercent(curPercent * (float)this.SlotNum - (float)i, false, true);
				}
				else
				{
					specialEnergyBarSlotItem.UpdatePercent(curPercent * (float)this.SlotNum - (float)i, keyEnable, true);
				}
			}
			int num = (int)Math.Floor((double)(curPercent * (float)this.SlotNum));
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable && this.TagCount < num, isStart);
		}

		// Token: 0x0401FDE9 RID: 130537
		private int TagCount;
	}
}
