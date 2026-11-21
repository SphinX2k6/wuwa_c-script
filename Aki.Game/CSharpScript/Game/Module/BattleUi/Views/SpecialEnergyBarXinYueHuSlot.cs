using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DF4 RID: 19956
	public class SpecialEnergyBarXinYueHuSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603234F RID: 205647 RVA: 0x00E12878 File Offset: 0x00E10A78
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

		// Token: 0x06032350 RID: 205648 RVA: 0x00E12930 File Offset: 0x00E10B30
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

		// Token: 0x0401A9AC RID: 108972
		[Nullable(2)]
		public Action<int, float> PercentCallback;

		// Token: 0x0401A9AD RID: 108973
		public int Index;
	}
}
