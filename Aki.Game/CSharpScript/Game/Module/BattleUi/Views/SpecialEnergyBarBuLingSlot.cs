using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD0 RID: 24016
	public class SpecialEnergyBarBuLingSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D08D RID: 249997 RVA: 0x00EADC10 File Offset: 0x00EABE10
		protected override void OnStart()
		{
			this.OverrideColor = false;
			SpecialEnergyBarInfo config = this.Config;
			if (!string.IsNullOrEmpty((config != null) ? config.EffectColor : null))
			{
				this.SetColor(0, this.Config.EffectColor, this.Config.PointColor);
				this.SetColor(1, this.Config.OtherEffectColorList[0], this.Config.PointColorList[1]);
			}
			base.OnStart();
		}

		// Token: 0x0603D08E RID: 249998 RVA: 0x00EADC88 File Offset: 0x00EABE88
		[NullableContext(1)]
		private void SetColor(int index, string effectColorStr, string pointColorStr)
		{
			FColor fcolor = FColor.FromHex(effectColorStr);
			FLinearColor flinearColor = new FLinearColor(ref fcolor);
			FColor fcolor2 = FColor.FromHex(pointColorStr);
			this.SlotItemList[index].SetBarColor(fcolor);
			this.SlotItemList[index].SetPointColor(fcolor2);
			this.SlotItemList[index].SetFullEffectColor(flinearColor, false);
		}

		// Token: 0x0603D08F RID: 249999 RVA: 0x00EADCE5 File Offset: 0x00EABEE5
		public void SetState(bool leftState, bool rightState)
		{
			this.LeftState = leftState;
			this.RightState = rightState;
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D090 RID: 250000 RVA: 0x00EADCFC File Offset: 0x00EABEFC
		protected override void RefreshBarPercent(bool isStart = false)
		{
			bool enable = this.LeftState && this.RightState;
			this.SlotItemList[0].UpdatePercent(this.LeftState ? 1f : 0f, false, false);
			this.SlotItemList[1].UpdatePercent(this.RightState ? 1f : 0f, false, false);
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(enable, isStart);
		}

		// Token: 0x0401FCC8 RID: 130248
		private bool LeftState;

		// Token: 0x0401FCC9 RID: 130249
		private bool RightState;
	}
}
