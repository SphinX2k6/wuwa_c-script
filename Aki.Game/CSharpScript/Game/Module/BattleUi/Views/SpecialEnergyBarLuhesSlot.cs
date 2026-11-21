using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD1 RID: 19921
	public class SpecialEnergyBarLuhesSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06032193 RID: 205203 RVA: 0x00E08D44 File Offset: 0x00E06F44
		[NullableContext(2)]
		public void SwitchKeyItem(SpecialEnergyBarInfo cfg)
		{
			if (cfg == null)
			{
				return;
			}
			this.Config = cfg;
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.SetConfig(cfg);
			}
			this.AttributeId = (EAttributeType)cfg.AttributeId;
			this.MaxAttributeId = (EAttributeType)cfg.MaxAttributeId;
			this.RemoveEvents();
			this.AddEvents();
			this.OnAttributeChanged();
			base.ClearAllTagCountChangedCallback();
			base.InitKeyEnableTag();
			SpecialEnergyBarKeyItem keyItem2 = this.KeyItem;
			if (keyItem2 != null)
			{
				keyItem2.SwitchToKeyInfoList(cfg.KeyInfoList);
			}
			SpecialEnergyBarKeyItem keyItem3 = this.KeyItem;
			if (keyItem3 == null)
			{
				return;
			}
			keyItem3.RefreshKeyEnable(this.GetKeyEnable(), false);
		}

		// Token: 0x06032194 RID: 205204 RVA: 0x00E08DD2 File Offset: 0x00E06FD2
		public void SetBarState(bool isAdvance = false)
		{
			this.IsAdvance = isAdvance;
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032195 RID: 205205 RVA: 0x00E08DE4 File Offset: 0x00E06FE4
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SlotItemList[i].UpdatePercent(curPercent * (float)this.SlotNum - (float)i, this.IsAdvance, false);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0401A895 RID: 108693
		private bool IsAdvance;
	}
}
