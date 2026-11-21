using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DDA RID: 19930
	public class SpecialEnergyBarLuXiSlot : SpecialEnergyBarSlot
	{
		// Token: 0x060321E4 RID: 205284 RVA: 0x00E0AB59 File Offset: 0x00E08D59
		protected override void OnStart()
		{
			if (this.ColorState >= 0)
			{
				this.OverrideColor = true;
			}
			base.OnStart();
		}

		// Token: 0x060321E5 RID: 205285 RVA: 0x00E0AB74 File Offset: 0x00E08D74
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

		// Token: 0x060321E6 RID: 205286 RVA: 0x00E0ABEC File Offset: 0x00E08DEC
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

		// Token: 0x0401A8CC RID: 108748
		private int ColorState = -1;

		// Token: 0x0401A8CD RID: 108749
		public bool ForbidFullEffect;
	}
}
