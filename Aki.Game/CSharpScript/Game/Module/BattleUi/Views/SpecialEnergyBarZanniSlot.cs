using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E16 RID: 24086
	public class SpecialEnergyBarZanniSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D40D RID: 250893 RVA: 0x00EC2D10 File Offset: 0x00EC0F10
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

		// Token: 0x0603D40E RID: 250894 RVA: 0x00EC2DB0 File Offset: 0x00EC0FB0
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

		// Token: 0x0401FF14 RID: 130836
		[Nullable(2)]
		public UUIItem BottomLineLight;

		// Token: 0x0401FF15 RID: 130837
		[Nullable(1)]
		public readonly List<UUIItem> DarkItemList = new List<UUIItem>();

		// Token: 0x0401FF16 RID: 130838
		public bool FullEffectWhenEnable;

		// Token: 0x0401FF17 RID: 130839
		private int State;
	}
}
