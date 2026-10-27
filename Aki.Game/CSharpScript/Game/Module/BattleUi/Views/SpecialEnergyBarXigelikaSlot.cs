using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E0A RID: 24074
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarXigelikaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D372 RID: 250738 RVA: 0x00EBF408 File Offset: 0x00EBD608
		public void SwitchKeyItem(SpecialEnergyBarInfo cfg)
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
				base.ClearAllTagCountChangedCallback();
				base.InitKeyEnableTag();
				SpecialEnergyBarKeyItem keyItem3 = this.KeyItem;
				if (keyItem3 == null)
				{
					return;
				}
				keyItem3.RefreshKeyEnable(this.GetKeyEnable(), false);
			}
		}

		// Token: 0x0603D373 RID: 250739 RVA: 0x00EBF470 File Offset: 0x00EBD670
		public void SetSegmentVisible(int i, bool visible)
		{
			if (0 <= i && i < this.SegmentVisibles.Length && this.SegmentVisibles[i] != visible)
			{
				this.SegmentVisibles[i] = visible;
				this.SlotItemList[i].SetUiActive(visible);
			}
		}

		// Token: 0x0401FEAA RID: 130730
		private readonly bool[] SegmentVisibles = new bool[]
		{
			true,
			true,
			true,
			true
		};
	}
}
