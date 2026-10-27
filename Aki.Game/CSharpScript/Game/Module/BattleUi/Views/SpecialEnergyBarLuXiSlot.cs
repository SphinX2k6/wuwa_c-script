using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF5 RID: 24053
	public class SpecialEnergyBarLuXiSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D255 RID: 250453 RVA: 0x00EB9611 File Offset: 0x00EB7811
		protected override void OnStart()
		{
			if (this.ColorState >= 0)
			{
				this.OverrideColor = true;
			}
			base.OnStart();
		}

		// Token: 0x0603D256 RID: 250454 RVA: 0x00EB962C File Offset: 0x00EB782C
		protected override void RefreshBarPercent(bool isStart = false)
		{
			if (!this.ForbidFullEffect)
			{
				base.RefreshBarPercent(isStart);
				return;
			}
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SlotItemList[i].UpdatePercent(curPercent * (float)this.SlotNum - (float)i, false, false);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0603D257 RID: 250455 RVA: 0x00EB96A4 File Offset: 0x00EB78A4
		public void SetColorState(int state)
		{
			if (this.ColorState == state)
			{
				return;
			}
			this.ColorState = state;
			if (this.Config == null)
			{
				return;
			}
			string hexStr = (state == 0) ? this.Config.EffectColor : this.Config.OtherEffectColorList[state - 1];
			string hexStr2 = this.Config.PointColorList[state];
			FColor fcolor = FColor.FromHex(hexStr);
			FColor fcolor2 = fcolor;
			if (!string.IsNullOrEmpty(this.Config.PointColor))
			{
				fcolor2 = FColor.FromHex(hexStr2);
			}
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetBarColor(fcolor);
				specialEnergyBarSlotItem.SetPointColor(fcolor2);
			}
		}

		// Token: 0x0401FE05 RID: 130565
		private int ColorState = -1;

		// Token: 0x0401FE06 RID: 130566
		public bool ForbidFullEffect;
	}
}
