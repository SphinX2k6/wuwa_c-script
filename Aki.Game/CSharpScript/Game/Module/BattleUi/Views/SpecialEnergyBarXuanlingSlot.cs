using System;
using System.Collections.Generic;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E12 RID: 24082
	public class SpecialEnergyBarXuanlingSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D3DD RID: 250845 RVA: 0x00EC1CD2 File Offset: 0x00EBFED2
		protected override void OnStart()
		{
			this.OverrideColor = true;
			base.SetUseEffectMode(EUseEffectMode.EnergyDecreaseSegment);
			base.OnStart();
		}

		// Token: 0x0603D3DE RID: 250846 RVA: 0x00EC1CE8 File Offset: 0x00EBFEE8
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[i];
				float percent = Math.Max(0f, Math.Min(1f, curPercent));
				float discreteEffectPercent = this.GetDiscreteEffectPercent(percent);
				specialEnergyBarSlotItem.UpdatePercentWithFullEffect(discreteEffectPercent, discreteEffectPercent, isStart);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(this.GetKeyEnable(), isStart);
		}

		// Token: 0x0603D3DF RID: 250847 RVA: 0x00EC1D60 File Offset: 0x00EBFF60
		private float GetDiscreteEffectPercent(float percent)
		{
			return (float)Math.Ceiling((double)(Math.Max(0f, Math.Min(1f, percent)) * 41f)) / 41f;
		}

		// Token: 0x0603D3E0 RID: 250848 RVA: 0x00EC1D8A File Offset: 0x00EBFF8A
		protected override bool GetKeyEnable()
		{
			if (this.IsSpEnergyFull)
			{
				return base.GetKeyEnable();
			}
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			return ((attributeComponent != null) ? attributeComponent.GetCurrentValue(this.AttributeId) : 0f) > 0f && base.GetKeyEnable();
		}

		// Token: 0x0603D3E1 RID: 250849 RVA: 0x00EC1DC8 File Offset: 0x00EBFFC8
		public void SetKeyActionBySpEnergy(bool isFull, bool isStart = false)
		{
			if (this.IsSpEnergyFull == isFull && !isStart)
			{
				return;
			}
			this.IsSpEnergyFull = isFull;
			int action = (isFull > false) ? 1 : 0;
			List<SpecialEnergyBarKeyInfo> list = new List<SpecialEnergyBarKeyInfo>();
			foreach (SpecialEnergyBarKeyInfo specialEnergyBarKeyInfo in this.Config.KeyInfoList)
			{
				list.Add(new SpecialEnergyBarKeyInfo
				{
					Action = action,
					ActionType = specialEnergyBarKeyInfo.ActionType
				});
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.SwitchToKeyInfoList(list);
			}
			SpecialEnergyBarKeyItem keyItem2 = this.KeyItem;
			if (keyItem2 == null)
			{
				return;
			}
			keyItem2.RefreshKeyEnable(this.GetKeyEnable(), isStart);
		}

		// Token: 0x0401FEF7 RID: 130807
		private const int KEY_ACTION_SP_ENERGY_NOT_FULL = 0;

		// Token: 0x0401FEF8 RID: 130808
		private const int KEY_ACTION_SP_ENERGY_FULL = 1;

		// Token: 0x0401FEF9 RID: 130809
		private const int TOTAL_EFFECT_POINT_NUM = 41;

		// Token: 0x0401FEFA RID: 130810
		private bool IsSpEnergyFull;
	}
}
