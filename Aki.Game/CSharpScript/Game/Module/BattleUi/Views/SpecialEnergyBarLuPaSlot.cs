using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD8 RID: 19928
	public class SpecialEnergyBarLuPaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x060321C8 RID: 205256 RVA: 0x00E09F25 File Offset: 0x00E08125
		public void SetTagCount(int tagCount)
		{
			this.TagCount = tagCount;
			this.RefreshBarPercent(false);
		}

		// Token: 0x060321C9 RID: 205257 RVA: 0x00E09F38 File Offset: 0x00E08138
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

		// Token: 0x0401A8B0 RID: 108720
		private int TagCount;
	}
}
