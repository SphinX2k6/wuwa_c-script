using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD7 RID: 24023
	public class SpecialEnergyBarFeibiSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D0F1 RID: 250097 RVA: 0x00EB02BC File Offset: 0x00EAE4BC
		protected override void OnStart()
		{
			SpecialEnergyBarInfo config = this.Config;
			if (!string.IsNullOrEmpty((config != null) ? config.EffectColor : null))
			{
				FColor fcolor = FColor.FromHex(this.Config.EffectColor);
				FLinearColor flinearColor = new FLinearColor(ref fcolor);
				foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
				{
					specialEnergyBarSlotItem.SetBarColor(fcolor);
					specialEnergyBarSlotItem.SetChangeEffectColor(flinearColor);
				}
			}
			base.OnStart();
		}

		// Token: 0x0603D0F2 RID: 250098 RVA: 0x00EB0350 File Offset: 0x00EAE550
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[i];
				float num = MathF.Floor((2f * curPercent - (float)i) * 19f) / 19f;
				num = MathF.Max(num, 0f);
				num = MathF.Min(num, 1f);
				float num2 = num * 0.46341464f;
				specialEnergyBarSlotItem.UpdatePercentWithFullEffect(num, num2, isStart);
				if (this.LastPercent[i] > num2 && !isStart)
				{
					specialEnergyBarSlotItem.SetChangeEffectOffsetX(184.5f + 369f * num2);
					specialEnergyBarSlotItem.PlayChangeEffectWithPercent(this.LastPercent[i] - num2);
				}
				this.LastPercent[i] = num2;
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0401FD01 RID: 130305
		private const float EFFECT_BASE_PERCENT = 0.46341464f;

		// Token: 0x0401FD02 RID: 130306
		private const int TOTAL_POINT_NUM = 19;

		// Token: 0x0401FD03 RID: 130307
		private const float CHANGE_EFFECT_OFFSET_X = 184.5f;

		// Token: 0x0401FD04 RID: 130308
		private const float CHANGE_EFFECT_WIDTH = 369f;

		// Token: 0x0401FD05 RID: 130309
		[Nullable(1)]
		private readonly float[] LastPercent = new float[2];
	}
}
