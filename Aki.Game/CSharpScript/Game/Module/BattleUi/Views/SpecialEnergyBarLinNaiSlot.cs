using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DCF RID: 19919
	public class SpecialEnergyBarLinNaiSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603217F RID: 205183 RVA: 0x00E08908 File Offset: 0x00E06B08
		public void SwitchPointColor(bool enhanced)
		{
			int num = (enhanced > false) ? 1 : 0;
			FColor fcolor = FColor.FromHex((this.Config != null && num < this.Config.PointColorList.Length) ? this.Config.PointColorList[num] : "ffffff");
			this.SlotItemList[0].SetPointColor(fcolor);
		}

		// Token: 0x06032180 RID: 205184 RVA: 0x00E08960 File Offset: 0x00E06B60
		[NullableContext(2)]
		public void SwitchKeyItem(SpecialEnergyBarInfo cfg, bool pureHotkey = false)
		{
			if (cfg != null)
			{
				this.Config = cfg;
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.SetConfig(cfg);
				}
				SpecialEnergyBarKeyItem keyItem2 = this.KeyItem;
				if (keyItem2 != null)
				{
					keyItem2.SwitchToKeyInfoList(this.Config.KeyInfoList);
				}
			}
			if (pureHotkey)
			{
				UUIItem item = base.GetItem(0);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				UUIItem item3 = base.GetItem(2);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem item4 = base.GetItem(0);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				UUIItem item5 = base.GetItem(1);
				if (item5 != null)
				{
					item5.SetUIActive(true);
				}
				UUIItem item6 = base.GetItem(2);
				if (item6 == null)
				{
					return;
				}
				item6.SetUIActive(true);
				return;
			}
		}

		// Token: 0x06032181 RID: 205185 RVA: 0x00E08A19 File Offset: 0x00E06C19
		protected override bool GetKeyEnable()
		{
			SpecialEnergyBarLinNai ownerLogic = this.OwnerLogic;
			return ownerLogic != null && ownerLogic.Internal_GetKeyEnable();
		}

		// Token: 0x06032182 RID: 205186 RVA: 0x00E08A2C File Offset: 0x00E06C2C
		public void RefreshKeyEnable(bool enable, bool bForce)
		{
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(enable, bForce);
		}

		// Token: 0x0401A88F RID: 108687
		[Nullable(2)]
		public SpecialEnergyBarLinNai OwnerLogic;

		// Token: 0x0200AB2D RID: 43821
		private enum EChildType
		{
			// Token: 0x04034F0E RID: 216846
			PnlSlot,
			// Token: 0x04034F0F RID: 216847
			PnlHotKey,
			// Token: 0x04034F10 RID: 216848
			SprDesc
		}
	}
}
