using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DFB RID: 19963
	public class SpecialEnergyBarZanniSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603239C RID: 205724 RVA: 0x00E14270 File Offset: 0x00E12470
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			if (!this.FullEffectWhenEnable)
			{
				base.RefreshBarPercent(isStart);
				int state = 0;
				if (curPercent <= 0f)
				{
					state = -1;
				}
				else if (curPercent >= 1f)
				{
					state = 1;
				}
				this.SetState(state, isStart);
				return;
			}
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[i];
				float percent = curPercent * (float)this.SlotNum - (float)i;
				specialEnergyBarSlotItem.UpdatePercentWithFullEffectEnable(percent, keyEnable, isStart);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0603239D RID: 205725 RVA: 0x00E14310 File Offset: 0x00E12510
		private void SetState(int state, bool isStart = false)
		{
			if (this.State == state && !isStart)
			{
				return;
			}
			this.State = state;
			UUIItem bottomLineLight = this.BottomLineLight;
			if (bottomLineLight != null)
			{
				bottomLineLight.SetUIActive(this.State == 1);
			}
			foreach (UUIItem uuiitem in this.DarkItemList)
			{
				uuiitem.SetUIActive(this.State != -1);
			}
		}

		// Token: 0x0401A9DB RID: 109019
		[Nullable(2)]
		public UUIItem BottomLineLight;

		// Token: 0x0401A9DC RID: 109020
		[Nullable(1)]
		public readonly List<UUIItem> DarkItemList = new List<UUIItem>();

		// Token: 0x0401A9DD RID: 109021
		public bool FullEffectWhenEnable;

		// Token: 0x0401A9DE RID: 109022
		private int State;
	}
}
