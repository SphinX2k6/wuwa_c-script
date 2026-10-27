using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E0F RID: 24079
	public class SpecialEnergyBarXinYueHuSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D3C0 RID: 250816 RVA: 0x00EC1318 File Offset: 0x00EBF518
		protected override void OnStart()
		{
			this.OverrideColor = true;
			base.OnStart();
			FColor fcolor = FColor.FromHex(this.Config.EffectColor);
			FLinearColor flinearColor = new FLinearColor(ref fcolor);
			FColor fcolor2 = fcolor;
			if (!string.IsNullOrEmpty(this.Config.PointColor))
			{
				fcolor2 = FColor.FromHex(this.Config.PointColor);
			}
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetFullEffectPercent(1f);
				specialEnergyBarSlotItem.SetBarColor(fcolor);
				specialEnergyBarSlotItem.SetPointColor(fcolor2);
				specialEnergyBarSlotItem.SetBgAndUseEffectColor(flinearColor);
			}
		}

		// Token: 0x0603D3C1 RID: 250817 RVA: 0x00EC13D0 File Offset: 0x00EBF5D0
		protected override void RefreshBarPercent(bool isStart = false)
		{
			base.RefreshBarPercent(isStart);
			float curPercent = this.PercentMachine.GetCurPercent();
			Action<int, float> percentCallback = this.PercentCallback;
			if (percentCallback == null)
			{
				return;
			}
			percentCallback(this.Index, curPercent);
		}

		// Token: 0x0401FEE5 RID: 130789
		[Nullable(2)]
		public Action<int, float> PercentCallback;

		// Token: 0x0401FEE6 RID: 130790
		public int Index;
	}
}
