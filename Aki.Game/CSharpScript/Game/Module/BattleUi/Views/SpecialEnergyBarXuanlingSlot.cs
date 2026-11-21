using System;
using System.Collections.Generic;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DF7 RID: 19959
	public class SpecialEnergyBarXuanlingSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603236C RID: 205676 RVA: 0x00E13232 File Offset: 0x00E11432
		protected override void OnStart()
		{
			this.OverrideColor = true;
			base.SetUseEffectMode(EUseEffectMode.EnergyDecreaseSegment);
			base.OnStart();
		}

		// Token: 0x0603236D RID: 205677 RVA: 0x00E13248 File Offset: 0x00E11448
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

		// Token: 0x0603236E RID: 205678 RVA: 0x00E132C0 File Offset: 0x00E114C0
		private float GetDiscreteEffectPercent(float percent)
		{
			return (float)Math.Ceiling((double)(Math.Max(0f, Math.Min(1f, percent)) * 41f)) / 41f;
		}

		// Token: 0x0603236F RID: 205679 RVA: 0x00E132EA File Offset: 0x00E114EA
		protected override bool GetKeyEnable()
		{
			if (this.IsSpEnergyFull)
			{
				return base.GetKeyEnable();
			}
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			return ((attributeComponent != null) ? attributeComponent.GetCurrentValue(this.AttributeId) : 0f) > 0f && base.GetKeyEnable();
		}

		// Token: 0x06032370 RID: 205680 RVA: 0x00E13328 File Offset: 0x00E11528
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

		// Token: 0x0401A9BE RID: 108990
		private const int KEY_ACTION_SP_ENERGY_NOT_FULL = 0;

		// Token: 0x0401A9BF RID: 108991
		private const int KEY_ACTION_SP_ENERGY_FULL = 1;

		// Token: 0x0401A9C0 RID: 108992
		private const int TOTAL_EFFECT_POINT_NUM = 41;

		// Token: 0x0401A9C1 RID: 108993
		private bool IsSpEnergyFull;
	}
}
