using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB4 RID: 19892
	public class SpecialEnergyBarBuLingSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06032004 RID: 204804 RVA: 0x00DFEB04 File Offset: 0x00DFCD04
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

		// Token: 0x06032005 RID: 204805 RVA: 0x00DFEB7C File Offset: 0x00DFCD7C
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

		// Token: 0x06032006 RID: 204806 RVA: 0x00DFEBD9 File Offset: 0x00DFCDD9
		public void SetState(bool leftState, bool rightState)
		{
			this.LeftState = leftState;
			this.RightState = rightState;
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032007 RID: 204807 RVA: 0x00DFEBF0 File Offset: 0x00DFCDF0
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

		// Token: 0x0401A785 RID: 108421
		private bool LeftState;

		// Token: 0x0401A786 RID: 108422
		private bool RightState;
	}
}
