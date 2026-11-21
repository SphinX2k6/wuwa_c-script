using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD5 RID: 19925
	public class SpecialEnergyBarLuoselaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x060321AC RID: 205228 RVA: 0x00E09594 File Offset: 0x00E07794
		protected override void OnStart()
		{
			base.OnStart();
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				SpecialEnergyBarLuoselaSlotItem specialEnergyBarLuoselaSlotItem = specialEnergyBarSlotItem as SpecialEnergyBarLuoselaSlotItem;
				if (specialEnergyBarLuoselaSlotItem != null)
				{
					specialEnergyBarLuoselaSlotItem.SetFullEffectPercent(1f);
				}
			}
		}

		// Token: 0x060321AD RID: 205229 RVA: 0x00E095FC File Offset: 0x00E077FC
		[NullableContext(1)]
		protected override UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarLuoselaSlot.<InitSlotItem>d__3 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarLuoselaSlot.<InitSlotItem>d__3>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x060321AE RID: 205230 RVA: 0x00E09648 File Offset: 0x00E07848
		public void SwitchPointColor(bool enhanced)
		{
			int num = (enhanced > false) ? 1 : 0;
			FColor fcolor = FColor.FromHex((this.Config != null && num < this.Config.PointColorList.Length) ? this.Config.PointColorList[num] : "ffffff");
			FLinearColor flinearColor = FLinearColor.FromSRGBColor(fcolor);
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetPointColor(fcolor);
				specialEnergyBarSlotItem.SetBarColor(fcolor);
				specialEnergyBarSlotItem.SetFullEffectColor(flinearColor, false);
			}
		}

		// Token: 0x060321AF RID: 205231 RVA: 0x00E096EC File Offset: 0x00E078EC
		[NullableContext(2)]
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
				if (keyItem2 == null)
				{
					return;
				}
				keyItem2.SwitchToKeyInfoList(this.Config.KeyInfoList);
			}
		}

		// Token: 0x060321B0 RID: 205232 RVA: 0x00E09728 File Offset: 0x00E07928
		public void SetSlotUlt(bool b)
		{
			if (this.IsUlt == b)
			{
				return;
			}
			this.IsUlt = b;
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarLuoselaSlotItem specialEnergyBarLuoselaSlotItem = this.SlotItemList[i] as SpecialEnergyBarLuoselaSlotItem;
				if (specialEnergyBarLuoselaSlotItem != null)
				{
					specialEnergyBarLuoselaSlotItem.SetSlotItemUlt(b, i <= this.PointIndex);
				}
			}
			this.RefreshBarPercent(false);
		}

		// Token: 0x060321B1 RID: 205233 RVA: 0x00E0978C File Offset: 0x00E0798C
		public void SetSlotPoint(int pointIndex)
		{
			this.PointIndex = pointIndex;
		}

		// Token: 0x0401A8A5 RID: 108709
		private bool IsUlt;

		// Token: 0x0401A8A6 RID: 108710
		private int PointIndex;
	}
}
