using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DEC RID: 24044
	public class SpecialEnergyBarLuhesSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D204 RID: 250372 RVA: 0x00EB7804 File Offset: 0x00EB5A04
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

		// Token: 0x0603D205 RID: 250373 RVA: 0x00EB7892 File Offset: 0x00EB5A92
		public void SetBarState(bool isAdvance = false)
		{
			this.IsAdvance = isAdvance;
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D206 RID: 250374 RVA: 0x00EB78A4 File Offset: 0x00EB5AA4
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

		// Token: 0x0401FDCE RID: 130510
		private bool IsAdvance;
	}
}
