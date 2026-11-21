using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DEF RID: 19951
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarXigelikaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06032301 RID: 205569 RVA: 0x00E10968 File Offset: 0x00E0EB68
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

		// Token: 0x06032302 RID: 205570 RVA: 0x00E109D0 File Offset: 0x00E0EBD0
		public void SetSegmentVisible(int i, bool visible)
		{
			if (0 <= i && i < this.SegmentVisibles.Length && this.SegmentVisibles[i] != visible)
			{
				this.SegmentVisibles[i] = visible;
				this.SlotItemList[i].SetUiActive(visible);
			}
		}

		// Token: 0x0401A971 RID: 108913
		private readonly bool[] SegmentVisibles = new bool[]
		{
			true,
			true,
			true,
			true
		};
	}
}
