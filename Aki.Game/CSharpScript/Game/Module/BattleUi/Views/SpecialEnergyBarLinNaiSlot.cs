using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DEA RID: 24042
	public class SpecialEnergyBarLinNaiSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D1F0 RID: 250352 RVA: 0x00EB73CC File Offset: 0x00EB55CC
		public void SwitchPointColor(bool enhanced)
		{
			SpecialEnergyBarInfo config = this.Config;
			string text;
			if (config == null)
			{
				text = null;
			}
			else
			{
				string[] pointColorList = config.PointColorList;
				text = ((pointColorList != null) ? pointColorList.ElementAtOrDefault((enhanced > false) ? 1 : 0) : null);
			}
			FColor fcolor = FColor.FromHex(text ?? "ffffff");
			this.SlotItemList[0].SetPointColor(fcolor);
		}

		// Token: 0x0603D1F1 RID: 250353 RVA: 0x00EB7420 File Offset: 0x00EB5620
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

		// Token: 0x0603D1F2 RID: 250354 RVA: 0x00EB74D9 File Offset: 0x00EB56D9
		protected override bool GetKeyEnable()
		{
			SpecialEnergyBarLinNai ownerLogic = this.OwnerLogic;
			return ownerLogic != null && ownerLogic.Internal_GetKeyEnable();
		}

		// Token: 0x0603D1F3 RID: 250355 RVA: 0x00EB74EC File Offset: 0x00EB56EC
		public void RefreshKeyEnable(bool enable, bool bForce)
		{
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(enable, bForce);
		}

		// Token: 0x0401FDC8 RID: 130504
		[Nullable(2)]
		public SpecialEnergyBarLinNai OwnerLogic;

		// Token: 0x0200C11E RID: 49438
		private enum EChildType
		{
			// Token: 0x0403A51C RID: 238876
			PnlSlot,
			// Token: 0x0403A51D RID: 238877
			PnlHotKey,
			// Token: 0x0403A51E RID: 238878
			SprDesc
		}
	}
}
